using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WinFormsPractice.Model;

namespace WinFormsPractice.View
{
    public partial class ContactControl : UserControl
    {
        private string imageFile;
        public ContactControl()
        {
            InitializeComponent();
            InitializeEmptyContactControls();
        }

        public ContactControl(Contact contact, bool isReadOnly = true)
        {
            InitializeComponent();
            InitializeContactControls(contact, isReadOnly);
        }

        public Contact GetContact()
        {
            return new Contact
            {
                Name = this.nameControl.GetFullName(),
                HomeAddress = this.addressControl.GetAddress(),
                Numbers = this.cellPhonesControl.GetCellphones(),
                ImageFile = imageFile
            };
        }

        private void InitializeContactControls(Contact contact, bool isReadOnly)
        {
            this.nameControl = new NameControl(contact.Name);
            this.addressControl = new AddressControl(contact.HomeAddress);
            this.cellPhonesControl = new CellPhonesControl(contact.Numbers.Numbers, isReadOnly);
            this.contactImage = new PictureBox();
            // 
            // nameControl
            // 
            this.nameControl.Location = new System.Drawing.Point(0, 0);
            this.nameControl.Name = "nameControl";
            this.nameControl.Size = new System.Drawing.Size(355, 99);
            this.nameControl.TabIndex = 0;
            // 
            // addressControl
            // 
            this.addressControl.Location = new System.Drawing.Point(374, 150);
            this.addressControl.Name = "addressControl";
            this.addressControl.Size = new System.Drawing.Size(362, 191);
            this.addressControl.TabIndex = 2;
            // 
            // cellPhonesControl
            // 
            this.cellPhonesControl.Location = new System.Drawing.Point(0, 105);
            this.cellPhonesControl.Name = "cellPhonesControl";
            this.cellPhonesControl.Size = new System.Drawing.Size(297, 196);
            this.cellPhonesControl.TabIndex = 1;
            //
            // contactImage
            //
            this.contactImage.Location = new Point(400, 0);
            this.contactImage.Size = new Size(140, 140);

            if(File.Exists(contact.ImageFile))
            {
                this.contactImage.Image = Image.FromFile(contact.ImageFile);
                imageFile = contact.ImageFile;
            }
            else
            {
                this.contactImage.Image = Properties.Resources.NoPhoto;
            }
            this.contactImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.contactImage.BorderStyle = BorderStyle.FixedSingle;


            this.Controls.Add(this.nameControl);
            this.Controls.Add(this.cellPhonesControl);
            this.Controls.Add(this.addressControl);
            this.Controls.Add(this.contactImage);

            //
            // addImageButton
            //
            if(!isReadOnly)
            {
                this.addImageButton = new Button();
                this.addImageButton.Name = "addImageButton";
                this.addImageButton.UseVisualStyleBackColor = true;
                this.addImageButton.Text = "Add new image";
                this.addImageButton.Location = new Point(550, 110);
                this.addImageButton.Size = new Size(180, 30);
                resources.ApplyResources(this.addImageButton, "addImageButton");
                this.addImageButton.Click += AddImageButton_Click;
                this.Controls.Add(this.addImageButton);
            }

            foreach (Control control in this.Controls)
            {
                foreach (Control nestedControl in control.Controls)
                {
                    if (nestedControl is TextBox)
                    {
                        (nestedControl as TextBox).ReadOnly = isReadOnly;
                    }
                }
            }
        }

        private void InitializeEmptyContactControls()
        {
            this.nameControl = new NameControl();
            this.addressControl = new AddressControl();
            this.cellPhonesControl = new CellPhonesControl(null, false);
            this.contactImage = new PictureBox();
            // 
            // nameControl
            // 
            this.nameControl.Location = new System.Drawing.Point(0, 0);
            this.nameControl.Name = "nameControl";
            this.nameControl.Size = new System.Drawing.Size(355, 99);
            this.nameControl.TabIndex = 0;
            // 
            // addressControl
            // 
            this.addressControl.Location = new System.Drawing.Point(374, 150);
            this.addressControl.Name = "addressControl";
            this.addressControl.Size = new System.Drawing.Size(362, 191);
            this.addressControl.TabIndex = 2;
            // 
            // cellPhonesControl
            // 
            this.cellPhonesControl.Location = new System.Drawing.Point(0, 105);
            this.cellPhonesControl.Name = "cellPhonesControl";
            this.cellPhonesControl.Size = new System.Drawing.Size(297, 196);
            this.cellPhonesControl.TabIndex = 1;
            //
            // contactImage
            //
            this.contactImage.Location = new System.Drawing.Point(400, 0);
            this.contactImage.Size = new System.Drawing.Size(140, 140);
            this.contactImage.Image = Properties.Resources.NoPhoto;
            this.contactImage.SizeMode = PictureBoxSizeMode.Zoom;
            this.contactImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            //
            // addImageButton
            //
            this.addImageButton = new Button();
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Text = "Add new image";
            this.addImageButton.Location = new Point(550, 110);
            this.addImageButton.Size = new Size(180, 30);
            resources.ApplyResources(this.addImageButton, "addImageButton");
            this.addImageButton.Click += AddImageButton_Click;

            this.Controls.Add(this.nameControl);
            this.Controls.Add(this.cellPhonesControl);
            this.Controls.Add(this.addressControl);
            this.Controls.Add(this.contactImage);
            this.Controls.Add(this.addImageButton);
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string path = Path.Combine(Settings.FilePath, "images");

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);


                try
                {
                    string contactImageFile = Path.Combine(path, $"{DateTime.Now.ToString().Replace(':', '_')}.jpg");

                    File.Copy(dialog.FileName, contactImageFile);
                    imageFile = contactImageFile;

                    this.contactImage.Image = Image.FromFile(contactImageFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}

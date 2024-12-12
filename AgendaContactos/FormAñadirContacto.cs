using System;
using System.Windows.Forms;

namespace AgendaContactos
{
    public partial class FormAñadirContacto : Form
    {
        private TextBox txtName;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Button btnVolver;
        private Button btnAdd;

        public FormAñadirContacto()
        {
            InitializeComponent();
        }


  
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de añadir contacto.");
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(279, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 22);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(351, 168);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(163, 22);
            this.txtPhone.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(351, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "AÑADIR";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NÚMERO DE TELÉFONO:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(202, 229);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormAñadirContacto
            // 
            this.ClientSize = new System.Drawing.Size(655, 415);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Name = "FormAñadirContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;

            if (!string.IsNullOrEmpty(name) && ClasePrograma.checkPhone(phone))
            {
                ClaseContacto newContact = new ClaseContacto(name, phone);
                ClasePrograma.Contacts.Add(newContact);
                MessageBox.Show("Contacto añadido correctamente.", "Éxito");
            }
            else
            {
                MessageBox.Show("Por favor, introduce un nombre válido y un teléfono válido.", "Error");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
          

            this.Close(); // Cierra el formulario actual
            Application.OpenForms["MainForm"].Show(); // Muestra el formulario principal ya abierto

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

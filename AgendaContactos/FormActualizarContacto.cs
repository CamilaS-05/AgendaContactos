using System;
using System.Windows.Forms;

namespace AgendaContactos
{
    public partial class FormActualizarContacto : Form
    {
        private TextBox txtName;
        private TextBox txtPhoneSearch;
        private Button btnUpdate;
        private TextBox txtBuscarPorContacto;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnVolver;
        private TextBox txtPhone;

        public FormActualizarContacto()
        {
            InitializeComponent();
        }

      
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de actualizar contacto.");
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBuscarPorContacto = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(295, 171);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Location = new System.Drawing.Point(445, 131);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(126, 22);
            this.txtPhoneSearch.TabIndex = 1;
            this.txtPhoneSearch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(383, 211);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(135, 22);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(393, 278);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "ACTUALIZAR";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // txtBuscarPorContacto
            // 
            this.txtBuscarPorContacto.Location = new System.Drawing.Point(383, 91);
            this.txtBuscarPorContacto.Name = "txtBuscarPorContacto";
            this.txtBuscarPorContacto.Size = new System.Drawing.Size(156, 22);
            this.txtBuscarPorContacto.TabIndex = 4;
            this.txtBuscarPorContacto.TextChanged += new System.EventHandler(this.buscarPorContacto_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "BUSCAR POR NOMBRE: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "BUSCAR POR NÚMERO DE TELÉFONO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "NOMBRE:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "NÚMERO DE TELÉFONO:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(231, 278);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(103, 23);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormActualizarContacto
            // 
            this.ClientSize = new System.Drawing.Size(789, 445);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPorContacto);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPhoneSearch);
            this.Controls.Add(this.txtName);
            this.Name = "FormActualizarContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string phoneSearch = txtPhoneSearch.Text;
            string contactNameSearch = txtBuscarPorContacto.Text;
            string newName = txtName.Text;
            string newPhone = txtPhone.Text;

            // Buscar por número de teléfono si el campo no está vacío
            var contact = !string.IsNullOrEmpty(phoneSearch)
                ? ClasePrograma.Contacts.Find(c => c.Phone == phoneSearch)
                : null;

            // Si no se encuentra por número de teléfono, buscar por nombre si se ingresó
            if (contact == null && !string.IsNullOrEmpty(contactNameSearch))
            {
                contact = ClasePrograma.Contacts.Find(c => c.Name.Equals(contactNameSearch, StringComparison.OrdinalIgnoreCase));
            }

            if (contact != null)
            {
                if (!string.IsNullOrEmpty(newName)) contact.Name = newName;
                if (ClasePrograma.checkPhone(newPhone)) contact.Phone = newPhone;

                MessageBox.Show("Contacto actualizado correctamente.", "Éxito");
            }
            else
            {
                MessageBox.Show("No se encontró ningún contacto con el criterio de búsqueda proporcionado.", "Error");
            }
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscarPorContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
            Application.OpenForms["MainForm"].Show(); // Muestra el formulario principal ya abierto
        }

    }
}

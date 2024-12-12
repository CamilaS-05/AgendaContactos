using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaContactos
{
    public partial class FormBuscarContacto : Form
    {
        private Label label2;
        private Button btnVolver;
        private TextBox txtPhoneSearch;
        private Button btnSearch;
        private Label label1;
        private TextBox txtBuscarPorContacto;

        public FormBuscarContacto()
        {
            InitializeComponent();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phone = txtPhoneSearch.Text;

            // Validar que el número de teléfono no esté vacío
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Por favor, introduce un número de teléfono válido.", "Error");
                return;
            }

            // Buscar contacto en la lista global
            var contact = ClasePrograma.Contacts.Find(c => c.Phone == phone);

            if (contact != null)
            {
                MessageBox.Show($"Nombre: {contact.Name}\nTeléfono: {contact.Phone}", "Contacto encontrado");
            }
            else
            {
                MessageBox.Show("No se encontró ningún contacto con ese número de teléfono.", "Error");
            }
        }

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarPorContacto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "BUSCAR POR NÚMERO DE TELÉFONO:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(272, 247);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Location = new System.Drawing.Point(493, 180);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(163, 22);
            this.txtPhoneSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(447, 247);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "BUSCAR POR NOMBRE:";
            // 
            // txtBuscarPorContacto
            // 
            this.txtBuscarPorContacto.Location = new System.Drawing.Point(407, 138);
            this.txtBuscarPorContacto.Name = "txtBuscarPorContacto";
            this.txtBuscarPorContacto.Size = new System.Drawing.Size(168, 22);
            this.txtBuscarPorContacto.TabIndex = 9;
            // 
            // FormBuscarContacto
            // 
            this.ClientSize = new System.Drawing.Size(863, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtPhoneSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarPorContacto);
            this.Name = "FormBuscarContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtPhoneSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string phone = txtPhoneSearch.Text;
            string contactName = txtBuscarPorContacto.Text;

            if (string.IsNullOrWhiteSpace(phone) && string.IsNullOrWhiteSpace(contactName))
            {
                MessageBox.Show("Por favor, introduce un número de teléfono o un nombre válido.", "Error");
                return;
            }

            var contact = !string.IsNullOrWhiteSpace(phone)
                ? ClasePrograma.Contacts.Find(c => c.Phone == phone)
                : ClasePrograma.Contacts.Find(c => c.Name.Equals(contactName, StringComparison.OrdinalIgnoreCase));

            if (contact != null)
            {
                MessageBox.Show($"Nombre: {contact.Name}\nTeléfono: {contact.Phone}", "Contacto encontrado");
            }
            else
            {
                MessageBox.Show("No se encontró ningún contacto con el criterio de búsqueda proporcionado.", "Error");
            }
        }

        private void txtBuscarPorContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Close(); // Cierra el formulario actual
            Application.OpenForms["MainForm"].Show(); // Muestra el formulario principal ya abierto
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_2(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {

        }
    }
}
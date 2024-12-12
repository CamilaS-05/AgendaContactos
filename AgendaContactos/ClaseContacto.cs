using System;

namespace AgendaContactos
{
    public class ClaseContacto
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public ClaseContacto() // Constructor vacío
        {
            Name = "";
            Phone = "";
        }

        public ClaseContacto(string name, string phone) // Constructor parametrizado
        {
            Name = name;
            Phone = phone;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ClaseContacto other = (ClaseContacto)obj;
            return Name == other.Name && Phone == other.Phone;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Phone);
        }
    }
}

using SuCosmetica.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuCosmetica.Forms
{
    public partial class ContactDetails : Form
    {
        DateTime birthday;
        private string firstname;
        private string lastname;
        private long cellphone;
        private Locality location;
        DateTime firstTime;
        DateTime nextTurn;
        

        public ContactDetails()
        {
            
            firstname = String.Empty;
            lastname = String.Empty;
            cellphone = 0;
            location = Locality.Adrogue;
            firstTime = DateTime.Now;
            nextTurn = DateTime.Now;
            birthday = DateTime.Now;
        }

        public ContactDetails(DateTime birthday, string firstname, string lastname, long cellphone, Locality location, DateTime firstTime, DateTime nextTurn)
        {
            this.birthday = birthday;
            this.firstname = firstname;
            this.lastname = lastname;
            this.cellphone = cellphone;
            this.location = location;
            this.firstTime = firstTime;
            this.nextTurn = nextTurn;
        }
        public DateTime Birthday
        {
            get { return birthday; }

            set { birthday = value; }
        }

        public string Firstname
        {
            get { return firstname; }

            set { firstname = value; }
        }

        public long Cellphone
        {
            get { return cellphone; }

            set { cellphone = value; }
        }

        public Locality Location
        {
            get { return location; }

            set { location = value; }
        }

        public string Lastname
        {
            get { return lastname; }

            set { lastname = value; }
        }

        public DateTime FirstTime
        {
            get { return firstTime; }
            set { firstTime = value; }
        }

        public DateTime NextTurn
        {
            get { return nextTurn; }
            set { nextTurn = value; }
        }
    }
}
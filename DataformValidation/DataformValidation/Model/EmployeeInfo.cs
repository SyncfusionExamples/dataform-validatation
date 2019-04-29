using Syncfusion.XForms.DataForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace DataformValidation
{
    public class EmployeeInfo : INotifyDataErrorInfo, INotifyPropertyChanged
    {
        private int employeeID;
        private string name;
        private string _Title;
        private string contactNumber;
        private string email;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public EmployeeInfo()
        {

        } 

        [Range(1000, 1500, ErrorMessage = "EmployeeID should be between 1000 and 1500")]
        public int EmployeeID
        {
            get { return this.employeeID; }
            set
            {
                this.employeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }

        [StringLength(10, ErrorMessage = "Phone number should have 10 digits.")]
        public string ContactNumber
        {
            get
            {
                return this.contactNumber;
            }

            set
            {
                this.contactNumber = value;
                this.RaisePropertyChanged("ContactNumber");
            }
        }

        [DisplayOptions(ValidMessage = "Name length is enough")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name should not be empty")]
        [StringLength(10, ErrorMessage = "Name should not exceed 10 characters")]
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        [MinLength(5, ErrorMessage = "Title should be at least 5 characters.")]
        [MaxLength(15, ErrorMessage = "Title should not exceed 15 characters.")]
        public string Title
        {
            get { return this._Title; }
            set
            {
                this._Title = value;
                this.RaisePropertyChanged("Title");
                this.GetErrors("Title");
            }
        }

        [EmailAddress(ErrorMessage = "Please enter a valid e-mail id.")]
        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
                this.RaisePropertyChanged("Email");
                this.GetErrors("Email");
            }
        }

        private Regex passwordRegExp = new Regex("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})");

        private string password;
        [DataType(DataType.Password)]
        public string Password
        {
            get { return this.password; }
            set
            {
                this.password = value;
                this.RaisePropertyChanged("Password");
            }
        }

        [DateRange(MinYear = 2010, MaxYear = 2017, ErrorMessage = "Joined date is invalid")]
        public DateTime JoinedDate { get; set; }


        [Display(AutoGenerateField = false)]
        public bool HasErrors
        {
            get
            {
                return false;
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public IEnumerable GetErrors(string propertyName)
        {
            var list = new List<string>();
            if (propertyName.Equals("Title"))
            {
                if (this.Title.Contains("Marketing"))
                    list.Add("Marketing is not allowed");
            }
            else if(propertyName.Equals("Password"))
            {
                if (!this.passwordRegExp.IsMatch(this.Password))
                {
                    list.Add("Password must contain at least one digit, one uppercase character and one special symbol");
                } 
            }
            return list;
        } 
    } 
}

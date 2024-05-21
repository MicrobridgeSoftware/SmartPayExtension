using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMARTPayExtension.TechLibrary
{
    public class CurrentUserCredentials
    {
        private List<CurrentUserCredentials> CurrentUserValues = new List<CurrentUserCredentials>(); 
        
        private string _menuName;
        private string _nodeName;
        private string _userName;
        private string _firstName;
        private string _lastName;
        private string _middleName;
        private byte[] _imageData;
        private bool _expireAccount;

        public string getMenuName()
        {
            return this._menuName;
        }
        private void setMenuName(string mnuName)
        {
            this._menuName = mnuName;
        }

        public string getNodeName()
        {
            return this._nodeName;
        }
        private void setNodeName(string ndeName)
        {
            this._nodeName = ndeName;
        }

        public string getUserName()
        {
            return this._userName;
        }
        private void setUserName(string uName)
        {
            this._userName = uName;
        }

        public string getFirstName()
        {
            return this._firstName;
        }
        private void setFirstName(string fName)
        {
            this._firstName = fName;
        }

        public string getLastName()
        {
            return this._lastName;
        }
        private void setLastName(string lName)
        {
            this._lastName = lName;
        }

        public string getMiddleName()
        {
            return this._middleName;
        }
        private void setMiddleName(string mName)
        {
            this._middleName = mName;
        }

        public byte[] getImageData()
        {
            return this._imageData;
        }
        public void setImageData(byte[] idata)
        {
            this._imageData = idata;
        }

        public bool getAccountConfig()
        {
            return this._expireAccount;
        }
        public void setAccountConfig(bool expire)
        {
            this._expireAccount = expire;
        }

        public void _userDetails(string menuName, string nodeName, string userName, string firstName, string lastName, string middleName)
        {
            setMenuName(menuName);
            setNodeName(nodeName);
            setUserName(userName);
            setFirstName(firstName);
            setLastName(lastName);
            setMiddleName(middleName);

            CurrentUserValues.Add(new CurrentUserCredentials
            {
                _firstName = firstName,
                _lastName = lastName,
                _userName = userName, 
                _nodeName = nodeName, 
                _menuName = menuName 
            });
        }

        public List<CurrentUserCredentials> _userCredentials()
        {
            return this.CurrentUserValues;
        }        

        public string _loggedInUserName()
        {
            return this._userName;
        }
    }
}
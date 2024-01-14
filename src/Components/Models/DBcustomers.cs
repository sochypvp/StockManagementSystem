using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.DBClasses
{
    public class DBcustomers
    {
        public string cusId { get; set; }
        public string cusName { get; set;}
        public string cusAddress { get; set;}
        public string cusPosition { get; set;}
        public string cusPhoneNumber { get; set;}
        public DBcustomers() { }
        public DBcustomers(string cusName, string cusAddress, string cusPosition, string cusPhoneNumber)
        {
            this.cusName = cusName;
            this.cusAddress = cusAddress;
            this.cusPosition = cusPosition;
            this.cusPhoneNumber = cusPhoneNumber;
        }
        public DBcustomers(string cusId, string cusName, string cusAddress, string cusPosition, string cusPhoneNumber)
        {
            this.cusId = cusId;
            this.cusName = cusName;
            this.cusAddress = cusAddress;
            this.cusPosition = cusPosition;
            this.cusPhoneNumber = cusPhoneNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnet_project
{
    class Admin
    {
       

        public void login()
        {

        }
        //manage customer
        private void add_customer()
        {

        }
        private void edit_customer()
        {

        }
        private void view_customer()
        {

        }
        private void list_customer()
        {

        }
        //manage courier
        private void add_courier()
        {

        }
        private void view_courier()
        {

        }
        private void list_courier()
        {

        }
        private void filter_courier()
        {

        }
        //manage tracking
        private void add_tracking()
        {

        }
        private void list_tracking()
        {

        }
        private void filter_tracking()
        {

        }
        //manage offices
        private void add_offices()
        {

        }
        private void list_offices()
        {

        }
        private void filter_offices()
        {

        }
        //manage manager
        private void add_manager()
        {

        }
        private void list_manager()
        {

        }
        private void filter_manager()
        {

        }
        //manage shipment
        private void add_shipment()
        {

        }
        private void list_shipment()
        {

        }
        private void filter_shipment()
        {

        }
        //manage reports
        private void customer_report()
        {

        }
        private void courier_report()
        {

        }
        private void tracking_report()
        {

        }
        private void offices_report()
        {

        }
        private void managers_report()
        {

        }
        private void shipment_report()
        {

        }

    }
    class Manager
    {
        String account_id;
        String manager_id;
        String name;
        String date_of_birth;
        String gender;
        String emailid;
        String phone_no;
        String branch;

        public void login()
        {

        }
        //manage employee
        private void add_employee()
        {

        }
        private void edit_employee()
        {

        }
        private void view_employee()
        {

        }
        private void list_employee()
        {

        }
        //manage payslip
        private void generatePaySlip()
        {

        }
        //generate consignment note
        private void generateConsignmentNote()
        {
            String origin;
            String destination;
            String date;
            bool non_docs;
            bool docs;
            String booked_by;
            
            String declared_value;
            bool insurance;
            float weight_kg;
            float weight_gm;
            int pkgs;
            float service_tax;
            float total_amount;
        }

    }
    class Employee
    {
        String account_id;
        String employee_id;
            String employee_name;
            String date_of_birth;
            String address;
            String branch;
        String gender;
        String phone_no;
        String emailid;

    }
}

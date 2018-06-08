using GreenMinded.APIGreenMinded;
using GreenMinded.Helper_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GreenMinded.View.Interface
{
    public class InterfaceViewModel : ObservableObject, IPageViewModel
    {
        private string name;
        public string Name { get => name; set => name = value; }

        public List<SPI_QuestionAnswer_Result> ListQuestions { get => listQuestions; set => listQuestions = value; }
        public IList<SPI_QuestionAnswer_Result> ListQuestionAnswer { get => listQuestionAnswer; set => listQuestionAnswer = value; }
        public IList<stations> ListStation { get => listStation; set => listStation = value; }

        private List<SPI_QuestionAnswer_Result> listQuestions = new List<SPI_QuestionAnswer_Result>();
        private IList<SPI_QuestionAnswer_Result> listQuestionAnswer;
        private IList<stations> listStation;

        public InterfaceViewModel()
        {
            //MessageBox.Show(GetMacAddress().ToString());
            AccessStation();
        }



        public string _Question;
        public string Question
        {
            get
            {
                if (_Question == null)
                {
                    _Question = listQuestions[0].label;
                }
                return _Question;
            }
        }

        public string _Response_left;
        public string Response_left
        {
            get
            {
                if (_Response_left == null)
                {
                    _Response_left = listQuestions[0].response_left;
                }
                return _Response_left;
            }
        }

        public string _Response_right;
        public string Response_right
        {
            get
            {
                if (_Response_right == null)
                {
                    _Response_right = listQuestions[0].response_right;
                }
                return _Response_right;
            }
        }

        //public void ChangeQuestion()
        //{
        //    if(date_Start == DateTime.Now)
        //    {
                
        //    }

        //}


        public void AccessStation()
        {
           
            using (APIGreenMinded.Service1Client api = new APIGreenMinded.Service1Client())
            {
                listQuestionAnswer = api.GetQuestionAnswer();
            }
            using (APIGreenMinded.Service1Client api = new APIGreenMinded.Service1Client())
            {
                ListStation = api.GetStation();
            }
            foreach (stations sta in ListStation) { 
            if(sta.mac_address == GetMacAddress().ToString())
                {
                    foreach(SPI_QuestionAnswer_Result queans in listQuestionAnswer) {
                        ListQuestions.Add(queans);
                    }
                }
              }
        }

        public static PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }

    }
}

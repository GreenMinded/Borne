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

        public List<SPI_QuestionAnswer_Result> ListQuestions { get => listQuestions; set { listQuestions = value; OnPropertyChanged("ListQuestions"); } } // Ajout d'un OnPropertyChange
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


        #region Properties Question
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
        #endregion

        public void ChangeQuestion()
        {
            using (APIGreenMinded.Service1Client api = new APIGreenMinded.Service1Client())
            {
                listQuestionAnswer = api.GetQuestionAnswer();
            }
            foreach (SPI_QuestionAnswer_Result queans in listQuestionAnswer)
            {
                if (DateTime.Now >= queans.date_start && DateTime.Now <= queans.date_end)
                {
                    ListQuestions.Clear();
                    AccessStation();
                }
            }

        }


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

                        if (DateTime.Now >= queans.date_start && DateTime.Now <= queans.date_end)
                        {
                            ListQuestions.Add(queans);
                        }
                        
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

        /* Fonctionne toutes les 5 secondes avec un timer en asynchrone( Timer à rajouter ) */
        public void DateActualise()
        {
            if (DateTime.Now > ListQuestions[0].date_end)
            {
                ChangeQuestion();
            }
        }

        /* Deux AsyncTask pour gérer le count des capteurs gauche et droit */
        

    }
}

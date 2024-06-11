using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    internal class Boernegruppe
    {
        private string _ageGroup;

        public string ID { get; private set; }
        public string Name { get; private set; }
        public string AgeGroup 
        { get { return _ageGroup; } 
          set { 
                
                switch (value) 
                {
                    case "pusling":
                        _ageGroup = "pusling";
                        break;
                    case "tumling":
                        _ageGroup = "tumling";
                        break;
                    case "pilt":
                        _ageGroup = "pilt";
                        break;
                    case "væbner":
                        _ageGroup = "væbner";
                        break;
                    case "seniorvæbner":
                        _ageGroup = "seniorvæbner";
                        break;
                    default:
                        _ageGroup = "Ingen relevant gruppe valgt";
                        break;


                }
            
            }
        
        }
        public int Participants { get; private set; }

        public Boernegruppe(string id, string name, string ageGroup, int participants)
        {
            ID = id;
            Name = name;
            AgeGroup = ageGroup;
            Participants = participants;
        }


        public override string ToString() {

            string message = "Jeres ID er " + ID + " Navn " + Name + " og aldersgruppen er" + AgeGroup ;
            return message;
        }
    }
}

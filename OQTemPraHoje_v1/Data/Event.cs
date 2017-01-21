using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Event
    {
        public enum EType
        {
            Music = 1,
            Theater,
            Gastronomy
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string Local { get; set; }
        public int Size { get; set; }
        public int Type { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public string DateFormated
        {
            get
            {
                if (Date <= DateTime.MinValue)
                    return string.Empty;

                return Date.Day.ToString() + " " + GetMonthInitial(Date.Month);
            }
        }

        public string TypeImagemName
        {
            get
            {
                switch ((EType)Type)
                {
                    case EType.Music:
                        return "guitar.png";
                    case EType.Theater:
                        return "-implementar-";
                    case EType.Gastronomy:
                        return "-implementar-";
                    default:
                        return string.Empty;
                }
            }
        }

        public static string GetMonthInitial(int month)
        {
            switch (month)
            {
                case 1:
                    return "JAN";
                case 2:
                    return "FEV";
                case 3:
                    return "MAR";
                case 4:
                    return "ABR";
                case 5:
                    return "MAI";
                case 6:
                    return "JUN";
                case 7:
                    return "JUL";
                case 8:
                    return "AGO";
                case 9:
                    return "SET";
                case 10:
                    return "OUT";
                case 11:
                    return "NOV";
                case 12:
                    return "DEZ";
                default:
                    return string.Empty;
            }
        }

        public static List<Event> GetHighlightEvents()
        {
            var listEvent = new List<Data.Event>();

            //Preechimento fixo para testes
            var event1 = new Data.Event();
            event1.Picture = "party3.jpg";
            event1.Name = "Baladinha Top";
            event1.Local = "Clube Juremaz";
            event1.Description = "À partir das 22:00. Entrada free até às 23:30. Na compra do ingresso antecipado, ganhe uma caipirinha de vinho.";
            event1.Date = DateTime.Now;
            listEvent.Add(event1);

            var event2 = new Data.Event();
            event2.Picture = "party1.jpg";
            event2.Name = "Baladinha Rocker";
            event2.Local = "John PUB";
            event2.Description = "À partir das 21:00. Entrada R$ 20,00 no local.";
            event2.Date = DateTime.Now.AddMonths(1);
            listEvent.Add(event2);

            var event3 = new Data.Event();
            event3.Picture = "party2.jpg";
            event3.Name = "Noite Flash Back";
            event3.Local = "Salão do Salto do Norte";
            event3.Description = "À partir das 22:00. Entrada free para elas. Na compra do ingresso antecipado, ganhe outro.";
            event3.Date = DateTime.Now.AddMonths(2);
            listEvent.Add(event3);
            //=============================

            return listEvent;
        }

        public static List<Event> GetEvents()
        {
            var listEvent = new List<Data.Event>();

            //Preechimento fixo para testes
            var event1 = new Data.Event();
            event1.Picture = "quadro1.jpg";
            event1.Name = "Show whatever";
            event1.Local = "No boteco do Seu Jorge";
            event1.Price = 100.00M;
            event1.Size = 2;
            event1.Description = "Duis mollis, est non commodo luctus, nisi erat porttitor ligula, est non commodo luctus, nisi erat porttitor ligula, est non commodo luctus, nisi erat porttitor ligula, est non commodo luctus, nisi erat porttitor ligula. Duis mollis, est non commodo luctus, nisi erat porttitor ligula, est non commodo luctus, nisi erat porttitor ligula, est non commodo luctus, nisi erat porttitor ligula, est non commodo luctus, nisi erat porttitor ligula.";
            event1.Date = DateTime.Now;
            event1.Type = EType.Music.GetHashCode();
            listEvent.Add(event1);

            var event2 = new Data.Event();
            event2.Picture = "quadro2.jpg";
            event2.Name = "Evento Gastronômico";
            event2.Local = "Parque Vila Germânica";
            event2.Price = 20.00M;
            event2.Size = 2;
            event2.Description = "Este é um evento gastronômico realizado no parque Vila Germânica de classificação livre. Estarão disponíveis pratos típicos alemães e italianos, além da típica linguiça Blumenau.";
            event2.Date = DateTime.Now.AddDays(2);
            event2.Type = EType.Music.GetHashCode();
            listEvent.Add(event2);

            var event3 = new Data.Event();
            event3.Picture = "quadro3.jpeg";
            event3.Name = "Final CBLOL";
            event3.Local = "Ginásio do Ibarapuera";
            event3.Price = 60.00M;
            event3.Size = 2;
            event3.Description = "Evento de classificação para maior de 14 anos. Venha prestigiar a grande final entre os dois maiores time do cenário brasileiro. Pain Game vs Keyd Stars. Abertura dos portões as 11:00.";
            event3.Date = DateTime.Now.AddDays(4);
            event3.Type = EType.Music.GetHashCode();
            listEvent.Add(event3);

            var event4 = new Data.Event();
            event4.Picture = "quadro4.jpg";
            event4.Name = "Os Barbixas";
            event4.Local = "Teatro Carlos Gomes";
            event4.Price = 80.00M;
            event4.Size = 2;
            event4.Description = "Peça da grande comédia conhecida nacionalmente e famosos pelos seus vídeos na internet. Classificação livre - Comédia.";
            event4.Date = DateTime.Now.AddDays(5);
            event4.Type = EType.Music.GetHashCode();
            listEvent.Add(event4);

            var event5 = new Data.Event();
            event5.Picture = "quadro5.jpg";
            event5.Name = "Festa Supimpa";
            event5.Local = "No lugar mágico";
            event5.Price = 25.99M;
            event5.Size = 4;
            event5.Description = "Festa mágina em um lugar secreto. Van disponível 2 horas antes do evento. Classificação +18";
            event5.Date = DateTime.Now.AddDays(6);
            event5.Type = EType.Music.GetHashCode();
            listEvent.Add(event5);

            var event6 = new Data.Event();
            event6.Name = "Apicultores Clandestinos";
            event6.Local = "Don PUB";
            event6.Price = 15.00M;
            event6.Size = 1;            
            event6.Date = DateTime.Now.AddDays(7);
            event6.Type = EType.Music.GetHashCode();
            listEvent.Add(event6);

            var event7 = new Data.Event();
            event7.Name = "Metallica Cover";
            event7.Local = "Obs BAR";
            event7.Price = 25.00M;
            event7.Size = 1;
            event7.Date = DateTime.Now.AddDays(8);
            event7.Type = EType.Music.GetHashCode();
            listEvent.Add(event7);

            listEvent.Add(event7);
            listEvent.Add(event1);   
            //=============================

            return listEvent;
        }

    }
}

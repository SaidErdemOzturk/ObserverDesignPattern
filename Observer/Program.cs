using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Nesne1 nesne1 = new Nesne1();
            IObser obser1 = new Uye1();
            nesne1.Register(obser1);

            Nesne2 nesne2 = new Nesne2();
            IObser obser2 = new Uye2();
            nesne2.Register(obser1);
            nesne2.Register(obser2);
            nesne1.fiyat = 50;
            nesne2.fiyat = 2;
            nesne2.fiyat = 20;
        }
    }
    interface ISubject
    {
        void Register(IObser obser);
        void DeRegister(IObser obser);
        void NotifyObserver();
    }
    interface IObser
    {
        void Update(int fiyat);
    }
    class Uye1 : IObser
    {
        public void Update(int fiyat)
        {
            Console.WriteLine(fiyat+" yeni fiyat");
        }
    }
    class Uye2 : IObser
    {
        public void Update(int fiyat)
        {
            Console.WriteLine(fiyat + " yeni fiyat");
        }
    }
    class Uye3 : IObser
    {
        public void Update(int fiyat)
        {
            Console.WriteLine(fiyat + " yeni fiyat");
        }
    }
    class Nesne1 : ISubject
    {
        private int _fiyat;
        public int fiyat
        {
            get
            {
                return _fiyat;
            }

            set
            {
                _fiyat = value;
                NotifyObserver();
            }
        }

        List<IObser> liste = new List<IObser>();
        
        public void DeRegister(IObser obser)
        {
            liste.Remove(obser);
        }

        public void NotifyObserver()
        {
            foreach (var item in liste)
            {
                item.Update(_fiyat);
                
            }
        }

        public void Register(IObser obser)
        {
            liste.Add(obser);
        }
        
    }
    class Nesne2 : ISubject
    {
        private int _fiyat;
        public int fiyat
        {
            get
            {
                return _fiyat;
            }

            set
            {
                _fiyat = value;
                NotifyObserver();
            }
        }

        List<IObser> liste = new List<IObser>();

        public void DeRegister(IObser obser)
        {
            liste.Remove(obser);
        }

        public void NotifyObserver()
        {
            foreach (var item in liste)
            {
                item.Update(_fiyat);

            }
        }

        public void Register(IObser obser)
        {
            liste.Add(obser);
        }
    }
    class Nesne3 : ISubject
    {
        private int _fiyat;
        public int fiyat
        {
            get
            {
                return _fiyat;
            }

            set
            {
                _fiyat = value;
                NotifyObserver();
            }
        }

        List<IObser> liste = new List<IObser>();

        public void DeRegister(IObser obser)
        {
            liste.Remove(obser);
        }

        public void NotifyObserver()
        {
            foreach (var item in liste)
            {
                item.Update(_fiyat);

            }
        }

        public void Register(IObser obser)
        {
            liste.Add(obser);

        }
    }
}

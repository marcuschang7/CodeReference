using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReference
{
    class AbstractFactory
    {
        static void Main(string[] args)
        {
            PhoneTypeChecker checker = new PhoneTypeChecker(MANUFACTURERS.SAMSUNG);

            checker.CheckProducts();

            Console.ReadLine();

            checker = new PhoneTypeChecker(MANUFACTURERS.HTC);

            checker.CheckProducts();
            Console.ReadLine();

            checker = new PhoneTypeChecker(MANUFACTURERS.NOKIA);

            checker.CheckProducts();
            Console.Read();
        }
    }


    interface IPhoneFactory
    {
        ISmart GetSmart();
        IDumb GetDumb();
    }

    class SamsungFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new GalaxyS2();
        }

        public IDumb GetDumb()
        {
            return new Primo();
        }
    }

    class HTCFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new Titan();
        }

        public IDumb GetDumb()
        {
            return new Genie();
        }
    }

    class NokiaFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new Lumia();
        }

        public IDumb GetDumb()
        {
            return new Asha();
        }
    }

    class Lumia : ISmart
    {
        public string Name()
        {
            return "Lumia";
        }
    }

    class Asha : IDumb
    {
        public string Name()
        {
            return "Asha";
        }
    }

    interface ISmart
    {
        string Name();
    }

    class GalaxyS2 : ISmart
    {
        public string Name()
        {
            return "GalaxyS2";
        }
    }

    class Primo : IDumb
    {
        public string Name()
        {
            return "Guru";
        }
    }

    interface IDumb
    {
        string Name();
    }

    class Titan : ISmart
    {
        public string Name()
        {
            return "Titan";
        }
    }

    class Genie : IDumb
    {
        public string Name()
        {
            return "Genie";
        }
    }

    enum MANUFACTURERS
    {
        SAMSUNG,
        HTC,
        NOKIA
    }
    class PhoneTypeChecker
    {
        //ISmart sam;
        //IDumb htc;
        IPhoneFactory factory; // This gets the correct class that was newed up from the switch statement
        MANUFACTURERS manu; // This stores that manufacture

        public PhoneTypeChecker(MANUFACTURERS m) // This is the constructor that takes in the manufacture
        {
            manu = m; //manufacture to field
        }

        public void CheckProducts() // This method is called to new up the correct class
        {
            switch (manu)
            {
                case MANUFACTURERS.SAMSUNG:
                    factory = new SamsungFactory();
                    break;
                case MANUFACTURERS.HTC:
                    factory = new HTCFactory();
                    break;
                case MANUFACTURERS.NOKIA:
                    factory = new NokiaFactory();
                    break;
            }

            Console.WriteLine(manu.ToString() + ":\nSmart Phone: " + factory.GetSmart().Name() + "\nDumb Phone: " + factory.GetDumb().Name());
        }
    }
}

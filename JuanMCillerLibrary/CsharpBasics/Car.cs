namespace CsharpBasics
{
    public class Car
    {
       
        private string _make;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        private int _year;

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public Car (string Make, string Model, int Year)
        {
            _make = Make;
            _model = Model;
            _year = Year;
        }
        public static string Accelerate(Car car)
        {
            return "This car is accelerating";
        }
    }
}

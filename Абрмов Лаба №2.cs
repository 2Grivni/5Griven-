using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_23v
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Coordinates
    {
        #region поля и инкапсуляция
        public double _latitude, _longitude, _height;
        #region инкапсуляция
        public double latitude
        {
            get; private set;
        }
        public double longitude
        {
            get; private set;
        }
        public double height
        {
            get; private set;
        }
        #endregion
        #endregion
        #region перегруженный конструктор
        public Coordinates() { }
        public Coordinates(double _latitude, double _longitude, double _height)
        {
            this._latitude = _latitude;
            this._longitude = _longitude;
            this._height = _height;
        }
        #endregion
        #region статичные и виртуальные методы
        public static double LatitudeMetod()
        {
            return 10;
        }
        public static double LongitudeMetod() 
            return 10;
        }
        public virtual double HeightMetod() 
        {
            return 3;
        }
        #endregion
    }
    #region Класс наследник и реализация интерфейсов
    class ClassImplementer : ICoordinates 
    {
        public double Latitude(double latitude)
        {
            return latitude;
        }
        public double Longitude(double longitude)
        {
            return longitude;
        }
        public double Height(double height)
        {
            return height;
        }
    }
    #endregion
    public interface ICoordinates 
    {
        double Latitude(double latitude);
        double Longitude(double longitude);
        double Height(double height);
    }
}
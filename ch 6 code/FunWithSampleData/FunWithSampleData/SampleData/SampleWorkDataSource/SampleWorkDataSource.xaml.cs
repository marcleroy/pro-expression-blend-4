﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Expression.Blend.SampleData.SampleWorkDataSource
{
    using System; 
    using System.ComponentModel;

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
    internal class SampleWorkDataSource { }
#else

    public class SampleWorkDataSource : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public SampleWorkDataSource()
        {
            try
            {
                Uri resourceUri = new Uri("/FunWithSampleData;component/SampleData/SampleWorkDataSource/SampleWorkDataSource.xaml", UriKind.RelativeOrAbsolute);
                System.Windows.Application.LoadComponent(this, resourceUri);
            }
            catch
            {
            }
        }

        private UserCollection _UserCollection = new UserCollection();

        public UserCollection UserCollection
        {
            get
            {
                return this._UserCollection;
            }
        }
    }

    public class UserCollectionItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _FirstName = string.Empty;

        public string FirstName
        {
            get
            {
                return this._FirstName;
            }

            set
            {
                if (this._FirstName != value)
                {
                    this._FirstName = value;
                    this.OnPropertyChanged("FirstName");
                }
            }
        }

        private string _LastName = string.Empty;

        public string LastName
        {
            get
            {
                return this._LastName;
            }

            set
            {
                if (this._LastName != value)
                {
                    this._LastName = value;
                    this.OnPropertyChanged("LastName");
                }
            }
        }

        private double _Age = 0;

        public double Age
        {
            get
            {
                return this._Age;
            }

            set
            {
                if (this._Age != value)
                {
                    this._Age = value;
                    this.OnPropertyChanged("Age");
                }
            }
        }

        private System.Windows.Media.ImageSource _Picture = null;

        public System.Windows.Media.ImageSource Picture
        {
            get
            {
                return this._Picture;
            }

            set
            {
                if (this._Picture != value)
                {
                    this._Picture = value;
                    this.OnPropertyChanged("Picture");
                }
            }
        }
    }

    public class UserCollection : System.Collections.ObjectModel.ObservableCollection<UserCollectionItem>
    { 
    }
#endif
}

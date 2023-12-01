using Laboratorio12_xamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using System.Xml.Linq;
using Xamarin.Forms;

namespace Laboratorio12_xamarin.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        int id;
        string title;
        string description;
        bool isCompleted;

        ObservableCollection<TaskModel> tasks;

        public ObservableCollection<TaskModel> Tasks
        {
            get { return tasks; }
            set
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }
        
        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsCompleted
        {
            get { return isCompleted; }
            set
            {
                if (isCompleted != value)
                {
                    isCompleted = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Save { get; set; }
        public ICommand Get { get; set; }

        private List<TaskModel> TaskModels;
        public TaskViewModel()
        {
            Tasks = new ObservableCollection<TaskModel>();
            TaskModels = new List<TaskModel>();

            Save = new Command(() =>
            {
                TaskModel task = new TaskModel();
                task.Title = this.Title;
                TaskModels.Add(task);
            });
            Get = new Command(() =>
            {
                Tasks = new ObservableCollection<TaskModel>(TaskModels);
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Todo.Models;
using Todo.Services;

namespace Todo.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
        {
            List = new TodoListViewModel(db.GetItems());
        }

        public TodoListViewModel List { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Todo.Models;
using Todo.Services;
using ReactiveUI;

namespace Todo.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        ViewModelBase content;
        public MainWindowViewModel(Database db)
        {
            Content = List = new TodoListViewModel(db.GetItems());
        }

        public ViewModelBase Content
        {
            get => Content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public TodoListViewModel List { get; }

        public void AddItem()
        {
            Content = new AddItemViewModel();
        }
    }
}

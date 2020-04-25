using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Dynamo.Controls;
using Dynamo.Models;
using Dynamo.Scheduler;
using Dynamo.ViewModels;
using Dynamo.Wpf;
using DynamoUI.Model;

namespace DynamoUI.ViewModel
{
<<<<<<< HEAD
<<<<<<< HEAD
    
}
=======

}
>>>>>>> fb3569762488a1d419197fbfe113b1a98c7e91b2
=======
    internal class ComboboxView : INodeViewCustomization<comboBoxModel>, IDisposable
    {

        DynamoModel DynamoModel;
        DynamoViewModel DynamoViewmodel;
        DispatcherSynchronizationContext SyncContext;
        BuiltInParamSelectorView View;
        BuiltInParamSelector ViewModel;

        public void CustomizeView(BuiltInParamSelector model, NodeView nodeView)
        {
            DynamoModel = nodeView.ViewModel.DynamoViewModel.Model;
            DynamoViewmodel = nodeView.ViewModel.DynamoViewModel;
            SyncContext = new DispatcherSynchronizationContext(nodeView.Dispatcher);
            ViewModel = model;
            ViewModel.EngineController = nodeView.ViewModel.DynamoViewModel.EngineController;
            View = new BuiltInParamSelectorView();
            nodeView.inputGrid.Children.Add(View);
            View.DataContext = model;
            model.RequestChangeBuiltInParamSelector += UpdateParameterSelector;
            UpdateParameterSelector();
        }

        public void Dispose()
        {
        }

        void UpdateParameterSelector()
        {
            DynamoScheduler scheduler = DynamoViewmodel.Model.Scheduler;
            DelegateBasedAsyncTask delegateBasedAsyncTask =
                new DelegateBasedAsyncTask(scheduler, delegate { ViewModel.PopulateItems(); });
            delegateBasedAsyncTask.ThenSend(delegate
            {
                if (ViewModel.SelectedItem != null)
                    ViewModel.SelectedItem = ViewModel.SelectedItem;
                else
                    ViewModel.SelectedItem = ViewModel.ItemsCollection.FirstOrDefault();
            }, SyncContext);
            scheduler.ScheduleForExecution(delegateBasedAsyncTask);
        }
    }
}
>>>>>>> parent of fb35697... re

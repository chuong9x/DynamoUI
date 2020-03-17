#pragma warning disable 1591,0618,0105,0672

using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using ReactiveUI.Events;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Xamarin.Forms
{
    public static class EventsMixin
    {
        public static ApplicationEvents Events(this Application This)
        {
            return new ApplicationEvents(This);
        }
        public static EntryCellEvents Events(this EntryCell This)
        {
            return new EntryCellEvents(This);
        }
        public static ICellControllerEvents Events(this ICellController This)
        {
            return new ICellControllerEvents(This);
        }
        public static ColumnDefinitionEvents Events(this ColumnDefinition This)
        {
            return new ColumnDefinitionEvents(This);
        }
        public static IListProxyEvents Events(this IListProxy This)
        {
            return new IListProxyEvents(This);
        }
        public static INavigationPageControllerEvents Events(this INavigationPageController This)
        {
            return new INavigationPageControllerEvents(This);
        }
        public static IMasterDetailPageControllerEvents Events(this IMasterDetailPageController This)
        {
            return new IMasterDetailPageControllerEvents(This);
        }
        public static IDefinitionEvents Events(this IDefinition This)
        {
            return new IDefinitionEvents(This);
        }
        public static IListViewControllerEvents Events(this IListViewController This)
        {
            return new IListViewControllerEvents(This);
        }
        public static IOpenGlViewControllerEvents Events(this IOpenGlViewController This)
        {
            return new IOpenGlViewControllerEvents(This);
        }
        public static IScrollViewControllerEvents Events(this IScrollViewController This)
        {
            return new IScrollViewControllerEvents(This);
        }
        public static ITableViewControllerEvents Events(this ITableViewController This)
        {
            return new ITableViewControllerEvents(This);
        }
        public static MenuItemEvents Events(this MenuItem This)
        {
            return new MenuItemEvents(This);
        }
        public static PanGestureRecognizerEvents Events(this PanGestureRecognizer This)
        {
            return new PanGestureRecognizerEvents(This);
        }
        public static BindableObjectEvents Events(this BindableObject This)
        {
            return new BindableObjectEvents(This);
        }
        public static RowDefinitionEvents Events(this RowDefinition This)
        {
            return new RowDefinitionEvents(This);
        }
        public static SpanEvents Events(this Span This)
        {
            return new SpanEvents(This);
        }
        public static TapGestureRecognizerEvents Events(this TapGestureRecognizer This)
        {
            return new TapGestureRecognizerEvents(This);
        }
        public static NavigationPageEvents Events(this NavigationPage This)
        {
            return new NavigationPageEvents(This);
        }
        public static PageEvents Events(this Page This)
        {
            return new PageEvents(This);
        }
        public static ToolbarItemEvents Events(this ToolbarItem This)
        {
            return new ToolbarItemEvents(This);
        }
        public static CellEvents Events(this Cell This)
        {
            return new CellEvents(This);
        }
        public static SwitchCellEvents Events(this SwitchCell This)
        {
            return new SwitchCellEvents(This);
        }
        public static ListViewEvents Events(this ListView This)
        {
            return new ListViewEvents(This);
        }
        public static ButtonEvents Events(this Button This)
        {
            return new ButtonEvents(This);
        }
        public static CommandEvents Events(this Command This)
        {
            return new CommandEvents(This);
        }
        public static DatePickerEvents Events(this DatePicker This)
        {
            return new DatePickerEvents(This);
        }
        public static EditorEvents Events(this Editor This)
        {
            return new EditorEvents(This);
        }
        public static EntryEvents Events(this Entry This)
        {
            return new EntryEvents(This);
        }
        public static MasterDetailPageEvents Events(this MasterDetailPage This)
        {
            return new MasterDetailPageEvents(This);
        }
        public static ScrollViewEvents Events(this ScrollView This)
        {
            return new ScrollViewEvents(This);
        }
        public static SearchBarEvents Events(this SearchBar This)
        {
            return new SearchBarEvents(This);
        }
        public static SliderEvents Events(this Slider This)
        {
            return new SliderEvents(This);
        }
        public static StepperEvents Events(this Stepper This)
        {
            return new StepperEvents(This);
        }
        public static SwitchEvents Events(this Switch This)
        {
            return new SwitchEvents(This);
        }
        public static WebViewEvents Events(this WebView This)
        {
            return new WebViewEvents(This);
        }
        public static ElementEvents Events(this Element This)
        {
            return new ElementEvents(This);
        }
        public static LayoutEvents Events(this Layout This)
        {
            return new LayoutEvents(This);
        }
        public static ILayoutEvents Events(this ILayout This)
        {
            return new ILayoutEvents(This);
        }
        public static VisualElementEvents Events(this VisualElement This)
        {
            return new VisualElementEvents(This);
        }
        public static PickerEvents Events(this Picker This)
        {
            return new PickerEvents(This);
        }
        public static FormattedStringEvents Events(this FormattedString This)
        {
            return new FormattedStringEvents(This);
        }
        public static PinchGestureRecognizerEvents Events(this PinchGestureRecognizer This)
        {
            return new PinchGestureRecognizerEvents(This);
        }
    }

    public class ApplicationEvents
        : Xamarin.Forms.ElementEvents
    {
        Application This;

        public ApplicationEvents(Application This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.ModalPoppedEventArgs> ModalPopped {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ModalPoppedEventArgs>, Xamarin.Forms.ModalPoppedEventArgs>(x => This.ModalPopped += x, x => This.ModalPopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.ModalPoppingEventArgs> ModalPopping {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ModalPoppingEventArgs>, Xamarin.Forms.ModalPoppingEventArgs>(x => This.ModalPopping += x, x => This.ModalPopping -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.ModalPushedEventArgs> ModalPushed {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ModalPushedEventArgs>, Xamarin.Forms.ModalPushedEventArgs>(x => This.ModalPushed += x, x => This.ModalPushed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.ModalPushingEventArgs> ModalPushing {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ModalPushingEventArgs>, Xamarin.Forms.ModalPushingEventArgs>(x => This.ModalPushing += x, x => This.ModalPushing -= x).Select(x => x.EventArgs); }
        }

    }
    public class EntryCellEvents
        : Xamarin.Forms.CellEvents
    {
        EntryCell This;

        public EntryCellEvents(EntryCell This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Completed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

    }
    public class ICellControllerEvents
    {
        ICellController This;

        public ICellControllerEvents(ICellController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ForceUpdateSizeRequested {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ForceUpdateSizeRequested += x, x => This.ForceUpdateSizeRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class ColumnDefinitionEvents
        : Xamarin.Forms.BindableObjectEvents
    {
        ColumnDefinition This;

        public ColumnDefinitionEvents(ColumnDefinition This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> SizeChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class IListProxyEvents
    {
        IListProxy This;

        public IListProxyEvents(IListProxy This)
        {
            this.This = This;
        }

        public IObservable<System.Collections.Specialized.NotifyCollectionChangedEventArgs> CollectionChanged {
            get { return Observable.FromEventPattern<System.Collections.Specialized.NotifyCollectionChangedEventHandler, System.Collections.Specialized.NotifyCollectionChangedEventArgs>(x => This.CollectionChanged += x, x => This.CollectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class INavigationPageControllerEvents
    {
        INavigationPageController This;

        public INavigationPageControllerEvents(INavigationPageController This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.Internals.NavigationRequestedEventArgs> InsertPageBeforeRequested {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.Internals.NavigationRequestedEventArgs>, Xamarin.Forms.Internals.NavigationRequestedEventArgs>(x => This.InsertPageBeforeRequested += x, x => This.InsertPageBeforeRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.Internals.NavigationRequestedEventArgs> PopRequested {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.Internals.NavigationRequestedEventArgs>, Xamarin.Forms.Internals.NavigationRequestedEventArgs>(x => This.PopRequested += x, x => This.PopRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.Internals.NavigationRequestedEventArgs> PopToRootRequested {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.Internals.NavigationRequestedEventArgs>, Xamarin.Forms.Internals.NavigationRequestedEventArgs>(x => This.PopToRootRequested += x, x => This.PopToRootRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.Internals.NavigationRequestedEventArgs> PushRequested {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.Internals.NavigationRequestedEventArgs>, Xamarin.Forms.Internals.NavigationRequestedEventArgs>(x => This.PushRequested += x, x => This.PushRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.Internals.NavigationRequestedEventArgs> RemovePageRequested {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.Internals.NavigationRequestedEventArgs>, Xamarin.Forms.Internals.NavigationRequestedEventArgs>(x => This.RemovePageRequested += x, x => This.RemovePageRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class IMasterDetailPageControllerEvents
    {
        IMasterDetailPageController This;

        public IMasterDetailPageControllerEvents(IMasterDetailPageController This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.BackButtonPressedEventArgs> BackButtonPressed {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.BackButtonPressedEventArgs>, Xamarin.Forms.BackButtonPressedEventArgs>(x => This.BackButtonPressed += x, x => This.BackButtonPressed -= x).Select(x => x.EventArgs); }
        }

    }
    public class IDefinitionEvents
    {
        IDefinition This;

        public IDefinitionEvents(IDefinition This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> SizeChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class IListViewControllerEvents
    {
        IListViewController This;

        public IListViewControllerEvents(IListViewController This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.ScrollToRequestedEventArgs> ScrollToRequested {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ScrollToRequestedEventArgs>, Xamarin.Forms.ScrollToRequestedEventArgs>(x => This.ScrollToRequested += x, x => This.ScrollToRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class IOpenGlViewControllerEvents
    {
        IOpenGlViewController This;

        public IOpenGlViewControllerEvents(IOpenGlViewController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DisplayRequested {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DisplayRequested += x, x => This.DisplayRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class IScrollViewControllerEvents
    {
        IScrollViewController This;

        public IScrollViewControllerEvents(IScrollViewController This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.ScrollToRequestedEventArgs> ScrollToRequested {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ScrollToRequestedEventArgs>, Xamarin.Forms.ScrollToRequestedEventArgs>(x => This.ScrollToRequested += x, x => This.ScrollToRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class ITableViewControllerEvents
    {
        ITableViewController This;

        public ITableViewControllerEvents(ITableViewController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ModelChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ModelChanged += x, x => This.ModelChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MenuItemEvents
        : Xamarin.Forms.ElementEvents
    {
        MenuItem This;

        public MenuItemEvents(MenuItem This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Clicked {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Clicked += x, x => This.Clicked -= x).Select(x => x.EventArgs); }
        }

    }
    public class PanGestureRecognizerEvents
        : Xamarin.Forms.ElementEvents
    {
        PanGestureRecognizer This;

        public PanGestureRecognizerEvents(PanGestureRecognizer This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.PanUpdatedEventArgs> PanUpdated {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.PanUpdatedEventArgs>, Xamarin.Forms.PanUpdatedEventArgs>(x => This.PanUpdated += x, x => This.PanUpdated -= x).Select(x => x.EventArgs); }
        }

    }
    public class BindableObjectEvents
    {
        BindableObject This;

        public BindableObjectEvents(BindableObject This)
        {
            this.This = This;
        }

        public IObservable<System.ComponentModel.PropertyChangedEventArgs> PropertyChanged {
            get { return Observable.FromEventPattern<System.ComponentModel.PropertyChangedEventHandler, System.ComponentModel.PropertyChangedEventArgs>(x => This.PropertyChanged += x, x => This.PropertyChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> BindingContextChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.BindingContextChanged += x, x => This.BindingContextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.PropertyChangingEventArgs> PropertyChanging {
            get { return Observable.FromEventPattern<Xamarin.Forms.PropertyChangingEventHandler, Xamarin.Forms.PropertyChangingEventArgs>(x => This.PropertyChanging += x, x => This.PropertyChanging -= x).Select(x => x.EventArgs); }
        }

    }
    public class RowDefinitionEvents
        : Xamarin.Forms.BindableObjectEvents
    {
        RowDefinition This;

        public RowDefinitionEvents(RowDefinition This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> SizeChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class SpanEvents
    {
        Span This;

        public SpanEvents(Span This)
        {
            this.This = This;
        }

        public IObservable<System.ComponentModel.PropertyChangedEventArgs> PropertyChanged {
            get { return Observable.FromEventPattern<System.ComponentModel.PropertyChangedEventHandler, System.ComponentModel.PropertyChangedEventArgs>(x => This.PropertyChanged += x, x => This.PropertyChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class TapGestureRecognizerEvents
        : Xamarin.Forms.ElementEvents
    {
        TapGestureRecognizer This;

        public TapGestureRecognizerEvents(TapGestureRecognizer This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Tapped {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Tapped += x, x => This.Tapped -= x).Select(x => x.EventArgs); }
        }

    }
    public class NavigationPageEvents
        : Xamarin.Forms.PageEvents
    {
        NavigationPage This;

        public NavigationPageEvents(NavigationPage This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.NavigationEventArgs> Popped {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.NavigationEventArgs>, Xamarin.Forms.NavigationEventArgs>(x => This.Popped += x, x => This.Popped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.NavigationEventArgs> PoppedToRoot {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.NavigationEventArgs>, Xamarin.Forms.NavigationEventArgs>(x => This.PoppedToRoot += x, x => This.PoppedToRoot -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.NavigationEventArgs> Pushed {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.NavigationEventArgs>, Xamarin.Forms.NavigationEventArgs>(x => This.Pushed += x, x => This.Pushed -= x).Select(x => x.EventArgs); }
        }

    }
    public class PageEvents
        : Xamarin.Forms.VisualElementEvents
    {
        Page This;

        public PageEvents(Page This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> LayoutChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LayoutChanged += x, x => This.LayoutChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Appearing {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Appearing += x, x => This.Appearing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Disappearing {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Disappearing += x, x => This.Disappearing -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToolbarItemEvents
        : Xamarin.Forms.MenuItemEvents
    {
        ToolbarItem This;

        public ToolbarItemEvents(ToolbarItem This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

    }
    public class CellEvents
        : Xamarin.Forms.ElementEvents
    {
        Cell This;

        public CellEvents(Cell This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Appearing {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Appearing += x, x => This.Appearing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Disappearing {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Disappearing += x, x => This.Disappearing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Tapped {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Tapped += x, x => This.Tapped -= x).Select(x => x.EventArgs); }
        }

    }
    public class SwitchCellEvents
        : Xamarin.Forms.CellEvents
    {
        SwitchCell This;

        public SwitchCellEvents(SwitchCell This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.ToggledEventArgs> OnChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ToggledEventArgs>, Xamarin.Forms.ToggledEventArgs>(x => This.OnChanged += x, x => This.OnChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ListViewEvents
        : Xamarin.Forms.VisualElementEvents
    {
        ListView This;

        public ListViewEvents(ListView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.ItemVisibilityEventArgs> ItemAppearing {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ItemVisibilityEventArgs>, Xamarin.Forms.ItemVisibilityEventArgs>(x => This.ItemAppearing += x, x => This.ItemAppearing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.ItemVisibilityEventArgs> ItemDisappearing {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ItemVisibilityEventArgs>, Xamarin.Forms.ItemVisibilityEventArgs>(x => This.ItemDisappearing += x, x => This.ItemDisappearing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.SelectedItemChangedEventArgs> ItemSelected {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.SelectedItemChangedEventArgs>, Xamarin.Forms.SelectedItemChangedEventArgs>(x => This.ItemSelected += x, x => This.ItemSelected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.ItemTappedEventArgs> ItemTapped {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ItemTappedEventArgs>, Xamarin.Forms.ItemTappedEventArgs>(x => This.ItemTapped += x, x => This.ItemTapped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Refreshing {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Refreshing += x, x => This.Refreshing -= x).Select(x => x.EventArgs); }
        }

    }
    public class ButtonEvents
        : Xamarin.Forms.VisualElementEvents
    {
        Button This;

        public ButtonEvents(Button This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Clicked {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Clicked += x, x => This.Clicked -= x).Select(x => x.EventArgs); }
        }

    }
    public class CommandEvents
    {
        Command This;

        public CommandEvents(Command This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> CanExecuteChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CanExecuteChanged += x, x => This.CanExecuteChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class DatePickerEvents
        : Xamarin.Forms.VisualElementEvents
    {
        DatePicker This;

        public DatePickerEvents(DatePicker This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.DateChangedEventArgs> DateSelected {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.DateChangedEventArgs>, Xamarin.Forms.DateChangedEventArgs>(x => This.DateSelected += x, x => This.DateSelected -= x).Select(x => x.EventArgs); }
        }

    }
    public class EditorEvents
        : Xamarin.Forms.VisualElementEvents
    {
        Editor This;

        public EditorEvents(Editor This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Completed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.TextChangedEventArgs> TextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.TextChangedEventArgs>, Xamarin.Forms.TextChangedEventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class EntryEvents
        : Xamarin.Forms.VisualElementEvents
    {
        Entry This;

        public EntryEvents(Entry This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Completed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.TextChangedEventArgs> TextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.TextChangedEventArgs>, Xamarin.Forms.TextChangedEventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MasterDetailPageEvents
        : Xamarin.Forms.PageEvents
    {
        MasterDetailPage This;

        public MasterDetailPageEvents(MasterDetailPage This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> IsPresentedChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.IsPresentedChanged += x, x => This.IsPresentedChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ScrollViewEvents
        : Xamarin.Forms.LayoutEvents
    {
        ScrollView This;

        public ScrollViewEvents(ScrollView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.ScrolledEventArgs> Scrolled {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ScrolledEventArgs>, Xamarin.Forms.ScrolledEventArgs>(x => This.Scrolled += x, x => This.Scrolled -= x).Select(x => x.EventArgs); }
        }

    }
    public class SearchBarEvents
        : Xamarin.Forms.VisualElementEvents
    {
        SearchBar This;

        public SearchBarEvents(SearchBar This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> SearchButtonPressed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SearchButtonPressed += x, x => This.SearchButtonPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.TextChangedEventArgs> TextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.TextChangedEventArgs>, Xamarin.Forms.TextChangedEventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class SliderEvents
        : Xamarin.Forms.VisualElementEvents
    {
        Slider This;

        public SliderEvents(Slider This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.ValueChangedEventArgs> ValueChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ValueChangedEventArgs>, Xamarin.Forms.ValueChangedEventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class StepperEvents
        : Xamarin.Forms.VisualElementEvents
    {
        Stepper This;

        public StepperEvents(Stepper This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.ValueChangedEventArgs> ValueChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ValueChangedEventArgs>, Xamarin.Forms.ValueChangedEventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class SwitchEvents
        : Xamarin.Forms.VisualElementEvents
    {
        Switch This;

        public SwitchEvents(Switch This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.ToggledEventArgs> Toggled {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ToggledEventArgs>, Xamarin.Forms.ToggledEventArgs>(x => This.Toggled += x, x => This.Toggled -= x).Select(x => x.EventArgs); }
        }

    }
    public class WebViewEvents
        : Xamarin.Forms.VisualElementEvents
    {
        WebView This;

        public WebViewEvents(WebView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.WebNavigatedEventArgs> Navigated {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.WebNavigatedEventArgs>, Xamarin.Forms.WebNavigatedEventArgs>(x => This.Navigated += x, x => This.Navigated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.WebNavigatingEventArgs> Navigating {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.WebNavigatingEventArgs>, Xamarin.Forms.WebNavigatingEventArgs>(x => This.Navigating += x, x => This.Navigating -= x).Select(x => x.EventArgs); }
        }

    }
    public class ElementEvents
        : Xamarin.Forms.BindableObjectEvents
    {
        Element This;

        public ElementEvents(Element This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.ElementEventArgs> ChildAdded {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ElementEventArgs>, Xamarin.Forms.ElementEventArgs>(x => This.ChildAdded += x, x => This.ChildAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.ElementEventArgs> ChildRemoved {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ElementEventArgs>, Xamarin.Forms.ElementEventArgs>(x => This.ChildRemoved += x, x => This.ChildRemoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.ElementEventArgs> DescendantAdded {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ElementEventArgs>, Xamarin.Forms.ElementEventArgs>(x => This.DescendantAdded += x, x => This.DescendantAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.ElementEventArgs> DescendantRemoved {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.ElementEventArgs>, Xamarin.Forms.ElementEventArgs>(x => This.DescendantRemoved += x, x => This.DescendantRemoved -= x).Select(x => x.EventArgs); }
        }

    }
    public class LayoutEvents
        : Xamarin.Forms.VisualElementEvents
    {
        Layout This;

        public LayoutEvents(Layout This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> LayoutChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LayoutChanged += x, x => This.LayoutChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ILayoutEvents
    {
        ILayout This;

        public ILayoutEvents(ILayout This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> LayoutChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LayoutChanged += x, x => This.LayoutChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class VisualElementEvents
        : Xamarin.Forms.ElementEvents
    {
        VisualElement This;

        public VisualElementEvents(VisualElement This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ChildrenReordered {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ChildrenReordered += x, x => This.ChildrenReordered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.FocusEventArgs> Focused {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.FocusEventArgs>, Xamarin.Forms.FocusEventArgs>(x => This.Focused += x, x => This.Focused -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> MeasureInvalidated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.MeasureInvalidated += x, x => This.MeasureInvalidated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SizeChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Xamarin.Forms.FocusEventArgs> Unfocused {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.FocusEventArgs>, Xamarin.Forms.FocusEventArgs>(x => This.Unfocused += x, x => This.Unfocused -= x).Select(x => x.EventArgs); }
        }

    }
    public class PickerEvents
        : Xamarin.Forms.VisualElementEvents
    {
        Picker This;

        public PickerEvents(Picker This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> SelectedIndexChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectedIndexChanged += x, x => This.SelectedIndexChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class FormattedStringEvents
    {
        FormattedString This;

        public FormattedStringEvents(FormattedString This)
        {
            this.This = This;
        }

        public IObservable<System.ComponentModel.PropertyChangedEventArgs> PropertyChanged {
            get { return Observable.FromEventPattern<System.ComponentModel.PropertyChangedEventHandler, System.ComponentModel.PropertyChangedEventArgs>(x => This.PropertyChanged += x, x => This.PropertyChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PinchGestureRecognizerEvents
        : Xamarin.Forms.ElementEvents
    {
        PinchGestureRecognizer This;

        public PinchGestureRecognizerEvents(PinchGestureRecognizer This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Xamarin.Forms.PinchGestureUpdatedEventArgs> PinchUpdated {
            get { return Observable.FromEventPattern<System.EventHandler<Xamarin.Forms.PinchGestureUpdatedEventArgs>, Xamarin.Forms.PinchGestureUpdatedEventArgs>(x => This.PinchUpdated += x, x => This.PinchUpdated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Xamarin.Forms.Internals
{
    public static class EventsMixin
    {
        public static ToolbarTrackerEvents Events(this ToolbarTracker This)
        {
            return new ToolbarTrackerEvents(This);
        }
    }

    public class ToolbarTrackerEvents
    {
        ToolbarTracker This;

        public ToolbarTrackerEvents(ToolbarTracker This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> CollectionChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CollectionChanged += x, x => This.CollectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
}


#pragma warning restore 1591,0618,0105,0672

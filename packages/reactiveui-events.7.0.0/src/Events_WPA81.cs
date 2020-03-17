#pragma warning disable 1591,0618,0105,0672

using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using ReactiveUI.Events;

using Windows.UI.ViewManagement;
using Windows.ApplicationModel.Background;
using Windows.ApplicationModel.DataTransfer;
using Windows.Graphics.Display;
using Windows.UI.Input;
using Windows.Storage.Pickers.Provider;
using Windows.Storage.Provider;
using Windows.UI.StartScreen;
using Windows.Storage.Search;
using Windows.Storage.AccessCache;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.Chat;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.Resources.Core;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Devices.Enumeration.Pnp;
using Windows.Devices.Geolocation.Geofencing;
using Windows.Devices.Geolocation;
using Windows.Devices.HumanInterfaceDevice;
using Windows.Devices.Input;
using Windows.Devices.Sensors;
using Windows.Devices.SmartCards;
using Windows.Devices.WiFiDirect;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Media.Effects;
using Windows.Media.Playback;
using Windows.Media.PlayTo;
using Windows.Media.SpeechRecognition;
using Windows.Media;
using Windows.Media.Capture.Core;
using Windows.Media.Protection;
using Windows.Media.Core;
using Windows.Networking.Proximity;
using Windows.Networking.Sockets;
using Windows.Networking.Vpn;
using Windows.Phone.Devices.Power;
using Windows.Phone.Media.Devices;
using Windows.Security.Credentials;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.WebUI.Core;
using Windows.UI.WebUI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Foundation.Diagnostics;
using Windows.Networking.PushNotifications;
using Windows.UI.Notifications;

namespace Windows.UI.ViewManagement
{
    public static class EventsMixin
    {
        public static ApplicationViewEvents Events(this ApplicationView This)
        {
            return new ApplicationViewEvents(This);
        }
        public static InputPaneEvents Events(this InputPane This)
        {
            return new InputPaneEvents(This);
        }
        public static AccessibilitySettingsEvents Events(this AccessibilitySettings This)
        {
            return new AccessibilitySettingsEvents(This);
        }
        public static UISettingsEvents Events(this UISettings This)
        {
            return new UISettingsEvents(This);
        }
        public static StatusBarEvents Events(this StatusBar This)
        {
            return new StatusBarEvents(This);
        }
    }

    public class ApplicationViewEvents
    {
        ApplicationView This;

        public ApplicationViewEvents(ApplicationView This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.ViewManagement.ApplicationViewConsolidatedEventArgs> Consolidated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.ApplicationView,Windows.UI.ViewManagement.ApplicationViewConsolidatedEventArgs>, Windows.UI.ViewManagement.ApplicationViewConsolidatedEventArgs>(x => This.Consolidated += x, x => This.Consolidated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VisibleBoundsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.ApplicationView,object>, object>(x => This.VisibleBoundsChanged += x, x => This.VisibleBoundsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class InputPaneEvents
    {
        InputPane This;

        public InputPaneEvents(InputPane This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.ViewManagement.InputPaneVisibilityEventArgs> Hiding {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.InputPane,Windows.UI.ViewManagement.InputPaneVisibilityEventArgs>, Windows.UI.ViewManagement.InputPaneVisibilityEventArgs>(x => This.Hiding += x, x => This.Hiding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.ViewManagement.InputPaneVisibilityEventArgs> Showing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.InputPane,Windows.UI.ViewManagement.InputPaneVisibilityEventArgs>, Windows.UI.ViewManagement.InputPaneVisibilityEventArgs>(x => This.Showing += x, x => This.Showing -= x).Select(x => x.EventArgs); }
        }

    }
    public class AccessibilitySettingsEvents
    {
        AccessibilitySettings This;

        public AccessibilitySettingsEvents(AccessibilitySettings This)
        {
            this.This = This;
        }

        public IObservable<object> HighContrastChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.AccessibilitySettings,object>, object>(x => This.HighContrastChanged += x, x => This.HighContrastChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class UISettingsEvents
    {
        UISettings This;

        public UISettingsEvents(UISettings This)
        {
            this.This = This;
        }

        public IObservable<object> TextScaleFactorChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.UISettings,object>, object>(x => This.TextScaleFactorChanged += x, x => This.TextScaleFactorChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class StatusBarEvents
    {
        StatusBar This;

        public StatusBarEvents(StatusBar This)
        {
            this.This = This;
        }

        public IObservable<object> Hiding {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.StatusBar,object>, object>(x => This.Hiding += x, x => This.Hiding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Showing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.StatusBar,object>, object>(x => This.Showing += x, x => This.Showing -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Background
{
    public static class EventsMixin
    {
        public static IBackgroundTaskInstanceEvents Events(this IBackgroundTaskInstance This)
        {
            return new IBackgroundTaskInstanceEvents(This);
        }
        public static BackgroundTaskRegistrationEvents Events(this BackgroundTaskRegistration This)
        {
            return new BackgroundTaskRegistrationEvents(This);
        }
        public static IBackgroundTaskRegistrationEvents Events(this IBackgroundTaskRegistration This)
        {
            return new IBackgroundTaskRegistrationEvents(This);
        }
    }

    public class IBackgroundTaskInstanceEvents
    {
        IBackgroundTaskInstance This;

        public IBackgroundTaskInstanceEvents(IBackgroundTaskInstance This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Background.BackgroundTaskCancellationReason> Canceled {
            get { return Observable.FromEventPattern<Windows.ApplicationModel.Background.BackgroundTaskCanceledEventHandler, Windows.ApplicationModel.Background.BackgroundTaskCancellationReason>(x => This.Canceled += x, x => This.Canceled -= x).Select(x => x.EventArgs); }
        }

    }
    public class BackgroundTaskRegistrationEvents
    {
        BackgroundTaskRegistration This;

        public BackgroundTaskRegistrationEvents(BackgroundTaskRegistration This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs> Completed {
            get { return Observable.FromEventPattern<Windows.ApplicationModel.Background.BackgroundTaskCompletedEventHandler, Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs> Progress {
            get { return Observable.FromEventPattern<Windows.ApplicationModel.Background.BackgroundTaskProgressEventHandler, Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs>(x => This.Progress += x, x => This.Progress -= x).Select(x => x.EventArgs); }
        }

    }
    public class IBackgroundTaskRegistrationEvents
    {
        IBackgroundTaskRegistration This;

        public IBackgroundTaskRegistrationEvents(IBackgroundTaskRegistration This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs> Completed {
            get { return Observable.FromEventPattern<Windows.ApplicationModel.Background.BackgroundTaskCompletedEventHandler, Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs> Progress {
            get { return Observable.FromEventPattern<Windows.ApplicationModel.Background.BackgroundTaskProgressEventHandler, Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs>(x => This.Progress += x, x => This.Progress -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.DataTransfer
{
    public static class EventsMixin
    {
        public static DataPackageEvents Events(this DataPackage This)
        {
            return new DataPackageEvents(This);
        }
        public static DataTransferManagerEvents Events(this DataTransferManager This)
        {
            return new DataTransferManagerEvents(This);
        }
    }

    public class DataPackageEvents
    {
        DataPackage This;

        public DataPackageEvents(DataPackage This)
        {
            this.This = This;
        }

        public IObservable<object> Destroyed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.DataPackage,object>, object>(x => This.Destroyed += x, x => This.Destroyed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.DataTransfer.OperationCompletedEventArgs> OperationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.DataPackage,Windows.ApplicationModel.DataTransfer.OperationCompletedEventArgs>, Windows.ApplicationModel.DataTransfer.OperationCompletedEventArgs>(x => This.OperationCompleted += x, x => This.OperationCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class DataTransferManagerEvents
    {
        DataTransferManager This;

        public DataTransferManagerEvents(DataTransferManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs> DataRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.DataTransferManager,Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs>, Windows.ApplicationModel.DataTransfer.DataRequestedEventArgs>(x => This.DataRequested += x, x => This.DataRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.DataTransfer.TargetApplicationChosenEventArgs> TargetApplicationChosen {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.DataTransferManager,Windows.ApplicationModel.DataTransfer.TargetApplicationChosenEventArgs>, Windows.ApplicationModel.DataTransfer.TargetApplicationChosenEventArgs>(x => This.TargetApplicationChosen += x, x => This.TargetApplicationChosen -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Graphics.Display
{
    public static class EventsMixin
    {
        public static DisplayInformationEvents Events(this DisplayInformation This)
        {
            return new DisplayInformationEvents(This);
        }
    }

    public class DisplayInformationEvents
    {
        DisplayInformation This;

        public DisplayInformationEvents(DisplayInformation This)
        {
            this.This = This;
        }

        public IObservable<object> ColorProfileChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Display.DisplayInformation,object>, object>(x => This.ColorProfileChanged += x, x => This.ColorProfileChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> DpiChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Display.DisplayInformation,object>, object>(x => This.DpiChanged += x, x => This.DpiChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> OrientationChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Display.DisplayInformation,object>, object>(x => This.OrientationChanged += x, x => This.OrientationChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> StereoEnabledChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Display.DisplayInformation,object>, object>(x => This.StereoEnabledChanged += x, x => This.StereoEnabledChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Input
{
    public static class EventsMixin
    {
        public static EdgeGestureEvents Events(this EdgeGesture This)
        {
            return new EdgeGestureEvents(This);
        }
        public static GestureRecognizerEvents Events(this GestureRecognizer This)
        {
            return new GestureRecognizerEvents(This);
        }
    }

    public class EdgeGestureEvents
    {
        EdgeGesture This;

        public EdgeGestureEvents(EdgeGesture This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Input.EdgeGestureEventArgs> Canceled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.EdgeGesture,Windows.UI.Input.EdgeGestureEventArgs>, Windows.UI.Input.EdgeGestureEventArgs>(x => This.Canceled += x, x => This.Canceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.EdgeGestureEventArgs> Completed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.EdgeGesture,Windows.UI.Input.EdgeGestureEventArgs>, Windows.UI.Input.EdgeGestureEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.EdgeGestureEventArgs> Starting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.EdgeGesture,Windows.UI.Input.EdgeGestureEventArgs>, Windows.UI.Input.EdgeGestureEventArgs>(x => This.Starting += x, x => This.Starting -= x).Select(x => x.EventArgs); }
        }

    }
    public class GestureRecognizerEvents
    {
        GestureRecognizer This;

        public GestureRecognizerEvents(GestureRecognizer This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Input.CrossSlidingEventArgs> CrossSliding {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.CrossSlidingEventArgs>, Windows.UI.Input.CrossSlidingEventArgs>(x => This.CrossSliding += x, x => This.CrossSliding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.DraggingEventArgs> Dragging {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.DraggingEventArgs>, Windows.UI.Input.DraggingEventArgs>(x => This.Dragging += x, x => This.Dragging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.HoldingEventArgs> Holding {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.HoldingEventArgs>, Windows.UI.Input.HoldingEventArgs>(x => This.Holding += x, x => This.Holding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.ManipulationCompletedEventArgs> ManipulationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.ManipulationCompletedEventArgs>, Windows.UI.Input.ManipulationCompletedEventArgs>(x => This.ManipulationCompleted += x, x => This.ManipulationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.ManipulationInertiaStartingEventArgs>, Windows.UI.Input.ManipulationInertiaStartingEventArgs>(x => This.ManipulationInertiaStarting += x, x => This.ManipulationInertiaStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.ManipulationStartedEventArgs> ManipulationStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.ManipulationStartedEventArgs>, Windows.UI.Input.ManipulationStartedEventArgs>(x => This.ManipulationStarted += x, x => This.ManipulationStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.ManipulationUpdatedEventArgs> ManipulationUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.ManipulationUpdatedEventArgs>, Windows.UI.Input.ManipulationUpdatedEventArgs>(x => This.ManipulationUpdated += x, x => This.ManipulationUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.RightTappedEventArgs> RightTapped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.RightTappedEventArgs>, Windows.UI.Input.RightTappedEventArgs>(x => This.RightTapped += x, x => This.RightTapped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.TappedEventArgs> Tapped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.GestureRecognizer,Windows.UI.Input.TappedEventArgs>, Windows.UI.Input.TappedEventArgs>(x => This.Tapped += x, x => This.Tapped -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Storage.Pickers.Provider
{
    public static class EventsMixin
    {
        public static FileOpenPickerUIEvents Events(this FileOpenPickerUI This)
        {
            return new FileOpenPickerUIEvents(This);
        }
        public static FileSavePickerUIEvents Events(this FileSavePickerUI This)
        {
            return new FileSavePickerUIEvents(This);
        }
    }

    public class FileOpenPickerUIEvents
    {
        FileOpenPickerUI This;

        public FileOpenPickerUIEvents(FileOpenPickerUI This)
        {
            this.This = This;
        }

        public IObservable<Windows.Storage.Pickers.Provider.PickerClosingEventArgs> Closing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Pickers.Provider.FileOpenPickerUI,Windows.Storage.Pickers.Provider.PickerClosingEventArgs>, Windows.Storage.Pickers.Provider.PickerClosingEventArgs>(x => This.Closing += x, x => This.Closing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Storage.Pickers.Provider.FileRemovedEventArgs> FileRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Pickers.Provider.FileOpenPickerUI,Windows.Storage.Pickers.Provider.FileRemovedEventArgs>, Windows.Storage.Pickers.Provider.FileRemovedEventArgs>(x => This.FileRemoved += x, x => This.FileRemoved -= x).Select(x => x.EventArgs); }
        }

    }
    public class FileSavePickerUIEvents
    {
        FileSavePickerUI This;

        public FileSavePickerUIEvents(FileSavePickerUI This)
        {
            this.This = This;
        }

        public IObservable<object> FileNameChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Pickers.Provider.FileSavePickerUI,object>, object>(x => This.FileNameChanged += x, x => This.FileNameChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Storage.Pickers.Provider.TargetFileRequestedEventArgs> TargetFileRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Pickers.Provider.FileSavePickerUI,Windows.Storage.Pickers.Provider.TargetFileRequestedEventArgs>, Windows.Storage.Pickers.Provider.TargetFileRequestedEventArgs>(x => This.TargetFileRequested += x, x => This.TargetFileRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Storage.Provider
{
    public static class EventsMixin
    {
        public static CachedFileUpdaterUIEvents Events(this CachedFileUpdaterUI This)
        {
            return new CachedFileUpdaterUIEvents(This);
        }
    }

    public class CachedFileUpdaterUIEvents
    {
        CachedFileUpdaterUI This;

        public CachedFileUpdaterUIEvents(CachedFileUpdaterUI This)
        {
            this.This = This;
        }

        public IObservable<Windows.Storage.Provider.FileUpdateRequestedEventArgs> FileUpdateRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Provider.CachedFileUpdaterUI,Windows.Storage.Provider.FileUpdateRequestedEventArgs>, Windows.Storage.Provider.FileUpdateRequestedEventArgs>(x => This.FileUpdateRequested += x, x => This.FileUpdateRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> UIRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Provider.CachedFileUpdaterUI,object>, object>(x => This.UIRequested += x, x => This.UIRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.StartScreen
{
    public static class EventsMixin
    {
        public static SecondaryTileEvents Events(this SecondaryTile This)
        {
            return new SecondaryTileEvents(This);
        }
    }

    public class SecondaryTileEvents
    {
        SecondaryTile This;

        public SecondaryTileEvents(SecondaryTile This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.StartScreen.VisualElementsRequestedEventArgs> VisualElementsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.StartScreen.SecondaryTile,Windows.UI.StartScreen.VisualElementsRequestedEventArgs>, Windows.UI.StartScreen.VisualElementsRequestedEventArgs>(x => This.VisualElementsRequested += x, x => This.VisualElementsRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Storage.Search
{
    public static class EventsMixin
    {
        public static IStorageQueryResultBaseEvents Events(this IStorageQueryResultBase This)
        {
            return new IStorageQueryResultBaseEvents(This);
        }
        public static StorageFileQueryResultEvents Events(this StorageFileQueryResult This)
        {
            return new StorageFileQueryResultEvents(This);
        }
        public static StorageFolderQueryResultEvents Events(this StorageFolderQueryResult This)
        {
            return new StorageFolderQueryResultEvents(This);
        }
        public static StorageItemQueryResultEvents Events(this StorageItemQueryResult This)
        {
            return new StorageItemQueryResultEvents(This);
        }
    }

    public class IStorageQueryResultBaseEvents
    {
        IStorageQueryResultBase This;

        public IStorageQueryResultBaseEvents(IStorageQueryResultBase This)
        {
            this.This = This;
        }

        public IObservable<object> ContentsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.ContentsChanged += x, x => This.ContentsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> OptionsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.OptionsChanged += x, x => This.OptionsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class StorageFileQueryResultEvents
    {
        StorageFileQueryResult This;

        public StorageFileQueryResultEvents(StorageFileQueryResult This)
        {
            this.This = This;
        }

        public IObservable<object> ContentsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.ContentsChanged += x, x => This.ContentsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> OptionsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.OptionsChanged += x, x => This.OptionsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class StorageFolderQueryResultEvents
    {
        StorageFolderQueryResult This;

        public StorageFolderQueryResultEvents(StorageFolderQueryResult This)
        {
            this.This = This;
        }

        public IObservable<object> ContentsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.ContentsChanged += x, x => This.ContentsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> OptionsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.OptionsChanged += x, x => This.OptionsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class StorageItemQueryResultEvents
    {
        StorageItemQueryResult This;

        public StorageItemQueryResultEvents(StorageItemQueryResult This)
        {
            this.This = This;
        }

        public IObservable<object> ContentsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.ContentsChanged += x, x => This.ContentsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> OptionsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.Search.IStorageQueryResultBase,object>, object>(x => This.OptionsChanged += x, x => This.OptionsChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Storage.AccessCache
{
    public static class EventsMixin
    {
        public static StorageItemMostRecentlyUsedListEvents Events(this StorageItemMostRecentlyUsedList This)
        {
            return new StorageItemMostRecentlyUsedListEvents(This);
        }
    }

    public class StorageItemMostRecentlyUsedListEvents
    {
        StorageItemMostRecentlyUsedList This;

        public StorageItemMostRecentlyUsedListEvents(StorageItemMostRecentlyUsedList This)
        {
            this.This = This;
        }

        public IObservable<Windows.Storage.AccessCache.ItemRemovedEventArgs> ItemRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.AccessCache.StorageItemMostRecentlyUsedList,Windows.Storage.AccessCache.ItemRemovedEventArgs>, Windows.Storage.AccessCache.ItemRemovedEventArgs>(x => This.ItemRemoved += x, x => This.ItemRemoved -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Activation
{
    public static class EventsMixin
    {
        public static SplashScreenEvents Events(this SplashScreen This)
        {
            return new SplashScreenEvents(This);
        }
    }

    public class SplashScreenEvents
    {
        SplashScreen This;

        public SplashScreenEvents(SplashScreen This)
        {
            this.This = This;
        }

        public IObservable<object> Dismissed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Activation.SplashScreen,object>, object>(x => This.Dismissed += x, x => This.Dismissed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Chat
{
    public static class EventsMixin
    {
        public static ChatMessageStoreEvents Events(this ChatMessageStore This)
        {
            return new ChatMessageStoreEvents(This);
        }
    }

    public class ChatMessageStoreEvents
    {
        ChatMessageStore This;

        public ChatMessageStoreEvents(ChatMessageStore This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Chat.ChatMessageChangedEventArgs> MessageChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Chat.ChatMessageStore,Windows.ApplicationModel.Chat.ChatMessageChangedEventArgs>, Windows.ApplicationModel.Chat.ChatMessageChangedEventArgs>(x => This.MessageChanged += x, x => This.MessageChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Core
{
    public static class EventsMixin
    {
        public static CoreApplicationViewEvents Events(this CoreApplicationView This)
        {
            return new CoreApplicationViewEvents(This);
        }
        public static ICoreApplicationUnhandledErrorEvents Events(this ICoreApplicationUnhandledError This)
        {
            return new ICoreApplicationUnhandledErrorEvents(This);
        }
    }

    public class CoreApplicationViewEvents
    {
        CoreApplicationView This;

        public CoreApplicationViewEvents(CoreApplicationView This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Activation.IActivatedEventArgs> Activated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Core.CoreApplicationView,Windows.ApplicationModel.Activation.IActivatedEventArgs>, Windows.ApplicationModel.Activation.IActivatedEventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

    }
    public class ICoreApplicationUnhandledErrorEvents
    {
        ICoreApplicationUnhandledError This;

        public ICoreApplicationUnhandledErrorEvents(ICoreApplicationUnhandledError This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Core.UnhandledErrorDetectedEventArgs> UnhandledErrorDetected {
            get { return Observable.FromEventPattern<EventHandler<Windows.ApplicationModel.Core.UnhandledErrorDetectedEventArgs>, Windows.ApplicationModel.Core.UnhandledErrorDetectedEventArgs>(x => This.UnhandledErrorDetected += x, x => This.UnhandledErrorDetected -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Resources.Core
{
    public static class EventsMixin
    {
        public static ResourceQualifierObservableMapEvents Events(this ResourceQualifierObservableMap This)
        {
            return new ResourceQualifierObservableMapEvents(This);
        }
    }

    public class ResourceQualifierObservableMapEvents
    {
        ResourceQualifierObservableMap This;

        public ResourceQualifierObservableMapEvents(ResourceQualifierObservableMap This)
        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IMapChangedEventArgs<string>> MapChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.MapChangedEventHandler<string,string>, Windows.Foundation.Collections.IMapChangedEventArgs<string>>(x => This.MapChanged += x, x => This.MapChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Bluetooth
{
    public static class EventsMixin
    {
        public static BluetoothDeviceEvents Events(this BluetoothDevice This)
        {
            return new BluetoothDeviceEvents(This);
        }
        public static BluetoothLEDeviceEvents Events(this BluetoothLEDevice This)
        {
            return new BluetoothLEDeviceEvents(This);
        }
    }

    public class BluetoothDeviceEvents
    {
        BluetoothDevice This;

        public BluetoothDeviceEvents(BluetoothDevice This)
        {
            this.This = This;
        }

        public IObservable<object> ConnectionStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Bluetooth.BluetoothDevice,object>, object>(x => This.ConnectionStatusChanged += x, x => This.ConnectionStatusChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> NameChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Bluetooth.BluetoothDevice,object>, object>(x => This.NameChanged += x, x => This.NameChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> SdpRecordsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Bluetooth.BluetoothDevice,object>, object>(x => This.SdpRecordsChanged += x, x => This.SdpRecordsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class BluetoothLEDeviceEvents
    {
        BluetoothLEDevice This;

        public BluetoothLEDeviceEvents(BluetoothLEDevice This)
        {
            this.This = This;
        }

        public IObservable<object> ConnectionStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Bluetooth.BluetoothLEDevice,object>, object>(x => This.ConnectionStatusChanged += x, x => This.ConnectionStatusChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> GattServicesChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Bluetooth.BluetoothLEDevice,object>, object>(x => This.GattServicesChanged += x, x => This.GattServicesChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> NameChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Bluetooth.BluetoothLEDevice,object>, object>(x => This.NameChanged += x, x => This.NameChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
    public static class EventsMixin
    {
        public static GattCharacteristicEvents Events(this GattCharacteristic This)
        {
            return new GattCharacteristicEvents(This);
        }
    }

    public class GattCharacteristicEvents
    {
        GattCharacteristic This;

        public GattCharacteristicEvents(GattCharacteristic This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Bluetooth.GenericAttributeProfile.GattValueChangedEventArgs> ValueChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic,Windows.Devices.Bluetooth.GenericAttributeProfile.GattValueChangedEventArgs>, Windows.Devices.Bluetooth.GenericAttributeProfile.GattValueChangedEventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Enumeration
{
    public static class EventsMixin
    {
        public static DeviceWatcherEvents Events(this DeviceWatcher This)
        {
            return new DeviceWatcherEvents(This);
        }
        public static DeviceAccessInformationEvents Events(this DeviceAccessInformation This)
        {
            return new DeviceAccessInformationEvents(This);
        }
    }

    public class DeviceWatcherEvents
    {
        DeviceWatcher This;

        public DeviceWatcherEvents(DeviceWatcher This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Enumeration.DeviceInformation> Added {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceWatcher,Windows.Devices.Enumeration.DeviceInformation>, Windows.Devices.Enumeration.DeviceInformation>(x => This.Added += x, x => This.Added -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Enumeration.DeviceInformationUpdate> Removed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceWatcher,Windows.Devices.Enumeration.DeviceInformationUpdate>, Windows.Devices.Enumeration.DeviceInformationUpdate>(x => This.Removed += x, x => This.Removed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Enumeration.DeviceInformationUpdate> Updated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceWatcher,Windows.Devices.Enumeration.DeviceInformationUpdate>, Windows.Devices.Enumeration.DeviceInformationUpdate>(x => This.Updated += x, x => This.Updated -= x).Select(x => x.EventArgs); }
        }

    }
    public class DeviceAccessInformationEvents
    {
        DeviceAccessInformation This;

        public DeviceAccessInformationEvents(DeviceAccessInformation This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Enumeration.DeviceAccessChangedEventArgs> AccessChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceAccessInformation,Windows.Devices.Enumeration.DeviceAccessChangedEventArgs>, Windows.Devices.Enumeration.DeviceAccessChangedEventArgs>(x => This.AccessChanged += x, x => This.AccessChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Enumeration.Pnp
{
    public static class EventsMixin
    {
        public static PnpObjectWatcherEvents Events(this PnpObjectWatcher This)
        {
            return new PnpObjectWatcherEvents(This);
        }
    }

    public class PnpObjectWatcherEvents
    {
        PnpObjectWatcher This;

        public PnpObjectWatcherEvents(PnpObjectWatcher This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Enumeration.Pnp.PnpObject> Added {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.Pnp.PnpObjectWatcher,Windows.Devices.Enumeration.Pnp.PnpObject>, Windows.Devices.Enumeration.Pnp.PnpObject>(x => This.Added += x, x => This.Added -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.Pnp.PnpObjectWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Enumeration.Pnp.PnpObjectUpdate> Removed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.Pnp.PnpObjectWatcher,Windows.Devices.Enumeration.Pnp.PnpObjectUpdate>, Windows.Devices.Enumeration.Pnp.PnpObjectUpdate>(x => This.Removed += x, x => This.Removed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.Pnp.PnpObjectWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Enumeration.Pnp.PnpObjectUpdate> Updated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.Pnp.PnpObjectWatcher,Windows.Devices.Enumeration.Pnp.PnpObjectUpdate>, Windows.Devices.Enumeration.Pnp.PnpObjectUpdate>(x => This.Updated += x, x => This.Updated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Geolocation.Geofencing
{
    public static class EventsMixin
    {
        public static GeofenceMonitorEvents Events(this GeofenceMonitor This)
        {
            return new GeofenceMonitorEvents(This);
        }
    }

    public class GeofenceMonitorEvents
    {
        GeofenceMonitor This;

        public GeofenceMonitorEvents(GeofenceMonitor This)
        {
            this.This = This;
        }

        public IObservable<object> GeofenceStateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Geolocation.Geofencing.GeofenceMonitor,object>, object>(x => This.GeofenceStateChanged += x, x => This.GeofenceStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> StatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Geolocation.Geofencing.GeofenceMonitor,object>, object>(x => This.StatusChanged += x, x => This.StatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Geolocation
{
    public static class EventsMixin
    {
        public static GeolocatorEvents Events(this Geolocator This)
        {
            return new GeolocatorEvents(This);
        }
    }

    public class GeolocatorEvents
    {
        Geolocator This;

        public GeolocatorEvents(Geolocator This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Geolocation.PositionChangedEventArgs> PositionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Geolocation.Geolocator,Windows.Devices.Geolocation.PositionChangedEventArgs>, Windows.Devices.Geolocation.PositionChangedEventArgs>(x => This.PositionChanged += x, x => This.PositionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Geolocation.StatusChangedEventArgs> StatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Geolocation.Geolocator,Windows.Devices.Geolocation.StatusChangedEventArgs>, Windows.Devices.Geolocation.StatusChangedEventArgs>(x => This.StatusChanged += x, x => This.StatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.HumanInterfaceDevice
{
    public static class EventsMixin
    {
        public static HidDeviceEvents Events(this HidDevice This)
        {
            return new HidDeviceEvents(This);
        }
    }

    public class HidDeviceEvents
    {
        HidDevice This;

        public HidDeviceEvents(HidDevice This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.HumanInterfaceDevice.HidInputReportReceivedEventArgs> InputReportReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.HumanInterfaceDevice.HidDevice,Windows.Devices.HumanInterfaceDevice.HidInputReportReceivedEventArgs>, Windows.Devices.HumanInterfaceDevice.HidInputReportReceivedEventArgs>(x => This.InputReportReceived += x, x => This.InputReportReceived -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Input
{
    public static class EventsMixin
    {
        public static MouseDeviceEvents Events(this MouseDevice This)
        {
            return new MouseDeviceEvents(This);
        }
    }

    public class MouseDeviceEvents
    {
        MouseDevice This;

        public MouseDeviceEvents(MouseDevice This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Input.MouseEventArgs> MouseMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Input.MouseDevice,Windows.Devices.Input.MouseEventArgs>, Windows.Devices.Input.MouseEventArgs>(x => This.MouseMoved += x, x => This.MouseMoved -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Sensors
{
    public static class EventsMixin
    {
        public static AccelerometerEvents Events(this Accelerometer This)
        {
            return new AccelerometerEvents(This);
        }
        public static InclinometerEvents Events(this Inclinometer This)
        {
            return new InclinometerEvents(This);
        }
        public static GyrometerEvents Events(this Gyrometer This)
        {
            return new GyrometerEvents(This);
        }
        public static CompassEvents Events(this Compass This)
        {
            return new CompassEvents(This);
        }
        public static LightSensorEvents Events(this LightSensor This)
        {
            return new LightSensorEvents(This);
        }
        public static OrientationSensorEvents Events(this OrientationSensor This)
        {
            return new OrientationSensorEvents(This);
        }
        public static SimpleOrientationSensorEvents Events(this SimpleOrientationSensor This)
        {
            return new SimpleOrientationSensorEvents(This);
        }
        public static MagnetometerEvents Events(this Magnetometer This)
        {
            return new MagnetometerEvents(This);
        }
    }

    public class AccelerometerEvents
    {
        Accelerometer This;

        public AccelerometerEvents(Accelerometer This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.AccelerometerReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Accelerometer,Windows.Devices.Sensors.AccelerometerReadingChangedEventArgs>, Windows.Devices.Sensors.AccelerometerReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Sensors.AccelerometerShakenEventArgs> Shaken {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Accelerometer,Windows.Devices.Sensors.AccelerometerShakenEventArgs>, Windows.Devices.Sensors.AccelerometerShakenEventArgs>(x => This.Shaken += x, x => This.Shaken -= x).Select(x => x.EventArgs); }
        }

    }
    public class InclinometerEvents
    {
        Inclinometer This;

        public InclinometerEvents(Inclinometer This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.InclinometerReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Inclinometer,Windows.Devices.Sensors.InclinometerReadingChangedEventArgs>, Windows.Devices.Sensors.InclinometerReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class GyrometerEvents
    {
        Gyrometer This;

        public GyrometerEvents(Gyrometer This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.GyrometerReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Gyrometer,Windows.Devices.Sensors.GyrometerReadingChangedEventArgs>, Windows.Devices.Sensors.GyrometerReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CompassEvents
    {
        Compass This;

        public CompassEvents(Compass This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.CompassReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Compass,Windows.Devices.Sensors.CompassReadingChangedEventArgs>, Windows.Devices.Sensors.CompassReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class LightSensorEvents
    {
        LightSensor This;

        public LightSensorEvents(LightSensor This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.LightSensorReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.LightSensor,Windows.Devices.Sensors.LightSensorReadingChangedEventArgs>, Windows.Devices.Sensors.LightSensorReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class OrientationSensorEvents
    {
        OrientationSensor This;

        public OrientationSensorEvents(OrientationSensor This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.OrientationSensorReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.OrientationSensor,Windows.Devices.Sensors.OrientationSensorReadingChangedEventArgs>, Windows.Devices.Sensors.OrientationSensorReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class SimpleOrientationSensorEvents
    {
        SimpleOrientationSensor This;

        public SimpleOrientationSensorEvents(SimpleOrientationSensor This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.SimpleOrientationSensorOrientationChangedEventArgs> OrientationChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.SimpleOrientationSensor,Windows.Devices.Sensors.SimpleOrientationSensorOrientationChangedEventArgs>, Windows.Devices.Sensors.SimpleOrientationSensorOrientationChangedEventArgs>(x => This.OrientationChanged += x, x => This.OrientationChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MagnetometerEvents
    {
        Magnetometer This;

        public MagnetometerEvents(Magnetometer This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.MagnetometerReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Magnetometer,Windows.Devices.Sensors.MagnetometerReadingChangedEventArgs>, Windows.Devices.Sensors.MagnetometerReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.SmartCards
{
    public static class EventsMixin
    {
        public static SmartCardReaderEvents Events(this SmartCardReader This)
        {
            return new SmartCardReaderEvents(This);
        }
    }

    public class SmartCardReaderEvents
    {
        SmartCardReader This;

        public SmartCardReaderEvents(SmartCardReader This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.SmartCards.CardAddedEventArgs> CardAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.SmartCards.SmartCardReader,Windows.Devices.SmartCards.CardAddedEventArgs>, Windows.Devices.SmartCards.CardAddedEventArgs>(x => This.CardAdded += x, x => This.CardAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.SmartCards.CardRemovedEventArgs> CardRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.SmartCards.SmartCardReader,Windows.Devices.SmartCards.CardRemovedEventArgs>, Windows.Devices.SmartCards.CardRemovedEventArgs>(x => This.CardRemoved += x, x => This.CardRemoved -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.WiFiDirect
{
    public static class EventsMixin
    {
        public static WiFiDirectDeviceEvents Events(this WiFiDirectDevice This)
        {
            return new WiFiDirectDeviceEvents(This);
        }
    }

    public class WiFiDirectDeviceEvents
    {
        WiFiDirectDevice This;

        public WiFiDirectDeviceEvents(WiFiDirectDevice This)
        {
            this.This = This;
        }

        public IObservable<object> ConnectionStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.WiFiDirect.WiFiDirectDevice,object>, object>(x => This.ConnectionStatusChanged += x, x => This.ConnectionStatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Foundation.Collections
{
    public static class EventsMixin
    {
        public static PropertySetEvents Events(this PropertySet This)
        {
            return new PropertySetEvents(This);
        }
        public static ValueSetEvents Events(this ValueSet This)
        {
            return new ValueSetEvents(This);
        }
    }

    public class PropertySetEvents
    {
        PropertySet This;

        public PropertySetEvents(PropertySet This)
        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IMapChangedEventArgs<string>> MapChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.MapChangedEventHandler<string,object>, Windows.Foundation.Collections.IMapChangedEventArgs<string>>(x => This.MapChanged += x, x => This.MapChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ValueSetEvents
    {
        ValueSet This;

        public ValueSetEvents(ValueSet This)
        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IMapChangedEventArgs<string>> MapChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.MapChangedEventHandler<string,object>, Windows.Foundation.Collections.IMapChangedEventArgs<string>>(x => This.MapChanged += x, x => This.MapChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Capture
{
    public static class EventsMixin
    {
        public static ScreenCaptureEvents Events(this ScreenCapture This)
        {
            return new ScreenCaptureEvents(This);
        }
        public static MediaCaptureEvents Events(this MediaCapture This)
        {
            return new MediaCaptureEvents(This);
        }
        public static LowLagPhotoSequenceCaptureEvents Events(this LowLagPhotoSequenceCapture This)
        {
            return new LowLagPhotoSequenceCaptureEvents(This);
        }
    }

    public class ScreenCaptureEvents
    {
        ScreenCapture This;

        public ScreenCaptureEvents(ScreenCapture This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Capture.SourceSuspensionChangedEventArgs> SourceSuspensionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.ScreenCapture,Windows.Media.Capture.SourceSuspensionChangedEventArgs>, Windows.Media.Capture.SourceSuspensionChangedEventArgs>(x => This.SourceSuspensionChanged += x, x => This.SourceSuspensionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaCaptureEvents
    {
        MediaCapture This;

        public MediaCaptureEvents(MediaCapture This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Capture.MediaCaptureFailedEventArgs> Failed {
            get { return Observable.FromEventPattern<Windows.Media.Capture.MediaCaptureFailedEventHandler, Windows.Media.Capture.MediaCaptureFailedEventArgs>(x => This.Failed += x, x => This.Failed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Capture.MediaCaptureFocusChangedEventArgs> FocusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.MediaCapture,Windows.Media.Capture.MediaCaptureFocusChangedEventArgs>, Windows.Media.Capture.MediaCaptureFocusChangedEventArgs>(x => This.FocusChanged += x, x => This.FocusChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Capture.PhotoConfirmationCapturedEventArgs> PhotoConfirmationCaptured {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.MediaCapture,Windows.Media.Capture.PhotoConfirmationCapturedEventArgs>, Windows.Media.Capture.PhotoConfirmationCapturedEventArgs>(x => This.PhotoConfirmationCaptured += x, x => This.PhotoConfirmationCaptured -= x).Select(x => x.EventArgs); }
        }

    }
    public class LowLagPhotoSequenceCaptureEvents
    {
        LowLagPhotoSequenceCapture This;

        public LowLagPhotoSequenceCaptureEvents(LowLagPhotoSequenceCapture This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Capture.PhotoCapturedEventArgs> PhotoCaptured {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.LowLagPhotoSequenceCapture,Windows.Media.Capture.PhotoCapturedEventArgs>, Windows.Media.Capture.PhotoCapturedEventArgs>(x => This.PhotoCaptured += x, x => This.PhotoCaptured -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Effects
{
    public static class EventsMixin
    {
        public static AudioRenderEffectsManagerEvents Events(this AudioRenderEffectsManager This)
        {
            return new AudioRenderEffectsManagerEvents(This);
        }
        public static AudioCaptureEffectsManagerEvents Events(this AudioCaptureEffectsManager This)
        {
            return new AudioCaptureEffectsManagerEvents(This);
        }
    }

    public class AudioRenderEffectsManagerEvents
    {
        AudioRenderEffectsManager This;

        public AudioRenderEffectsManagerEvents(AudioRenderEffectsManager This)
        {
            this.This = This;
        }

        public IObservable<object> AudioRenderEffectsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Effects.AudioRenderEffectsManager,object>, object>(x => This.AudioRenderEffectsChanged += x, x => This.AudioRenderEffectsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class AudioCaptureEffectsManagerEvents
    {
        AudioCaptureEffectsManager This;

        public AudioCaptureEffectsManagerEvents(AudioCaptureEffectsManager This)
        {
            this.This = This;
        }

        public IObservable<object> AudioCaptureEffectsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Effects.AudioCaptureEffectsManager,object>, object>(x => This.AudioCaptureEffectsChanged += x, x => This.AudioCaptureEffectsChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Playback
{
    public static class EventsMixin
    {
        public static MediaPlayerEvents Events(this MediaPlayer This)
        {
            return new MediaPlayerEvents(This);
        }
    }

    public class MediaPlayerEvents
    {
        MediaPlayer This;

        public MediaPlayerEvents(MediaPlayer This)
        {
            this.This = This;
        }

        public IObservable<object> BufferingEnded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlayer,object>, object>(x => This.BufferingEnded += x, x => This.BufferingEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> BufferingStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlayer,object>, object>(x => This.BufferingStarted += x, x => This.BufferingStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> CurrentStateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlayer,object>, object>(x => This.CurrentStateChanged += x, x => This.CurrentStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> MediaEnded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlayer,object>, object>(x => This.MediaEnded += x, x => This.MediaEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlayerFailedEventArgs> MediaFailed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlayer,Windows.Media.Playback.MediaPlayerFailedEventArgs>, Windows.Media.Playback.MediaPlayerFailedEventArgs>(x => This.MediaFailed += x, x => This.MediaFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> MediaOpened {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlayer,object>, object>(x => This.MediaOpened += x, x => This.MediaOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlayerRateChangedEventArgs> MediaPlayerRateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlayer,Windows.Media.Playback.MediaPlayerRateChangedEventArgs>, Windows.Media.Playback.MediaPlayerRateChangedEventArgs>(x => This.MediaPlayerRateChanged += x, x => This.MediaPlayerRateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.PlaybackMediaMarkerReachedEventArgs> PlaybackMediaMarkerReached {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlayer,Windows.Media.Playback.PlaybackMediaMarkerReachedEventArgs>, Windows.Media.Playback.PlaybackMediaMarkerReachedEventArgs>(x => This.PlaybackMediaMarkerReached += x, x => This.PlaybackMediaMarkerReached -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> SeekCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlayer,object>, object>(x => This.SeekCompleted += x, x => This.SeekCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VolumeChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlayer,object>, object>(x => This.VolumeChanged += x, x => This.VolumeChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.PlayTo
{
    public static class EventsMixin
    {
        public static PlayToConnectionEvents Events(this PlayToConnection This)
        {
            return new PlayToConnectionEvents(This);
        }
    }

    public class PlayToConnectionEvents
    {
        PlayToConnection This;

        public PlayToConnectionEvents(PlayToConnection This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.PlayTo.PlayToConnectionErrorEventArgs> Error {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToConnection,Windows.Media.PlayTo.PlayToConnectionErrorEventArgs>, Windows.Media.PlayTo.PlayToConnectionErrorEventArgs>(x => This.Error += x, x => This.Error -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs> StateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToConnection,Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs>, Windows.Media.PlayTo.PlayToConnectionStateChangedEventArgs>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.PlayToConnectionTransferredEventArgs> Transferred {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToConnection,Windows.Media.PlayTo.PlayToConnectionTransferredEventArgs>, Windows.Media.PlayTo.PlayToConnectionTransferredEventArgs>(x => This.Transferred += x, x => This.Transferred -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.SpeechRecognition
{
    public static class EventsMixin
    {
        public static SpeechRecognizerEvents Events(this SpeechRecognizer This)
        {
            return new SpeechRecognizerEvents(This);
        }
    }

    public class SpeechRecognizerEvents
    {
        SpeechRecognizer This;

        public SpeechRecognizerEvents(SpeechRecognizer This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.SpeechRecognition.SpeechRecognitionQualityDegradingEventArgs> RecognitionQualityDegrading {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SpeechRecognition.SpeechRecognizer,Windows.Media.SpeechRecognition.SpeechRecognitionQualityDegradingEventArgs>, Windows.Media.SpeechRecognition.SpeechRecognitionQualityDegradingEventArgs>(x => This.RecognitionQualityDegrading += x, x => This.RecognitionQualityDegrading -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.SpeechRecognition.SpeechRecognizerStateChangedEventArgs> StateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SpeechRecognition.SpeechRecognizer,Windows.Media.SpeechRecognition.SpeechRecognizerStateChangedEventArgs>, Windows.Media.SpeechRecognition.SpeechRecognizerStateChangedEventArgs>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media
{
    public static class EventsMixin
    {
        public static SystemMediaTransportControlsEvents Events(this SystemMediaTransportControls This)
        {
            return new SystemMediaTransportControlsEvents(This);
        }
    }

    public class SystemMediaTransportControlsEvents
    {
        SystemMediaTransportControls This;

        public SystemMediaTransportControlsEvents(SystemMediaTransportControls This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.SystemMediaTransportControlsButtonPressedEventArgs> ButtonPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SystemMediaTransportControls,Windows.Media.SystemMediaTransportControlsButtonPressedEventArgs>, Windows.Media.SystemMediaTransportControlsButtonPressedEventArgs>(x => This.ButtonPressed += x, x => This.ButtonPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.SystemMediaTransportControlsPropertyChangedEventArgs> PropertyChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SystemMediaTransportControls,Windows.Media.SystemMediaTransportControlsPropertyChangedEventArgs>, Windows.Media.SystemMediaTransportControlsPropertyChangedEventArgs>(x => This.PropertyChanged += x, x => This.PropertyChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Capture.Core
{
    public static class EventsMixin
    {
        public static VariablePhotoSequenceCaptureEvents Events(this VariablePhotoSequenceCapture This)
        {
            return new VariablePhotoSequenceCaptureEvents(This);
        }
    }

    public class VariablePhotoSequenceCaptureEvents
    {
        VariablePhotoSequenceCapture This;

        public VariablePhotoSequenceCaptureEvents(VariablePhotoSequenceCapture This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Capture.Core.VariablePhotoCapturedEventArgs> PhotoCaptured {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.Core.VariablePhotoSequenceCapture,Windows.Media.Capture.Core.VariablePhotoCapturedEventArgs>, Windows.Media.Capture.Core.VariablePhotoCapturedEventArgs>(x => This.PhotoCaptured += x, x => This.PhotoCaptured -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.Core.VariablePhotoSequenceCapture,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Protection
{
    public static class EventsMixin
    {
        public static MediaProtectionManagerEvents Events(this MediaProtectionManager This)
        {
            return new MediaProtectionManagerEvents(This);
        }
    }

    public class MediaProtectionManagerEvents
    {
        MediaProtectionManager This;

        public MediaProtectionManagerEvents(MediaProtectionManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Protection.ComponentLoadFailedEventArgs> ComponentLoadFailed {
            get { return Observable.FromEventPattern<Windows.Media.Protection.ComponentLoadFailedEventHandler, Windows.Media.Protection.ComponentLoadFailedEventArgs>(x => This.ComponentLoadFailed += x, x => This.ComponentLoadFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Protection.ServiceRequestedEventArgs> ServiceRequested {
            get { return Observable.FromEventPattern<Windows.Media.Protection.ServiceRequestedEventHandler, Windows.Media.Protection.ServiceRequestedEventArgs>(x => This.ServiceRequested += x, x => This.ServiceRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Core
{
    public static class EventsMixin
    {
        public static MediaStreamSourceEvents Events(this MediaStreamSource This)
        {
            return new MediaStreamSourceEvents(This);
        }
        public static MediaStreamSampleEvents Events(this MediaStreamSample This)
        {
            return new MediaStreamSampleEvents(This);
        }
    }

    public class MediaStreamSourceEvents
    {
        MediaStreamSource This;

        public MediaStreamSourceEvents(MediaStreamSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Core.MediaStreamSourceClosedEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSource,Windows.Media.Core.MediaStreamSourceClosedEventArgs>, Windows.Media.Core.MediaStreamSourceClosedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Paused {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSource,object>, object>(x => This.Paused += x, x => This.Paused -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Core.MediaStreamSourceSampleRequestedEventArgs> SampleRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSource,Windows.Media.Core.MediaStreamSourceSampleRequestedEventArgs>, Windows.Media.Core.MediaStreamSourceSampleRequestedEventArgs>(x => This.SampleRequested += x, x => This.SampleRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Core.MediaStreamSourceStartingEventArgs> Starting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSource,Windows.Media.Core.MediaStreamSourceStartingEventArgs>, Windows.Media.Core.MediaStreamSourceStartingEventArgs>(x => This.Starting += x, x => This.Starting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Core.MediaStreamSourceSwitchStreamsRequestedEventArgs> SwitchStreamsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSource,Windows.Media.Core.MediaStreamSourceSwitchStreamsRequestedEventArgs>, Windows.Media.Core.MediaStreamSourceSwitchStreamsRequestedEventArgs>(x => This.SwitchStreamsRequested += x, x => This.SwitchStreamsRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaStreamSampleEvents
    {
        MediaStreamSample This;

        public MediaStreamSampleEvents(MediaStreamSample This)
        {
            this.This = This;
        }

        public IObservable<object> Processed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSample,object>, object>(x => This.Processed += x, x => This.Processed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Networking.Proximity
{
    public static class EventsMixin
    {
        public static PeerWatcherEvents Events(this PeerWatcher This)
        {
            return new PeerWatcherEvents(This);
        }
    }

    public class PeerWatcherEvents
    {
        PeerWatcher This;

        public PeerWatcherEvents(PeerWatcher This)
        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Proximity.PeerInformation> Added {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Proximity.PeerWatcher,Windows.Networking.Proximity.PeerInformation>, Windows.Networking.Proximity.PeerInformation>(x => This.Added += x, x => This.Added -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Proximity.PeerWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Networking.Proximity.PeerInformation> Removed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Proximity.PeerWatcher,Windows.Networking.Proximity.PeerInformation>, Windows.Networking.Proximity.PeerInformation>(x => This.Removed += x, x => This.Removed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Proximity.PeerWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Networking.Proximity.PeerInformation> Updated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Proximity.PeerWatcher,Windows.Networking.Proximity.PeerInformation>, Windows.Networking.Proximity.PeerInformation>(x => This.Updated += x, x => This.Updated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Networking.Sockets
{
    public static class EventsMixin
    {
        public static DatagramSocketEvents Events(this DatagramSocket This)
        {
            return new DatagramSocketEvents(This);
        }
        public static StreamSocketListenerEvents Events(this StreamSocketListener This)
        {
            return new StreamSocketListenerEvents(This);
        }
        public static IWebSocketEvents Events(this IWebSocket This)
        {
            return new IWebSocketEvents(This);
        }
        public static MessageWebSocketEvents Events(this MessageWebSocket This)
        {
            return new MessageWebSocketEvents(This);
        }
        public static StreamWebSocketEvents Events(this StreamWebSocket This)
        {
            return new StreamWebSocketEvents(This);
        }
    }

    public class DatagramSocketEvents
    {
        DatagramSocket This;

        public DatagramSocketEvents(DatagramSocket This)
        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs> MessageReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.DatagramSocket,Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs>, Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs>(x => This.MessageReceived += x, x => This.MessageReceived -= x).Select(x => x.EventArgs); }
        }

    }
    public class StreamSocketListenerEvents
    {
        StreamSocketListener This;

        public StreamSocketListenerEvents(StreamSocketListener This)
        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Sockets.StreamSocketListenerConnectionReceivedEventArgs> ConnectionReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.StreamSocketListener,Windows.Networking.Sockets.StreamSocketListenerConnectionReceivedEventArgs>, Windows.Networking.Sockets.StreamSocketListenerConnectionReceivedEventArgs>(x => This.ConnectionReceived += x, x => This.ConnectionReceived -= x).Select(x => x.EventArgs); }
        }

    }
    public class IWebSocketEvents
    {
        IWebSocket This;

        public IWebSocketEvents(IWebSocket This)
        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Sockets.WebSocketClosedEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.IWebSocket,Windows.Networking.Sockets.WebSocketClosedEventArgs>, Windows.Networking.Sockets.WebSocketClosedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

    }
    public class MessageWebSocketEvents
    {
        MessageWebSocket This;

        public MessageWebSocketEvents(MessageWebSocket This)
        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs> MessageReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.MessageWebSocket,Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs>, Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs>(x => This.MessageReceived += x, x => This.MessageReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Networking.Sockets.WebSocketClosedEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.IWebSocket,Windows.Networking.Sockets.WebSocketClosedEventArgs>, Windows.Networking.Sockets.WebSocketClosedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

    }
    public class StreamWebSocketEvents
    {
        StreamWebSocket This;

        public StreamWebSocketEvents(StreamWebSocket This)
        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Sockets.WebSocketClosedEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.IWebSocket,Windows.Networking.Sockets.WebSocketClosedEventArgs>, Windows.Networking.Sockets.WebSocketClosedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Networking.Vpn
{
    public static class EventsMixin
    {
        public static VpnChannelEvents Events(this VpnChannel This)
        {
            return new VpnChannelEvents(This);
        }
    }

    public class VpnChannelEvents
    {
        VpnChannel This;

        public VpnChannelEvents(VpnChannel This)
        {
            this.This = This;
        }

        public IObservable<Windows.Networking.Vpn.VpnChannelActivityEventArgs> ActivityChange {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Vpn.VpnChannel,Windows.Networking.Vpn.VpnChannelActivityEventArgs>, Windows.Networking.Vpn.VpnChannelActivityEventArgs>(x => This.ActivityChange += x, x => This.ActivityChange -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Phone.Devices.Power
{
    public static class EventsMixin
    {
        public static BatteryEvents Events(this Battery This)
        {
            return new BatteryEvents(This);
        }
    }

    public class BatteryEvents
    {
        Battery This;

        public BatteryEvents(Battery This)
        {
            this.This = This;
        }

        public IObservable<object> RemainingChargePercentChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.RemainingChargePercentChanged += x, x => This.RemainingChargePercentChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Phone.Media.Devices
{
    public static class EventsMixin
    {
        public static AudioRoutingManagerEvents Events(this AudioRoutingManager This)
        {
            return new AudioRoutingManagerEvents(This);
        }
    }

    public class AudioRoutingManagerEvents
    {
        AudioRoutingManager This;

        public AudioRoutingManagerEvents(AudioRoutingManager This)
        {
            this.This = This;
        }

        public IObservable<object> AudioEndpointChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Phone.Media.Devices.AudioRoutingManager,object>, object>(x => This.AudioEndpointChanged += x, x => This.AudioEndpointChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Security.Credentials
{
    public static class EventsMixin
    {
        public static PasswordCredentialPropertyStoreEvents Events(this PasswordCredentialPropertyStore This)
        {
            return new PasswordCredentialPropertyStoreEvents(This);
        }
    }

    public class PasswordCredentialPropertyStoreEvents
    {
        PasswordCredentialPropertyStore This;

        public PasswordCredentialPropertyStoreEvents(PasswordCredentialPropertyStore This)
        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IMapChangedEventArgs<string>> MapChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.MapChangedEventHandler<string,object>, Windows.Foundation.Collections.IMapChangedEventArgs<string>>(x => This.MapChanged += x, x => This.MapChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Storage
{
    public static class EventsMixin
    {
        public static ApplicationDataEvents Events(this ApplicationData This)
        {
            return new ApplicationDataEvents(This);
        }
        public static ApplicationDataContainerSettingsEvents Events(this ApplicationDataContainerSettings This)
        {
            return new ApplicationDataContainerSettingsEvents(This);
        }
        public static ApplicationDataCompositeValueEvents Events(this ApplicationDataCompositeValue This)
        {
            return new ApplicationDataCompositeValueEvents(This);
        }
    }

    public class ApplicationDataEvents
    {
        ApplicationData This;

        public ApplicationDataEvents(ApplicationData This)
        {
            this.This = This;
        }

        public IObservable<object> DataChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.ApplicationData,object>, object>(x => This.DataChanged += x, x => This.DataChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationDataContainerSettingsEvents
    {
        ApplicationDataContainerSettings This;

        public ApplicationDataContainerSettingsEvents(ApplicationDataContainerSettings This)
        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IMapChangedEventArgs<string>> MapChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.MapChangedEventHandler<string,object>, Windows.Foundation.Collections.IMapChangedEventArgs<string>>(x => This.MapChanged += x, x => This.MapChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationDataCompositeValueEvents
    {
        ApplicationDataCompositeValue This;

        public ApplicationDataCompositeValueEvents(ApplicationDataCompositeValue This)
        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IMapChangedEventArgs<string>> MapChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.MapChangedEventHandler<string,object>, Windows.Foundation.Collections.IMapChangedEventArgs<string>>(x => This.MapChanged += x, x => This.MapChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Core
{
    public static class EventsMixin
    {
        public static ICoreWindowEvents Events(this ICoreWindow This)
        {
            return new ICoreWindowEvents(This);
        }
        public static CoreDispatcherEvents Events(this CoreDispatcher This)
        {
            return new CoreDispatcherEvents(This);
        }
        public static CoreWindowEvents Events(this CoreWindow This)
        {
            return new CoreWindowEvents(This);
        }
        public static ICoreAcceleratorKeysEvents Events(this ICoreAcceleratorKeys This)
        {
            return new ICoreAcceleratorKeysEvents(This);
        }
        public static CoreAcceleratorKeysEvents Events(this CoreAcceleratorKeys This)
        {
            return new CoreAcceleratorKeysEvents(This);
        }
        public static ICoreInputSourceBaseEvents Events(this ICoreInputSourceBase This)
        {
            return new ICoreInputSourceBaseEvents(This);
        }
        public static ICorePointerInputSourceEvents Events(this ICorePointerInputSource This)
        {
            return new ICorePointerInputSourceEvents(This);
        }
        public static CoreIndependentInputSourceEvents Events(this CoreIndependentInputSource This)
        {
            return new CoreIndependentInputSourceEvents(This);
        }
        public static CoreComponentInputSourceEvents Events(this CoreComponentInputSource This)
        {
            return new CoreComponentInputSourceEvents(This);
        }
    }

    public class ICoreWindowEvents
    {
        ICoreWindow This;

        public ICoreWindowEvents(ICoreWindow This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.WindowActivatedEventArgs> Activated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.WindowActivatedEventArgs>, Windows.UI.Core.WindowActivatedEventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.AutomationProviderRequestedEventArgs> AutomationProviderRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.AutomationProviderRequestedEventArgs>, Windows.UI.Core.AutomationProviderRequestedEventArgs>(x => This.AutomationProviderRequested += x, x => This.AutomationProviderRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CharacterReceivedEventArgs> CharacterReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.CharacterReceivedEventArgs>, Windows.UI.Core.CharacterReceivedEventArgs>(x => This.CharacterReceived += x, x => This.CharacterReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CoreWindowEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.CoreWindowEventArgs>, Windows.UI.Core.CoreWindowEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.InputEnabledEventArgs> InputEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.InputEnabledEventArgs>, Windows.UI.Core.InputEnabledEventArgs>(x => This.InputEnabled += x, x => This.InputEnabled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerCaptureLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerCaptureLost += x, x => This.PointerCaptureLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerWheelChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerWheelChanged += x, x => This.PointerWheelChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.WindowSizeChangedEventArgs> SizeChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.WindowSizeChangedEventArgs>, Windows.UI.Core.WindowSizeChangedEventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.TouchHitTestingEventArgs> TouchHitTesting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.TouchHitTestingEventArgs>, Windows.UI.Core.TouchHitTestingEventArgs>(x => This.TouchHitTesting += x, x => This.TouchHitTesting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.VisibilityChangedEventArgs> VisibilityChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.VisibilityChangedEventArgs>, Windows.UI.Core.VisibilityChangedEventArgs>(x => This.VisibilityChanged += x, x => This.VisibilityChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreDispatcherEvents
    {
        CoreDispatcher This;

        public CoreDispatcherEvents(CoreDispatcher This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.AcceleratorKeyEventArgs> AcceleratorKeyActivated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreDispatcher,Windows.UI.Core.AcceleratorKeyEventArgs>, Windows.UI.Core.AcceleratorKeyEventArgs>(x => This.AcceleratorKeyActivated += x, x => This.AcceleratorKeyActivated -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreWindowEvents
    {
        CoreWindow This;

        public CoreWindowEvents(CoreWindow This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.WindowActivatedEventArgs> Activated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.WindowActivatedEventArgs>, Windows.UI.Core.WindowActivatedEventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.AutomationProviderRequestedEventArgs> AutomationProviderRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.AutomationProviderRequestedEventArgs>, Windows.UI.Core.AutomationProviderRequestedEventArgs>(x => This.AutomationProviderRequested += x, x => This.AutomationProviderRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CharacterReceivedEventArgs> CharacterReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.CharacterReceivedEventArgs>, Windows.UI.Core.CharacterReceivedEventArgs>(x => This.CharacterReceived += x, x => This.CharacterReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CoreWindowEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.CoreWindowEventArgs>, Windows.UI.Core.CoreWindowEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.InputEnabledEventArgs> InputEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.InputEnabledEventArgs>, Windows.UI.Core.InputEnabledEventArgs>(x => This.InputEnabled += x, x => This.InputEnabled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerCaptureLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerCaptureLost += x, x => This.PointerCaptureLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerWheelChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerWheelChanged += x, x => This.PointerWheelChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.WindowSizeChangedEventArgs> SizeChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.WindowSizeChangedEventArgs>, Windows.UI.Core.WindowSizeChangedEventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.TouchHitTestingEventArgs> TouchHitTesting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.TouchHitTestingEventArgs>, Windows.UI.Core.TouchHitTestingEventArgs>(x => This.TouchHitTesting += x, x => This.TouchHitTesting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.VisibilityChangedEventArgs> VisibilityChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.VisibilityChangedEventArgs>, Windows.UI.Core.VisibilityChangedEventArgs>(x => This.VisibilityChanged += x, x => This.VisibilityChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ICoreAcceleratorKeysEvents
    {
        ICoreAcceleratorKeys This;

        public ICoreAcceleratorKeysEvents(ICoreAcceleratorKeys This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.AcceleratorKeyEventArgs> AcceleratorKeyActivated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreDispatcher,Windows.UI.Core.AcceleratorKeyEventArgs>, Windows.UI.Core.AcceleratorKeyEventArgs>(x => This.AcceleratorKeyActivated += x, x => This.AcceleratorKeyActivated -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreAcceleratorKeysEvents
    {
        CoreAcceleratorKeys This;

        public CoreAcceleratorKeysEvents(CoreAcceleratorKeys This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.AcceleratorKeyEventArgs> AcceleratorKeyActivated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreDispatcher,Windows.UI.Core.AcceleratorKeyEventArgs>, Windows.UI.Core.AcceleratorKeyEventArgs>(x => This.AcceleratorKeyActivated += x, x => This.AcceleratorKeyActivated -= x).Select(x => x.EventArgs); }
        }

    }
    public class ICoreInputSourceBaseEvents
    {
        ICoreInputSourceBase This;

        public ICoreInputSourceBaseEvents(ICoreInputSourceBase This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.InputEnabledEventArgs> InputEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.InputEnabledEventArgs>, Windows.UI.Core.InputEnabledEventArgs>(x => This.InputEnabled += x, x => This.InputEnabled -= x).Select(x => x.EventArgs); }
        }

    }
    public class ICorePointerInputSourceEvents
    {
        ICorePointerInputSource This;

        public ICorePointerInputSourceEvents(ICorePointerInputSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerCaptureLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerCaptureLost += x, x => This.PointerCaptureLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerWheelChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerWheelChanged += x, x => This.PointerWheelChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreIndependentInputSourceEvents
    {
        CoreIndependentInputSource This;

        public CoreIndependentInputSourceEvents(CoreIndependentInputSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.InputEnabledEventArgs> InputEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.InputEnabledEventArgs>, Windows.UI.Core.InputEnabledEventArgs>(x => This.InputEnabled += x, x => This.InputEnabled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerCaptureLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerCaptureLost += x, x => This.PointerCaptureLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerWheelChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerWheelChanged += x, x => This.PointerWheelChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreComponentInputSourceEvents
    {
        CoreComponentInputSource This;

        public CoreComponentInputSourceEvents(CoreComponentInputSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.InputEnabledEventArgs> InputEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.InputEnabledEventArgs>, Windows.UI.Core.InputEnabledEventArgs>(x => This.InputEnabled += x, x => This.InputEnabled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerCaptureLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerCaptureLost += x, x => This.PointerCaptureLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerWheelChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerWheelChanged += x, x => This.PointerWheelChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CharacterReceivedEventArgs> CharacterReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.CharacterReceivedEventArgs>, Windows.UI.Core.CharacterReceivedEventArgs>(x => This.CharacterReceived += x, x => This.CharacterReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CoreWindowEventArgs> GotFocus {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.CoreWindowEventArgs>, Windows.UI.Core.CoreWindowEventArgs>(x => This.GotFocus += x, x => This.GotFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CoreWindowEventArgs> LostFocus {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.CoreWindowEventArgs>, Windows.UI.Core.CoreWindowEventArgs>(x => This.LostFocus += x, x => This.LostFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.TouchHitTestingEventArgs> TouchHitTesting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Core.TouchHitTestingEventArgs>, Windows.UI.Core.TouchHitTestingEventArgs>(x => This.TouchHitTesting += x, x => This.TouchHitTesting -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.WebUI.Core
{
    public static class EventsMixin
    {
        public static WebUICommandBarIconButtonEvents Events(this WebUICommandBarIconButton This)
        {
            return new WebUICommandBarIconButtonEvents(This);
        }
        public static WebUICommandBarConfirmationButtonEvents Events(this WebUICommandBarConfirmationButton This)
        {
            return new WebUICommandBarConfirmationButtonEvents(This);
        }
    }

    public class WebUICommandBarIconButtonEvents
    {
        WebUICommandBarIconButton This;

        public WebUICommandBarIconButtonEvents(WebUICommandBarIconButton This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.WebUI.Core.WebUICommandBarItemInvokedEventArgs> ItemInvoked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.WebUI.Core.WebUICommandBarIconButton,Windows.UI.WebUI.Core.WebUICommandBarItemInvokedEventArgs>, Windows.UI.WebUI.Core.WebUICommandBarItemInvokedEventArgs>(x => This.ItemInvoked += x, x => This.ItemInvoked -= x).Select(x => x.EventArgs); }
        }

    }
    public class WebUICommandBarConfirmationButtonEvents
    {
        WebUICommandBarConfirmationButton This;

        public WebUICommandBarConfirmationButtonEvents(WebUICommandBarConfirmationButton This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.WebUI.Core.WebUICommandBarItemInvokedEventArgs> ItemInvoked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.WebUI.Core.WebUICommandBarConfirmationButton,Windows.UI.WebUI.Core.WebUICommandBarItemInvokedEventArgs>, Windows.UI.WebUI.Core.WebUICommandBarItemInvokedEventArgs>(x => This.ItemInvoked += x, x => This.ItemInvoked -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.WebUI
{
    public static class EventsMixin
    {
        public static WebUIBackgroundTaskInstanceRuntimeClassEvents Events(this WebUIBackgroundTaskInstanceRuntimeClass This)
        {
            return new WebUIBackgroundTaskInstanceRuntimeClassEvents(This);
        }
    }

    public class WebUIBackgroundTaskInstanceRuntimeClassEvents
    {
        WebUIBackgroundTaskInstanceRuntimeClass This;

        public WebUIBackgroundTaskInstanceRuntimeClassEvents(WebUIBackgroundTaskInstanceRuntimeClass This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Background.BackgroundTaskCancellationReason> Canceled {
            get { return Observable.FromEventPattern<Windows.ApplicationModel.Background.BackgroundTaskCanceledEventHandler, Windows.ApplicationModel.Background.BackgroundTaskCancellationReason>(x => This.Canceled += x, x => This.Canceled -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Controls
{
    public static class EventsMixin
    {
        public static GroupStyleEvents Events(this GroupStyle This)
        {
            return new GroupStyleEvents(This);
        }
        public static ItemCollectionEvents Events(this ItemCollection This)
        {
            return new ItemCollectionEvents(This);
        }
        public static ItemContainerGeneratorEvents Events(this ItemContainerGenerator This)
        {
            return new ItemContainerGeneratorEvents(This);
        }
        public static ImageEvents Events(this Image This)
        {
            return new ImageEvents(This);
        }
        public static ItemsPresenterEvents Events(this ItemsPresenter This)
        {
            return new ItemsPresenterEvents(This);
        }
        public static MediaElementEvents Events(this MediaElement This)
        {
            return new MediaElementEvents(This);
        }
        public static RichTextBlockEvents Events(this RichTextBlock This)
        {
            return new RichTextBlockEvents(This);
        }
        public static StackPanelEvents Events(this StackPanel This)
        {
            return new StackPanelEvents(This);
        }
        public static TextBlockEvents Events(this TextBlock This)
        {
            return new TextBlockEvents(This);
        }
        public static VirtualizingStackPanelEvents Events(this VirtualizingStackPanel This)
        {
            return new VirtualizingStackPanelEvents(This);
        }
        public static SwapChainPanelEvents Events(this SwapChainPanel This)
        {
            return new SwapChainPanelEvents(This);
        }
        public static WebViewEvents Events(this WebView This)
        {
            return new WebViewEvents(This);
        }
        public static ControlEvents Events(this Control This)
        {
            return new ControlEvents(This);
        }
        public static DatePickerEvents Events(this DatePicker This)
        {
            return new DatePickerEvents(This);
        }
        public static SemanticZoomEvents Events(this SemanticZoom This)
        {
            return new SemanticZoomEvents(This);
        }
        public static PasswordBoxEvents Events(this PasswordBox This)
        {
            return new PasswordBoxEvents(This);
        }
        public static RichEditBoxEvents Events(this RichEditBox This)
        {
            return new RichEditBoxEvents(This);
        }
        public static ScrollViewerEvents Events(this ScrollViewer This)
        {
            return new ScrollViewerEvents(This);
        }
        public static SettingsFlyoutEvents Events(this SettingsFlyout This)
        {
            return new SettingsFlyoutEvents(This);
        }
        public static TextBoxEvents Events(this TextBox This)
        {
            return new TextBoxEvents(This);
        }
        public static ToggleSwitchEvents Events(this ToggleSwitch This)
        {
            return new ToggleSwitchEvents(This);
        }
        public static ToolTipEvents Events(this ToolTip This)
        {
            return new ToolTipEvents(This);
        }
        public static ComboBoxEvents Events(this ComboBox This)
        {
            return new ComboBoxEvents(This);
        }
        public static ListViewBaseEvents Events(this ListViewBase This)
        {
            return new ListViewBaseEvents(This);
        }
        public static AppBarEvents Events(this AppBar This)
        {
            return new AppBarEvents(This);
        }
        public static ContentDialogEvents Events(this ContentDialog This)
        {
            return new ContentDialogEvents(This);
        }
        public static FrameEvents Events(this Frame This)
        {
            return new FrameEvents(This);
        }
        public static HubEvents Events(this Hub This)
        {
            return new HubEvents(This);
        }
        public static MenuFlyoutItemEvents Events(this MenuFlyoutItem This)
        {
            return new MenuFlyoutItemEvents(This);
        }
        public static TimePickerEvents Events(this TimePicker This)
        {
            return new TimePickerEvents(This);
        }
        public static AutoSuggestBoxEvents Events(this AutoSuggestBox This)
        {
            return new AutoSuggestBoxEvents(This);
        }
        public static PivotEvents Events(this Pivot This)
        {
            return new PivotEvents(This);
        }
        public static DatePickerFlyoutEvents Events(this DatePickerFlyout This)
        {
            return new DatePickerFlyoutEvents(This);
        }
        public static ListPickerFlyoutEvents Events(this ListPickerFlyout This)
        {
            return new ListPickerFlyoutEvents(This);
        }
        public static PickerFlyoutEvents Events(this PickerFlyout This)
        {
            return new PickerFlyoutEvents(This);
        }
        public static TimePickerFlyoutEvents Events(this TimePickerFlyout This)
        {
            return new TimePickerFlyoutEvents(This);
        }
    }

    public class GroupStyleEvents
    {
        GroupStyle This;

        public GroupStyleEvents(GroupStyle This)
        {
            this.This = This;
        }

        public IObservable<global::System.ComponentModel.PropertyChangedEventArgs> PropertyChanged {
            get { return Observable.FromEventPattern<global::System.ComponentModel.PropertyChangedEventHandler, global::System.ComponentModel.PropertyChangedEventArgs>(x => This.PropertyChanged += x, x => This.PropertyChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ItemCollectionEvents
    {
        ItemCollection This;

        public ItemCollectionEvents(ItemCollection This)
        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IVectorChangedEventArgs> VectorChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.VectorChangedEventHandler<object>, Windows.Foundation.Collections.IVectorChangedEventArgs>(x => This.VectorChanged += x, x => This.VectorChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ItemContainerGeneratorEvents
    {
        ItemContainerGenerator This;

        public ItemContainerGeneratorEvents(ItemContainerGenerator This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Primitives.ItemsChangedEventArgs> ItemsChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.Primitives.ItemsChangedEventHandler, Windows.UI.Xaml.Controls.Primitives.ItemsChangedEventArgs>(x => This.ItemsChanged += x, x => This.ItemsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ImageEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        Image This;

        public ImageEvents(Image This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.ExceptionRoutedEventArgs> ImageFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.ExceptionRoutedEventHandler, Windows.UI.Xaml.ExceptionRoutedEventArgs>(x => This.ImageFailed += x, x => This.ImageFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> ImageOpened {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.ImageOpened += x, x => This.ImageOpened -= x).Select(x => x.EventArgs); }
        }

    }
    public class ItemsPresenterEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        ItemsPresenter This;

        public ItemsPresenterEvents(ItemsPresenter This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> HorizontalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.HorizontalSnapPointsChanged += x, x => This.HorizontalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VerticalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.VerticalSnapPointsChanged += x, x => This.VerticalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaElementEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        MediaElement This;

        public MediaElementEvents(MediaElement This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> BufferingProgressChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.BufferingProgressChanged += x, x => This.BufferingProgressChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> CurrentStateChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.CurrentStateChanged += x, x => This.CurrentStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> DownloadProgressChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.DownloadProgressChanged += x, x => This.DownloadProgressChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs> MarkerReached {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Media.TimelineMarkerRoutedEventHandler, Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs>(x => This.MarkerReached += x, x => This.MarkerReached -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> MediaEnded {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.MediaEnded += x, x => This.MediaEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.ExceptionRoutedEventArgs> MediaFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.ExceptionRoutedEventHandler, Windows.UI.Xaml.ExceptionRoutedEventArgs>(x => This.MediaFailed += x, x => This.MediaFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> MediaOpened {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.MediaOpened += x, x => This.MediaOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Media.RateChangedRoutedEventArgs> RateChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Media.RateChangedRoutedEventHandler, Windows.UI.Xaml.Media.RateChangedRoutedEventArgs>(x => This.RateChanged += x, x => This.RateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> SeekCompleted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.SeekCompleted += x, x => This.SeekCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> VolumeChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.VolumeChanged += x, x => This.VolumeChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RichTextBlockEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        RichTextBlock This;

        public RichTextBlockEvents(RichTextBlock This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ContextMenuEventArgs> ContextMenuOpening {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.ContextMenuOpeningEventHandler, Windows.UI.Xaml.Controls.ContextMenuEventArgs>(x => This.ContextMenuOpening += x, x => This.ContextMenuOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class StackPanelEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        StackPanel This;

        public StackPanelEvents(StackPanel This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> HorizontalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.HorizontalSnapPointsChanged += x, x => This.HorizontalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VerticalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.VerticalSnapPointsChanged += x, x => This.VerticalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextBlockEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        TextBlock This;

        public TextBlockEvents(TextBlock This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ContextMenuEventArgs> ContextMenuOpening {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.ContextMenuOpeningEventHandler, Windows.UI.Xaml.Controls.ContextMenuEventArgs>(x => This.ContextMenuOpening += x, x => This.ContextMenuOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class VirtualizingStackPanelEvents
        : Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanelEvents
    {
        VirtualizingStackPanel This;

        public VirtualizingStackPanelEvents(VirtualizingStackPanel This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventArgs> CleanUpVirtualizedItemEvent {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventHandler, Windows.UI.Xaml.Controls.CleanUpVirtualizedItemEventArgs>(x => This.CleanUpVirtualizedItemEvent += x, x => This.CleanUpVirtualizedItemEvent -= x).Select(x => x.EventArgs); }
        }

    }
    public class SwapChainPanelEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        SwapChainPanel This;

        public SwapChainPanelEvents(SwapChainPanel This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> CompositionScaleChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SwapChainPanel,object>, object>(x => This.CompositionScaleChanged += x, x => This.CompositionScaleChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class WebViewEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        WebView This;

        public WebViewEvents(WebView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Navigation.NavigationEventArgs> LoadCompleted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Navigation.LoadCompletedEventHandler, Windows.UI.Xaml.Navigation.NavigationEventArgs>(x => This.LoadCompleted += x, x => This.LoadCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewNavigationFailedEventArgs> NavigationFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.WebViewNavigationFailedEventHandler, Windows.UI.Xaml.Controls.WebViewNavigationFailedEventArgs>(x => This.NavigationFailed += x, x => This.NavigationFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.NotifyEventArgs> ScriptNotify {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.NotifyEventHandler, Windows.UI.Xaml.Controls.NotifyEventArgs>(x => This.ScriptNotify += x, x => This.ScriptNotify -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs> ContentLoading {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs>, Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs>(x => This.ContentLoading += x, x => This.ContentLoading -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs> DOMContentLoaded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs>, Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs>(x => This.DOMContentLoaded += x, x => This.DOMContentLoaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs> FrameContentLoading {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs>, Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs>(x => This.FrameContentLoading += x, x => This.FrameContentLoading -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs> FrameDOMContentLoaded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs>, Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs>(x => This.FrameDOMContentLoaded += x, x => This.FrameDOMContentLoaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs> FrameNavigationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs>, Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs>(x => This.FrameNavigationCompleted += x, x => This.FrameNavigationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs> FrameNavigationStarting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs>, Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs>(x => This.FrameNavigationStarting += x, x => This.FrameNavigationStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs> LongRunningScriptDetected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs>, Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs>(x => This.LongRunningScriptDetected += x, x => This.LongRunningScriptDetected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs> NavigationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs>, Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs>(x => This.NavigationCompleted += x, x => This.NavigationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs> NavigationStarting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs>, Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs>(x => This.NavigationStarting += x, x => This.NavigationStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> UnsafeContentWarningDisplaying {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,object>, object>(x => This.UnsafeContentWarningDisplaying += x, x => This.UnsafeContentWarningDisplaying -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewUnviewableContentIdentifiedEventArgs> UnviewableContentIdentified {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewUnviewableContentIdentifiedEventArgs>, Windows.UI.Xaml.Controls.WebViewUnviewableContentIdentifiedEventArgs>(x => This.UnviewableContentIdentified += x, x => This.UnviewableContentIdentified -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ContainsFullScreenElementChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,object>, object>(x => This.ContainsFullScreenElementChanged += x, x => This.ContainsFullScreenElementChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ControlEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        Control This;

        public ControlEvents(Control This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.DependencyPropertyChangedEventArgs> IsEnabledChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.DependencyPropertyChangedEventHandler, Windows.UI.Xaml.DependencyPropertyChangedEventArgs>(x => This.IsEnabledChanged += x, x => This.IsEnabledChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class DatePickerEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        DatePicker This;

        public DatePickerEvents(DatePicker This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.DatePickerValueChangedEventArgs> DateChanged {
            get { return Observable.FromEventPattern<EventHandler<Windows.UI.Xaml.Controls.DatePickerValueChangedEventArgs>, Windows.UI.Xaml.Controls.DatePickerValueChangedEventArgs>(x => This.DateChanged += x, x => This.DateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class SemanticZoomEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        SemanticZoom This;

        public SemanticZoomEvents(SemanticZoom This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs> ViewChangeCompleted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventHandler, Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs>(x => This.ViewChangeCompleted += x, x => This.ViewChangeCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs> ViewChangeStarted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventHandler, Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs>(x => This.ViewChangeStarted += x, x => This.ViewChangeStarted -= x).Select(x => x.EventArgs); }
        }

    }
    public class PasswordBoxEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        PasswordBox This;

        public PasswordBoxEvents(PasswordBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ContextMenuEventArgs> ContextMenuOpening {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.ContextMenuOpeningEventHandler, Windows.UI.Xaml.Controls.ContextMenuEventArgs>(x => This.ContextMenuOpening += x, x => This.ContextMenuOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> PasswordChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.PasswordChanged += x, x => This.PasswordChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextControlPasteEventArgs> Paste {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.TextControlPasteEventHandler, Windows.UI.Xaml.Controls.TextControlPasteEventArgs>(x => This.Paste += x, x => This.Paste -= x).Select(x => x.EventArgs); }
        }

    }
    public class RichEditBoxEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        RichEditBox This;

        public RichEditBoxEvents(RichEditBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ContextMenuEventArgs> ContextMenuOpening {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.ContextMenuOpeningEventHandler, Windows.UI.Xaml.Controls.ContextMenuEventArgs>(x => This.ContextMenuOpening += x, x => This.ContextMenuOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> TextChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextControlPasteEventArgs> Paste {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.TextControlPasteEventHandler, Windows.UI.Xaml.Controls.TextControlPasteEventArgs>(x => This.Paste += x, x => This.Paste -= x).Select(x => x.EventArgs); }
        }

    }
    public class ScrollViewerEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        ScrollViewer This;

        public ScrollViewerEvents(ScrollViewer This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ScrollViewerViewChangedEventArgs> ViewChanged {
            get { return Observable.FromEventPattern<EventHandler<Windows.UI.Xaml.Controls.ScrollViewerViewChangedEventArgs>, Windows.UI.Xaml.Controls.ScrollViewerViewChangedEventArgs>(x => This.ViewChanged += x, x => This.ViewChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs> ViewChanging {
            get { return Observable.FromEventPattern<EventHandler<Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs>, Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs>(x => This.ViewChanging += x, x => This.ViewChanging -= x).Select(x => x.EventArgs); }
        }

    }
    public class SettingsFlyoutEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        SettingsFlyout This;

        public SettingsFlyoutEvents(SettingsFlyout This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.BackClickEventArgs> BackClick {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.BackClickEventHandler, Windows.UI.Xaml.Controls.BackClickEventArgs>(x => This.BackClick += x, x => This.BackClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextBoxEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        TextBox This;

        public TextBoxEvents(TextBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ContextMenuEventArgs> ContextMenuOpening {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.ContextMenuOpeningEventHandler, Windows.UI.Xaml.Controls.ContextMenuEventArgs>(x => This.ContextMenuOpening += x, x => This.ContextMenuOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextChangedEventArgs> TextChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.TextChangedEventHandler, Windows.UI.Xaml.Controls.TextChangedEventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextControlPasteEventArgs> Paste {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.TextControlPasteEventHandler, Windows.UI.Xaml.Controls.TextControlPasteEventArgs>(x => This.Paste += x, x => This.Paste -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToggleSwitchEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        ToggleSwitch This;

        public ToggleSwitchEvents(ToggleSwitch This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Toggled {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Toggled += x, x => This.Toggled -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToolTipEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        ToolTip This;

        public ToolTipEvents(ToolTip This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Opened {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

    }
    public class ComboBoxEvents
        : Windows.UI.Xaml.Controls.Primitives.SelectorEvents
    {
        ComboBox This;

        public ComboBoxEvents(ComboBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> DropDownClosed {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.DropDownClosed += x, x => This.DropDownClosed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> DropDownOpened {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.DropDownOpened += x, x => This.DropDownOpened -= x).Select(x => x.EventArgs); }
        }

    }
    public class ListViewBaseEvents
        : Windows.UI.Xaml.Controls.Primitives.SelectorEvents
    {
        ListViewBase This;

        public ListViewBaseEvents(ListViewBase This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.DragItemsStartingEventArgs> DragItemsStarting {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.DragItemsStartingEventHandler, Windows.UI.Xaml.Controls.DragItemsStartingEventArgs>(x => This.DragItemsStarting += x, x => This.DragItemsStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.ItemClickEventArgs> ItemClick {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.ItemClickEventHandler, Windows.UI.Xaml.Controls.ItemClickEventArgs>(x => This.ItemClick += x, x => This.ItemClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs> ContainerContentChanging {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.ListViewBase,Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs>, Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs>(x => This.ContainerContentChanging += x, x => This.ContainerContentChanging -= x).Select(x => x.EventArgs); }
        }

    }
    public class AppBarEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        AppBar This;

        public AppBarEvents(AppBar This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> Closed {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Opened {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

    }
    public class ContentDialogEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        ContentDialog This;

        public ContentDialogEvents(ContentDialog This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ContentDialogClosedEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.ContentDialog,Windows.UI.Xaml.Controls.ContentDialogClosedEventArgs>, Windows.UI.Xaml.Controls.ContentDialogClosedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.ContentDialogClosingEventArgs> Closing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.ContentDialog,Windows.UI.Xaml.Controls.ContentDialogClosingEventArgs>, Windows.UI.Xaml.Controls.ContentDialogClosingEventArgs>(x => This.Closing += x, x => This.Closing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.ContentDialogOpenedEventArgs> Opened {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.ContentDialog,Windows.UI.Xaml.Controls.ContentDialogOpenedEventArgs>, Windows.UI.Xaml.Controls.ContentDialogOpenedEventArgs>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.ContentDialogButtonClickEventArgs> PrimaryButtonClick {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.ContentDialog,Windows.UI.Xaml.Controls.ContentDialogButtonClickEventArgs>, Windows.UI.Xaml.Controls.ContentDialogButtonClickEventArgs>(x => This.PrimaryButtonClick += x, x => This.PrimaryButtonClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.ContentDialogButtonClickEventArgs> SecondaryButtonClick {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.ContentDialog,Windows.UI.Xaml.Controls.ContentDialogButtonClickEventArgs>, Windows.UI.Xaml.Controls.ContentDialogButtonClickEventArgs>(x => This.SecondaryButtonClick += x, x => This.SecondaryButtonClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class FrameEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        Frame This;

        public FrameEvents(Frame This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Navigation.NavigationEventArgs> Navigated {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Navigation.NavigatedEventHandler, Windows.UI.Xaml.Navigation.NavigationEventArgs>(x => This.Navigated += x, x => This.Navigated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs> Navigating {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Navigation.NavigatingCancelEventHandler, Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs>(x => This.Navigating += x, x => This.Navigating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Navigation.NavigationFailedEventArgs> NavigationFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Navigation.NavigationFailedEventHandler, Windows.UI.Xaml.Navigation.NavigationFailedEventArgs>(x => This.NavigationFailed += x, x => This.NavigationFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Navigation.NavigationEventArgs> NavigationStopped {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Navigation.NavigationStoppedEventHandler, Windows.UI.Xaml.Navigation.NavigationEventArgs>(x => This.NavigationStopped += x, x => This.NavigationStopped -= x).Select(x => x.EventArgs); }
        }

    }
    public class HubEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        Hub This;

        public HubEvents(Hub This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.HubSectionHeaderClickEventArgs> SectionHeaderClick {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.HubSectionHeaderClickEventHandler, Windows.UI.Xaml.Controls.HubSectionHeaderClickEventArgs>(x => This.SectionHeaderClick += x, x => This.SectionHeaderClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SectionsInViewChangedEventArgs> SectionsInViewChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.SectionsInViewChangedEventHandler, Windows.UI.Xaml.Controls.SectionsInViewChangedEventArgs>(x => This.SectionsInViewChanged += x, x => This.SectionsInViewChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MenuFlyoutItemEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        MenuFlyoutItem This;

        public MenuFlyoutItemEvents(MenuFlyoutItem This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Click {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class TimePickerEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        TimePicker This;

        public TimePickerEvents(TimePicker This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.TimePickerValueChangedEventArgs> TimeChanged {
            get { return Observable.FromEventPattern<EventHandler<Windows.UI.Xaml.Controls.TimePickerValueChangedEventArgs>, Windows.UI.Xaml.Controls.TimePickerValueChangedEventArgs>(x => This.TimeChanged += x, x => This.TimeChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class AutoSuggestBoxEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        AutoSuggestBox This;

        public AutoSuggestBoxEvents(AutoSuggestBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.AutoSuggestBoxSuggestionChosenEventArgs> SuggestionChosen {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.AutoSuggestBox,Windows.UI.Xaml.Controls.AutoSuggestBoxSuggestionChosenEventArgs>, Windows.UI.Xaml.Controls.AutoSuggestBoxSuggestionChosenEventArgs>(x => This.SuggestionChosen += x, x => This.SuggestionChosen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.AutoSuggestBoxTextChangedEventArgs> TextChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.AutoSuggestBox,Windows.UI.Xaml.Controls.AutoSuggestBoxTextChangedEventArgs>, Windows.UI.Xaml.Controls.AutoSuggestBoxTextChangedEventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PivotEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        Pivot This;

        public PivotEvents(Pivot This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.PivotItemEventArgs> PivotItemLoaded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Pivot,Windows.UI.Xaml.Controls.PivotItemEventArgs>, Windows.UI.Xaml.Controls.PivotItemEventArgs>(x => This.PivotItemLoaded += x, x => This.PivotItemLoaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.PivotItemEventArgs> PivotItemLoading {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Pivot,Windows.UI.Xaml.Controls.PivotItemEventArgs>, Windows.UI.Xaml.Controls.PivotItemEventArgs>(x => This.PivotItemLoading += x, x => This.PivotItemLoading -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.PivotItemEventArgs> PivotItemUnloaded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Pivot,Windows.UI.Xaml.Controls.PivotItemEventArgs>, Windows.UI.Xaml.Controls.PivotItemEventArgs>(x => This.PivotItemUnloaded += x, x => This.PivotItemUnloaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.PivotItemEventArgs> PivotItemUnloading {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Pivot,Windows.UI.Xaml.Controls.PivotItemEventArgs>, Windows.UI.Xaml.Controls.PivotItemEventArgs>(x => This.PivotItemUnloading += x, x => This.PivotItemUnloading -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.SelectionChangedEventHandler, Windows.UI.Xaml.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class DatePickerFlyoutEvents
        : Windows.UI.Xaml.Controls.Primitives.FlyoutBaseEvents
    {
        DatePickerFlyout This;

        public DatePickerFlyoutEvents(DatePickerFlyout This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.DatePickedEventArgs> DatePicked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.DatePickerFlyout,Windows.UI.Xaml.Controls.DatePickedEventArgs>, Windows.UI.Xaml.Controls.DatePickedEventArgs>(x => This.DatePicked += x, x => This.DatePicked -= x).Select(x => x.EventArgs); }
        }

    }
    public class ListPickerFlyoutEvents
        : Windows.UI.Xaml.Controls.Primitives.FlyoutBaseEvents
    {
        ListPickerFlyout This;

        public ListPickerFlyoutEvents(ListPickerFlyout This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.ItemsPickedEventArgs> ItemsPicked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.ListPickerFlyout,Windows.UI.Xaml.Controls.ItemsPickedEventArgs>, Windows.UI.Xaml.Controls.ItemsPickedEventArgs>(x => This.ItemsPicked += x, x => This.ItemsPicked -= x).Select(x => x.EventArgs); }
        }

    }
    public class PickerFlyoutEvents
        : Windows.UI.Xaml.Controls.Primitives.FlyoutBaseEvents
    {
        PickerFlyout This;

        public PickerFlyoutEvents(PickerFlyout This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.PickerConfirmedEventArgs> Confirmed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.PickerFlyout,Windows.UI.Xaml.Controls.PickerConfirmedEventArgs>, Windows.UI.Xaml.Controls.PickerConfirmedEventArgs>(x => This.Confirmed += x, x => This.Confirmed -= x).Select(x => x.EventArgs); }
        }

    }
    public class TimePickerFlyoutEvents
        : Windows.UI.Xaml.Controls.Primitives.FlyoutBaseEvents
    {
        TimePickerFlyout This;

        public TimePickerFlyoutEvents(TimePickerFlyout This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.TimePickedEventArgs> TimePicked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.TimePickerFlyout,Windows.UI.Xaml.Controls.TimePickedEventArgs>, Windows.UI.Xaml.Controls.TimePickedEventArgs>(x => This.TimePicked += x, x => This.TimePicked -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Controls.Primitives
{
    public static class EventsMixin
    {
        public static IScrollSnapPointsInfoEvents Events(this IScrollSnapPointsInfo This)
        {
            return new IScrollSnapPointsInfoEvents(This);
        }
        public static FlyoutBaseEvents Events(this FlyoutBase This)
        {
            return new FlyoutBaseEvents(This);
        }
        public static CarouselPanelEvents Events(this CarouselPanel This)
        {
            return new CarouselPanelEvents(This);
        }
        public static OrientedVirtualizingPanelEvents Events(this OrientedVirtualizingPanel This)
        {
            return new OrientedVirtualizingPanelEvents(This);
        }
        public static PopupEvents Events(this Popup This)
        {
            return new PopupEvents(This);
        }
        public static ButtonBaseEvents Events(this ButtonBase This)
        {
            return new ButtonBaseEvents(This);
        }
        public static RangeBaseEvents Events(this RangeBase This)
        {
            return new RangeBaseEvents(This);
        }
        public static ScrollBarEvents Events(this ScrollBar This)
        {
            return new ScrollBarEvents(This);
        }
        public static SelectorEvents Events(this Selector This)
        {
            return new SelectorEvents(This);
        }
        public static ThumbEvents Events(this Thumb This)
        {
            return new ThumbEvents(This);
        }
        public static ToggleButtonEvents Events(this ToggleButton This)
        {
            return new ToggleButtonEvents(This);
        }
        public static LoopingSelectorEvents Events(this LoopingSelector This)
        {
            return new LoopingSelectorEvents(This);
        }
        public static LoopingSelectorPanelEvents Events(this LoopingSelectorPanel This)
        {
            return new LoopingSelectorPanelEvents(This);
        }
        public static PivotPanelEvents Events(this PivotPanel This)
        {
            return new PivotPanelEvents(This);
        }
    }

    public class IScrollSnapPointsInfoEvents
    {
        IScrollSnapPointsInfo This;

        public IScrollSnapPointsInfoEvents(IScrollSnapPointsInfo This)
        {
            this.This = This;
        }

        public IObservable<object> HorizontalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.HorizontalSnapPointsChanged += x, x => This.HorizontalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VerticalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.VerticalSnapPointsChanged += x, x => This.VerticalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class FlyoutBaseEvents
    {
        FlyoutBase This;

        public FlyoutBaseEvents(FlyoutBase This)
        {
            this.This = This;
        }

        public IObservable<object> Closed {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Opened {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Opening {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Opening += x, x => This.Opening -= x).Select(x => x.EventArgs); }
        }

    }
    public class CarouselPanelEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        CarouselPanel This;

        public CarouselPanelEvents(CarouselPanel This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> HorizontalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.HorizontalSnapPointsChanged += x, x => This.HorizontalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VerticalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.VerticalSnapPointsChanged += x, x => This.VerticalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class OrientedVirtualizingPanelEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        OrientedVirtualizingPanel This;

        public OrientedVirtualizingPanelEvents(OrientedVirtualizingPanel This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> HorizontalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.HorizontalSnapPointsChanged += x, x => This.HorizontalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VerticalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.VerticalSnapPointsChanged += x, x => This.VerticalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PopupEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        Popup This;

        public PopupEvents(Popup This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> Closed {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Opened {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

    }
    public class ButtonBaseEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        ButtonBase This;

        public ButtonBaseEvents(ButtonBase This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Click {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class RangeBaseEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        RangeBase This;

        public RangeBaseEvents(RangeBase This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs> ValueChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventHandler, Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ScrollBarEvents
        : Windows.UI.Xaml.Controls.Primitives.RangeBaseEvents
    {
        ScrollBar This;

        public ScrollBarEvents(ScrollBar This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Primitives.ScrollEventArgs> Scroll {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.Primitives.ScrollEventHandler, Windows.UI.Xaml.Controls.Primitives.ScrollEventArgs>(x => This.Scroll += x, x => This.Scroll -= x).Select(x => x.EventArgs); }
        }

    }
    public class SelectorEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        Selector This;

        public SelectorEvents(Selector This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.SelectionChangedEventHandler, Windows.UI.Xaml.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ThumbEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        Thumb This;

        public ThumbEvents(Thumb This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs> DragCompleted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.Primitives.DragCompletedEventHandler, Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs>(x => This.DragCompleted += x, x => This.DragCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Primitives.DragDeltaEventArgs> DragDelta {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.Primitives.DragDeltaEventHandler, Windows.UI.Xaml.Controls.Primitives.DragDeltaEventArgs>(x => This.DragDelta += x, x => This.DragDelta -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Primitives.DragStartedEventArgs> DragStarted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.Primitives.DragStartedEventHandler, Windows.UI.Xaml.Controls.Primitives.DragStartedEventArgs>(x => This.DragStarted += x, x => This.DragStarted -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToggleButtonEvents
        : Windows.UI.Xaml.Controls.Primitives.ButtonBaseEvents
    {
        ToggleButton This;

        public ToggleButtonEvents(ToggleButton This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Checked {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Checked += x, x => This.Checked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Indeterminate {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Indeterminate += x, x => This.Indeterminate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Unchecked {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Unchecked += x, x => This.Unchecked -= x).Select(x => x.EventArgs); }
        }

    }
    public class LoopingSelectorEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        LoopingSelector This;

        public LoopingSelectorEvents(LoopingSelector This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.SelectionChangedEventHandler, Windows.UI.Xaml.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class LoopingSelectorPanelEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        LoopingSelectorPanel This;

        public LoopingSelectorPanelEvents(LoopingSelectorPanel This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> HorizontalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.HorizontalSnapPointsChanged += x, x => This.HorizontalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VerticalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.VerticalSnapPointsChanged += x, x => This.VerticalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PivotPanelEvents
        : Windows.UI.Xaml.FrameworkElementEvents
    {
        PivotPanel This;

        public PivotPanelEvents(PivotPanel This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> HorizontalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.HorizontalSnapPointsChanged += x, x => This.HorizontalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VerticalSnapPointsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.VerticalSnapPointsChanged += x, x => This.VerticalSnapPointsChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Documents
{
    public static class EventsMixin
    {
        public static HyperlinkEvents Events(this Hyperlink This)
        {
            return new HyperlinkEvents(This);
        }
    }

    public class HyperlinkEvents
    {
        Hyperlink This;

        public HyperlinkEvents(Hyperlink This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Documents.HyperlinkClickEventArgs> Click {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Documents.Hyperlink,Windows.UI.Xaml.Documents.HyperlinkClickEventArgs>, Windows.UI.Xaml.Documents.HyperlinkClickEventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml
{
    public static class EventsMixin
    {
        public static DebugSettingsEvents Events(this DebugSettings This)
        {
            return new DebugSettingsEvents(This);
        }
        public static DependencyObjectCollectionEvents Events(this DependencyObjectCollection This)
        {
            return new DependencyObjectCollectionEvents(This);
        }
        public static DispatcherTimerEvents Events(this DispatcherTimer This)
        {
            return new DispatcherTimerEvents(This);
        }
        public static ApplicationEvents Events(this Application This)
        {
            return new ApplicationEvents(This);
        }
        public static UIElementEvents Events(this UIElement This)
        {
            return new UIElementEvents(This);
        }
        public static FrameworkElementEvents Events(this FrameworkElement This)
        {
            return new FrameworkElementEvents(This);
        }
        public static VisualStateGroupEvents Events(this VisualStateGroup This)
        {
            return new VisualStateGroupEvents(This);
        }
        public static WindowEvents Events(this Window This)
        {
            return new WindowEvents(This);
        }
    }

    public class DebugSettingsEvents
    {
        DebugSettings This;

        public DebugSettingsEvents(DebugSettings This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.BindingFailedEventArgs> BindingFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.BindingFailedEventHandler, Windows.UI.Xaml.BindingFailedEventArgs>(x => This.BindingFailed += x, x => This.BindingFailed -= x).Select(x => x.EventArgs); }
        }

    }
    public class DependencyObjectCollectionEvents
    {
        DependencyObjectCollection This;

        public DependencyObjectCollectionEvents(DependencyObjectCollection This)
        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IVectorChangedEventArgs> VectorChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.VectorChangedEventHandler<Windows.UI.Xaml.DependencyObject>, Windows.Foundation.Collections.IVectorChangedEventArgs>(x => This.VectorChanged += x, x => This.VectorChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class DispatcherTimerEvents
    {
        DispatcherTimer This;

        public DispatcherTimerEvents(DispatcherTimer This)
        {
            this.This = This;
        }

        public IObservable<object> Tick {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Tick += x, x => This.Tick -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationEvents
    {
        Application This;

        public ApplicationEvents(Application This)
        {
            this.This = This;
        }

        public IObservable<object> Resuming {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Resuming += x, x => This.Resuming -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.SuspendingEventArgs> Suspending {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.SuspendingEventHandler, Windows.ApplicationModel.SuspendingEventArgs>(x => This.Suspending += x, x => This.Suspending -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.UnhandledExceptionEventArgs> UnhandledException {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.UnhandledExceptionEventHandler, Windows.UI.Xaml.UnhandledExceptionEventArgs>(x => This.UnhandledException += x, x => This.UnhandledException -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIElementEvents
    {
        UIElement This;

        public UIElementEvents(UIElement This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs> DoubleTapped {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.DoubleTappedEventHandler, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs>(x => This.DoubleTapped += x, x => This.DoubleTapped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.DragEventArgs> DragEnter {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.DragEventHandler, Windows.UI.Xaml.DragEventArgs>(x => This.DragEnter += x, x => This.DragEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.DragEventArgs> DragLeave {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.DragEventHandler, Windows.UI.Xaml.DragEventArgs>(x => This.DragLeave += x, x => This.DragLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.DragEventArgs> DragOver {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.DragEventHandler, Windows.UI.Xaml.DragEventArgs>(x => This.DragOver += x, x => This.DragOver -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.DragEventArgs> Drop {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.DragEventHandler, Windows.UI.Xaml.DragEventArgs>(x => This.Drop += x, x => This.Drop -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> GotFocus {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.GotFocus += x, x => This.GotFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.HoldingRoutedEventArgs> Holding {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.HoldingEventHandler, Windows.UI.Xaml.Input.HoldingRoutedEventArgs>(x => This.Holding += x, x => This.Holding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.KeyRoutedEventArgs> KeyDown {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.KeyEventHandler, Windows.UI.Xaml.Input.KeyRoutedEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.KeyRoutedEventArgs> KeyUp {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.KeyEventHandler, Windows.UI.Xaml.Input.KeyRoutedEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> LostFocus {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.LostFocus += x, x => This.LostFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs> ManipulationCompleted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.ManipulationCompletedEventHandler, Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs>(x => This.ManipulationCompleted += x, x => This.ManipulationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs> ManipulationDelta {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.ManipulationDeltaEventHandler, Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs>(x => This.ManipulationDelta += x, x => This.ManipulationDelta -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs> ManipulationInertiaStarting {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.ManipulationInertiaStartingEventHandler, Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs>(x => This.ManipulationInertiaStarting += x, x => This.ManipulationInertiaStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs> ManipulationStarted {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.ManipulationStartedEventHandler, Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs>(x => This.ManipulationStarted += x, x => This.ManipulationStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs> ManipulationStarting {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.ManipulationStartingEventHandler, Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs>(x => This.ManipulationStarting += x, x => This.ManipulationStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerCanceled {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerCanceled += x, x => This.PointerCanceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerCaptureLost {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerCaptureLost += x, x => This.PointerCaptureLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.PointerRoutedEventArgs> PointerWheelChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.PointerEventHandler, Windows.UI.Xaml.Input.PointerRoutedEventArgs>(x => This.PointerWheelChanged += x, x => This.PointerWheelChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.RightTappedRoutedEventArgs> RightTapped {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.RightTappedEventHandler, Windows.UI.Xaml.Input.RightTappedRoutedEventArgs>(x => This.RightTapped += x, x => This.RightTapped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.TappedRoutedEventArgs> Tapped {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Input.TappedEventHandler, Windows.UI.Xaml.Input.TappedRoutedEventArgs>(x => This.Tapped += x, x => This.Tapped -= x).Select(x => x.EventArgs); }
        }

    }
    public class FrameworkElementEvents
        : Windows.UI.Xaml.UIElementEvents
    {
        FrameworkElement This;

        public FrameworkElementEvents(FrameworkElement This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> LayoutUpdated {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.LayoutUpdated += x, x => This.LayoutUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Loaded {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Loaded += x, x => This.Loaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.SizeChangedEventArgs> SizeChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.SizeChangedEventHandler, Windows.UI.Xaml.SizeChangedEventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> Unloaded {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.Unloaded += x, x => This.Unloaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.DataContextChangedEventArgs> DataContextChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.FrameworkElement,Windows.UI.Xaml.DataContextChangedEventArgs>, Windows.UI.Xaml.DataContextChangedEventArgs>(x => This.DataContextChanged += x, x => This.DataContextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class VisualStateGroupEvents
    {
        VisualStateGroup This;

        public VisualStateGroupEvents(VisualStateGroup This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.VisualStateChangedEventArgs> CurrentStateChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.VisualStateChangedEventHandler, Windows.UI.Xaml.VisualStateChangedEventArgs>(x => This.CurrentStateChanged += x, x => This.CurrentStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.VisualStateChangedEventArgs> CurrentStateChanging {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.VisualStateChangedEventHandler, Windows.UI.Xaml.VisualStateChangedEventArgs>(x => This.CurrentStateChanging += x, x => This.CurrentStateChanging -= x).Select(x => x.EventArgs); }
        }

    }
    public class WindowEvents
    {
        Window This;

        public WindowEvents(Window This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.WindowActivatedEventArgs> Activated {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.WindowActivatedEventHandler, Windows.UI.Core.WindowActivatedEventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.CoreWindowEventArgs> Closed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.WindowClosedEventHandler, Windows.UI.Core.CoreWindowEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.WindowSizeChangedEventArgs> SizeChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.WindowSizeChangedEventHandler, Windows.UI.Core.WindowSizeChangedEventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.VisibilityChangedEventArgs> VisibilityChanged {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.WindowVisibilityChangedEventHandler, Windows.UI.Core.VisibilityChangedEventArgs>(x => This.VisibilityChanged += x, x => This.VisibilityChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Media
{
    public static class EventsMixin
    {
        public static ImageBrushEvents Events(this ImageBrush This)
        {
            return new ImageBrushEvents(This);
        }
    }

    public class ImageBrushEvents
    {
        ImageBrush This;

        public ImageBrushEvents(ImageBrush This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.ExceptionRoutedEventArgs> ImageFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.ExceptionRoutedEventHandler, Windows.UI.Xaml.ExceptionRoutedEventArgs>(x => This.ImageFailed += x, x => This.ImageFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> ImageOpened {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.ImageOpened += x, x => This.ImageOpened -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Media.Animation
{
    public static class EventsMixin
    {
        public static TimelineEvents Events(this Timeline This)
        {
            return new TimelineEvents(This);
        }
    }

    public class TimelineEvents
    {
        Timeline This;

        public TimelineEvents(Timeline This)
        {
            this.This = This;
        }

        public IObservable<object> Completed {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Media.Imaging
{
    public static class EventsMixin
    {
        public static BitmapImageEvents Events(this BitmapImage This)
        {
            return new BitmapImageEvents(This);
        }
    }

    public class BitmapImageEvents
    {
        BitmapImage This;

        public BitmapImageEvents(BitmapImage This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Media.Imaging.DownloadProgressEventArgs> DownloadProgress {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Media.Imaging.DownloadProgressEventHandler, Windows.UI.Xaml.Media.Imaging.DownloadProgressEventArgs>(x => This.DownloadProgress += x, x => This.DownloadProgress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.ExceptionRoutedEventArgs> ImageFailed {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.ExceptionRoutedEventHandler, Windows.UI.Xaml.ExceptionRoutedEventArgs>(x => This.ImageFailed += x, x => This.ImageFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> ImageOpened {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.RoutedEventHandler, Windows.UI.Xaml.RoutedEventArgs>(x => This.ImageOpened += x, x => This.ImageOpened -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Controls.Maps
{
    public static class EventsMixin
    {
        public static MapControlEvents Events(this MapControl This)
        {
            return new MapControlEvents(This);
        }
        public static CustomMapTileDataSourceEvents Events(this CustomMapTileDataSource This)
        {
            return new CustomMapTileDataSourceEvents(This);
        }
        public static HttpMapTileDataSourceEvents Events(this HttpMapTileDataSource This)
        {
            return new HttpMapTileDataSourceEvents(This);
        }
        public static LocalMapTileDataSourceEvents Events(this LocalMapTileDataSource This)
        {
            return new LocalMapTileDataSourceEvents(This);
        }
    }

    public class MapControlEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        MapControl This;

        public MapControlEvents(MapControl This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> CenterChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,object>, object>(x => This.CenterChanged += x, x => This.CenterChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> HeadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,object>, object>(x => This.HeadingChanged += x, x => This.HeadingChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> LoadingStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,object>, object>(x => This.LoadingStatusChanged += x, x => This.LoadingStatusChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapInputEventArgs> MapDoubleTapped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapInputEventArgs>, Windows.UI.Xaml.Controls.Maps.MapInputEventArgs>(x => This.MapDoubleTapped += x, x => This.MapDoubleTapped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapInputEventArgs> MapHolding {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapInputEventArgs>, Windows.UI.Xaml.Controls.Maps.MapInputEventArgs>(x => This.MapHolding += x, x => This.MapHolding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapInputEventArgs> MapTapped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapInputEventArgs>, Windows.UI.Xaml.Controls.Maps.MapInputEventArgs>(x => This.MapTapped += x, x => This.MapTapped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> PitchChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,object>, object>(x => This.PitchChanged += x, x => This.PitchChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> TransformOriginChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,object>, object>(x => This.TransformOriginChanged += x, x => This.TransformOriginChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ZoomLevelChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,object>, object>(x => This.ZoomLevelChanged += x, x => This.ZoomLevelChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CustomMapTileDataSourceEvents
    {
        CustomMapTileDataSource This;

        public CustomMapTileDataSourceEvents(CustomMapTileDataSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequestedEventArgs> BitmapRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.CustomMapTileDataSource,Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequestedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapTileBitmapRequestedEventArgs>(x => This.BitmapRequested += x, x => This.BitmapRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class HttpMapTileDataSourceEvents
    {
        HttpMapTileDataSource This;

        public HttpMapTileDataSourceEvents(HttpMapTileDataSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapTileUriRequestedEventArgs> UriRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.HttpMapTileDataSource,Windows.UI.Xaml.Controls.Maps.MapTileUriRequestedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapTileUriRequestedEventArgs>(x => This.UriRequested += x, x => This.UriRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class LocalMapTileDataSourceEvents
    {
        LocalMapTileDataSource This;

        public LocalMapTileDataSourceEvents(LocalMapTileDataSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapTileUriRequestedEventArgs> UriRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.LocalMapTileDataSource,Windows.UI.Xaml.Controls.Maps.MapTileUriRequestedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapTileUriRequestedEventArgs>(x => This.UriRequested += x, x => This.UriRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Foundation.Diagnostics
{
    public static class EventsMixin
    {
        public static ILoggingChannelEvents Events(this ILoggingChannel This)
        {
            return new ILoggingChannelEvents(This);
        }
        public static LoggingChannelEvents Events(this LoggingChannel This)
        {
            return new LoggingChannelEvents(This);
        }
        public static IFileLoggingSessionEvents Events(this IFileLoggingSession This)
        {
            return new IFileLoggingSessionEvents(This);
        }
        public static FileLoggingSessionEvents Events(this FileLoggingSession This)
        {
            return new FileLoggingSessionEvents(This);
        }
    }

    public class ILoggingChannelEvents
    {
        ILoggingChannel This;

        public ILoggingChannelEvents(ILoggingChannel This)
        {
            this.This = This;
        }

        public IObservable<object> LoggingEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Foundation.Diagnostics.ILoggingChannel,object>, object>(x => This.LoggingEnabled += x, x => This.LoggingEnabled -= x).Select(x => x.EventArgs); }
        }

    }
    public class LoggingChannelEvents
    {
        LoggingChannel This;

        public LoggingChannelEvents(LoggingChannel This)
        {
            this.This = This;
        }

        public IObservable<object> LoggingEnabled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Foundation.Diagnostics.ILoggingChannel,object>, object>(x => This.LoggingEnabled += x, x => This.LoggingEnabled -= x).Select(x => x.EventArgs); }
        }

    }
    public class IFileLoggingSessionEvents
    {
        IFileLoggingSession This;

        public IFileLoggingSessionEvents(IFileLoggingSession This)
        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs> LogFileGenerated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Foundation.Diagnostics.IFileLoggingSession,Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs>, Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs>(x => This.LogFileGenerated += x, x => This.LogFileGenerated -= x).Select(x => x.EventArgs); }
        }

    }
    public class FileLoggingSessionEvents
    {
        FileLoggingSession This;

        public FileLoggingSessionEvents(FileLoggingSession This)
        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs> LogFileGenerated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Foundation.Diagnostics.IFileLoggingSession,Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs>, Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs>(x => This.LogFileGenerated += x, x => This.LogFileGenerated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Networking.PushNotifications
{
    public static class EventsMixin
    {
        public static PushNotificationChannelEvents Events(this PushNotificationChannel This)
        {
            return new PushNotificationChannelEvents(This);
        }
    }

    public class PushNotificationChannelEvents
    {
        PushNotificationChannel This;

        public PushNotificationChannelEvents(PushNotificationChannel This)
        {
            this.This = This;
        }

        public IObservable<Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs> PushNotificationReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.PushNotifications.PushNotificationChannel,Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs>, Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs>(x => This.PushNotificationReceived += x, x => This.PushNotificationReceived -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Notifications
{
    public static class EventsMixin
    {
        public static ToastNotificationEvents Events(this ToastNotification This)
        {
            return new ToastNotificationEvents(This);
        }
    }

    public class ToastNotificationEvents
    {
        ToastNotification This;

        public ToastNotificationEvents(ToastNotification This)
        {
            this.This = This;
        }

        public IObservable<object> Activated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Notifications.ToastNotification,object>, object>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Notifications.ToastDismissedEventArgs> Dismissed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Notifications.ToastNotification,Windows.UI.Notifications.ToastDismissedEventArgs>, Windows.UI.Notifications.ToastDismissedEventArgs>(x => This.Dismissed += x, x => This.Dismissed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Notifications.ToastFailedEventArgs> Failed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Notifications.ToastNotification,Windows.UI.Notifications.ToastFailedEventArgs>, Windows.UI.Notifications.ToastFailedEventArgs>(x => This.Failed += x, x => This.Failed -= x).Select(x => x.EventArgs); }
        }

    }
}


#pragma warning restore 1591,0618,0105,0672

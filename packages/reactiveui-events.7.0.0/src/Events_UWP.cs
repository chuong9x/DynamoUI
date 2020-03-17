#pragma warning disable 1591,0618,0105,0672

using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using ReactiveUI.Events;

using Windows.ApplicationModel.Calls;
using Windows.ApplicationModel.Preview.Notes;
using Windows.ApplicationModel.Search.Core;
using Windows.ApplicationModel.Search;
using Windows.Devices.Gpio.Provider;
using Windows.Devices.Gpio;
using Windows.Devices.Printers.Extensions;
using Windows.Devices.SmartCards;
using Windows.Devices.Sms;
using Windows.Foundation.Collections;
using Windows.UI.ApplicationSettings;
using Windows.ApplicationModel.AppService;
using Windows.UI.ViewManagement;
using Windows.ApplicationModel.Appointments;
using Windows.ApplicationModel.Appointments.DataProvider;
using Windows.ApplicationModel.Background;
using Windows.Devices.Power;
using Windows.ApplicationModel.Chat;
using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.Contacts.DataProvider;
using Windows.ApplicationModel.Contacts.Provider;
using Windows.ApplicationModel.DataTransfer;
using Windows.Graphics.Display;
using Windows.ApplicationModel.DataTransfer.DragDrop.Core;
using Windows.UI.Input;
using Windows.ApplicationModel.Email;
using Windows.ApplicationModel.Email.DataProvider;
using Windows.ApplicationModel.ExtendedExecution;
using Windows.ApplicationModel.ExtendedExecution.Foreground;
using Windows.Storage.Pickers.Provider;
using Windows.Storage.Provider;
using Windows.Networking.NetworkOperators;
using Windows.System.RemoteSystems;
using Windows.UI.StartScreen;
using Windows.Storage;
using Windows.Storage.Search;
using Windows.Storage.AccessCache;
using Windows.Storage.BulkAccess;
using Windows.ApplicationModel.UserDataAccounts;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.AppExtensions;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.LockScreen;
using Windows.ApplicationModel.Resources.Core;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using Windows.ApplicationModel.VoiceCommands;
using Windows.ApplicationModel;
using Windows.Devices.AllJoyn;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Devices.Enumeration;
using Windows.Devices.Enumeration.Pnp;
using Windows.Devices.Geolocation.Geofencing;
using Windows.Devices.Geolocation;
using Windows.Devices.HumanInterfaceDevice;
using Windows.Devices.Input;
using Windows.Devices.Lights;
using Windows.Devices.Midi;
using Windows.Devices.Perception;
using Windows.Devices.PointOfService;
using Windows.Devices.Radios;
using Windows.Devices.Sensors;
using Windows.Devices.Sensors.Custom;
using Windows.Devices.SerialCommunication;
using Windows.Devices.Usb;
using Windows.Devices.WiFi;
using Windows.Devices.WiFiDirect;
using Windows.Devices.WiFiDirect.Services;
using Windows.Foundation;
using Windows.Gaming.Input;
using Windows.Graphics.Printing.OptionDetails;
using Windows.Graphics.Printing;
using Windows.Media.Audio;
using Windows.Media.Capture;
using Windows.Media.Casting;
using Windows.Media.DialProtocol;
using Windows.Media.Effects;
using Windows.Media.Import;
using Windows.Media.Playback;
using Windows.Media.PlayTo;
using Windows.Media.Protection.PlayReady;
using Windows.Media.SpeechRecognition;
using Windows.Media;
using Windows.Media.Capture.Core;
using Windows.Media.Capture.Frames;
using Windows.Media.Protection;
using Windows.Media.Core;
using Windows.Media.Streaming.Adaptive;
using Windows.Networking.Proximity;
using Windows.Networking.ServiceDiscovery.Dnssd;
using Windows.Networking.Sockets;
using Windows.Networking.Vpn;
using Windows.Perception.Spatial;
using Windows.Graphics.Holographic;
using Windows.UI.Input.Spatial;
using Windows.Perception.Spatial.Surfaces;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;
using Windows.System;
using Windows.UI.Composition;
using Windows.UI.Core;
using Windows.UI.Input.Inking;
using Windows.UI.Input.Inking.Core;
using Windows.UI.Text.Core;
using Windows.UI.WebUI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Printing;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Web.Http.Filters;
using Windows.ApplicationModel.Wallet.System;
using Windows.Foundation.Diagnostics;
using Windows.Media.ContentRestrictions;
using Windows.Networking.PushNotifications;
using Windows.UI.Notifications;
using Windows.UI.Notifications.Management;
using Windows.Graphics.Printing3D;
using Windows.Media.Devices;
using Windows.Phone.Devices.Power;
using Windows.Phone.Media.Devices;
using Windows.Services.Maps.Guidance;
using Windows.Services.Store;
using Windows.UI.WebUI.Core;
using Windows.Web.Http.Diagnostics;

namespace Windows.ApplicationModel.Calls
{
    public static class EventsMixin
    {
        public static PhoneLineEvents Events(this PhoneLine This)
        {
            return new PhoneLineEvents(This);
        }
        public static PhoneLineWatcherEvents Events(this PhoneLineWatcher This)
        {
            return new PhoneLineWatcherEvents(This);
        }
        public static VoipPhoneCallEvents Events(this VoipPhoneCall This)
        {
            return new VoipPhoneCallEvents(This);
        }
        public static VoipCallCoordinatorEvents Events(this VoipCallCoordinator This)
        {
            return new VoipCallCoordinatorEvents(This);
        }
        public static LockScreenCallUIEvents Events(this LockScreenCallUI This)
        {
            return new LockScreenCallUIEvents(This);
        }
    }

    public class PhoneLineEvents
    {
        PhoneLine This;

        public PhoneLineEvents(PhoneLine This)
        {
            this.This = This;
        }

        public IObservable<object> LineChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.PhoneLine,object>, object>(x => This.LineChanged += x, x => This.LineChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PhoneLineWatcherEvents
    {
        PhoneLineWatcher This;

        public PhoneLineWatcherEvents(PhoneLineWatcher This)
        {
            this.This = This;
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.PhoneLineWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Calls.PhoneLineWatcherEventArgs> LineAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.PhoneLineWatcher,Windows.ApplicationModel.Calls.PhoneLineWatcherEventArgs>, Windows.ApplicationModel.Calls.PhoneLineWatcherEventArgs>(x => This.LineAdded += x, x => This.LineAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Calls.PhoneLineWatcherEventArgs> LineRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.PhoneLineWatcher,Windows.ApplicationModel.Calls.PhoneLineWatcherEventArgs>, Windows.ApplicationModel.Calls.PhoneLineWatcherEventArgs>(x => This.LineRemoved += x, x => This.LineRemoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Calls.PhoneLineWatcherEventArgs> LineUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.PhoneLineWatcher,Windows.ApplicationModel.Calls.PhoneLineWatcherEventArgs>, Windows.ApplicationModel.Calls.PhoneLineWatcherEventArgs>(x => This.LineUpdated += x, x => This.LineUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.PhoneLineWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

    }
    public class VoipPhoneCallEvents
    {
        VoipPhoneCall This;

        public VoipPhoneCallEvents(VoipPhoneCall This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Calls.CallAnswerEventArgs> AnswerRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.VoipPhoneCall,Windows.ApplicationModel.Calls.CallAnswerEventArgs>, Windows.ApplicationModel.Calls.CallAnswerEventArgs>(x => This.AnswerRequested += x, x => This.AnswerRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Calls.CallStateChangeEventArgs> EndRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.VoipPhoneCall,Windows.ApplicationModel.Calls.CallStateChangeEventArgs>, Windows.ApplicationModel.Calls.CallStateChangeEventArgs>(x => This.EndRequested += x, x => This.EndRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Calls.CallStateChangeEventArgs> HoldRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.VoipPhoneCall,Windows.ApplicationModel.Calls.CallStateChangeEventArgs>, Windows.ApplicationModel.Calls.CallStateChangeEventArgs>(x => This.HoldRequested += x, x => This.HoldRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Calls.CallRejectEventArgs> RejectRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.VoipPhoneCall,Windows.ApplicationModel.Calls.CallRejectEventArgs>, Windows.ApplicationModel.Calls.CallRejectEventArgs>(x => This.RejectRequested += x, x => This.RejectRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Calls.CallStateChangeEventArgs> ResumeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.VoipPhoneCall,Windows.ApplicationModel.Calls.CallStateChangeEventArgs>, Windows.ApplicationModel.Calls.CallStateChangeEventArgs>(x => This.ResumeRequested += x, x => This.ResumeRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class VoipCallCoordinatorEvents
    {
        VoipCallCoordinator This;

        public VoipCallCoordinatorEvents(VoipCallCoordinator This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Calls.MuteChangeEventArgs> MuteStateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.VoipCallCoordinator,Windows.ApplicationModel.Calls.MuteChangeEventArgs>, Windows.ApplicationModel.Calls.MuteChangeEventArgs>(x => This.MuteStateChanged += x, x => This.MuteStateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class LockScreenCallUIEvents
    {
        LockScreenCallUI This;

        public LockScreenCallUIEvents(LockScreenCallUI This)
        {
            this.This = This;
        }

        public IObservable<object> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.LockScreenCallUI,object>, object>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs> EndRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Calls.LockScreenCallUI,Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs>, Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs>(x => This.EndRequested += x, x => This.EndRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Preview.Notes
{
    public static class EventsMixin
    {
        public static NotesWindowManagerPreviewEvents Events(this NotesWindowManagerPreview This)
        {
            return new NotesWindowManagerPreviewEvents(This);
        }
    }

    public class NotesWindowManagerPreviewEvents
    {
        NotesWindowManagerPreview This;

        public NotesWindowManagerPreviewEvents(NotesWindowManagerPreview This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Preview.Notes.NotePlacementChangedPreviewEventArgs> NotePlacementChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview,Windows.ApplicationModel.Preview.Notes.NotePlacementChangedPreviewEventArgs>, Windows.ApplicationModel.Preview.Notes.NotePlacementChangedPreviewEventArgs>(x => This.NotePlacementChanged += x, x => This.NotePlacementChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Preview.Notes.NoteVisibilityChangedPreviewEventArgs> NoteVisibilityChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview,Windows.ApplicationModel.Preview.Notes.NoteVisibilityChangedPreviewEventArgs>, Windows.ApplicationModel.Preview.Notes.NoteVisibilityChangedPreviewEventArgs>(x => This.NoteVisibilityChanged += x, x => This.NoteVisibilityChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> SystemLockStateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Preview.Notes.NotesWindowManagerPreview,object>, object>(x => This.SystemLockStateChanged += x, x => This.SystemLockStateChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Search.Core
{
    public static class EventsMixin
    {
        public static SearchSuggestionManagerEvents Events(this SearchSuggestionManager This)
        {
            return new SearchSuggestionManagerEvents(This);
        }
    }

    public class SearchSuggestionManagerEvents
    {
        SearchSuggestionManager This;

        public SearchSuggestionManagerEvents(SearchSuggestionManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Search.Core.RequestingFocusOnKeyboardInputEventArgs> RequestingFocusOnKeyboardInput {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.Core.SearchSuggestionManager,Windows.ApplicationModel.Search.Core.RequestingFocusOnKeyboardInputEventArgs>, Windows.ApplicationModel.Search.Core.RequestingFocusOnKeyboardInputEventArgs>(x => This.RequestingFocusOnKeyboardInput += x, x => This.RequestingFocusOnKeyboardInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Search.Core.SearchSuggestionsRequestedEventArgs> SuggestionsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.Core.SearchSuggestionManager,Windows.ApplicationModel.Search.Core.SearchSuggestionsRequestedEventArgs>, Windows.ApplicationModel.Search.Core.SearchSuggestionsRequestedEventArgs>(x => This.SuggestionsRequested += x, x => This.SuggestionsRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Search
{
    public static class EventsMixin
    {
        public static SearchPaneEvents Events(this SearchPane This)
        {
            return new SearchPaneEvents(This);
        }
    }

    public class SearchPaneEvents
    {
        SearchPane This;

        public SearchPaneEvents(SearchPane This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Search.SearchPaneQueryChangedEventArgs> QueryChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.SearchPane,Windows.ApplicationModel.Search.SearchPaneQueryChangedEventArgs>, Windows.ApplicationModel.Search.SearchPaneQueryChangedEventArgs>(x => This.QueryChanged += x, x => This.QueryChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs> QuerySubmitted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.SearchPane,Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs>, Windows.ApplicationModel.Search.SearchPaneQuerySubmittedEventArgs>(x => This.QuerySubmitted += x, x => This.QuerySubmitted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs> ResultSuggestionChosen {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.SearchPane,Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs>, Windows.ApplicationModel.Search.SearchPaneResultSuggestionChosenEventArgs>(x => This.ResultSuggestionChosen += x, x => This.ResultSuggestionChosen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs> SuggestionsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.SearchPane,Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs>, Windows.ApplicationModel.Search.SearchPaneSuggestionsRequestedEventArgs>(x => This.SuggestionsRequested += x, x => This.SuggestionsRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Search.SearchPaneVisibilityChangedEventArgs> VisibilityChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Search.SearchPane,Windows.ApplicationModel.Search.SearchPaneVisibilityChangedEventArgs>, Windows.ApplicationModel.Search.SearchPaneVisibilityChangedEventArgs>(x => This.VisibilityChanged += x, x => This.VisibilityChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Gpio.Provider
{
    public static class EventsMixin
    {
        public static IGpioPinProviderEvents Events(this IGpioPinProvider This)
        {
            return new IGpioPinProviderEvents(This);
        }
    }

    public class IGpioPinProviderEvents
    {
        IGpioPinProvider This;

        public IGpioPinProviderEvents(IGpioPinProvider This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Gpio.Provider.GpioPinProviderValueChangedEventArgs> ValueChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Gpio.Provider.IGpioPinProvider,Windows.Devices.Gpio.Provider.GpioPinProviderValueChangedEventArgs>, Windows.Devices.Gpio.Provider.GpioPinProviderValueChangedEventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Gpio
{
    public static class EventsMixin
    {
        public static GpioPinEvents Events(this GpioPin This)
        {
            return new GpioPinEvents(This);
        }
    }

    public class GpioPinEvents
    {
        GpioPin This;

        public GpioPinEvents(GpioPin This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Gpio.GpioPinValueChangedEventArgs> ValueChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Gpio.GpioPin,Windows.Devices.Gpio.GpioPinValueChangedEventArgs>, Windows.Devices.Gpio.GpioPinValueChangedEventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Printers.Extensions
{
    public static class EventsMixin
    {
        public static PrintTaskConfigurationEvents Events(this PrintTaskConfiguration This)
        {
            return new PrintTaskConfigurationEvents(This);
        }
        public static Print3DWorkflowEvents Events(this Print3DWorkflow This)
        {
            return new Print3DWorkflowEvents(This);
        }
    }

    public class PrintTaskConfigurationEvents
    {
        PrintTaskConfiguration This;

        public PrintTaskConfigurationEvents(PrintTaskConfiguration This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Printers.Extensions.PrintTaskConfigurationSaveRequestedEventArgs> SaveRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Printers.Extensions.PrintTaskConfiguration,Windows.Devices.Printers.Extensions.PrintTaskConfigurationSaveRequestedEventArgs>, Windows.Devices.Printers.Extensions.PrintTaskConfigurationSaveRequestedEventArgs>(x => This.SaveRequested += x, x => This.SaveRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class Print3DWorkflowEvents
    {
        Print3DWorkflow This;

        public Print3DWorkflowEvents(Print3DWorkflow This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Printers.Extensions.Print3DWorkflowPrintRequestedEventArgs> PrintRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Printers.Extensions.Print3DWorkflow,Windows.Devices.Printers.Extensions.Print3DWorkflowPrintRequestedEventArgs>, Windows.Devices.Printers.Extensions.Print3DWorkflowPrintRequestedEventArgs>(x => This.PrintRequested += x, x => This.PrintRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Printers.Extensions.Print3DWorkflowPrinterChangedEventArgs> PrinterChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Printers.Extensions.Print3DWorkflow,Windows.Devices.Printers.Extensions.Print3DWorkflowPrinterChangedEventArgs>, Windows.Devices.Printers.Extensions.Print3DWorkflowPrinterChangedEventArgs>(x => This.PrinterChanged += x, x => This.PrinterChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.SmartCards
{
    public static class EventsMixin
    {
        public static SmartCardEmulatorEvents Events(this SmartCardEmulator This)
        {
            return new SmartCardEmulatorEvents(This);
        }
        public static SmartCardReaderEvents Events(this SmartCardReader This)
        {
            return new SmartCardReaderEvents(This);
        }
    }

    public class SmartCardEmulatorEvents
    {
        SmartCardEmulator This;

        public SmartCardEmulatorEvents(SmartCardEmulator This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs> ApduReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.SmartCards.SmartCardEmulator,Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs>, Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs>(x => This.ApduReceived += x, x => This.ApduReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.SmartCards.SmartCardEmulatorConnectionDeactivatedEventArgs> ConnectionDeactivated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.SmartCards.SmartCardEmulator,Windows.Devices.SmartCards.SmartCardEmulatorConnectionDeactivatedEventArgs>, Windows.Devices.SmartCards.SmartCardEmulatorConnectionDeactivatedEventArgs>(x => This.ConnectionDeactivated += x, x => This.ConnectionDeactivated -= x).Select(x => x.EventArgs); }
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
namespace Windows.Devices.Sms
{
    public static class EventsMixin
    {
        public static SmsDeviceEvents Events(this SmsDevice This)
        {
            return new SmsDeviceEvents(This);
        }
        public static ISmsDeviceEvents Events(this ISmsDevice This)
        {
            return new ISmsDeviceEvents(This);
        }
        public static SmsDevice2Events Events(this SmsDevice2 This)
        {
            return new SmsDevice2Events(This);
        }
        public static SmsMessageRegistrationEvents Events(this SmsMessageRegistration This)
        {
            return new SmsMessageRegistrationEvents(This);
        }
    }

    public class SmsDeviceEvents
    {
        SmsDevice This;

        public SmsDeviceEvents(SmsDevice This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sms.SmsMessageReceivedEventArgs> SmsMessageReceived {
            get { return Observable.FromEventPattern<Windows.Devices.Sms.SmsMessageReceivedEventHandler, Windows.Devices.Sms.SmsMessageReceivedEventArgs>(x => This.SmsMessageReceived += x, x => This.SmsMessageReceived -= x).Select(x => x.EventArgs); }
        }

    }
    public class ISmsDeviceEvents
    {
        ISmsDevice This;

        public ISmsDeviceEvents(ISmsDevice This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sms.SmsMessageReceivedEventArgs> SmsMessageReceived {
            get { return Observable.FromEventPattern<Windows.Devices.Sms.SmsMessageReceivedEventHandler, Windows.Devices.Sms.SmsMessageReceivedEventArgs>(x => This.SmsMessageReceived += x, x => This.SmsMessageReceived -= x).Select(x => x.EventArgs); }
        }

    }
    public class SmsDevice2Events
    {
        SmsDevice2 This;

        public SmsDevice2Events(SmsDevice2 This)
        {
            this.This = This;
        }

        public IObservable<object> DeviceStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sms.SmsDevice2,object>, object>(x => This.DeviceStatusChanged += x, x => This.DeviceStatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class SmsMessageRegistrationEvents
    {
        SmsMessageRegistration This;

        public SmsMessageRegistrationEvents(SmsMessageRegistration This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sms.SmsMessageReceivedTriggerDetails> MessageReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sms.SmsMessageRegistration,Windows.Devices.Sms.SmsMessageReceivedTriggerDetails>, Windows.Devices.Sms.SmsMessageReceivedTriggerDetails>(x => This.MessageReceived += x, x => This.MessageReceived -= x).Select(x => x.EventArgs); }
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
        public static StringMapEvents Events(this StringMap This)
        {
            return new StringMapEvents(This);
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
    public class StringMapEvents
    {
        StringMap This;

        public StringMapEvents(StringMap This)
        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IMapChangedEventArgs<string>> MapChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.Collections.MapChangedEventHandler<string,string>, Windows.Foundation.Collections.IMapChangedEventArgs<string>>(x => This.MapChanged += x, x => This.MapChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.ApplicationSettings
{
    public static class EventsMixin
    {
        public static AccountsSettingsPaneEvents Events(this AccountsSettingsPane This)
        {
            return new AccountsSettingsPaneEvents(This);
        }
        public static SettingsPaneEvents Events(this SettingsPane This)
        {
            return new SettingsPaneEvents(This);
        }
    }

    public class AccountsSettingsPaneEvents
    {
        AccountsSettingsPane This;

        public AccountsSettingsPaneEvents(AccountsSettingsPane This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.ApplicationSettings.AccountsSettingsPaneCommandsRequestedEventArgs> AccountCommandsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ApplicationSettings.AccountsSettingsPane,Windows.UI.ApplicationSettings.AccountsSettingsPaneCommandsRequestedEventArgs>, Windows.UI.ApplicationSettings.AccountsSettingsPaneCommandsRequestedEventArgs>(x => This.AccountCommandsRequested += x, x => This.AccountCommandsRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class SettingsPaneEvents
    {
        SettingsPane This;

        public SettingsPaneEvents(SettingsPane This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.ApplicationSettings.SettingsPaneCommandsRequestedEventArgs> CommandsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ApplicationSettings.SettingsPane,Windows.UI.ApplicationSettings.SettingsPaneCommandsRequestedEventArgs>, Windows.UI.ApplicationSettings.SettingsPaneCommandsRequestedEventArgs>(x => This.CommandsRequested += x, x => This.CommandsRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.AppService
{
    public static class EventsMixin
    {
        public static AppServiceConnectionEvents Events(this AppServiceConnection This)
        {
            return new AppServiceConnectionEvents(This);
        }
    }

    public class AppServiceConnectionEvents
    {
        AppServiceConnection This;

        public AppServiceConnectionEvents(AppServiceConnection This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.AppService.AppServiceRequestReceivedEventArgs> RequestReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.AppService.AppServiceConnection,Windows.ApplicationModel.AppService.AppServiceRequestReceivedEventArgs>, Windows.ApplicationModel.AppService.AppServiceRequestReceivedEventArgs>(x => This.RequestReceived += x, x => This.RequestReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.AppService.AppServiceClosedEventArgs> ServiceClosed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.AppService.AppServiceConnection,Windows.ApplicationModel.AppService.AppServiceClosedEventArgs>, Windows.ApplicationModel.AppService.AppServiceClosedEventArgs>(x => This.ServiceClosed += x, x => This.ServiceClosed -= x).Select(x => x.EventArgs); }
        }

    }
}
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

        public IObservable<object> ColorValuesChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.UISettings,object>, object>(x => This.ColorValuesChanged += x, x => This.ColorValuesChanged -= x).Select(x => x.EventArgs); }
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
namespace Windows.ApplicationModel.Appointments
{
    public static class EventsMixin
    {
        public static AppointmentStoreEvents Events(this AppointmentStore This)
        {
            return new AppointmentStoreEvents(This);
        }
        public static AppointmentCalendarSyncManagerEvents Events(this AppointmentCalendarSyncManager This)
        {
            return new AppointmentCalendarSyncManagerEvents(This);
        }
    }

    public class AppointmentStoreEvents
    {
        AppointmentStore This;

        public AppointmentStoreEvents(AppointmentStore This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Appointments.AppointmentStoreChangedEventArgs> StoreChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Appointments.AppointmentStore,Windows.ApplicationModel.Appointments.AppointmentStoreChangedEventArgs>, Windows.ApplicationModel.Appointments.AppointmentStoreChangedEventArgs>(x => This.StoreChanged += x, x => This.StoreChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class AppointmentCalendarSyncManagerEvents
    {
        AppointmentCalendarSyncManager This;

        public AppointmentCalendarSyncManagerEvents(AppointmentCalendarSyncManager This)
        {
            this.This = This;
        }

        public IObservable<object> SyncStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Appointments.AppointmentCalendarSyncManager,object>, object>(x => This.SyncStatusChanged += x, x => This.SyncStatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Appointments.DataProvider
{
    public static class EventsMixin
    {
        public static AppointmentDataProviderConnectionEvents Events(this AppointmentDataProviderConnection This)
        {
            return new AppointmentDataProviderConnectionEvents(This);
        }
    }

    public class AppointmentDataProviderConnectionEvents
    {
        AppointmentDataProviderConnection This;

        public AppointmentDataProviderConnectionEvents(AppointmentDataProviderConnection This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCancelMeetingRequestEventArgs> CancelMeetingRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Appointments.DataProvider.AppointmentDataProviderConnection,Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCancelMeetingRequestEventArgs>, Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCancelMeetingRequestEventArgs>(x => This.CancelMeetingRequested += x, x => This.CancelMeetingRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs> CreateOrUpdateAppointmentRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Appointments.DataProvider.AppointmentDataProviderConnection,Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs>, Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarCreateOrUpdateAppointmentRequestEventArgs>(x => This.CreateOrUpdateAppointmentRequested += x, x => This.CreateOrUpdateAppointmentRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarForwardMeetingRequestEventArgs> ForwardMeetingRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Appointments.DataProvider.AppointmentDataProviderConnection,Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarForwardMeetingRequestEventArgs>, Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarForwardMeetingRequestEventArgs>(x => This.ForwardMeetingRequested += x, x => This.ForwardMeetingRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarProposeNewTimeForMeetingRequestEventArgs> ProposeNewTimeForMeetingRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Appointments.DataProvider.AppointmentDataProviderConnection,Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarProposeNewTimeForMeetingRequestEventArgs>, Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarProposeNewTimeForMeetingRequestEventArgs>(x => This.ProposeNewTimeForMeetingRequested += x, x => This.ProposeNewTimeForMeetingRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarSyncManagerSyncRequestEventArgs> SyncRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Appointments.DataProvider.AppointmentDataProviderConnection,Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarSyncManagerSyncRequestEventArgs>, Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarSyncManagerSyncRequestEventArgs>(x => This.SyncRequested += x, x => This.SyncRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarUpdateMeetingResponseRequestEventArgs> UpdateMeetingResponseRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Appointments.DataProvider.AppointmentDataProviderConnection,Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarUpdateMeetingResponseRequestEventArgs>, Windows.ApplicationModel.Appointments.DataProvider.AppointmentCalendarUpdateMeetingResponseRequestEventArgs>(x => This.UpdateMeetingResponseRequested += x, x => This.UpdateMeetingResponseRequested -= x).Select(x => x.EventArgs); }
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
namespace Windows.Devices.Power
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

        public IObservable<object> ReportUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Power.Battery,object>, object>(x => This.ReportUpdated += x, x => This.ReportUpdated -= x).Select(x => x.EventArgs); }
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
        public static ChatConversationEvents Events(this ChatConversation This)
        {
            return new ChatConversationEvents(This);
        }
        public static RcsEndUserMessageManagerEvents Events(this RcsEndUserMessageManager This)
        {
            return new RcsEndUserMessageManagerEvents(This);
        }
        public static RcsTransportEvents Events(this RcsTransport This)
        {
            return new RcsTransportEvents(This);
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

        public IObservable<Windows.ApplicationModel.Chat.ChatMessageStoreChangedEventArgs> StoreChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Chat.ChatMessageStore,Windows.ApplicationModel.Chat.ChatMessageStoreChangedEventArgs>, Windows.ApplicationModel.Chat.ChatMessageStoreChangedEventArgs>(x => This.StoreChanged += x, x => This.StoreChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ChatConversationEvents
    {
        ChatConversation This;

        public ChatConversationEvents(ChatConversation This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Chat.RemoteParticipantComposingChangedEventArgs> RemoteParticipantComposingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Chat.ChatConversation,Windows.ApplicationModel.Chat.RemoteParticipantComposingChangedEventArgs>, Windows.ApplicationModel.Chat.RemoteParticipantComposingChangedEventArgs>(x => This.RemoteParticipantComposingChanged += x, x => This.RemoteParticipantComposingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RcsEndUserMessageManagerEvents
    {
        RcsEndUserMessageManager This;

        public RcsEndUserMessageManagerEvents(RcsEndUserMessageManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableEventArgs> MessageAvailableChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Chat.RcsEndUserMessageManager,Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableEventArgs>, Windows.ApplicationModel.Chat.RcsEndUserMessageAvailableEventArgs>(x => This.MessageAvailableChanged += x, x => This.MessageAvailableChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RcsTransportEvents
    {
        RcsTransport This;

        public RcsTransportEvents(RcsTransport This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Chat.RcsServiceKindSupportedChangedEventArgs> ServiceKindSupportedChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Chat.RcsTransport,Windows.ApplicationModel.Chat.RcsServiceKindSupportedChangedEventArgs>, Windows.ApplicationModel.Chat.RcsServiceKindSupportedChangedEventArgs>(x => This.ServiceKindSupportedChanged += x, x => This.ServiceKindSupportedChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Contacts
{
    public static class EventsMixin
    {
        public static ContactStoreEvents Events(this ContactStore This)
        {
            return new ContactStoreEvents(This);
        }
        public static ContactListEvents Events(this ContactList This)
        {
            return new ContactListEvents(This);
        }
        public static ContactListSyncManagerEvents Events(this ContactListSyncManager This)
        {
            return new ContactListSyncManagerEvents(This);
        }
    }

    public class ContactStoreEvents
    {
        ContactStore This;

        public ContactStoreEvents(ContactStore This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Contacts.ContactChangedEventArgs> ContactChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Contacts.ContactStore,Windows.ApplicationModel.Contacts.ContactChangedEventArgs>, Windows.ApplicationModel.Contacts.ContactChangedEventArgs>(x => This.ContactChanged += x, x => This.ContactChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ContactListEvents
    {
        ContactList This;

        public ContactListEvents(ContactList This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Contacts.ContactChangedEventArgs> ContactChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Contacts.ContactList,Windows.ApplicationModel.Contacts.ContactChangedEventArgs>, Windows.ApplicationModel.Contacts.ContactChangedEventArgs>(x => This.ContactChanged += x, x => This.ContactChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ContactListSyncManagerEvents
    {
        ContactListSyncManager This;

        public ContactListSyncManagerEvents(ContactListSyncManager This)
        {
            this.This = This;
        }

        public IObservable<object> SyncStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Contacts.ContactListSyncManager,object>, object>(x => This.SyncStatusChanged += x, x => This.SyncStatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Contacts.DataProvider
{
    public static class EventsMixin
    {
        public static ContactDataProviderConnectionEvents Events(this ContactDataProviderConnection This)
        {
            return new ContactDataProviderConnectionEvents(This);
        }
    }

    public class ContactDataProviderConnectionEvents
    {
        ContactDataProviderConnection This;

        public ContactDataProviderConnectionEvents(ContactDataProviderConnection This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Contacts.DataProvider.ContactListServerSearchReadBatchRequestEventArgs> ServerSearchReadBatchRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Contacts.DataProvider.ContactDataProviderConnection,Windows.ApplicationModel.Contacts.DataProvider.ContactListServerSearchReadBatchRequestEventArgs>, Windows.ApplicationModel.Contacts.DataProvider.ContactListServerSearchReadBatchRequestEventArgs>(x => This.ServerSearchReadBatchRequested += x, x => This.ServerSearchReadBatchRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Contacts.DataProvider.ContactListSyncManagerSyncRequestEventArgs> SyncRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Contacts.DataProvider.ContactDataProviderConnection,Windows.ApplicationModel.Contacts.DataProvider.ContactListSyncManagerSyncRequestEventArgs>, Windows.ApplicationModel.Contacts.DataProvider.ContactListSyncManagerSyncRequestEventArgs>(x => This.SyncRequested += x, x => This.SyncRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Contacts.Provider
{
    public static class EventsMixin
    {
        public static ContactPickerUIEvents Events(this ContactPickerUI This)
        {
            return new ContactPickerUIEvents(This);
        }
    }

    public class ContactPickerUIEvents
    {
        ContactPickerUI This;

        public ContactPickerUIEvents(ContactPickerUI This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Contacts.Provider.ContactRemovedEventArgs> ContactRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Contacts.Provider.ContactPickerUI,Windows.ApplicationModel.Contacts.Provider.ContactRemovedEventArgs>, Windows.ApplicationModel.Contacts.Provider.ContactRemovedEventArgs>(x => This.ContactRemoved += x, x => This.ContactRemoved -= x).Select(x => x.EventArgs); }
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
namespace Windows.ApplicationModel.DataTransfer.DragDrop.Core
{
    public static class EventsMixin
    {
        public static CoreDragDropManagerEvents Events(this CoreDragDropManager This)
        {
            return new CoreDragDropManagerEvents(This);
        }
    }

    public class CoreDragDropManagerEvents
    {
        CoreDragDropManager This;

        public CoreDragDropManagerEvents(CoreDragDropManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDropOperationTargetRequestedEventArgs> TargetRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDragDropManager,Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDropOperationTargetRequestedEventArgs>, Windows.ApplicationModel.DataTransfer.DragDrop.Core.CoreDropOperationTargetRequestedEventArgs>(x => This.TargetRequested += x, x => This.TargetRequested -= x).Select(x => x.EventArgs); }
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
        public static KeyboardDeliveryInterceptorEvents Events(this KeyboardDeliveryInterceptor This)
        {
            return new KeyboardDeliveryInterceptorEvents(This);
        }
        public static GestureRecognizerEvents Events(this GestureRecognizer This)
        {
            return new GestureRecognizerEvents(This);
        }
        public static RadialControllerEvents Events(this RadialController This)
        {
            return new RadialControllerEvents(This);
        }
        public static RadialControllerMenuItemEvents Events(this RadialControllerMenuItem This)
        {
            return new RadialControllerMenuItemEvents(This);
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
    public class KeyboardDeliveryInterceptorEvents
    {
        KeyboardDeliveryInterceptor This;

        public KeyboardDeliveryInterceptorEvents(KeyboardDeliveryInterceptor This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.KeyboardDeliveryInterceptor,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.KeyboardDeliveryInterceptor,Windows.UI.Core.KeyEventArgs>, Windows.UI.Core.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
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
    public class RadialControllerEvents
    {
        RadialController This;

        public RadialControllerEvents(RadialController This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Input.RadialControllerButtonClickedEventArgs> ButtonClicked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.RadialController,Windows.UI.Input.RadialControllerButtonClickedEventArgs>, Windows.UI.Input.RadialControllerButtonClickedEventArgs>(x => This.ButtonClicked += x, x => This.ButtonClicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.RadialControllerControlAcquiredEventArgs> ControlAcquired {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.RadialController,Windows.UI.Input.RadialControllerControlAcquiredEventArgs>, Windows.UI.Input.RadialControllerControlAcquiredEventArgs>(x => This.ControlAcquired += x, x => This.ControlAcquired -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ControlLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.RadialController,object>, object>(x => This.ControlLost += x, x => This.ControlLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.RadialControllerRotationChangedEventArgs> RotationChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.RadialController,Windows.UI.Input.RadialControllerRotationChangedEventArgs>, Windows.UI.Input.RadialControllerRotationChangedEventArgs>(x => This.RotationChanged += x, x => This.RotationChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.RadialControllerScreenContactContinuedEventArgs> ScreenContactContinued {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.RadialController,Windows.UI.Input.RadialControllerScreenContactContinuedEventArgs>, Windows.UI.Input.RadialControllerScreenContactContinuedEventArgs>(x => This.ScreenContactContinued += x, x => This.ScreenContactContinued -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ScreenContactEnded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.RadialController,object>, object>(x => This.ScreenContactEnded += x, x => This.ScreenContactEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.RadialControllerScreenContactStartedEventArgs> ScreenContactStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.RadialController,Windows.UI.Input.RadialControllerScreenContactStartedEventArgs>, Windows.UI.Input.RadialControllerScreenContactStartedEventArgs>(x => This.ScreenContactStarted += x, x => This.ScreenContactStarted -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadialControllerMenuItemEvents
    {
        RadialControllerMenuItem This;

        public RadialControllerMenuItemEvents(RadialControllerMenuItem This)
        {
            this.This = This;
        }

        public IObservable<object> Invoked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.RadialControllerMenuItem,object>, object>(x => This.Invoked += x, x => This.Invoked -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Email
{
    public static class EventsMixin
    {
        public static EmailMailboxEvents Events(this EmailMailbox This)
        {
            return new EmailMailboxEvents(This);
        }
        public static EmailMailboxSyncManagerEvents Events(this EmailMailboxSyncManager This)
        {
            return new EmailMailboxSyncManagerEvents(This);
        }
    }

    public class EmailMailboxEvents
    {
        EmailMailbox This;

        public EmailMailboxEvents(EmailMailbox This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Email.EmailMailboxChangedEventArgs> MailboxChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.EmailMailbox,Windows.ApplicationModel.Email.EmailMailboxChangedEventArgs>, Windows.ApplicationModel.Email.EmailMailboxChangedEventArgs>(x => This.MailboxChanged += x, x => This.MailboxChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class EmailMailboxSyncManagerEvents
    {
        EmailMailboxSyncManager This;

        public EmailMailboxSyncManagerEvents(EmailMailboxSyncManager This)
        {
            this.This = This;
        }

        public IObservable<object> SyncStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.EmailMailboxSyncManager,object>, object>(x => This.SyncStatusChanged += x, x => This.SyncStatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Email.DataProvider
{
    public static class EventsMixin
    {
        public static EmailDataProviderConnectionEvents Events(this EmailDataProviderConnection This)
        {
            return new EmailDataProviderConnectionEvents(This);
        }
    }

    public class EmailDataProviderConnectionEvents
    {
        EmailDataProviderConnection This;

        public EmailDataProviderConnectionEvents(EmailDataProviderConnection This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxCreateFolderRequestEventArgs> CreateFolderRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxCreateFolderRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxCreateFolderRequestEventArgs>(x => This.CreateFolderRequested += x, x => This.CreateFolderRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxDeleteFolderRequestEventArgs> DeleteFolderRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxDeleteFolderRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxDeleteFolderRequestEventArgs>(x => This.DeleteFolderRequested += x, x => This.DeleteFolderRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxDownloadAttachmentRequestEventArgs> DownloadAttachmentRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxDownloadAttachmentRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxDownloadAttachmentRequestEventArgs>(x => This.DownloadAttachmentRequested += x, x => This.DownloadAttachmentRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxDownloadMessageRequestEventArgs> DownloadMessageRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxDownloadMessageRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxDownloadMessageRequestEventArgs>(x => This.DownloadMessageRequested += x, x => This.DownloadMessageRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxEmptyFolderRequestEventArgs> EmptyFolderRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxEmptyFolderRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxEmptyFolderRequestEventArgs>(x => This.EmptyFolderRequested += x, x => This.EmptyFolderRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxForwardMeetingRequestEventArgs> ForwardMeetingRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxForwardMeetingRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxForwardMeetingRequestEventArgs>(x => This.ForwardMeetingRequested += x, x => This.ForwardMeetingRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxGetAutoReplySettingsRequestEventArgs> GetAutoReplySettingsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxGetAutoReplySettingsRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxGetAutoReplySettingsRequestEventArgs>(x => This.GetAutoReplySettingsRequested += x, x => This.GetAutoReplySettingsRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxSyncManagerSyncRequestEventArgs> MailboxSyncRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxSyncManagerSyncRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxSyncManagerSyncRequestEventArgs>(x => This.MailboxSyncRequested += x, x => This.MailboxSyncRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxMoveFolderRequestEventArgs> MoveFolderRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxMoveFolderRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxMoveFolderRequestEventArgs>(x => This.MoveFolderRequested += x, x => This.MoveFolderRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxProposeNewTimeForMeetingRequestEventArgs> ProposeNewTimeForMeetingRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxProposeNewTimeForMeetingRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxProposeNewTimeForMeetingRequestEventArgs>(x => This.ProposeNewTimeForMeetingRequested += x, x => This.ProposeNewTimeForMeetingRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxResolveRecipientsRequestEventArgs> ResolveRecipientsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxResolveRecipientsRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxResolveRecipientsRequestEventArgs>(x => This.ResolveRecipientsRequested += x, x => This.ResolveRecipientsRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxServerSearchReadBatchRequestEventArgs> ServerSearchReadBatchRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxServerSearchReadBatchRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxServerSearchReadBatchRequestEventArgs>(x => This.ServerSearchReadBatchRequested += x, x => This.ServerSearchReadBatchRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxSetAutoReplySettingsRequestEventArgs> SetAutoReplySettingsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxSetAutoReplySettingsRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxSetAutoReplySettingsRequestEventArgs>(x => This.SetAutoReplySettingsRequested += x, x => This.SetAutoReplySettingsRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxUpdateMeetingResponseRequestEventArgs> UpdateMeetingResponseRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxUpdateMeetingResponseRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxUpdateMeetingResponseRequestEventArgs>(x => This.UpdateMeetingResponseRequested += x, x => This.UpdateMeetingResponseRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Email.DataProvider.EmailMailboxValidateCertificatesRequestEventArgs> ValidateCertificatesRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection,Windows.ApplicationModel.Email.DataProvider.EmailMailboxValidateCertificatesRequestEventArgs>, Windows.ApplicationModel.Email.DataProvider.EmailMailboxValidateCertificatesRequestEventArgs>(x => This.ValidateCertificatesRequested += x, x => This.ValidateCertificatesRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.ExtendedExecution
{
    public static class EventsMixin
    {
        public static ExtendedExecutionSessionEvents Events(this ExtendedExecutionSession This)
        {
            return new ExtendedExecutionSessionEvents(This);
        }
    }

    public class ExtendedExecutionSessionEvents
    {
        ExtendedExecutionSession This;

        public ExtendedExecutionSessionEvents(ExtendedExecutionSession This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.ExtendedExecution.ExtendedExecutionRevokedEventArgs> Revoked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.ApplicationModel.ExtendedExecution.ExtendedExecutionRevokedEventArgs>, Windows.ApplicationModel.ExtendedExecution.ExtendedExecutionRevokedEventArgs>(x => This.Revoked += x, x => This.Revoked -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.ExtendedExecution.Foreground
{
    public static class EventsMixin
    {
        public static ExtendedExecutionForegroundSessionEvents Events(this ExtendedExecutionForegroundSession This)
        {
            return new ExtendedExecutionForegroundSessionEvents(This);
        }
    }

    public class ExtendedExecutionForegroundSessionEvents
    {
        ExtendedExecutionForegroundSession This;

        public ExtendedExecutionForegroundSessionEvents(ExtendedExecutionForegroundSession This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.ExtendedExecution.Foreground.ExtendedExecutionForegroundRevokedEventArgs> Revoked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.ApplicationModel.ExtendedExecution.Foreground.ExtendedExecutionForegroundRevokedEventArgs>, Windows.ApplicationModel.ExtendedExecution.Foreground.ExtendedExecutionForegroundRevokedEventArgs>(x => This.Revoked += x, x => This.Revoked -= x).Select(x => x.EventArgs); }
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
namespace Windows.Networking.NetworkOperators
{
    public static class EventsMixin
    {
        public static MobileBroadbandAccountWatcherEvents Events(this MobileBroadbandAccountWatcher This)
        {
            return new MobileBroadbandAccountWatcherEvents(This);
        }
        public static MobileBroadbandDeviceServiceDataSessionEvents Events(this MobileBroadbandDeviceServiceDataSession This)
        {
            return new MobileBroadbandDeviceServiceDataSessionEvents(This);
        }
    }

    public class MobileBroadbandAccountWatcherEvents
    {
        MobileBroadbandAccountWatcher This;

        public MobileBroadbandAccountWatcherEvents(MobileBroadbandAccountWatcher This)
        {
            this.This = This;
        }

        public IObservable<Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs> AccountAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs>, Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs>(x => This.AccountAdded += x, x => This.AccountAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs> AccountRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs>, Windows.Networking.NetworkOperators.MobileBroadbandAccountEventArgs>(x => This.AccountRemoved += x, x => This.AccountRemoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Networking.NetworkOperators.MobileBroadbandAccountUpdatedEventArgs> AccountUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,Windows.Networking.NetworkOperators.MobileBroadbandAccountUpdatedEventArgs>, Windows.Networking.NetworkOperators.MobileBroadbandAccountUpdatedEventArgs>(x => This.AccountUpdated += x, x => This.AccountUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

    }
    public class MobileBroadbandDeviceServiceDataSessionEvents
    {
        MobileBroadbandDeviceServiceDataSession This;

        public MobileBroadbandDeviceServiceDataSessionEvents(MobileBroadbandDeviceServiceDataSession This)
        {
            this.This = This;
        }

        public IObservable<Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceDataReceivedEventArgs> DataReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceDataSession,Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceDataReceivedEventArgs>, Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceDataReceivedEventArgs>(x => This.DataReceived += x, x => This.DataReceived -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.System.RemoteSystems
{
    public static class EventsMixin
    {
        public static RemoteSystemWatcherEvents Events(this RemoteSystemWatcher This)
        {
            return new RemoteSystemWatcherEvents(This);
        }
    }

    public class RemoteSystemWatcherEvents
    {
        RemoteSystemWatcher This;

        public RemoteSystemWatcherEvents(RemoteSystemWatcher This)
        {
            this.This = This;
        }

        public IObservable<Windows.System.RemoteSystems.RemoteSystemAddedEventArgs> RemoteSystemAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.System.RemoteSystems.RemoteSystemWatcher,Windows.System.RemoteSystems.RemoteSystemAddedEventArgs>, Windows.System.RemoteSystems.RemoteSystemAddedEventArgs>(x => This.RemoteSystemAdded += x, x => This.RemoteSystemAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.System.RemoteSystems.RemoteSystemRemovedEventArgs> RemoteSystemRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.System.RemoteSystems.RemoteSystemWatcher,Windows.System.RemoteSystems.RemoteSystemRemovedEventArgs>, Windows.System.RemoteSystems.RemoteSystemRemovedEventArgs>(x => This.RemoteSystemRemoved += x, x => This.RemoteSystemRemoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.System.RemoteSystems.RemoteSystemUpdatedEventArgs> RemoteSystemUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.System.RemoteSystems.RemoteSystemWatcher,Windows.System.RemoteSystems.RemoteSystemUpdatedEventArgs>, Windows.System.RemoteSystems.RemoteSystemUpdatedEventArgs>(x => This.RemoteSystemUpdated += x, x => This.RemoteSystemUpdated -= x).Select(x => x.EventArgs); }
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
namespace Windows.Storage
{
    public static class EventsMixin
    {
        public static StorageLibraryEvents Events(this StorageLibrary This)
        {
            return new StorageLibraryEvents(This);
        }
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

    public class StorageLibraryEvents
    {
        StorageLibrary This;

        public StorageLibraryEvents(StorageLibrary This)
        {
            this.This = This;
        }

        public IObservable<object> DefinitionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.StorageLibrary,object>, object>(x => This.DefinitionChanged += x, x => This.DefinitionChanged -= x).Select(x => x.EventArgs); }
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
namespace Windows.Storage.BulkAccess
{
    public static class EventsMixin
    {
        public static IStorageItemInformationEvents Events(this IStorageItemInformation This)
        {
            return new IStorageItemInformationEvents(This);
        }
        public static FileInformationEvents Events(this FileInformation This)
        {
            return new FileInformationEvents(This);
        }
        public static FolderInformationEvents Events(this FolderInformation This)
        {
            return new FolderInformationEvents(This);
        }
    }

    public class IStorageItemInformationEvents
    {
        IStorageItemInformation This;

        public IStorageItemInformationEvents(IStorageItemInformation This)
        {
            this.This = This;
        }

        public IObservable<object> PropertiesUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.BulkAccess.IStorageItemInformation,object>, object>(x => This.PropertiesUpdated += x, x => This.PropertiesUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ThumbnailUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.BulkAccess.IStorageItemInformation,object>, object>(x => This.ThumbnailUpdated += x, x => This.ThumbnailUpdated -= x).Select(x => x.EventArgs); }
        }

    }
    public class FileInformationEvents
    {
        FileInformation This;

        public FileInformationEvents(FileInformation This)
        {
            this.This = This;
        }

        public IObservable<object> PropertiesUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.BulkAccess.IStorageItemInformation,object>, object>(x => This.PropertiesUpdated += x, x => This.PropertiesUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ThumbnailUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.BulkAccess.IStorageItemInformation,object>, object>(x => This.ThumbnailUpdated += x, x => This.ThumbnailUpdated -= x).Select(x => x.EventArgs); }
        }

    }
    public class FolderInformationEvents
    {
        FolderInformation This;

        public FolderInformationEvents(FolderInformation This)
        {
            this.This = This;
        }

        public IObservable<object> PropertiesUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.BulkAccess.IStorageItemInformation,object>, object>(x => This.PropertiesUpdated += x, x => This.PropertiesUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ThumbnailUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Storage.BulkAccess.IStorageItemInformation,object>, object>(x => This.ThumbnailUpdated += x, x => This.ThumbnailUpdated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.UserDataAccounts
{
    public static class EventsMixin
    {
        public static UserDataAccountStoreEvents Events(this UserDataAccountStore This)
        {
            return new UserDataAccountStoreEvents(This);
        }
    }

    public class UserDataAccountStoreEvents
    {
        UserDataAccountStore This;

        public UserDataAccountStoreEvents(UserDataAccountStore This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.UserDataAccounts.UserDataAccountStoreChangedEventArgs> StoreChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.UserDataAccounts.UserDataAccountStore,Windows.ApplicationModel.UserDataAccounts.UserDataAccountStoreChangedEventArgs>, Windows.ApplicationModel.UserDataAccounts.UserDataAccountStoreChangedEventArgs>(x => This.StoreChanged += x, x => This.StoreChanged -= x).Select(x => x.EventArgs); }
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
namespace Windows.ApplicationModel.AppExtensions
{
    public static class EventsMixin
    {
        public static AppExtensionCatalogEvents Events(this AppExtensionCatalog This)
        {
            return new AppExtensionCatalogEvents(This);
        }
    }

    public class AppExtensionCatalogEvents
    {
        AppExtensionCatalog This;

        public AppExtensionCatalogEvents(AppExtensionCatalog This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.AppExtensions.AppExtensionPackageInstalledEventArgs> PackageInstalled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.AppExtensions.AppExtensionCatalog,Windows.ApplicationModel.AppExtensions.AppExtensionPackageInstalledEventArgs>, Windows.ApplicationModel.AppExtensions.AppExtensionPackageInstalledEventArgs>(x => This.PackageInstalled += x, x => This.PackageInstalled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.AppExtensions.AppExtensionPackageStatusChangedEventArgs> PackageStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.AppExtensions.AppExtensionCatalog,Windows.ApplicationModel.AppExtensions.AppExtensionPackageStatusChangedEventArgs>, Windows.ApplicationModel.AppExtensions.AppExtensionPackageStatusChangedEventArgs>(x => This.PackageStatusChanged += x, x => This.PackageStatusChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.AppExtensions.AppExtensionPackageUninstallingEventArgs> PackageUninstalling {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.AppExtensions.AppExtensionCatalog,Windows.ApplicationModel.AppExtensions.AppExtensionPackageUninstallingEventArgs>, Windows.ApplicationModel.AppExtensions.AppExtensionPackageUninstallingEventArgs>(x => This.PackageUninstalling += x, x => This.PackageUninstalling -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatedEventArgs> PackageUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.AppExtensions.AppExtensionCatalog,Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatedEventArgs>, Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatedEventArgs>(x => This.PackageUpdated += x, x => This.PackageUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatingEventArgs> PackageUpdating {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.AppExtensions.AppExtensionCatalog,Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatingEventArgs>, Windows.ApplicationModel.AppExtensions.AppExtensionPackageUpdatingEventArgs>(x => This.PackageUpdating += x, x => This.PackageUpdating -= x).Select(x => x.EventArgs); }
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
        public static CoreApplicationViewTitleBarEvents Events(this CoreApplicationViewTitleBar This)
        {
            return new CoreApplicationViewTitleBarEvents(This);
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

        public IObservable<Windows.ApplicationModel.Core.HostedViewClosingEventArgs> HostedViewClosing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Core.CoreApplicationView,Windows.ApplicationModel.Core.HostedViewClosingEventArgs>, Windows.ApplicationModel.Core.HostedViewClosingEventArgs>(x => This.HostedViewClosing += x, x => This.HostedViewClosing -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreApplicationViewTitleBarEvents
    {
        CoreApplicationViewTitleBar This;

        public CoreApplicationViewTitleBarEvents(CoreApplicationViewTitleBar This)
        {
            this.This = This;
        }

        public IObservable<object> IsVisibleChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Core.CoreApplicationViewTitleBar,object>, object>(x => This.IsVisibleChanged += x, x => This.IsVisibleChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> LayoutMetricsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Core.CoreApplicationViewTitleBar,object>, object>(x => This.LayoutMetricsChanged += x, x => This.LayoutMetricsChanged -= x).Select(x => x.EventArgs); }
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
namespace Windows.ApplicationModel.LockScreen
{
    public static class EventsMixin
    {
        public static LockScreenInfoEvents Events(this LockScreenInfo This)
        {
            return new LockScreenInfoEvents(This);
        }
        public static LockApplicationHostEvents Events(this LockApplicationHost This)
        {
            return new LockApplicationHostEvents(This);
        }
    }

    public class LockScreenInfoEvents
    {
        LockScreenInfo This;

        public LockScreenInfoEvents(LockScreenInfo This)
        {
            this.This = This;
        }

        public IObservable<object> AlarmIconChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.LockScreen.LockScreenInfo,object>, object>(x => This.AlarmIconChanged += x, x => This.AlarmIconChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> BadgesChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.LockScreen.LockScreenInfo,object>, object>(x => This.BadgesChanged += x, x => This.BadgesChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> DetailTextChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.LockScreen.LockScreenInfo,object>, object>(x => This.DetailTextChanged += x, x => This.DetailTextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> LockScreenImageChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.LockScreen.LockScreenInfo,object>, object>(x => This.LockScreenImageChanged += x, x => This.LockScreenImageChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class LockApplicationHostEvents
    {
        LockApplicationHost This;

        public LockApplicationHostEvents(LockApplicationHost This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.LockScreen.LockScreenUnlockingEventArgs> Unlocking {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.LockScreen.LockApplicationHost,Windows.ApplicationModel.LockScreen.LockScreenUnlockingEventArgs>, Windows.ApplicationModel.LockScreen.LockScreenUnlockingEventArgs>(x => This.Unlocking += x, x => This.Unlocking -= x).Select(x => x.EventArgs); }
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
namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
    public static class EventsMixin
    {
        public static AppInstallItemEvents Events(this AppInstallItem This)
        {
            return new AppInstallItemEvents(This);
        }
        public static AppInstallManagerEvents Events(this AppInstallManager This)
        {
            return new AppInstallManagerEvents(This);
        }
    }

    public class AppInstallItemEvents
    {
        AppInstallItem This;

        public AppInstallItemEvents(AppInstallItem This)
        {
            this.This = This;
        }

        public IObservable<object> Completed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem,object>, object>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> StatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem,object>, object>(x => This.StatusChanged += x, x => This.StatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class AppInstallManagerEvents
    {
        AppInstallManager This;

        public AppInstallManagerEvents(AppInstallManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManagerItemEventArgs> ItemCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager,Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManagerItemEventArgs>, Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManagerItemEventArgs>(x => This.ItemCompleted += x, x => This.ItemCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManagerItemEventArgs> ItemStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager,Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManagerItemEventArgs>, Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManagerItemEventArgs>(x => This.ItemStatusChanged += x, x => This.ItemStatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.VoiceCommands
{
    public static class EventsMixin
    {
        public static VoiceCommandServiceConnectionEvents Events(this VoiceCommandServiceConnection This)
        {
            return new VoiceCommandServiceConnectionEvents(This);
        }
    }

    public class VoiceCommandServiceConnectionEvents
    {
        VoiceCommandServiceConnection This;

        public VoiceCommandServiceConnectionEvents(VoiceCommandServiceConnection This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.VoiceCommands.VoiceCommandCompletedEventArgs> VoiceCommandCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.VoiceCommands.VoiceCommandServiceConnection,Windows.ApplicationModel.VoiceCommands.VoiceCommandCompletedEventArgs>, Windows.ApplicationModel.VoiceCommands.VoiceCommandCompletedEventArgs>(x => This.VoiceCommandCompleted += x, x => This.VoiceCommandCompleted -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel
{
    public static class EventsMixin
    {
        public static PackageCatalogEvents Events(this PackageCatalog This)
        {
            return new PackageCatalogEvents(This);
        }
    }

    public class PackageCatalogEvents
    {
        PackageCatalog This;

        public PackageCatalogEvents(PackageCatalog This)
        {
            this.This = This;
        }

        public IObservable<Windows.ApplicationModel.PackageInstallingEventArgs> PackageInstalling {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.PackageCatalog,Windows.ApplicationModel.PackageInstallingEventArgs>, Windows.ApplicationModel.PackageInstallingEventArgs>(x => This.PackageInstalling += x, x => This.PackageInstalling -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.PackageStagingEventArgs> PackageStaging {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.PackageCatalog,Windows.ApplicationModel.PackageStagingEventArgs>, Windows.ApplicationModel.PackageStagingEventArgs>(x => This.PackageStaging += x, x => This.PackageStaging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.PackageStatusChangedEventArgs> PackageStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.PackageCatalog,Windows.ApplicationModel.PackageStatusChangedEventArgs>, Windows.ApplicationModel.PackageStatusChangedEventArgs>(x => This.PackageStatusChanged += x, x => This.PackageStatusChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.PackageUninstallingEventArgs> PackageUninstalling {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.PackageCatalog,Windows.ApplicationModel.PackageUninstallingEventArgs>, Windows.ApplicationModel.PackageUninstallingEventArgs>(x => This.PackageUninstalling += x, x => This.PackageUninstalling -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.PackageUpdatingEventArgs> PackageUpdating {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.PackageCatalog,Windows.ApplicationModel.PackageUpdatingEventArgs>, Windows.ApplicationModel.PackageUpdatingEventArgs>(x => This.PackageUpdating += x, x => This.PackageUpdating -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.AllJoyn
{
    public static class EventsMixin
    {
        public static AllJoynBusAttachmentEvents Events(this AllJoynBusAttachment This)
        {
            return new AllJoynBusAttachmentEvents(This);
        }
        public static AllJoynSessionEvents Events(this AllJoynSession This)
        {
            return new AllJoynSessionEvents(This);
        }
        public static AllJoynBusObjectEvents Events(this AllJoynBusObject This)
        {
            return new AllJoynBusObjectEvents(This);
        }
    }

    public class AllJoynBusAttachmentEvents
    {
        AllJoynBusAttachment This;

        public AllJoynBusAttachmentEvents(AllJoynBusAttachment This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.AllJoyn.AllJoynAuthenticationCompleteEventArgs> AuthenticationComplete {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.AllJoyn.AllJoynBusAttachment,Windows.Devices.AllJoyn.AllJoynAuthenticationCompleteEventArgs>, Windows.Devices.AllJoyn.AllJoynAuthenticationCompleteEventArgs>(x => This.AuthenticationComplete += x, x => This.AuthenticationComplete -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.AllJoyn.AllJoynCredentialsRequestedEventArgs> CredentialsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.AllJoyn.AllJoynBusAttachment,Windows.Devices.AllJoyn.AllJoynCredentialsRequestedEventArgs>, Windows.Devices.AllJoyn.AllJoynCredentialsRequestedEventArgs>(x => This.CredentialsRequested += x, x => This.CredentialsRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.AllJoyn.AllJoynCredentialsVerificationRequestedEventArgs> CredentialsVerificationRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.AllJoyn.AllJoynBusAttachment,Windows.Devices.AllJoyn.AllJoynCredentialsVerificationRequestedEventArgs>, Windows.Devices.AllJoyn.AllJoynCredentialsVerificationRequestedEventArgs>(x => This.CredentialsVerificationRequested += x, x => This.CredentialsVerificationRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.AllJoyn.AllJoynBusAttachmentStateChangedEventArgs> StateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.AllJoyn.AllJoynBusAttachment,Windows.Devices.AllJoyn.AllJoynBusAttachmentStateChangedEventArgs>, Windows.Devices.AllJoyn.AllJoynBusAttachmentStateChangedEventArgs>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs> AcceptSessionJoinerRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.AllJoyn.AllJoynBusAttachment,Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs>, Windows.Devices.AllJoyn.AllJoynAcceptSessionJoinerEventArgs>(x => This.AcceptSessionJoinerRequested += x, x => This.AcceptSessionJoinerRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.AllJoyn.AllJoynSessionJoinedEventArgs> SessionJoined {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.AllJoyn.AllJoynBusAttachment,Windows.Devices.AllJoyn.AllJoynSessionJoinedEventArgs>, Windows.Devices.AllJoyn.AllJoynSessionJoinedEventArgs>(x => This.SessionJoined += x, x => This.SessionJoined -= x).Select(x => x.EventArgs); }
        }

    }
    public class AllJoynSessionEvents
    {
        AllJoynSession This;

        public AllJoynSessionEvents(AllJoynSession This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.AllJoyn.AllJoynSessionLostEventArgs> Lost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.AllJoyn.AllJoynSession,Windows.Devices.AllJoyn.AllJoynSessionLostEventArgs>, Windows.Devices.AllJoyn.AllJoynSessionLostEventArgs>(x => This.Lost += x, x => This.Lost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.AllJoyn.AllJoynSessionMemberAddedEventArgs> MemberAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.AllJoyn.AllJoynSession,Windows.Devices.AllJoyn.AllJoynSessionMemberAddedEventArgs>, Windows.Devices.AllJoyn.AllJoynSessionMemberAddedEventArgs>(x => This.MemberAdded += x, x => This.MemberAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.AllJoyn.AllJoynSessionMemberRemovedEventArgs> MemberRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.AllJoyn.AllJoynSession,Windows.Devices.AllJoyn.AllJoynSessionMemberRemovedEventArgs>, Windows.Devices.AllJoyn.AllJoynSessionMemberRemovedEventArgs>(x => This.MemberRemoved += x, x => This.MemberRemoved -= x).Select(x => x.EventArgs); }
        }

    }
    public class AllJoynBusObjectEvents
    {
        AllJoynBusObject This;

        public AllJoynBusObjectEvents(AllJoynBusObject This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.AllJoyn.AllJoynBusObjectStoppedEventArgs> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.AllJoyn.AllJoynBusObject,Windows.Devices.AllJoyn.AllJoynBusObjectStoppedEventArgs>, Windows.Devices.AllJoyn.AllJoynBusObjectStoppedEventArgs>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
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
namespace Windows.Devices.Bluetooth.Advertisement
{
    public static class EventsMixin
    {
        public static BluetoothLEAdvertisementWatcherEvents Events(this BluetoothLEAdvertisementWatcher This)
        {
            return new BluetoothLEAdvertisementWatcherEvents(This);
        }
        public static BluetoothLEAdvertisementPublisherEvents Events(this BluetoothLEAdvertisementPublisher This)
        {
            return new BluetoothLEAdvertisementPublisherEvents(This);
        }
    }

    public class BluetoothLEAdvertisementWatcherEvents
    {
        BluetoothLEAdvertisementWatcher This;

        public BluetoothLEAdvertisementWatcherEvents(BluetoothLEAdvertisementWatcher This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementReceivedEventArgs> Received {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher,Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementReceivedEventArgs>, Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementReceivedEventArgs>(x => This.Received += x, x => This.Received -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcherStoppedEventArgs> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher,Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcherStoppedEventArgs>, Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcherStoppedEventArgs>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

    }
    public class BluetoothLEAdvertisementPublisherEvents
    {
        BluetoothLEAdvertisementPublisher This;

        public BluetoothLEAdvertisementPublisherEvents(BluetoothLEAdvertisementPublisher This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisherStatusChangedEventArgs> StatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher,Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisherStatusChangedEventArgs>, Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisherStatusChangedEventArgs>(x => This.StatusChanged += x, x => This.StatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Enumeration
{
    public static class EventsMixin
    {
        public static DevicePickerEvents Events(this DevicePicker This)
        {
            return new DevicePickerEvents(This);
        }
        public static DeviceWatcherEvents Events(this DeviceWatcher This)
        {
            return new DeviceWatcherEvents(This);
        }
        public static DeviceInformationCustomPairingEvents Events(this DeviceInformationCustomPairing This)
        {
            return new DeviceInformationCustomPairingEvents(This);
        }
        public static DeviceAccessInformationEvents Events(this DeviceAccessInformation This)
        {
            return new DeviceAccessInformationEvents(This);
        }
    }

    public class DevicePickerEvents
    {
        DevicePicker This;

        public DevicePickerEvents(DevicePicker This)
        {
            this.This = This;
        }

        public IObservable<object> DevicePickerDismissed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DevicePicker,object>, object>(x => This.DevicePickerDismissed += x, x => This.DevicePickerDismissed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Enumeration.DeviceSelectedEventArgs> DeviceSelected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DevicePicker,Windows.Devices.Enumeration.DeviceSelectedEventArgs>, Windows.Devices.Enumeration.DeviceSelectedEventArgs>(x => This.DeviceSelected += x, x => This.DeviceSelected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Enumeration.DeviceDisconnectButtonClickedEventArgs> DisconnectButtonClicked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DevicePicker,Windows.Devices.Enumeration.DeviceDisconnectButtonClickedEventArgs>, Windows.Devices.Enumeration.DeviceDisconnectButtonClickedEventArgs>(x => This.DisconnectButtonClicked += x, x => This.DisconnectButtonClicked -= x).Select(x => x.EventArgs); }
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
    public class DeviceInformationCustomPairingEvents
    {
        DeviceInformationCustomPairing This;

        public DeviceInformationCustomPairingEvents(DeviceInformationCustomPairing This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Enumeration.DevicePairingRequestedEventArgs> PairingRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Enumeration.DeviceInformationCustomPairing,Windows.Devices.Enumeration.DevicePairingRequestedEventArgs>, Windows.Devices.Enumeration.DevicePairingRequestedEventArgs>(x => This.PairingRequested += x, x => This.PairingRequested -= x).Select(x => x.EventArgs); }
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
namespace Windows.Devices.Lights
{
    public static class EventsMixin
    {
        public static LampEvents Events(this Lamp This)
        {
            return new LampEvents(This);
        }
    }

    public class LampEvents
    {
        Lamp This;

        public LampEvents(Lamp This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Lights.LampAvailabilityChangedEventArgs> AvailabilityChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Lights.Lamp,Windows.Devices.Lights.LampAvailabilityChangedEventArgs>, Windows.Devices.Lights.LampAvailabilityChangedEventArgs>(x => This.AvailabilityChanged += x, x => This.AvailabilityChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Midi
{
    public static class EventsMixin
    {
        public static MidiInPortEvents Events(this MidiInPort This)
        {
            return new MidiInPortEvents(This);
        }
    }

    public class MidiInPortEvents
    {
        MidiInPort This;

        public MidiInPortEvents(MidiInPort This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Midi.MidiMessageReceivedEventArgs> MessageReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Midi.MidiInPort,Windows.Devices.Midi.MidiMessageReceivedEventArgs>, Windows.Devices.Midi.MidiMessageReceivedEventArgs>(x => This.MessageReceived += x, x => This.MessageReceived -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Perception
{
    public static class EventsMixin
    {
        public static PerceptionColorFrameSourceWatcherEvents Events(this PerceptionColorFrameSourceWatcher This)
        {
            return new PerceptionColorFrameSourceWatcherEvents(This);
        }
        public static PerceptionDepthFrameSourceWatcherEvents Events(this PerceptionDepthFrameSourceWatcher This)
        {
            return new PerceptionDepthFrameSourceWatcherEvents(This);
        }
        public static PerceptionInfraredFrameSourceWatcherEvents Events(this PerceptionInfraredFrameSourceWatcher This)
        {
            return new PerceptionInfraredFrameSourceWatcherEvents(This);
        }
        public static PerceptionColorFrameSourceEvents Events(this PerceptionColorFrameSource This)
        {
            return new PerceptionColorFrameSourceEvents(This);
        }
        public static PerceptionDepthFrameSourceEvents Events(this PerceptionDepthFrameSource This)
        {
            return new PerceptionDepthFrameSourceEvents(This);
        }
        public static PerceptionInfraredFrameSourceEvents Events(this PerceptionInfraredFrameSource This)
        {
            return new PerceptionInfraredFrameSourceEvents(This);
        }
        public static PerceptionControlSessionEvents Events(this PerceptionControlSession This)
        {
            return new PerceptionControlSessionEvents(This);
        }
        public static PerceptionColorFrameReaderEvents Events(this PerceptionColorFrameReader This)
        {
            return new PerceptionColorFrameReaderEvents(This);
        }
        public static PerceptionDepthFrameReaderEvents Events(this PerceptionDepthFrameReader This)
        {
            return new PerceptionDepthFrameReaderEvents(This);
        }
        public static PerceptionInfraredFrameReaderEvents Events(this PerceptionInfraredFrameReader This)
        {
            return new PerceptionInfraredFrameReaderEvents(This);
        }
    }

    public class PerceptionColorFrameSourceWatcherEvents
    {
        PerceptionColorFrameSourceWatcher This;

        public PerceptionColorFrameSourceWatcherEvents(PerceptionColorFrameSourceWatcher This)
        {
            this.This = This;
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionColorFrameSourceWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Perception.PerceptionColorFrameSourceAddedEventArgs> SourceAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionColorFrameSourceWatcher,Windows.Devices.Perception.PerceptionColorFrameSourceAddedEventArgs>, Windows.Devices.Perception.PerceptionColorFrameSourceAddedEventArgs>(x => This.SourceAdded += x, x => This.SourceAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Perception.PerceptionColorFrameSourceRemovedEventArgs> SourceRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionColorFrameSourceWatcher,Windows.Devices.Perception.PerceptionColorFrameSourceRemovedEventArgs>, Windows.Devices.Perception.PerceptionColorFrameSourceRemovedEventArgs>(x => This.SourceRemoved += x, x => This.SourceRemoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionColorFrameSourceWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

    }
    public class PerceptionDepthFrameSourceWatcherEvents
    {
        PerceptionDepthFrameSourceWatcher This;

        public PerceptionDepthFrameSourceWatcherEvents(PerceptionDepthFrameSourceWatcher This)
        {
            this.This = This;
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionDepthFrameSourceWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Perception.PerceptionDepthFrameSourceAddedEventArgs> SourceAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionDepthFrameSourceWatcher,Windows.Devices.Perception.PerceptionDepthFrameSourceAddedEventArgs>, Windows.Devices.Perception.PerceptionDepthFrameSourceAddedEventArgs>(x => This.SourceAdded += x, x => This.SourceAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Perception.PerceptionDepthFrameSourceRemovedEventArgs> SourceRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionDepthFrameSourceWatcher,Windows.Devices.Perception.PerceptionDepthFrameSourceRemovedEventArgs>, Windows.Devices.Perception.PerceptionDepthFrameSourceRemovedEventArgs>(x => This.SourceRemoved += x, x => This.SourceRemoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionDepthFrameSourceWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

    }
    public class PerceptionInfraredFrameSourceWatcherEvents
    {
        PerceptionInfraredFrameSourceWatcher This;

        public PerceptionInfraredFrameSourceWatcherEvents(PerceptionInfraredFrameSourceWatcher This)
        {
            this.This = This;
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionInfraredFrameSourceWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Perception.PerceptionInfraredFrameSourceAddedEventArgs> SourceAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionInfraredFrameSourceWatcher,Windows.Devices.Perception.PerceptionInfraredFrameSourceAddedEventArgs>, Windows.Devices.Perception.PerceptionInfraredFrameSourceAddedEventArgs>(x => This.SourceAdded += x, x => This.SourceAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Perception.PerceptionInfraredFrameSourceRemovedEventArgs> SourceRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionInfraredFrameSourceWatcher,Windows.Devices.Perception.PerceptionInfraredFrameSourceRemovedEventArgs>, Windows.Devices.Perception.PerceptionInfraredFrameSourceRemovedEventArgs>(x => This.SourceRemoved += x, x => This.SourceRemoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionInfraredFrameSourceWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

    }
    public class PerceptionColorFrameSourceEvents
    {
        PerceptionColorFrameSource This;

        public PerceptionColorFrameSourceEvents(PerceptionColorFrameSource This)
        {
            this.This = This;
        }

        public IObservable<object> ActiveChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionColorFrameSource,object>, object>(x => This.ActiveChanged += x, x => This.ActiveChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> AvailableChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionColorFrameSource,object>, object>(x => This.AvailableChanged += x, x => This.AvailableChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> CameraIntrinsicsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionColorFrameSource,object>, object>(x => This.CameraIntrinsicsChanged += x, x => This.CameraIntrinsicsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Perception.PerceptionFrameSourcePropertiesChangedEventArgs> PropertiesChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionColorFrameSource,Windows.Devices.Perception.PerceptionFrameSourcePropertiesChangedEventArgs>, Windows.Devices.Perception.PerceptionFrameSourcePropertiesChangedEventArgs>(x => This.PropertiesChanged += x, x => This.PropertiesChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VideoProfileChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionColorFrameSource,object>, object>(x => This.VideoProfileChanged += x, x => This.VideoProfileChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PerceptionDepthFrameSourceEvents
    {
        PerceptionDepthFrameSource This;

        public PerceptionDepthFrameSourceEvents(PerceptionDepthFrameSource This)
        {
            this.This = This;
        }

        public IObservable<object> ActiveChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionDepthFrameSource,object>, object>(x => This.ActiveChanged += x, x => This.ActiveChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> AvailableChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionDepthFrameSource,object>, object>(x => This.AvailableChanged += x, x => This.AvailableChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> CameraIntrinsicsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionDepthFrameSource,object>, object>(x => This.CameraIntrinsicsChanged += x, x => This.CameraIntrinsicsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Perception.PerceptionFrameSourcePropertiesChangedEventArgs> PropertiesChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionDepthFrameSource,Windows.Devices.Perception.PerceptionFrameSourcePropertiesChangedEventArgs>, Windows.Devices.Perception.PerceptionFrameSourcePropertiesChangedEventArgs>(x => This.PropertiesChanged += x, x => This.PropertiesChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VideoProfileChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionDepthFrameSource,object>, object>(x => This.VideoProfileChanged += x, x => This.VideoProfileChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PerceptionInfraredFrameSourceEvents
    {
        PerceptionInfraredFrameSource This;

        public PerceptionInfraredFrameSourceEvents(PerceptionInfraredFrameSource This)
        {
            this.This = This;
        }

        public IObservable<object> ActiveChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionInfraredFrameSource,object>, object>(x => This.ActiveChanged += x, x => This.ActiveChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> AvailableChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionInfraredFrameSource,object>, object>(x => This.AvailableChanged += x, x => This.AvailableChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> CameraIntrinsicsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionInfraredFrameSource,object>, object>(x => This.CameraIntrinsicsChanged += x, x => This.CameraIntrinsicsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.Perception.PerceptionFrameSourcePropertiesChangedEventArgs> PropertiesChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionInfraredFrameSource,Windows.Devices.Perception.PerceptionFrameSourcePropertiesChangedEventArgs>, Windows.Devices.Perception.PerceptionFrameSourcePropertiesChangedEventArgs>(x => This.PropertiesChanged += x, x => This.PropertiesChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> VideoProfileChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionInfraredFrameSource,object>, object>(x => This.VideoProfileChanged += x, x => This.VideoProfileChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PerceptionControlSessionEvents
    {
        PerceptionControlSession This;

        public PerceptionControlSessionEvents(PerceptionControlSession This)
        {
            this.This = This;
        }

        public IObservable<object> ControlLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionControlSession,object>, object>(x => This.ControlLost += x, x => This.ControlLost -= x).Select(x => x.EventArgs); }
        }

    }
    public class PerceptionColorFrameReaderEvents
    {
        PerceptionColorFrameReader This;

        public PerceptionColorFrameReaderEvents(PerceptionColorFrameReader This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Perception.PerceptionColorFrameArrivedEventArgs> FrameArrived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionColorFrameReader,Windows.Devices.Perception.PerceptionColorFrameArrivedEventArgs>, Windows.Devices.Perception.PerceptionColorFrameArrivedEventArgs>(x => This.FrameArrived += x, x => This.FrameArrived -= x).Select(x => x.EventArgs); }
        }

    }
    public class PerceptionDepthFrameReaderEvents
    {
        PerceptionDepthFrameReader This;

        public PerceptionDepthFrameReaderEvents(PerceptionDepthFrameReader This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Perception.PerceptionDepthFrameArrivedEventArgs> FrameArrived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionDepthFrameReader,Windows.Devices.Perception.PerceptionDepthFrameArrivedEventArgs>, Windows.Devices.Perception.PerceptionDepthFrameArrivedEventArgs>(x => This.FrameArrived += x, x => This.FrameArrived -= x).Select(x => x.EventArgs); }
        }

    }
    public class PerceptionInfraredFrameReaderEvents
    {
        PerceptionInfraredFrameReader This;

        public PerceptionInfraredFrameReaderEvents(PerceptionInfraredFrameReader This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Perception.PerceptionInfraredFrameArrivedEventArgs> FrameArrived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Perception.PerceptionInfraredFrameReader,Windows.Devices.Perception.PerceptionInfraredFrameArrivedEventArgs>, Windows.Devices.Perception.PerceptionInfraredFrameArrivedEventArgs>(x => This.FrameArrived += x, x => This.FrameArrived -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.PointOfService
{
    public static class EventsMixin
    {
        public static BarcodeScannerEvents Events(this BarcodeScanner This)
        {
            return new BarcodeScannerEvents(This);
        }
        public static ClaimedBarcodeScannerEvents Events(this ClaimedBarcodeScanner This)
        {
            return new ClaimedBarcodeScannerEvents(This);
        }
        public static ClaimedMagneticStripeReaderEvents Events(this ClaimedMagneticStripeReader This)
        {
            return new ClaimedMagneticStripeReaderEvents(This);
        }
        public static MagneticStripeReaderEvents Events(this MagneticStripeReader This)
        {
            return new MagneticStripeReaderEvents(This);
        }
        public static PosPrinterEvents Events(this PosPrinter This)
        {
            return new PosPrinterEvents(This);
        }
        public static ClaimedPosPrinterEvents Events(this ClaimedPosPrinter This)
        {
            return new ClaimedPosPrinterEvents(This);
        }
        public static CashDrawerEvents Events(this CashDrawer This)
        {
            return new CashDrawerEvents(This);
        }
        public static CashDrawerEventSourceEvents Events(this CashDrawerEventSource This)
        {
            return new CashDrawerEventSourceEvents(This);
        }
        public static ClaimedCashDrawerEvents Events(this ClaimedCashDrawer This)
        {
            return new ClaimedCashDrawerEvents(This);
        }
        public static CashDrawerCloseAlarmEvents Events(this CashDrawerCloseAlarm This)
        {
            return new CashDrawerCloseAlarmEvents(This);
        }
    }

    public class BarcodeScannerEvents
    {
        BarcodeScanner This;

        public BarcodeScannerEvents(BarcodeScanner This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.PointOfService.BarcodeScannerStatusUpdatedEventArgs> StatusUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.BarcodeScanner,Windows.Devices.PointOfService.BarcodeScannerStatusUpdatedEventArgs>, Windows.Devices.PointOfService.BarcodeScannerStatusUpdatedEventArgs>(x => This.StatusUpdated += x, x => This.StatusUpdated -= x).Select(x => x.EventArgs); }
        }

    }
    public class ClaimedBarcodeScannerEvents
    {
        ClaimedBarcodeScanner This;

        public ClaimedBarcodeScannerEvents(ClaimedBarcodeScanner This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.PointOfService.BarcodeScannerDataReceivedEventArgs> DataReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedBarcodeScanner,Windows.Devices.PointOfService.BarcodeScannerDataReceivedEventArgs>, Windows.Devices.PointOfService.BarcodeScannerDataReceivedEventArgs>(x => This.DataReceived += x, x => This.DataReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.BarcodeScannerErrorOccurredEventArgs> ErrorOccurred {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedBarcodeScanner,Windows.Devices.PointOfService.BarcodeScannerErrorOccurredEventArgs>, Windows.Devices.PointOfService.BarcodeScannerErrorOccurredEventArgs>(x => This.ErrorOccurred += x, x => This.ErrorOccurred -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.BarcodeScannerImagePreviewReceivedEventArgs> ImagePreviewReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedBarcodeScanner,Windows.Devices.PointOfService.BarcodeScannerImagePreviewReceivedEventArgs>, Windows.Devices.PointOfService.BarcodeScannerImagePreviewReceivedEventArgs>(x => This.ImagePreviewReceived += x, x => This.ImagePreviewReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.ClaimedBarcodeScanner> ReleaseDeviceRequested {
            get { return Observable.FromEventPattern<EventHandler<Windows.Devices.PointOfService.ClaimedBarcodeScanner>, Windows.Devices.PointOfService.ClaimedBarcodeScanner>(x => This.ReleaseDeviceRequested += x, x => This.ReleaseDeviceRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.ClaimedBarcodeScanner> TriggerPressed {
            get { return Observable.FromEventPattern<EventHandler<Windows.Devices.PointOfService.ClaimedBarcodeScanner>, Windows.Devices.PointOfService.ClaimedBarcodeScanner>(x => This.TriggerPressed += x, x => This.TriggerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.ClaimedBarcodeScanner> TriggerReleased {
            get { return Observable.FromEventPattern<EventHandler<Windows.Devices.PointOfService.ClaimedBarcodeScanner>, Windows.Devices.PointOfService.ClaimedBarcodeScanner>(x => This.TriggerReleased += x, x => This.TriggerReleased -= x).Select(x => x.EventArgs); }
        }

    }
    public class ClaimedMagneticStripeReaderEvents
    {
        ClaimedMagneticStripeReader This;

        public ClaimedMagneticStripeReaderEvents(ClaimedMagneticStripeReader This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.PointOfService.MagneticStripeReaderAamvaCardDataReceivedEventArgs> AamvaCardDataReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedMagneticStripeReader,Windows.Devices.PointOfService.MagneticStripeReaderAamvaCardDataReceivedEventArgs>, Windows.Devices.PointOfService.MagneticStripeReaderAamvaCardDataReceivedEventArgs>(x => This.AamvaCardDataReceived += x, x => This.AamvaCardDataReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.MagneticStripeReaderBankCardDataReceivedEventArgs> BankCardDataReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedMagneticStripeReader,Windows.Devices.PointOfService.MagneticStripeReaderBankCardDataReceivedEventArgs>, Windows.Devices.PointOfService.MagneticStripeReaderBankCardDataReceivedEventArgs>(x => This.BankCardDataReceived += x, x => This.BankCardDataReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.MagneticStripeReaderErrorOccurredEventArgs> ErrorOccurred {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedMagneticStripeReader,Windows.Devices.PointOfService.MagneticStripeReaderErrorOccurredEventArgs>, Windows.Devices.PointOfService.MagneticStripeReaderErrorOccurredEventArgs>(x => This.ErrorOccurred += x, x => This.ErrorOccurred -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.ClaimedMagneticStripeReader> ReleaseDeviceRequested {
            get { return Observable.FromEventPattern<EventHandler<Windows.Devices.PointOfService.ClaimedMagneticStripeReader>, Windows.Devices.PointOfService.ClaimedMagneticStripeReader>(x => This.ReleaseDeviceRequested += x, x => This.ReleaseDeviceRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.MagneticStripeReaderVendorSpecificCardDataReceivedEventArgs> VendorSpecificDataReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedMagneticStripeReader,Windows.Devices.PointOfService.MagneticStripeReaderVendorSpecificCardDataReceivedEventArgs>, Windows.Devices.PointOfService.MagneticStripeReaderVendorSpecificCardDataReceivedEventArgs>(x => This.VendorSpecificDataReceived += x, x => This.VendorSpecificDataReceived -= x).Select(x => x.EventArgs); }
        }

    }
    public class MagneticStripeReaderEvents
    {
        MagneticStripeReader This;

        public MagneticStripeReaderEvents(MagneticStripeReader This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.PointOfService.MagneticStripeReaderStatusUpdatedEventArgs> StatusUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.MagneticStripeReader,Windows.Devices.PointOfService.MagneticStripeReaderStatusUpdatedEventArgs>, Windows.Devices.PointOfService.MagneticStripeReaderStatusUpdatedEventArgs>(x => This.StatusUpdated += x, x => This.StatusUpdated -= x).Select(x => x.EventArgs); }
        }

    }
    public class PosPrinterEvents
    {
        PosPrinter This;

        public PosPrinterEvents(PosPrinter This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.PointOfService.PosPrinterStatusUpdatedEventArgs> StatusUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.PosPrinter,Windows.Devices.PointOfService.PosPrinterStatusUpdatedEventArgs>, Windows.Devices.PointOfService.PosPrinterStatusUpdatedEventArgs>(x => This.StatusUpdated += x, x => This.StatusUpdated -= x).Select(x => x.EventArgs); }
        }

    }
    public class ClaimedPosPrinterEvents
    {
        ClaimedPosPrinter This;

        public ClaimedPosPrinterEvents(ClaimedPosPrinter This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.PointOfService.PosPrinterReleaseDeviceRequestedEventArgs> ReleaseDeviceRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedPosPrinter,Windows.Devices.PointOfService.PosPrinterReleaseDeviceRequestedEventArgs>, Windows.Devices.PointOfService.PosPrinterReleaseDeviceRequestedEventArgs>(x => This.ReleaseDeviceRequested += x, x => This.ReleaseDeviceRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class CashDrawerEvents
    {
        CashDrawer This;

        public CashDrawerEvents(CashDrawer This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.PointOfService.CashDrawerStatusUpdatedEventArgs> StatusUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.CashDrawer,Windows.Devices.PointOfService.CashDrawerStatusUpdatedEventArgs>, Windows.Devices.PointOfService.CashDrawerStatusUpdatedEventArgs>(x => This.StatusUpdated += x, x => This.StatusUpdated -= x).Select(x => x.EventArgs); }
        }

    }
    public class CashDrawerEventSourceEvents
    {
        CashDrawerEventSource This;

        public CashDrawerEventSourceEvents(CashDrawerEventSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.PointOfService.CashDrawerClosedEventArgs> DrawerClosed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.CashDrawerEventSource,Windows.Devices.PointOfService.CashDrawerClosedEventArgs>, Windows.Devices.PointOfService.CashDrawerClosedEventArgs>(x => This.DrawerClosed += x, x => This.DrawerClosed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.PointOfService.CashDrawerOpenedEventArgs> DrawerOpened {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.CashDrawerEventSource,Windows.Devices.PointOfService.CashDrawerOpenedEventArgs>, Windows.Devices.PointOfService.CashDrawerOpenedEventArgs>(x => This.DrawerOpened += x, x => This.DrawerOpened -= x).Select(x => x.EventArgs); }
        }

    }
    public class ClaimedCashDrawerEvents
    {
        ClaimedCashDrawer This;

        public ClaimedCashDrawerEvents(ClaimedCashDrawer This)
        {
            this.This = This;
        }

        public IObservable<object> ReleaseDeviceRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.ClaimedCashDrawer,object>, object>(x => This.ReleaseDeviceRequested += x, x => This.ReleaseDeviceRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class CashDrawerCloseAlarmEvents
    {
        CashDrawerCloseAlarm This;

        public CashDrawerCloseAlarmEvents(CashDrawerCloseAlarm This)
        {
            this.This = This;
        }

        public IObservable<object> AlarmTimeoutExpired {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.PointOfService.CashDrawerCloseAlarm,object>, object>(x => This.AlarmTimeoutExpired += x, x => This.AlarmTimeoutExpired -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Radios
{
    public static class EventsMixin
    {
        public static RadioEvents Events(this Radio This)
        {
            return new RadioEvents(This);
        }
    }

    public class RadioEvents
    {
        Radio This;

        public RadioEvents(Radio This)
        {
            this.This = This;
        }

        public IObservable<object> StateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Radios.Radio,object>, object>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
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
        public static ActivitySensorEvents Events(this ActivitySensor This)
        {
            return new ActivitySensorEvents(This);
        }
        public static BarometerEvents Events(this Barometer This)
        {
            return new BarometerEvents(This);
        }
        public static PedometerEvents Events(this Pedometer This)
        {
            return new PedometerEvents(This);
        }
        public static ProximitySensorEvents Events(this ProximitySensor This)
        {
            return new ProximitySensorEvents(This);
        }
        public static AltimeterEvents Events(this Altimeter This)
        {
            return new AltimeterEvents(This);
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
    public class ActivitySensorEvents
    {
        ActivitySensor This;

        public ActivitySensorEvents(ActivitySensor This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.ActivitySensorReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.ActivitySensor,Windows.Devices.Sensors.ActivitySensorReadingChangedEventArgs>, Windows.Devices.Sensors.ActivitySensorReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class BarometerEvents
    {
        Barometer This;

        public BarometerEvents(Barometer This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.BarometerReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Barometer,Windows.Devices.Sensors.BarometerReadingChangedEventArgs>, Windows.Devices.Sensors.BarometerReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PedometerEvents
    {
        Pedometer This;

        public PedometerEvents(Pedometer This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.PedometerReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Pedometer,Windows.Devices.Sensors.PedometerReadingChangedEventArgs>, Windows.Devices.Sensors.PedometerReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ProximitySensorEvents
    {
        ProximitySensor This;

        public ProximitySensorEvents(ProximitySensor This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.ProximitySensorReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.ProximitySensor,Windows.Devices.Sensors.ProximitySensorReadingChangedEventArgs>, Windows.Devices.Sensors.ProximitySensorReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class AltimeterEvents
    {
        Altimeter This;

        public AltimeterEvents(Altimeter This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.AltimeterReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Altimeter,Windows.Devices.Sensors.AltimeterReadingChangedEventArgs>, Windows.Devices.Sensors.AltimeterReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Sensors.Custom
{
    public static class EventsMixin
    {
        public static CustomSensorEvents Events(this CustomSensor This)
        {
            return new CustomSensorEvents(This);
        }
    }

    public class CustomSensorEvents
    {
        CustomSensor This;

        public CustomSensorEvents(CustomSensor This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Sensors.Custom.CustomSensorReadingChangedEventArgs> ReadingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Sensors.Custom.CustomSensor,Windows.Devices.Sensors.Custom.CustomSensorReadingChangedEventArgs>, Windows.Devices.Sensors.Custom.CustomSensorReadingChangedEventArgs>(x => This.ReadingChanged += x, x => This.ReadingChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.SerialCommunication
{
    public static class EventsMixin
    {
        public static SerialDeviceEvents Events(this SerialDevice This)
        {
            return new SerialDeviceEvents(This);
        }
    }

    public class SerialDeviceEvents
    {
        SerialDevice This;

        public SerialDeviceEvents(SerialDevice This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.SerialCommunication.ErrorReceivedEventArgs> ErrorReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.SerialCommunication.SerialDevice,Windows.Devices.SerialCommunication.ErrorReceivedEventArgs>, Windows.Devices.SerialCommunication.ErrorReceivedEventArgs>(x => This.ErrorReceived += x, x => This.ErrorReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.SerialCommunication.PinChangedEventArgs> PinChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.SerialCommunication.SerialDevice,Windows.Devices.SerialCommunication.PinChangedEventArgs>, Windows.Devices.SerialCommunication.PinChangedEventArgs>(x => This.PinChanged += x, x => This.PinChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.Usb
{
    public static class EventsMixin
    {
        public static UsbInterruptInPipeEvents Events(this UsbInterruptInPipe This)
        {
            return new UsbInterruptInPipeEvents(This);
        }
    }

    public class UsbInterruptInPipeEvents
    {
        UsbInterruptInPipe This;

        public UsbInterruptInPipeEvents(UsbInterruptInPipe This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.Usb.UsbInterruptInEventArgs> DataReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.Usb.UsbInterruptInPipe,Windows.Devices.Usb.UsbInterruptInEventArgs>, Windows.Devices.Usb.UsbInterruptInEventArgs>(x => This.DataReceived += x, x => This.DataReceived -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.WiFi
{
    public static class EventsMixin
    {
        public static WiFiAdapterEvents Events(this WiFiAdapter This)
        {
            return new WiFiAdapterEvents(This);
        }
    }

    public class WiFiAdapterEvents
    {
        WiFiAdapter This;

        public WiFiAdapterEvents(WiFiAdapter This)
        {
            this.This = This;
        }

        public IObservable<object> AvailableNetworksChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.WiFi.WiFiAdapter,object>, object>(x => This.AvailableNetworksChanged += x, x => This.AvailableNetworksChanged -= x).Select(x => x.EventArgs); }
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
        public static WiFiDirectAdvertisementPublisherEvents Events(this WiFiDirectAdvertisementPublisher This)
        {
            return new WiFiDirectAdvertisementPublisherEvents(This);
        }
        public static WiFiDirectConnectionListenerEvents Events(this WiFiDirectConnectionListener This)
        {
            return new WiFiDirectConnectionListenerEvents(This);
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
    public class WiFiDirectAdvertisementPublisherEvents
    {
        WiFiDirectAdvertisementPublisher This;

        public WiFiDirectAdvertisementPublisherEvents(WiFiDirectAdvertisementPublisher This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.WiFiDirect.WiFiDirectAdvertisementPublisherStatusChangedEventArgs> StatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.WiFiDirect.WiFiDirectAdvertisementPublisher,Windows.Devices.WiFiDirect.WiFiDirectAdvertisementPublisherStatusChangedEventArgs>, Windows.Devices.WiFiDirect.WiFiDirectAdvertisementPublisherStatusChangedEventArgs>(x => This.StatusChanged += x, x => This.StatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class WiFiDirectConnectionListenerEvents
    {
        WiFiDirectConnectionListener This;

        public WiFiDirectConnectionListenerEvents(WiFiDirectConnectionListener This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.WiFiDirect.WiFiDirectConnectionRequestedEventArgs> ConnectionRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.WiFiDirect.WiFiDirectConnectionListener,Windows.Devices.WiFiDirect.WiFiDirectConnectionRequestedEventArgs>, Windows.Devices.WiFiDirect.WiFiDirectConnectionRequestedEventArgs>(x => This.ConnectionRequested += x, x => This.ConnectionRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Devices.WiFiDirect.Services
{
    public static class EventsMixin
    {
        public static WiFiDirectServiceSessionEvents Events(this WiFiDirectServiceSession This)
        {
            return new WiFiDirectServiceSessionEvents(This);
        }
        public static WiFiDirectServiceAdvertiserEvents Events(this WiFiDirectServiceAdvertiser This)
        {
            return new WiFiDirectServiceAdvertiserEvents(This);
        }
        public static WiFiDirectServiceEvents Events(this WiFiDirectService This)
        {
            return new WiFiDirectServiceEvents(This);
        }
    }

    public class WiFiDirectServiceSessionEvents
    {
        WiFiDirectServiceSession This;

        public WiFiDirectServiceSessionEvents(WiFiDirectServiceSession This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.WiFiDirect.Services.WiFiDirectServiceRemotePortAddedEventArgs> RemotePortAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSession,Windows.Devices.WiFiDirect.Services.WiFiDirectServiceRemotePortAddedEventArgs>, Windows.Devices.WiFiDirect.Services.WiFiDirectServiceRemotePortAddedEventArgs>(x => This.RemotePortAdded += x, x => This.RemotePortAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> SessionStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSession,object>, object>(x => This.SessionStatusChanged += x, x => This.SessionStatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class WiFiDirectServiceAdvertiserEvents
    {
        WiFiDirectServiceAdvertiser This;

        public WiFiDirectServiceAdvertiserEvents(WiFiDirectServiceAdvertiser This)
        {
            this.This = This;
        }

        public IObservable<object> AdvertisementStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser,object>, object>(x => This.AdvertisementStatusChanged += x, x => This.AdvertisementStatusChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAutoAcceptSessionConnectedEventArgs> AutoAcceptSessionConnected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser,Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAutoAcceptSessionConnectedEventArgs>, Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAutoAcceptSessionConnectedEventArgs>(x => This.AutoAcceptSessionConnected += x, x => This.AutoAcceptSessionConnected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionRequestedEventArgs> SessionRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertiser,Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionRequestedEventArgs>, Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionRequestedEventArgs>(x => This.SessionRequested += x, x => This.SessionRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class WiFiDirectServiceEvents
    {
        WiFiDirectService This;

        public WiFiDirectServiceEvents(WiFiDirectService This)
        {
            this.This = This;
        }

        public IObservable<Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionDeferredEventArgs> SessionDeferred {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Devices.WiFiDirect.Services.WiFiDirectService,Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionDeferredEventArgs>, Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionDeferredEventArgs>(x => This.SessionDeferred += x, x => This.SessionDeferred -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Foundation
{
    public static class EventsMixin
    {
        public static IMemoryBufferReferenceEvents Events(this IMemoryBufferReference This)
        {
            return new IMemoryBufferReferenceEvents(This);
        }
    }

    public class IMemoryBufferReferenceEvents
    {
        IMemoryBufferReference This;

        public IMemoryBufferReferenceEvents(IMemoryBufferReference This)
        {
            this.This = This;
        }

        public IObservable<object> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Foundation.IMemoryBufferReference,object>, object>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Gaming.Input
{
    public static class EventsMixin
    {
        public static IGameControllerEvents Events(this IGameController This)
        {
            return new IGameControllerEvents(This);
        }
        public static ArcadeStickEvents Events(this ArcadeStick This)
        {
            return new ArcadeStickEvents(This);
        }
        public static GamepadEvents Events(this Gamepad This)
        {
            return new GamepadEvents(This);
        }
        public static RacingWheelEvents Events(this RacingWheel This)
        {
            return new RacingWheelEvents(This);
        }
        public static UINavigationControllerEvents Events(this UINavigationController This)
        {
            return new UINavigationControllerEvents(This);
        }
    }

    public class IGameControllerEvents
    {
        IGameController This;

        public IGameControllerEvents(IGameController This)
        {
            this.This = This;
        }

        public IObservable<Windows.Gaming.Input.Headset> HeadsetConnected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.Gaming.Input.Headset>, Windows.Gaming.Input.Headset>(x => This.HeadsetConnected += x, x => This.HeadsetConnected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Gaming.Input.Headset> HeadsetDisconnected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.Gaming.Input.Headset>, Windows.Gaming.Input.Headset>(x => This.HeadsetDisconnected += x, x => This.HeadsetDisconnected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.System.UserChangedEventArgs> UserChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.System.UserChangedEventArgs>, Windows.System.UserChangedEventArgs>(x => This.UserChanged += x, x => This.UserChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ArcadeStickEvents
    {
        ArcadeStick This;

        public ArcadeStickEvents(ArcadeStick This)
        {
            this.This = This;
        }

        public IObservable<Windows.Gaming.Input.Headset> HeadsetConnected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.Gaming.Input.Headset>, Windows.Gaming.Input.Headset>(x => This.HeadsetConnected += x, x => This.HeadsetConnected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Gaming.Input.Headset> HeadsetDisconnected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.Gaming.Input.Headset>, Windows.Gaming.Input.Headset>(x => This.HeadsetDisconnected += x, x => This.HeadsetDisconnected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.System.UserChangedEventArgs> UserChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.System.UserChangedEventArgs>, Windows.System.UserChangedEventArgs>(x => This.UserChanged += x, x => This.UserChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class GamepadEvents
    {
        Gamepad This;

        public GamepadEvents(Gamepad This)
        {
            this.This = This;
        }

        public IObservable<Windows.Gaming.Input.Headset> HeadsetConnected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.Gaming.Input.Headset>, Windows.Gaming.Input.Headset>(x => This.HeadsetConnected += x, x => This.HeadsetConnected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Gaming.Input.Headset> HeadsetDisconnected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.Gaming.Input.Headset>, Windows.Gaming.Input.Headset>(x => This.HeadsetDisconnected += x, x => This.HeadsetDisconnected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.System.UserChangedEventArgs> UserChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.System.UserChangedEventArgs>, Windows.System.UserChangedEventArgs>(x => This.UserChanged += x, x => This.UserChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class RacingWheelEvents
    {
        RacingWheel This;

        public RacingWheelEvents(RacingWheel This)
        {
            this.This = This;
        }

        public IObservable<Windows.Gaming.Input.Headset> HeadsetConnected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.Gaming.Input.Headset>, Windows.Gaming.Input.Headset>(x => This.HeadsetConnected += x, x => This.HeadsetConnected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Gaming.Input.Headset> HeadsetDisconnected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.Gaming.Input.Headset>, Windows.Gaming.Input.Headset>(x => This.HeadsetDisconnected += x, x => This.HeadsetDisconnected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.System.UserChangedEventArgs> UserChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.System.UserChangedEventArgs>, Windows.System.UserChangedEventArgs>(x => This.UserChanged += x, x => This.UserChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class UINavigationControllerEvents
    {
        UINavigationController This;

        public UINavigationControllerEvents(UINavigationController This)
        {
            this.This = This;
        }

        public IObservable<Windows.Gaming.Input.Headset> HeadsetConnected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.Gaming.Input.Headset>, Windows.Gaming.Input.Headset>(x => This.HeadsetConnected += x, x => This.HeadsetConnected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Gaming.Input.Headset> HeadsetDisconnected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.Gaming.Input.Headset>, Windows.Gaming.Input.Headset>(x => This.HeadsetDisconnected += x, x => This.HeadsetDisconnected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.System.UserChangedEventArgs> UserChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Gaming.Input.IGameController,Windows.System.UserChangedEventArgs>, Windows.System.UserChangedEventArgs>(x => This.UserChanged += x, x => This.UserChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Graphics.Printing.OptionDetails
{
    public static class EventsMixin
    {
        public static PrintTaskOptionDetailsEvents Events(this PrintTaskOptionDetails This)
        {
            return new PrintTaskOptionDetailsEvents(This);
        }
    }

    public class PrintTaskOptionDetailsEvents
    {
        PrintTaskOptionDetails This;

        public PrintTaskOptionDetailsEvents(PrintTaskOptionDetails This)
        {
            this.This = This;
        }

        public IObservable<object> BeginValidation {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails,object>, object>(x => This.BeginValidation += x, x => This.BeginValidation -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Graphics.Printing.OptionDetails.PrintTaskOptionChangedEventArgs> OptionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.OptionDetails.PrintTaskOptionDetails,Windows.Graphics.Printing.OptionDetails.PrintTaskOptionChangedEventArgs>, Windows.Graphics.Printing.OptionDetails.PrintTaskOptionChangedEventArgs>(x => This.OptionChanged += x, x => This.OptionChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Graphics.Printing
{
    public static class EventsMixin
    {
        public static PrintTaskEvents Events(this PrintTask This)
        {
            return new PrintTaskEvents(This);
        }
        public static PrintManagerEvents Events(this PrintManager This)
        {
            return new PrintManagerEvents(This);
        }
    }

    public class PrintTaskEvents
    {
        PrintTask This;

        public PrintTaskEvents(PrintTask This)
        {
            this.This = This;
        }

        public IObservable<Windows.Graphics.Printing.PrintTaskCompletedEventArgs> Completed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.PrintTask,Windows.Graphics.Printing.PrintTaskCompletedEventArgs>, Windows.Graphics.Printing.PrintTaskCompletedEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Previewing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.PrintTask,object>, object>(x => This.Previewing += x, x => This.Previewing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Graphics.Printing.PrintTaskProgressingEventArgs> Progressing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.PrintTask,Windows.Graphics.Printing.PrintTaskProgressingEventArgs>, Windows.Graphics.Printing.PrintTaskProgressingEventArgs>(x => This.Progressing += x, x => This.Progressing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Submitting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.PrintTask,object>, object>(x => This.Submitting += x, x => This.Submitting -= x).Select(x => x.EventArgs); }
        }

    }
    public class PrintManagerEvents
    {
        PrintManager This;

        public PrintManagerEvents(PrintManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.Graphics.Printing.PrintTaskRequestedEventArgs> PrintTaskRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing.PrintManager,Windows.Graphics.Printing.PrintTaskRequestedEventArgs>, Windows.Graphics.Printing.PrintTaskRequestedEventArgs>(x => This.PrintTaskRequested += x, x => This.PrintTaskRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Audio
{
    public static class EventsMixin
    {
        public static AudioGraphEvents Events(this AudioGraph This)
        {
            return new AudioGraphEvents(This);
        }
        public static AudioFileInputNodeEvents Events(this AudioFileInputNode This)
        {
            return new AudioFileInputNodeEvents(This);
        }
        public static AudioFrameInputNodeEvents Events(this AudioFrameInputNode This)
        {
            return new AudioFrameInputNodeEvents(This);
        }
    }

    public class AudioGraphEvents
    {
        AudioGraph This;

        public AudioGraphEvents(AudioGraph This)
        {
            this.This = This;
        }

        public IObservable<object> QuantumProcessed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Audio.AudioGraph,object>, object>(x => This.QuantumProcessed += x, x => This.QuantumProcessed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> QuantumStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Audio.AudioGraph,object>, object>(x => This.QuantumStarted += x, x => This.QuantumStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Audio.AudioGraphUnrecoverableErrorOccurredEventArgs> UnrecoverableErrorOccurred {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Audio.AudioGraph,Windows.Media.Audio.AudioGraphUnrecoverableErrorOccurredEventArgs>, Windows.Media.Audio.AudioGraphUnrecoverableErrorOccurredEventArgs>(x => This.UnrecoverableErrorOccurred += x, x => This.UnrecoverableErrorOccurred -= x).Select(x => x.EventArgs); }
        }

    }
    public class AudioFileInputNodeEvents
    {
        AudioFileInputNode This;

        public AudioFileInputNodeEvents(AudioFileInputNode This)
        {
            this.This = This;
        }

        public IObservable<object> FileCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Audio.AudioFileInputNode,object>, object>(x => This.FileCompleted += x, x => This.FileCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class AudioFrameInputNodeEvents
    {
        AudioFrameInputNode This;

        public AudioFrameInputNodeEvents(AudioFrameInputNode This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Audio.AudioFrameCompletedEventArgs> AudioFrameCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Audio.AudioFrameInputNode,Windows.Media.Audio.AudioFrameCompletedEventArgs>, Windows.Media.Audio.AudioFrameCompletedEventArgs>(x => This.AudioFrameCompleted += x, x => This.AudioFrameCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Audio.FrameInputNodeQuantumStartedEventArgs> QuantumStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Audio.AudioFrameInputNode,Windows.Media.Audio.FrameInputNodeQuantumStartedEventArgs>, Windows.Media.Audio.FrameInputNodeQuantumStartedEventArgs>(x => This.QuantumStarted += x, x => This.QuantumStarted -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Capture
{
    public static class EventsMixin
    {
        public static AppCaptureEvents Events(this AppCapture This)
        {
            return new AppCaptureEvents(This);
        }
        public static MediaCaptureEvents Events(this MediaCapture This)
        {
            return new MediaCaptureEvents(This);
        }
        public static LowLagPhotoSequenceCaptureEvents Events(this LowLagPhotoSequenceCapture This)
        {
            return new LowLagPhotoSequenceCaptureEvents(This);
        }
        public static AdvancedPhotoCaptureEvents Events(this AdvancedPhotoCapture This)
        {
            return new AdvancedPhotoCaptureEvents(This);
        }
        public static ScreenCaptureEvents Events(this ScreenCapture This)
        {
            return new ScreenCaptureEvents(This);
        }
    }

    public class AppCaptureEvents
    {
        AppCapture This;

        public AppCaptureEvents(AppCapture This)
        {
            this.This = This;
        }

        public IObservable<object> CapturingChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.AppCapture,object>, object>(x => This.CapturingChanged += x, x => This.CapturingChanged -= x).Select(x => x.EventArgs); }
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

        public IObservable<object> CameraStreamStateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.MediaCapture,object>, object>(x => This.CameraStreamStateChanged += x, x => This.CameraStreamStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ThermalStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.MediaCapture,object>, object>(x => This.ThermalStatusChanged += x, x => This.ThermalStatusChanged -= x).Select(x => x.EventArgs); }
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
    public class AdvancedPhotoCaptureEvents
    {
        AdvancedPhotoCapture This;

        public AdvancedPhotoCaptureEvents(AdvancedPhotoCapture This)
        {
            this.This = This;
        }

        public IObservable<object> AllPhotosCaptured {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.AdvancedPhotoCapture,object>, object>(x => This.AllPhotosCaptured += x, x => This.AllPhotosCaptured -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Capture.OptionalReferencePhotoCapturedEventArgs> OptionalReferencePhotoCaptured {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.AdvancedPhotoCapture,Windows.Media.Capture.OptionalReferencePhotoCapturedEventArgs>, Windows.Media.Capture.OptionalReferencePhotoCapturedEventArgs>(x => This.OptionalReferencePhotoCaptured += x, x => This.OptionalReferencePhotoCaptured -= x).Select(x => x.EventArgs); }
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
}
namespace Windows.Media.Casting
{
    public static class EventsMixin
    {
        public static CastingConnectionEvents Events(this CastingConnection This)
        {
            return new CastingConnectionEvents(This);
        }
        public static CastingDevicePickerEvents Events(this CastingDevicePicker This)
        {
            return new CastingDevicePickerEvents(This);
        }
    }

    public class CastingConnectionEvents
    {
        CastingConnection This;

        public CastingConnectionEvents(CastingConnection This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Casting.CastingConnectionErrorOccurredEventArgs> ErrorOccurred {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Casting.CastingConnection,Windows.Media.Casting.CastingConnectionErrorOccurredEventArgs>, Windows.Media.Casting.CastingConnectionErrorOccurredEventArgs>(x => This.ErrorOccurred += x, x => This.ErrorOccurred -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> StateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Casting.CastingConnection,object>, object>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CastingDevicePickerEvents
    {
        CastingDevicePicker This;

        public CastingDevicePickerEvents(CastingDevicePicker This)
        {
            this.This = This;
        }

        public IObservable<object> CastingDevicePickerDismissed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Casting.CastingDevicePicker,object>, object>(x => This.CastingDevicePickerDismissed += x, x => This.CastingDevicePickerDismissed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Casting.CastingDeviceSelectedEventArgs> CastingDeviceSelected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Casting.CastingDevicePicker,Windows.Media.Casting.CastingDeviceSelectedEventArgs>, Windows.Media.Casting.CastingDeviceSelectedEventArgs>(x => This.CastingDeviceSelected += x, x => This.CastingDeviceSelected -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.DialProtocol
{
    public static class EventsMixin
    {
        public static DialDevicePickerEvents Events(this DialDevicePicker This)
        {
            return new DialDevicePickerEvents(This);
        }
    }

    public class DialDevicePickerEvents
    {
        DialDevicePicker This;

        public DialDevicePickerEvents(DialDevicePicker This)
        {
            this.This = This;
        }

        public IObservable<object> DialDevicePickerDismissed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.DialProtocol.DialDevicePicker,object>, object>(x => This.DialDevicePickerDismissed += x, x => This.DialDevicePickerDismissed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.DialProtocol.DialDeviceSelectedEventArgs> DialDeviceSelected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.DialProtocol.DialDevicePicker,Windows.Media.DialProtocol.DialDeviceSelectedEventArgs>, Windows.Media.DialProtocol.DialDeviceSelectedEventArgs>(x => This.DialDeviceSelected += x, x => This.DialDeviceSelected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.DialProtocol.DialDisconnectButtonClickedEventArgs> DisconnectButtonClicked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.DialProtocol.DialDevicePicker,Windows.Media.DialProtocol.DialDisconnectButtonClickedEventArgs>, Windows.Media.DialProtocol.DialDisconnectButtonClickedEventArgs>(x => This.DisconnectButtonClicked += x, x => This.DisconnectButtonClicked -= x).Select(x => x.EventArgs); }
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
namespace Windows.Media.Import
{
    public static class EventsMixin
    {
        public static PhotoImportFindItemsResultEvents Events(this PhotoImportFindItemsResult This)
        {
            return new PhotoImportFindItemsResultEvents(This);
        }
    }

    public class PhotoImportFindItemsResultEvents
    {
        PhotoImportFindItemsResult This;

        public PhotoImportFindItemsResultEvents(PhotoImportFindItemsResult This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Import.PhotoImportItemImportedEventArgs> ItemImported {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Import.PhotoImportFindItemsResult,Windows.Media.Import.PhotoImportItemImportedEventArgs>, Windows.Media.Import.PhotoImportItemImportedEventArgs>(x => This.ItemImported += x, x => This.ItemImported -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Import.PhotoImportSelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Import.PhotoImportFindItemsResult,Windows.Media.Import.PhotoImportSelectionChangedEventArgs>, Windows.Media.Import.PhotoImportSelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
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
        public static MediaBreakManagerEvents Events(this MediaBreakManager This)
        {
            return new MediaBreakManagerEvents(This);
        }
        public static MediaPlaybackCommandManagerEvents Events(this MediaPlaybackCommandManager This)
        {
            return new MediaPlaybackCommandManagerEvents(This);
        }
        public static MediaPlaybackSessionEvents Events(this MediaPlaybackSession This)
        {
            return new MediaPlaybackSessionEvents(This);
        }
        public static MediaPlaybackCommandManagerCommandBehaviorEvents Events(this MediaPlaybackCommandManagerCommandBehavior This)
        {
            return new MediaPlaybackCommandManagerCommandBehaviorEvents(This);
        }
        public static MediaPlaybackItemEvents Events(this MediaPlaybackItem This)
        {
            return new MediaPlaybackItemEvents(This);
        }
        public static MediaPlaybackAudioTrackListEvents Events(this MediaPlaybackAudioTrackList This)
        {
            return new MediaPlaybackAudioTrackListEvents(This);
        }
        public static MediaPlaybackVideoTrackListEvents Events(this MediaPlaybackVideoTrackList This)
        {
            return new MediaPlaybackVideoTrackListEvents(This);
        }
        public static MediaPlaybackTimedMetadataTrackListEvents Events(this MediaPlaybackTimedMetadataTrackList This)
        {
            return new MediaPlaybackTimedMetadataTrackListEvents(This);
        }
        public static MediaBreakScheduleEvents Events(this MediaBreakSchedule This)
        {
            return new MediaBreakScheduleEvents(This);
        }
        public static MediaPlaybackListEvents Events(this MediaPlaybackList This)
        {
            return new MediaPlaybackListEvents(This);
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

        public IObservable<object> IsMutedChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlayer,object>, object>(x => This.IsMutedChanged += x, x => This.IsMutedChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> SourceChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlayer,object>, object>(x => This.SourceChanged += x, x => This.SourceChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaBreakManagerEvents
    {
        MediaBreakManager This;

        public MediaBreakManagerEvents(MediaBreakManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Playback.MediaBreakEndedEventArgs> BreakEnded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaBreakManager,Windows.Media.Playback.MediaBreakEndedEventArgs>, Windows.Media.Playback.MediaBreakEndedEventArgs>(x => This.BreakEnded += x, x => This.BreakEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaBreakSkippedEventArgs> BreakSkipped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaBreakManager,Windows.Media.Playback.MediaBreakSkippedEventArgs>, Windows.Media.Playback.MediaBreakSkippedEventArgs>(x => This.BreakSkipped += x, x => This.BreakSkipped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaBreakStartedEventArgs> BreakStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaBreakManager,Windows.Media.Playback.MediaBreakStartedEventArgs>, Windows.Media.Playback.MediaBreakStartedEventArgs>(x => This.BreakStarted += x, x => This.BreakStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaBreakSeekedOverEventArgs> BreaksSeekedOver {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaBreakManager,Windows.Media.Playback.MediaBreakSeekedOverEventArgs>, Windows.Media.Playback.MediaBreakSeekedOverEventArgs>(x => This.BreaksSeekedOver += x, x => This.BreaksSeekedOver -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaPlaybackCommandManagerEvents
    {
        MediaPlaybackCommandManager This;

        public MediaPlaybackCommandManagerEvents(MediaPlaybackCommandManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Playback.MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs> AutoRepeatModeReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackCommandManager,Windows.Media.Playback.MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs>, Windows.Media.Playback.MediaPlaybackCommandManagerAutoRepeatModeReceivedEventArgs>(x => This.AutoRepeatModeReceived += x, x => This.AutoRepeatModeReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlaybackCommandManagerFastForwardReceivedEventArgs> FastForwardReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackCommandManager,Windows.Media.Playback.MediaPlaybackCommandManagerFastForwardReceivedEventArgs>, Windows.Media.Playback.MediaPlaybackCommandManagerFastForwardReceivedEventArgs>(x => This.FastForwardReceived += x, x => This.FastForwardReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlaybackCommandManagerNextReceivedEventArgs> NextReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackCommandManager,Windows.Media.Playback.MediaPlaybackCommandManagerNextReceivedEventArgs>, Windows.Media.Playback.MediaPlaybackCommandManagerNextReceivedEventArgs>(x => This.NextReceived += x, x => This.NextReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlaybackCommandManagerPauseReceivedEventArgs> PauseReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackCommandManager,Windows.Media.Playback.MediaPlaybackCommandManagerPauseReceivedEventArgs>, Windows.Media.Playback.MediaPlaybackCommandManagerPauseReceivedEventArgs>(x => This.PauseReceived += x, x => This.PauseReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlaybackCommandManagerPlayReceivedEventArgs> PlayReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackCommandManager,Windows.Media.Playback.MediaPlaybackCommandManagerPlayReceivedEventArgs>, Windows.Media.Playback.MediaPlaybackCommandManagerPlayReceivedEventArgs>(x => This.PlayReceived += x, x => This.PlayReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlaybackCommandManagerPositionReceivedEventArgs> PositionReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackCommandManager,Windows.Media.Playback.MediaPlaybackCommandManagerPositionReceivedEventArgs>, Windows.Media.Playback.MediaPlaybackCommandManagerPositionReceivedEventArgs>(x => This.PositionReceived += x, x => This.PositionReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlaybackCommandManagerPreviousReceivedEventArgs> PreviousReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackCommandManager,Windows.Media.Playback.MediaPlaybackCommandManagerPreviousReceivedEventArgs>, Windows.Media.Playback.MediaPlaybackCommandManagerPreviousReceivedEventArgs>(x => This.PreviousReceived += x, x => This.PreviousReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlaybackCommandManagerRateReceivedEventArgs> RateReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackCommandManager,Windows.Media.Playback.MediaPlaybackCommandManagerRateReceivedEventArgs>, Windows.Media.Playback.MediaPlaybackCommandManagerRateReceivedEventArgs>(x => This.RateReceived += x, x => This.RateReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlaybackCommandManagerRewindReceivedEventArgs> RewindReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackCommandManager,Windows.Media.Playback.MediaPlaybackCommandManagerRewindReceivedEventArgs>, Windows.Media.Playback.MediaPlaybackCommandManagerRewindReceivedEventArgs>(x => This.RewindReceived += x, x => This.RewindReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlaybackCommandManagerShuffleReceivedEventArgs> ShuffleReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackCommandManager,Windows.Media.Playback.MediaPlaybackCommandManagerShuffleReceivedEventArgs>, Windows.Media.Playback.MediaPlaybackCommandManagerShuffleReceivedEventArgs>(x => This.ShuffleReceived += x, x => This.ShuffleReceived -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaPlaybackSessionEvents
    {
        MediaPlaybackSession This;

        public MediaPlaybackSessionEvents(MediaPlaybackSession This)
        {
            this.This = This;
        }

        public IObservable<object> BufferingEnded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackSession,object>, object>(x => This.BufferingEnded += x, x => This.BufferingEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> BufferingProgressChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackSession,object>, object>(x => This.BufferingProgressChanged += x, x => This.BufferingProgressChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> BufferingStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackSession,object>, object>(x => This.BufferingStarted += x, x => This.BufferingStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> DownloadProgressChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackSession,object>, object>(x => This.DownloadProgressChanged += x, x => This.DownloadProgressChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> NaturalDurationChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackSession,object>, object>(x => This.NaturalDurationChanged += x, x => This.NaturalDurationChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> NaturalVideoSizeChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackSession,object>, object>(x => This.NaturalVideoSizeChanged += x, x => This.NaturalVideoSizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> PlaybackRateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackSession,object>, object>(x => This.PlaybackRateChanged += x, x => This.PlaybackRateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> PlaybackStateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackSession,object>, object>(x => This.PlaybackStateChanged += x, x => This.PlaybackStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> PositionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackSession,object>, object>(x => This.PositionChanged += x, x => This.PositionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> SeekCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackSession,object>, object>(x => This.SeekCompleted += x, x => This.SeekCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaPlaybackCommandManagerCommandBehaviorEvents
    {
        MediaPlaybackCommandManagerCommandBehavior This;

        public MediaPlaybackCommandManagerCommandBehaviorEvents(MediaPlaybackCommandManagerCommandBehavior This)
        {
            this.This = This;
        }

        public IObservable<object> IsEnabledChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackCommandManagerCommandBehavior,object>, object>(x => This.IsEnabledChanged += x, x => This.IsEnabledChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaPlaybackItemEvents
    {
        MediaPlaybackItem This;

        public MediaPlaybackItemEvents(MediaPlaybackItem This)
        {
            this.This = This;
        }

        public IObservable<Windows.Foundation.Collections.IVectorChangedEventArgs> AudioTracksChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackItem,Windows.Foundation.Collections.IVectorChangedEventArgs>, Windows.Foundation.Collections.IVectorChangedEventArgs>(x => This.AudioTracksChanged += x, x => This.AudioTracksChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Foundation.Collections.IVectorChangedEventArgs> TimedMetadataTracksChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackItem,Windows.Foundation.Collections.IVectorChangedEventArgs>, Windows.Foundation.Collections.IVectorChangedEventArgs>(x => This.TimedMetadataTracksChanged += x, x => This.TimedMetadataTracksChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Foundation.Collections.IVectorChangedEventArgs> VideoTracksChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackItem,Windows.Foundation.Collections.IVectorChangedEventArgs>, Windows.Foundation.Collections.IVectorChangedEventArgs>(x => This.VideoTracksChanged += x, x => This.VideoTracksChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaPlaybackAudioTrackListEvents
    {
        MediaPlaybackAudioTrackList This;

        public MediaPlaybackAudioTrackListEvents(MediaPlaybackAudioTrackList This)
        {
            this.This = This;
        }

        public IObservable<object> SelectedIndexChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.ISingleSelectMediaTrackList,object>, object>(x => This.SelectedIndexChanged += x, x => This.SelectedIndexChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaPlaybackVideoTrackListEvents
    {
        MediaPlaybackVideoTrackList This;

        public MediaPlaybackVideoTrackListEvents(MediaPlaybackVideoTrackList This)
        {
            this.This = This;
        }

        public IObservable<object> SelectedIndexChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.ISingleSelectMediaTrackList,object>, object>(x => This.SelectedIndexChanged += x, x => This.SelectedIndexChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaPlaybackTimedMetadataTrackListEvents
    {
        MediaPlaybackTimedMetadataTrackList This;

        public MediaPlaybackTimedMetadataTrackListEvents(MediaPlaybackTimedMetadataTrackList This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Playback.TimedMetadataPresentationModeChangedEventArgs> PresentationModeChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackTimedMetadataTrackList,Windows.Media.Playback.TimedMetadataPresentationModeChangedEventArgs>, Windows.Media.Playback.TimedMetadataPresentationModeChangedEventArgs>(x => This.PresentationModeChanged += x, x => This.PresentationModeChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaBreakScheduleEvents
    {
        MediaBreakSchedule This;

        public MediaBreakScheduleEvents(MediaBreakSchedule This)
        {
            this.This = This;
        }

        public IObservable<object> ScheduleChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaBreakSchedule,object>, object>(x => This.ScheduleChanged += x, x => This.ScheduleChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaPlaybackListEvents
    {
        MediaPlaybackList This;

        public MediaPlaybackListEvents(MediaPlaybackList This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Playback.CurrentMediaPlaybackItemChangedEventArgs> CurrentItemChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackList,Windows.Media.Playback.CurrentMediaPlaybackItemChangedEventArgs>, Windows.Media.Playback.CurrentMediaPlaybackItemChangedEventArgs>(x => This.CurrentItemChanged += x, x => This.CurrentItemChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlaybackItemFailedEventArgs> ItemFailed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackList,Windows.Media.Playback.MediaPlaybackItemFailedEventArgs>, Windows.Media.Playback.MediaPlaybackItemFailedEventArgs>(x => This.ItemFailed += x, x => This.ItemFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Playback.MediaPlaybackItemOpenedEventArgs> ItemOpened {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Playback.MediaPlaybackList,Windows.Media.Playback.MediaPlaybackItemOpenedEventArgs>, Windows.Media.Playback.MediaPlaybackItemOpenedEventArgs>(x => This.ItemOpened += x, x => This.ItemOpened -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.PlayTo
{
    public static class EventsMixin
    {
        public static PlayToReceiverEvents Events(this PlayToReceiver This)
        {
            return new PlayToReceiverEvents(This);
        }
        public static PlayToConnectionEvents Events(this PlayToConnection This)
        {
            return new PlayToConnectionEvents(This);
        }
        public static PlayToManagerEvents Events(this PlayToManager This)
        {
            return new PlayToManagerEvents(This);
        }
    }

    public class PlayToReceiverEvents
    {
        PlayToReceiver This;

        public PlayToReceiverEvents(PlayToReceiver This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.PlayTo.CurrentTimeChangeRequestedEventArgs> CurrentTimeChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,Windows.Media.PlayTo.CurrentTimeChangeRequestedEventArgs>, Windows.Media.PlayTo.CurrentTimeChangeRequestedEventArgs>(x => This.CurrentTimeChangeRequested += x, x => This.CurrentTimeChangeRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.MuteChangeRequestedEventArgs> MuteChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,Windows.Media.PlayTo.MuteChangeRequestedEventArgs>, Windows.Media.PlayTo.MuteChangeRequestedEventArgs>(x => This.MuteChangeRequested += x, x => This.MuteChangeRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> PauseRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,object>, object>(x => This.PauseRequested += x, x => This.PauseRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> PlayRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,object>, object>(x => This.PlayRequested += x, x => This.PlayRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,Windows.Media.PlayTo.PlaybackRateChangeRequestedEventArgs>, Windows.Media.PlayTo.PlaybackRateChangeRequestedEventArgs>(x => This.PlaybackRateChangeRequested += x, x => This.PlaybackRateChangeRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.SourceChangeRequestedEventArgs> SourceChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,Windows.Media.PlayTo.SourceChangeRequestedEventArgs>, Windows.Media.PlayTo.SourceChangeRequestedEventArgs>(x => This.SourceChangeRequested += x, x => This.SourceChangeRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> StopRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,object>, object>(x => This.StopRequested += x, x => This.StopRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> TimeUpdateRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,object>, object>(x => This.TimeUpdateRequested += x, x => This.TimeUpdateRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.VolumeChangeRequestedEventArgs> VolumeChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToReceiver,Windows.Media.PlayTo.VolumeChangeRequestedEventArgs>, Windows.Media.PlayTo.VolumeChangeRequestedEventArgs>(x => This.VolumeChangeRequested += x, x => This.VolumeChangeRequested -= x).Select(x => x.EventArgs); }
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
    public class PlayToManagerEvents
    {
        PlayToManager This;

        public PlayToManagerEvents(PlayToManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.PlayTo.PlayToSourceRequestedEventArgs> SourceRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToManager,Windows.Media.PlayTo.PlayToSourceRequestedEventArgs>, Windows.Media.PlayTo.PlayToSourceRequestedEventArgs>(x => This.SourceRequested += x, x => This.SourceRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlayTo.PlayToSourceSelectedEventArgs> SourceSelected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.PlayTo.PlayToManager,Windows.Media.PlayTo.PlayToSourceSelectedEventArgs>, Windows.Media.PlayTo.PlayToSourceSelectedEventArgs>(x => This.SourceSelected += x, x => This.SourceSelected -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Protection.PlayReady
{
    public static class EventsMixin
    {
        public static NDClientEvents Events(this NDClient This)
        {
            return new NDClientEvents(This);
        }
    }

    public class NDClientEvents
    {
        NDClient This;

        public NDClientEvents(NDClient This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Protection.PlayReady.INDClosedCaptionDataReceivedEventArgs> ClosedCaptionDataReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Protection.PlayReady.NDClient,Windows.Media.Protection.PlayReady.INDClosedCaptionDataReceivedEventArgs>, Windows.Media.Protection.PlayReady.INDClosedCaptionDataReceivedEventArgs>(x => This.ClosedCaptionDataReceived += x, x => This.ClosedCaptionDataReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Protection.PlayReady.INDLicenseFetchCompletedEventArgs> LicenseFetchCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Protection.PlayReady.NDClient,Windows.Media.Protection.PlayReady.INDLicenseFetchCompletedEventArgs>, Windows.Media.Protection.PlayReady.INDLicenseFetchCompletedEventArgs>(x => This.LicenseFetchCompleted += x, x => This.LicenseFetchCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Protection.PlayReady.INDProximityDetectionCompletedEventArgs> ProximityDetectionCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Protection.PlayReady.NDClient,Windows.Media.Protection.PlayReady.INDProximityDetectionCompletedEventArgs>, Windows.Media.Protection.PlayReady.INDProximityDetectionCompletedEventArgs>(x => This.ProximityDetectionCompleted += x, x => This.ProximityDetectionCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ReRegistrationNeeded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Protection.PlayReady.NDClient,object>, object>(x => This.ReRegistrationNeeded += x, x => This.ReRegistrationNeeded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Protection.PlayReady.INDRegistrationCompletedEventArgs> RegistrationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Protection.PlayReady.NDClient,Windows.Media.Protection.PlayReady.INDRegistrationCompletedEventArgs>, Windows.Media.Protection.PlayReady.INDRegistrationCompletedEventArgs>(x => This.RegistrationCompleted += x, x => This.RegistrationCompleted -= x).Select(x => x.EventArgs); }
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
        public static SpeechContinuousRecognitionSessionEvents Events(this SpeechContinuousRecognitionSession This)
        {
            return new SpeechContinuousRecognitionSessionEvents(This);
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

        public IObservable<Windows.Media.SpeechRecognition.SpeechRecognitionHypothesisGeneratedEventArgs> HypothesisGenerated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SpeechRecognition.SpeechRecognizer,Windows.Media.SpeechRecognition.SpeechRecognitionHypothesisGeneratedEventArgs>, Windows.Media.SpeechRecognition.SpeechRecognitionHypothesisGeneratedEventArgs>(x => This.HypothesisGenerated += x, x => This.HypothesisGenerated -= x).Select(x => x.EventArgs); }
        }

    }
    public class SpeechContinuousRecognitionSessionEvents
    {
        SpeechContinuousRecognitionSession This;

        public SpeechContinuousRecognitionSessionEvents(SpeechContinuousRecognitionSession This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.SpeechRecognition.SpeechContinuousRecognitionCompletedEventArgs> Completed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession,Windows.Media.SpeechRecognition.SpeechContinuousRecognitionCompletedEventArgs>, Windows.Media.SpeechRecognition.SpeechContinuousRecognitionCompletedEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.SpeechRecognition.SpeechContinuousRecognitionResultGeneratedEventArgs> ResultGenerated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SpeechRecognition.SpeechContinuousRecognitionSession,Windows.Media.SpeechRecognition.SpeechContinuousRecognitionResultGeneratedEventArgs>, Windows.Media.SpeechRecognition.SpeechContinuousRecognitionResultGeneratedEventArgs>(x => This.ResultGenerated += x, x => This.ResultGenerated -= x).Select(x => x.EventArgs); }
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
        public static MediaTimelineControllerEvents Events(this MediaTimelineController This)
        {
            return new MediaTimelineControllerEvents(This);
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

        public IObservable<Windows.Media.AutoRepeatModeChangeRequestedEventArgs> AutoRepeatModeChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SystemMediaTransportControls,Windows.Media.AutoRepeatModeChangeRequestedEventArgs>, Windows.Media.AutoRepeatModeChangeRequestedEventArgs>(x => This.AutoRepeatModeChangeRequested += x, x => This.AutoRepeatModeChangeRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlaybackPositionChangeRequestedEventArgs> PlaybackPositionChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SystemMediaTransportControls,Windows.Media.PlaybackPositionChangeRequestedEventArgs>, Windows.Media.PlaybackPositionChangeRequestedEventArgs>(x => This.PlaybackPositionChangeRequested += x, x => This.PlaybackPositionChangeRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.PlaybackRateChangeRequestedEventArgs> PlaybackRateChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SystemMediaTransportControls,Windows.Media.PlaybackRateChangeRequestedEventArgs>, Windows.Media.PlaybackRateChangeRequestedEventArgs>(x => This.PlaybackRateChangeRequested += x, x => This.PlaybackRateChangeRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.ShuffleEnabledChangeRequestedEventArgs> ShuffleEnabledChangeRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.SystemMediaTransportControls,Windows.Media.ShuffleEnabledChangeRequestedEventArgs>, Windows.Media.ShuffleEnabledChangeRequestedEventArgs>(x => This.ShuffleEnabledChangeRequested += x, x => This.ShuffleEnabledChangeRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaTimelineControllerEvents
    {
        MediaTimelineController This;

        public MediaTimelineControllerEvents(MediaTimelineController This)
        {
            this.This = This;
        }

        public IObservable<object> PositionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.MediaTimelineController,object>, object>(x => This.PositionChanged += x, x => This.PositionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> StateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.MediaTimelineController,object>, object>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
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
namespace Windows.Media.Capture.Frames
{
    public static class EventsMixin
    {
        public static MediaFrameSourceEvents Events(this MediaFrameSource This)
        {
            return new MediaFrameSourceEvents(This);
        }
        public static MediaFrameReaderEvents Events(this MediaFrameReader This)
        {
            return new MediaFrameReaderEvents(This);
        }
    }

    public class MediaFrameSourceEvents
    {
        MediaFrameSource This;

        public MediaFrameSourceEvents(MediaFrameSource This)
        {
            this.This = This;
        }

        public IObservable<object> FormatChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.Frames.MediaFrameSource,object>, object>(x => This.FormatChanged += x, x => This.FormatChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaFrameReaderEvents
    {
        MediaFrameReader This;

        public MediaFrameReaderEvents(MediaFrameReader This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs> FrameArrived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Capture.Frames.MediaFrameReader,Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs>, Windows.Media.Capture.Frames.MediaFrameArrivedEventArgs>(x => This.FrameArrived += x, x => This.FrameArrived -= x).Select(x => x.EventArgs); }
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
        public static HdcpSessionEvents Events(this HdcpSession This)
        {
            return new HdcpSessionEvents(This);
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
    public class HdcpSessionEvents
    {
        HdcpSession This;

        public HdcpSessionEvents(HdcpSession This)
        {
            this.This = This;
        }

        public IObservable<object> ProtectionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Protection.HdcpSession,object>, object>(x => This.ProtectionChanged += x, x => This.ProtectionChanged -= x).Select(x => x.EventArgs); }
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
        public static MseStreamSourceEvents Events(this MseStreamSource This)
        {
            return new MseStreamSourceEvents(This);
        }
        public static MseSourceBufferListEvents Events(this MseSourceBufferList This)
        {
            return new MseSourceBufferListEvents(This);
        }
        public static MseSourceBufferEvents Events(this MseSourceBuffer This)
        {
            return new MseSourceBufferEvents(This);
        }
        public static SceneAnalysisEffectEvents Events(this SceneAnalysisEffect This)
        {
            return new SceneAnalysisEffectEvents(This);
        }
        public static FaceDetectionEffectEvents Events(this FaceDetectionEffect This)
        {
            return new FaceDetectionEffectEvents(This);
        }
        public static VideoStabilizationEffectEvents Events(this VideoStabilizationEffect This)
        {
            return new VideoStabilizationEffectEvents(This);
        }
        public static MediaSourceEvents Events(this MediaSource This)
        {
            return new MediaSourceEvents(This);
        }
        public static MediaBinderEvents Events(this MediaBinder This)
        {
            return new MediaBinderEvents(This);
        }
        public static MediaBindingEventArgsEvents Events(this MediaBindingEventArgs This)
        {
            return new MediaBindingEventArgsEvents(This);
        }
        public static TimedTextSourceEvents Events(this TimedTextSource This)
        {
            return new TimedTextSourceEvents(This);
        }
        public static TimedMetadataTrackEvents Events(this TimedMetadataTrack This)
        {
            return new TimedMetadataTrackEvents(This);
        }
        public static ISingleSelectMediaTrackListEvents Events(this ISingleSelectMediaTrackList This)
        {
            return new ISingleSelectMediaTrackListEvents(This);
        }
        public static VideoTrackEvents Events(this VideoTrack This)
        {
            return new VideoTrackEvents(This);
        }
        public static AudioTrackEvents Events(this AudioTrack This)
        {
            return new AudioTrackEvents(This);
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

        public IObservable<Windows.Media.Core.MediaStreamSourceSampleRenderedEventArgs> SampleRendered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaStreamSource,Windows.Media.Core.MediaStreamSourceSampleRenderedEventArgs>, Windows.Media.Core.MediaStreamSourceSampleRenderedEventArgs>(x => This.SampleRendered += x, x => This.SampleRendered -= x).Select(x => x.EventArgs); }
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
    public class MseStreamSourceEvents
    {
        MseStreamSource This;

        public MseStreamSourceEvents(MseStreamSource This)
        {
            this.This = This;
        }

        public IObservable<object> Closed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MseStreamSource,object>, object>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Ended {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MseStreamSource,object>, object>(x => This.Ended += x, x => This.Ended -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Opened {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MseStreamSource,object>, object>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

    }
    public class MseSourceBufferListEvents
    {
        MseSourceBufferList This;

        public MseSourceBufferListEvents(MseSourceBufferList This)
        {
            this.This = This;
        }

        public IObservable<object> SourceBufferAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MseSourceBufferList,object>, object>(x => This.SourceBufferAdded += x, x => This.SourceBufferAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> SourceBufferRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MseSourceBufferList,object>, object>(x => This.SourceBufferRemoved += x, x => This.SourceBufferRemoved -= x).Select(x => x.EventArgs); }
        }

    }
    public class MseSourceBufferEvents
    {
        MseSourceBuffer This;

        public MseSourceBufferEvents(MseSourceBuffer This)
        {
            this.This = This;
        }

        public IObservable<object> Aborted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MseSourceBuffer,object>, object>(x => This.Aborted += x, x => This.Aborted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> ErrorOccurred {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MseSourceBuffer,object>, object>(x => This.ErrorOccurred += x, x => This.ErrorOccurred -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> UpdateEnded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MseSourceBuffer,object>, object>(x => This.UpdateEnded += x, x => This.UpdateEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> UpdateStarting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MseSourceBuffer,object>, object>(x => This.UpdateStarting += x, x => This.UpdateStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Updated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MseSourceBuffer,object>, object>(x => This.Updated += x, x => This.Updated -= x).Select(x => x.EventArgs); }
        }

    }
    public class SceneAnalysisEffectEvents
    {
        SceneAnalysisEffect This;

        public SceneAnalysisEffectEvents(SceneAnalysisEffect This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Core.SceneAnalyzedEventArgs> SceneAnalyzed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.SceneAnalysisEffect,Windows.Media.Core.SceneAnalyzedEventArgs>, Windows.Media.Core.SceneAnalyzedEventArgs>(x => This.SceneAnalyzed += x, x => This.SceneAnalyzed -= x).Select(x => x.EventArgs); }
        }

    }
    public class FaceDetectionEffectEvents
    {
        FaceDetectionEffect This;

        public FaceDetectionEffectEvents(FaceDetectionEffect This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Core.FaceDetectedEventArgs> FaceDetected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.FaceDetectionEffect,Windows.Media.Core.FaceDetectedEventArgs>, Windows.Media.Core.FaceDetectedEventArgs>(x => This.FaceDetected += x, x => This.FaceDetected -= x).Select(x => x.EventArgs); }
        }

    }
    public class VideoStabilizationEffectEvents
    {
        VideoStabilizationEffect This;

        public VideoStabilizationEffectEvents(VideoStabilizationEffect This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Core.VideoStabilizationEffectEnabledChangedEventArgs> EnabledChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.VideoStabilizationEffect,Windows.Media.Core.VideoStabilizationEffectEnabledChangedEventArgs>, Windows.Media.Core.VideoStabilizationEffectEnabledChangedEventArgs>(x => This.EnabledChanged += x, x => This.EnabledChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaSourceEvents
    {
        MediaSource This;

        public MediaSourceEvents(MediaSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Core.MediaSourceOpenOperationCompletedEventArgs> OpenOperationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaSource,Windows.Media.Core.MediaSourceOpenOperationCompletedEventArgs>, Windows.Media.Core.MediaSourceOpenOperationCompletedEventArgs>(x => This.OpenOperationCompleted += x, x => This.OpenOperationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Core.MediaSourceStateChangedEventArgs> StateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaSource,Windows.Media.Core.MediaSourceStateChangedEventArgs>, Windows.Media.Core.MediaSourceStateChangedEventArgs>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaBinderEvents
    {
        MediaBinder This;

        public MediaBinderEvents(MediaBinder This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Core.MediaBindingEventArgs> Binding {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaBinder,Windows.Media.Core.MediaBindingEventArgs>, Windows.Media.Core.MediaBindingEventArgs>(x => This.Binding += x, x => This.Binding -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaBindingEventArgsEvents
    {
        MediaBindingEventArgs This;

        public MediaBindingEventArgsEvents(MediaBindingEventArgs This)
        {
            this.This = This;
        }

        public IObservable<object> Canceled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.MediaBindingEventArgs,object>, object>(x => This.Canceled += x, x => This.Canceled -= x).Select(x => x.EventArgs); }
        }

    }
    public class TimedTextSourceEvents
    {
        TimedTextSource This;

        public TimedTextSourceEvents(TimedTextSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Core.TimedTextSourceResolveResultEventArgs> Resolved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.TimedTextSource,Windows.Media.Core.TimedTextSourceResolveResultEventArgs>, Windows.Media.Core.TimedTextSourceResolveResultEventArgs>(x => This.Resolved += x, x => This.Resolved -= x).Select(x => x.EventArgs); }
        }

    }
    public class TimedMetadataTrackEvents
    {
        TimedMetadataTrack This;

        public TimedMetadataTrackEvents(TimedMetadataTrack This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Core.MediaCueEventArgs> CueEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.TimedMetadataTrack,Windows.Media.Core.MediaCueEventArgs>, Windows.Media.Core.MediaCueEventArgs>(x => This.CueEntered += x, x => This.CueEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Core.MediaCueEventArgs> CueExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.TimedMetadataTrack,Windows.Media.Core.MediaCueEventArgs>, Windows.Media.Core.MediaCueEventArgs>(x => This.CueExited += x, x => This.CueExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Core.TimedMetadataTrackFailedEventArgs> TrackFailed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.TimedMetadataTrack,Windows.Media.Core.TimedMetadataTrackFailedEventArgs>, Windows.Media.Core.TimedMetadataTrackFailedEventArgs>(x => This.TrackFailed += x, x => This.TrackFailed -= x).Select(x => x.EventArgs); }
        }

    }
    public class ISingleSelectMediaTrackListEvents
    {
        ISingleSelectMediaTrackList This;

        public ISingleSelectMediaTrackListEvents(ISingleSelectMediaTrackList This)
        {
            this.This = This;
        }

        public IObservable<object> SelectedIndexChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.ISingleSelectMediaTrackList,object>, object>(x => This.SelectedIndexChanged += x, x => This.SelectedIndexChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class VideoTrackEvents
    {
        VideoTrack This;

        public VideoTrackEvents(VideoTrack This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Core.VideoTrackOpenFailedEventArgs> OpenFailed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.VideoTrack,Windows.Media.Core.VideoTrackOpenFailedEventArgs>, Windows.Media.Core.VideoTrackOpenFailedEventArgs>(x => This.OpenFailed += x, x => This.OpenFailed -= x).Select(x => x.EventArgs); }
        }

    }
    public class AudioTrackEvents
    {
        AudioTrack This;

        public AudioTrackEvents(AudioTrack This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Core.AudioTrackOpenFailedEventArgs> OpenFailed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Core.AudioTrack,Windows.Media.Core.AudioTrackOpenFailedEventArgs>, Windows.Media.Core.AudioTrackOpenFailedEventArgs>(x => This.OpenFailed += x, x => This.OpenFailed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Streaming.Adaptive
{
    public static class EventsMixin
    {
        public static AdaptiveMediaSourceEvents Events(this AdaptiveMediaSource This)
        {
            return new AdaptiveMediaSourceEvents(This);
        }
    }

    public class AdaptiveMediaSourceEvents
    {
        AdaptiveMediaSource This;

        public AdaptiveMediaSourceEvents(AdaptiveMediaSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadBitrateChangedEventArgs> DownloadBitrateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Streaming.Adaptive.AdaptiveMediaSource,Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadBitrateChangedEventArgs>, Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadBitrateChangedEventArgs>(x => This.DownloadBitrateChanged += x, x => This.DownloadBitrateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadCompletedEventArgs> DownloadCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Streaming.Adaptive.AdaptiveMediaSource,Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadCompletedEventArgs>, Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadCompletedEventArgs>(x => This.DownloadCompleted += x, x => This.DownloadCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadFailedEventArgs> DownloadFailed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Streaming.Adaptive.AdaptiveMediaSource,Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadFailedEventArgs>, Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadFailedEventArgs>(x => This.DownloadFailed += x, x => This.DownloadFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadRequestedEventArgs> DownloadRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Streaming.Adaptive.AdaptiveMediaSource,Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadRequestedEventArgs>, Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadRequestedEventArgs>(x => This.DownloadRequested += x, x => This.DownloadRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Streaming.Adaptive.AdaptiveMediaSourcePlaybackBitrateChangedEventArgs> PlaybackBitrateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Media.Streaming.Adaptive.AdaptiveMediaSource,Windows.Media.Streaming.Adaptive.AdaptiveMediaSourcePlaybackBitrateChangedEventArgs>, Windows.Media.Streaming.Adaptive.AdaptiveMediaSourcePlaybackBitrateChangedEventArgs>(x => This.PlaybackBitrateChanged += x, x => This.PlaybackBitrateChanged -= x).Select(x => x.EventArgs); }
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
namespace Windows.Networking.ServiceDiscovery.Dnssd
{
    public static class EventsMixin
    {
        public static DnssdServiceWatcherEvents Events(this DnssdServiceWatcher This)
        {
            return new DnssdServiceWatcherEvents(This);
        }
    }

    public class DnssdServiceWatcherEvents
    {
        DnssdServiceWatcher This;

        public DnssdServiceWatcherEvents(DnssdServiceWatcher This)
        {
            this.This = This;
        }

        public IObservable<Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstance> Added {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceWatcher,Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstance>, Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceInstance>(x => This.Added += x, x => This.Added -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.ServiceDiscovery.Dnssd.DnssdServiceWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
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

        public IObservable<Windows.Networking.Sockets.WebSocketServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.MessageWebSocket,Windows.Networking.Sockets.WebSocketServerCustomValidationRequestedEventArgs>, Windows.Networking.Sockets.WebSocketServerCustomValidationRequestedEventArgs>(x => This.ServerCustomValidationRequested += x, x => This.ServerCustomValidationRequested -= x).Select(x => x.EventArgs); }
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

        public IObservable<Windows.Networking.Sockets.WebSocketServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Sockets.StreamWebSocket,Windows.Networking.Sockets.WebSocketServerCustomValidationRequestedEventArgs>, Windows.Networking.Sockets.WebSocketServerCustomValidationRequestedEventArgs>(x => This.ServerCustomValidationRequested += x, x => This.ServerCustomValidationRequested -= x).Select(x => x.EventArgs); }
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

        public IObservable<Windows.Networking.Vpn.VpnChannelActivityStateChangedArgs> ActivityStateChange {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Networking.Vpn.VpnChannel,Windows.Networking.Vpn.VpnChannelActivityStateChangedArgs>, Windows.Networking.Vpn.VpnChannelActivityStateChangedArgs>(x => This.ActivityStateChange += x, x => This.ActivityStateChange -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Perception.Spatial
{
    public static class EventsMixin
    {
        public static SpatialAnchorEvents Events(this SpatialAnchor This)
        {
            return new SpatialAnchorEvents(This);
        }
        public static SpatialLocatorEvents Events(this SpatialLocator This)
        {
            return new SpatialLocatorEvents(This);
        }
    }

    public class SpatialAnchorEvents
    {
        SpatialAnchor This;

        public SpatialAnchorEvents(SpatialAnchor This)
        {
            this.This = This;
        }

        public IObservable<Windows.Perception.Spatial.SpatialAnchorRawCoordinateSystemAdjustedEventArgs> RawCoordinateSystemAdjusted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Perception.Spatial.SpatialAnchor,Windows.Perception.Spatial.SpatialAnchorRawCoordinateSystemAdjustedEventArgs>, Windows.Perception.Spatial.SpatialAnchorRawCoordinateSystemAdjustedEventArgs>(x => This.RawCoordinateSystemAdjusted += x, x => This.RawCoordinateSystemAdjusted -= x).Select(x => x.EventArgs); }
        }

    }
    public class SpatialLocatorEvents
    {
        SpatialLocator This;

        public SpatialLocatorEvents(SpatialLocator This)
        {
            this.This = This;
        }

        public IObservable<object> LocatabilityChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Perception.Spatial.SpatialLocator,object>, object>(x => This.LocatabilityChanged += x, x => This.LocatabilityChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Perception.Spatial.SpatialLocatorPositionalTrackingDeactivatingEventArgs> PositionalTrackingDeactivating {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Perception.Spatial.SpatialLocator,Windows.Perception.Spatial.SpatialLocatorPositionalTrackingDeactivatingEventArgs>, Windows.Perception.Spatial.SpatialLocatorPositionalTrackingDeactivatingEventArgs>(x => This.PositionalTrackingDeactivating += x, x => This.PositionalTrackingDeactivating -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Graphics.Holographic
{
    public static class EventsMixin
    {
        public static HolographicSpaceEvents Events(this HolographicSpace This)
        {
            return new HolographicSpaceEvents(This);
        }
    }

    public class HolographicSpaceEvents
    {
        HolographicSpace This;

        public HolographicSpaceEvents(HolographicSpace This)
        {
            this.This = This;
        }

        public IObservable<Windows.Graphics.Holographic.HolographicSpaceCameraAddedEventArgs> CameraAdded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Holographic.HolographicSpace,Windows.Graphics.Holographic.HolographicSpaceCameraAddedEventArgs>, Windows.Graphics.Holographic.HolographicSpaceCameraAddedEventArgs>(x => This.CameraAdded += x, x => This.CameraAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Graphics.Holographic.HolographicSpaceCameraRemovedEventArgs> CameraRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Holographic.HolographicSpace,Windows.Graphics.Holographic.HolographicSpaceCameraRemovedEventArgs>, Windows.Graphics.Holographic.HolographicSpaceCameraRemovedEventArgs>(x => This.CameraRemoved += x, x => This.CameraRemoved -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Input.Spatial
{
    public static class EventsMixin
    {
        public static SpatialGestureRecognizerEvents Events(this SpatialGestureRecognizer This)
        {
            return new SpatialGestureRecognizerEvents(This);
        }
        public static SpatialInteractionManagerEvents Events(this SpatialInteractionManager This)
        {
            return new SpatialInteractionManagerEvents(This);
        }
    }

    public class SpatialGestureRecognizerEvents
    {
        SpatialGestureRecognizer This;

        public SpatialGestureRecognizerEvents(SpatialGestureRecognizer This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialHoldCanceledEventArgs> HoldCanceled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialHoldCanceledEventArgs>, Windows.UI.Input.Spatial.SpatialHoldCanceledEventArgs>(x => This.HoldCanceled += x, x => This.HoldCanceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialHoldCompletedEventArgs> HoldCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialHoldCompletedEventArgs>, Windows.UI.Input.Spatial.SpatialHoldCompletedEventArgs>(x => This.HoldCompleted += x, x => This.HoldCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialHoldStartedEventArgs> HoldStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialHoldStartedEventArgs>, Windows.UI.Input.Spatial.SpatialHoldStartedEventArgs>(x => This.HoldStarted += x, x => This.HoldStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialManipulationCanceledEventArgs> ManipulationCanceled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialManipulationCanceledEventArgs>, Windows.UI.Input.Spatial.SpatialManipulationCanceledEventArgs>(x => This.ManipulationCanceled += x, x => This.ManipulationCanceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialManipulationCompletedEventArgs> ManipulationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialManipulationCompletedEventArgs>, Windows.UI.Input.Spatial.SpatialManipulationCompletedEventArgs>(x => This.ManipulationCompleted += x, x => This.ManipulationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialManipulationStartedEventArgs> ManipulationStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialManipulationStartedEventArgs>, Windows.UI.Input.Spatial.SpatialManipulationStartedEventArgs>(x => This.ManipulationStarted += x, x => This.ManipulationStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialManipulationUpdatedEventArgs> ManipulationUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialManipulationUpdatedEventArgs>, Windows.UI.Input.Spatial.SpatialManipulationUpdatedEventArgs>(x => This.ManipulationUpdated += x, x => This.ManipulationUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialNavigationCanceledEventArgs> NavigationCanceled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialNavigationCanceledEventArgs>, Windows.UI.Input.Spatial.SpatialNavigationCanceledEventArgs>(x => This.NavigationCanceled += x, x => This.NavigationCanceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialNavigationCompletedEventArgs> NavigationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialNavigationCompletedEventArgs>, Windows.UI.Input.Spatial.SpatialNavigationCompletedEventArgs>(x => This.NavigationCompleted += x, x => This.NavigationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialNavigationStartedEventArgs> NavigationStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialNavigationStartedEventArgs>, Windows.UI.Input.Spatial.SpatialNavigationStartedEventArgs>(x => This.NavigationStarted += x, x => This.NavigationStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialNavigationUpdatedEventArgs> NavigationUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialNavigationUpdatedEventArgs>, Windows.UI.Input.Spatial.SpatialNavigationUpdatedEventArgs>(x => This.NavigationUpdated += x, x => This.NavigationUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialRecognitionEndedEventArgs> RecognitionEnded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialRecognitionEndedEventArgs>, Windows.UI.Input.Spatial.SpatialRecognitionEndedEventArgs>(x => This.RecognitionEnded += x, x => This.RecognitionEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialRecognitionStartedEventArgs> RecognitionStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialRecognitionStartedEventArgs>, Windows.UI.Input.Spatial.SpatialRecognitionStartedEventArgs>(x => This.RecognitionStarted += x, x => This.RecognitionStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialTappedEventArgs> Tapped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialGestureRecognizer,Windows.UI.Input.Spatial.SpatialTappedEventArgs>, Windows.UI.Input.Spatial.SpatialTappedEventArgs>(x => This.Tapped += x, x => This.Tapped -= x).Select(x => x.EventArgs); }
        }

    }
    public class SpatialInteractionManagerEvents
    {
        SpatialInteractionManager This;

        public SpatialInteractionManagerEvents(SpatialInteractionManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialInteractionDetectedEventArgs> InteractionDetected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialInteractionManager,Windows.UI.Input.Spatial.SpatialInteractionDetectedEventArgs>, Windows.UI.Input.Spatial.SpatialInteractionDetectedEventArgs>(x => This.InteractionDetected += x, x => This.InteractionDetected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs> SourceDetected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialInteractionManager,Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs>, Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs>(x => This.SourceDetected += x, x => This.SourceDetected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs> SourceLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialInteractionManager,Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs>, Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs>(x => This.SourceLost += x, x => This.SourceLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs> SourcePressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialInteractionManager,Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs>, Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs>(x => This.SourcePressed += x, x => This.SourcePressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs> SourceReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialInteractionManager,Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs>, Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs>(x => This.SourceReleased += x, x => This.SourceReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs> SourceUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Spatial.SpatialInteractionManager,Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs>, Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs>(x => This.SourceUpdated += x, x => This.SourceUpdated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Perception.Spatial.Surfaces
{
    public static class EventsMixin
    {
        public static SpatialSurfaceObserverEvents Events(this SpatialSurfaceObserver This)
        {
            return new SpatialSurfaceObserverEvents(This);
        }
    }

    public class SpatialSurfaceObserverEvents
    {
        SpatialSurfaceObserver This;

        public SpatialSurfaceObserverEvents(SpatialSurfaceObserver This)
        {
            this.This = This;
        }

        public IObservable<object> ObservedSurfacesChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Perception.Spatial.Surfaces.SpatialSurfaceObserver,object>, object>(x => This.ObservedSurfacesChanged += x, x => This.ObservedSurfacesChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Security.Authentication.Web.Core
{
    public static class EventsMixin
    {
        public static WebAccountMonitorEvents Events(this WebAccountMonitor This)
        {
            return new WebAccountMonitorEvents(This);
        }
    }

    public class WebAccountMonitorEvents
    {
        WebAccountMonitor This;

        public WebAccountMonitorEvents(WebAccountMonitor This)
        {
            this.This = This;
        }

        public IObservable<object> DefaultSignInAccountChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Security.Authentication.Web.Core.WebAccountMonitor,object>, object>(x => This.DefaultSignInAccountChanged += x, x => This.DefaultSignInAccountChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Security.Authentication.Web.Core.WebAccountEventArgs> Removed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Security.Authentication.Web.Core.WebAccountMonitor,Windows.Security.Authentication.Web.Core.WebAccountEventArgs>, Windows.Security.Authentication.Web.Core.WebAccountEventArgs>(x => This.Removed += x, x => This.Removed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Security.Authentication.Web.Core.WebAccountEventArgs> Updated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Security.Authentication.Web.Core.WebAccountMonitor,Windows.Security.Authentication.Web.Core.WebAccountEventArgs>, Windows.Security.Authentication.Web.Core.WebAccountEventArgs>(x => This.Updated += x, x => This.Updated -= x).Select(x => x.EventArgs); }
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
namespace Windows.System
{
    public static class EventsMixin
    {
        public static UserWatcherEvents Events(this UserWatcher This)
        {
            return new UserWatcherEvents(This);
        }
    }

    public class UserWatcherEvents
    {
        UserWatcher This;

        public UserWatcherEvents(UserWatcher This)
        {
            this.This = This;
        }

        public IObservable<Windows.System.UserChangedEventArgs> Added {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.System.UserWatcher,Windows.System.UserChangedEventArgs>, Windows.System.UserChangedEventArgs>(x => This.Added += x, x => This.Added -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.System.UserChangedEventArgs> AuthenticationStatusChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.System.UserWatcher,Windows.System.UserChangedEventArgs>, Windows.System.UserChangedEventArgs>(x => This.AuthenticationStatusChanged += x, x => This.AuthenticationStatusChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.System.UserAuthenticationStatusChangingEventArgs> AuthenticationStatusChanging {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.System.UserWatcher,Windows.System.UserAuthenticationStatusChangingEventArgs>, Windows.System.UserAuthenticationStatusChangingEventArgs>(x => This.AuthenticationStatusChanging += x, x => This.AuthenticationStatusChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> EnumerationCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.System.UserWatcher,object>, object>(x => This.EnumerationCompleted += x, x => This.EnumerationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.System.UserChangedEventArgs> Removed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.System.UserWatcher,Windows.System.UserChangedEventArgs>, Windows.System.UserChangedEventArgs>(x => This.Removed += x, x => This.Removed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Stopped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.System.UserWatcher,object>, object>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.System.UserChangedEventArgs> Updated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.System.UserWatcher,Windows.System.UserChangedEventArgs>, Windows.System.UserChangedEventArgs>(x => This.Updated += x, x => This.Updated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Composition
{
    public static class EventsMixin
    {
        public static CompositionGraphicsDeviceEvents Events(this CompositionGraphicsDevice This)
        {
            return new CompositionGraphicsDeviceEvents(This);
        }
        public static CompositionScopedBatchEvents Events(this CompositionScopedBatch This)
        {
            return new CompositionScopedBatchEvents(This);
        }
        public static CompositionCommitBatchEvents Events(this CompositionCommitBatch This)
        {
            return new CompositionCommitBatchEvents(This);
        }
    }

    public class CompositionGraphicsDeviceEvents
    {
        CompositionGraphicsDevice This;

        public CompositionGraphicsDeviceEvents(CompositionGraphicsDevice This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Composition.RenderingDeviceReplacedEventArgs> RenderingDeviceReplaced {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Composition.CompositionGraphicsDevice,Windows.UI.Composition.RenderingDeviceReplacedEventArgs>, Windows.UI.Composition.RenderingDeviceReplacedEventArgs>(x => This.RenderingDeviceReplaced += x, x => This.RenderingDeviceReplaced -= x).Select(x => x.EventArgs); }
        }

    }
    public class CompositionScopedBatchEvents
    {
        CompositionScopedBatch This;

        public CompositionScopedBatchEvents(CompositionScopedBatch This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Composition.CompositionBatchCompletedEventArgs> Completed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Composition.CompositionBatchCompletedEventArgs>, Windows.UI.Composition.CompositionBatchCompletedEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

    }
    public class CompositionCommitBatchEvents
    {
        CompositionCommitBatch This;

        public CompositionCommitBatchEvents(CompositionCommitBatch This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Composition.CompositionBatchCompletedEventArgs> Completed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<object,Windows.UI.Composition.CompositionBatchCompletedEventArgs>, Windows.UI.Composition.CompositionBatchCompletedEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
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
        public static CoreComponentInputSourceEvents Events(this CoreComponentInputSource This)
        {
            return new CoreComponentInputSourceEvents(This);
        }
        public static CoreIndependentInputSourceEvents Events(this CoreIndependentInputSource This)
        {
            return new CoreIndependentInputSourceEvents(This);
        }
        public static ICorePointerRedirectorEvents Events(this ICorePointerRedirector This)
        {
            return new ICorePointerRedirectorEvents(This);
        }
        public static SystemNavigationManagerEvents Events(this SystemNavigationManager This)
        {
            return new SystemNavigationManagerEvents(This);
        }
        public static CoreWindowDialogEvents Events(this CoreWindowDialog This)
        {
            return new CoreWindowDialogEvents(This);
        }
        public static CoreWindowFlyoutEvents Events(this CoreWindowFlyout This)
        {
            return new CoreWindowFlyoutEvents(This);
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

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerRoutedAway {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.ICorePointerRedirector,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerRoutedAway += x, x => This.PointerRoutedAway -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerRoutedReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.ICorePointerRedirector,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerRoutedReleased += x, x => This.PointerRoutedReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerRoutedTo {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.ICorePointerRedirector,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerRoutedTo += x, x => This.PointerRoutedTo -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.ClosestInteractiveBoundsRequestedEventArgs> ClosestInteractiveBoundsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.ClosestInteractiveBoundsRequestedEventArgs>, Windows.UI.Core.ClosestInteractiveBoundsRequestedEventArgs>(x => This.ClosestInteractiveBoundsRequested += x, x => This.ClosestInteractiveBoundsRequested -= x).Select(x => x.EventArgs); }
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

        public IObservable<Windows.UI.Core.ClosestInteractiveBoundsRequestedEventArgs> ClosestInteractiveBoundsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreComponentInputSource,Windows.UI.Core.ClosestInteractiveBoundsRequestedEventArgs>, Windows.UI.Core.ClosestInteractiveBoundsRequestedEventArgs>(x => This.ClosestInteractiveBoundsRequested += x, x => This.ClosestInteractiveBoundsRequested -= x).Select(x => x.EventArgs); }
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
    public class ICorePointerRedirectorEvents
    {
        ICorePointerRedirector This;

        public ICorePointerRedirectorEvents(ICorePointerRedirector This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerRoutedAway {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.ICorePointerRedirector,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerRoutedAway += x, x => This.PointerRoutedAway -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerRoutedReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.ICorePointerRedirector,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerRoutedReleased += x, x => This.PointerRoutedReleased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerRoutedTo {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.ICorePointerRedirector,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerRoutedTo += x, x => This.PointerRoutedTo -= x).Select(x => x.EventArgs); }
        }

    }
    public class SystemNavigationManagerEvents
    {
        SystemNavigationManager This;

        public SystemNavigationManagerEvents(SystemNavigationManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.BackRequestedEventArgs> BackRequested {
            get { return Observable.FromEventPattern<EventHandler<Windows.UI.Core.BackRequestedEventArgs>, Windows.UI.Core.BackRequestedEventArgs>(x => This.BackRequested += x, x => This.BackRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreWindowDialogEvents
    {
        CoreWindowDialog This;

        public CoreWindowDialogEvents(CoreWindowDialog This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.CoreWindowPopupShowingEventArgs> Showing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.CoreWindowPopupShowingEventArgs>, Windows.UI.Core.CoreWindowPopupShowingEventArgs>(x => This.Showing += x, x => This.Showing -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreWindowFlyoutEvents
    {
        CoreWindowFlyout This;

        public CoreWindowFlyoutEvents(CoreWindowFlyout This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.CoreWindowPopupShowingEventArgs> Showing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Core.CoreWindow,Windows.UI.Core.CoreWindowPopupShowingEventArgs>, Windows.UI.Core.CoreWindowPopupShowingEventArgs>(x => This.Showing += x, x => This.Showing -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Input.Inking
{
    public static class EventsMixin
    {
        public static InkUnprocessedInputEvents Events(this InkUnprocessedInput This)
        {
            return new InkUnprocessedInputEvents(This);
        }
        public static InkStrokeInputEvents Events(this InkStrokeInput This)
        {
            return new InkStrokeInputEvents(This);
        }
        public static InkPresenterEvents Events(this InkPresenter This)
        {
            return new InkPresenterEvents(This);
        }
    }

    public class InkUnprocessedInputEvents
    {
        InkUnprocessedInput This;

        public InkUnprocessedInputEvents(InkUnprocessedInput This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkUnprocessedInput,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerEntered += x, x => This.PointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkUnprocessedInput,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerExited += x, x => This.PointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerHovered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkUnprocessedInput,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerHovered += x, x => This.PointerHovered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkUnprocessedInput,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerLost += x, x => This.PointerLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerMoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkUnprocessedInput,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerMoved += x, x => This.PointerMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerPressed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkUnprocessedInput,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerPressed += x, x => This.PointerPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerReleased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkUnprocessedInput,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerReleased += x, x => This.PointerReleased -= x).Select(x => x.EventArgs); }
        }

    }
    public class InkStrokeInputEvents
    {
        InkStrokeInput This;

        public InkStrokeInputEvents(InkStrokeInput This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> StrokeCanceled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkStrokeInput,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.StrokeCanceled += x, x => This.StrokeCanceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> StrokeContinued {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkStrokeInput,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.StrokeContinued += x, x => This.StrokeContinued -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> StrokeEnded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkStrokeInput,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.StrokeEnded += x, x => This.StrokeEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> StrokeStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkStrokeInput,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.StrokeStarted += x, x => This.StrokeStarted -= x).Select(x => x.EventArgs); }
        }

    }
    public class InkPresenterEvents
    {
        InkPresenter This;

        public InkPresenterEvents(InkPresenter This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Input.Inking.InkStrokesCollectedEventArgs> StrokesCollected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkPresenter,Windows.UI.Input.Inking.InkStrokesCollectedEventArgs>, Windows.UI.Input.Inking.InkStrokesCollectedEventArgs>(x => This.StrokesCollected += x, x => This.StrokesCollected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Inking.InkStrokesErasedEventArgs> StrokesErased {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.InkPresenter,Windows.UI.Input.Inking.InkStrokesErasedEventArgs>, Windows.UI.Input.Inking.InkStrokesErasedEventArgs>(x => This.StrokesErased += x, x => This.StrokesErased -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Input.Inking.Core
{
    public static class EventsMixin
    {
        public static CoreInkIndependentInputSourceEvents Events(this CoreInkIndependentInputSource This)
        {
            return new CoreInkIndependentInputSourceEvents(This);
        }
        public static CoreWetStrokeUpdateSourceEvents Events(this CoreWetStrokeUpdateSource This)
        {
            return new CoreWetStrokeUpdateSourceEvents(This);
        }
    }

    public class CoreInkIndependentInputSourceEvents
    {
        CoreInkIndependentInputSource This;

        public CoreInkIndependentInputSourceEvents(CoreInkIndependentInputSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerEntering {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerEntering += x, x => This.PointerEntering -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerExiting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerExiting += x, x => This.PointerExiting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerHovering {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerHovering += x, x => This.PointerHovering -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerLost += x, x => This.PointerLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerMoving {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerMoving += x, x => This.PointerMoving -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerPressing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerPressing += x, x => This.PointerPressing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Core.PointerEventArgs> PointerReleasing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource,Windows.UI.Core.PointerEventArgs>, Windows.UI.Core.PointerEventArgs>(x => This.PointerReleasing += x, x => This.PointerReleasing -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreWetStrokeUpdateSourceEvents
    {
        CoreWetStrokeUpdateSource This;

        public CoreWetStrokeUpdateSourceEvents(CoreWetStrokeUpdateSource This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs> WetStrokeCanceled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource,Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>, Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>(x => This.WetStrokeCanceled += x, x => This.WetStrokeCanceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs> WetStrokeCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource,Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>, Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>(x => This.WetStrokeCompleted += x, x => This.WetStrokeCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs> WetStrokeContinuing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource,Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>, Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>(x => This.WetStrokeContinuing += x, x => This.WetStrokeContinuing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs> WetStrokeStarting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource,Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>, Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>(x => This.WetStrokeStarting += x, x => This.WetStrokeStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs> WetStrokeStopping {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource,Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>, Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>(x => This.WetStrokeStopping += x, x => This.WetStrokeStopping -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Text.Core
{
    public static class EventsMixin
    {
        public static CoreTextEditContextEvents Events(this CoreTextEditContext This)
        {
            return new CoreTextEditContextEvents(This);
        }
        public static CoreTextServicesManagerEvents Events(this CoreTextServicesManager This)
        {
            return new CoreTextServicesManagerEvents(This);
        }
    }

    public class CoreTextEditContextEvents
    {
        CoreTextEditContext This;

        public CoreTextEditContextEvents(CoreTextEditContext This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Text.Core.CoreTextCompositionCompletedEventArgs> CompositionCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Text.Core.CoreTextEditContext,Windows.UI.Text.Core.CoreTextCompositionCompletedEventArgs>, Windows.UI.Text.Core.CoreTextCompositionCompletedEventArgs>(x => This.CompositionCompleted += x, x => This.CompositionCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Text.Core.CoreTextCompositionStartedEventArgs> CompositionStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Text.Core.CoreTextEditContext,Windows.UI.Text.Core.CoreTextCompositionStartedEventArgs>, Windows.UI.Text.Core.CoreTextCompositionStartedEventArgs>(x => This.CompositionStarted += x, x => This.CompositionStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> FocusRemoved {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Text.Core.CoreTextEditContext,object>, object>(x => This.FocusRemoved += x, x => This.FocusRemoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Text.Core.CoreTextFormatUpdatingEventArgs> FormatUpdating {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Text.Core.CoreTextEditContext,Windows.UI.Text.Core.CoreTextFormatUpdatingEventArgs>, Windows.UI.Text.Core.CoreTextFormatUpdatingEventArgs>(x => This.FormatUpdating += x, x => This.FormatUpdating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Text.Core.CoreTextLayoutRequestedEventArgs> LayoutRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Text.Core.CoreTextEditContext,Windows.UI.Text.Core.CoreTextLayoutRequestedEventArgs>, Windows.UI.Text.Core.CoreTextLayoutRequestedEventArgs>(x => This.LayoutRequested += x, x => This.LayoutRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Text.Core.CoreTextSelectionRequestedEventArgs> SelectionRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Text.Core.CoreTextEditContext,Windows.UI.Text.Core.CoreTextSelectionRequestedEventArgs>, Windows.UI.Text.Core.CoreTextSelectionRequestedEventArgs>(x => This.SelectionRequested += x, x => This.SelectionRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Text.Core.CoreTextSelectionUpdatingEventArgs> SelectionUpdating {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Text.Core.CoreTextEditContext,Windows.UI.Text.Core.CoreTextSelectionUpdatingEventArgs>, Windows.UI.Text.Core.CoreTextSelectionUpdatingEventArgs>(x => This.SelectionUpdating += x, x => This.SelectionUpdating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Text.Core.CoreTextTextRequestedEventArgs> TextRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Text.Core.CoreTextEditContext,Windows.UI.Text.Core.CoreTextTextRequestedEventArgs>, Windows.UI.Text.Core.CoreTextTextRequestedEventArgs>(x => This.TextRequested += x, x => This.TextRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Text.Core.CoreTextTextUpdatingEventArgs> TextUpdating {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Text.Core.CoreTextEditContext,Windows.UI.Text.Core.CoreTextTextUpdatingEventArgs>, Windows.UI.Text.Core.CoreTextTextUpdatingEventArgs>(x => This.TextUpdating += x, x => This.TextUpdating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> NotifyFocusLeaveCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Text.Core.CoreTextEditContext,object>, object>(x => This.NotifyFocusLeaveCompleted += x, x => This.NotifyFocusLeaveCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class CoreTextServicesManagerEvents
    {
        CoreTextServicesManager This;

        public CoreTextServicesManagerEvents(CoreTextServicesManager This)
        {
            this.This = This;
        }

        public IObservable<object> InputLanguageChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Text.Core.CoreTextServicesManager,object>, object>(x => This.InputLanguageChanged += x, x => This.InputLanguageChanged -= x).Select(x => x.EventArgs); }
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
        public static RichTextBlockEvents Events(this RichTextBlock This)
        {
            return new RichTextBlockEvents(This);
        }
        public static TextBlockEvents Events(this TextBlock This)
        {
            return new TextBlockEvents(This);
        }
        public static StackPanelEvents Events(this StackPanel This)
        {
            return new StackPanelEvents(This);
        }
        public static VirtualizingStackPanelEvents Events(this VirtualizingStackPanel This)
        {
            return new VirtualizingStackPanelEvents(This);
        }
        public static MediaElementEvents Events(this MediaElement This)
        {
            return new MediaElementEvents(This);
        }
        public static WebViewEvents Events(this WebView This)
        {
            return new WebViewEvents(This);
        }
        public static SwapChainPanelEvents Events(this SwapChainPanel This)
        {
            return new SwapChainPanelEvents(This);
        }
        public static ControlEvents Events(this Control This)
        {
            return new ControlEvents(This);
        }
        public static SemanticZoomEvents Events(this SemanticZoom This)
        {
            return new SemanticZoomEvents(This);
        }
        public static MediaTransportControlsEvents Events(this MediaTransportControls This)
        {
            return new MediaTransportControlsEvents(This);
        }
        public static PasswordBoxEvents Events(this PasswordBox This)
        {
            return new PasswordBoxEvents(This);
        }
        public static RichEditBoxEvents Events(this RichEditBox This)
        {
            return new RichEditBoxEvents(This);
        }
        public static TextBoxEvents Events(this TextBox This)
        {
            return new TextBoxEvents(This);
        }
        public static ToggleSwitchEvents Events(this ToggleSwitch This)
        {
            return new ToggleSwitchEvents(This);
        }
        public static SettingsFlyoutEvents Events(this SettingsFlyout This)
        {
            return new SettingsFlyoutEvents(This);
        }
        public static ToolTipEvents Events(this ToolTip This)
        {
            return new ToolTipEvents(This);
        }
        public static ListViewBaseEvents Events(this ListViewBase This)
        {
            return new ListViewBaseEvents(This);
        }
        public static ComboBoxEvents Events(this ComboBox This)
        {
            return new ComboBoxEvents(This);
        }
        public static CalendarViewEvents Events(this CalendarView This)
        {
            return new CalendarViewEvents(This);
        }
        public static CalendarDatePickerEvents Events(this CalendarDatePicker This)
        {
            return new CalendarDatePickerEvents(This);
        }
        public static DatePickerEvents Events(this DatePicker This)
        {
            return new DatePickerEvents(This);
        }
        public static HubEvents Events(this Hub This)
        {
            return new HubEvents(This);
        }
        public static SearchBoxEvents Events(this SearchBox This)
        {
            return new SearchBoxEvents(This);
        }
        public static SplitViewEvents Events(this SplitView This)
        {
            return new SplitViewEvents(This);
        }
        public static TimePickerEvents Events(this TimePicker This)
        {
            return new TimePickerEvents(This);
        }
        public static AppBarEvents Events(this AppBar This)
        {
            return new AppBarEvents(This);
        }
        public static AutoSuggestBoxEvents Events(this AutoSuggestBox This)
        {
            return new AutoSuggestBoxEvents(This);
        }
        public static ContentDialogEvents Events(this ContentDialog This)
        {
            return new ContentDialogEvents(This);
        }
        public static FrameEvents Events(this Frame This)
        {
            return new FrameEvents(This);
        }
        public static MenuFlyoutItemEvents Events(this MenuFlyoutItem This)
        {
            return new MenuFlyoutItemEvents(This);
        }
        public static ScrollViewerEvents Events(this ScrollViewer This)
        {
            return new ScrollViewerEvents(This);
        }
        public static CommandBarEvents Events(this CommandBar This)
        {
            return new CommandBarEvents(This);
        }
        public static InkToolbarEvents Events(this InkToolbar This)
        {
            return new InkToolbarEvents(This);
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

        public IObservable<Windows.UI.Xaml.Media.PartialMediaFailureDetectedEventArgs> PartialMediaFailureDetected {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.MediaElement,Windows.UI.Xaml.Media.PartialMediaFailureDetectedEventArgs>, Windows.UI.Xaml.Media.PartialMediaFailureDetectedEventArgs>(x => This.PartialMediaFailureDetected += x, x => This.PartialMediaFailureDetected -= x).Select(x => x.EventArgs); }
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

        public IObservable<Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs> NewWindowRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs>, Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs>(x => This.NewWindowRequested += x, x => This.NewWindowRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewPermissionRequestedEventArgs> PermissionRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewPermissionRequestedEventArgs>, Windows.UI.Xaml.Controls.WebViewPermissionRequestedEventArgs>(x => This.PermissionRequested += x, x => This.PermissionRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.WebViewUnsupportedUriSchemeIdentifiedEventArgs> UnsupportedUriSchemeIdentified {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.WebView,Windows.UI.Xaml.Controls.WebViewUnsupportedUriSchemeIdentifiedEventArgs>, Windows.UI.Xaml.Controls.WebViewUnsupportedUriSchemeIdentifiedEventArgs>(x => This.UnsupportedUriSchemeIdentified += x, x => This.UnsupportedUriSchemeIdentified -= x).Select(x => x.EventArgs); }
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

        public IObservable<Windows.UI.Xaml.Controls.FocusDisengagedEventArgs> FocusDisengaged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Control,Windows.UI.Xaml.Controls.FocusDisengagedEventArgs>, Windows.UI.Xaml.Controls.FocusDisengagedEventArgs>(x => This.FocusDisengaged += x, x => This.FocusDisengaged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.FocusEngagedEventArgs> FocusEngaged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Control,Windows.UI.Xaml.Controls.FocusEngagedEventArgs>, Windows.UI.Xaml.Controls.FocusEngagedEventArgs>(x => This.FocusEngaged += x, x => This.FocusEngaged -= x).Select(x => x.EventArgs); }
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
    public class MediaTransportControlsEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        MediaTransportControls This;

        public MediaTransportControlsEvents(MediaTransportControls This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Media.MediaTransportControlsThumbnailRequestedEventArgs> ThumbnailRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.MediaTransportControls,Windows.UI.Xaml.Media.MediaTransportControlsThumbnailRequestedEventArgs>, Windows.UI.Xaml.Media.MediaTransportControlsThumbnailRequestedEventArgs>(x => This.ThumbnailRequested += x, x => This.ThumbnailRequested -= x).Select(x => x.EventArgs); }
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

        public IObservable<Windows.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs> CandidateWindowBoundsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.RichEditBox,Windows.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs>, Windows.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs>(x => This.CandidateWindowBoundsChanged += x, x => This.CandidateWindowBoundsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.RichEditBoxTextChangingEventArgs> TextChanging {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.RichEditBox,Windows.UI.Xaml.Controls.RichEditBoxTextChangingEventArgs>, Windows.UI.Xaml.Controls.RichEditBoxTextChangingEventArgs>(x => This.TextChanging += x, x => This.TextChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs> TextCompositionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.RichEditBox,Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs>, Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs>(x => This.TextCompositionChanged += x, x => This.TextCompositionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs> TextCompositionEnded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.RichEditBox,Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs>, Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs>(x => This.TextCompositionEnded += x, x => This.TextCompositionEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs> TextCompositionStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.RichEditBox,Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs>, Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs>(x => This.TextCompositionStarted += x, x => This.TextCompositionStarted -= x).Select(x => x.EventArgs); }
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

        public IObservable<Windows.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs> CandidateWindowBoundsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.TextBox,Windows.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs>, Windows.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs>(x => This.CandidateWindowBoundsChanged += x, x => This.CandidateWindowBoundsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextBoxTextChangingEventArgs> TextChanging {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.TextBox,Windows.UI.Xaml.Controls.TextBoxTextChangingEventArgs>, Windows.UI.Xaml.Controls.TextBoxTextChangingEventArgs>(x => This.TextChanging += x, x => This.TextChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs> TextCompositionChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.TextBox,Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs>, Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs>(x => This.TextCompositionChanged += x, x => This.TextCompositionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs> TextCompositionEnded {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.TextBox,Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs>, Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs>(x => This.TextCompositionEnded += x, x => This.TextCompositionEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs> TextCompositionStarted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.TextBox,Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs>, Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs>(x => This.TextCompositionStarted += x, x => This.TextCompositionStarted -= x).Select(x => x.EventArgs); }
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

        public IObservable<Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs> ChoosingGroupHeaderContainer {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.ListViewBase,Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs>, Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs>(x => This.ChoosingGroupHeaderContainer += x, x => This.ChoosingGroupHeaderContainer -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs> ChoosingItemContainer {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.ListViewBase,Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs>, Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs>(x => This.ChoosingItemContainer += x, x => This.ChoosingItemContainer -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.DragItemsCompletedEventArgs> DragItemsCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.ListViewBase,Windows.UI.Xaml.Controls.DragItemsCompletedEventArgs>, Windows.UI.Xaml.Controls.DragItemsCompletedEventArgs>(x => This.DragItemsCompleted += x, x => This.DragItemsCompleted -= x).Select(x => x.EventArgs); }
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
    public class CalendarViewEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        CalendarView This;

        public CalendarViewEvents(CalendarView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs> CalendarViewDayItemChanging {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.CalendarView,Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs>, Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs>(x => This.CalendarViewDayItemChanging += x, x => This.CalendarViewDayItemChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.CalendarViewSelectedDatesChangedEventArgs> SelectedDatesChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.CalendarView,Windows.UI.Xaml.Controls.CalendarViewSelectedDatesChangedEventArgs>, Windows.UI.Xaml.Controls.CalendarViewSelectedDatesChangedEventArgs>(x => This.SelectedDatesChanged += x, x => This.SelectedDatesChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CalendarDatePickerEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        CalendarDatePicker This;

        public CalendarDatePickerEvents(CalendarDatePicker This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs> CalendarViewDayItemChanging {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventHandler, Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs>(x => This.CalendarViewDayItemChanging += x, x => This.CalendarViewDayItemChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Closed {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.CalendarDatePickerDateChangedEventArgs> DateChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.CalendarDatePicker,Windows.UI.Xaml.Controls.CalendarDatePickerDateChangedEventArgs>, Windows.UI.Xaml.Controls.CalendarDatePickerDateChangedEventArgs>(x => This.DateChanged += x, x => This.DateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Opened {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
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
    public class SearchBoxEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        SearchBox This;

        public SearchBoxEvents(SearchBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> PrepareForFocusOnKeyboardInput {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SearchBox,Windows.UI.Xaml.RoutedEventArgs>, Windows.UI.Xaml.RoutedEventArgs>(x => This.PrepareForFocusOnKeyboardInput += x, x => This.PrepareForFocusOnKeyboardInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs> QueryChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SearchBox,Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs>, Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs>(x => This.QueryChanged += x, x => This.QueryChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs> QuerySubmitted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SearchBox,Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs>, Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs>(x => This.QuerySubmitted += x, x => This.QuerySubmitted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs> ResultSuggestionChosen {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SearchBox,Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs>, Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs>(x => This.ResultSuggestionChosen += x, x => This.ResultSuggestionChosen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs> SuggestionsRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SearchBox,Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs>, Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs>(x => This.SuggestionsRequested += x, x => This.SuggestionsRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class SplitViewEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        SplitView This;

        public SplitViewEvents(SplitView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> PaneClosed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SplitView,object>, object>(x => This.PaneClosed += x, x => This.PaneClosed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.SplitViewPaneClosingEventArgs> PaneClosing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.SplitView,Windows.UI.Xaml.Controls.SplitViewPaneClosingEventArgs>, Windows.UI.Xaml.Controls.SplitViewPaneClosingEventArgs>(x => This.PaneClosing += x, x => This.PaneClosing -= x).Select(x => x.EventArgs); }
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

        public IObservable<object> Closing {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Closing += x, x => This.Closing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Opening {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.Opening += x, x => This.Opening -= x).Select(x => x.EventArgs); }
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

        public IObservable<Windows.UI.Xaml.Controls.AutoSuggestBoxQuerySubmittedEventArgs> QuerySubmitted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.AutoSuggestBox,Windows.UI.Xaml.Controls.AutoSuggestBoxQuerySubmittedEventArgs>, Windows.UI.Xaml.Controls.AutoSuggestBoxQuerySubmittedEventArgs>(x => This.QuerySubmitted += x, x => This.QuerySubmitted -= x).Select(x => x.EventArgs); }
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

        public IObservable<object> DirectManipulationCompleted {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.DirectManipulationCompleted += x, x => This.DirectManipulationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> DirectManipulationStarted {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.DirectManipulationStarted += x, x => This.DirectManipulationStarted -= x).Select(x => x.EventArgs); }
        }

    }
    public class CommandBarEvents
        : Windows.UI.Xaml.Controls.AppBarEvents
    {
        CommandBar This;

        public CommandBarEvents(CommandBar This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.DynamicOverflowItemsChangingEventArgs> DynamicOverflowItemsChanging {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.CommandBar,Windows.UI.Xaml.Controls.DynamicOverflowItemsChangingEventArgs>, Windows.UI.Xaml.Controls.DynamicOverflowItemsChangingEventArgs>(x => This.DynamicOverflowItemsChanging += x, x => This.DynamicOverflowItemsChanging -= x).Select(x => x.EventArgs); }
        }

    }
    public class InkToolbarEvents
        : Windows.UI.Xaml.Controls.ControlEvents
    {
        InkToolbar This;

        public InkToolbarEvents(InkToolbar This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<object> ActiveToolChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.InkToolbar,object>, object>(x => This.ActiveToolChanged += x, x => This.ActiveToolChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> EraseAllClicked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.InkToolbar,object>, object>(x => This.EraseAllClicked += x, x => This.EraseAllClicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> InkDrawingAttributesChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.InkToolbar,object>, object>(x => This.InkDrawingAttributesChanged += x, x => This.InkDrawingAttributesChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> IsRulerButtonCheckedChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.InkToolbar,object>, object>(x => This.IsRulerButtonCheckedChanged += x, x => This.IsRulerButtonCheckedChanged -= x).Select(x => x.EventArgs); }
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
        public static PopupEvents Events(this Popup This)
        {
            return new PopupEvents(This);
        }
        public static CarouselPanelEvents Events(this CarouselPanel This)
        {
            return new CarouselPanelEvents(This);
        }
        public static OrientedVirtualizingPanelEvents Events(this OrientedVirtualizingPanel This)
        {
            return new OrientedVirtualizingPanelEvents(This);
        }
        public static RangeBaseEvents Events(this RangeBase This)
        {
            return new RangeBaseEvents(This);
        }
        public static ThumbEvents Events(this Thumb This)
        {
            return new ThumbEvents(This);
        }
        public static ButtonBaseEvents Events(this ButtonBase This)
        {
            return new ButtonBaseEvents(This);
        }
        public static ScrollBarEvents Events(this ScrollBar This)
        {
            return new ScrollBarEvents(This);
        }
        public static SelectorEvents Events(this Selector This)
        {
            return new SelectorEvents(This);
        }
        public static ToggleButtonEvents Events(this ToggleButton This)
        {
            return new ToggleButtonEvents(This);
        }
        public static FlyoutBaseEvents Events(this FlyoutBase This)
        {
            return new FlyoutBaseEvents(This);
        }
        public static LoopingSelectorEvents Events(this LoopingSelector This)
        {
            return new LoopingSelectorEvents(This);
        }
        public static PivotPanelEvents Events(this PivotPanel This)
        {
            return new PivotPanelEvents(This);
        }
        public static LoopingSelectorPanelEvents Events(this LoopingSelectorPanel This)
        {
            return new LoopingSelectorPanelEvents(This);
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

        public IObservable<Windows.UI.Xaml.Controls.Primitives.FlyoutBaseClosingEventArgs> Closing {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Primitives.FlyoutBase,Windows.UI.Xaml.Controls.Primitives.FlyoutBaseClosingEventArgs>, Windows.UI.Xaml.Controls.Primitives.FlyoutBaseClosingEventArgs>(x => This.Closing += x, x => This.Closing -= x).Select(x => x.EventArgs); }
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
}
namespace Windows.UI.Xaml
{
    public static class EventsMixin
    {
        public static DispatcherTimerEvents Events(this DispatcherTimer This)
        {
            return new DispatcherTimerEvents(This);
        }
        public static WindowEvents Events(this Window This)
        {
            return new WindowEvents(This);
        }
        public static DependencyObjectCollectionEvents Events(this DependencyObjectCollection This)
        {
            return new DependencyObjectCollectionEvents(This);
        }
        public static UIElementEvents Events(this UIElement This)
        {
            return new UIElementEvents(This);
        }
        public static VisualStateGroupEvents Events(this VisualStateGroup This)
        {
            return new VisualStateGroupEvents(This);
        }
        public static FrameworkElementEvents Events(this FrameworkElement This)
        {
            return new FrameworkElementEvents(This);
        }
        public static DebugSettingsEvents Events(this DebugSettings This)
        {
            return new DebugSettingsEvents(This);
        }
        public static ApplicationEvents Events(this Application This)
        {
            return new ApplicationEvents(This);
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

        public IObservable<Windows.UI.Xaml.DragStartingEventArgs> DragStarting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.UIElement,Windows.UI.Xaml.DragStartingEventArgs>, Windows.UI.Xaml.DragStartingEventArgs>(x => This.DragStarting += x, x => This.DragStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.DropCompletedEventArgs> DropCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.UIElement,Windows.UI.Xaml.DropCompletedEventArgs>, Windows.UI.Xaml.DropCompletedEventArgs>(x => This.DropCompleted += x, x => This.DropCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.AccessKeyDisplayDismissedEventArgs> AccessKeyDisplayDismissed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.UIElement,Windows.UI.Xaml.Input.AccessKeyDisplayDismissedEventArgs>, Windows.UI.Xaml.Input.AccessKeyDisplayDismissedEventArgs>(x => This.AccessKeyDisplayDismissed += x, x => This.AccessKeyDisplayDismissed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs> AccessKeyDisplayRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.UIElement,Windows.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs>, Windows.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs>(x => This.AccessKeyDisplayRequested += x, x => This.AccessKeyDisplayRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs> AccessKeyInvoked {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.UIElement,Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs>, Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs>(x => This.AccessKeyInvoked += x, x => This.AccessKeyInvoked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.RoutedEventArgs> ContextCanceled {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.UIElement,Windows.UI.Xaml.RoutedEventArgs>, Windows.UI.Xaml.RoutedEventArgs>(x => This.ContextCanceled += x, x => This.ContextCanceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Input.ContextRequestedEventArgs> ContextRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.UIElement,Windows.UI.Xaml.Input.ContextRequestedEventArgs>, Windows.UI.Xaml.Input.ContextRequestedEventArgs>(x => This.ContextRequested += x, x => This.ContextRequested -= x).Select(x => x.EventArgs); }
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

        public IObservable<object> Loading {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.FrameworkElement,object>, object>(x => This.Loading += x, x => This.Loading -= x).Select(x => x.EventArgs); }
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

        public IObservable<Windows.ApplicationModel.EnteredBackgroundEventArgs> EnteredBackground {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.EnteredBackgroundEventHandler, Windows.ApplicationModel.EnteredBackgroundEventArgs>(x => This.EnteredBackground += x, x => This.EnteredBackground -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.ApplicationModel.LeavingBackgroundEventArgs> LeavingBackground {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.LeavingBackgroundEventHandler, Windows.ApplicationModel.LeavingBackgroundEventArgs>(x => This.LeavingBackground += x, x => This.LeavingBackground -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.UI.Xaml.Printing
{
    public static class EventsMixin
    {
        public static PrintDocumentEvents Events(this PrintDocument This)
        {
            return new PrintDocumentEvents(This);
        }
    }

    public class PrintDocumentEvents
    {
        PrintDocument This;

        public PrintDocumentEvents(PrintDocument This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Printing.AddPagesEventArgs> AddPages {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Printing.AddPagesEventHandler, Windows.UI.Xaml.Printing.AddPagesEventArgs>(x => This.AddPages += x, x => This.AddPages -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Printing.GetPreviewPageEventArgs> GetPreviewPage {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Printing.GetPreviewPageEventHandler, Windows.UI.Xaml.Printing.GetPreviewPageEventArgs>(x => This.GetPreviewPage += x, x => This.GetPreviewPage -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Printing.PaginateEventArgs> Paginate {
            get { return Observable.FromEventPattern<Windows.UI.Xaml.Printing.PaginateEventHandler, Windows.UI.Xaml.Printing.PaginateEventArgs>(x => This.Paginate += x, x => This.Paginate -= x).Select(x => x.EventArgs); }
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
namespace Windows.UI.Xaml.Media.Animation
{
    public static class EventsMixin
    {
        public static TimelineEvents Events(this Timeline This)
        {
            return new TimelineEvents(This);
        }
        public static ConnectedAnimationEvents Events(this ConnectedAnimation This)
        {
            return new ConnectedAnimationEvents(This);
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
    public class ConnectedAnimationEvents
    {
        ConnectedAnimation This;

        public ConnectedAnimationEvents(ConnectedAnimation This)
        {
            this.This = This;
        }

        public IObservable<object> Completed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Media.Animation.ConnectedAnimation,object>, object>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
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
namespace Windows.UI.Xaml.Controls.Maps
{
    public static class EventsMixin
    {
        public static MapSceneEvents Events(this MapScene This)
        {
            return new MapSceneEvents(This);
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
        public static MapControlEvents Events(this MapControl This)
        {
            return new MapControlEvents(This);
        }
        public static MapControlDataHelperEvents Events(this MapControlDataHelper This)
        {
            return new MapControlDataHelperEvents(This);
        }
    }

    public class MapSceneEvents
    {
        MapScene This;

        public MapSceneEvents(MapScene This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapTargetCameraChangedEventArgs> TargetCameraChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapScene,Windows.UI.Xaml.Controls.Maps.MapTargetCameraChangedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapTargetCameraChangedEventArgs>(x => This.TargetCameraChanged += x, x => This.TargetCameraChanged -= x).Select(x => x.EventArgs); }
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

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapActualCameraChangedEventArgs> ActualCameraChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapActualCameraChangedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapActualCameraChangedEventArgs>(x => This.ActualCameraChanged += x, x => This.ActualCameraChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs> ActualCameraChanging {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs>, Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs>(x => This.ActualCameraChanging += x, x => This.ActualCameraChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapCustomExperienceChangedEventArgs> CustomExperienceChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapCustomExperienceChangedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapCustomExperienceChangedEventArgs>(x => This.CustomExperienceChanged += x, x => This.CustomExperienceChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs> MapElementClick {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs>, Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs>(x => This.MapElementClick += x, x => This.MapElementClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapElementPointerEnteredEventArgs> MapElementPointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapElementPointerEnteredEventArgs>, Windows.UI.Xaml.Controls.Maps.MapElementPointerEnteredEventArgs>(x => This.MapElementPointerEntered += x, x => This.MapElementPointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapElementPointerExitedEventArgs> MapElementPointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapElementPointerExitedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapElementPointerExitedEventArgs>(x => This.MapElementPointerExited += x, x => This.MapElementPointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapTargetCameraChangedEventArgs> TargetCameraChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapTargetCameraChangedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapTargetCameraChangedEventArgs>(x => This.TargetCameraChanged += x, x => This.TargetCameraChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapRightTappedEventArgs> MapRightTapped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapRightTappedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapRightTappedEventArgs>(x => This.MapRightTapped += x, x => This.MapRightTapped -= x).Select(x => x.EventArgs); }
        }

    }
    public class MapControlDataHelperEvents
    {
        MapControlDataHelper This;

        public MapControlDataHelperEvents(MapControlDataHelper This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkClickEventArgs> BusinessLandmarkClick {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkClickEventArgs>, Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkClickEventArgs>(x => This.BusinessLandmarkClick += x, x => This.BusinessLandmarkClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkRightTappedEventArgs> BusinessLandmarkRightTapped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkRightTappedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkRightTappedEventArgs>(x => This.BusinessLandmarkRightTapped += x, x => This.BusinessLandmarkRightTapped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapControlTransitFeatureClickEventArgs> TransitFeatureClick {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapControlTransitFeatureClickEventArgs>, Windows.UI.Xaml.Controls.Maps.MapControlTransitFeatureClickEventArgs>(x => This.TransitFeatureClick += x, x => This.TransitFeatureClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapControlTransitFeatureRightTappedEventArgs> TransitFeatureRightTapped {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapControlTransitFeatureRightTappedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapControlTransitFeatureRightTappedEventArgs>(x => This.TransitFeatureRightTapped += x, x => This.TransitFeatureRightTapped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkPointerEnteredEventArgs> BusinessLandmarkPointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkPointerEnteredEventArgs>, Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkPointerEnteredEventArgs>(x => This.BusinessLandmarkPointerEntered += x, x => This.BusinessLandmarkPointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkPointerExitedEventArgs> BusinessLandmarkPointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkPointerExitedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapControlBusinessLandmarkPointerExitedEventArgs>(x => This.BusinessLandmarkPointerExited += x, x => This.BusinessLandmarkPointerExited -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapControlTransitFeaturePointerEnteredEventArgs> TransitFeaturePointerEntered {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapControlTransitFeaturePointerEnteredEventArgs>, Windows.UI.Xaml.Controls.Maps.MapControlTransitFeaturePointerEnteredEventArgs>(x => This.TransitFeaturePointerEntered += x, x => This.TransitFeaturePointerEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.UI.Xaml.Controls.Maps.MapControlTransitFeaturePointerExitedEventArgs> TransitFeaturePointerExited {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Xaml.Controls.Maps.MapControl,Windows.UI.Xaml.Controls.Maps.MapControlTransitFeaturePointerExitedEventArgs>, Windows.UI.Xaml.Controls.Maps.MapControlTransitFeaturePointerExitedEventArgs>(x => This.TransitFeaturePointerExited += x, x => This.TransitFeaturePointerExited -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Web.Http.Filters
{
    public static class EventsMixin
    {
        public static HttpBaseProtocolFilterEvents Events(this HttpBaseProtocolFilter This)
        {
            return new HttpBaseProtocolFilterEvents(This);
        }
    }

    public class HttpBaseProtocolFilterEvents
    {
        HttpBaseProtocolFilter This;

        public HttpBaseProtocolFilterEvents(HttpBaseProtocolFilter This)
        {
            this.This = This;
        }

        public IObservable<Windows.Web.Http.Filters.HttpServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Web.Http.Filters.HttpBaseProtocolFilter,Windows.Web.Http.Filters.HttpServerCustomValidationRequestedEventArgs>, Windows.Web.Http.Filters.HttpServerCustomValidationRequestedEventArgs>(x => This.ServerCustomValidationRequested += x, x => This.ServerCustomValidationRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.ApplicationModel.Wallet.System
{
    public static class EventsMixin
    {
        public static WalletItemSystemStoreEvents Events(this WalletItemSystemStore This)
        {
            return new WalletItemSystemStoreEvents(This);
        }
    }

    public class WalletItemSystemStoreEvents
    {
        WalletItemSystemStore This;

        public WalletItemSystemStoreEvents(WalletItemSystemStore This)
        {
            this.This = This;
        }

        public IObservable<object> ItemsChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.ApplicationModel.Wallet.System.WalletItemSystemStore,object>, object>(x => This.ItemsChanged += x, x => This.ItemsChanged -= x).Select(x => x.EventArgs); }
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
namespace Windows.Media.ContentRestrictions
{
    public static class EventsMixin
    {
        public static RatedContentRestrictionsEvents Events(this RatedContentRestrictions This)
        {
            return new RatedContentRestrictionsEvents(This);
        }
    }

    public class RatedContentRestrictionsEvents
    {
        RatedContentRestrictions This;

        public RatedContentRestrictionsEvents(RatedContentRestrictions This)
        {
            this.This = This;
        }

        public IObservable<object> RestrictionsChanged {
            get { return Observable.FromEventPattern<EventHandler<object>, object>(x => This.RestrictionsChanged += x, x => This.RestrictionsChanged -= x).Select(x => x.EventArgs); }
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
namespace Windows.UI.Notifications.Management
{
    public static class EventsMixin
    {
        public static UserNotificationListenerEvents Events(this UserNotificationListener This)
        {
            return new UserNotificationListenerEvents(This);
        }
    }

    public class UserNotificationListenerEvents
    {
        UserNotificationListener This;

        public UserNotificationListenerEvents(UserNotificationListener This)
        {
            this.This = This;
        }

        public IObservable<Windows.UI.Notifications.UserNotificationChangedEventArgs> NotificationChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.UI.Notifications.Management.UserNotificationListener,Windows.UI.Notifications.UserNotificationChangedEventArgs>, Windows.UI.Notifications.UserNotificationChangedEventArgs>(x => This.NotificationChanged += x, x => This.NotificationChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Graphics.Printing3D
{
    public static class EventsMixin
    {
        public static Print3DTaskEvents Events(this Print3DTask This)
        {
            return new Print3DTaskEvents(This);
        }
        public static Print3DManagerEvents Events(this Print3DManager This)
        {
            return new Print3DManagerEvents(This);
        }
    }

    public class Print3DTaskEvents
    {
        Print3DTask This;

        public Print3DTaskEvents(Print3DTask This)
        {
            this.This = This;
        }

        public IObservable<Windows.Graphics.Printing3D.Print3DTaskCompletedEventArgs> Completed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing3D.Print3DTask,Windows.Graphics.Printing3D.Print3DTaskCompletedEventArgs>, Windows.Graphics.Printing3D.Print3DTaskCompletedEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Graphics.Printing3D.Print3DTaskSourceChangedEventArgs> SourceChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing3D.Print3DTask,Windows.Graphics.Printing3D.Print3DTaskSourceChangedEventArgs>, Windows.Graphics.Printing3D.Print3DTaskSourceChangedEventArgs>(x => This.SourceChanged += x, x => This.SourceChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Submitting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing3D.Print3DTask,object>, object>(x => This.Submitting += x, x => This.Submitting -= x).Select(x => x.EventArgs); }
        }

    }
    public class Print3DManagerEvents
    {
        Print3DManager This;

        public Print3DManagerEvents(Print3DManager This)
        {
            this.This = This;
        }

        public IObservable<Windows.Graphics.Printing3D.Print3DTaskRequestedEventArgs> TaskRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Graphics.Printing3D.Print3DManager,Windows.Graphics.Printing3D.Print3DTaskRequestedEventArgs>, Windows.Graphics.Printing3D.Print3DTaskRequestedEventArgs>(x => This.TaskRequested += x, x => This.TaskRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Media.Devices
{
    public static class EventsMixin
    {
        public static CallControlEvents Events(this CallControl This)
        {
            return new CallControlEvents(This);
        }
    }

    public class CallControlEvents
    {
        CallControl This;

        public CallControlEvents(CallControl This)
        {
            this.This = This;
        }

        public IObservable<Windows.Media.Devices.DialRequestedEventArgs> DialRequested {
            get { return Observable.FromEventPattern<Windows.Media.Devices.DialRequestedEventHandler, Windows.Media.Devices.DialRequestedEventArgs>(x => This.DialRequested += x, x => This.DialRequested -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Devices.KeypadPressedEventArgs> KeypadPressed {
            get { return Observable.FromEventPattern<Windows.Media.Devices.KeypadPressedEventHandler, Windows.Media.Devices.KeypadPressedEventArgs>(x => This.KeypadPressed += x, x => This.KeypadPressed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Media.Devices.RedialRequestedEventArgs> RedialRequested {
            get { return Observable.FromEventPattern<Windows.Media.Devices.RedialRequestedEventHandler, Windows.Media.Devices.RedialRequestedEventArgs>(x => This.RedialRequested += x, x => This.RedialRequested -= x).Select(x => x.EventArgs); }
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
namespace Windows.Services.Maps.Guidance
{
    public static class EventsMixin
    {
        public static GuidanceNavigatorEvents Events(this GuidanceNavigator This)
        {
            return new GuidanceNavigatorEvents(This);
        }
    }

    public class GuidanceNavigatorEvents
    {
        GuidanceNavigator This;

        public GuidanceNavigatorEvents(GuidanceNavigator This)
        {
            this.This = This;
        }

        public IObservable<object> DestinationReached {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Services.Maps.Guidance.GuidanceNavigator,object>, object>(x => This.DestinationReached += x, x => This.DestinationReached -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Services.Maps.Guidance.GuidanceUpdatedEventArgs> GuidanceUpdated {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Services.Maps.Guidance.GuidanceNavigator,Windows.Services.Maps.Guidance.GuidanceUpdatedEventArgs>, Windows.Services.Maps.Guidance.GuidanceUpdatedEventArgs>(x => This.GuidanceUpdated += x, x => This.GuidanceUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> RerouteFailed {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Services.Maps.Guidance.GuidanceNavigator,object>, object>(x => This.RerouteFailed += x, x => This.RerouteFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Services.Maps.Guidance.GuidanceReroutedEventArgs> Rerouted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Services.Maps.Guidance.GuidanceNavigator,Windows.Services.Maps.Guidance.GuidanceReroutedEventArgs>, Windows.Services.Maps.Guidance.GuidanceReroutedEventArgs>(x => This.Rerouted += x, x => This.Rerouted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> Rerouting {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Services.Maps.Guidance.GuidanceNavigator,object>, object>(x => This.Rerouting += x, x => This.Rerouting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> UserLocationLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Services.Maps.Guidance.GuidanceNavigator,object>, object>(x => This.UserLocationLost += x, x => This.UserLocationLost -= x).Select(x => x.EventArgs); }
        }

        public IObservable<object> UserLocationRestored {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Services.Maps.Guidance.GuidanceNavigator,object>, object>(x => This.UserLocationRestored += x, x => This.UserLocationRestored -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Services.Maps.Guidance.GuidanceAudioNotificationRequestedEventArgs> AudioNotificationRequested {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Services.Maps.Guidance.GuidanceNavigator,Windows.Services.Maps.Guidance.GuidanceAudioNotificationRequestedEventArgs>, Windows.Services.Maps.Guidance.GuidanceAudioNotificationRequestedEventArgs>(x => This.AudioNotificationRequested += x, x => This.AudioNotificationRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Windows.Services.Store
{
    public static class EventsMixin
    {
        public static StoreContextEvents Events(this StoreContext This)
        {
            return new StoreContextEvents(This);
        }
        public static StorePackageLicenseEvents Events(this StorePackageLicense This)
        {
            return new StorePackageLicenseEvents(This);
        }
    }

    public class StoreContextEvents
    {
        StoreContext This;

        public StoreContextEvents(StoreContext This)
        {
            this.This = This;
        }

        public IObservable<object> OfflineLicensesChanged {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Services.Store.StoreContext,object>, object>(x => This.OfflineLicensesChanged += x, x => This.OfflineLicensesChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class StorePackageLicenseEvents
    {
        StorePackageLicense This;

        public StorePackageLicenseEvents(StorePackageLicense This)
        {
            this.This = This;
        }

        public IObservable<object> LicenseLost {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Services.Store.StorePackageLicense,object>, object>(x => This.LicenseLost += x, x => This.LicenseLost -= x).Select(x => x.EventArgs); }
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
namespace Windows.Web.Http.Diagnostics
{
    public static class EventsMixin
    {
        public static HttpDiagnosticProviderEvents Events(this HttpDiagnosticProvider This)
        {
            return new HttpDiagnosticProviderEvents(This);
        }
    }

    public class HttpDiagnosticProviderEvents
    {
        HttpDiagnosticProvider This;

        public HttpDiagnosticProviderEvents(HttpDiagnosticProvider This)
        {
            this.This = This;
        }

        public IObservable<Windows.Web.Http.Diagnostics.HttpDiagnosticProviderRequestResponseCompletedEventArgs> RequestResponseCompleted {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Web.Http.Diagnostics.HttpDiagnosticProvider,Windows.Web.Http.Diagnostics.HttpDiagnosticProviderRequestResponseCompletedEventArgs>, Windows.Web.Http.Diagnostics.HttpDiagnosticProviderRequestResponseCompletedEventArgs>(x => This.RequestResponseCompleted += x, x => This.RequestResponseCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Web.Http.Diagnostics.HttpDiagnosticProviderRequestSentEventArgs> RequestSent {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Web.Http.Diagnostics.HttpDiagnosticProvider,Windows.Web.Http.Diagnostics.HttpDiagnosticProviderRequestSentEventArgs>, Windows.Web.Http.Diagnostics.HttpDiagnosticProviderRequestSentEventArgs>(x => This.RequestSent += x, x => This.RequestSent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Windows.Web.Http.Diagnostics.HttpDiagnosticProviderResponseReceivedEventArgs> ResponseReceived {
            get { return Observable.FromEventPattern<Windows.Foundation.TypedEventHandler<Windows.Web.Http.Diagnostics.HttpDiagnosticProvider,Windows.Web.Http.Diagnostics.HttpDiagnosticProviderResponseReceivedEventArgs>, Windows.Web.Http.Diagnostics.HttpDiagnosticProviderResponseReceivedEventArgs>(x => This.ResponseReceived += x, x => This.ResponseReceived -= x).Select(x => x.EventArgs); }
        }

    }
}


#pragma warning restore 1591,0618,0105,0672

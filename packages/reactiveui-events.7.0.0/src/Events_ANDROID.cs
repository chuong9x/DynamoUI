#pragma warning disable 1591,0618,0105,0672

using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using ReactiveUI.Events;

using Android.Accounts;
using Android.Animation;
using Android.App;
using Android.InputMethodServices;
using Android.Media;
using Android.Net;
using Android.Views;
using Android.Widget;
using Android.Content;
using Android.Drm;
using Android.Gestures;
using Android.Graphics;
using Android.Hardware;
using Android.Media.Audiofx;
using Android.Media.Effect;
using Android.Media.TV;
using Android.OS;
using Android.Preferences;
using Android.Renderscripts;
using Android.Sax;
using Android.Speech;
using Android.Views.Animations;
using Android.Webkit;
using Javax.Xml.Transform;

namespace Android.Accounts
{
    public static class EventsMixin
    {
        public static AccountManagerEvents Events(this AccountManager This)
        {
            return new AccountManagerEvents(This);
        }
    }

    public class AccountManagerEvents
    {
        AccountManager This;

        public AccountManagerEvents(AccountManager This)
        {
            this.This = This;
        }

        public IObservable<Android.Accounts.AccountsUpdateEventArgs> AccountsUpdated {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Accounts.AccountsUpdateEventArgs>, Android.Accounts.AccountsUpdateEventArgs>(x => This.AccountsUpdated += x, x => This.AccountsUpdated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Animation
{
    public static class EventsMixin
    {
        public static AnimatorEvents Events(this Animator This)
        {
            return new AnimatorEvents(This);
        }
        public static ValueAnimatorEvents Events(this ValueAnimator This)
        {
            return new ValueAnimatorEvents(This);
        }
        public static LayoutTransitionEvents Events(this LayoutTransition This)
        {
            return new LayoutTransitionEvents(This);
        }
        public static TimeAnimatorEvents Events(this TimeAnimator This)
        {
            return new TimeAnimatorEvents(This);
        }
    }

    public class AnimatorEvents
    {
        Animator This;

        public AnimatorEvents(Animator This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> AnimationCancel {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AnimationCancel += x, x => This.AnimationCancel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> AnimationEnd {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AnimationEnd += x, x => This.AnimationEnd -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> AnimationRepeat {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AnimationRepeat += x, x => This.AnimationRepeat -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> AnimationStart {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AnimationStart += x, x => This.AnimationStart -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Animation.Animator.AnimationPauseEventArgs> AnimationPause {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Animation.Animator.AnimationPauseEventArgs>, Android.Animation.Animator.AnimationPauseEventArgs>(x => This.AnimationPause += x, x => This.AnimationPause -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Animation.Animator.AnimationResumeEventArgs> AnimationResume {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Animation.Animator.AnimationResumeEventArgs>, Android.Animation.Animator.AnimationResumeEventArgs>(x => This.AnimationResume += x, x => This.AnimationResume -= x).Select(x => x.EventArgs); }
        }

    }
    public class ValueAnimatorEvents
        : Android.Animation.AnimatorEvents
    {
        ValueAnimator This;

        public ValueAnimatorEvents(ValueAnimator This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Animation.ValueAnimator.AnimatorUpdateEventArgs> Update {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Animation.ValueAnimator.AnimatorUpdateEventArgs>, Android.Animation.ValueAnimator.AnimatorUpdateEventArgs>(x => This.Update += x, x => This.Update -= x).Select(x => x.EventArgs); }
        }

    }
    public class LayoutTransitionEvents
    {
        LayoutTransition This;

        public LayoutTransitionEvents(LayoutTransition This)
        {
            this.This = This;
        }

        public IObservable<Android.Animation.LayoutTransition.EndTransitionEventArgs> EndTransition {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Animation.LayoutTransition.EndTransitionEventArgs>, Android.Animation.LayoutTransition.EndTransitionEventArgs>(x => This.EndTransition += x, x => This.EndTransition -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Animation.LayoutTransition.StartTransitionEventArgs> StartTransition {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Animation.LayoutTransition.StartTransitionEventArgs>, Android.Animation.LayoutTransition.StartTransitionEventArgs>(x => This.StartTransition += x, x => This.StartTransition -= x).Select(x => x.EventArgs); }
        }

    }
    public class TimeAnimatorEvents
        : Android.Animation.ValueAnimatorEvents
    {
        TimeAnimator This;

        public TimeAnimatorEvents(TimeAnimator This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Animation.TimeAnimator.TimeEventArgs> Time {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Animation.TimeAnimator.TimeEventArgs>, Android.Animation.TimeAnimator.TimeEventArgs>(x => This.Time += x, x => This.Time -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.App
{
    public static class EventsMixin
    {
        public static ActionBarEvents Events(this ActionBar This)
        {
            return new ActionBarEvents(This);
        }
        public static DatePickerDialogEvents Events(this DatePickerDialog This)
        {
            return new DatePickerDialogEvents(This);
        }
        public static DialogEvents Events(this Dialog This)
        {
            return new DialogEvents(This);
        }
        public static FragmentManagerEvents Events(this FragmentManager This)
        {
            return new FragmentManagerEvents(This);
        }
        public static SearchManagerEvents Events(this SearchManager This)
        {
            return new SearchManagerEvents(This);
        }
        public static FragmentBreadCrumbsEvents Events(this FragmentBreadCrumbs This)
        {
            return new FragmentBreadCrumbsEvents(This);
        }
        public static MediaRouteActionProviderEvents Events(this MediaRouteActionProvider This)
        {
            return new MediaRouteActionProviderEvents(This);
        }
        public static MediaRouteButtonEvents Events(this MediaRouteButton This)
        {
            return new MediaRouteButtonEvents(This);
        }
        public static UiAutomationEvents Events(this UiAutomation This)
        {
            return new UiAutomationEvents(This);
        }
    }

    public class ActionBarEvents
    {
        ActionBar This;

        public ActionBarEvents(ActionBar This)
        {
            this.This = This;
        }

        public IObservable<Android.App.ActionBar.MenuVisibilityEventArgs> MenuVisibility {
            get { return Observable.FromEventPattern<System.EventHandler<Android.App.ActionBar.MenuVisibilityEventArgs>, Android.App.ActionBar.MenuVisibilityEventArgs>(x => This.MenuVisibility += x, x => This.MenuVisibility -= x).Select(x => x.EventArgs); }
        }

    }
    public class DatePickerDialogEvents
        : Android.App.DialogEvents
    {
        DatePickerDialog This;

        public DatePickerDialogEvents(DatePickerDialog This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.App.DatePickerDialog.DateSetEventArgs> DateSet {
            get { return Observable.FromEventPattern<System.EventHandler<Android.App.DatePickerDialog.DateSetEventArgs>, Android.App.DatePickerDialog.DateSetEventArgs>(x => This.DateSet += x, x => This.DateSet -= x).Select(x => x.EventArgs); }
        }

    }
    public class DialogEvents
    {
        Dialog This;

        public DialogEvents(Dialog This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> CancelEvent {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CancelEvent += x, x => This.CancelEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DismissEvent {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DismissEvent += x, x => This.DismissEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Content.DialogKeyEventArgs> KeyPress {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Content.DialogKeyEventArgs>, Android.Content.DialogKeyEventArgs>(x => This.KeyPress += x, x => This.KeyPress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ShowEvent {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ShowEvent += x, x => This.ShowEvent -= x).Select(x => x.EventArgs); }
        }

    }
    public class FragmentManagerEvents
    {
        FragmentManager This;

        public FragmentManagerEvents(FragmentManager This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> BackStackChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.BackStackChanged += x, x => This.BackStackChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class SearchManagerEvents
    {
        SearchManager This;

        public SearchManagerEvents(SearchManager This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Cancel {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Cancel += x, x => This.Cancel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Dismiss {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Dismiss += x, x => This.Dismiss -= x).Select(x => x.EventArgs); }
        }

    }
    public class FragmentBreadCrumbsEvents
        : Android.Views.ViewGroupEvents
    {
        FragmentBreadCrumbs This;

        public FragmentBreadCrumbsEvents(FragmentBreadCrumbs This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.App.FragmentBreadCrumbs.BreadCrumbClickEventArgs> BreadCrumbClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.App.FragmentBreadCrumbs.BreadCrumbClickEventArgs>, Android.App.FragmentBreadCrumbs.BreadCrumbClickEventArgs>(x => This.BreadCrumbClick += x, x => This.BreadCrumbClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaRouteActionProviderEvents
        : Android.Views.ActionProviderEvents
    {
        MediaRouteActionProvider This;

        public MediaRouteActionProviderEvents(MediaRouteActionProvider This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ExtendedSettingsClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ExtendedSettingsClick += x, x => This.ExtendedSettingsClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaRouteButtonEvents
        : Android.Views.ViewEvents
    {
        MediaRouteButton This;

        public MediaRouteButtonEvents(MediaRouteButton This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ExtendedSettingsClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ExtendedSettingsClick += x, x => This.ExtendedSettingsClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class UiAutomationEvents
    {
        UiAutomation This;

        public UiAutomationEvents(UiAutomation This)
        {
            this.This = This;
        }

        public IObservable<Android.App.UiAutomation.AccessibilityEventEventArgs> AccessibilityEvent {
            get { return Observable.FromEventPattern<System.EventHandler<Android.App.UiAutomation.AccessibilityEventEventArgs>, Android.App.UiAutomation.AccessibilityEventEventArgs>(x => This.AccessibilityEvent += x, x => This.AccessibilityEvent -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.InputMethodServices
{
    public static class EventsMixin
    {
        public static KeyboardViewEvents Events(this KeyboardView This)
        {
            return new KeyboardViewEvents(This);
        }
    }

    public class KeyboardViewEvents
        : Android.Views.ViewEvents
    {
        KeyboardView This;

        public KeyboardViewEvents(KeyboardView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.InputMethodServices.KeyboardView.KeyEventArgs> Key {
            get { return Observable.FromEventPattern<System.EventHandler<Android.InputMethodServices.KeyboardView.KeyEventArgs>, Android.InputMethodServices.KeyboardView.KeyEventArgs>(x => This.Key += x, x => This.Key -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.InputMethodServices.KeyboardView.PressEventArgs> Press {
            get { return Observable.FromEventPattern<System.EventHandler<Android.InputMethodServices.KeyboardView.PressEventArgs>, Android.InputMethodServices.KeyboardView.PressEventArgs>(x => This.Press += x, x => This.Press -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.InputMethodServices.KeyboardView.ReleaseEventArgs> Release {
            get { return Observable.FromEventPattern<System.EventHandler<Android.InputMethodServices.KeyboardView.ReleaseEventArgs>, Android.InputMethodServices.KeyboardView.ReleaseEventArgs>(x => This.Release += x, x => This.Release -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.InputMethodServices.KeyboardView.TextEventArgs> Text {
            get { return Observable.FromEventPattern<System.EventHandler<Android.InputMethodServices.KeyboardView.TextEventArgs>, Android.InputMethodServices.KeyboardView.TextEventArgs>(x => This.Text += x, x => This.Text -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SwipeDownEvent {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SwipeDownEvent += x, x => This.SwipeDownEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SwipeLeftEvent {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SwipeLeftEvent += x, x => This.SwipeLeftEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SwipeRightEvent {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SwipeRightEvent += x, x => This.SwipeRightEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SwipeUpEvent {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SwipeUpEvent += x, x => This.SwipeUpEvent -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Media
{
    public static class EventsMixin
    {
        public static AudioTrackEvents Events(this AudioTrack This)
        {
            return new AudioTrackEvents(This);
        }
        public static MediaPlayerEvents Events(this MediaPlayer This)
        {
            return new MediaPlayerEvents(This);
        }
        public static AudioRecordEvents Events(this AudioRecord This)
        {
            return new AudioRecordEvents(This);
        }
        public static JetPlayerEvents Events(this JetPlayer This)
        {
            return new JetPlayerEvents(This);
        }
        public static MediaDrmEvents Events(this MediaDrm This)
        {
            return new MediaDrmEvents(This);
        }
        public static MediaRecorderEvents Events(this MediaRecorder This)
        {
            return new MediaRecorderEvents(This);
        }
        public static RemoteControlClientEvents Events(this RemoteControlClient This)
        {
            return new RemoteControlClientEvents(This);
        }
        public static SoundPoolEvents Events(this SoundPool This)
        {
            return new SoundPoolEvents(This);
        }
    }

    public class AudioTrackEvents
    {
        AudioTrack This;

        public AudioTrackEvents(AudioTrack This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.AudioTrack.MarkerReachedEventArgs> MarkerReached {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.AudioTrack.MarkerReachedEventArgs>, Android.Media.AudioTrack.MarkerReachedEventArgs>(x => This.MarkerReached += x, x => This.MarkerReached -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.AudioTrack.PeriodicNotificationEventArgs> PeriodicNotification {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.AudioTrack.PeriodicNotificationEventArgs>, Android.Media.AudioTrack.PeriodicNotificationEventArgs>(x => This.PeriodicNotification += x, x => This.PeriodicNotification -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaPlayerEvents
    {
        MediaPlayer This;

        public MediaPlayerEvents(MediaPlayer This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.MediaPlayer.BufferingUpdateEventArgs> BufferingUpdate {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.MediaPlayer.BufferingUpdateEventArgs>, Android.Media.MediaPlayer.BufferingUpdateEventArgs>(x => This.BufferingUpdate += x, x => This.BufferingUpdate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Completion {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Completion += x, x => This.Completion -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.MediaPlayer.ErrorEventArgs> Error {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.MediaPlayer.ErrorEventArgs>, Android.Media.MediaPlayer.ErrorEventArgs>(x => This.Error += x, x => This.Error -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.MediaPlayer.InfoEventArgs> Info {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.MediaPlayer.InfoEventArgs>, Android.Media.MediaPlayer.InfoEventArgs>(x => This.Info += x, x => This.Info -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Prepared {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Prepared += x, x => This.Prepared -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SeekComplete {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SeekComplete += x, x => This.SeekComplete -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.MediaPlayer.TimedMetaDataAvailableEventArgs> TimedMetaDataAvailable {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.MediaPlayer.TimedMetaDataAvailableEventArgs>, Android.Media.MediaPlayer.TimedMetaDataAvailableEventArgs>(x => This.TimedMetaDataAvailable += x, x => This.TimedMetaDataAvailable -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.MediaPlayer.TimedTextEventArgs> TimedText {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.MediaPlayer.TimedTextEventArgs>, Android.Media.MediaPlayer.TimedTextEventArgs>(x => This.TimedText += x, x => This.TimedText -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.MediaPlayer.VideoSizeChangedEventArgs> VideoSizeChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.MediaPlayer.VideoSizeChangedEventArgs>, Android.Media.MediaPlayer.VideoSizeChangedEventArgs>(x => This.VideoSizeChanged += x, x => This.VideoSizeChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class AudioRecordEvents
    {
        AudioRecord This;

        public AudioRecordEvents(AudioRecord This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.AudioRecord.MarkerReachedEventArgs> MarkerReached {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.AudioRecord.MarkerReachedEventArgs>, Android.Media.AudioRecord.MarkerReachedEventArgs>(x => This.MarkerReached += x, x => This.MarkerReached -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.AudioRecord.PeriodicNotificationEventArgs> PeriodicNotification {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.AudioRecord.PeriodicNotificationEventArgs>, Android.Media.AudioRecord.PeriodicNotificationEventArgs>(x => This.PeriodicNotification += x, x => This.PeriodicNotification -= x).Select(x => x.EventArgs); }
        }

    }
    public class JetPlayerEvents
    {
        JetPlayer This;

        public JetPlayerEvents(JetPlayer This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.JetPlayer.JetEventEventArgs> JetEvent {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.JetPlayer.JetEventEventArgs>, Android.Media.JetPlayer.JetEventEventArgs>(x => This.JetEvent += x, x => This.JetEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.JetPlayer.JetNumQueuedSegmentUpdateEventArgs> JetNumQueuedSegmentUpdate {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.JetPlayer.JetNumQueuedSegmentUpdateEventArgs>, Android.Media.JetPlayer.JetNumQueuedSegmentUpdateEventArgs>(x => This.JetNumQueuedSegmentUpdate += x, x => This.JetNumQueuedSegmentUpdate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.JetPlayer.JetPauseUpdateEventArgs> JetPauseUpdate {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.JetPlayer.JetPauseUpdateEventArgs>, Android.Media.JetPlayer.JetPauseUpdateEventArgs>(x => This.JetPauseUpdate += x, x => This.JetPauseUpdate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.JetPlayer.JetUserIdUpdateEventArgs> JetUserIdUpdate {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.JetPlayer.JetUserIdUpdateEventArgs>, Android.Media.JetPlayer.JetUserIdUpdateEventArgs>(x => This.JetUserIdUpdate += x, x => This.JetUserIdUpdate -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaDrmEvents
    {
        MediaDrm This;

        public MediaDrmEvents(MediaDrm This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.MediaDrm.MediaDrmEventArgs> MediaDrmEvent {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.MediaDrm.MediaDrmEventArgs>, Android.Media.MediaDrm.MediaDrmEventArgs>(x => This.MediaDrmEvent += x, x => This.MediaDrmEvent -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaRecorderEvents
    {
        MediaRecorder This;

        public MediaRecorderEvents(MediaRecorder This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.MediaRecorder.ErrorEventArgs> Error {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.MediaRecorder.ErrorEventArgs>, Android.Media.MediaRecorder.ErrorEventArgs>(x => This.Error += x, x => This.Error -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.MediaRecorder.InfoEventArgs> Info {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.MediaRecorder.InfoEventArgs>, Android.Media.MediaRecorder.InfoEventArgs>(x => This.Info += x, x => This.Info -= x).Select(x => x.EventArgs); }
        }

    }
    public class RemoteControlClientEvents
    {
        RemoteControlClient This;

        public RemoteControlClientEvents(RemoteControlClient This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.RemoteControlClient.MetadataUpdateEventArgs> MetadataUpdate {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.RemoteControlClient.MetadataUpdateEventArgs>, Android.Media.RemoteControlClient.MetadataUpdateEventArgs>(x => This.MetadataUpdate += x, x => This.MetadataUpdate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.RemoteControlClient.PlaybackPositionUpdateEventArgs> PlaybackPositionUpdate {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.RemoteControlClient.PlaybackPositionUpdateEventArgs>, Android.Media.RemoteControlClient.PlaybackPositionUpdateEventArgs>(x => This.PlaybackPositionUpdate += x, x => This.PlaybackPositionUpdate -= x).Select(x => x.EventArgs); }
        }

    }
    public class SoundPoolEvents
    {
        SoundPool This;

        public SoundPoolEvents(SoundPool This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.SoundPool.LoadCompleteEventArgs> LoadComplete {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.SoundPool.LoadCompleteEventArgs>, Android.Media.SoundPool.LoadCompleteEventArgs>(x => This.LoadComplete += x, x => This.LoadComplete -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Net
{
    public static class EventsMixin
    {
        public static ConnectivityManagerEvents Events(this ConnectivityManager This)
        {
            return new ConnectivityManagerEvents(This);
        }
    }

    public class ConnectivityManagerEvents
    {
        ConnectivityManager This;

        public ConnectivityManagerEvents(ConnectivityManager This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DefaultNetworkActive {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DefaultNetworkActive += x, x => This.DefaultNetworkActive -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Views
{
    public static class EventsMixin
    {
        public static ViewEvents Events(this View This)
        {
            return new ViewEvents(This);
        }
        public static ViewTreeObserverEvents Events(this ViewTreeObserver This)
        {
            return new ViewTreeObserverEvents(This);
        }
        public static WindowEvents Events(this Window This)
        {
            return new WindowEvents(This);
        }
        public static ActionProviderEvents Events(this ActionProvider This)
        {
            return new ActionProviderEvents(This);
        }
        public static GestureDetectorEvents Events(this GestureDetector This)
        {
            return new GestureDetectorEvents(This);
        }
        public static TextureViewEvents Events(this TextureView This)
        {
            return new TextureViewEvents(This);
        }
        public static ViewGroupEvents Events(this ViewGroup This)
        {
            return new ViewGroupEvents(This);
        }
        public static ViewStubEvents Events(this ViewStub This)
        {
            return new ViewStubEvents(This);
        }
    }

    public class ViewEvents
    {
        View This;

        public ViewEvents(View This)
        {
            this.This = This;
        }

        public IObservable<Android.Views.View.ViewAttachedToWindowEventArgs> ViewAttachedToWindow {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.ViewAttachedToWindowEventArgs>, Android.Views.View.ViewAttachedToWindowEventArgs>(x => This.ViewAttachedToWindow += x, x => This.ViewAttachedToWindow -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.ViewDetachedFromWindowEventArgs> ViewDetachedFromWindow {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.ViewDetachedFromWindowEventArgs>, Android.Views.View.ViewDetachedFromWindowEventArgs>(x => This.ViewDetachedFromWindow += x, x => This.ViewDetachedFromWindow -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.LayoutChangeEventArgs> LayoutChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.LayoutChangeEventArgs>, Android.Views.View.LayoutChangeEventArgs>(x => This.LayoutChange += x, x => This.LayoutChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.ContextClickEventArgs> ContextClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.ContextClickEventArgs>, Android.Views.View.ContextClickEventArgs>(x => This.ContextClick += x, x => This.ContextClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.CreateContextMenuEventArgs> ContextMenuCreated {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.CreateContextMenuEventArgs>, Android.Views.View.CreateContextMenuEventArgs>(x => This.ContextMenuCreated += x, x => This.ContextMenuCreated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.DragEventArgs> Drag {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.DragEventArgs>, Android.Views.View.DragEventArgs>(x => This.Drag += x, x => This.Drag -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.GenericMotionEventArgs> GenericMotion {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.GenericMotionEventArgs>, Android.Views.View.GenericMotionEventArgs>(x => This.GenericMotion += x, x => This.GenericMotion -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.HoverEventArgs> Hover {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.HoverEventArgs>, Android.Views.View.HoverEventArgs>(x => This.Hover += x, x => This.Hover -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.KeyEventArgs> KeyPress {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.KeyEventArgs>, Android.Views.View.KeyEventArgs>(x => This.KeyPress += x, x => This.KeyPress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.LongClickEventArgs> LongClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.LongClickEventArgs>, Android.Views.View.LongClickEventArgs>(x => This.LongClick += x, x => This.LongClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.ScrollChangeEventArgs> ScrollChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.ScrollChangeEventArgs>, Android.Views.View.ScrollChangeEventArgs>(x => This.ScrollChange += x, x => This.ScrollChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.SystemUiVisibilityChangeEventArgs> SystemUiVisibilityChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.SystemUiVisibilityChangeEventArgs>, Android.Views.View.SystemUiVisibilityChangeEventArgs>(x => This.SystemUiVisibilityChange += x, x => This.SystemUiVisibilityChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.TouchEventArgs> Touch {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.TouchEventArgs>, Android.Views.View.TouchEventArgs>(x => This.Touch += x, x => This.Touch -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.FocusChangeEventArgs> FocusChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.FocusChangeEventArgs>, Android.Views.View.FocusChangeEventArgs>(x => This.FocusChange += x, x => This.FocusChange -= x).Select(x => x.EventArgs); }
        }

    }
    public class ViewTreeObserverEvents
    {
        ViewTreeObserver This;

        public ViewTreeObserverEvents(ViewTreeObserver This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Draw {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Draw += x, x => This.Draw -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.ViewTreeObserver.GlobalFocusChangeEventArgs> GlobalFocusChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.ViewTreeObserver.GlobalFocusChangeEventArgs>, Android.Views.ViewTreeObserver.GlobalFocusChangeEventArgs>(x => This.GlobalFocusChange += x, x => This.GlobalFocusChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> GlobalLayout {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.GlobalLayout += x, x => This.GlobalLayout -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.ViewTreeObserver.PreDrawEventArgs> PreDraw {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.ViewTreeObserver.PreDrawEventArgs>, Android.Views.ViewTreeObserver.PreDrawEventArgs>(x => This.PreDraw += x, x => This.PreDraw -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ScrollChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ScrollChanged += x, x => This.ScrollChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.ViewTreeObserver.TouchModeChangeEventArgs> TouchModeChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.ViewTreeObserver.TouchModeChangeEventArgs>, Android.Views.ViewTreeObserver.TouchModeChangeEventArgs>(x => This.TouchModeChange += x, x => This.TouchModeChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WindowAttached {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WindowAttached += x, x => This.WindowAttached -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WindowDetached {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WindowDetached += x, x => This.WindowDetached -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.ViewTreeObserver.WindowFocusChangeEventArgs> WindowFocusChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.ViewTreeObserver.WindowFocusChangeEventArgs>, Android.Views.ViewTreeObserver.WindowFocusChangeEventArgs>(x => This.WindowFocusChange += x, x => This.WindowFocusChange -= x).Select(x => x.EventArgs); }
        }

    }
    public class WindowEvents
    {
        Window This;

        public WindowEvents(Window This)
        {
            this.This = This;
        }

        public IObservable<Android.Views.Window.RestrictedCaptionAreaChangedEventArgs> RestrictedCaptionArea {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.Window.RestrictedCaptionAreaChangedEventArgs>, Android.Views.Window.RestrictedCaptionAreaChangedEventArgs>(x => This.RestrictedCaptionArea += x, x => This.RestrictedCaptionArea -= x).Select(x => x.EventArgs); }
        }

    }
    public class ActionProviderEvents
    {
        ActionProvider This;

        public ActionProviderEvents(ActionProvider This)
        {
            this.This = This;
        }

        public IObservable<Android.Views.ActionProvider.VisibilityEventArgs> Visibility {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.ActionProvider.VisibilityEventArgs>, Android.Views.ActionProvider.VisibilityEventArgs>(x => This.Visibility += x, x => This.Visibility -= x).Select(x => x.EventArgs); }
        }

    }
    public class GestureDetectorEvents
    {
        GestureDetector This;

        public GestureDetectorEvents(GestureDetector This)
        {
            this.This = This;
        }

        public IObservable<Android.Views.GestureDetector.ContextClickEventArgs> ContextClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.GestureDetector.ContextClickEventArgs>, Android.Views.GestureDetector.ContextClickEventArgs>(x => This.ContextClick += x, x => This.ContextClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.GestureDetector.DoubleTapEventArgs> DoubleTap {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.GestureDetector.DoubleTapEventArgs>, Android.Views.GestureDetector.DoubleTapEventArgs>(x => This.DoubleTap += x, x => This.DoubleTap -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.GestureDetector.DoubleTapEventEventArgs> DoubleTapEvent {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.GestureDetector.DoubleTapEventEventArgs>, Android.Views.GestureDetector.DoubleTapEventEventArgs>(x => This.DoubleTapEvent += x, x => This.DoubleTapEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.GestureDetector.SingleTapConfirmedEventArgs> SingleTapConfirmed {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.GestureDetector.SingleTapConfirmedEventArgs>, Android.Views.GestureDetector.SingleTapConfirmedEventArgs>(x => This.SingleTapConfirmed += x, x => This.SingleTapConfirmed -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextureViewEvents
        : Android.Views.ViewEvents
    {
        TextureView This;

        public TextureViewEvents(TextureView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Views.TextureView.SurfaceTextureAvailableEventArgs> SurfaceTextureAvailable {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.TextureView.SurfaceTextureAvailableEventArgs>, Android.Views.TextureView.SurfaceTextureAvailableEventArgs>(x => This.SurfaceTextureAvailable += x, x => This.SurfaceTextureAvailable -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.TextureView.SurfaceTextureDestroyedEventArgs> SurfaceTextureDestroyed {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.TextureView.SurfaceTextureDestroyedEventArgs>, Android.Views.TextureView.SurfaceTextureDestroyedEventArgs>(x => This.SurfaceTextureDestroyed += x, x => This.SurfaceTextureDestroyed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.TextureView.SurfaceTextureSizeChangedEventArgs> SurfaceTextureSizeChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.TextureView.SurfaceTextureSizeChangedEventArgs>, Android.Views.TextureView.SurfaceTextureSizeChangedEventArgs>(x => This.SurfaceTextureSizeChanged += x, x => This.SurfaceTextureSizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.TextureView.SurfaceTextureUpdatedEventArgs> SurfaceTextureUpdated {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.TextureView.SurfaceTextureUpdatedEventArgs>, Android.Views.TextureView.SurfaceTextureUpdatedEventArgs>(x => This.SurfaceTextureUpdated += x, x => This.SurfaceTextureUpdated -= x).Select(x => x.EventArgs); }
        }

    }
    public class ViewGroupEvents
        : Android.Views.ViewEvents
    {
        ViewGroup This;

        public ViewGroupEvents(ViewGroup This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Views.ViewGroup.ChildViewAddedEventArgs> ChildViewAdded {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.ViewGroup.ChildViewAddedEventArgs>, Android.Views.ViewGroup.ChildViewAddedEventArgs>(x => This.ChildViewAdded += x, x => This.ChildViewAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.ViewGroup.ChildViewRemovedEventArgs> ChildViewRemoved {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.ViewGroup.ChildViewRemovedEventArgs>, Android.Views.ViewGroup.ChildViewRemovedEventArgs>(x => This.ChildViewRemoved += x, x => This.ChildViewRemoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.Animations.Animation.AnimationEndEventArgs> AnimationEnd {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.Animations.Animation.AnimationEndEventArgs>, Android.Views.Animations.Animation.AnimationEndEventArgs>(x => This.AnimationEnd += x, x => This.AnimationEnd -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.Animations.Animation.AnimationRepeatEventArgs> AnimationRepeat {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.Animations.Animation.AnimationRepeatEventArgs>, Android.Views.Animations.Animation.AnimationRepeatEventArgs>(x => This.AnimationRepeat += x, x => This.AnimationRepeat -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.Animations.Animation.AnimationStartEventArgs> AnimationStart {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.Animations.Animation.AnimationStartEventArgs>, Android.Views.Animations.Animation.AnimationStartEventArgs>(x => This.AnimationStart += x, x => This.AnimationStart -= x).Select(x => x.EventArgs); }
        }

    }
    public class ViewStubEvents
        : Android.Views.ViewEvents
    {
        ViewStub This;

        public ViewStubEvents(ViewStub This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Views.ViewStub.InflateEventArgs> InflateEvent {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.ViewStub.InflateEventArgs>, Android.Views.ViewStub.InflateEventArgs>(x => This.InflateEvent += x, x => This.InflateEvent -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Widget
{
    public static class EventsMixin
    {
        public static AbsListViewEvents Events(this AbsListView This)
        {
            return new AbsListViewEvents(This);
        }
        public static AdapterViewEvents Events(this AdapterView This)
        {
            return new AdapterViewEvents(This);
        }
        public static AutoCompleteTextViewEvents Events(this AutoCompleteTextView This)
        {
            return new AutoCompleteTextViewEvents(This);
        }
        public static MediaControllerEvents Events(this MediaController This)
        {
            return new MediaControllerEvents(This);
        }
        public static TextViewEvents Events(this TextView This)
        {
            return new TextViewEvents(This);
        }
        public static ActionMenuViewEvents Events(this ActionMenuView This)
        {
            return new ActionMenuViewEvents(This);
        }
        public static CalendarViewEvents Events(this CalendarView This)
        {
            return new CalendarViewEvents(This);
        }
        public static ChronometerEvents Events(this Chronometer This)
        {
            return new ChronometerEvents(This);
        }
        public static CompoundButtonEvents Events(this CompoundButton This)
        {
            return new CompoundButtonEvents(This);
        }
        public static ExpandableListViewEvents Events(this ExpandableListView This)
        {
            return new ExpandableListViewEvents(This);
        }
        public static ListPopupWindowEvents Events(this ListPopupWindow This)
        {
            return new ListPopupWindowEvents(This);
        }
        public static NumberPickerEvents Events(this NumberPicker This)
        {
            return new NumberPickerEvents(This);
        }
        public static PopupMenuEvents Events(this PopupMenu This)
        {
            return new PopupMenuEvents(This);
        }
        public static PopupWindowEvents Events(this PopupWindow This)
        {
            return new PopupWindowEvents(This);
        }
        public static RadioGroupEvents Events(this RadioGroup This)
        {
            return new RadioGroupEvents(This);
        }
        public static RatingBarEvents Events(this RatingBar This)
        {
            return new RatingBarEvents(This);
        }
        public static SearchViewEvents Events(this SearchView This)
        {
            return new SearchViewEvents(This);
        }
        public static SeekBarEvents Events(this SeekBar This)
        {
            return new SeekBarEvents(This);
        }
        public static ShareActionProviderEvents Events(this ShareActionProvider This)
        {
            return new ShareActionProviderEvents(This);
        }
        public static SlidingDrawerEvents Events(this SlidingDrawer This)
        {
            return new SlidingDrawerEvents(This);
        }
        public static TabHostEvents Events(this TabHost This)
        {
            return new TabHostEvents(This);
        }
        public static TimePickerEvents Events(this TimePicker This)
        {
            return new TimePickerEvents(This);
        }
        public static ToolbarEvents Events(this Toolbar This)
        {
            return new ToolbarEvents(This);
        }
        public static VideoViewEvents Events(this VideoView This)
        {
            return new VideoViewEvents(This);
        }
        public static ZoomButtonsControllerEvents Events(this ZoomButtonsController This)
        {
            return new ZoomButtonsControllerEvents(This);
        }
        public static ZoomControlsEvents Events(this ZoomControls This)
        {
            return new ZoomControlsEvents(This);
        }
    }

    public class AbsListViewEvents
        : Android.Widget.AdapterViewEvents
    {
        AbsListView This;

        public AbsListViewEvents(AbsListView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.AbsListView.ScrollEventArgs> Scroll {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AbsListView.ScrollEventArgs>, Android.Widget.AbsListView.ScrollEventArgs>(x => This.Scroll += x, x => This.Scroll -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.AbsListView.ScrollStateChangedEventArgs> ScrollStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AbsListView.ScrollStateChangedEventArgs>, Android.Widget.AbsListView.ScrollStateChangedEventArgs>(x => This.ScrollStateChanged += x, x => This.ScrollStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.AbsListView.RecyclerEventArgs> Recycler {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AbsListView.RecyclerEventArgs>, Android.Widget.AbsListView.RecyclerEventArgs>(x => This.Recycler += x, x => This.Recycler -= x).Select(x => x.EventArgs); }
        }

    }
    public class AdapterViewEvents
        : Android.Views.ViewGroupEvents
    {
        AdapterView This;

        public AdapterViewEvents(AdapterView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ItemSelectionCleared {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ItemSelectionCleared += x, x => This.ItemSelectionCleared -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.AdapterView.ItemClickEventArgs> ItemClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AdapterView.ItemClickEventArgs>, Android.Widget.AdapterView.ItemClickEventArgs>(x => This.ItemClick += x, x => This.ItemClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.AdapterView.ItemLongClickEventArgs> ItemLongClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AdapterView.ItemLongClickEventArgs>, Android.Widget.AdapterView.ItemLongClickEventArgs>(x => This.ItemLongClick += x, x => This.ItemLongClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.AdapterView.ItemSelectedEventArgs> ItemSelected {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AdapterView.ItemSelectedEventArgs>, Android.Widget.AdapterView.ItemSelectedEventArgs>(x => This.ItemSelected += x, x => This.ItemSelected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.AdapterView.NothingSelectedEventArgs> NothingSelected {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AdapterView.NothingSelectedEventArgs>, Android.Widget.AdapterView.NothingSelectedEventArgs>(x => This.NothingSelected += x, x => This.NothingSelected -= x).Select(x => x.EventArgs); }
        }

    }
    public class AutoCompleteTextViewEvents
        : Android.Widget.TextViewEvents
    {
        AutoCompleteTextView This;

        public AutoCompleteTextViewEvents(AutoCompleteTextView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ItemSelectionCleared {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ItemSelectionCleared += x, x => This.ItemSelectionCleared -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Dismiss {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Dismiss += x, x => This.Dismiss -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.AdapterView.ItemClickEventArgs> ItemClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AdapterView.ItemClickEventArgs>, Android.Widget.AdapterView.ItemClickEventArgs>(x => This.ItemClick += x, x => This.ItemClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.AdapterView.ItemSelectedEventArgs> ItemSelected {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AdapterView.ItemSelectedEventArgs>, Android.Widget.AdapterView.ItemSelectedEventArgs>(x => This.ItemSelected += x, x => This.ItemSelected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.AdapterView.NothingSelectedEventArgs> NothingSelected {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AdapterView.NothingSelectedEventArgs>, Android.Widget.AdapterView.NothingSelectedEventArgs>(x => This.NothingSelected += x, x => This.NothingSelected -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaControllerEvents
        : Android.Views.ViewGroupEvents
    {
        MediaController This;

        public MediaControllerEvents(MediaController This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> NextClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.NextClick += x, x => This.NextClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PreviousClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PreviousClick += x, x => This.PreviousClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextViewEvents
        : Android.Views.ViewEvents
    {
        TextView This;

        public TextViewEvents(TextView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Text.AfterTextChangedEventArgs> AfterTextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Text.AfterTextChangedEventArgs>, Android.Text.AfterTextChangedEventArgs>(x => This.AfterTextChanged += x, x => This.AfterTextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Text.TextChangedEventArgs> BeforeTextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(x => This.BeforeTextChanged += x, x => This.BeforeTextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Text.TextChangedEventArgs> TextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Text.TextChangedEventArgs>, Android.Text.TextChangedEventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.TextView.EditorActionEventArgs> EditorAction {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.TextView.EditorActionEventArgs>, Android.Widget.TextView.EditorActionEventArgs>(x => This.EditorAction += x, x => This.EditorAction -= x).Select(x => x.EventArgs); }
        }

    }
    public class ActionMenuViewEvents
        : Android.Views.ViewGroupEvents
    {
        ActionMenuView This;

        public ActionMenuViewEvents(ActionMenuView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.ActionMenuView.MenuItemClickEventArgs> MenuItemClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.ActionMenuView.MenuItemClickEventArgs>, Android.Widget.ActionMenuView.MenuItemClickEventArgs>(x => This.MenuItemClick += x, x => This.MenuItemClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class CalendarViewEvents
        : Android.Views.ViewGroupEvents
    {
        CalendarView This;

        public CalendarViewEvents(CalendarView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.CalendarView.DateChangeEventArgs> DateChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.CalendarView.DateChangeEventArgs>, Android.Widget.CalendarView.DateChangeEventArgs>(x => This.DateChange += x, x => This.DateChange -= x).Select(x => x.EventArgs); }
        }

    }
    public class ChronometerEvents
        : Android.Widget.TextViewEvents
    {
        Chronometer This;

        public ChronometerEvents(Chronometer This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ChronometerTick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ChronometerTick += x, x => This.ChronometerTick -= x).Select(x => x.EventArgs); }
        }

    }
    public class CompoundButtonEvents
        : Android.Widget.TextViewEvents
    {
        CompoundButton This;

        public CompoundButtonEvents(CompoundButton This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.CompoundButton.CheckedChangeEventArgs> CheckedChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.CompoundButton.CheckedChangeEventArgs>, Android.Widget.CompoundButton.CheckedChangeEventArgs>(x => This.CheckedChange += x, x => This.CheckedChange -= x).Select(x => x.EventArgs); }
        }

    }
    public class ExpandableListViewEvents
        : Android.Widget.AbsListViewEvents
    {
        ExpandableListView This;

        public ExpandableListViewEvents(ExpandableListView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.ExpandableListView.ChildClickEventArgs> ChildClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.ExpandableListView.ChildClickEventArgs>, Android.Widget.ExpandableListView.ChildClickEventArgs>(x => This.ChildClick += x, x => This.ChildClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.ExpandableListView.GroupClickEventArgs> GroupClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.ExpandableListView.GroupClickEventArgs>, Android.Widget.ExpandableListView.GroupClickEventArgs>(x => This.GroupClick += x, x => This.GroupClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.ExpandableListView.GroupCollapseEventArgs> GroupCollapse {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.ExpandableListView.GroupCollapseEventArgs>, Android.Widget.ExpandableListView.GroupCollapseEventArgs>(x => This.GroupCollapse += x, x => This.GroupCollapse -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.ExpandableListView.GroupExpandEventArgs> GroupExpand {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.ExpandableListView.GroupExpandEventArgs>, Android.Widget.ExpandableListView.GroupExpandEventArgs>(x => This.GroupExpand += x, x => This.GroupExpand -= x).Select(x => x.EventArgs); }
        }

    }
    public class ListPopupWindowEvents
    {
        ListPopupWindow This;

        public ListPopupWindowEvents(ListPopupWindow This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DismissEvent {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DismissEvent += x, x => This.DismissEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.AdapterView.ItemClickEventArgs> ItemClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AdapterView.ItemClickEventArgs>, Android.Widget.AdapterView.ItemClickEventArgs>(x => This.ItemClick += x, x => This.ItemClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.AdapterView.ItemSelectedEventArgs> ItemSelected {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AdapterView.ItemSelectedEventArgs>, Android.Widget.AdapterView.ItemSelectedEventArgs>(x => This.ItemSelected += x, x => This.ItemSelected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.AdapterView.NothingSelectedEventArgs> NothingSelected {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.AdapterView.NothingSelectedEventArgs>, Android.Widget.AdapterView.NothingSelectedEventArgs>(x => This.NothingSelected += x, x => This.NothingSelected -= x).Select(x => x.EventArgs); }
        }

    }
    public class NumberPickerEvents
        : Android.Views.ViewGroupEvents
    {
        NumberPicker This;

        public NumberPickerEvents(NumberPicker This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.NumberPicker.ScrollEventArgs> Scroll {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.NumberPicker.ScrollEventArgs>, Android.Widget.NumberPicker.ScrollEventArgs>(x => This.Scroll += x, x => This.Scroll -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.NumberPicker.ValueChangeEventArgs> ValueChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.NumberPicker.ValueChangeEventArgs>, Android.Widget.NumberPicker.ValueChangeEventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PopupMenuEvents
    {
        PopupMenu This;

        public PopupMenuEvents(PopupMenu This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.PopupMenu.DismissEventArgs> DismissEvent {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.PopupMenu.DismissEventArgs>, Android.Widget.PopupMenu.DismissEventArgs>(x => This.DismissEvent += x, x => This.DismissEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.PopupMenu.MenuItemClickEventArgs> MenuItemClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.PopupMenu.MenuItemClickEventArgs>, Android.Widget.PopupMenu.MenuItemClickEventArgs>(x => This.MenuItemClick += x, x => This.MenuItemClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class PopupWindowEvents
    {
        PopupWindow This;

        public PopupWindowEvents(PopupWindow This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DismissEvent {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DismissEvent += x, x => This.DismissEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.TouchEventArgs> TouchIntercepted {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.TouchEventArgs>, Android.Views.View.TouchEventArgs>(x => This.TouchIntercepted += x, x => This.TouchIntercepted -= x).Select(x => x.EventArgs); }
        }

    }
    public class RadioGroupEvents
        : Android.Views.ViewGroupEvents
    {
        RadioGroup This;

        public RadioGroupEvents(RadioGroup This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.RadioGroup.CheckedChangeEventArgs> CheckedChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.RadioGroup.CheckedChangeEventArgs>, Android.Widget.RadioGroup.CheckedChangeEventArgs>(x => This.CheckedChange += x, x => This.CheckedChange -= x).Select(x => x.EventArgs); }
        }

    }
    public class RatingBarEvents
        : Android.Views.ViewEvents
    {
        RatingBar This;

        public RatingBarEvents(RatingBar This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.RatingBar.RatingBarChangeEventArgs> RatingBarChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.RatingBar.RatingBarChangeEventArgs>, Android.Widget.RatingBar.RatingBarChangeEventArgs>(x => This.RatingBarChange += x, x => This.RatingBarChange -= x).Select(x => x.EventArgs); }
        }

    }
    public class SearchViewEvents
        : Android.Views.ViewGroupEvents
    {
        SearchView This;

        public SearchViewEvents(SearchView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.SearchView.CloseEventArgs> Close {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.SearchView.CloseEventArgs>, Android.Widget.SearchView.CloseEventArgs>(x => This.Close += x, x => This.Close -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.View.FocusChangeEventArgs> QueryTextFocusChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.View.FocusChangeEventArgs>, Android.Views.View.FocusChangeEventArgs>(x => This.QueryTextFocusChange += x, x => This.QueryTextFocusChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.SearchView.QueryTextChangeEventArgs> QueryTextChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.SearchView.QueryTextChangeEventArgs>, Android.Widget.SearchView.QueryTextChangeEventArgs>(x => This.QueryTextChange += x, x => This.QueryTextChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.SearchView.QueryTextSubmitEventArgs> QueryTextSubmit {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.SearchView.QueryTextSubmitEventArgs>, Android.Widget.SearchView.QueryTextSubmitEventArgs>(x => This.QueryTextSubmit += x, x => This.QueryTextSubmit -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SearchClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SearchClick += x, x => This.SearchClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.SearchView.SuggestionClickEventArgs> SuggestionClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.SearchView.SuggestionClickEventArgs>, Android.Widget.SearchView.SuggestionClickEventArgs>(x => This.SuggestionClick += x, x => This.SuggestionClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.SearchView.SuggestionSelectEventArgs> SuggestionSelect {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.SearchView.SuggestionSelectEventArgs>, Android.Widget.SearchView.SuggestionSelectEventArgs>(x => This.SuggestionSelect += x, x => This.SuggestionSelect -= x).Select(x => x.EventArgs); }
        }

    }
    public class SeekBarEvents
        : Android.Views.ViewEvents
    {
        SeekBar This;

        public SeekBarEvents(SeekBar This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.SeekBar.ProgressChangedEventArgs> ProgressChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.SeekBar.ProgressChangedEventArgs>, Android.Widget.SeekBar.ProgressChangedEventArgs>(x => This.ProgressChanged += x, x => This.ProgressChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.SeekBar.StartTrackingTouchEventArgs> StartTrackingTouch {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.SeekBar.StartTrackingTouchEventArgs>, Android.Widget.SeekBar.StartTrackingTouchEventArgs>(x => This.StartTrackingTouch += x, x => This.StartTrackingTouch -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.SeekBar.StopTrackingTouchEventArgs> StopTrackingTouch {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.SeekBar.StopTrackingTouchEventArgs>, Android.Widget.SeekBar.StopTrackingTouchEventArgs>(x => This.StopTrackingTouch += x, x => This.StopTrackingTouch -= x).Select(x => x.EventArgs); }
        }

    }
    public class ShareActionProviderEvents
        : Android.Views.ActionProviderEvents
    {
        ShareActionProvider This;

        public ShareActionProviderEvents(ShareActionProvider This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.ShareActionProvider.ShareTargetSelectedEventArgs> ShareTargetSelected {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.ShareActionProvider.ShareTargetSelectedEventArgs>, Android.Widget.ShareActionProvider.ShareTargetSelectedEventArgs>(x => This.ShareTargetSelected += x, x => This.ShareTargetSelected -= x).Select(x => x.EventArgs); }
        }

    }
    public class SlidingDrawerEvents
        : Android.Views.ViewGroupEvents
    {
        SlidingDrawer This;

        public SlidingDrawerEvents(SlidingDrawer This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DrawerClose {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DrawerClose += x, x => This.DrawerClose -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DrawerOpen {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DrawerOpen += x, x => This.DrawerOpen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ScrollEnded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ScrollEnded += x, x => This.ScrollEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ScrollStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ScrollStarted += x, x => This.ScrollStarted -= x).Select(x => x.EventArgs); }
        }

    }
    public class TabHostEvents
        : Android.Views.ViewGroupEvents
    {
        TabHost This;

        public TabHostEvents(TabHost This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.TabHost.TabChangeEventArgs> TabChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.TabHost.TabChangeEventArgs>, Android.Widget.TabHost.TabChangeEventArgs>(x => This.TabChanged += x, x => This.TabChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class TimePickerEvents
        : Android.Views.ViewGroupEvents
    {
        TimePicker This;

        public TimePickerEvents(TimePicker This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.TimePicker.TimeChangedEventArgs> TimeChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.TimePicker.TimeChangedEventArgs>, Android.Widget.TimePicker.TimeChangedEventArgs>(x => This.TimeChanged += x, x => This.TimeChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToolbarEvents
        : Android.Views.ViewGroupEvents
    {
        Toolbar This;

        public ToolbarEvents(Toolbar This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> NavigationOnClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.NavigationOnClick += x, x => This.NavigationOnClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.Toolbar.MenuItemClickEventArgs> MenuItemClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.Toolbar.MenuItemClickEventArgs>, Android.Widget.Toolbar.MenuItemClickEventArgs>(x => This.MenuItemClick += x, x => This.MenuItemClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class VideoViewEvents
        : Android.Views.ViewEvents
    {
        VideoView This;

        public VideoViewEvents(VideoView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Completion {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Completion += x, x => This.Completion -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.MediaPlayer.ErrorEventArgs> Error {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.MediaPlayer.ErrorEventArgs>, Android.Media.MediaPlayer.ErrorEventArgs>(x => This.Error += x, x => This.Error -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.MediaPlayer.InfoEventArgs> Info {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.MediaPlayer.InfoEventArgs>, Android.Media.MediaPlayer.InfoEventArgs>(x => This.Info += x, x => This.Info -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Prepared {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Prepared += x, x => This.Prepared -= x).Select(x => x.EventArgs); }
        }

    }
    public class ZoomButtonsControllerEvents
    {
        ZoomButtonsController This;

        public ZoomButtonsControllerEvents(ZoomButtonsController This)
        {
            this.This = This;
        }

        public IObservable<Android.Widget.ZoomButtonsController.VisibilityChangedEventArgs> VisibilityChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.ZoomButtonsController.VisibilityChangedEventArgs>, Android.Widget.ZoomButtonsController.VisibilityChangedEventArgs>(x => This.VisibilityChanged += x, x => This.VisibilityChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Widget.ZoomButtonsController.ZoomEventArgs> Zoom {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Widget.ZoomButtonsController.ZoomEventArgs>, Android.Widget.ZoomButtonsController.ZoomEventArgs>(x => This.Zoom += x, x => This.Zoom -= x).Select(x => x.EventArgs); }
        }

    }
    public class ZoomControlsEvents
        : Android.Views.ViewGroupEvents
    {
        ZoomControls This;

        public ZoomControlsEvents(ZoomControls This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ZoomInClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ZoomInClick += x, x => This.ZoomInClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ZoomOutClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ZoomOutClick += x, x => This.ZoomOutClick -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Content
{
    public static class EventsMixin
    {
        public static ClipboardManagerEvents Events(this ClipboardManager This)
        {
            return new ClipboardManagerEvents(This);
        }
    }

    public class ClipboardManagerEvents
    {
        ClipboardManager This;

        public ClipboardManagerEvents(ClipboardManager This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> PrimaryClipChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PrimaryClipChanged += x, x => This.PrimaryClipChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Drm
{
    public static class EventsMixin
    {
        public static DrmManagerClientEvents Events(this DrmManagerClient This)
        {
            return new DrmManagerClientEvents(This);
        }
    }

    public class DrmManagerClientEvents
    {
        DrmManagerClient This;

        public DrmManagerClientEvents(DrmManagerClient This)
        {
            this.This = This;
        }

        public IObservable<Android.Drm.DrmManagerClient.ErrorEventArgs> Error {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Drm.DrmManagerClient.ErrorEventArgs>, Android.Drm.DrmManagerClient.ErrorEventArgs>(x => This.Error += x, x => This.Error -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Drm.DrmManagerClient.EventEventArgs> Event {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Drm.DrmManagerClient.EventEventArgs>, Android.Drm.DrmManagerClient.EventEventArgs>(x => This.Event += x, x => This.Event -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Drm.DrmManagerClient.InfoEventArgs> Info {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Drm.DrmManagerClient.InfoEventArgs>, Android.Drm.DrmManagerClient.InfoEventArgs>(x => This.Info += x, x => This.Info -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Gestures
{
    public static class EventsMixin
    {
        public static GestureOverlayViewEvents Events(this GestureOverlayView This)
        {
            return new GestureOverlayViewEvents(This);
        }
    }

    public class GestureOverlayViewEvents
        : Android.Views.ViewGroupEvents
    {
        GestureOverlayView This;

        public GestureOverlayViewEvents(GestureOverlayView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Gestures.GestureOverlayView.GestureEventArgs> GestureEvent {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Gestures.GestureOverlayView.GestureEventArgs>, Android.Gestures.GestureOverlayView.GestureEventArgs>(x => This.GestureEvent += x, x => This.GestureEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Gestures.GestureOverlayView.GestureCancelledEventArgs> GestureCancelled {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Gestures.GestureOverlayView.GestureCancelledEventArgs>, Android.Gestures.GestureOverlayView.GestureCancelledEventArgs>(x => This.GestureCancelled += x, x => This.GestureCancelled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Gestures.GestureOverlayView.GestureEndedEventArgs> GestureEnded {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Gestures.GestureOverlayView.GestureEndedEventArgs>, Android.Gestures.GestureOverlayView.GestureEndedEventArgs>(x => This.GestureEnded += x, x => This.GestureEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Gestures.GestureOverlayView.GestureStartedEventArgs> GestureStarted {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Gestures.GestureOverlayView.GestureStartedEventArgs>, Android.Gestures.GestureOverlayView.GestureStartedEventArgs>(x => This.GestureStarted += x, x => This.GestureStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Gestures.GestureOverlayView.GesturePerformedEventArgs> GesturePerformed {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Gestures.GestureOverlayView.GesturePerformedEventArgs>, Android.Gestures.GestureOverlayView.GesturePerformedEventArgs>(x => This.GesturePerformed += x, x => This.GesturePerformed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Gestures.GestureOverlayView.GesturingEndedEventArgs> GesturingEnded {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Gestures.GestureOverlayView.GesturingEndedEventArgs>, Android.Gestures.GestureOverlayView.GesturingEndedEventArgs>(x => This.GesturingEnded += x, x => This.GesturingEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Gestures.GestureOverlayView.GesturingStartedEventArgs> GesturingStarted {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Gestures.GestureOverlayView.GesturingStartedEventArgs>, Android.Gestures.GestureOverlayView.GesturingStartedEventArgs>(x => This.GesturingStarted += x, x => This.GesturingStarted -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Graphics
{
    public static class EventsMixin
    {
        public static SurfaceTextureEvents Events(this SurfaceTexture This)
        {
            return new SurfaceTextureEvents(This);
        }
    }

    public class SurfaceTextureEvents
    {
        SurfaceTexture This;

        public SurfaceTextureEvents(SurfaceTexture This)
        {
            this.This = This;
        }

        public IObservable<Android.Graphics.SurfaceTexture.FrameAvailableEventArgs> FrameAvailable {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Graphics.SurfaceTexture.FrameAvailableEventArgs>, Android.Graphics.SurfaceTexture.FrameAvailableEventArgs>(x => This.FrameAvailable += x, x => This.FrameAvailable -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Hardware
{
    public static class EventsMixin
    {
        public static CameraEvents Events(this Camera This)
        {
            return new CameraEvents(This);
        }
    }

    public class CameraEvents
    {
        Camera This;

        public CameraEvents(Camera This)
        {
            this.This = This;
        }

        public IObservable<Android.Hardware.Camera.FaceDetectionEventArgs> FaceDetection {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Hardware.Camera.FaceDetectionEventArgs>, Android.Hardware.Camera.FaceDetectionEventArgs>(x => This.FaceDetection += x, x => This.FaceDetection -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Hardware.Camera.ZoomChangeEventArgs> ZoomChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Hardware.Camera.ZoomChangeEventArgs>, Android.Hardware.Camera.ZoomChangeEventArgs>(x => This.ZoomChange += x, x => This.ZoomChange -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Media.Audiofx
{
    public static class EventsMixin
    {
        public static AudioEffectEvents Events(this AudioEffect This)
        {
            return new AudioEffectEvents(This);
        }
        public static BassBoostEvents Events(this BassBoost This)
        {
            return new BassBoostEvents(This);
        }
        public static EnvironmentalReverbEvents Events(this EnvironmentalReverb This)
        {
            return new EnvironmentalReverbEvents(This);
        }
        public static EqualizerEvents Events(this Equalizer This)
        {
            return new EqualizerEvents(This);
        }
        public static PresetReverbEvents Events(this PresetReverb This)
        {
            return new PresetReverbEvents(This);
        }
        public static VirtualizerEvents Events(this Virtualizer This)
        {
            return new VirtualizerEvents(This);
        }
    }

    public class AudioEffectEvents
    {
        AudioEffect This;

        public AudioEffectEvents(AudioEffect This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.Audiofx.AudioEffect.ControlStatusChangeEventArgs> ControlStatus {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.Audiofx.AudioEffect.ControlStatusChangeEventArgs>, Android.Media.Audiofx.AudioEffect.ControlStatusChangeEventArgs>(x => This.ControlStatus += x, x => This.ControlStatus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Media.Audiofx.AudioEffect.EnableStatusChangeEventArgs> EnableStatus {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.Audiofx.AudioEffect.EnableStatusChangeEventArgs>, Android.Media.Audiofx.AudioEffect.EnableStatusChangeEventArgs>(x => This.EnableStatus += x, x => This.EnableStatus -= x).Select(x => x.EventArgs); }
        }

    }
    public class BassBoostEvents
        : Android.Media.Audiofx.AudioEffectEvents
    {
        BassBoost This;

        public BassBoostEvents(BassBoost This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.Audiofx.BassBoost.ParameterChangeEventArgs> Parameter {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.Audiofx.BassBoost.ParameterChangeEventArgs>, Android.Media.Audiofx.BassBoost.ParameterChangeEventArgs>(x => This.Parameter += x, x => This.Parameter -= x).Select(x => x.EventArgs); }
        }

    }
    public class EnvironmentalReverbEvents
        : Android.Media.Audiofx.AudioEffectEvents
    {
        EnvironmentalReverb This;

        public EnvironmentalReverbEvents(EnvironmentalReverb This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.Audiofx.EnvironmentalReverb.ParameterChangeEventArgs> Parameter {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.Audiofx.EnvironmentalReverb.ParameterChangeEventArgs>, Android.Media.Audiofx.EnvironmentalReverb.ParameterChangeEventArgs>(x => This.Parameter += x, x => This.Parameter -= x).Select(x => x.EventArgs); }
        }

    }
    public class EqualizerEvents
        : Android.Media.Audiofx.AudioEffectEvents
    {
        Equalizer This;

        public EqualizerEvents(Equalizer This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.Audiofx.Equalizer.ParameterChangeEventArgs> Parameter {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.Audiofx.Equalizer.ParameterChangeEventArgs>, Android.Media.Audiofx.Equalizer.ParameterChangeEventArgs>(x => This.Parameter += x, x => This.Parameter -= x).Select(x => x.EventArgs); }
        }

    }
    public class PresetReverbEvents
        : Android.Media.Audiofx.AudioEffectEvents
    {
        PresetReverb This;

        public PresetReverbEvents(PresetReverb This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.Audiofx.PresetReverb.ParameterChangeEventArgs> Parameter {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.Audiofx.PresetReverb.ParameterChangeEventArgs>, Android.Media.Audiofx.PresetReverb.ParameterChangeEventArgs>(x => This.Parameter += x, x => This.Parameter -= x).Select(x => x.EventArgs); }
        }

    }
    public class VirtualizerEvents
        : Android.Media.Audiofx.AudioEffectEvents
    {
        Virtualizer This;

        public VirtualizerEvents(Virtualizer This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.Audiofx.Virtualizer.ParameterChangeEventArgs> Parameter {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.Audiofx.Virtualizer.ParameterChangeEventArgs>, Android.Media.Audiofx.Virtualizer.ParameterChangeEventArgs>(x => This.Parameter += x, x => This.Parameter -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Media.Effect
{
    public static class EventsMixin
    {
        public static EffectEvents Events(this Effect This)
        {
            return new EffectEvents(This);
        }
    }

    public class EffectEvents
    {
        Effect This;

        public EffectEvents(Effect This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.Effect.EffectUpdateEventArgs> Update {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.Effect.EffectUpdateEventArgs>, Android.Media.Effect.EffectUpdateEventArgs>(x => This.Update += x, x => This.Update -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Media.TV
{
    public static class EventsMixin
    {
        public static TvViewEvents Events(this TvView This)
        {
            return new TvViewEvents(This);
        }
    }

    public class TvViewEvents
        : Android.Views.ViewGroupEvents
    {
        TvView This;

        public TvViewEvents(TvView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Media.TV.TvView.UnhandledInputEventEventArgs> UnhandledInputEvent {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Media.TV.TvView.UnhandledInputEventEventArgs>, Android.Media.TV.TvView.UnhandledInputEventEventArgs>(x => This.UnhandledInputEvent += x, x => This.UnhandledInputEvent -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.OS
{
    public static class EventsMixin
    {
        public static CancellationSignalEvents Events(this CancellationSignal This)
        {
            return new CancellationSignalEvents(This);
        }
    }

    public class CancellationSignalEvents
    {
        CancellationSignal This;

        public CancellationSignalEvents(CancellationSignal This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> CancelEvent {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CancelEvent += x, x => This.CancelEvent -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Preferences
{
    public static class EventsMixin
    {
        public static PreferenceEvents Events(this Preference This)
        {
            return new PreferenceEvents(This);
        }
    }

    public class PreferenceEvents
    {
        Preference This;

        public PreferenceEvents(Preference This)
        {
            this.This = This;
        }

        public IObservable<Android.Preferences.Preference.PreferenceChangeEventArgs> PreferenceChange {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Preferences.Preference.PreferenceChangeEventArgs>, Android.Preferences.Preference.PreferenceChangeEventArgs>(x => This.PreferenceChange += x, x => This.PreferenceChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Preferences.Preference.PreferenceClickEventArgs> PreferenceClick {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Preferences.Preference.PreferenceClickEventArgs>, Android.Preferences.Preference.PreferenceClickEventArgs>(x => This.PreferenceClick += x, x => This.PreferenceClick -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Renderscripts
{
    public static class EventsMixin
    {
        public static AllocationEvents Events(this Allocation This)
        {
            return new AllocationEvents(This);
        }
    }

    public class AllocationEvents
    {
        Allocation This;

        public AllocationEvents(Allocation This)
        {
            this.This = This;
        }

        public IObservable<Android.Renderscripts.Allocation.BufferAvailableEventArgs> BufferAvailable {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Renderscripts.Allocation.BufferAvailableEventArgs>, Android.Renderscripts.Allocation.BufferAvailableEventArgs>(x => This.BufferAvailable += x, x => This.BufferAvailable -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Sax
{
    public static class EventsMixin
    {
        public static ElementEvents Events(this Element This)
        {
            return new ElementEvents(This);
        }
    }

    public class ElementEvents
    {
        Element This;

        public ElementEvents(Element This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> EndElement {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EndElement += x, x => This.EndElement -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Sax.EndTextElementEventArgs> EndTextElement {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Sax.EndTextElementEventArgs>, Android.Sax.EndTextElementEventArgs>(x => This.EndTextElement += x, x => This.EndTextElement -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Sax.StartElementEventArgs> StartElement {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Sax.StartElementEventArgs>, Android.Sax.StartElementEventArgs>(x => This.StartElement += x, x => This.StartElement -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Speech
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

        public IObservable<System.EventArgs> BeginningOfSpeech {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.BeginningOfSpeech += x, x => This.BeginningOfSpeech -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Speech.BufferReceivedEventArgs> BufferReceived {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Speech.BufferReceivedEventArgs>, Android.Speech.BufferReceivedEventArgs>(x => This.BufferReceived += x, x => This.BufferReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EndOfSpeech {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EndOfSpeech += x, x => This.EndOfSpeech -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Speech.ErrorEventArgs> Error {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Speech.ErrorEventArgs>, Android.Speech.ErrorEventArgs>(x => This.Error += x, x => This.Error -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Speech.EventEventArgs> Event {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Speech.EventEventArgs>, Android.Speech.EventEventArgs>(x => This.Event += x, x => This.Event -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Speech.PartialResultsEventArgs> PartialResults {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Speech.PartialResultsEventArgs>, Android.Speech.PartialResultsEventArgs>(x => This.PartialResults += x, x => This.PartialResults -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Speech.ReadyForSpeechEventArgs> ReadyForSpeech {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Speech.ReadyForSpeechEventArgs>, Android.Speech.ReadyForSpeechEventArgs>(x => This.ReadyForSpeech += x, x => This.ReadyForSpeech -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Speech.ResultsEventArgs> Results {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Speech.ResultsEventArgs>, Android.Speech.ResultsEventArgs>(x => This.Results += x, x => This.Results -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Speech.RmsChangedEventArgs> RmsChanged {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Speech.RmsChangedEventArgs>, Android.Speech.RmsChangedEventArgs>(x => This.RmsChanged += x, x => This.RmsChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Views.Animations
{
    public static class EventsMixin
    {
        public static AnimationEvents Events(this Animation This)
        {
            return new AnimationEvents(This);
        }
    }

    public class AnimationEvents
    {
        Animation This;

        public AnimationEvents(Animation This)
        {
            this.This = This;
        }

        public IObservable<Android.Views.Animations.Animation.AnimationEndEventArgs> AnimationEnd {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.Animations.Animation.AnimationEndEventArgs>, Android.Views.Animations.Animation.AnimationEndEventArgs>(x => This.AnimationEnd += x, x => This.AnimationEnd -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.Animations.Animation.AnimationRepeatEventArgs> AnimationRepeat {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.Animations.Animation.AnimationRepeatEventArgs>, Android.Views.Animations.Animation.AnimationRepeatEventArgs>(x => This.AnimationRepeat += x, x => This.AnimationRepeat -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Views.Animations.Animation.AnimationStartEventArgs> AnimationStart {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Views.Animations.Animation.AnimationStartEventArgs>, Android.Views.Animations.Animation.AnimationStartEventArgs>(x => This.AnimationStart += x, x => This.AnimationStart -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Android.Webkit
{
    public static class EventsMixin
    {
        public static WebViewEvents Events(this WebView This)
        {
            return new WebViewEvents(This);
        }
    }

    public class WebViewEvents
        : Android.Views.ViewGroupEvents
    {
        WebView This;

        public WebViewEvents(WebView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<Android.Webkit.DownloadEventArgs> Download {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Webkit.DownloadEventArgs>, Android.Webkit.DownloadEventArgs>(x => This.Download += x, x => This.Download -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Webkit.WebView.FindEventArgs> Find {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Webkit.WebView.FindEventArgs>, Android.Webkit.WebView.FindEventArgs>(x => This.Find += x, x => This.Find -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Android.Webkit.WebView.PictureEventArgs> Picture {
            get { return Observable.FromEventPattern<System.EventHandler<Android.Webkit.WebView.PictureEventArgs>, Android.Webkit.WebView.PictureEventArgs>(x => This.Picture += x, x => This.Picture -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Javax.Xml.Transform
{
    public static class EventsMixin
    {
        public static TransformerEvents Events(this Transformer This)
        {
            return new TransformerEvents(This);
        }
        public static TransformerFactoryEvents Events(this TransformerFactory This)
        {
            return new TransformerFactoryEvents(This);
        }
    }

    public class TransformerEvents
    {
        Transformer This;

        public TransformerEvents(Transformer This)
        {
            this.This = This;
        }

        public IObservable<Javax.Xml.Transform.ErrorEventArgs> Error {
            get { return Observable.FromEventPattern<System.EventHandler<Javax.Xml.Transform.ErrorEventArgs>, Javax.Xml.Transform.ErrorEventArgs>(x => This.Error += x, x => This.Error -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Javax.Xml.Transform.FatalErrorEventArgs> FatalError {
            get { return Observable.FromEventPattern<System.EventHandler<Javax.Xml.Transform.FatalErrorEventArgs>, Javax.Xml.Transform.FatalErrorEventArgs>(x => This.FatalError += x, x => This.FatalError -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Javax.Xml.Transform.WarningEventArgs> Warning {
            get { return Observable.FromEventPattern<System.EventHandler<Javax.Xml.Transform.WarningEventArgs>, Javax.Xml.Transform.WarningEventArgs>(x => This.Warning += x, x => This.Warning -= x).Select(x => x.EventArgs); }
        }

    }
    public class TransformerFactoryEvents
    {
        TransformerFactory This;

        public TransformerFactoryEvents(TransformerFactory This)
        {
            this.This = This;
        }

        public IObservable<Javax.Xml.Transform.ErrorEventArgs> Error {
            get { return Observable.FromEventPattern<System.EventHandler<Javax.Xml.Transform.ErrorEventArgs>, Javax.Xml.Transform.ErrorEventArgs>(x => This.Error += x, x => This.Error -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Javax.Xml.Transform.FatalErrorEventArgs> FatalError {
            get { return Observable.FromEventPattern<System.EventHandler<Javax.Xml.Transform.FatalErrorEventArgs>, Javax.Xml.Transform.FatalErrorEventArgs>(x => This.FatalError += x, x => This.FatalError -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Javax.Xml.Transform.WarningEventArgs> Warning {
            get { return Observable.FromEventPattern<System.EventHandler<Javax.Xml.Transform.WarningEventArgs>, Javax.Xml.Transform.WarningEventArgs>(x => This.Warning += x, x => This.Warning -= x).Select(x => x.EventArgs); }
        }

    }
}


#pragma warning restore 1591,0618,0105,0672

#pragma warning disable 1591,0618,0105,0672

using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using ReactiveUI.Events;

using WebKit;
using MapKit;
using AVFoundation;
using CoreFoundation;
using Foundation;
using AppKit;
using GameKit;
using CoreLocation;
using AudioToolbox;
using CoreAnimation;
using CoreBluetooth;
using NotificationCenter;
using PdfKit;
using CoreServices;
using QTKit;
using SceneKit;
using ImageKit;
using SpriteKit;
using StoreKit;
using CoreMidi;
using AVFoundation;
using WebKit;
using MapKit;
using MetalKit;
using AppKit;
using CoreLocation;
using MultipeerConnectivity;
using Foundation;
using CoreAnimation;
using NetworkExtension;
using NotificationCenter;
using PdfKit;
using QTKit;
using QuickLookUI;
using SceneKit;
using ContactsUI;
using CoreBluetooth;
using GameKit;
using GameplayKit;
using ImageKit;
using SpriteKit;
using StoreKit;

namespace WebKit
{
    public static class EventsMixin
    {
        public static WebViewEvents Events(this WebView This)
        {
            return new WebViewEvents(This);
        }
    }

    public class WebViewEvents
    {
        WebView This;

        public WebViewEvents(WebView This)
        {
            this.This = This;
        }

        public IObservable<WebKit.WebFrameEventArgs> CanceledClientRedirect {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameEventArgs>, WebKit.WebFrameEventArgs>(x => This.CanceledClientRedirect += x, x => This.CanceledClientRedirect -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameEventArgs> ChangedLocationWithinPage {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameEventArgs>, WebKit.WebFrameEventArgs>(x => This.ChangedLocationWithinPage += x, x => This.ChangedLocationWithinPage -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameScriptFrameEventArgs> ClearedWindowObject {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameScriptFrameEventArgs>, WebKit.WebFrameScriptFrameEventArgs>(x => This.ClearedWindowObject += x, x => This.ClearedWindowObject -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameEventArgs> CommitedLoad {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameEventArgs>, WebKit.WebFrameEventArgs>(x => This.CommitedLoad += x, x => This.CommitedLoad -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameErrorEventArgs> FailedLoadWithError {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameErrorEventArgs>, WebKit.WebFrameErrorEventArgs>(x => This.FailedLoadWithError += x, x => This.FailedLoadWithError -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameErrorEventArgs> FailedProvisionalLoad {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameErrorEventArgs>, WebKit.WebFrameErrorEventArgs>(x => This.FailedProvisionalLoad += x, x => This.FailedProvisionalLoad -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameEventArgs> FinishedLoad {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameEventArgs>, WebKit.WebFrameEventArgs>(x => This.FinishedLoad += x, x => This.FinishedLoad -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameImageEventArgs> ReceivedIcon {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameImageEventArgs>, WebKit.WebFrameImageEventArgs>(x => This.ReceivedIcon += x, x => This.ReceivedIcon -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameEventArgs> ReceivedServerRedirectForProvisionalLoad {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameEventArgs>, WebKit.WebFrameEventArgs>(x => This.ReceivedServerRedirectForProvisionalLoad += x, x => This.ReceivedServerRedirectForProvisionalLoad -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameTitleEventArgs> ReceivedTitle {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameTitleEventArgs>, WebKit.WebFrameTitleEventArgs>(x => This.ReceivedTitle += x, x => This.ReceivedTitle -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameEventArgs> StartedProvisionalLoad {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameEventArgs>, WebKit.WebFrameEventArgs>(x => This.StartedProvisionalLoad += x, x => This.StartedProvisionalLoad -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameEventArgs> WillCloseFrame {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameEventArgs>, WebKit.WebFrameEventArgs>(x => This.WillCloseFrame += x, x => This.WillCloseFrame -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameClientRedirectEventArgs> WillPerformClientRedirect {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameClientRedirectEventArgs>, WebKit.WebFrameClientRedirectEventArgs>(x => This.WillPerformClientRedirect += x, x => This.WillPerformClientRedirect -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFrameScriptObjectEventArgs> WindowScriptObjectAvailable {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFrameScriptObjectEventArgs>, WebKit.WebFrameScriptObjectEventArgs>(x => This.WindowScriptObjectAvailable += x, x => This.WindowScriptObjectAvailable -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebMimeTypePolicyEventArgs> DecidePolicyForMimeType {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebMimeTypePolicyEventArgs>, WebKit.WebMimeTypePolicyEventArgs>(x => This.DecidePolicyForMimeType += x, x => This.DecidePolicyForMimeType -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebNavigationPolicyEventArgs> DecidePolicyForNavigation {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebNavigationPolicyEventArgs>, WebKit.WebNavigationPolicyEventArgs>(x => This.DecidePolicyForNavigation += x, x => This.DecidePolicyForNavigation -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebNewWindowPolicyEventArgs> DecidePolicyForNewWindow {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebNewWindowPolicyEventArgs>, WebKit.WebNewWindowPolicyEventArgs>(x => This.DecidePolicyForNewWindow += x, x => This.DecidePolicyForNewWindow -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebFailureToImplementPolicyEventArgs> UnableToImplementPolicy {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebFailureToImplementPolicyEventArgs>, WebKit.WebFailureToImplementPolicyEventArgs>(x => This.UnableToImplementPolicy += x, x => This.UnableToImplementPolicy -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebResourceCancelledChallengeEventArgs> OnCancelledAuthenticationChallenge {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebResourceCancelledChallengeEventArgs>, WebKit.WebResourceCancelledChallengeEventArgs>(x => This.OnCancelledAuthenticationChallenge += x, x => This.OnCancelledAuthenticationChallenge -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebResourceErrorEventArgs> OnFailedLoading {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebResourceErrorEventArgs>, WebKit.WebResourceErrorEventArgs>(x => This.OnFailedLoading += x, x => This.OnFailedLoading -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebResourceCompletedEventArgs> OnFinishedLoading {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebResourceCompletedEventArgs>, WebKit.WebResourceCompletedEventArgs>(x => This.OnFinishedLoading += x, x => This.OnFinishedLoading -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebResourcePluginErrorEventArgs> OnPlugInFailed {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebResourcePluginErrorEventArgs>, WebKit.WebResourcePluginErrorEventArgs>(x => This.OnPlugInFailed += x, x => This.OnPlugInFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebResourceAuthenticationChallengeEventArgs> OnReceivedAuthenticationChallenge {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebResourceAuthenticationChallengeEventArgs>, WebKit.WebResourceAuthenticationChallengeEventArgs>(x => This.OnReceivedAuthenticationChallenge += x, x => This.OnReceivedAuthenticationChallenge -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebResourceReceivedContentLengthEventArgs> OnReceivedContentLength {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebResourceReceivedContentLengthEventArgs>, WebKit.WebResourceReceivedContentLengthEventArgs>(x => This.OnReceivedContentLength += x, x => This.OnReceivedContentLength -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebResourceReceivedResponseEventArgs> OnReceivedResponse {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebResourceReceivedResponseEventArgs>, WebKit.WebResourceReceivedResponseEventArgs>(x => This.OnReceivedResponse += x, x => This.OnReceivedResponse -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> UIClose {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.UIClose += x, x => This.UIClose -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewFooterEventArgs> UIDrawFooterInRect {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewFooterEventArgs>, WebKit.WebViewFooterEventArgs>(x => This.UIDrawFooterInRect += x, x => This.UIDrawFooterInRect -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewHeaderEventArgs> UIDrawHeaderInRect {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewHeaderEventArgs>, WebKit.WebViewHeaderEventArgs>(x => This.UIDrawHeaderInRect += x, x => This.UIDrawHeaderInRect -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> UIFocus {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.UIFocus += x, x => This.UIFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewResponderEventArgs> UIMakeFirstResponder {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewResponderEventArgs>, WebKit.WebViewResponderEventArgs>(x => This.UIMakeFirstResponder += x, x => This.UIMakeFirstResponder -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewMouseMovedEventArgs> UIMouseDidMoveOverElement {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewMouseMovedEventArgs>, WebKit.WebViewMouseMovedEventArgs>(x => This.UIMouseDidMoveOverElement += x, x => This.UIMouseDidMoveOverElement -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewPrintEventArgs> UIPrintFrameView {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewPrintEventArgs>, WebKit.WebViewPrintEventArgs>(x => This.UIPrintFrameView += x, x => This.UIPrintFrameView -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewJavaScriptEventArgs> UIRunJavaScriptAlertPanel {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewJavaScriptEventArgs>, WebKit.WebViewJavaScriptEventArgs>(x => This.UIRunJavaScriptAlertPanel += x, x => This.UIRunJavaScriptAlertPanel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewJavaScriptFrameEventArgs> UIRunJavaScriptAlertPanelMessage {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewJavaScriptFrameEventArgs>, WebKit.WebViewJavaScriptFrameEventArgs>(x => This.UIRunJavaScriptAlertPanelMessage += x, x => This.UIRunJavaScriptAlertPanelMessage -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> UIRunModal {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.UIRunModal += x, x => This.UIRunModal -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewRunOpenPanelEventArgs> UIRunOpenPanelForFileButton {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewRunOpenPanelEventArgs>, WebKit.WebViewRunOpenPanelEventArgs>(x => This.UIRunOpenPanelForFileButton += x, x => This.UIRunOpenPanelForFileButton -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewContentEventArgs> UISetContentRect {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewContentEventArgs>, WebKit.WebViewContentEventArgs>(x => This.UISetContentRect += x, x => This.UISetContentRect -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewFrameEventArgs> UISetFrame {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewFrameEventArgs>, WebKit.WebViewFrameEventArgs>(x => This.UISetFrame += x, x => This.UISetFrame -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewResizableEventArgs> UISetResizable {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewResizableEventArgs>, WebKit.WebViewResizableEventArgs>(x => This.UISetResizable += x, x => This.UISetResizable -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewStatusBarEventArgs> UISetStatusBarVisible {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewStatusBarEventArgs>, WebKit.WebViewStatusBarEventArgs>(x => This.UISetStatusBarVisible += x, x => This.UISetStatusBarVisible -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewStatusTextEventArgs> UISetStatusText {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewStatusTextEventArgs>, WebKit.WebViewStatusTextEventArgs>(x => This.UISetStatusText += x, x => This.UISetStatusText -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewToolBarsEventArgs> UISetToolbarsVisible {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewToolBarsEventArgs>, WebKit.WebViewToolBarsEventArgs>(x => This.UISetToolbarsVisible += x, x => This.UISetToolbarsVisible -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> UIShow {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.UIShow += x, x => This.UIShow -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> UIUnfocus {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.UIUnfocus += x, x => This.UIUnfocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewDragEventArgs> UIWillPerformDragDestination {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewDragEventArgs>, WebKit.WebViewDragEventArgs>(x => This.UIWillPerformDragDestination += x, x => This.UIWillPerformDragDestination -= x).Select(x => x.EventArgs); }
        }

        public IObservable<WebKit.WebViewPerformDragEventArgs> UIWillPerformDragSource {
            get { return Observable.FromEventPattern<System.EventHandler<WebKit.WebViewPerformDragEventArgs>, WebKit.WebViewPerformDragEventArgs>(x => This.UIWillPerformDragSource += x, x => This.UIWillPerformDragSource -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace MapKit
{
    public static class EventsMixin
    {
        public static MKMapViewEvents Events(this MKMapView This)
        {
            return new MKMapViewEvents(This);
        }
    }

    public class MKMapViewEvents
    {
        MKMapView This;

        public MKMapViewEvents(MKMapView This)
        {
            this.This = This;
        }

        public IObservable<MapKit.MKMapViewDragStateEventArgs> ChangedDragState {
            get { return Observable.FromEventPattern<System.EventHandler<MapKit.MKMapViewDragStateEventArgs>, MapKit.MKMapViewDragStateEventArgs>(x => This.ChangedDragState += x, x => This.ChangedDragState -= x).Select(x => x.EventArgs); }
        }

        public IObservable<MapKit.MKMapViewAnnotationEventArgs> DidAddAnnotationViews {
            get { return Observable.FromEventPattern<System.EventHandler<MapKit.MKMapViewAnnotationEventArgs>, MapKit.MKMapViewAnnotationEventArgs>(x => This.DidAddAnnotationViews += x, x => This.DidAddAnnotationViews -= x).Select(x => x.EventArgs); }
        }

        public IObservable<MapKit.MKDidAddOverlayRenderersEventArgs> DidAddOverlayRenderers {
            get { return Observable.FromEventPattern<System.EventHandler<MapKit.MKDidAddOverlayRenderersEventArgs>, MapKit.MKDidAddOverlayRenderersEventArgs>(x => This.DidAddOverlayRenderers += x, x => This.DidAddOverlayRenderers -= x).Select(x => x.EventArgs); }
        }

        public IObservable<MapKit.MKAnnotationViewEventArgs> DidDeselectAnnotationView {
            get { return Observable.FromEventPattern<System.EventHandler<MapKit.MKAnnotationViewEventArgs>, MapKit.MKAnnotationViewEventArgs>(x => This.DidDeselectAnnotationView += x, x => This.DidDeselectAnnotationView -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSErrorEventArgs> DidFailToLocateUser {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSErrorEventArgs>, Foundation.NSErrorEventArgs>(x => This.DidFailToLocateUser += x, x => This.DidFailToLocateUser -= x).Select(x => x.EventArgs); }
        }

        public IObservable<MapKit.MKDidFinishRenderingMapEventArgs> DidFinishRenderingMap {
            get { return Observable.FromEventPattern<System.EventHandler<MapKit.MKDidFinishRenderingMapEventArgs>, MapKit.MKDidFinishRenderingMapEventArgs>(x => This.DidFinishRenderingMap += x, x => This.DidFinishRenderingMap -= x).Select(x => x.EventArgs); }
        }

        public IObservable<MapKit.MKAnnotationViewEventArgs> DidSelectAnnotationView {
            get { return Observable.FromEventPattern<System.EventHandler<MapKit.MKAnnotationViewEventArgs>, MapKit.MKAnnotationViewEventArgs>(x => This.DidSelectAnnotationView += x, x => This.DidSelectAnnotationView -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidStopLocatingUser {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidStopLocatingUser += x, x => This.DidStopLocatingUser -= x).Select(x => x.EventArgs); }
        }

        public IObservable<MapKit.MKUserLocationEventArgs> DidUpdateUserLocation {
            get { return Observable.FromEventPattern<System.EventHandler<MapKit.MKUserLocationEventArgs>, MapKit.MKUserLocationEventArgs>(x => This.DidUpdateUserLocation += x, x => This.DidUpdateUserLocation -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSErrorEventArgs> LoadingMapFailed {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSErrorEventArgs>, Foundation.NSErrorEventArgs>(x => This.LoadingMapFailed += x, x => This.LoadingMapFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> MapLoaded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.MapLoaded += x, x => This.MapLoaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<MapKit.MKMapViewChangeEventArgs> RegionChanged {
            get { return Observable.FromEventPattern<System.EventHandler<MapKit.MKMapViewChangeEventArgs>, MapKit.MKMapViewChangeEventArgs>(x => This.RegionChanged += x, x => This.RegionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<MapKit.MKMapViewChangeEventArgs> RegionWillChange {
            get { return Observable.FromEventPattern<System.EventHandler<MapKit.MKMapViewChangeEventArgs>, MapKit.MKMapViewChangeEventArgs>(x => This.RegionWillChange += x, x => This.RegionWillChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillStartLoadingMap {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillStartLoadingMap += x, x => This.WillStartLoadingMap -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillStartLocatingUser {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillStartLocatingUser += x, x => This.WillStartLocatingUser -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillStartRenderingMap {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillStartRenderingMap += x, x => This.WillStartRenderingMap -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace AVFoundation
{
    public static class EventsMixin
    {
        public static AVAudioPlayerEvents Events(this AVAudioPlayer This)
        {
            return new AVAudioPlayerEvents(This);
        }
        public static AVAudioRecorderEvents Events(this AVAudioRecorder This)
        {
            return new AVAudioRecorderEvents(This);
        }
    }

    public class AVAudioPlayerEvents
    {
        AVAudioPlayer This;

        public AVAudioPlayerEvents(AVAudioPlayer This)
        {
            this.This = This;
        }

        public IObservable<AVFoundation.AVStatusEventArgs> FinishedPlaying {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVStatusEventArgs>, AVFoundation.AVStatusEventArgs>(x => This.FinishedPlaying += x, x => This.FinishedPlaying -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AVFoundation.AVErrorEventArgs> DecoderError {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVErrorEventArgs>, AVFoundation.AVErrorEventArgs>(x => This.DecoderError += x, x => This.DecoderError -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> BeginInterruption {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.BeginInterruption += x, x => This.BeginInterruption -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EndInterruption {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EndInterruption += x, x => This.EndInterruption -= x).Select(x => x.EventArgs); }
        }

    }
    public class AVAudioRecorderEvents
    {
        AVAudioRecorder This;

        public AVAudioRecorderEvents(AVAudioRecorder This)
        {
            this.This = This;
        }

        public IObservable<AVFoundation.AVStatusEventArgs> FinishedRecording {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVStatusEventArgs>, AVFoundation.AVStatusEventArgs>(x => This.FinishedRecording += x, x => This.FinishedRecording -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AVFoundation.AVErrorEventArgs> EncoderError {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVErrorEventArgs>, AVFoundation.AVErrorEventArgs>(x => This.EncoderError += x, x => This.EncoderError -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> BeginInterruption {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.BeginInterruption += x, x => This.BeginInterruption -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EndInterruption {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EndInterruption += x, x => This.EndInterruption -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace CoreFoundation
{
    public static class EventsMixin
    {
        public static CFSocketEvents Events(this CFSocket This)
        {
            return new CFSocketEvents(This);
        }
        public static CFStreamEvents Events(this CFStream This)
        {
            return new CFStreamEvents(This);
        }
    }

    public class CFSocketEvents
    {
        CFSocket This;

        public CFSocketEvents(CFSocket This)
        {
            this.This = This;
        }

        public IObservable<CoreFoundation.CFSocket.CFSocketAcceptEventArgs> AcceptEvent {
            get { return Observable.FromEventPattern<System.EventHandler<CoreFoundation.CFSocket.CFSocketAcceptEventArgs>, CoreFoundation.CFSocket.CFSocketAcceptEventArgs>(x => This.AcceptEvent += x, x => This.AcceptEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreFoundation.CFSocket.CFSocketConnectEventArgs> ConnectEvent {
            get { return Observable.FromEventPattern<System.EventHandler<CoreFoundation.CFSocket.CFSocketConnectEventArgs>, CoreFoundation.CFSocket.CFSocketConnectEventArgs>(x => This.ConnectEvent += x, x => This.ConnectEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreFoundation.CFSocket.CFSocketDataEventArgs> DataEvent {
            get { return Observable.FromEventPattern<System.EventHandler<CoreFoundation.CFSocket.CFSocketDataEventArgs>, CoreFoundation.CFSocket.CFSocketDataEventArgs>(x => This.DataEvent += x, x => This.DataEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreFoundation.CFSocket.CFSocketReadEventArgs> ReadEvent {
            get { return Observable.FromEventPattern<System.EventHandler<CoreFoundation.CFSocket.CFSocketReadEventArgs>, CoreFoundation.CFSocket.CFSocketReadEventArgs>(x => This.ReadEvent += x, x => This.ReadEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreFoundation.CFSocket.CFSocketWriteEventArgs> WriteEvent {
            get { return Observable.FromEventPattern<System.EventHandler<CoreFoundation.CFSocket.CFSocketWriteEventArgs>, CoreFoundation.CFSocket.CFSocketWriteEventArgs>(x => This.WriteEvent += x, x => This.WriteEvent -= x).Select(x => x.EventArgs); }
        }

    }
    public class CFStreamEvents
    {
        CFStream This;

        public CFStreamEvents(CFStream This)
        {
            this.This = This;
        }

        public IObservable<CoreFoundation.CFStream.StreamEventArgs> OpenCompletedEvent {
            get { return Observable.FromEventPattern<System.EventHandler<CoreFoundation.CFStream.StreamEventArgs>, CoreFoundation.CFStream.StreamEventArgs>(x => This.OpenCompletedEvent += x, x => This.OpenCompletedEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreFoundation.CFStream.StreamEventArgs> HasBytesAvailableEvent {
            get { return Observable.FromEventPattern<System.EventHandler<CoreFoundation.CFStream.StreamEventArgs>, CoreFoundation.CFStream.StreamEventArgs>(x => This.HasBytesAvailableEvent += x, x => This.HasBytesAvailableEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreFoundation.CFStream.StreamEventArgs> CanAcceptBytesEvent {
            get { return Observable.FromEventPattern<System.EventHandler<CoreFoundation.CFStream.StreamEventArgs>, CoreFoundation.CFStream.StreamEventArgs>(x => This.CanAcceptBytesEvent += x, x => This.CanAcceptBytesEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreFoundation.CFStream.StreamEventArgs> ErrorEvent {
            get { return Observable.FromEventPattern<System.EventHandler<CoreFoundation.CFStream.StreamEventArgs>, CoreFoundation.CFStream.StreamEventArgs>(x => This.ErrorEvent += x, x => This.ErrorEvent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreFoundation.CFStream.StreamEventArgs> ClosedEvent {
            get { return Observable.FromEventPattern<System.EventHandler<CoreFoundation.CFStream.StreamEventArgs>, CoreFoundation.CFStream.StreamEventArgs>(x => This.ClosedEvent += x, x => This.ClosedEvent -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Foundation
{
    public static class EventsMixin
    {
        public static NSKeyedArchiverEvents Events(this NSKeyedArchiver This)
        {
            return new NSKeyedArchiverEvents(This);
        }
        public static NSKeyedUnarchiverEvents Events(this NSKeyedUnarchiver This)
        {
            return new NSKeyedUnarchiverEvents(This);
        }
        public static NSNetServiceEvents Events(this NSNetService This)
        {
            return new NSNetServiceEvents(This);
        }
        public static NSStreamEvents Events(this NSStream This)
        {
            return new NSStreamEvents(This);
        }
        public static NSCacheEvents Events(this NSCache This)
        {
            return new NSCacheEvents(This);
        }
        public static NSNetServiceBrowserEvents Events(this NSNetServiceBrowser This)
        {
            return new NSNetServiceBrowserEvents(This);
        }
        public static NSUserNotificationCenterEvents Events(this NSUserNotificationCenter This)
        {
            return new NSUserNotificationCenterEvents(This);
        }
    }

    public class NSKeyedArchiverEvents
    {
        NSKeyedArchiver This;

        public NSKeyedArchiverEvents(NSKeyedArchiver This)
        {
            this.This = This;
        }

        public IObservable<Foundation.NSObjectEventArgs> EncodedObject {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSObjectEventArgs>, Foundation.NSObjectEventArgs>(x => This.EncodedObject += x, x => This.EncodedObject -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Finished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Finished += x, x => This.Finished -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Finishing {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Finishing += x, x => This.Finishing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSArchiveReplaceEventArgs> ReplacingObject {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSArchiveReplaceEventArgs>, Foundation.NSArchiveReplaceEventArgs>(x => This.ReplacingObject += x, x => This.ReplacingObject -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSKeyedUnarchiverEvents
    {
        NSKeyedUnarchiver This;

        public NSKeyedUnarchiverEvents(NSKeyedUnarchiver This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Finished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Finished += x, x => This.Finished -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Finishing {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Finishing += x, x => This.Finishing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSArchiveReplaceEventArgs> ReplacingObject {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSArchiveReplaceEventArgs>, Foundation.NSArchiveReplaceEventArgs>(x => This.ReplacingObject += x, x => This.ReplacingObject -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSNetServiceEvents
    {
        NSNetService This;

        public NSNetServiceEvents(NSNetService This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> AddressResolved {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AddressResolved += x, x => This.AddressResolved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSNetServiceConnectionEventArgs> DidAcceptConnection {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSNetServiceConnectionEventArgs>, Foundation.NSNetServiceConnectionEventArgs>(x => This.DidAcceptConnection += x, x => This.DidAcceptConnection -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Published {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Published += x, x => This.Published -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSNetServiceErrorEventArgs> PublishFailure {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSNetServiceErrorEventArgs>, Foundation.NSNetServiceErrorEventArgs>(x => This.PublishFailure += x, x => This.PublishFailure -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSNetServiceErrorEventArgs> ResolveFailure {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSNetServiceErrorEventArgs>, Foundation.NSNetServiceErrorEventArgs>(x => This.ResolveFailure += x, x => This.ResolveFailure -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Stopped {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Stopped += x, x => This.Stopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSNetServiceDataEventArgs> UpdatedTxtRecordData {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSNetServiceDataEventArgs>, Foundation.NSNetServiceDataEventArgs>(x => This.UpdatedTxtRecordData += x, x => This.UpdatedTxtRecordData -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillPublish {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillPublish += x, x => This.WillPublish -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillResolve {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillResolve += x, x => This.WillResolve -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSStreamEvents
    {
        NSStream This;

        public NSStreamEvents(NSStream This)
        {
            this.This = This;
        }

        public IObservable<Foundation.NSStreamEventArgs> OnEvent {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSStreamEventArgs>, Foundation.NSStreamEventArgs>(x => This.OnEvent += x, x => This.OnEvent -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSCacheEvents
    {
        NSCache This;

        public NSCacheEvents(NSCache This)
        {
            this.This = This;
        }

        public IObservable<Foundation.NSObjectEventArgs> WillEvictObject {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSObjectEventArgs>, Foundation.NSObjectEventArgs>(x => This.WillEvictObject += x, x => This.WillEvictObject -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSNetServiceBrowserEvents
    {
        NSNetServiceBrowser This;

        public NSNetServiceBrowserEvents(NSNetServiceBrowser This)
        {
            this.This = This;
        }

        public IObservable<Foundation.NSNetDomainEventArgs> DomainRemoved {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSNetDomainEventArgs>, Foundation.NSNetDomainEventArgs>(x => This.DomainRemoved += x, x => This.DomainRemoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSNetDomainEventArgs> FoundDomain {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSNetDomainEventArgs>, Foundation.NSNetDomainEventArgs>(x => This.FoundDomain += x, x => This.FoundDomain -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSNetServiceEventArgs> FoundService {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSNetServiceEventArgs>, Foundation.NSNetServiceEventArgs>(x => This.FoundService += x, x => This.FoundService -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSNetServiceErrorEventArgs> NotSearched {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSNetServiceErrorEventArgs>, Foundation.NSNetServiceErrorEventArgs>(x => This.NotSearched += x, x => This.NotSearched -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SearchStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SearchStarted += x, x => This.SearchStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SearchStopped {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SearchStopped += x, x => This.SearchStopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSNetServiceEventArgs> ServiceRemoved {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSNetServiceEventArgs>, Foundation.NSNetServiceEventArgs>(x => This.ServiceRemoved += x, x => This.ServiceRemoved -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSUserNotificationCenterEvents
    {
        NSUserNotificationCenter This;

        public NSUserNotificationCenterEvents(NSUserNotificationCenter This)
        {
            this.This = This;
        }

        public IObservable<Foundation.UNCDidActivateNotificationEventArgs> DidActivateNotification {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.UNCDidActivateNotificationEventArgs>, Foundation.UNCDidActivateNotificationEventArgs>(x => This.DidActivateNotification += x, x => This.DidActivateNotification -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.UNCDidDeliverNotificationEventArgs> DidDeliverNotification {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.UNCDidDeliverNotificationEventArgs>, Foundation.UNCDidDeliverNotificationEventArgs>(x => This.DidDeliverNotification += x, x => This.DidDeliverNotification -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace AppKit
{
    public static class EventsMixin
    {
        public static NSActionCellEvents Events(this NSActionCell This)
        {
            return new NSActionCellEvents(This);
        }
        public static NSAnimationEvents Events(this NSAnimation This)
        {
            return new NSAnimationEvents(This);
        }
        public static NSApplicationEvents Events(this NSApplication This)
        {
            return new NSApplicationEvents(This);
        }
        public static NSBrowserEvents Events(this NSBrowser This)
        {
            return new NSBrowserEvents(This);
        }
        public static NSMatrixEvents Events(this NSMatrix This)
        {
            return new NSMatrixEvents(This);
        }
        public static NSPathCellEvents Events(this NSPathCell This)
        {
            return new NSPathCellEvents(This);
        }
        public static NSPathControlEvents Events(this NSPathControl This)
        {
            return new NSPathControlEvents(This);
        }
        public static NSStatusItemEvents Events(this NSStatusItem This)
        {
            return new NSStatusItemEvents(This);
        }
        public static NSTableViewEvents Events(this NSTableView This)
        {
            return new NSTableViewEvents(This);
        }
        public static NSComboBoxEvents Events(this NSComboBox This)
        {
            return new NSComboBoxEvents(This);
        }
        public static NSControlEvents Events(this NSControl This)
        {
            return new NSControlEvents(This);
        }
        public static NSImageEvents Events(this NSImage This)
        {
            return new NSImageEvents(This);
        }
        public static NSMenuItemEvents Events(this NSMenuItem This)
        {
            return new NSMenuItemEvents(This);
        }
        public static NSSharingServiceEvents Events(this NSSharingService This)
        {
            return new NSSharingServiceEvents(This);
        }
        public static NSSoundEvents Events(this NSSound This)
        {
            return new NSSoundEvents(This);
        }
        public static NSDatePickerEvents Events(this NSDatePicker This)
        {
            return new NSDatePickerEvents(This);
        }
        public static NSTextFieldEvents Events(this NSTextField This)
        {
            return new NSTextFieldEvents(This);
        }
        public static NSTextStorageEvents Events(this NSTextStorage This)
        {
            return new NSTextStorageEvents(This);
        }
        public static NSToolbarItemEvents Events(this NSToolbarItem This)
        {
            return new NSToolbarItemEvents(This);
        }
        public static NSWindowEvents Events(this NSWindow This)
        {
            return new NSWindowEvents(This);
        }
        public static NSSavePanelEvents Events(this NSSavePanel This)
        {
            return new NSSavePanelEvents(This);
        }
        public static NSDatePickerCellEvents Events(this NSDatePickerCell This)
        {
            return new NSDatePickerCellEvents(This);
        }
        public static NSDrawerEvents Events(this NSDrawer This)
        {
            return new NSDrawerEvents(This);
        }
        public static NSPageControllerEvents Events(this NSPageController This)
        {
            return new NSPageControllerEvents(This);
        }
        public static NSRuleEditorEvents Events(this NSRuleEditor This)
        {
            return new NSRuleEditorEvents(This);
        }
        public static NSSearchFieldEvents Events(this NSSearchField This)
        {
            return new NSSearchFieldEvents(This);
        }
        public static NSTabViewEvents Events(this NSTabView This)
        {
            return new NSTabViewEvents(This);
        }
        public static NSSharingServicePickerEvents Events(this NSSharingServicePicker This)
        {
            return new NSSharingServicePickerEvents(This);
        }
        public static NSTextViewEvents Events(this NSTextView This)
        {
            return new NSTextViewEvents(This);
        }
        public static NSTextEvents Events(this NSText This)
        {
            return new NSTextEvents(This);
        }
        public static NSToolbarEvents Events(this NSToolbar This)
        {
            return new NSToolbarEvents(This);
        }
    }

    public class NSActionCellEvents
    {
        NSActionCell This;

        public NSActionCellEvents(NSActionCell This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSAnimationEvents
    {
        NSAnimation This;

        public NSAnimationEvents(NSAnimation This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> AnimationDidEnd {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AnimationDidEnd += x, x => This.AnimationDidEnd -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSAnimationEventArgs> AnimationDidReachProgressMark {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSAnimationEventArgs>, AppKit.NSAnimationEventArgs>(x => This.AnimationDidReachProgressMark += x, x => This.AnimationDidReachProgressMark -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> AnimationDidStop {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AnimationDidStop += x, x => This.AnimationDidStop -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSApplicationEvents
    {
        NSApplication This;

        public NSApplicationEvents(NSApplication This)
        {
            this.This = This;
        }

        public IObservable<AppKit.NSCoderEventArgs> DecodedRestorableState {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSCoderEventArgs>, AppKit.NSCoderEventArgs>(x => This.DecodedRestorableState += x, x => This.DecodedRestorableState -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidBecomeActive {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidBecomeActive += x, x => This.DidBecomeActive -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidFinishLaunching {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidFinishLaunching += x, x => This.DidFinishLaunching -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidHide {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidHide += x, x => This.DidHide -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidResignActive {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidResignActive += x, x => This.DidResignActive -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidUnhide {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidUnhide += x, x => This.DidUnhide -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidUpdate {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidUpdate += x, x => This.DidUpdate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSApplicationFailedEventArgs> FailedToContinueUserActivity {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSApplicationFailedEventArgs>, AppKit.NSApplicationFailedEventArgs>(x => This.FailedToContinueUserActivity += x, x => This.FailedToContinueUserActivity -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSErrorEventArgs> FailedToRegisterForRemoteNotifications {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSErrorEventArgs>, Foundation.NSErrorEventArgs>(x => This.FailedToRegisterForRemoteNotifications += x, x => This.FailedToRegisterForRemoteNotifications -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSApplicationFilesEventArgs> OpenFiles {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSApplicationFilesEventArgs>, AppKit.NSApplicationFilesEventArgs>(x => This.OpenFiles += x, x => This.OpenFiles -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> OrderFrontStandardAboutPanel {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.OrderFrontStandardAboutPanel += x, x => This.OrderFrontStandardAboutPanel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> OrderFrontStandardAboutPanelWithOptions {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.OrderFrontStandardAboutPanelWithOptions += x, x => This.OrderFrontStandardAboutPanelWithOptions -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSDictionaryEventArgs> ReceivedRemoteNotification {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSDictionaryEventArgs>, AppKit.NSDictionaryEventArgs>(x => This.ReceivedRemoteNotification += x, x => This.ReceivedRemoteNotification -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSDataEventArgs> RegisteredForRemoteNotifications {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSDataEventArgs>, AppKit.NSDataEventArgs>(x => This.RegisteredForRemoteNotifications += x, x => This.RegisteredForRemoteNotifications -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSApplicationRegisterEventArgs> RegisterServicesMenu {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSApplicationRegisterEventArgs>, AppKit.NSApplicationRegisterEventArgs>(x => This.RegisterServicesMenu += x, x => This.RegisterServicesMenu -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ScreenParametersChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ScreenParametersChanged += x, x => This.ScreenParametersChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSApplicationUpdatedUserActivityEventArgs> UpdatedUserActivity {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSApplicationUpdatedUserActivityEventArgs>, AppKit.NSApplicationUpdatedUserActivityEventArgs>(x => This.UpdatedUserActivity += x, x => This.UpdatedUserActivity -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillBecomeActive {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillBecomeActive += x, x => This.WillBecomeActive -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSCoderEventArgs> WillEncodeRestorableState {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSCoderEventArgs>, AppKit.NSCoderEventArgs>(x => This.WillEncodeRestorableState += x, x => This.WillEncodeRestorableState -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillFinishLaunching {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillFinishLaunching += x, x => This.WillFinishLaunching -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillHide {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillHide += x, x => This.WillHide -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillResignActive {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillResignActive += x, x => This.WillResignActive -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillTerminate {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillTerminate += x, x => This.WillTerminate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillUnhide {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillUnhide += x, x => This.WillUnhide -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillUpdate {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillUpdate += x, x => This.WillUpdate -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSBrowserEvents
        : AppKit.NSControlEvents
    {
        NSBrowser This;

        public NSBrowserEvents(NSBrowser This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DoubleClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DoubleClick += x, x => This.DoubleClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSMatrixEvents
        : AppKit.NSControlEvents
    {
        NSMatrix This;

        public NSMatrixEvents(NSMatrix This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DoubleClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DoubleClick += x, x => This.DoubleClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSPathCellEvents
        : AppKit.NSActionCellEvents
    {
        NSPathCell This;

        public NSPathCellEvents(NSPathCell This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DoubleClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DoubleClick += x, x => This.DoubleClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSPathCellDisplayPanelEventArgs> WillDisplayOpenPanel {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSPathCellDisplayPanelEventArgs>, AppKit.NSPathCellDisplayPanelEventArgs>(x => This.WillDisplayOpenPanel += x, x => This.WillDisplayOpenPanel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSPathCellMenuEventArgs> WillPopupMenu {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSPathCellMenuEventArgs>, AppKit.NSPathCellMenuEventArgs>(x => This.WillPopupMenu += x, x => This.WillPopupMenu -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSPathControlEvents
        : AppKit.NSControlEvents
    {
        NSPathControl This;

        public NSPathControlEvents(NSPathControl This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DoubleClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DoubleClick += x, x => This.DoubleClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSStatusItemEvents
    {
        NSStatusItem This;

        public NSStatusItemEvents(NSStatusItem This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DoubleClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DoubleClick += x, x => This.DoubleClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSTableViewEvents
        : AppKit.NSControlEvents
    {
        NSTableView This;

        public NSTableViewEvents(NSTableView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DoubleClick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DoubleClick += x, x => This.DoubleClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ColumnDidMove {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ColumnDidMove += x, x => This.ColumnDidMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ColumnDidResize {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ColumnDidResize += x, x => This.ColumnDidResize -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSTableViewRowEventArgs> DidAddRowView {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTableViewRowEventArgs>, AppKit.NSTableViewRowEventArgs>(x => This.DidAddRowView += x, x => This.DidAddRowView -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSTableViewTableEventArgs> DidClickTableColumn {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTableViewTableEventArgs>, AppKit.NSTableViewTableEventArgs>(x => This.DidClickTableColumn += x, x => This.DidClickTableColumn -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSTableViewTableEventArgs> DidDragTableColumn {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTableViewTableEventArgs>, AppKit.NSTableViewTableEventArgs>(x => This.DidDragTableColumn += x, x => This.DidDragTableColumn -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSTableViewRowEventArgs> DidRemoveRowView {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTableViewRowEventArgs>, AppKit.NSTableViewRowEventArgs>(x => This.DidRemoveRowView += x, x => This.DidRemoveRowView -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSTableViewTableEventArgs> MouseDownInHeaderOfTableColumn {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTableViewTableEventArgs>, AppKit.NSTableViewTableEventArgs>(x => This.MouseDownInHeaderOfTableColumn += x, x => This.MouseDownInHeaderOfTableColumn -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionDidChange {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionDidChange += x, x => This.SelectionDidChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionIsChanging {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionIsChanging += x, x => This.SelectionIsChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSTableViewCellEventArgs> WillDisplayCell {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTableViewCellEventArgs>, AppKit.NSTableViewCellEventArgs>(x => This.WillDisplayCell += x, x => This.WillDisplayCell -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSComboBoxEvents
        : AppKit.NSTextFieldEvents
    {
        NSComboBox This;

        public NSComboBoxEvents(NSComboBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionIsChanging {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionIsChanging += x, x => This.SelectionIsChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillDismiss {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillDismiss += x, x => This.WillDismiss -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillPopUp {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillPopUp += x, x => This.WillPopUp -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSControlEvents
    {
        NSControl This;

        public NSControlEvents(NSControl This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSImageEvents
    {
        NSImage This;

        public NSImageEvents(NSImage This)
        {
            this.This = This;
        }

        public IObservable<AppKit.NSImagePartialEventArgs> DidLoadPartOfRepresentation {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSImagePartialEventArgs>, AppKit.NSImagePartialEventArgs>(x => This.DidLoadPartOfRepresentation += x, x => This.DidLoadPartOfRepresentation -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSImageLoadRepresentationEventArgs> DidLoadRepresentation {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSImageLoadRepresentationEventArgs>, AppKit.NSImageLoadRepresentationEventArgs>(x => This.DidLoadRepresentation += x, x => This.DidLoadRepresentation -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSImageLoadEventArgs> DidLoadRepresentationHeader {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSImageLoadEventArgs>, AppKit.NSImageLoadEventArgs>(x => This.DidLoadRepresentationHeader += x, x => This.DidLoadRepresentationHeader -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSImageLoadEventArgs> WillLoadRepresentation {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSImageLoadEventArgs>, AppKit.NSImageLoadEventArgs>(x => This.WillLoadRepresentation += x, x => This.WillLoadRepresentation -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSMenuItemEvents
    {
        NSMenuItem This;

        public NSMenuItemEvents(NSMenuItem This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSSharingServiceEvents
    {
        NSSharingService This;

        public NSSharingServiceEvents(NSSharingService This)
        {
            this.This = This;
        }

        public IObservable<AppKit.NSSharingServiceDidFailToShareItemsEventArgs> DidFailToShareItems {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSSharingServiceDidFailToShareItemsEventArgs>, AppKit.NSSharingServiceDidFailToShareItemsEventArgs>(x => This.DidFailToShareItems += x, x => This.DidFailToShareItems -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSSharingServiceItemsEventArgs> DidShareItems {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSSharingServiceItemsEventArgs>, AppKit.NSSharingServiceItemsEventArgs>(x => This.DidShareItems += x, x => This.DidShareItems -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSSharingServiceItemsEventArgs> WillShareItems {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSSharingServiceItemsEventArgs>, AppKit.NSSharingServiceItemsEventArgs>(x => This.WillShareItems += x, x => This.WillShareItems -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSSoundEvents
    {
        NSSound This;

        public NSSoundEvents(NSSound This)
        {
            this.This = This;
        }

        public IObservable<AppKit.NSSoundFinishedEventArgs> DidFinishPlaying {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSSoundFinishedEventArgs>, AppKit.NSSoundFinishedEventArgs>(x => This.DidFinishPlaying += x, x => This.DidFinishPlaying -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSDatePickerEvents
        : AppKit.NSControlEvents
    {
        NSDatePicker This;

        public NSDatePickerEvents(NSDatePicker This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<AppKit.NSDatePickerValidatorEventArgs> ValidateProposedDateValue {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSDatePickerValidatorEventArgs>, AppKit.NSDatePickerValidatorEventArgs>(x => This.ValidateProposedDateValue += x, x => This.ValidateProposedDateValue -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSTextFieldEvents
        : AppKit.NSControlEvents
    {
        NSTextField This;

        public NSTextFieldEvents(NSTextField This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Changed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Changed += x, x => This.Changed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSControlTextErrorEventArgs> DidFailToValidatePartialString {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSControlTextErrorEventArgs>, AppKit.NSControlTextErrorEventArgs>(x => This.DidFailToValidatePartialString += x, x => This.DidFailToValidatePartialString -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EditingBegan {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EditingBegan += x, x => This.EditingBegan -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EditingEnded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EditingEnded += x, x => This.EditingEnded -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSTextStorageEvents
    {
        NSTextStorage This;

        public NSTextStorageEvents(NSTextStorage This)
        {
            this.This = This;
        }

        public IObservable<AppKit.NSTextStorageEventArgs> DidProcessEditing {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTextStorageEventArgs>, AppKit.NSTextStorageEventArgs>(x => This.DidProcessEditing += x, x => This.DidProcessEditing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TextStorageDidProcessEditing {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TextStorageDidProcessEditing += x, x => This.TextStorageDidProcessEditing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TextStorageWillProcessEditing {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TextStorageWillProcessEditing += x, x => This.TextStorageWillProcessEditing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSTextStorageEventArgs> WillProcessEditing {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTextStorageEventArgs>, AppKit.NSTextStorageEventArgs>(x => This.WillProcessEditing += x, x => This.WillProcessEditing -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSToolbarItemEvents
    {
        NSToolbarItem This;

        public NSToolbarItemEvents(NSToolbarItem This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSWindowEvents
    {
        NSWindow This;

        public NSWindowEvents(NSWindow This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidBecomeKey {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidBecomeKey += x, x => This.DidBecomeKey -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidBecomeMain {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidBecomeMain += x, x => This.DidBecomeMain -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidChangeBackingProperties {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidChangeBackingProperties += x, x => This.DidChangeBackingProperties -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidChangeScreen {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidChangeScreen += x, x => This.DidChangeScreen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidChangeScreenProfile {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidChangeScreenProfile += x, x => This.DidChangeScreenProfile -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSWindowCoderEventArgs> DidDecodeRestorableState {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSWindowCoderEventArgs>, AppKit.NSWindowCoderEventArgs>(x => This.DidDecodeRestorableState += x, x => This.DidDecodeRestorableState -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidDeminiaturize {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidDeminiaturize += x, x => This.DidDeminiaturize -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidEndLiveResize {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidEndLiveResize += x, x => This.DidEndLiveResize -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidEndSheet {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidEndSheet += x, x => This.DidEndSheet -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidEnterFullScreen {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidEnterFullScreen += x, x => This.DidEnterFullScreen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidEnterVersionBrowser {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidEnterVersionBrowser += x, x => This.DidEnterVersionBrowser -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidExitFullScreen {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidExitFullScreen += x, x => This.DidExitFullScreen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidExitVersionBrowser {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidExitVersionBrowser += x, x => This.DidExitVersionBrowser -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidExpose {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidExpose += x, x => This.DidExpose -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidFailToEnterFullScreen {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidFailToEnterFullScreen += x, x => This.DidFailToEnterFullScreen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidFailToExitFullScreen {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidFailToExitFullScreen += x, x => This.DidFailToExitFullScreen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidMiniaturize {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidMiniaturize += x, x => This.DidMiniaturize -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidMove {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidMove += x, x => This.DidMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidResignKey {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidResignKey += x, x => This.DidResignKey -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidResignMain {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidResignMain += x, x => This.DidResignMain -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidResize {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidResize += x, x => This.DidResize -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidUpdate {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidUpdate += x, x => This.DidUpdate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSWindowDurationEventArgs> StartCustomAnimationToEnterFullScreen {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSWindowDurationEventArgs>, AppKit.NSWindowDurationEventArgs>(x => This.StartCustomAnimationToEnterFullScreen += x, x => This.StartCustomAnimationToEnterFullScreen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSWindowDurationEventArgs> StartCustomAnimationToExitFullScreen {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSWindowDurationEventArgs>, AppKit.NSWindowDurationEventArgs>(x => This.StartCustomAnimationToExitFullScreen += x, x => This.StartCustomAnimationToExitFullScreen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillBeginSheet {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillBeginSheet += x, x => This.WillBeginSheet -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillClose {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillClose += x, x => This.WillClose -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSWindowCoderEventArgs> WillEncodeRestorableState {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSWindowCoderEventArgs>, AppKit.NSWindowCoderEventArgs>(x => This.WillEncodeRestorableState += x, x => This.WillEncodeRestorableState -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillEnterFullScreen {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillEnterFullScreen += x, x => This.WillEnterFullScreen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillEnterVersionBrowser {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillEnterVersionBrowser += x, x => This.WillEnterVersionBrowser -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillExitFullScreen {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillExitFullScreen += x, x => This.WillExitFullScreen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillExitVersionBrowser {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillExitVersionBrowser += x, x => This.WillExitVersionBrowser -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillMiniaturize {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillMiniaturize += x, x => This.WillMiniaturize -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillMove {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillMove += x, x => This.WillMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillStartLiveResize {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillStartLiveResize += x, x => This.WillStartLiveResize -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSSavePanelEvents
        : AppKit.NSWindowEvents
    {
        NSSavePanel This;

        public NSSavePanelEvents(NSSavePanel This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<AppKit.NSOpenSavePanelUrlEventArgs> DidChangeToDirectory {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSOpenSavePanelUrlEventArgs>, AppKit.NSOpenSavePanelUrlEventArgs>(x => This.DidChangeToDirectory += x, x => This.DidChangeToDirectory -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSOpenSaveFilenameEventArgs> DirectoryDidChange {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSOpenSaveFilenameEventArgs>, AppKit.NSOpenSaveFilenameEventArgs>(x => This.DirectoryDidChange += x, x => This.DirectoryDidChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionDidChange {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionDidChange += x, x => This.SelectionDidChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSOpenSaveExpandingEventArgs> WillExpand {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSOpenSaveExpandingEventArgs>, AppKit.NSOpenSaveExpandingEventArgs>(x => This.WillExpand += x, x => This.WillExpand -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSDatePickerCellEvents
        : AppKit.NSActionCellEvents
    {
        NSDatePickerCell This;

        public NSDatePickerCellEvents(NSDatePickerCell This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<AppKit.NSDatePickerValidatorEventArgs> ValidateProposedDateValue {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSDatePickerValidatorEventArgs>, AppKit.NSDatePickerValidatorEventArgs>(x => This.ValidateProposedDateValue += x, x => This.ValidateProposedDateValue -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSDrawerEvents
    {
        NSDrawer This;

        public NSDrawerEvents(NSDrawer This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DrawerDidClose {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DrawerDidClose += x, x => This.DrawerDidClose -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DrawerDidOpen {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DrawerDidOpen += x, x => This.DrawerDidOpen -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DrawerWillClose {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DrawerWillClose += x, x => This.DrawerWillClose -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DrawerWillOpen {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DrawerWillOpen += x, x => This.DrawerWillOpen -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSPageControllerEvents
    {
        NSPageController This;

        public NSPageControllerEvents(NSPageController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidEndLiveTransition {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidEndLiveTransition += x, x => This.DidEndLiveTransition -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSPageControllerTransitionEventArgs> DidTransition {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSPageControllerTransitionEventArgs>, AppKit.NSPageControllerTransitionEventArgs>(x => This.DidTransition += x, x => This.DidTransition -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSPageControllerPrepareViewControllerEventArgs> PrepareViewController {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSPageControllerPrepareViewControllerEventArgs>, AppKit.NSPageControllerPrepareViewControllerEventArgs>(x => This.PrepareViewController += x, x => This.PrepareViewController -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillStartLiveTransition {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillStartLiveTransition += x, x => This.WillStartLiveTransition -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSRuleEditorEvents
        : AppKit.NSControlEvents
    {
        NSRuleEditor This;

        public NSRuleEditorEvents(NSRuleEditor This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Changed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Changed += x, x => This.Changed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EditingBegan {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EditingBegan += x, x => This.EditingBegan -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EditingEnded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EditingEnded += x, x => This.EditingEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> RowsDidChange {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.RowsDidChange += x, x => This.RowsDidChange -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSSearchFieldEvents
        : AppKit.NSTextFieldEvents
    {
        NSSearchField This;

        public NSSearchFieldEvents(NSSearchField This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> SearchingEnded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SearchingEnded += x, x => This.SearchingEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SearchingStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SearchingStarted += x, x => This.SearchingStarted -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSTabViewEvents
    {
        NSTabView This;

        public NSTabViewEvents(NSTabView This)
        {
            this.This = This;
        }

        public IObservable<AppKit.NSTabViewItemEventArgs> DidSelect {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTabViewItemEventArgs>, AppKit.NSTabViewItemEventArgs>(x => This.DidSelect += x, x => This.DidSelect -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> NumberOfItemsChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.NumberOfItemsChanged += x, x => This.NumberOfItemsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSTabViewItemEventArgs> WillSelect {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTabViewItemEventArgs>, AppKit.NSTabViewItemEventArgs>(x => This.WillSelect += x, x => This.WillSelect -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSSharingServicePickerEvents
    {
        NSSharingServicePicker This;

        public NSSharingServicePickerEvents(NSSharingServicePicker This)
        {
            this.This = This;
        }

        public IObservable<AppKit.NSSharingServicePickerDidChooseSharingServiceEventArgs> DidChooseSharingService {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSSharingServicePickerDidChooseSharingServiceEventArgs>, AppKit.NSSharingServicePickerDidChooseSharingServiceEventArgs>(x => This.DidChooseSharingService += x, x => This.DidChooseSharingService -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSTextViewEvents
        : AppKit.NSTextEvents
    {
        NSTextView This;

        public NSTextViewEvents(NSTextView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<AppKit.NSTextViewClickedEventArgs> CellClicked {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTextViewClickedEventArgs>, AppKit.NSTextViewClickedEventArgs>(x => This.CellClicked += x, x => This.CellClicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSTextViewDoubleClickEventArgs> CellDoubleClicked {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTextViewDoubleClickEventArgs>, AppKit.NSTextViewDoubleClickEventArgs>(x => This.CellDoubleClicked += x, x => This.CellDoubleClicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidChangeSelection {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidChangeSelection += x, x => This.DidChangeSelection -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidChangeTypingAttributes {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidChangeTypingAttributes += x, x => This.DidChangeTypingAttributes -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AppKit.NSTextViewDraggedCellEventArgs> DraggedCell {
            get { return Observable.FromEventPattern<System.EventHandler<AppKit.NSTextViewDraggedCellEventArgs>, AppKit.NSTextViewDraggedCellEventArgs>(x => This.DraggedCell += x, x => This.DraggedCell -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSTextEvents
    {
        NSText This;

        public NSTextEvents(NSText This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> TextDidBeginEditing {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TextDidBeginEditing += x, x => This.TextDidBeginEditing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TextDidChange {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TextDidChange += x, x => This.TextDidChange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TextDidEndEditing {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TextDidEndEditing += x, x => This.TextDidEndEditing -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSToolbarEvents
    {
        NSToolbar This;

        public NSToolbarEvents(NSToolbar This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidRemoveItem {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidRemoveItem += x, x => This.DidRemoveItem -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillAddItem {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillAddItem += x, x => This.WillAddItem -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace GameKit
{
    public static class EventsMixin
    {
        public static GKMatchEvents Events(this GKMatch This)
        {
            return new GKMatchEvents(This);
        }
        public static GKAchievementViewControllerEvents Events(this GKAchievementViewController This)
        {
            return new GKAchievementViewControllerEvents(This);
        }
        public static GKFriendRequestComposeViewControllerEvents Events(this GKFriendRequestComposeViewController This)
        {
            return new GKFriendRequestComposeViewControllerEvents(This);
        }
        public static GKGameCenterViewControllerEvents Events(this GKGameCenterViewController This)
        {
            return new GKGameCenterViewControllerEvents(This);
        }
        public static GKLeaderboardViewControllerEvents Events(this GKLeaderboardViewController This)
        {
            return new GKLeaderboardViewControllerEvents(This);
        }
        public static GKMatchmakerViewControllerEvents Events(this GKMatchmakerViewController This)
        {
            return new GKMatchmakerViewControllerEvents(This);
        }
    }

    public class GKMatchEvents
    {
        GKMatch This;

        public GKMatchEvents(GKMatch This)
        {
            this.This = This;
        }

        public IObservable<GameKit.GKPlayerErrorEventArgs> ConnectionFailed {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKPlayerErrorEventArgs>, GameKit.GKPlayerErrorEventArgs>(x => This.ConnectionFailed += x, x => This.ConnectionFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKDataEventArgs> DataReceived {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKDataEventArgs>, GameKit.GKDataEventArgs>(x => This.DataReceived += x, x => This.DataReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKDataReceivedForRecipientEventArgs> DataReceivedForRecipient {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKDataReceivedForRecipientEventArgs>, GameKit.GKDataReceivedForRecipientEventArgs>(x => This.DataReceivedForRecipient += x, x => This.DataReceivedForRecipient -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKMatchReceivedDataFromRemotePlayerEventArgs> DataReceivedFromPlayer {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKMatchReceivedDataFromRemotePlayerEventArgs>, GameKit.GKMatchReceivedDataFromRemotePlayerEventArgs>(x => This.DataReceivedFromPlayer += x, x => This.DataReceivedFromPlayer -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKErrorEventArgs> Failed {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKErrorEventArgs>, GameKit.GKErrorEventArgs>(x => This.Failed += x, x => This.Failed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKStateEventArgs> StateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKStateEventArgs>, GameKit.GKStateEventArgs>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKMatchConnectionChangedEventArgs> StateChangedForPlayer {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKMatchConnectionChangedEventArgs>, GameKit.GKMatchConnectionChangedEventArgs>(x => This.StateChangedForPlayer += x, x => This.StateChangedForPlayer -= x).Select(x => x.EventArgs); }
        }

    }
    public class GKAchievementViewControllerEvents
        : GameKit.GKGameCenterViewControllerEvents
    {
        GKAchievementViewController This;

        public GKAchievementViewControllerEvents(GKAchievementViewController This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidFinish {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidFinish += x, x => This.DidFinish -= x).Select(x => x.EventArgs); }
        }

    }
    public class GKFriendRequestComposeViewControllerEvents
    {
        GKFriendRequestComposeViewController This;

        public GKFriendRequestComposeViewControllerEvents(GKFriendRequestComposeViewController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidFinish {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidFinish += x, x => This.DidFinish -= x).Select(x => x.EventArgs); }
        }

    }
    public class GKGameCenterViewControllerEvents
    {
        GKGameCenterViewController This;

        public GKGameCenterViewControllerEvents(GKGameCenterViewController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Finished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Finished += x, x => This.Finished -= x).Select(x => x.EventArgs); }
        }

    }
    public class GKLeaderboardViewControllerEvents
        : GameKit.GKGameCenterViewControllerEvents
    {
        GKLeaderboardViewController This;

        public GKLeaderboardViewControllerEvents(GKLeaderboardViewController This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidFinish {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidFinish += x, x => This.DidFinish -= x).Select(x => x.EventArgs); }
        }

    }
    public class GKMatchmakerViewControllerEvents
    {
        GKMatchmakerViewController This;

        public GKMatchmakerViewControllerEvents(GKMatchmakerViewController This)
        {
            this.This = This;
        }

        public IObservable<GameKit.GKErrorEventArgs> DidFailWithError {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKErrorEventArgs>, GameKit.GKErrorEventArgs>(x => This.DidFailWithError += x, x => This.DidFailWithError -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKMatchmakingPlayersEventArgs> DidFindHostedPlayers {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKMatchmakingPlayersEventArgs>, GameKit.GKMatchmakingPlayersEventArgs>(x => This.DidFindHostedPlayers += x, x => This.DidFindHostedPlayers -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKMatchEventArgs> DidFindMatch {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKMatchEventArgs>, GameKit.GKMatchEventArgs>(x => This.DidFindMatch += x, x => This.DidFindMatch -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKPlayersEventArgs> DidFindPlayers {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKPlayersEventArgs>, GameKit.GKPlayersEventArgs>(x => This.DidFindPlayers += x, x => This.DidFindPlayers -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKMatchmakingPlayerEventArgs> HostedPlayerDidAccept {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKMatchmakingPlayerEventArgs>, GameKit.GKMatchmakingPlayerEventArgs>(x => This.HostedPlayerDidAccept += x, x => This.HostedPlayerDidAccept -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKPlayerEventArgs> ReceivedAcceptFromHostedPlayer {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKPlayerEventArgs>, GameKit.GKPlayerEventArgs>(x => This.ReceivedAcceptFromHostedPlayer += x, x => This.ReceivedAcceptFromHostedPlayer -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WasCancelled {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WasCancelled += x, x => This.WasCancelled -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace CoreLocation
{
    public static class EventsMixin
    {
        public static CLLocationManagerEvents Events(this CLLocationManager This)
        {
            return new CLLocationManagerEvents(This);
        }
    }

    public class CLLocationManagerEvents
    {
        CLLocationManager This;

        public CLLocationManagerEvents(CLLocationManager This)
        {
            this.This = This;
        }

        public IObservable<CoreLocation.CLAuthorizationChangedEventArgs> AuthorizationChanged {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLAuthorizationChangedEventArgs>, CoreLocation.CLAuthorizationChangedEventArgs>(x => This.AuthorizationChanged += x, x => This.AuthorizationChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSErrorEventArgs> DeferredUpdatesFinished {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSErrorEventArgs>, Foundation.NSErrorEventArgs>(x => This.DeferredUpdatesFinished += x, x => This.DeferredUpdatesFinished -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLRegionStateDeterminedEventArgs> DidDetermineState {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLRegionStateDeterminedEventArgs>, CoreLocation.CLRegionStateDeterminedEventArgs>(x => This.DidDetermineState += x, x => This.DidDetermineState -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLRegionEventArgs> DidStartMonitoringForRegion {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLRegionEventArgs>, CoreLocation.CLRegionEventArgs>(x => This.DidStartMonitoringForRegion += x, x => This.DidStartMonitoringForRegion -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSErrorEventArgs> Failed {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSErrorEventArgs>, Foundation.NSErrorEventArgs>(x => This.Failed += x, x => This.Failed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLLocationsUpdatedEventArgs> LocationsUpdated {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLLocationsUpdatedEventArgs>, CoreLocation.CLLocationsUpdatedEventArgs>(x => This.LocationsUpdated += x, x => This.LocationsUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> LocationUpdatesPaused {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LocationUpdatesPaused += x, x => This.LocationUpdatesPaused -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> LocationUpdatesResumed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LocationUpdatesResumed += x, x => This.LocationUpdatesResumed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLRegionErrorEventArgs> MonitoringFailed {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLRegionErrorEventArgs>, CoreLocation.CLRegionErrorEventArgs>(x => This.MonitoringFailed += x, x => This.MonitoringFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLRegionEventArgs> RegionEntered {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLRegionEventArgs>, CoreLocation.CLRegionEventArgs>(x => This.RegionEntered += x, x => This.RegionEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLRegionEventArgs> RegionLeft {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLRegionEventArgs>, CoreLocation.CLRegionEventArgs>(x => This.RegionLeft += x, x => This.RegionLeft -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLLocationUpdatedEventArgs> UpdatedLocation {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLLocationUpdatedEventArgs>, CoreLocation.CLLocationUpdatedEventArgs>(x => This.UpdatedLocation += x, x => This.UpdatedLocation -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace AudioToolbox
{
    public static class EventsMixin
    {
        public static AudioConverterEvents Events(this AudioConverter This)
        {
            return new AudioConverterEvents(This);
        }
        public static OutputAudioQueueEvents Events(this OutputAudioQueue This)
        {
            return new OutputAudioQueueEvents(This);
        }
        public static InputAudioQueueEvents Events(this InputAudioQueue This)
        {
            return new InputAudioQueueEvents(This);
        }
    }

    public class AudioConverterEvents
    {
        AudioConverter This;

        public AudioConverterEvents(AudioConverter This)
        {
            this.This = This;
        }

        public IObservable<AudioToolbox.AudioBuffers> InputData {
            get { return Observable.FromEventPattern<AudioToolbox.AudioConverterComplexInputData, AudioToolbox.AudioBuffers>(x => This.InputData += x, x => This.InputData -= x).Select(x => x.EventArgs); }
        }

    }
    public class OutputAudioQueueEvents
    {
        OutputAudioQueue This;

        public OutputAudioQueueEvents(OutputAudioQueue This)
        {
            this.This = This;
        }

        public IObservable<AudioToolbox.BufferCompletedEventArgs> BufferCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<AudioToolbox.BufferCompletedEventArgs>, AudioToolbox.BufferCompletedEventArgs>(x => This.BufferCompleted += x, x => This.BufferCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class InputAudioQueueEvents
    {
        InputAudioQueue This;

        public InputAudioQueueEvents(InputAudioQueue This)
        {
            this.This = This;
        }

        public IObservable<AudioToolbox.InputCompletedEventArgs> InputCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<AudioToolbox.InputCompletedEventArgs>, AudioToolbox.InputCompletedEventArgs>(x => This.InputCompleted += x, x => This.InputCompleted -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace CoreAnimation
{
    public static class EventsMixin
    {
        public static CAAnimationEvents Events(this CAAnimation This)
        {
            return new CAAnimationEvents(This);
        }
    }

    public class CAAnimationEvents
    {
        CAAnimation This;

        public CAAnimationEvents(CAAnimation This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> AnimationStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AnimationStarted += x, x => This.AnimationStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreAnimation.CAAnimationStateEventArgs> AnimationStopped {
            get { return Observable.FromEventPattern<System.EventHandler<CoreAnimation.CAAnimationStateEventArgs>, CoreAnimation.CAAnimationStateEventArgs>(x => This.AnimationStopped += x, x => This.AnimationStopped -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace CoreBluetooth
{
    public static class EventsMixin
    {
        public static CBCentralManagerEvents Events(this CBCentralManager This)
        {
            return new CBCentralManagerEvents(This);
        }
        public static CBPeripheralEvents Events(this CBPeripheral This)
        {
            return new CBPeripheralEvents(This);
        }
        public static CBPeripheralManagerEvents Events(this CBPeripheralManager This)
        {
            return new CBPeripheralManagerEvents(This);
        }
    }

    public class CBCentralManagerEvents
    {
        CBCentralManager This;

        public CBCentralManagerEvents(CBCentralManager This)
        {
            this.This = This;
        }

        public IObservable<CoreBluetooth.CBPeripheralEventArgs> ConnectedPeripheral {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBPeripheralEventArgs>, CoreBluetooth.CBPeripheralEventArgs>(x => This.ConnectedPeripheral += x, x => This.ConnectedPeripheral -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBPeripheralErrorEventArgs> DisconnectedPeripheral {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBPeripheralErrorEventArgs>, CoreBluetooth.CBPeripheralErrorEventArgs>(x => This.DisconnectedPeripheral += x, x => This.DisconnectedPeripheral -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBDiscoveredPeripheralEventArgs> DiscoveredPeripheral {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBDiscoveredPeripheralEventArgs>, CoreBluetooth.CBDiscoveredPeripheralEventArgs>(x => This.DiscoveredPeripheral += x, x => This.DiscoveredPeripheral -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBPeripheralErrorEventArgs> FailedToConnectPeripheral {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBPeripheralErrorEventArgs>, CoreBluetooth.CBPeripheralErrorEventArgs>(x => This.FailedToConnectPeripheral += x, x => This.FailedToConnectPeripheral -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBPeripheralsEventArgs> RetrievedConnectedPeripherals {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBPeripheralsEventArgs>, CoreBluetooth.CBPeripheralsEventArgs>(x => This.RetrievedConnectedPeripherals += x, x => This.RetrievedConnectedPeripherals -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBPeripheralsEventArgs> RetrievedPeripherals {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBPeripheralsEventArgs>, CoreBluetooth.CBPeripheralsEventArgs>(x => This.RetrievedPeripherals += x, x => This.RetrievedPeripherals -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> UpdatedState {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.UpdatedState += x, x => This.UpdatedState -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBWillRestoreEventArgs> WillRestoreState {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBWillRestoreEventArgs>, CoreBluetooth.CBWillRestoreEventArgs>(x => This.WillRestoreState += x, x => This.WillRestoreState -= x).Select(x => x.EventArgs); }
        }

    }
    public class CBPeripheralEvents
    {
        CBPeripheral This;

        public CBPeripheralEvents(CBPeripheral This)
        {
            this.This = This;
        }

        public IObservable<CoreBluetooth.CBServiceEventArgs> DiscoveredCharacteristic {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBServiceEventArgs>, CoreBluetooth.CBServiceEventArgs>(x => This.DiscoveredCharacteristic += x, x => This.DiscoveredCharacteristic -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBCharacteristicEventArgs> DiscoveredDescriptor {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBCharacteristicEventArgs>, CoreBluetooth.CBCharacteristicEventArgs>(x => This.DiscoveredDescriptor += x, x => This.DiscoveredDescriptor -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBServiceEventArgs> DiscoveredIncludedService {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBServiceEventArgs>, CoreBluetooth.CBServiceEventArgs>(x => This.DiscoveredIncludedService += x, x => This.DiscoveredIncludedService -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSErrorEventArgs> DiscoveredService {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSErrorEventArgs>, Foundation.NSErrorEventArgs>(x => This.DiscoveredService += x, x => This.DiscoveredService -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> InvalidatedService {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.InvalidatedService += x, x => This.InvalidatedService -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBPeripheralServicesEventArgs> ModifiedServices {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBPeripheralServicesEventArgs>, CoreBluetooth.CBPeripheralServicesEventArgs>(x => This.ModifiedServices += x, x => This.ModifiedServices -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBRssiEventArgs> RssiRead {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBRssiEventArgs>, CoreBluetooth.CBRssiEventArgs>(x => This.RssiRead += x, x => This.RssiRead -= x).Select(x => x.EventArgs); }
        }

        public IObservable<Foundation.NSErrorEventArgs> RssiUpdated {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSErrorEventArgs>, Foundation.NSErrorEventArgs>(x => This.RssiUpdated += x, x => This.RssiUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBCharacteristicEventArgs> UpdatedCharacterteristicValue {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBCharacteristicEventArgs>, CoreBluetooth.CBCharacteristicEventArgs>(x => This.UpdatedCharacterteristicValue += x, x => This.UpdatedCharacterteristicValue -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> UpdatedName {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.UpdatedName += x, x => This.UpdatedName -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBCharacteristicEventArgs> UpdatedNotificationState {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBCharacteristicEventArgs>, CoreBluetooth.CBCharacteristicEventArgs>(x => This.UpdatedNotificationState += x, x => This.UpdatedNotificationState -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBDescriptorEventArgs> UpdatedValue {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBDescriptorEventArgs>, CoreBluetooth.CBDescriptorEventArgs>(x => This.UpdatedValue += x, x => This.UpdatedValue -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBCharacteristicEventArgs> WroteCharacteristicValue {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBCharacteristicEventArgs>, CoreBluetooth.CBCharacteristicEventArgs>(x => This.WroteCharacteristicValue += x, x => This.WroteCharacteristicValue -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBDescriptorEventArgs> WroteDescriptorValue {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBDescriptorEventArgs>, CoreBluetooth.CBDescriptorEventArgs>(x => This.WroteDescriptorValue += x, x => This.WroteDescriptorValue -= x).Select(x => x.EventArgs); }
        }

    }
    public class CBPeripheralManagerEvents
    {
        CBPeripheralManager This;

        public CBPeripheralManagerEvents(CBPeripheralManager This)
        {
            this.This = This;
        }

        public IObservable<Foundation.NSErrorEventArgs> AdvertisingStarted {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSErrorEventArgs>, Foundation.NSErrorEventArgs>(x => This.AdvertisingStarted += x, x => This.AdvertisingStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBPeripheralManagerSubscriptionEventArgs> CharacteristicSubscribed {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBPeripheralManagerSubscriptionEventArgs>, CoreBluetooth.CBPeripheralManagerSubscriptionEventArgs>(x => This.CharacteristicSubscribed += x, x => This.CharacteristicSubscribed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBPeripheralManagerSubscriptionEventArgs> CharacteristicUnsubscribed {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBPeripheralManagerSubscriptionEventArgs>, CoreBluetooth.CBPeripheralManagerSubscriptionEventArgs>(x => This.CharacteristicUnsubscribed += x, x => This.CharacteristicUnsubscribed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBATTRequestEventArgs> ReadRequestReceived {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBATTRequestEventArgs>, CoreBluetooth.CBATTRequestEventArgs>(x => This.ReadRequestReceived += x, x => This.ReadRequestReceived -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ReadyToUpdateSubscribers {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ReadyToUpdateSubscribers += x, x => This.ReadyToUpdateSubscribers -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBPeripheralManagerServiceEventArgs> ServiceAdded {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBPeripheralManagerServiceEventArgs>, CoreBluetooth.CBPeripheralManagerServiceEventArgs>(x => This.ServiceAdded += x, x => This.ServiceAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> StateUpdated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.StateUpdated += x, x => This.StateUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBWillRestoreEventArgs> WillRestoreState {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBWillRestoreEventArgs>, CoreBluetooth.CBWillRestoreEventArgs>(x => This.WillRestoreState += x, x => This.WillRestoreState -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreBluetooth.CBATTRequestsEventArgs> WriteRequestsReceived {
            get { return Observable.FromEventPattern<System.EventHandler<CoreBluetooth.CBATTRequestsEventArgs>, CoreBluetooth.CBATTRequestsEventArgs>(x => This.WriteRequestsReceived += x, x => This.WriteRequestsReceived -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace NotificationCenter
{
    public static class EventsMixin
    {
        public static NCWidgetListViewControllerEvents Events(this NCWidgetListViewController This)
        {
            return new NCWidgetListViewControllerEvents(This);
        }
        public static NCWidgetSearchViewControllerEvents Events(this NCWidgetSearchViewController This)
        {
            return new NCWidgetSearchViewControllerEvents(This);
        }
    }

    public class NCWidgetListViewControllerEvents
    {
        NCWidgetListViewController This;

        public NCWidgetListViewControllerEvents(NCWidgetListViewController This)
        {
            this.This = This;
        }

        public IObservable<NotificationCenter.NCWidgetListViewControllerDidRemoveRowEventArgs> DidRemoveRow {
            get { return Observable.FromEventPattern<System.EventHandler<NotificationCenter.NCWidgetListViewControllerDidRemoveRowEventArgs>, NotificationCenter.NCWidgetListViewControllerDidRemoveRowEventArgs>(x => This.DidRemoveRow += x, x => This.DidRemoveRow -= x).Select(x => x.EventArgs); }
        }

        public IObservable<NotificationCenter.NCWidgetListViewControllerDidReorderEventArgs> DidReorderRow {
            get { return Observable.FromEventPattern<System.EventHandler<NotificationCenter.NCWidgetListViewControllerDidReorderEventArgs>, NotificationCenter.NCWidgetListViewControllerDidReorderEventArgs>(x => This.DidReorderRow += x, x => This.DidReorderRow -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PerformAddAction {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PerformAddAction += x, x => This.PerformAddAction -= x).Select(x => x.EventArgs); }
        }

    }
    public class NCWidgetSearchViewControllerEvents
    {
        NCWidgetSearchViewController This;

        public NCWidgetSearchViewControllerEvents(NCWidgetSearchViewController This)
        {
            this.This = This;
        }

        public IObservable<NotificationCenter.NSWidgetSearchResultSelectedEventArgs> ResultSelected {
            get { return Observable.FromEventPattern<System.EventHandler<NotificationCenter.NSWidgetSearchResultSelectedEventArgs>, NotificationCenter.NSWidgetSearchResultSelectedEventArgs>(x => This.ResultSelected += x, x => This.ResultSelected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<NotificationCenter.NSWidgetSearchForTermEventArgs> SearchForTearm {
            get { return Observable.FromEventPattern<System.EventHandler<NotificationCenter.NSWidgetSearchForTermEventArgs>, NotificationCenter.NSWidgetSearchForTermEventArgs>(x => This.SearchForTearm += x, x => This.SearchForTearm -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TermCleared {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TermCleared += x, x => This.TermCleared -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace PdfKit
{
    public static class EventsMixin
    {
        public static PdfDocumentEvents Events(this PdfDocument This)
        {
            return new PdfDocumentEvents(This);
        }
        public static PdfViewEvents Events(this PdfView This)
        {
            return new PdfViewEvents(This);
        }
    }

    public class PdfDocumentEvents
    {
        PdfDocument This;

        public PdfDocumentEvents(PdfDocument This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidMatchString {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidMatchString += x, x => This.DidMatchString -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> FindFinished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.FindFinished += x, x => This.FindFinished -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> MatchFound {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.MatchFound += x, x => This.MatchFound -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PageFindFinished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PageFindFinished += x, x => This.PageFindFinished -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PageFindStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PageFindStarted += x, x => This.PageFindStarted -= x).Select(x => x.EventArgs); }
        }

    }
    public class PdfViewEvents
    {
        PdfView This;

        public PdfViewEvents(PdfView This)
        {
            this.This = This;
        }

        public IObservable<PdfKit.PdfViewActionEventArgs> OpenPdf {
            get { return Observable.FromEventPattern<System.EventHandler<PdfKit.PdfViewActionEventArgs>, PdfKit.PdfViewActionEventArgs>(x => This.OpenPdf += x, x => This.OpenPdf -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PerformFind {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PerformFind += x, x => This.PerformFind -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PerformGoToPage {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PerformGoToPage += x, x => This.PerformGoToPage -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PerformPrint {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PerformPrint += x, x => This.PerformPrint -= x).Select(x => x.EventArgs); }
        }

        public IObservable<PdfKit.PdfViewUrlEventArgs> WillClickOnLink {
            get { return Observable.FromEventPattern<System.EventHandler<PdfKit.PdfViewUrlEventArgs>, PdfKit.PdfViewUrlEventArgs>(x => This.WillClickOnLink += x, x => This.WillClickOnLink -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace CoreServices
{
    public static class EventsMixin
    {
        public static FSEventStreamEvents Events(this FSEventStream This)
        {
            return new FSEventStreamEvents(This);
        }
    }

    public class FSEventStreamEvents
    {
        FSEventStream This;

        public FSEventStreamEvents(FSEventStream This)
        {
            this.This = This;
        }

        public IObservable<CoreServices.FSEventStreamEventsArgs> Events {
            get { return Observable.FromEventPattern<CoreServices.FSEventStreamEventsHandler, CoreServices.FSEventStreamEventsArgs>(x => This.Events += x, x => This.Events -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace QTKit
{
    public static class EventsMixin
    {
        public static QTCaptureDecompressedVideoOutputEvents Events(this QTCaptureDecompressedVideoOutput This)
        {
            return new QTCaptureDecompressedVideoOutputEvents(This);
        }
        public static QTCaptureFileOutputEvents Events(this QTCaptureFileOutput This)
        {
            return new QTCaptureFileOutputEvents(This);
        }
    }

    public class QTCaptureDecompressedVideoOutputEvents
    {
        QTCaptureDecompressedVideoOutput This;

        public QTCaptureDecompressedVideoOutputEvents(QTCaptureDecompressedVideoOutput This)
        {
            this.This = This;
        }

        public IObservable<QTKit.QTCaptureVideoDroppedEventArgs> DidDropVideoFrame {
            get { return Observable.FromEventPattern<System.EventHandler<QTKit.QTCaptureVideoDroppedEventArgs>, QTKit.QTCaptureVideoDroppedEventArgs>(x => This.DidDropVideoFrame += x, x => This.DidDropVideoFrame -= x).Select(x => x.EventArgs); }
        }

        public IObservable<QTKit.QTCaptureVideoFrameEventArgs> DidOutputVideoFrame {
            get { return Observable.FromEventPattern<System.EventHandler<QTKit.QTCaptureVideoFrameEventArgs>, QTKit.QTCaptureVideoFrameEventArgs>(x => This.DidOutputVideoFrame += x, x => This.DidOutputVideoFrame -= x).Select(x => x.EventArgs); }
        }

    }
    public class QTCaptureFileOutputEvents
    {
        QTCaptureFileOutput This;

        public QTCaptureFileOutputEvents(QTCaptureFileOutput This)
        {
            this.This = This;
        }

        public IObservable<QTKit.QTCaptureFileErrorEventArgs> DidFinishRecording {
            get { return Observable.FromEventPattern<System.EventHandler<QTKit.QTCaptureFileErrorEventArgs>, QTKit.QTCaptureFileErrorEventArgs>(x => This.DidFinishRecording += x, x => This.DidFinishRecording -= x).Select(x => x.EventArgs); }
        }

        public IObservable<QTKit.QTCaptureFileSampleEventArgs> DidOutputSampleBuffer {
            get { return Observable.FromEventPattern<System.EventHandler<QTKit.QTCaptureFileSampleEventArgs>, QTKit.QTCaptureFileSampleEventArgs>(x => This.DidOutputSampleBuffer += x, x => This.DidOutputSampleBuffer -= x).Select(x => x.EventArgs); }
        }

        public IObservable<QTKit.QTCaptureFileUrlEventArgs> DidPauseRecording {
            get { return Observable.FromEventPattern<System.EventHandler<QTKit.QTCaptureFileUrlEventArgs>, QTKit.QTCaptureFileUrlEventArgs>(x => This.DidPauseRecording += x, x => This.DidPauseRecording -= x).Select(x => x.EventArgs); }
        }

        public IObservable<QTKit.QTCaptureFileUrlEventArgs> DidResumeRecording {
            get { return Observable.FromEventPattern<System.EventHandler<QTKit.QTCaptureFileUrlEventArgs>, QTKit.QTCaptureFileUrlEventArgs>(x => This.DidResumeRecording += x, x => This.DidResumeRecording -= x).Select(x => x.EventArgs); }
        }

        public IObservable<QTKit.QTCaptureFileUrlEventArgs> DidStartRecording {
            get { return Observable.FromEventPattern<System.EventHandler<QTKit.QTCaptureFileUrlEventArgs>, QTKit.QTCaptureFileUrlEventArgs>(x => This.DidStartRecording += x, x => This.DidStartRecording -= x).Select(x => x.EventArgs); }
        }

        public IObservable<QTKit.QTCaptureFileErrorEventArgs> MustChangeOutputFile {
            get { return Observable.FromEventPattern<System.EventHandler<QTKit.QTCaptureFileErrorEventArgs>, QTKit.QTCaptureFileErrorEventArgs>(x => This.MustChangeOutputFile += x, x => This.MustChangeOutputFile -= x).Select(x => x.EventArgs); }
        }

        public IObservable<QTKit.QTCaptureFileErrorEventArgs> WillFinishRecording {
            get { return Observable.FromEventPattern<System.EventHandler<QTKit.QTCaptureFileErrorEventArgs>, QTKit.QTCaptureFileErrorEventArgs>(x => This.WillFinishRecording += x, x => This.WillFinishRecording -= x).Select(x => x.EventArgs); }
        }

        public IObservable<QTKit.QTCaptureFileUrlEventArgs> WillStartRecording {
            get { return Observable.FromEventPattern<System.EventHandler<QTKit.QTCaptureFileUrlEventArgs>, QTKit.QTCaptureFileUrlEventArgs>(x => This.WillStartRecording += x, x => This.WillStartRecording -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace SceneKit
{
    public static class EventsMixin
    {
        public static SCNPhysicsWorldEvents Events(this SCNPhysicsWorld This)
        {
            return new SCNPhysicsWorldEvents(This);
        }
    }

    public class SCNPhysicsWorldEvents
    {
        SCNPhysicsWorld This;

        public SCNPhysicsWorldEvents(SCNPhysicsWorld This)
        {
            this.This = This;
        }

        public IObservable<SceneKit.SCNPhysicsContactEventArgs> DidBeginContact {
            get { return Observable.FromEventPattern<System.EventHandler<SceneKit.SCNPhysicsContactEventArgs>, SceneKit.SCNPhysicsContactEventArgs>(x => This.DidBeginContact += x, x => This.DidBeginContact -= x).Select(x => x.EventArgs); }
        }

        public IObservable<SceneKit.SCNPhysicsContactEventArgs> DidEndContact {
            get { return Observable.FromEventPattern<System.EventHandler<SceneKit.SCNPhysicsContactEventArgs>, SceneKit.SCNPhysicsContactEventArgs>(x => This.DidEndContact += x, x => This.DidEndContact -= x).Select(x => x.EventArgs); }
        }

        public IObservable<SceneKit.SCNPhysicsContactEventArgs> DidUpdateContact {
            get { return Observable.FromEventPattern<System.EventHandler<SceneKit.SCNPhysicsContactEventArgs>, SceneKit.SCNPhysicsContactEventArgs>(x => This.DidUpdateContact += x, x => This.DidUpdateContact -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace ImageKit
{
    public static class EventsMixin
    {
        public static IKImageBrowserViewEvents Events(this IKImageBrowserView This)
        {
            return new IKImageBrowserViewEvents(This);
        }
        public static IKCameraDeviceViewEvents Events(this IKCameraDeviceView This)
        {
            return new IKCameraDeviceViewEvents(This);
        }
        public static IKDeviceBrowserViewEvents Events(this IKDeviceBrowserView This)
        {
            return new IKDeviceBrowserViewEvents(This);
        }
        public static IKScannerDeviceViewEvents Events(this IKScannerDeviceView This)
        {
            return new IKScannerDeviceViewEvents(This);
        }
    }

    public class IKImageBrowserViewEvents
    {
        IKImageBrowserView This;

        public IKImageBrowserViewEvents(IKImageBrowserView This)
        {
            this.This = This;
        }

        public IObservable<ImageKit.IKImageBrowserViewEventEventArgs> BackgroundWasRightClicked {
            get { return Observable.FromEventPattern<System.EventHandler<ImageKit.IKImageBrowserViewEventEventArgs>, ImageKit.IKImageBrowserViewEventEventArgs>(x => This.BackgroundWasRightClicked += x, x => This.BackgroundWasRightClicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<ImageKit.IKImageBrowserViewIndexEventArgs> CellWasDoubleClicked {
            get { return Observable.FromEventPattern<System.EventHandler<ImageKit.IKImageBrowserViewIndexEventArgs>, ImageKit.IKImageBrowserViewIndexEventArgs>(x => This.CellWasDoubleClicked += x, x => This.CellWasDoubleClicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<ImageKit.IKImageBrowserViewIndexEventEventArgs> CellWasRightClicked {
            get { return Observable.FromEventPattern<System.EventHandler<ImageKit.IKImageBrowserViewIndexEventEventArgs>, ImageKit.IKImageBrowserViewIndexEventEventArgs>(x => This.CellWasRightClicked += x, x => This.CellWasRightClicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionDidChange {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionDidChange += x, x => This.SelectionDidChange -= x).Select(x => x.EventArgs); }
        }

    }
    public class IKCameraDeviceViewEvents
    {
        IKCameraDeviceView This;

        public IKCameraDeviceViewEvents(IKCameraDeviceView This)
        {
            this.This = This;
        }

        public IObservable<ImageKit.IKCameraDeviceViewNSErrorEventArgs> DidEncounterError {
            get { return Observable.FromEventPattern<System.EventHandler<ImageKit.IKCameraDeviceViewNSErrorEventArgs>, ImageKit.IKCameraDeviceViewNSErrorEventArgs>(x => This.DidEncounterError += x, x => This.DidEncounterError -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionDidChange {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionDidChange += x, x => This.SelectionDidChange -= x).Select(x => x.EventArgs); }
        }

    }
    public class IKDeviceBrowserViewEvents
    {
        IKDeviceBrowserView This;

        public IKDeviceBrowserViewEvents(IKDeviceBrowserView This)
        {
            this.This = This;
        }

        public IObservable<ImageKit.IKDeviceBrowserViewNSErrorEventArgs> DidEncounterError {
            get { return Observable.FromEventPattern<System.EventHandler<ImageKit.IKDeviceBrowserViewNSErrorEventArgs>, ImageKit.IKDeviceBrowserViewNSErrorEventArgs>(x => This.DidEncounterError += x, x => This.DidEncounterError -= x).Select(x => x.EventArgs); }
        }

    }
    public class IKScannerDeviceViewEvents
    {
        IKScannerDeviceView This;

        public IKScannerDeviceViewEvents(IKScannerDeviceView This)
        {
            this.This = This;
        }

        public IObservable<ImageKit.IKScannerDeviceViewErrorEventArgs> DidEncounterError {
            get { return Observable.FromEventPattern<System.EventHandler<ImageKit.IKScannerDeviceViewErrorEventArgs>, ImageKit.IKScannerDeviceViewErrorEventArgs>(x => This.DidEncounterError += x, x => This.DidEncounterError -= x).Select(x => x.EventArgs); }
        }

        public IObservable<ImageKit.IKScannerDeviceViewScanEventArgs> DidScan {
            get { return Observable.FromEventPattern<System.EventHandler<ImageKit.IKScannerDeviceViewScanEventArgs>, ImageKit.IKScannerDeviceViewScanEventArgs>(x => This.DidScan += x, x => This.DidScan -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace SpriteKit
{
    public static class EventsMixin
    {
        public static SKPhysicsWorldEvents Events(this SKPhysicsWorld This)
        {
            return new SKPhysicsWorldEvents(This);
        }
    }

    public class SKPhysicsWorldEvents
    {
        SKPhysicsWorld This;

        public SKPhysicsWorldEvents(SKPhysicsWorld This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidBeginContact {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidBeginContact += x, x => This.DidBeginContact -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidEndContact {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidEndContact += x, x => This.DidEndContact -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace StoreKit
{
    public static class EventsMixin
    {
        public static SKProductsRequestEvents Events(this SKProductsRequest This)
        {
            return new SKProductsRequestEvents(This);
        }
        public static SKRequestEvents Events(this SKRequest This)
        {
            return new SKRequestEvents(This);
        }
    }

    public class SKProductsRequestEvents
        : StoreKit.SKRequestEvents
    {
        SKProductsRequest This;

        public SKProductsRequestEvents(SKProductsRequest This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<StoreKit.SKProductsRequestResponseEventArgs> ReceivedResponse {
            get { return Observable.FromEventPattern<System.EventHandler<StoreKit.SKProductsRequestResponseEventArgs>, StoreKit.SKProductsRequestResponseEventArgs>(x => This.ReceivedResponse += x, x => This.ReceivedResponse -= x).Select(x => x.EventArgs); }
        }

    }
    public class SKRequestEvents
    {
        SKRequest This;

        public SKRequestEvents(SKRequest This)
        {
            this.This = This;
        }

        public IObservable<StoreKit.SKRequestErrorEventArgs> RequestFailed {
            get { return Observable.FromEventPattern<System.EventHandler<StoreKit.SKRequestErrorEventArgs>, StoreKit.SKRequestErrorEventArgs>(x => This.RequestFailed += x, x => This.RequestFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> RequestFinished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.RequestFinished += x, x => This.RequestFinished -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace CoreMidi
{
    public static class EventsMixin
    {
        public static MidiClientEvents Events(this MidiClient This)
        {
            return new MidiClientEvents(This);
        }
        public static MidiPortEvents Events(this MidiPort This)
        {
            return new MidiPortEvents(This);
        }
        public static MidiEndpointEvents Events(this MidiEndpoint This)
        {
            return new MidiEndpointEvents(This);
        }
    }

    public class MidiClientEvents
    {
        MidiClient This;

        public MidiClientEvents(MidiClient This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> SetupChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SetupChanged += x, x => This.SetupChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreMidi.ObjectAddedOrRemovedEventArgs> ObjectAdded {
            get { return Observable.FromEventPattern<System.EventHandler<CoreMidi.ObjectAddedOrRemovedEventArgs>, CoreMidi.ObjectAddedOrRemovedEventArgs>(x => This.ObjectAdded += x, x => This.ObjectAdded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreMidi.ObjectAddedOrRemovedEventArgs> ObjectRemoved {
            get { return Observable.FromEventPattern<System.EventHandler<CoreMidi.ObjectAddedOrRemovedEventArgs>, CoreMidi.ObjectAddedOrRemovedEventArgs>(x => This.ObjectRemoved += x, x => This.ObjectRemoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreMidi.ObjectPropertyChangedEventArgs> PropertyChanged {
            get { return Observable.FromEventPattern<System.EventHandler<CoreMidi.ObjectPropertyChangedEventArgs>, CoreMidi.ObjectPropertyChangedEventArgs>(x => This.PropertyChanged += x, x => This.PropertyChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ThruConnectionsChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ThruConnectionsChanged += x, x => This.ThruConnectionsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SerialPortOwnerChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SerialPortOwnerChanged += x, x => This.SerialPortOwnerChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreMidi.IOErrorEventArgs> IOError {
            get { return Observable.FromEventPattern<System.EventHandler<CoreMidi.IOErrorEventArgs>, CoreMidi.IOErrorEventArgs>(x => This.IOError += x, x => This.IOError -= x).Select(x => x.EventArgs); }
        }

    }
    public class MidiPortEvents
    {
        MidiPort This;

        public MidiPortEvents(MidiPort This)
        {
            this.This = This;
        }

        public IObservable<CoreMidi.MidiPacketsEventArgs> MessageReceived {
            get { return Observable.FromEventPattern<System.EventHandler<CoreMidi.MidiPacketsEventArgs>, CoreMidi.MidiPacketsEventArgs>(x => This.MessageReceived += x, x => This.MessageReceived -= x).Select(x => x.EventArgs); }
        }

    }
    public class MidiEndpointEvents
    {
        MidiEndpoint This;

        public MidiEndpointEvents(MidiEndpoint This)
        {
            this.This = This;
        }

        public IObservable<CoreMidi.MidiPacketsEventArgs> MessageReceived {
            get { return Observable.FromEventPattern<System.EventHandler<CoreMidi.MidiPacketsEventArgs>, CoreMidi.MidiPacketsEventArgs>(x => This.MessageReceived += x, x => This.MessageReceived -= x).Select(x => x.EventArgs); }
        }

    }
}

namespace AVFoundation.Rx
{
    public abstract partial class AVAssetResourceLoaderDelegateRx : AVAssetResourceLoaderDelegate
    {
        readonly SingleAwaitSubject<Tuple<AVFoundation.AVAssetResourceLoader, Foundation.NSUrlAuthenticationChallenge>> _DidCancelAuthenticationChallenge = new SingleAwaitSubject<Tuple<AVFoundation.AVAssetResourceLoader, Foundation.NSUrlAuthenticationChallenge>>();
        public IObservable<Tuple<AVFoundation.AVAssetResourceLoader, Foundation.NSUrlAuthenticationChallenge>> DidCancelAuthenticationChallengeObs { get { return _DidCancelAuthenticationChallenge; } }
        public override void DidCancelAuthenticationChallenge(AVFoundation.AVAssetResourceLoader resourceLoader, Foundation.NSUrlAuthenticationChallenge authenticationChallenge)
        {
            _DidCancelAuthenticationChallenge.OnNext(Tuple.Create(resourceLoader, authenticationChallenge));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVAssetResourceLoader, AVFoundation.AVAssetResourceLoadingRequest>> _DidCancelLoadingRequest = new SingleAwaitSubject<Tuple<AVFoundation.AVAssetResourceLoader, AVFoundation.AVAssetResourceLoadingRequest>>();
        public IObservable<Tuple<AVFoundation.AVAssetResourceLoader, AVFoundation.AVAssetResourceLoadingRequest>> DidCancelLoadingRequestObs { get { return _DidCancelLoadingRequest; } }
        public override void DidCancelLoadingRequest(AVFoundation.AVAssetResourceLoader resourceLoader, AVFoundation.AVAssetResourceLoadingRequest loadingRequest)
        {
            _DidCancelLoadingRequest.OnNext(Tuple.Create(resourceLoader, loadingRequest));
        }

    }
    public  partial class AVAudioPlayerDelegateRx : AVAudioPlayerDelegate
    {
        readonly SingleAwaitSubject<Tuple<AVFoundation.AVAudioPlayer, Foundation.NSError>> _DecoderError = new SingleAwaitSubject<Tuple<AVFoundation.AVAudioPlayer, Foundation.NSError>>();
        public IObservable<Tuple<AVFoundation.AVAudioPlayer, Foundation.NSError>> DecoderErrorObs { get { return _DecoderError; } }
        public override void DecoderError(AVFoundation.AVAudioPlayer player, Foundation.NSError error)
        {
            _DecoderError.OnNext(Tuple.Create(player, error));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVAudioPlayer, System.Boolean>> _FinishedPlaying = new SingleAwaitSubject<Tuple<AVFoundation.AVAudioPlayer, System.Boolean>>();
        public IObservable<Tuple<AVFoundation.AVAudioPlayer, System.Boolean>> FinishedPlayingObs { get { return _FinishedPlaying; } }
        public override void FinishedPlaying(AVFoundation.AVAudioPlayer player, System.Boolean flag)
        {
            _FinishedPlaying.OnNext(Tuple.Create(player, flag));
        }

    }
    public  partial class AVAudioRecorderDelegateRx : AVAudioRecorderDelegate
    {
        readonly SingleAwaitSubject<Tuple<AVFoundation.AVAudioRecorder, Foundation.NSError>> _EncoderError = new SingleAwaitSubject<Tuple<AVFoundation.AVAudioRecorder, Foundation.NSError>>();
        public IObservable<Tuple<AVFoundation.AVAudioRecorder, Foundation.NSError>> EncoderErrorObs { get { return _EncoderError; } }
        public override void EncoderError(AVFoundation.AVAudioRecorder recorder, Foundation.NSError error)
        {
            _EncoderError.OnNext(Tuple.Create(recorder, error));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVAudioRecorder, System.Boolean>> _FinishedRecording = new SingleAwaitSubject<Tuple<AVFoundation.AVAudioRecorder, System.Boolean>>();
        public IObservable<Tuple<AVFoundation.AVAudioRecorder, System.Boolean>> FinishedRecordingObs { get { return _FinishedRecording; } }
        public override void FinishedRecording(AVFoundation.AVAudioRecorder recorder, System.Boolean flag)
        {
            _FinishedRecording.OnNext(Tuple.Create(recorder, flag));
        }

    }
    public  partial class AVCaptureAudioDataOutputSampleBufferDelegateRx : AVCaptureAudioDataOutputSampleBufferDelegate
    {
        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCaptureOutput, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureConnection>> _DidOutputSampleBuffer = new SingleAwaitSubject<Tuple<AVFoundation.AVCaptureOutput, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureConnection>>();
        public IObservable<Tuple<AVFoundation.AVCaptureOutput, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureConnection>> DidOutputSampleBufferObs { get { return _DidOutputSampleBuffer; } }
        public override void DidOutputSampleBuffer(AVFoundation.AVCaptureOutput captureOutput, CoreMedia.CMSampleBuffer sampleBuffer, AVFoundation.AVCaptureConnection connection)
        {
            _DidOutputSampleBuffer.OnNext(Tuple.Create(captureOutput, sampleBuffer, connection));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCaptureOutput, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureConnection>> _DidDropSampleBuffer = new SingleAwaitSubject<Tuple<AVFoundation.AVCaptureOutput, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureConnection>>();
        public IObservable<Tuple<AVFoundation.AVCaptureOutput, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureConnection>> DidDropSampleBufferObs { get { return _DidDropSampleBuffer; } }
        public override void DidDropSampleBuffer(AVFoundation.AVCaptureOutput captureOutput, CoreMedia.CMSampleBuffer sampleBuffer, AVFoundation.AVCaptureConnection connection)
        {
            _DidDropSampleBuffer.OnNext(Tuple.Create(captureOutput, sampleBuffer, connection));
        }

    }
    public  partial class AVCaptureVideoDataOutputSampleBufferDelegateRx : AVCaptureVideoDataOutputSampleBufferDelegate
    {
        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCaptureOutput, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureConnection>> _DidDropSampleBuffer = new SingleAwaitSubject<Tuple<AVFoundation.AVCaptureOutput, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureConnection>>();
        public IObservable<Tuple<AVFoundation.AVCaptureOutput, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureConnection>> DidDropSampleBufferObs { get { return _DidDropSampleBuffer; } }
        public override void DidDropSampleBuffer(AVFoundation.AVCaptureOutput captureOutput, CoreMedia.CMSampleBuffer sampleBuffer, AVFoundation.AVCaptureConnection connection)
        {
            _DidDropSampleBuffer.OnNext(Tuple.Create(captureOutput, sampleBuffer, connection));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCaptureOutput, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureConnection>> _DidOutputSampleBuffer = new SingleAwaitSubject<Tuple<AVFoundation.AVCaptureOutput, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureConnection>>();
        public IObservable<Tuple<AVFoundation.AVCaptureOutput, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureConnection>> DidOutputSampleBufferObs { get { return _DidOutputSampleBuffer; } }
        public override void DidOutputSampleBuffer(AVFoundation.AVCaptureOutput captureOutput, CoreMedia.CMSampleBuffer sampleBuffer, AVFoundation.AVCaptureConnection connection)
        {
            _DidOutputSampleBuffer.OnNext(Tuple.Create(captureOutput, sampleBuffer, connection));
        }

    }
    public abstract partial class AVCaptureFileOutputRecordingDelegateRx : AVCaptureFileOutputRecordingDelegate
    {
        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCaptureFileOutput, Foundation.NSUrl, Foundation.NSObject[]>> _DidStartRecording = new SingleAwaitSubject<Tuple<AVFoundation.AVCaptureFileOutput, Foundation.NSUrl, Foundation.NSObject[]>>();
        public IObservable<Tuple<AVFoundation.AVCaptureFileOutput, Foundation.NSUrl, Foundation.NSObject[]>> DidStartRecordingObs { get { return _DidStartRecording; } }
        public override void DidStartRecording(AVFoundation.AVCaptureFileOutput captureOutput, Foundation.NSUrl outputFileUrl, Foundation.NSObject[] connections)
        {
            _DidStartRecording.OnNext(Tuple.Create(captureOutput, outputFileUrl, connections));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCaptureFileOutput, Foundation.NSUrl, Foundation.NSObject[], Foundation.NSError>> _FinishedRecording = new SingleAwaitSubject<Tuple<AVFoundation.AVCaptureFileOutput, Foundation.NSUrl, Foundation.NSObject[], Foundation.NSError>>();
        public IObservable<Tuple<AVFoundation.AVCaptureFileOutput, Foundation.NSUrl, Foundation.NSObject[], Foundation.NSError>> FinishedRecordingObs { get { return _FinishedRecording; } }
        public override void FinishedRecording(AVFoundation.AVCaptureFileOutput captureOutput, Foundation.NSUrl outputFileUrl, Foundation.NSObject[] connections, Foundation.NSError error)
        {
            _FinishedRecording.OnNext(Tuple.Create(captureOutput, outputFileUrl, connections, error));
        }

    }
    public abstract partial class AVPlayerItemMetadataCollectorPushDelegateRx : AVPlayerItemMetadataCollectorPushDelegate
    {
        readonly SingleAwaitSubject<Tuple<AVFoundation.AVPlayerItemMetadataCollector, AVFoundation.AVDateRangeMetadataGroup[], Foundation.NSIndexSet, Foundation.NSIndexSet>> _DidCollectDateRange = new SingleAwaitSubject<Tuple<AVFoundation.AVPlayerItemMetadataCollector, AVFoundation.AVDateRangeMetadataGroup[], Foundation.NSIndexSet, Foundation.NSIndexSet>>();
        public IObservable<Tuple<AVFoundation.AVPlayerItemMetadataCollector, AVFoundation.AVDateRangeMetadataGroup[], Foundation.NSIndexSet, Foundation.NSIndexSet>> DidCollectDateRangeObs { get { return _DidCollectDateRange; } }
        public override void DidCollectDateRange(AVFoundation.AVPlayerItemMetadataCollector metadataCollector, AVFoundation.AVDateRangeMetadataGroup[] metadataGroups, Foundation.NSIndexSet indexesOfNewGroups, Foundation.NSIndexSet indexesOfModifiedGroups)
        {
            _DidCollectDateRange.OnNext(Tuple.Create(metadataCollector, metadataGroups, indexesOfNewGroups, indexesOfModifiedGroups));
        }

    }
    public  partial class AVPlayerItemMetadataOutputPushDelegateRx : AVPlayerItemMetadataOutputPushDelegate
    {
        readonly SingleAwaitSubject<AVFoundation.AVPlayerItemOutput> _OutputSequenceWasFlushed = new SingleAwaitSubject<AVFoundation.AVPlayerItemOutput>();
        public IObservable<AVFoundation.AVPlayerItemOutput> OutputSequenceWasFlushedObs { get { return _OutputSequenceWasFlushed; } }
        public override void OutputSequenceWasFlushed(AVFoundation.AVPlayerItemOutput output)
        {
            _OutputSequenceWasFlushed.OnNext(output);
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVPlayerItemMetadataOutput, AVFoundation.AVTimedMetadataGroup[], AVFoundation.AVPlayerItemTrack>> _DidOutputTimedMetadataGroups = new SingleAwaitSubject<Tuple<AVFoundation.AVPlayerItemMetadataOutput, AVFoundation.AVTimedMetadataGroup[], AVFoundation.AVPlayerItemTrack>>();
        public IObservable<Tuple<AVFoundation.AVPlayerItemMetadataOutput, AVFoundation.AVTimedMetadataGroup[], AVFoundation.AVPlayerItemTrack>> DidOutputTimedMetadataGroupsObs { get { return _DidOutputTimedMetadataGroups; } }
        public override void DidOutputTimedMetadataGroups(AVFoundation.AVPlayerItemMetadataOutput output, AVFoundation.AVTimedMetadataGroup[] groups, AVFoundation.AVPlayerItemTrack track)
        {
            _DidOutputTimedMetadataGroups.OnNext(Tuple.Create(output, groups, track));
        }

    }
    public  partial class AVPlayerItemOutputPullDelegateRx : AVPlayerItemOutputPullDelegate
    {
        readonly SingleAwaitSubject<AVFoundation.AVPlayerItemOutput> _OutputMediaDataWillChange = new SingleAwaitSubject<AVFoundation.AVPlayerItemOutput>();
        public IObservable<AVFoundation.AVPlayerItemOutput> OutputMediaDataWillChangeObs { get { return _OutputMediaDataWillChange; } }
        public override void OutputMediaDataWillChange(AVFoundation.AVPlayerItemOutput sender)
        {
            _OutputMediaDataWillChange.OnNext(sender);
        }

        readonly SingleAwaitSubject<AVFoundation.AVPlayerItemOutput> _OutputSequenceWasFlushed = new SingleAwaitSubject<AVFoundation.AVPlayerItemOutput>();
        public IObservable<AVFoundation.AVPlayerItemOutput> OutputSequenceWasFlushedObs { get { return _OutputSequenceWasFlushed; } }
        public override void OutputSequenceWasFlushed(AVFoundation.AVPlayerItemOutput output)
        {
            _OutputSequenceWasFlushed.OnNext(output);
        }

    }
    public  partial class AVPlayerItemOutputPushDelegateRx : AVPlayerItemOutputPushDelegate
    {
        readonly SingleAwaitSubject<AVFoundation.AVPlayerItemOutput> _OutputSequenceWasFlushed = new SingleAwaitSubject<AVFoundation.AVPlayerItemOutput>();
        public IObservable<AVFoundation.AVPlayerItemOutput> OutputSequenceWasFlushedObs { get { return _OutputSequenceWasFlushed; } }
        public override void OutputSequenceWasFlushed(AVFoundation.AVPlayerItemOutput output)
        {
            _OutputSequenceWasFlushed.OnNext(output);
        }

    }
}
namespace WebKit.Rx
{
    public  partial class WebFrameLoadDelegateRx : WebFrameLoadDelegate
    {
        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>> _CanceledClientRedirect = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.WebFrame>> CanceledClientRedirectObs { get { return _CanceledClientRedirect; } }
        public override void CanceledClientRedirect(WebKit.WebView sender, WebKit.WebFrame forFrame)
        {
            _CanceledClientRedirect.OnNext(Tuple.Create(sender, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>> _ChangedLocationWithinPage = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.WebFrame>> ChangedLocationWithinPageObs { get { return _ChangedLocationWithinPage; } }
        public override void ChangedLocationWithinPage(WebKit.WebView sender, WebKit.WebFrame forFrame)
        {
            _ChangedLocationWithinPage.OnNext(Tuple.Create(sender, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebScriptObject, WebKit.WebFrame>> _ClearedWindowObject = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebScriptObject, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.WebScriptObject, WebKit.WebFrame>> ClearedWindowObjectObs { get { return _ClearedWindowObject; } }
        public override void ClearedWindowObject(WebKit.WebView webView, WebKit.WebScriptObject windowObject, WebKit.WebFrame forFrame)
        {
            _ClearedWindowObject.OnNext(Tuple.Create(webView, windowObject, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>> _CommitedLoad = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.WebFrame>> CommitedLoadObs { get { return _CommitedLoad; } }
        public override void CommitedLoad(WebKit.WebView sender, WebKit.WebFrame forFrame)
        {
            _CommitedLoad.OnNext(Tuple.Create(sender, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSError, WebKit.WebFrame>> _FailedLoadWithError = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSError, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSError, WebKit.WebFrame>> FailedLoadWithErrorObs { get { return _FailedLoadWithError; } }
        public override void FailedLoadWithError(WebKit.WebView sender, Foundation.NSError error, WebKit.WebFrame forFrame)
        {
            _FailedLoadWithError.OnNext(Tuple.Create(sender, error, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSError, WebKit.WebFrame>> _FailedProvisionalLoad = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSError, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSError, WebKit.WebFrame>> FailedProvisionalLoadObs { get { return _FailedProvisionalLoad; } }
        public override void FailedProvisionalLoad(WebKit.WebView sender, Foundation.NSError error, WebKit.WebFrame forFrame)
        {
            _FailedProvisionalLoad.OnNext(Tuple.Create(sender, error, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>> _FinishedLoad = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.WebFrame>> FinishedLoadObs { get { return _FinishedLoad; } }
        public override void FinishedLoad(WebKit.WebView sender, WebKit.WebFrame forFrame)
        {
            _FinishedLoad.OnNext(Tuple.Create(sender, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, AppKit.NSImage, WebKit.WebFrame>> _ReceivedIcon = new SingleAwaitSubject<Tuple<WebKit.WebView, AppKit.NSImage, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, AppKit.NSImage, WebKit.WebFrame>> ReceivedIconObs { get { return _ReceivedIcon; } }
        public override void ReceivedIcon(WebKit.WebView sender, AppKit.NSImage image, WebKit.WebFrame forFrame)
        {
            _ReceivedIcon.OnNext(Tuple.Create(sender, image, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>> _ReceivedServerRedirectForProvisionalLoad = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.WebFrame>> ReceivedServerRedirectForProvisionalLoadObs { get { return _ReceivedServerRedirectForProvisionalLoad; } }
        public override void ReceivedServerRedirectForProvisionalLoad(WebKit.WebView sender, WebKit.WebFrame forFrame)
        {
            _ReceivedServerRedirectForProvisionalLoad.OnNext(Tuple.Create(sender, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, string, WebKit.WebFrame>> _ReceivedTitle = new SingleAwaitSubject<Tuple<WebKit.WebView, string, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, string, WebKit.WebFrame>> ReceivedTitleObs { get { return _ReceivedTitle; } }
        public override void ReceivedTitle(WebKit.WebView sender, string title, WebKit.WebFrame forFrame)
        {
            _ReceivedTitle.OnNext(Tuple.Create(sender, title, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>> _StartedProvisionalLoad = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.WebFrame>> StartedProvisionalLoadObs { get { return _StartedProvisionalLoad; } }
        public override void StartedProvisionalLoad(WebKit.WebView sender, WebKit.WebFrame forFrame)
        {
            _StartedProvisionalLoad.OnNext(Tuple.Create(sender, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>> _WillCloseFrame = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.WebFrame>> WillCloseFrameObs { get { return _WillCloseFrame; } }
        public override void WillCloseFrame(WebKit.WebView sender, WebKit.WebFrame forFrame)
        {
            _WillCloseFrame.OnNext(Tuple.Create(sender, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSUrl, System.Double, Foundation.NSDate, WebKit.WebFrame>> _WillPerformClientRedirect = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSUrl, System.Double, Foundation.NSDate, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSUrl, System.Double, Foundation.NSDate, WebKit.WebFrame>> WillPerformClientRedirectObs { get { return _WillPerformClientRedirect; } }
        public override void WillPerformClientRedirect(WebKit.WebView sender, Foundation.NSUrl toUrl, System.Double secondsDelay, Foundation.NSDate fireDate, WebKit.WebFrame forFrame)
        {
            _WillPerformClientRedirect.OnNext(Tuple.Create(sender, toUrl, secondsDelay, fireDate, forFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebScriptObject>> _WindowScriptObjectAvailable = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebScriptObject>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.WebScriptObject>> WindowScriptObjectAvailableObs { get { return _WindowScriptObjectAvailable; } }
        public override void WindowScriptObjectAvailable(WebKit.WebView webView, WebKit.WebScriptObject windowScriptObject)
        {
            _WindowScriptObjectAvailable.OnNext(Tuple.Create(webView, windowScriptObject));
        }

    }
    public  partial class WebPolicyDelegateRx : WebPolicyDelegate
    {
        readonly SingleAwaitSubject<Tuple<WebKit.WebView, string, Foundation.NSUrlRequest, WebKit.WebFrame, Foundation.NSObject>> _DecidePolicyForMimeType = new SingleAwaitSubject<Tuple<WebKit.WebView, string, Foundation.NSUrlRequest, WebKit.WebFrame, Foundation.NSObject>>();
        public IObservable<Tuple<WebKit.WebView, string, Foundation.NSUrlRequest, WebKit.WebFrame, Foundation.NSObject>> DecidePolicyForMimeTypeObs { get { return _DecidePolicyForMimeType; } }
        public override void DecidePolicyForMimeType(WebKit.WebView webView, string mimeType, Foundation.NSUrlRequest request, WebKit.WebFrame frame, Foundation.NSObject decisionToken)
        {
            _DecidePolicyForMimeType.OnNext(Tuple.Create(webView, mimeType, request, frame, decisionToken));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSDictionary, Foundation.NSUrlRequest, WebKit.WebFrame, Foundation.NSObject>> _DecidePolicyForNavigation = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSDictionary, Foundation.NSUrlRequest, WebKit.WebFrame, Foundation.NSObject>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSDictionary, Foundation.NSUrlRequest, WebKit.WebFrame, Foundation.NSObject>> DecidePolicyForNavigationObs { get { return _DecidePolicyForNavigation; } }
        public override void DecidePolicyForNavigation(WebKit.WebView webView, Foundation.NSDictionary actionInformation, Foundation.NSUrlRequest request, WebKit.WebFrame frame, Foundation.NSObject decisionToken)
        {
            _DecidePolicyForNavigation.OnNext(Tuple.Create(webView, actionInformation, request, frame, decisionToken));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSDictionary, Foundation.NSUrlRequest, string, Foundation.NSObject>> _DecidePolicyForNewWindow = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSDictionary, Foundation.NSUrlRequest, string, Foundation.NSObject>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSDictionary, Foundation.NSUrlRequest, string, Foundation.NSObject>> DecidePolicyForNewWindowObs { get { return _DecidePolicyForNewWindow; } }
        public override void DecidePolicyForNewWindow(WebKit.WebView webView, Foundation.NSDictionary actionInformation, Foundation.NSUrlRequest request, string newFrameName, Foundation.NSObject decisionToken)
        {
            _DecidePolicyForNewWindow.OnNext(Tuple.Create(webView, actionInformation, request, newFrameName, decisionToken));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSError, WebKit.WebFrame>> _UnableToImplementPolicy = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSError, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSError, WebKit.WebFrame>> UnableToImplementPolicyObs { get { return _UnableToImplementPolicy; } }
        public override void UnableToImplementPolicy(WebKit.WebView webView, Foundation.NSError error, WebKit.WebFrame frame)
        {
            _UnableToImplementPolicy.OnNext(Tuple.Create(webView, error, frame));
        }

    }
    public  partial class WebResourceLoadDelegateRx : WebResourceLoadDelegate
    {
        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSObject, Foundation.NSUrlAuthenticationChallenge, WebKit.WebDataSource>> _OnCancelledAuthenticationChallenge = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSObject, Foundation.NSUrlAuthenticationChallenge, WebKit.WebDataSource>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSObject, Foundation.NSUrlAuthenticationChallenge, WebKit.WebDataSource>> OnCancelledAuthenticationChallengeObs { get { return _OnCancelledAuthenticationChallenge; } }
        public override void OnCancelledAuthenticationChallenge(WebKit.WebView sender, Foundation.NSObject identifier, Foundation.NSUrlAuthenticationChallenge challenge, WebKit.WebDataSource dataSource)
        {
            _OnCancelledAuthenticationChallenge.OnNext(Tuple.Create(sender, identifier, challenge, dataSource));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSObject, Foundation.NSError, WebKit.WebDataSource>> _OnFailedLoading = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSObject, Foundation.NSError, WebKit.WebDataSource>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSObject, Foundation.NSError, WebKit.WebDataSource>> OnFailedLoadingObs { get { return _OnFailedLoading; } }
        public override void OnFailedLoading(WebKit.WebView sender, Foundation.NSObject identifier, Foundation.NSError withError, WebKit.WebDataSource dataSource)
        {
            _OnFailedLoading.OnNext(Tuple.Create(sender, identifier, withError, dataSource));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSObject, WebKit.WebDataSource>> _OnFinishedLoading = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSObject, WebKit.WebDataSource>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSObject, WebKit.WebDataSource>> OnFinishedLoadingObs { get { return _OnFinishedLoading; } }
        public override void OnFinishedLoading(WebKit.WebView sender, Foundation.NSObject identifier, WebKit.WebDataSource dataSource)
        {
            _OnFinishedLoading.OnNext(Tuple.Create(sender, identifier, dataSource));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSError, WebKit.WebDataSource>> _OnPlugInFailed = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSError, WebKit.WebDataSource>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSError, WebKit.WebDataSource>> OnPlugInFailedObs { get { return _OnPlugInFailed; } }
        public override void OnPlugInFailed(WebKit.WebView sender, Foundation.NSError error, WebKit.WebDataSource dataSource)
        {
            _OnPlugInFailed.OnNext(Tuple.Create(sender, error, dataSource));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSObject, Foundation.NSUrlAuthenticationChallenge, WebKit.WebDataSource>> _OnReceivedAuthenticationChallenge = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSObject, Foundation.NSUrlAuthenticationChallenge, WebKit.WebDataSource>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSObject, Foundation.NSUrlAuthenticationChallenge, WebKit.WebDataSource>> OnReceivedAuthenticationChallengeObs { get { return _OnReceivedAuthenticationChallenge; } }
        public override void OnReceivedAuthenticationChallenge(WebKit.WebView sender, Foundation.NSObject identifier, Foundation.NSUrlAuthenticationChallenge challenge, WebKit.WebDataSource dataSource)
        {
            _OnReceivedAuthenticationChallenge.OnNext(Tuple.Create(sender, identifier, challenge, dataSource));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSObject, System.nint, WebKit.WebDataSource>> _OnReceivedContentLength = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSObject, System.nint, WebKit.WebDataSource>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSObject, System.nint, WebKit.WebDataSource>> OnReceivedContentLengthObs { get { return _OnReceivedContentLength; } }
        public override void OnReceivedContentLength(WebKit.WebView sender, Foundation.NSObject identifier, System.nint length, WebKit.WebDataSource dataSource)
        {
            _OnReceivedContentLength.OnNext(Tuple.Create(sender, identifier, length, dataSource));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSObject, Foundation.NSUrlResponse, WebKit.WebDataSource>> _OnReceivedResponse = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSObject, Foundation.NSUrlResponse, WebKit.WebDataSource>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSObject, Foundation.NSUrlResponse, WebKit.WebDataSource>> OnReceivedResponseObs { get { return _OnReceivedResponse; } }
        public override void OnReceivedResponse(WebKit.WebView sender, Foundation.NSObject identifier, Foundation.NSUrlResponse responseReceived, WebKit.WebDataSource dataSource)
        {
            _OnReceivedResponse.OnNext(Tuple.Create(sender, identifier, responseReceived, dataSource));
        }

    }
    public  partial class WebUIDelegateRx : WebUIDelegate
    {
        readonly SingleAwaitSubject<WebKit.WebView> _UIClose = new SingleAwaitSubject<WebKit.WebView>();
        public IObservable<WebKit.WebView> UICloseObs { get { return _UIClose; } }
        public override void UIClose(WebKit.WebView sender)
        {
            _UIClose.OnNext(sender);
        }

        readonly SingleAwaitSubject<WebKit.WebView> _UIFocus = new SingleAwaitSubject<WebKit.WebView>();
        public IObservable<WebKit.WebView> UIFocusObs { get { return _UIFocus; } }
        public override void UIFocus(WebKit.WebView sender)
        {
            _UIFocus.OnNext(sender);
        }

        readonly SingleAwaitSubject<WebKit.WebView> _UIRunModal = new SingleAwaitSubject<WebKit.WebView>();
        public IObservable<WebKit.WebView> UIRunModalObs { get { return _UIRunModal; } }
        public override void UIRunModal(WebKit.WebView sender)
        {
            _UIRunModal.OnNext(sender);
        }

        readonly SingleAwaitSubject<WebKit.WebView> _UIShow = new SingleAwaitSubject<WebKit.WebView>();
        public IObservable<WebKit.WebView> UIShowObs { get { return _UIShow; } }
        public override void UIShow(WebKit.WebView sender)
        {
            _UIShow.OnNext(sender);
        }

        readonly SingleAwaitSubject<WebKit.WebView> _UIUnfocus = new SingleAwaitSubject<WebKit.WebView>();
        public IObservable<WebKit.WebView> UIUnfocusObs { get { return _UIUnfocus; } }
        public override void UIUnfocus(WebKit.WebView sender)
        {
            _UIUnfocus.OnNext(sender);
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, CoreGraphics.CGRect>> _UIDrawFooterInRect = new SingleAwaitSubject<Tuple<WebKit.WebView, CoreGraphics.CGRect>>();
        public IObservable<Tuple<WebKit.WebView, CoreGraphics.CGRect>> UIDrawFooterInRectObs { get { return _UIDrawFooterInRect; } }
        public override void UIDrawFooterInRect(WebKit.WebView sender, CoreGraphics.CGRect rect)
        {
            _UIDrawFooterInRect.OnNext(Tuple.Create(sender, rect));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, CoreGraphics.CGRect>> _UIDrawHeaderInRect = new SingleAwaitSubject<Tuple<WebKit.WebView, CoreGraphics.CGRect>>();
        public IObservable<Tuple<WebKit.WebView, CoreGraphics.CGRect>> UIDrawHeaderInRectObs { get { return _UIDrawHeaderInRect; } }
        public override void UIDrawHeaderInRect(WebKit.WebView sender, CoreGraphics.CGRect rect)
        {
            _UIDrawHeaderInRect.OnNext(Tuple.Create(sender, rect));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, AppKit.NSResponder>> _UIMakeFirstResponder = new SingleAwaitSubject<Tuple<WebKit.WebView, AppKit.NSResponder>>();
        public IObservable<Tuple<WebKit.WebView, AppKit.NSResponder>> UIMakeFirstResponderObs { get { return _UIMakeFirstResponder; } }
        public override void UIMakeFirstResponder(WebKit.WebView sender, AppKit.NSResponder newResponder)
        {
            _UIMakeFirstResponder.OnNext(Tuple.Create(sender, newResponder));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSDictionary, AppKit.NSEventModifierMask>> _UIMouseDidMoveOverElement = new SingleAwaitSubject<Tuple<WebKit.WebView, Foundation.NSDictionary, AppKit.NSEventModifierMask>>();
        public IObservable<Tuple<WebKit.WebView, Foundation.NSDictionary, AppKit.NSEventModifierMask>> UIMouseDidMoveOverElementObs { get { return _UIMouseDidMoveOverElement; } }
        public override void UIMouseDidMoveOverElement(WebKit.WebView sender, Foundation.NSDictionary elementInformation, AppKit.NSEventModifierMask modifierFlags)
        {
            _UIMouseDidMoveOverElement.OnNext(Tuple.Create(sender, elementInformation, modifierFlags));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrameView>> _UIPrintFrameView = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebFrameView>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.WebFrameView>> UIPrintFrameViewObs { get { return _UIPrintFrameView; } }
        public override void UIPrintFrameView(WebKit.WebView sender, WebKit.WebFrameView frameView)
        {
            _UIPrintFrameView.OnNext(Tuple.Create(sender, frameView));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, string>> _UIRunJavaScriptAlertPanel = new SingleAwaitSubject<Tuple<WebKit.WebView, string>>();
        public IObservable<Tuple<WebKit.WebView, string>> UIRunJavaScriptAlertPanelObs { get { return _UIRunJavaScriptAlertPanel; } }
        public override void UIRunJavaScriptAlertPanel(WebKit.WebView sender, string message)
        {
            _UIRunJavaScriptAlertPanel.OnNext(Tuple.Create(sender, message));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, string, WebKit.WebFrame>> _UIRunJavaScriptAlertPanelMessage = new SingleAwaitSubject<Tuple<WebKit.WebView, string, WebKit.WebFrame>>();
        public IObservable<Tuple<WebKit.WebView, string, WebKit.WebFrame>> UIRunJavaScriptAlertPanelMessageObs { get { return _UIRunJavaScriptAlertPanelMessage; } }
        public override void UIRunJavaScriptAlertPanelMessage(WebKit.WebView sender, string withMessage, WebKit.WebFrame initiatedByFrame)
        {
            _UIRunJavaScriptAlertPanelMessage.OnNext(Tuple.Create(sender, withMessage, initiatedByFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.IWebOpenPanelResultListener>> _UIRunOpenPanelForFileButton = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.IWebOpenPanelResultListener>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.IWebOpenPanelResultListener>> UIRunOpenPanelForFileButtonObs { get { return _UIRunOpenPanelForFileButton; } }
        public override void UIRunOpenPanelForFileButton(WebKit.WebView sender, WebKit.IWebOpenPanelResultListener resultListener)
        {
            _UIRunOpenPanelForFileButton.OnNext(Tuple.Create(sender, resultListener));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, CoreGraphics.CGRect>> _UISetContentRect = new SingleAwaitSubject<Tuple<WebKit.WebView, CoreGraphics.CGRect>>();
        public IObservable<Tuple<WebKit.WebView, CoreGraphics.CGRect>> UISetContentRectObs { get { return _UISetContentRect; } }
        public override void UISetContentRect(WebKit.WebView sender, CoreGraphics.CGRect frame)
        {
            _UISetContentRect.OnNext(Tuple.Create(sender, frame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, CoreGraphics.CGRect>> _UISetFrame = new SingleAwaitSubject<Tuple<WebKit.WebView, CoreGraphics.CGRect>>();
        public IObservable<Tuple<WebKit.WebView, CoreGraphics.CGRect>> UISetFrameObs { get { return _UISetFrame; } }
        public override void UISetFrame(WebKit.WebView sender, CoreGraphics.CGRect newFrame)
        {
            _UISetFrame.OnNext(Tuple.Create(sender, newFrame));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, System.Boolean>> _UISetResizable = new SingleAwaitSubject<Tuple<WebKit.WebView, System.Boolean>>();
        public IObservable<Tuple<WebKit.WebView, System.Boolean>> UISetResizableObs { get { return _UISetResizable; } }
        public override void UISetResizable(WebKit.WebView sender, System.Boolean resizable)
        {
            _UISetResizable.OnNext(Tuple.Create(sender, resizable));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, System.Boolean>> _UISetStatusBarVisible = new SingleAwaitSubject<Tuple<WebKit.WebView, System.Boolean>>();
        public IObservable<Tuple<WebKit.WebView, System.Boolean>> UISetStatusBarVisibleObs { get { return _UISetStatusBarVisible; } }
        public override void UISetStatusBarVisible(WebKit.WebView sender, System.Boolean visible)
        {
            _UISetStatusBarVisible.OnNext(Tuple.Create(sender, visible));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, string>> _UISetStatusText = new SingleAwaitSubject<Tuple<WebKit.WebView, string>>();
        public IObservable<Tuple<WebKit.WebView, string>> UISetStatusTextObs { get { return _UISetStatusText; } }
        public override void UISetStatusText(WebKit.WebView sender, string text)
        {
            _UISetStatusText.OnNext(Tuple.Create(sender, text));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, System.Boolean>> _UISetToolbarsVisible = new SingleAwaitSubject<Tuple<WebKit.WebView, System.Boolean>>();
        public IObservable<Tuple<WebKit.WebView, System.Boolean>> UISetToolbarsVisibleObs { get { return _UISetToolbarsVisible; } }
        public override void UISetToolbarsVisible(WebKit.WebView sender, System.Boolean visible)
        {
            _UISetToolbarsVisible.OnNext(Tuple.Create(sender, visible));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebDragDestinationAction, AppKit.NSDraggingInfo>> _UIWillPerformDragDestination = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebDragDestinationAction, AppKit.NSDraggingInfo>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.WebDragDestinationAction, AppKit.NSDraggingInfo>> UIWillPerformDragDestinationObs { get { return _UIWillPerformDragDestination; } }
        public override void UIWillPerformDragDestination(WebKit.WebView webView, WebKit.WebDragDestinationAction action, AppKit.NSDraggingInfo draggingInfo)
        {
            _UIWillPerformDragDestination.OnNext(Tuple.Create(webView, action, draggingInfo));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebDragSourceAction, CoreGraphics.CGPoint, AppKit.NSPasteboard>> _UIWillPerformDragSource = new SingleAwaitSubject<Tuple<WebKit.WebView, WebKit.WebDragSourceAction, CoreGraphics.CGPoint, AppKit.NSPasteboard>>();
        public IObservable<Tuple<WebKit.WebView, WebKit.WebDragSourceAction, CoreGraphics.CGPoint, AppKit.NSPasteboard>> UIWillPerformDragSourceObs { get { return _UIWillPerformDragSource; } }
        public override void UIWillPerformDragSource(WebKit.WebView webView, WebKit.WebDragSourceAction action, CoreGraphics.CGPoint sourcePoint, AppKit.NSPasteboard pasteboard)
        {
            _UIWillPerformDragSource.OnNext(Tuple.Create(webView, action, sourcePoint, pasteboard));
        }

    }
    public  partial class WKNavigationDelegateRx : WKNavigationDelegate
    {
        readonly SingleAwaitSubject<WebKit.WKWebView> _ContentProcessDidTerminate = new SingleAwaitSubject<WebKit.WKWebView>();
        public IObservable<WebKit.WKWebView> ContentProcessDidTerminateObs { get { return _ContentProcessDidTerminate; } }
        public override void ContentProcessDidTerminate(WebKit.WKWebView webView)
        {
            _ContentProcessDidTerminate.OnNext(webView);
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigationAction, System.Action<WebKit.WKNavigationActionPolicy>>> _DecidePolicy = new SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigationAction, System.Action<WebKit.WKNavigationActionPolicy>>>();
        public IObservable<Tuple<WebKit.WKWebView, WebKit.WKNavigationAction, System.Action<WebKit.WKNavigationActionPolicy>>> DecidePolicyObs { get { return _DecidePolicy; } }
        public override void DecidePolicy(WebKit.WKWebView webView, WebKit.WKNavigationAction navigationAction, System.Action<WebKit.WKNavigationActionPolicy> decisionHandler)
        {
            _DecidePolicy.OnNext(Tuple.Create(webView, navigationAction, decisionHandler));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigation>> _DidCommitNavigation = new SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigation>>();
        public IObservable<Tuple<WebKit.WKWebView, WebKit.WKNavigation>> DidCommitNavigationObs { get { return _DidCommitNavigation; } }
        public override void DidCommitNavigation(WebKit.WKWebView webView, WebKit.WKNavigation navigation)
        {
            _DidCommitNavigation.OnNext(Tuple.Create(webView, navigation));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigation, Foundation.NSError>> _DidFailNavigation = new SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigation, Foundation.NSError>>();
        public IObservable<Tuple<WebKit.WKWebView, WebKit.WKNavigation, Foundation.NSError>> DidFailNavigationObs { get { return _DidFailNavigation; } }
        public override void DidFailNavigation(WebKit.WKWebView webView, WebKit.WKNavigation navigation, Foundation.NSError error)
        {
            _DidFailNavigation.OnNext(Tuple.Create(webView, navigation, error));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigation, Foundation.NSError>> _DidFailProvisionalNavigation = new SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigation, Foundation.NSError>>();
        public IObservable<Tuple<WebKit.WKWebView, WebKit.WKNavigation, Foundation.NSError>> DidFailProvisionalNavigationObs { get { return _DidFailProvisionalNavigation; } }
        public override void DidFailProvisionalNavigation(WebKit.WKWebView webView, WebKit.WKNavigation navigation, Foundation.NSError error)
        {
            _DidFailProvisionalNavigation.OnNext(Tuple.Create(webView, navigation, error));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigation>> _DidFinishNavigation = new SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigation>>();
        public IObservable<Tuple<WebKit.WKWebView, WebKit.WKNavigation>> DidFinishNavigationObs { get { return _DidFinishNavigation; } }
        public override void DidFinishNavigation(WebKit.WKWebView webView, WebKit.WKNavigation navigation)
        {
            _DidFinishNavigation.OnNext(Tuple.Create(webView, navigation));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WKWebView, Foundation.NSUrlAuthenticationChallenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential>>> _DidReceiveAuthenticationChallenge = new SingleAwaitSubject<Tuple<WebKit.WKWebView, Foundation.NSUrlAuthenticationChallenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential>>>();
        public IObservable<Tuple<WebKit.WKWebView, Foundation.NSUrlAuthenticationChallenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential>>> DidReceiveAuthenticationChallengeObs { get { return _DidReceiveAuthenticationChallenge; } }
        public override void DidReceiveAuthenticationChallenge(WebKit.WKWebView webView, Foundation.NSUrlAuthenticationChallenge challenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential> completionHandler)
        {
            _DidReceiveAuthenticationChallenge.OnNext(Tuple.Create(webView, challenge, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigation>> _DidReceiveServerRedirectForProvisionalNavigation = new SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigation>>();
        public IObservable<Tuple<WebKit.WKWebView, WebKit.WKNavigation>> DidReceiveServerRedirectForProvisionalNavigationObs { get { return _DidReceiveServerRedirectForProvisionalNavigation; } }
        public override void DidReceiveServerRedirectForProvisionalNavigation(WebKit.WKWebView webView, WebKit.WKNavigation navigation)
        {
            _DidReceiveServerRedirectForProvisionalNavigation.OnNext(Tuple.Create(webView, navigation));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigation>> _DidStartProvisionalNavigation = new SingleAwaitSubject<Tuple<WebKit.WKWebView, WebKit.WKNavigation>>();
        public IObservable<Tuple<WebKit.WKWebView, WebKit.WKNavigation>> DidStartProvisionalNavigationObs { get { return _DidStartProvisionalNavigation; } }
        public override void DidStartProvisionalNavigation(WebKit.WKWebView webView, WebKit.WKNavigation navigation)
        {
            _DidStartProvisionalNavigation.OnNext(Tuple.Create(webView, navigation));
        }

    }
    public  partial class WKUIDelegateRx : WKUIDelegate
    {
        readonly SingleAwaitSubject<WebKit.WKWebView> _DidClose = new SingleAwaitSubject<WebKit.WKWebView>();
        public IObservable<WebKit.WKWebView> DidCloseObs { get { return _DidClose; } }
        public override void DidClose(WebKit.WKWebView webView)
        {
            _DidClose.OnNext(webView);
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WKWebView, string, WebKit.WKFrameInfo, System.Action>> _RunJavaScriptAlertPanel = new SingleAwaitSubject<Tuple<WebKit.WKWebView, string, WebKit.WKFrameInfo, System.Action>>();
        public IObservable<Tuple<WebKit.WKWebView, string, WebKit.WKFrameInfo, System.Action>> RunJavaScriptAlertPanelObs { get { return _RunJavaScriptAlertPanel; } }
        public override void RunJavaScriptAlertPanel(WebKit.WKWebView webView, string message, WebKit.WKFrameInfo frame, System.Action completionHandler)
        {
            _RunJavaScriptAlertPanel.OnNext(Tuple.Create(webView, message, frame, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WKWebView, string, WebKit.WKFrameInfo, System.Action<System.Boolean>>> _RunJavaScriptConfirmPanel = new SingleAwaitSubject<Tuple<WebKit.WKWebView, string, WebKit.WKFrameInfo, System.Action<System.Boolean>>>();
        public IObservable<Tuple<WebKit.WKWebView, string, WebKit.WKFrameInfo, System.Action<System.Boolean>>> RunJavaScriptConfirmPanelObs { get { return _RunJavaScriptConfirmPanel; } }
        public override void RunJavaScriptConfirmPanel(WebKit.WKWebView webView, string message, WebKit.WKFrameInfo frame, System.Action<System.Boolean> completionHandler)
        {
            _RunJavaScriptConfirmPanel.OnNext(Tuple.Create(webView, message, frame, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<WebKit.WKWebView, string, string, WebKit.WKFrameInfo, System.Action<string>>> _RunJavaScriptTextInputPanel = new SingleAwaitSubject<Tuple<WebKit.WKWebView, string, string, WebKit.WKFrameInfo, System.Action<string>>>();
        public IObservable<Tuple<WebKit.WKWebView, string, string, WebKit.WKFrameInfo, System.Action<string>>> RunJavaScriptTextInputPanelObs { get { return _RunJavaScriptTextInputPanel; } }
        public override void RunJavaScriptTextInputPanel(WebKit.WKWebView webView, string prompt, string defaultText, WebKit.WKFrameInfo frame, System.Action<string> completionHandler)
        {
            _RunJavaScriptTextInputPanel.OnNext(Tuple.Create(webView, prompt, defaultText, frame, completionHandler));
        }

    }
}
namespace MapKit.Rx
{
    public  partial class MKLocalSearchCompleterDelegateRx : MKLocalSearchCompleterDelegate
    {
        readonly SingleAwaitSubject<MapKit.MKLocalSearchCompleter> _DidUpdateResults = new SingleAwaitSubject<MapKit.MKLocalSearchCompleter>();
        public IObservable<MapKit.MKLocalSearchCompleter> DidUpdateResultsObs { get { return _DidUpdateResults; } }
        public override void DidUpdateResults(MapKit.MKLocalSearchCompleter completer)
        {
            _DidUpdateResults.OnNext(completer);
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKLocalSearchCompleter, Foundation.NSError>> _DidFail = new SingleAwaitSubject<Tuple<MapKit.MKLocalSearchCompleter, Foundation.NSError>>();
        public IObservable<Tuple<MapKit.MKLocalSearchCompleter, Foundation.NSError>> DidFailObs { get { return _DidFail; } }
        public override void DidFail(MapKit.MKLocalSearchCompleter completer, Foundation.NSError error)
        {
            _DidFail.OnNext(Tuple.Create(completer, error));
        }

    }
    public  partial class MKMapViewDelegateRx : MKMapViewDelegate
    {
        readonly SingleAwaitSubject<MapKit.MKMapView> _DidStopLocatingUser = new SingleAwaitSubject<MapKit.MKMapView>();
        public IObservable<MapKit.MKMapView> DidStopLocatingUserObs { get { return _DidStopLocatingUser; } }
        public override void DidStopLocatingUser(MapKit.MKMapView mapView)
        {
            _DidStopLocatingUser.OnNext(mapView);
        }

        readonly SingleAwaitSubject<MapKit.MKMapView> _MapLoaded = new SingleAwaitSubject<MapKit.MKMapView>();
        public IObservable<MapKit.MKMapView> MapLoadedObs { get { return _MapLoaded; } }
        public override void MapLoaded(MapKit.MKMapView mapView)
        {
            _MapLoaded.OnNext(mapView);
        }

        readonly SingleAwaitSubject<MapKit.MKMapView> _WillStartLoadingMap = new SingleAwaitSubject<MapKit.MKMapView>();
        public IObservable<MapKit.MKMapView> WillStartLoadingMapObs { get { return _WillStartLoadingMap; } }
        public override void WillStartLoadingMap(MapKit.MKMapView mapView)
        {
            _WillStartLoadingMap.OnNext(mapView);
        }

        readonly SingleAwaitSubject<MapKit.MKMapView> _WillStartLocatingUser = new SingleAwaitSubject<MapKit.MKMapView>();
        public IObservable<MapKit.MKMapView> WillStartLocatingUserObs { get { return _WillStartLocatingUser; } }
        public override void WillStartLocatingUser(MapKit.MKMapView mapView)
        {
            _WillStartLocatingUser.OnNext(mapView);
        }

        readonly SingleAwaitSubject<MapKit.MKMapView> _WillStartRenderingMap = new SingleAwaitSubject<MapKit.MKMapView>();
        public IObservable<MapKit.MKMapView> WillStartRenderingMapObs { get { return _WillStartRenderingMap; } }
        public override void WillStartRenderingMap(MapKit.MKMapView mapView)
        {
            _WillStartRenderingMap.OnNext(mapView);
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView, MapKit.MKAnnotationViewDragState, MapKit.MKAnnotationViewDragState>> _ChangedDragState = new SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView, MapKit.MKAnnotationViewDragState, MapKit.MKAnnotationViewDragState>>();
        public IObservable<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView, MapKit.MKAnnotationViewDragState, MapKit.MKAnnotationViewDragState>> ChangedDragStateObs { get { return _ChangedDragState; } }
        public override void ChangedDragState(MapKit.MKMapView mapView, MapKit.MKAnnotationView annotationView, MapKit.MKAnnotationViewDragState newState, MapKit.MKAnnotationViewDragState oldState)
        {
            _ChangedDragState.OnNext(Tuple.Create(mapView, annotationView, newState, oldState));
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView[]>> _DidAddAnnotationViews = new SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView[]>>();
        public IObservable<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView[]>> DidAddAnnotationViewsObs { get { return _DidAddAnnotationViews; } }
        public override void DidAddAnnotationViews(MapKit.MKMapView mapView, MapKit.MKAnnotationView[] views)
        {
            _DidAddAnnotationViews.OnNext(Tuple.Create(mapView, views));
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKOverlayRenderer[]>> _DidAddOverlayRenderers = new SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKOverlayRenderer[]>>();
        public IObservable<Tuple<MapKit.MKMapView, MapKit.MKOverlayRenderer[]>> DidAddOverlayRenderersObs { get { return _DidAddOverlayRenderers; } }
        public override void DidAddOverlayRenderers(MapKit.MKMapView mapView, MapKit.MKOverlayRenderer[] renderers)
        {
            _DidAddOverlayRenderers.OnNext(Tuple.Create(mapView, renderers));
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView>> _DidDeselectAnnotationView = new SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView>>();
        public IObservable<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView>> DidDeselectAnnotationViewObs { get { return _DidDeselectAnnotationView; } }
        public override void DidDeselectAnnotationView(MapKit.MKMapView mapView, MapKit.MKAnnotationView view)
        {
            _DidDeselectAnnotationView.OnNext(Tuple.Create(mapView, view));
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, Foundation.NSError>> _DidFailToLocateUser = new SingleAwaitSubject<Tuple<MapKit.MKMapView, Foundation.NSError>>();
        public IObservable<Tuple<MapKit.MKMapView, Foundation.NSError>> DidFailToLocateUserObs { get { return _DidFailToLocateUser; } }
        public override void DidFailToLocateUser(MapKit.MKMapView mapView, Foundation.NSError error)
        {
            _DidFailToLocateUser.OnNext(Tuple.Create(mapView, error));
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, System.Boolean>> _DidFinishRenderingMap = new SingleAwaitSubject<Tuple<MapKit.MKMapView, System.Boolean>>();
        public IObservable<Tuple<MapKit.MKMapView, System.Boolean>> DidFinishRenderingMapObs { get { return _DidFinishRenderingMap; } }
        public override void DidFinishRenderingMap(MapKit.MKMapView mapView, System.Boolean fullyRendered)
        {
            _DidFinishRenderingMap.OnNext(Tuple.Create(mapView, fullyRendered));
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView>> _DidSelectAnnotationView = new SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView>>();
        public IObservable<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView>> DidSelectAnnotationViewObs { get { return _DidSelectAnnotationView; } }
        public override void DidSelectAnnotationView(MapKit.MKMapView mapView, MapKit.MKAnnotationView view)
        {
            _DidSelectAnnotationView.OnNext(Tuple.Create(mapView, view));
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKUserLocation>> _DidUpdateUserLocation = new SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKUserLocation>>();
        public IObservable<Tuple<MapKit.MKMapView, MapKit.MKUserLocation>> DidUpdateUserLocationObs { get { return _DidUpdateUserLocation; } }
        public override void DidUpdateUserLocation(MapKit.MKMapView mapView, MapKit.MKUserLocation userLocation)
        {
            _DidUpdateUserLocation.OnNext(Tuple.Create(mapView, userLocation));
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, Foundation.NSError>> _LoadingMapFailed = new SingleAwaitSubject<Tuple<MapKit.MKMapView, Foundation.NSError>>();
        public IObservable<Tuple<MapKit.MKMapView, Foundation.NSError>> LoadingMapFailedObs { get { return _LoadingMapFailed; } }
        public override void LoadingMapFailed(MapKit.MKMapView mapView, Foundation.NSError error)
        {
            _LoadingMapFailed.OnNext(Tuple.Create(mapView, error));
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, System.Boolean>> _RegionChanged = new SingleAwaitSubject<Tuple<MapKit.MKMapView, System.Boolean>>();
        public IObservable<Tuple<MapKit.MKMapView, System.Boolean>> RegionChangedObs { get { return _RegionChanged; } }
        public override void RegionChanged(MapKit.MKMapView mapView, System.Boolean animated)
        {
            _RegionChanged.OnNext(Tuple.Create(mapView, animated));
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, System.Boolean>> _RegionWillChange = new SingleAwaitSubject<Tuple<MapKit.MKMapView, System.Boolean>>();
        public IObservable<Tuple<MapKit.MKMapView, System.Boolean>> RegionWillChangeObs { get { return _RegionWillChange; } }
        public override void RegionWillChange(MapKit.MKMapView mapView, System.Boolean animated)
        {
            _RegionWillChange.OnNext(Tuple.Create(mapView, animated));
        }

    }
}
namespace MetalKit.Rx
{
    public abstract partial class MTKViewDelegateRx : MTKViewDelegate
    {
        readonly SingleAwaitSubject<MetalKit.MTKView> _Draw = new SingleAwaitSubject<MetalKit.MTKView>();
        public IObservable<MetalKit.MTKView> DrawObs { get { return _Draw; } }
        public override void Draw(MetalKit.MTKView view)
        {
            _Draw.OnNext(view);
        }

        readonly SingleAwaitSubject<Tuple<MetalKit.MTKView, CoreGraphics.CGSize>> _DrawableSizeWillChange = new SingleAwaitSubject<Tuple<MetalKit.MTKView, CoreGraphics.CGSize>>();
        public IObservable<Tuple<MetalKit.MTKView, CoreGraphics.CGSize>> DrawableSizeWillChangeObs { get { return _DrawableSizeWillChange; } }
        public override void DrawableSizeWillChange(MetalKit.MTKView view, CoreGraphics.CGSize size)
        {
            _DrawableSizeWillChange.OnNext(Tuple.Create(view, size));
        }

    }
}
namespace AppKit.Rx
{
    public  partial class NSAnimationDelegateRx : NSAnimationDelegate
    {
        readonly SingleAwaitSubject<AppKit.NSAnimation> _AnimationDidEnd = new SingleAwaitSubject<AppKit.NSAnimation>();
        public IObservable<AppKit.NSAnimation> AnimationDidEndObs { get { return _AnimationDidEnd; } }
        public override void AnimationDidEnd(AppKit.NSAnimation animation)
        {
            _AnimationDidEnd.OnNext(animation);
        }

        readonly SingleAwaitSubject<AppKit.NSAnimation> _AnimationDidStop = new SingleAwaitSubject<AppKit.NSAnimation>();
        public IObservable<AppKit.NSAnimation> AnimationDidStopObs { get { return _AnimationDidStop; } }
        public override void AnimationDidStop(AppKit.NSAnimation animation)
        {
            _AnimationDidStop.OnNext(animation);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSAnimation, System.Single>> _AnimationDidReachProgressMark = new SingleAwaitSubject<Tuple<AppKit.NSAnimation, System.Single>>();
        public IObservable<Tuple<AppKit.NSAnimation, System.Single>> AnimationDidReachProgressMarkObs { get { return _AnimationDidReachProgressMark; } }
        public override void AnimationDidReachProgressMark(AppKit.NSAnimation animation, System.Single progress)
        {
            _AnimationDidReachProgressMark.OnNext(Tuple.Create(animation, progress));
        }

    }
    public  partial class NSApplicationDelegateRx : NSApplicationDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _DidBecomeActive = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidBecomeActiveObs { get { return _DidBecomeActive; } }
        public override void DidBecomeActive(Foundation.NSNotification notification)
        {
            _DidBecomeActive.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidFinishLaunching = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidFinishLaunchingObs { get { return _DidFinishLaunching; } }
        public override void DidFinishLaunching(Foundation.NSNotification notification)
        {
            _DidFinishLaunching.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidHide = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidHideObs { get { return _DidHide; } }
        public override void DidHide(Foundation.NSNotification notification)
        {
            _DidHide.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidResignActive = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidResignActiveObs { get { return _DidResignActive; } }
        public override void DidResignActive(Foundation.NSNotification notification)
        {
            _DidResignActive.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidUnhide = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidUnhideObs { get { return _DidUnhide; } }
        public override void DidUnhide(Foundation.NSNotification notification)
        {
            _DidUnhide.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidUpdate = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidUpdateObs { get { return _DidUpdate; } }
        public override void DidUpdate(Foundation.NSNotification notification)
        {
            _DidUpdate.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSObject> _OrderFrontStandardAboutPanel = new SingleAwaitSubject<Foundation.NSObject>();
        public IObservable<Foundation.NSObject> OrderFrontStandardAboutPanelObs { get { return _OrderFrontStandardAboutPanel; } }
        public override void OrderFrontStandardAboutPanel(Foundation.NSObject sender)
        {
            _OrderFrontStandardAboutPanel.OnNext(sender);
        }

        readonly SingleAwaitSubject<Foundation.NSDictionary> _OrderFrontStandardAboutPanelWithOptions = new SingleAwaitSubject<Foundation.NSDictionary>();
        public IObservable<Foundation.NSDictionary> OrderFrontStandardAboutPanelWithOptionsObs { get { return _OrderFrontStandardAboutPanelWithOptions; } }
        public override void OrderFrontStandardAboutPanelWithOptions(Foundation.NSDictionary optionsDictionary)
        {
            _OrderFrontStandardAboutPanelWithOptions.OnNext(optionsDictionary);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _ScreenParametersChanged = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ScreenParametersChangedObs { get { return _ScreenParametersChanged; } }
        public override void ScreenParametersChanged(Foundation.NSNotification notification)
        {
            _ScreenParametersChanged.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillBecomeActive = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillBecomeActiveObs { get { return _WillBecomeActive; } }
        public override void WillBecomeActive(Foundation.NSNotification notification)
        {
            _WillBecomeActive.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillFinishLaunching = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillFinishLaunchingObs { get { return _WillFinishLaunching; } }
        public override void WillFinishLaunching(Foundation.NSNotification notification)
        {
            _WillFinishLaunching.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillHide = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillHideObs { get { return _WillHide; } }
        public override void WillHide(Foundation.NSNotification notification)
        {
            _WillHide.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillResignActive = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillResignActiveObs { get { return _WillResignActive; } }
        public override void WillResignActive(Foundation.NSNotification notification)
        {
            _WillResignActive.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillTerminate = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillTerminateObs { get { return _WillTerminate; } }
        public override void WillTerminate(Foundation.NSNotification notification)
        {
            _WillTerminate.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillUnhide = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillUnhideObs { get { return _WillUnhide; } }
        public override void WillUnhide(Foundation.NSNotification notification)
        {
            _WillUnhide.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillUpdate = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillUpdateObs { get { return _WillUpdate; } }
        public override void WillUpdate(Foundation.NSNotification notification)
        {
            _WillUpdate.OnNext(notification);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSApplication, Foundation.NSCoder>> _DecodedRestorableState = new SingleAwaitSubject<Tuple<AppKit.NSApplication, Foundation.NSCoder>>();
        public IObservable<Tuple<AppKit.NSApplication, Foundation.NSCoder>> DecodedRestorableStateObs { get { return _DecodedRestorableState; } }
        public override void DecodedRestorableState(AppKit.NSApplication app, Foundation.NSCoder state)
        {
            _DecodedRestorableState.OnNext(Tuple.Create(app, state));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSApplication, string, Foundation.NSError>> _FailedToContinueUserActivity = new SingleAwaitSubject<Tuple<AppKit.NSApplication, string, Foundation.NSError>>();
        public IObservable<Tuple<AppKit.NSApplication, string, Foundation.NSError>> FailedToContinueUserActivityObs { get { return _FailedToContinueUserActivity; } }
        public override void FailedToContinueUserActivity(AppKit.NSApplication application, string userActivityType, Foundation.NSError error)
        {
            _FailedToContinueUserActivity.OnNext(Tuple.Create(application, userActivityType, error));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSApplication, Foundation.NSError>> _FailedToRegisterForRemoteNotifications = new SingleAwaitSubject<Tuple<AppKit.NSApplication, Foundation.NSError>>();
        public IObservable<Tuple<AppKit.NSApplication, Foundation.NSError>> FailedToRegisterForRemoteNotificationsObs { get { return _FailedToRegisterForRemoteNotifications; } }
        public override void FailedToRegisterForRemoteNotifications(AppKit.NSApplication application, Foundation.NSError error)
        {
            _FailedToRegisterForRemoteNotifications.OnNext(Tuple.Create(application, error));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSApplication, string[]>> _OpenFiles = new SingleAwaitSubject<Tuple<AppKit.NSApplication, string[]>>();
        public IObservable<Tuple<AppKit.NSApplication, string[]>> OpenFilesObs { get { return _OpenFiles; } }
        public override void OpenFiles(AppKit.NSApplication sender, string[] filenames)
        {
            _OpenFiles.OnNext(Tuple.Create(sender, filenames));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSApplication, Foundation.NSDictionary>> _ReceivedRemoteNotification = new SingleAwaitSubject<Tuple<AppKit.NSApplication, Foundation.NSDictionary>>();
        public IObservable<Tuple<AppKit.NSApplication, Foundation.NSDictionary>> ReceivedRemoteNotificationObs { get { return _ReceivedRemoteNotification; } }
        public override void ReceivedRemoteNotification(AppKit.NSApplication application, Foundation.NSDictionary userInfo)
        {
            _ReceivedRemoteNotification.OnNext(Tuple.Create(application, userInfo));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSApplication, Foundation.NSData>> _RegisteredForRemoteNotifications = new SingleAwaitSubject<Tuple<AppKit.NSApplication, Foundation.NSData>>();
        public IObservable<Tuple<AppKit.NSApplication, Foundation.NSData>> RegisteredForRemoteNotificationsObs { get { return _RegisteredForRemoteNotifications; } }
        public override void RegisteredForRemoteNotifications(AppKit.NSApplication application, Foundation.NSData deviceToken)
        {
            _RegisteredForRemoteNotifications.OnNext(Tuple.Create(application, deviceToken));
        }

        readonly SingleAwaitSubject<Tuple<string[], string[]>> _RegisterServicesMenu = new SingleAwaitSubject<Tuple<string[], string[]>>();
        public IObservable<Tuple<string[], string[]>> RegisterServicesMenuObs { get { return _RegisterServicesMenu; } }
        public override void RegisterServicesMenu(string[] sendTypes, string[] returnTypes)
        {
            _RegisterServicesMenu.OnNext(Tuple.Create(sendTypes, returnTypes));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSApplication, Foundation.NSUserActivity>> _UpdatedUserActivity = new SingleAwaitSubject<Tuple<AppKit.NSApplication, Foundation.NSUserActivity>>();
        public IObservable<Tuple<AppKit.NSApplication, Foundation.NSUserActivity>> UpdatedUserActivityObs { get { return _UpdatedUserActivity; } }
        public override void UpdatedUserActivity(AppKit.NSApplication application, Foundation.NSUserActivity userActivity)
        {
            _UpdatedUserActivity.OnNext(Tuple.Create(application, userActivity));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSApplication, Foundation.NSCoder>> _WillEncodeRestorableState = new SingleAwaitSubject<Tuple<AppKit.NSApplication, Foundation.NSCoder>>();
        public IObservable<Tuple<AppKit.NSApplication, Foundation.NSCoder>> WillEncodeRestorableStateObs { get { return _WillEncodeRestorableState; } }
        public override void WillEncodeRestorableState(AppKit.NSApplication app, Foundation.NSCoder encoder)
        {
            _WillEncodeRestorableState.OnNext(Tuple.Create(app, encoder));
        }

    }
    public  partial class NSSharingServiceDelegateRx : NSSharingServiceDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSSharingService, Foundation.NSObject[], Foundation.NSError>> _DidFailToShareItems = new SingleAwaitSubject<Tuple<AppKit.NSSharingService, Foundation.NSObject[], Foundation.NSError>>();
        public IObservable<Tuple<AppKit.NSSharingService, Foundation.NSObject[], Foundation.NSError>> DidFailToShareItemsObs { get { return _DidFailToShareItems; } }
        public override void DidFailToShareItems(AppKit.NSSharingService sharingService, Foundation.NSObject[] items, Foundation.NSError error)
        {
            _DidFailToShareItems.OnNext(Tuple.Create(sharingService, items, error));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSSharingService, Foundation.NSObject[]>> _DidShareItems = new SingleAwaitSubject<Tuple<AppKit.NSSharingService, Foundation.NSObject[]>>();
        public IObservable<Tuple<AppKit.NSSharingService, Foundation.NSObject[]>> DidShareItemsObs { get { return _DidShareItems; } }
        public override void DidShareItems(AppKit.NSSharingService sharingService, Foundation.NSObject[] items)
        {
            _DidShareItems.OnNext(Tuple.Create(sharingService, items));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSSharingService, Foundation.NSObject[]>> _WillShareItems = new SingleAwaitSubject<Tuple<AppKit.NSSharingService, Foundation.NSObject[]>>();
        public IObservable<Tuple<AppKit.NSSharingService, Foundation.NSObject[]>> WillShareItemsObs { get { return _WillShareItems; } }
        public override void WillShareItems(AppKit.NSSharingService sharingService, Foundation.NSObject[] items)
        {
            _WillShareItems.OnNext(Tuple.Create(sharingService, items));
        }

    }
    public  partial class NSBrowserDelegateRx : NSBrowserDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _ColumnConfigurationDidChange = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ColumnConfigurationDidChangeObs { get { return _ColumnConfigurationDidChange; } }
        public override void ColumnConfigurationDidChange(Foundation.NSNotification notification)
        {
            _ColumnConfigurationDidChange.OnNext(notification);
        }

        readonly SingleAwaitSubject<AppKit.NSBrowser> _DidScroll = new SingleAwaitSubject<AppKit.NSBrowser>();
        public IObservable<AppKit.NSBrowser> DidScrollObs { get { return _DidScroll; } }
        public override void DidScroll(AppKit.NSBrowser sender)
        {
            _DidScroll.OnNext(sender);
        }

        readonly SingleAwaitSubject<AppKit.NSBrowser> _WillScroll = new SingleAwaitSubject<AppKit.NSBrowser>();
        public IObservable<AppKit.NSBrowser> WillScrollObs { get { return _WillScroll; } }
        public override void WillScroll(AppKit.NSBrowser sender)
        {
            _WillScroll.OnNext(sender);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSBrowser, System.nint, AppKit.NSMatrix>> _CreateRowsForColumn = new SingleAwaitSubject<Tuple<AppKit.NSBrowser, System.nint, AppKit.NSMatrix>>();
        public IObservable<Tuple<AppKit.NSBrowser, System.nint, AppKit.NSMatrix>> CreateRowsForColumnObs { get { return _CreateRowsForColumn; } }
        public override void CreateRowsForColumn(AppKit.NSBrowser sender, System.nint column, AppKit.NSMatrix matrix)
        {
            _CreateRowsForColumn.OnNext(Tuple.Create(sender, column, matrix));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSBrowser, System.nint, System.nint>> _DidChangeLastColumn = new SingleAwaitSubject<Tuple<AppKit.NSBrowser, System.nint, System.nint>>();
        public IObservable<Tuple<AppKit.NSBrowser, System.nint, System.nint>> DidChangeLastColumnObs { get { return _DidChangeLastColumn; } }
        public override void DidChangeLastColumn(AppKit.NSBrowser browser, System.nint oldLastColumn, System.nint toColumn)
        {
            _DidChangeLastColumn.OnNext(Tuple.Create(browser, oldLastColumn, toColumn));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSBrowser, Foundation.NSObject, Foundation.NSObject>> _SetObjectValue = new SingleAwaitSubject<Tuple<AppKit.NSBrowser, Foundation.NSObject, Foundation.NSObject>>();
        public IObservable<Tuple<AppKit.NSBrowser, Foundation.NSObject, Foundation.NSObject>> SetObjectValueObs { get { return _SetObjectValue; } }
        public override void SetObjectValue(AppKit.NSBrowser browser, Foundation.NSObject obj, Foundation.NSObject item)
        {
            _SetObjectValue.OnNext(Tuple.Create(browser, obj, item));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSBrowser, Foundation.NSObject, System.nint, System.nint>> _WillDisplayCell = new SingleAwaitSubject<Tuple<AppKit.NSBrowser, Foundation.NSObject, System.nint, System.nint>>();
        public IObservable<Tuple<AppKit.NSBrowser, Foundation.NSObject, System.nint, System.nint>> WillDisplayCellObs { get { return _WillDisplayCell; } }
        public override void WillDisplayCell(AppKit.NSBrowser sender, Foundation.NSObject cell, System.nint row, System.nint column)
        {
            _WillDisplayCell.OnNext(Tuple.Create(sender, cell, row, column));
        }

    }
    public  partial class NSComboBoxDelegateRx : NSComboBoxDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _SelectionChanged = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> SelectionChangedObs { get { return _SelectionChanged; } }
        public override void SelectionChanged(Foundation.NSNotification notification)
        {
            _SelectionChanged.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _SelectionIsChanging = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> SelectionIsChangingObs { get { return _SelectionIsChanging; } }
        public override void SelectionIsChanging(Foundation.NSNotification notification)
        {
            _SelectionIsChanging.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillDismiss = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillDismissObs { get { return _WillDismiss; } }
        public override void WillDismiss(Foundation.NSNotification notification)
        {
            _WillDismiss.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillPopUp = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillPopUpObs { get { return _WillPopUp; } }
        public override void WillPopUp(Foundation.NSNotification notification)
        {
            _WillPopUp.OnNext(notification);
        }

    }
    public  partial class NSControlTextEditingDelegateRx : NSControlTextEditingDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSControl, string, string>> _DidFailToValidatePartialString = new SingleAwaitSubject<Tuple<AppKit.NSControl, string, string>>();
        public IObservable<Tuple<AppKit.NSControl, string, string>> DidFailToValidatePartialStringObs { get { return _DidFailToValidatePartialString; } }
        public override void DidFailToValidatePartialString(AppKit.NSControl control, string str, string error)
        {
            _DidFailToValidatePartialString.OnNext(Tuple.Create(control, str, error));
        }

    }
    public  partial class NSCloudSharingServiceDelegateRx : NSCloudSharingServiceDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSSharingService, Foundation.NSObject[], Foundation.NSError>> _Completed = new SingleAwaitSubject<Tuple<AppKit.NSSharingService, Foundation.NSObject[], Foundation.NSError>>();
        public IObservable<Tuple<AppKit.NSSharingService, Foundation.NSObject[], Foundation.NSError>> CompletedObs { get { return _Completed; } }
        public override void Completed(AppKit.NSSharingService sharingService, Foundation.NSObject[] items, Foundation.NSError error)
        {
            _Completed.OnNext(Tuple.Create(sharingService, items, error));
        }

    }
    public  partial class NSCollectionViewDelegateRx : NSCollectionViewDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSCollectionViewItem, Foundation.NSIndexPath>> _DisplayingItemEnded = new SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSCollectionViewItem, Foundation.NSIndexPath>>();
        public IObservable<Tuple<AppKit.NSCollectionView, AppKit.NSCollectionViewItem, Foundation.NSIndexPath>> DisplayingItemEndedObs { get { return _DisplayingItemEnded; } }
        public override void DisplayingItemEnded(AppKit.NSCollectionView collectionView, AppKit.NSCollectionViewItem item, Foundation.NSIndexPath indexPath)
        {
            _DisplayingItemEnded.OnNext(Tuple.Create(collectionView, item, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSView, string, Foundation.NSIndexPath>> _DisplayingSupplementaryViewEnded = new SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSView, string, Foundation.NSIndexPath>>();
        public IObservable<Tuple<AppKit.NSCollectionView, AppKit.NSView, string, Foundation.NSIndexPath>> DisplayingSupplementaryViewEndedObs { get { return _DisplayingSupplementaryViewEnded; } }
        public override void DisplayingSupplementaryViewEnded(AppKit.NSCollectionView collectionView, AppKit.NSView view, string elementKind, Foundation.NSIndexPath indexPath)
        {
            _DisplayingSupplementaryViewEnded.OnNext(Tuple.Create(collectionView, view, elementKind, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSDraggingSession, CoreGraphics.CGPoint, AppKit.NSDragOperation>> _DraggingSessionEnded = new SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSDraggingSession, CoreGraphics.CGPoint, AppKit.NSDragOperation>>();
        public IObservable<Tuple<AppKit.NSCollectionView, AppKit.NSDraggingSession, CoreGraphics.CGPoint, AppKit.NSDragOperation>> DraggingSessionEndedObs { get { return _DraggingSessionEnded; } }
        public override void DraggingSessionEnded(AppKit.NSCollectionView collectionView, AppKit.NSDraggingSession draggingSession, CoreGraphics.CGPoint screenPoint, AppKit.NSDragOperation dragOperation)
        {
            _DraggingSessionEnded.OnNext(Tuple.Create(collectionView, draggingSession, screenPoint, dragOperation));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSDraggingSession, CoreGraphics.CGPoint, Foundation.NSSet>> _DraggingSessionWillBegin = new SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSDraggingSession, CoreGraphics.CGPoint, Foundation.NSSet>>();
        public IObservable<Tuple<AppKit.NSCollectionView, AppKit.NSDraggingSession, CoreGraphics.CGPoint, Foundation.NSSet>> DraggingSessionWillBeginObs { get { return _DraggingSessionWillBegin; } }
        public override void DraggingSessionWillBegin(AppKit.NSCollectionView collectionView, AppKit.NSDraggingSession session, CoreGraphics.CGPoint screenPoint, Foundation.NSSet indexPaths)
        {
            _DraggingSessionWillBegin.OnNext(Tuple.Create(collectionView, session, screenPoint, indexPaths));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSCollectionView, Foundation.NSSet, AppKit.NSCollectionViewItemHighlightState>> _ItemsChanged = new SingleAwaitSubject<Tuple<AppKit.NSCollectionView, Foundation.NSSet, AppKit.NSCollectionViewItemHighlightState>>();
        public IObservable<Tuple<AppKit.NSCollectionView, Foundation.NSSet, AppKit.NSCollectionViewItemHighlightState>> ItemsChangedObs { get { return _ItemsChanged; } }
        public override void ItemsChanged(AppKit.NSCollectionView collectionView, Foundation.NSSet indexPaths, AppKit.NSCollectionViewItemHighlightState highlightState)
        {
            _ItemsChanged.OnNext(Tuple.Create(collectionView, indexPaths, highlightState));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSCollectionView, Foundation.NSSet>> _ItemsDeselected = new SingleAwaitSubject<Tuple<AppKit.NSCollectionView, Foundation.NSSet>>();
        public IObservable<Tuple<AppKit.NSCollectionView, Foundation.NSSet>> ItemsDeselectedObs { get { return _ItemsDeselected; } }
        public override void ItemsDeselected(AppKit.NSCollectionView collectionView, Foundation.NSSet indexPaths)
        {
            _ItemsDeselected.OnNext(Tuple.Create(collectionView, indexPaths));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSCollectionView, Foundation.NSSet>> _ItemsSelected = new SingleAwaitSubject<Tuple<AppKit.NSCollectionView, Foundation.NSSet>>();
        public IObservable<Tuple<AppKit.NSCollectionView, Foundation.NSSet>> ItemsSelectedObs { get { return _ItemsSelected; } }
        public override void ItemsSelected(AppKit.NSCollectionView collectionView, Foundation.NSSet indexPaths)
        {
            _ItemsSelected.OnNext(Tuple.Create(collectionView, indexPaths));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSDraggingInfo>> _UpdateDraggingItemsForDrag = new SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSDraggingInfo>>();
        public IObservable<Tuple<AppKit.NSCollectionView, AppKit.NSDraggingInfo>> UpdateDraggingItemsForDragObs { get { return _UpdateDraggingItemsForDrag; } }
        public override void UpdateDraggingItemsForDrag(AppKit.NSCollectionView collectionView, AppKit.NSDraggingInfo draggingInfo)
        {
            _UpdateDraggingItemsForDrag.OnNext(Tuple.Create(collectionView, draggingInfo));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSCollectionViewItem, Foundation.NSIndexPath>> _WillDisplayItem = new SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSCollectionViewItem, Foundation.NSIndexPath>>();
        public IObservable<Tuple<AppKit.NSCollectionView, AppKit.NSCollectionViewItem, Foundation.NSIndexPath>> WillDisplayItemObs { get { return _WillDisplayItem; } }
        public override void WillDisplayItem(AppKit.NSCollectionView collectionView, AppKit.NSCollectionViewItem item, Foundation.NSIndexPath indexPath)
        {
            _WillDisplayItem.OnNext(Tuple.Create(collectionView, item, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSView, Foundation.NSString, Foundation.NSIndexPath>> _WillDisplaySupplementaryView = new SingleAwaitSubject<Tuple<AppKit.NSCollectionView, AppKit.NSView, Foundation.NSString, Foundation.NSIndexPath>>();
        public IObservable<Tuple<AppKit.NSCollectionView, AppKit.NSView, Foundation.NSString, Foundation.NSIndexPath>> WillDisplaySupplementaryViewObs { get { return _WillDisplaySupplementaryView; } }
        public override void WillDisplaySupplementaryView(AppKit.NSCollectionView collectionView, AppKit.NSView view, Foundation.NSString elementKind, Foundation.NSIndexPath indexPath)
        {
            _WillDisplaySupplementaryView.OnNext(Tuple.Create(collectionView, view, elementKind, indexPath));
        }

    }
    public  partial class NSImageDelegateRx : NSImageDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSImage, AppKit.NSImageRep, System.nint>> _DidLoadPartOfRepresentation = new SingleAwaitSubject<Tuple<AppKit.NSImage, AppKit.NSImageRep, System.nint>>();
        public IObservable<Tuple<AppKit.NSImage, AppKit.NSImageRep, System.nint>> DidLoadPartOfRepresentationObs { get { return _DidLoadPartOfRepresentation; } }
        public override void DidLoadPartOfRepresentation(AppKit.NSImage image, AppKit.NSImageRep rep, System.nint rows)
        {
            _DidLoadPartOfRepresentation.OnNext(Tuple.Create(image, rep, rows));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSImage, AppKit.NSImageRep, AppKit.NSImageLoadStatus>> _DidLoadRepresentation = new SingleAwaitSubject<Tuple<AppKit.NSImage, AppKit.NSImageRep, AppKit.NSImageLoadStatus>>();
        public IObservable<Tuple<AppKit.NSImage, AppKit.NSImageRep, AppKit.NSImageLoadStatus>> DidLoadRepresentationObs { get { return _DidLoadRepresentation; } }
        public override void DidLoadRepresentation(AppKit.NSImage image, AppKit.NSImageRep rep, AppKit.NSImageLoadStatus status)
        {
            _DidLoadRepresentation.OnNext(Tuple.Create(image, rep, status));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSImage, AppKit.NSImageRep>> _DidLoadRepresentationHeader = new SingleAwaitSubject<Tuple<AppKit.NSImage, AppKit.NSImageRep>>();
        public IObservable<Tuple<AppKit.NSImage, AppKit.NSImageRep>> DidLoadRepresentationHeaderObs { get { return _DidLoadRepresentationHeader; } }
        public override void DidLoadRepresentationHeader(AppKit.NSImage image, AppKit.NSImageRep rep)
        {
            _DidLoadRepresentationHeader.OnNext(Tuple.Create(image, rep));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSImage, AppKit.NSImageRep>> _WillLoadRepresentation = new SingleAwaitSubject<Tuple<AppKit.NSImage, AppKit.NSImageRep>>();
        public IObservable<Tuple<AppKit.NSImage, AppKit.NSImageRep>> WillLoadRepresentationObs { get { return _WillLoadRepresentation; } }
        public override void WillLoadRepresentation(AppKit.NSImage image, AppKit.NSImageRep rep)
        {
            _WillLoadRepresentation.OnNext(Tuple.Create(image, rep));
        }

    }
    public  partial class NSDrawerDelegateRx : NSDrawerDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _DrawerDidClose = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DrawerDidCloseObs { get { return _DrawerDidClose; } }
        public override void DrawerDidClose(Foundation.NSNotification notification)
        {
            _DrawerDidClose.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DrawerDidOpen = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DrawerDidOpenObs { get { return _DrawerDidOpen; } }
        public override void DrawerDidOpen(Foundation.NSNotification notification)
        {
            _DrawerDidOpen.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DrawerWillClose = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DrawerWillCloseObs { get { return _DrawerWillClose; } }
        public override void DrawerWillClose(Foundation.NSNotification notification)
        {
            _DrawerWillClose.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DrawerWillOpen = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DrawerWillOpenObs { get { return _DrawerWillOpen; } }
        public override void DrawerWillOpen(Foundation.NSNotification notification)
        {
            _DrawerWillOpen.OnNext(notification);
        }

    }
    public  partial class NSLayoutManagerDelegateRx : NSLayoutManagerDelegate
    {
        readonly SingleAwaitSubject<AppKit.NSLayoutManager> _LayoutInvalidated = new SingleAwaitSubject<AppKit.NSLayoutManager>();
        public IObservable<AppKit.NSLayoutManager> LayoutInvalidatedObs { get { return _LayoutInvalidated; } }
        public override void LayoutInvalidated(AppKit.NSLayoutManager sender)
        {
            _LayoutInvalidated.OnNext(sender);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSLayoutManager, AppKit.NSTextContainer, CoreGraphics.CGSize>> _DidChangeGeometry = new SingleAwaitSubject<Tuple<AppKit.NSLayoutManager, AppKit.NSTextContainer, CoreGraphics.CGSize>>();
        public IObservable<Tuple<AppKit.NSLayoutManager, AppKit.NSTextContainer, CoreGraphics.CGSize>> DidChangeGeometryObs { get { return _DidChangeGeometry; } }
        public override void DidChangeGeometry(AppKit.NSLayoutManager layoutManager, AppKit.NSTextContainer textContainer, CoreGraphics.CGSize oldSize)
        {
            _DidChangeGeometry.OnNext(Tuple.Create(layoutManager, textContainer, oldSize));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSLayoutManager, AppKit.NSTextContainer, System.Boolean>> _LayoutCompleted = new SingleAwaitSubject<Tuple<AppKit.NSLayoutManager, AppKit.NSTextContainer, System.Boolean>>();
        public IObservable<Tuple<AppKit.NSLayoutManager, AppKit.NSTextContainer, System.Boolean>> LayoutCompletedObs { get { return _LayoutCompleted; } }
        public override void LayoutCompleted(AppKit.NSLayoutManager layoutManager, AppKit.NSTextContainer textContainer, System.Boolean layoutFinishedFlag)
        {
            _LayoutCompleted.OnNext(Tuple.Create(layoutManager, textContainer, layoutFinishedFlag));
        }

    }
    public  partial class NSMatrixDelegateRx : NSMatrixDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSControl, string, string>> _DidFailToValidatePartialString = new SingleAwaitSubject<Tuple<AppKit.NSControl, string, string>>();
        public IObservable<Tuple<AppKit.NSControl, string, string>> DidFailToValidatePartialStringObs { get { return _DidFailToValidatePartialString; } }
        public override void DidFailToValidatePartialString(AppKit.NSControl control, string str, string error)
        {
            _DidFailToValidatePartialString.OnNext(Tuple.Create(control, str, error));
        }

    }
    public  partial class NSOutlineViewDelegateRx : NSOutlineViewDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _ColumnDidMove = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ColumnDidMoveObs { get { return _ColumnDidMove; } }
        public override void ColumnDidMove(Foundation.NSNotification notification)
        {
            _ColumnDidMove.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _ColumnDidResize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ColumnDidResizeObs { get { return _ColumnDidResize; } }
        public override void ColumnDidResize(Foundation.NSNotification notification)
        {
            _ColumnDidResize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _ItemDidCollapse = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ItemDidCollapseObs { get { return _ItemDidCollapse; } }
        public override void ItemDidCollapse(Foundation.NSNotification notification)
        {
            _ItemDidCollapse.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _ItemDidExpand = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ItemDidExpandObs { get { return _ItemDidExpand; } }
        public override void ItemDidExpand(Foundation.NSNotification notification)
        {
            _ItemDidExpand.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _ItemWillCollapse = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ItemWillCollapseObs { get { return _ItemWillCollapse; } }
        public override void ItemWillCollapse(Foundation.NSNotification notification)
        {
            _ItemWillCollapse.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _ItemWillExpand = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ItemWillExpandObs { get { return _ItemWillExpand; } }
        public override void ItemWillExpand(Foundation.NSNotification notification)
        {
            _ItemWillExpand.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _SelectionDidChange = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> SelectionDidChangeObs { get { return _SelectionDidChange; } }
        public override void SelectionDidChange(Foundation.NSNotification notification)
        {
            _SelectionDidChange.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _SelectionIsChanging = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> SelectionIsChangingObs { get { return _SelectionIsChanging; } }
        public override void SelectionIsChanging(Foundation.NSNotification notification)
        {
            _SelectionIsChanging.OnNext(notification);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSOutlineView, AppKit.NSTableRowView, System.nint>> _DidAddRowView = new SingleAwaitSubject<Tuple<AppKit.NSOutlineView, AppKit.NSTableRowView, System.nint>>();
        public IObservable<Tuple<AppKit.NSOutlineView, AppKit.NSTableRowView, System.nint>> DidAddRowViewObs { get { return _DidAddRowView; } }
        public override void DidAddRowView(AppKit.NSOutlineView outlineView, AppKit.NSTableRowView rowView, System.nint row)
        {
            _DidAddRowView.OnNext(Tuple.Create(outlineView, rowView, row));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSOutlineView, AppKit.NSTableColumn>> _DidClickTableColumn = new SingleAwaitSubject<Tuple<AppKit.NSOutlineView, AppKit.NSTableColumn>>();
        public IObservable<Tuple<AppKit.NSOutlineView, AppKit.NSTableColumn>> DidClickTableColumnObs { get { return _DidClickTableColumn; } }
        public override void DidClickTableColumn(AppKit.NSOutlineView outlineView, AppKit.NSTableColumn tableColumn)
        {
            _DidClickTableColumn.OnNext(Tuple.Create(outlineView, tableColumn));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSOutlineView, AppKit.NSTableColumn>> _DidDragTableColumn = new SingleAwaitSubject<Tuple<AppKit.NSOutlineView, AppKit.NSTableColumn>>();
        public IObservable<Tuple<AppKit.NSOutlineView, AppKit.NSTableColumn>> DidDragTableColumnObs { get { return _DidDragTableColumn; } }
        public override void DidDragTableColumn(AppKit.NSOutlineView outlineView, AppKit.NSTableColumn tableColumn)
        {
            _DidDragTableColumn.OnNext(Tuple.Create(outlineView, tableColumn));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSOutlineView, AppKit.NSTableRowView, System.nint>> _DidRemoveRowView = new SingleAwaitSubject<Tuple<AppKit.NSOutlineView, AppKit.NSTableRowView, System.nint>>();
        public IObservable<Tuple<AppKit.NSOutlineView, AppKit.NSTableRowView, System.nint>> DidRemoveRowViewObs { get { return _DidRemoveRowView; } }
        public override void DidRemoveRowView(AppKit.NSOutlineView outlineView, AppKit.NSTableRowView rowView, System.nint row)
        {
            _DidRemoveRowView.OnNext(Tuple.Create(outlineView, rowView, row));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSOutlineView, AppKit.NSTableColumn>> _MouseDown = new SingleAwaitSubject<Tuple<AppKit.NSOutlineView, AppKit.NSTableColumn>>();
        public IObservable<Tuple<AppKit.NSOutlineView, AppKit.NSTableColumn>> MouseDownObs { get { return _MouseDown; } }
        public override void MouseDown(AppKit.NSOutlineView outlineView, AppKit.NSTableColumn tableColumn)
        {
            _MouseDown.OnNext(Tuple.Create(outlineView, tableColumn));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSOutlineView, Foundation.NSObject, AppKit.NSTableColumn, Foundation.NSObject>> _WillDisplayCell = new SingleAwaitSubject<Tuple<AppKit.NSOutlineView, Foundation.NSObject, AppKit.NSTableColumn, Foundation.NSObject>>();
        public IObservable<Tuple<AppKit.NSOutlineView, Foundation.NSObject, AppKit.NSTableColumn, Foundation.NSObject>> WillDisplayCellObs { get { return _WillDisplayCell; } }
        public override void WillDisplayCell(AppKit.NSOutlineView outlineView, Foundation.NSObject cell, AppKit.NSTableColumn tableColumn, Foundation.NSObject item)
        {
            _WillDisplayCell.OnNext(Tuple.Create(outlineView, cell, tableColumn, item));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSOutlineView, Foundation.NSObject, AppKit.NSTableColumn, Foundation.NSObject>> _WillDisplayOutlineCell = new SingleAwaitSubject<Tuple<AppKit.NSOutlineView, Foundation.NSObject, AppKit.NSTableColumn, Foundation.NSObject>>();
        public IObservable<Tuple<AppKit.NSOutlineView, Foundation.NSObject, AppKit.NSTableColumn, Foundation.NSObject>> WillDisplayOutlineCellObs { get { return _WillDisplayOutlineCell; } }
        public override void WillDisplayOutlineCell(AppKit.NSOutlineView outlineView, Foundation.NSObject cell, AppKit.NSTableColumn tableColumn, Foundation.NSObject item)
        {
            _WillDisplayOutlineCell.OnNext(Tuple.Create(outlineView, cell, tableColumn, item));
        }

    }
    public  partial class NSPageControllerDelegateRx : NSPageControllerDelegate
    {
        readonly SingleAwaitSubject<AppKit.NSPageController> _DidEndLiveTransition = new SingleAwaitSubject<AppKit.NSPageController>();
        public IObservable<AppKit.NSPageController> DidEndLiveTransitionObs { get { return _DidEndLiveTransition; } }
        public override void DidEndLiveTransition(AppKit.NSPageController pageController)
        {
            _DidEndLiveTransition.OnNext(pageController);
        }

        readonly SingleAwaitSubject<AppKit.NSPageController> _WillStartLiveTransition = new SingleAwaitSubject<AppKit.NSPageController>();
        public IObservable<AppKit.NSPageController> WillStartLiveTransitionObs { get { return _WillStartLiveTransition; } }
        public override void WillStartLiveTransition(AppKit.NSPageController pageController)
        {
            _WillStartLiveTransition.OnNext(pageController);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSPageController, Foundation.NSObject>> _DidTransition = new SingleAwaitSubject<Tuple<AppKit.NSPageController, Foundation.NSObject>>();
        public IObservable<Tuple<AppKit.NSPageController, Foundation.NSObject>> DidTransitionObs { get { return _DidTransition; } }
        public override void DidTransition(AppKit.NSPageController pageController, Foundation.NSObject targetObject)
        {
            _DidTransition.OnNext(Tuple.Create(pageController, targetObject));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSPageController, AppKit.NSViewController, Foundation.NSObject>> _PrepareViewController = new SingleAwaitSubject<Tuple<AppKit.NSPageController, AppKit.NSViewController, Foundation.NSObject>>();
        public IObservable<Tuple<AppKit.NSPageController, AppKit.NSViewController, Foundation.NSObject>> PrepareViewControllerObs { get { return _PrepareViewController; } }
        public override void PrepareViewController(AppKit.NSPageController pageController, AppKit.NSViewController viewController, Foundation.NSObject targetObject)
        {
            _PrepareViewController.OnNext(Tuple.Create(pageController, viewController, targetObject));
        }

    }
    public abstract partial class NSMenuDelegateRx : NSMenuDelegate
    {
        readonly SingleAwaitSubject<AppKit.NSMenu> _MenuDidClose = new SingleAwaitSubject<AppKit.NSMenu>();
        public IObservable<AppKit.NSMenu> MenuDidCloseObs { get { return _MenuDidClose; } }
        public override void MenuDidClose(AppKit.NSMenu menu)
        {
            _MenuDidClose.OnNext(menu);
        }

        readonly SingleAwaitSubject<AppKit.NSMenu> _MenuWillOpen = new SingleAwaitSubject<AppKit.NSMenu>();
        public IObservable<AppKit.NSMenu> MenuWillOpenObs { get { return _MenuWillOpen; } }
        public override void MenuWillOpen(AppKit.NSMenu menu)
        {
            _MenuWillOpen.OnNext(menu);
        }

        readonly SingleAwaitSubject<AppKit.NSMenu> _NeedsUpdate = new SingleAwaitSubject<AppKit.NSMenu>();
        public IObservable<AppKit.NSMenu> NeedsUpdateObs { get { return _NeedsUpdate; } }
        public override void NeedsUpdate(AppKit.NSMenu menu)
        {
            _NeedsUpdate.OnNext(menu);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSMenu, AppKit.NSMenuItem>> _MenuWillHighlightItem = new SingleAwaitSubject<Tuple<AppKit.NSMenu, AppKit.NSMenuItem>>();
        public IObservable<Tuple<AppKit.NSMenu, AppKit.NSMenuItem>> MenuWillHighlightItemObs { get { return _MenuWillHighlightItem; } }
        public override void MenuWillHighlightItem(AppKit.NSMenu menu, AppKit.NSMenuItem item)
        {
            _MenuWillHighlightItem.OnNext(Tuple.Create(menu, item));
        }

    }
    public  partial class NSPathControlDelegateRx : NSPathControlDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSPathControl, AppKit.NSOpenPanel>> _WillDisplayOpenPanel = new SingleAwaitSubject<Tuple<AppKit.NSPathControl, AppKit.NSOpenPanel>>();
        public IObservable<Tuple<AppKit.NSPathControl, AppKit.NSOpenPanel>> WillDisplayOpenPanelObs { get { return _WillDisplayOpenPanel; } }
        public override void WillDisplayOpenPanel(AppKit.NSPathControl pathControl, AppKit.NSOpenPanel openPanel)
        {
            _WillDisplayOpenPanel.OnNext(Tuple.Create(pathControl, openPanel));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSPathControl, AppKit.NSMenu>> _WillPopUpMenu = new SingleAwaitSubject<Tuple<AppKit.NSPathControl, AppKit.NSMenu>>();
        public IObservable<Tuple<AppKit.NSPathControl, AppKit.NSMenu>> WillPopUpMenuObs { get { return _WillPopUpMenu; } }
        public override void WillPopUpMenu(AppKit.NSPathControl pathControl, AppKit.NSMenu menu)
        {
            _WillPopUpMenu.OnNext(Tuple.Create(pathControl, menu));
        }

    }
    public  partial class NSPathCellDelegateRx : NSPathCellDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSPathCell, AppKit.NSOpenPanel>> _WillDisplayOpenPanel = new SingleAwaitSubject<Tuple<AppKit.NSPathCell, AppKit.NSOpenPanel>>();
        public IObservable<Tuple<AppKit.NSPathCell, AppKit.NSOpenPanel>> WillDisplayOpenPanelObs { get { return _WillDisplayOpenPanel; } }
        public override void WillDisplayOpenPanel(AppKit.NSPathCell pathCell, AppKit.NSOpenPanel openPanel)
        {
            _WillDisplayOpenPanel.OnNext(Tuple.Create(pathCell, openPanel));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSPathCell, AppKit.NSMenu>> _WillPopupMenu = new SingleAwaitSubject<Tuple<AppKit.NSPathCell, AppKit.NSMenu>>();
        public IObservable<Tuple<AppKit.NSPathCell, AppKit.NSMenu>> WillPopupMenuObs { get { return _WillPopupMenu; } }
        public override void WillPopupMenu(AppKit.NSPathCell pathCell, AppKit.NSMenu menu)
        {
            _WillPopupMenu.OnNext(Tuple.Create(pathCell, menu));
        }

    }
    public  partial class NSOpenSavePanelDelegateRx : NSOpenSavePanelDelegate
    {
        readonly SingleAwaitSubject<AppKit.NSSavePanel> _SelectionDidChange = new SingleAwaitSubject<AppKit.NSSavePanel>();
        public IObservable<AppKit.NSSavePanel> SelectionDidChangeObs { get { return _SelectionDidChange; } }
        public override void SelectionDidChange(AppKit.NSSavePanel panel)
        {
            _SelectionDidChange.OnNext(panel);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSSavePanel, Foundation.NSUrl>> _DidChangeToDirectory = new SingleAwaitSubject<Tuple<AppKit.NSSavePanel, Foundation.NSUrl>>();
        public IObservable<Tuple<AppKit.NSSavePanel, Foundation.NSUrl>> DidChangeToDirectoryObs { get { return _DidChangeToDirectory; } }
        public override void DidChangeToDirectory(AppKit.NSSavePanel panel, Foundation.NSUrl newDirectoryUrl)
        {
            _DidChangeToDirectory.OnNext(Tuple.Create(panel, newDirectoryUrl));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSSavePanel, string>> _DirectoryDidChange = new SingleAwaitSubject<Tuple<AppKit.NSSavePanel, string>>();
        public IObservable<Tuple<AppKit.NSSavePanel, string>> DirectoryDidChangeObs { get { return _DirectoryDidChange; } }
        public override void DirectoryDidChange(AppKit.NSSavePanel panel, string path)
        {
            _DirectoryDidChange.OnNext(Tuple.Create(panel, path));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSSavePanel, System.Boolean>> _WillExpand = new SingleAwaitSubject<Tuple<AppKit.NSSavePanel, System.Boolean>>();
        public IObservable<Tuple<AppKit.NSSavePanel, System.Boolean>> WillExpandObs { get { return _WillExpand; } }
        public override void WillExpand(AppKit.NSSavePanel panel, System.Boolean expanding)
        {
            _WillExpand.OnNext(Tuple.Create(panel, expanding));
        }

    }
    public abstract partial class NSRuleEditorDelegateRx : NSRuleEditorDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _Changed = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ChangedObs { get { return _Changed; } }
        public override void Changed(Foundation.NSNotification notification)
        {
            _Changed.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _EditingBegan = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> EditingBeganObs { get { return _EditingBegan; } }
        public override void EditingBegan(Foundation.NSNotification notification)
        {
            _EditingBegan.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _EditingEnded = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> EditingEndedObs { get { return _EditingEnded; } }
        public override void EditingEnded(Foundation.NSNotification notification)
        {
            _EditingEnded.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _RowsDidChange = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> RowsDidChangeObs { get { return _RowsDidChange; } }
        public override void RowsDidChange(Foundation.NSNotification notification)
        {
            _RowsDidChange.OnNext(notification);
        }

    }
    public  partial class NSPopoverDelegateRx : NSPopoverDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _DidClose = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidCloseObs { get { return _DidClose; } }
        public override void DidClose(Foundation.NSNotification notification)
        {
            _DidClose.OnNext(notification);
        }

        readonly SingleAwaitSubject<AppKit.NSPopover> _DidDetach = new SingleAwaitSubject<AppKit.NSPopover>();
        public IObservable<AppKit.NSPopover> DidDetachObs { get { return _DidDetach; } }
        public override void DidDetach(AppKit.NSPopover popover)
        {
            _DidDetach.OnNext(popover);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidShow = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidShowObs { get { return _DidShow; } }
        public override void DidShow(Foundation.NSNotification notification)
        {
            _DidShow.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillClose = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillCloseObs { get { return _WillClose; } }
        public override void WillClose(Foundation.NSNotification notification)
        {
            _WillClose.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillShow = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillShowObs { get { return _WillShow; } }
        public override void WillShow(Foundation.NSNotification notification)
        {
            _WillShow.OnNext(notification);
        }

    }
    public  partial class NSSearchFieldDelegateRx : NSSearchFieldDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _Changed = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ChangedObs { get { return _Changed; } }
        public override void Changed(Foundation.NSNotification notification)
        {
            _Changed.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _EditingBegan = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> EditingBeganObs { get { return _EditingBegan; } }
        public override void EditingBegan(Foundation.NSNotification notification)
        {
            _EditingBegan.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _EditingEnded = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> EditingEndedObs { get { return _EditingEnded; } }
        public override void EditingEnded(Foundation.NSNotification notification)
        {
            _EditingEnded.OnNext(notification);
        }

        readonly SingleAwaitSubject<AppKit.NSSearchField> _SearchingEnded = new SingleAwaitSubject<AppKit.NSSearchField>();
        public IObservable<AppKit.NSSearchField> SearchingEndedObs { get { return _SearchingEnded; } }
        public override void SearchingEnded(AppKit.NSSearchField sender)
        {
            _SearchingEnded.OnNext(sender);
        }

        readonly SingleAwaitSubject<AppKit.NSSearchField> _SearchingStarted = new SingleAwaitSubject<AppKit.NSSearchField>();
        public IObservable<AppKit.NSSearchField> SearchingStartedObs { get { return _SearchingStarted; } }
        public override void SearchingStarted(AppKit.NSSearchField sender)
        {
            _SearchingStarted.OnNext(sender);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSControl, string, string>> _DidFailToValidatePartialString = new SingleAwaitSubject<Tuple<AppKit.NSControl, string, string>>();
        public IObservable<Tuple<AppKit.NSControl, string, string>> DidFailToValidatePartialStringObs { get { return _DidFailToValidatePartialString; } }
        public override void DidFailToValidatePartialString(AppKit.NSControl control, string str, string error)
        {
            _DidFailToValidatePartialString.OnNext(Tuple.Create(control, str, error));
        }

    }
    public  partial class NSSoundDelegateRx : NSSoundDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSSound, System.Boolean>> _DidFinishPlaying = new SingleAwaitSubject<Tuple<AppKit.NSSound, System.Boolean>>();
        public IObservable<Tuple<AppKit.NSSound, System.Boolean>> DidFinishPlayingObs { get { return _DidFinishPlaying; } }
        public override void DidFinishPlaying(AppKit.NSSound sound, System.Boolean finished)
        {
            _DidFinishPlaying.OnNext(Tuple.Create(sound, finished));
        }

    }
    public  partial class NSSpeechRecognizerDelegateRx : NSSpeechRecognizerDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSSpeechRecognizer, string>> _DidRecognizeCommand = new SingleAwaitSubject<Tuple<AppKit.NSSpeechRecognizer, string>>();
        public IObservable<Tuple<AppKit.NSSpeechRecognizer, string>> DidRecognizeCommandObs { get { return _DidRecognizeCommand; } }
        public override void DidRecognizeCommand(AppKit.NSSpeechRecognizer sender, string command)
        {
            _DidRecognizeCommand.OnNext(Tuple.Create(sender, command));
        }

    }
    public  partial class NSSpeechSynthesizerDelegateRx : NSSpeechSynthesizerDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSSpeechSynthesizer, System.nuint, string, string>> _DidEncounterError = new SingleAwaitSubject<Tuple<AppKit.NSSpeechSynthesizer, System.nuint, string, string>>();
        public IObservable<Tuple<AppKit.NSSpeechSynthesizer, System.nuint, string, string>> DidEncounterErrorObs { get { return _DidEncounterError; } }
        public override void DidEncounterError(AppKit.NSSpeechSynthesizer sender, System.nuint characterIndex, string theString, string message)
        {
            _DidEncounterError.OnNext(Tuple.Create(sender, characterIndex, theString, message));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSSpeechSynthesizer, string>> _DidEncounterSyncMessage = new SingleAwaitSubject<Tuple<AppKit.NSSpeechSynthesizer, string>>();
        public IObservable<Tuple<AppKit.NSSpeechSynthesizer, string>> DidEncounterSyncMessageObs { get { return _DidEncounterSyncMessage; } }
        public override void DidEncounterSyncMessage(AppKit.NSSpeechSynthesizer sender, string message)
        {
            _DidEncounterSyncMessage.OnNext(Tuple.Create(sender, message));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSSpeechSynthesizer, System.Boolean>> _DidFinishSpeaking = new SingleAwaitSubject<Tuple<AppKit.NSSpeechSynthesizer, System.Boolean>>();
        public IObservable<Tuple<AppKit.NSSpeechSynthesizer, System.Boolean>> DidFinishSpeakingObs { get { return _DidFinishSpeaking; } }
        public override void DidFinishSpeaking(AppKit.NSSpeechSynthesizer sender, System.Boolean finishedSpeaking)
        {
            _DidFinishSpeaking.OnNext(Tuple.Create(sender, finishedSpeaking));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSSpeechSynthesizer, System.Int16>> _WillSpeakPhoneme = new SingleAwaitSubject<Tuple<AppKit.NSSpeechSynthesizer, System.Int16>>();
        public IObservable<Tuple<AppKit.NSSpeechSynthesizer, System.Int16>> WillSpeakPhonemeObs { get { return _WillSpeakPhoneme; } }
        public override void WillSpeakPhoneme(AppKit.NSSpeechSynthesizer sender, System.Int16 phonemeOpcode)
        {
            _WillSpeakPhoneme.OnNext(Tuple.Create(sender, phonemeOpcode));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSSpeechSynthesizer, Foundation.NSRange, string>> _WillSpeakWord = new SingleAwaitSubject<Tuple<AppKit.NSSpeechSynthesizer, Foundation.NSRange, string>>();
        public IObservable<Tuple<AppKit.NSSpeechSynthesizer, Foundation.NSRange, string>> WillSpeakWordObs { get { return _WillSpeakWord; } }
        public override void WillSpeakWord(AppKit.NSSpeechSynthesizer sender, Foundation.NSRange wordCharacterRange, string ofString)
        {
            _WillSpeakWord.OnNext(Tuple.Create(sender, wordCharacterRange, ofString));
        }

    }
    public  partial class NSSharingServicePickerDelegateRx : NSSharingServicePickerDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSSharingServicePicker, AppKit.NSSharingService>> _DidChooseSharingService = new SingleAwaitSubject<Tuple<AppKit.NSSharingServicePicker, AppKit.NSSharingService>>();
        public IObservable<Tuple<AppKit.NSSharingServicePicker, AppKit.NSSharingService>> DidChooseSharingServiceObs { get { return _DidChooseSharingService; } }
        public override void DidChooseSharingService(AppKit.NSSharingServicePicker sharingServicePicker, AppKit.NSSharingService service)
        {
            _DidChooseSharingService.OnNext(Tuple.Create(sharingServicePicker, service));
        }

    }
    public  partial class NSSplitViewDelegateRx : NSSplitViewDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _DidResizeSubviews = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidResizeSubviewsObs { get { return _DidResizeSubviews; } }
        public override void DidResizeSubviews(Foundation.NSNotification notification)
        {
            _DidResizeSubviews.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _SplitViewWillResizeSubviews = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> SplitViewWillResizeSubviewsObs { get { return _SplitViewWillResizeSubviews; } }
        public override void SplitViewWillResizeSubviews(Foundation.NSNotification notification)
        {
            _SplitViewWillResizeSubviews.OnNext(notification);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSSplitView, CoreGraphics.CGSize>> _Resize = new SingleAwaitSubject<Tuple<AppKit.NSSplitView, CoreGraphics.CGSize>>();
        public IObservable<Tuple<AppKit.NSSplitView, CoreGraphics.CGSize>> ResizeObs { get { return _Resize; } }
        public override void Resize(AppKit.NSSplitView splitView, CoreGraphics.CGSize oldSize)
        {
            _Resize.OnNext(Tuple.Create(splitView, oldSize));
        }

    }
    public  partial class NSStackViewDelegateRx : NSStackViewDelegate
    {
        readonly SingleAwaitSubject<Tuple<AppKit.NSStackView, AppKit.NSView[]>> _DidReattachViews = new SingleAwaitSubject<Tuple<AppKit.NSStackView, AppKit.NSView[]>>();
        public IObservable<Tuple<AppKit.NSStackView, AppKit.NSView[]>> DidReattachViewsObs { get { return _DidReattachViews; } }
        public override void DidReattachViews(AppKit.NSStackView stackView, AppKit.NSView[] views)
        {
            _DidReattachViews.OnNext(Tuple.Create(stackView, views));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSStackView, AppKit.NSView[]>> _WillDetachViews = new SingleAwaitSubject<Tuple<AppKit.NSStackView, AppKit.NSView[]>>();
        public IObservable<Tuple<AppKit.NSStackView, AppKit.NSView[]>> WillDetachViewsObs { get { return _WillDetachViews; } }
        public override void WillDetachViews(AppKit.NSStackView stackView, AppKit.NSView[] views)
        {
            _WillDetachViews.OnNext(Tuple.Create(stackView, views));
        }

    }
    public  partial class NSTabViewDelegateRx : NSTabViewDelegate
    {
        readonly SingleAwaitSubject<AppKit.NSTabView> _NumberOfItemsChanged = new SingleAwaitSubject<AppKit.NSTabView>();
        public IObservable<AppKit.NSTabView> NumberOfItemsChangedObs { get { return _NumberOfItemsChanged; } }
        public override void NumberOfItemsChanged(AppKit.NSTabView tabView)
        {
            _NumberOfItemsChanged.OnNext(tabView);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTabView, AppKit.NSTabViewItem>> _DidSelect = new SingleAwaitSubject<Tuple<AppKit.NSTabView, AppKit.NSTabViewItem>>();
        public IObservable<Tuple<AppKit.NSTabView, AppKit.NSTabViewItem>> DidSelectObs { get { return _DidSelect; } }
        public override void DidSelect(AppKit.NSTabView tabView, AppKit.NSTabViewItem item)
        {
            _DidSelect.OnNext(Tuple.Create(tabView, item));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTabView, AppKit.NSTabViewItem>> _WillSelect = new SingleAwaitSubject<Tuple<AppKit.NSTabView, AppKit.NSTabViewItem>>();
        public IObservable<Tuple<AppKit.NSTabView, AppKit.NSTabViewItem>> WillSelectObs { get { return _WillSelect; } }
        public override void WillSelect(AppKit.NSTabView tabView, AppKit.NSTabViewItem item)
        {
            _WillSelect.OnNext(Tuple.Create(tabView, item));
        }

    }
    public  partial class NSTextDelegateRx : NSTextDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _TextDidBeginEditing = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> TextDidBeginEditingObs { get { return _TextDidBeginEditing; } }
        public override void TextDidBeginEditing(Foundation.NSNotification notification)
        {
            _TextDidBeginEditing.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _TextDidChange = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> TextDidChangeObs { get { return _TextDidChange; } }
        public override void TextDidChange(Foundation.NSNotification notification)
        {
            _TextDidChange.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _TextDidEndEditing = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> TextDidEndEditingObs { get { return _TextDidEndEditing; } }
        public override void TextDidEndEditing(Foundation.NSNotification notification)
        {
            _TextDidEndEditing.OnNext(notification);
        }

    }
    public  partial class NSTextFieldDelegateRx : NSTextFieldDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _Changed = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ChangedObs { get { return _Changed; } }
        public override void Changed(Foundation.NSNotification notification)
        {
            _Changed.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _EditingBegan = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> EditingBeganObs { get { return _EditingBegan; } }
        public override void EditingBegan(Foundation.NSNotification notification)
        {
            _EditingBegan.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _EditingEnded = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> EditingEndedObs { get { return _EditingEnded; } }
        public override void EditingEnded(Foundation.NSNotification notification)
        {
            _EditingEnded.OnNext(notification);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSControl, string, string>> _DidFailToValidatePartialString = new SingleAwaitSubject<Tuple<AppKit.NSControl, string, string>>();
        public IObservable<Tuple<AppKit.NSControl, string, string>> DidFailToValidatePartialStringObs { get { return _DidFailToValidatePartialString; } }
        public override void DidFailToValidatePartialString(AppKit.NSControl control, string str, string error)
        {
            _DidFailToValidatePartialString.OnNext(Tuple.Create(control, str, error));
        }

    }
    public  partial class NSTableViewDelegateRx : NSTableViewDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _ColumnDidMove = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ColumnDidMoveObs { get { return _ColumnDidMove; } }
        public override void ColumnDidMove(Foundation.NSNotification notification)
        {
            _ColumnDidMove.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _ColumnDidResize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> ColumnDidResizeObs { get { return _ColumnDidResize; } }
        public override void ColumnDidResize(Foundation.NSNotification notification)
        {
            _ColumnDidResize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _SelectionDidChange = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> SelectionDidChangeObs { get { return _SelectionDidChange; } }
        public override void SelectionDidChange(Foundation.NSNotification notification)
        {
            _SelectionDidChange.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _SelectionIsChanging = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> SelectionIsChangingObs { get { return _SelectionIsChanging; } }
        public override void SelectionIsChanging(Foundation.NSNotification notification)
        {
            _SelectionIsChanging.OnNext(notification);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTableView, AppKit.NSTableRowView, System.nint>> _DidAddRowView = new SingleAwaitSubject<Tuple<AppKit.NSTableView, AppKit.NSTableRowView, System.nint>>();
        public IObservable<Tuple<AppKit.NSTableView, AppKit.NSTableRowView, System.nint>> DidAddRowViewObs { get { return _DidAddRowView; } }
        public override void DidAddRowView(AppKit.NSTableView tableView, AppKit.NSTableRowView rowView, System.nint row)
        {
            _DidAddRowView.OnNext(Tuple.Create(tableView, rowView, row));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTableView, AppKit.NSTableColumn>> _DidClickTableColumn = new SingleAwaitSubject<Tuple<AppKit.NSTableView, AppKit.NSTableColumn>>();
        public IObservable<Tuple<AppKit.NSTableView, AppKit.NSTableColumn>> DidClickTableColumnObs { get { return _DidClickTableColumn; } }
        public override void DidClickTableColumn(AppKit.NSTableView tableView, AppKit.NSTableColumn tableColumn)
        {
            _DidClickTableColumn.OnNext(Tuple.Create(tableView, tableColumn));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTableView, AppKit.NSTableColumn>> _DidDragTableColumn = new SingleAwaitSubject<Tuple<AppKit.NSTableView, AppKit.NSTableColumn>>();
        public IObservable<Tuple<AppKit.NSTableView, AppKit.NSTableColumn>> DidDragTableColumnObs { get { return _DidDragTableColumn; } }
        public override void DidDragTableColumn(AppKit.NSTableView tableView, AppKit.NSTableColumn tableColumn)
        {
            _DidDragTableColumn.OnNext(Tuple.Create(tableView, tableColumn));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTableView, AppKit.NSTableRowView, System.nint>> _DidRemoveRowView = new SingleAwaitSubject<Tuple<AppKit.NSTableView, AppKit.NSTableRowView, System.nint>>();
        public IObservable<Tuple<AppKit.NSTableView, AppKit.NSTableRowView, System.nint>> DidRemoveRowViewObs { get { return _DidRemoveRowView; } }
        public override void DidRemoveRowView(AppKit.NSTableView tableView, AppKit.NSTableRowView rowView, System.nint row)
        {
            _DidRemoveRowView.OnNext(Tuple.Create(tableView, rowView, row));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTableView, AppKit.NSTableColumn>> _MouseDownInHeaderOfTableColumn = new SingleAwaitSubject<Tuple<AppKit.NSTableView, AppKit.NSTableColumn>>();
        public IObservable<Tuple<AppKit.NSTableView, AppKit.NSTableColumn>> MouseDownInHeaderOfTableColumnObs { get { return _MouseDownInHeaderOfTableColumn; } }
        public override void MouseDownInHeaderOfTableColumn(AppKit.NSTableView tableView, AppKit.NSTableColumn tableColumn)
        {
            _MouseDownInHeaderOfTableColumn.OnNext(Tuple.Create(tableView, tableColumn));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTableView, Foundation.NSObject, AppKit.NSTableColumn, System.nint>> _WillDisplayCell = new SingleAwaitSubject<Tuple<AppKit.NSTableView, Foundation.NSObject, AppKit.NSTableColumn, System.nint>>();
        public IObservable<Tuple<AppKit.NSTableView, Foundation.NSObject, AppKit.NSTableColumn, System.nint>> WillDisplayCellObs { get { return _WillDisplayCell; } }
        public override void WillDisplayCell(AppKit.NSTableView tableView, Foundation.NSObject cell, AppKit.NSTableColumn tableColumn, System.nint row)
        {
            _WillDisplayCell.OnNext(Tuple.Create(tableView, cell, tableColumn, row));
        }

    }
    public  partial class NSTextViewDelegateRx : NSTextViewDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _DidChangeSelection = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidChangeSelectionObs { get { return _DidChangeSelection; } }
        public override void DidChangeSelection(Foundation.NSNotification notification)
        {
            _DidChangeSelection.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidChangeTypingAttributes = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidChangeTypingAttributesObs { get { return _DidChangeTypingAttributes; } }
        public override void DidChangeTypingAttributes(Foundation.NSNotification notification)
        {
            _DidChangeTypingAttributes.OnNext(notification);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTextView, AppKit.NSTextAttachmentCell, CoreGraphics.CGRect, System.nuint>> _CellClicked = new SingleAwaitSubject<Tuple<AppKit.NSTextView, AppKit.NSTextAttachmentCell, CoreGraphics.CGRect, System.nuint>>();
        public IObservable<Tuple<AppKit.NSTextView, AppKit.NSTextAttachmentCell, CoreGraphics.CGRect, System.nuint>> CellClickedObs { get { return _CellClicked; } }
        public override void CellClicked(AppKit.NSTextView textView, AppKit.NSTextAttachmentCell cell, CoreGraphics.CGRect cellFrame, System.nuint charIndex)
        {
            _CellClicked.OnNext(Tuple.Create(textView, cell, cellFrame, charIndex));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTextView, AppKit.NSTextAttachmentCell, CoreGraphics.CGRect, System.nuint>> _CellDoubleClicked = new SingleAwaitSubject<Tuple<AppKit.NSTextView, AppKit.NSTextAttachmentCell, CoreGraphics.CGRect, System.nuint>>();
        public IObservable<Tuple<AppKit.NSTextView, AppKit.NSTextAttachmentCell, CoreGraphics.CGRect, System.nuint>> CellDoubleClickedObs { get { return _CellDoubleClicked; } }
        public override void CellDoubleClicked(AppKit.NSTextView textView, AppKit.NSTextAttachmentCell cell, CoreGraphics.CGRect cellFrame, System.nuint charIndex)
        {
            _CellDoubleClicked.OnNext(Tuple.Create(textView, cell, cellFrame, charIndex));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTextView, AppKit.NSTextAttachmentCell, CoreGraphics.CGRect, AppKit.NSEvent>> _DraggedCell = new SingleAwaitSubject<Tuple<AppKit.NSTextView, AppKit.NSTextAttachmentCell, CoreGraphics.CGRect, AppKit.NSEvent>>();
        public IObservable<Tuple<AppKit.NSTextView, AppKit.NSTextAttachmentCell, CoreGraphics.CGRect, AppKit.NSEvent>> DraggedCellObs { get { return _DraggedCell; } }
        public override void DraggedCell(AppKit.NSTextView view, AppKit.NSTextAttachmentCell cell, CoreGraphics.CGRect rect, AppKit.NSEvent theevent)
        {
            _DraggedCell.OnNext(Tuple.Create(view, cell, rect, theevent));
        }

    }
    public  partial class NSToolbarDelegateRx : NSToolbarDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _DidRemoveItem = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidRemoveItemObs { get { return _DidRemoveItem; } }
        public override void DidRemoveItem(Foundation.NSNotification notification)
        {
            _DidRemoveItem.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillAddItem = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillAddItemObs { get { return _WillAddItem; } }
        public override void WillAddItem(Foundation.NSNotification notification)
        {
            _WillAddItem.OnNext(notification);
        }

    }
    public  partial class NSTextStorageDelegateRx : NSTextStorageDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _TextStorageDidProcessEditing = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> TextStorageDidProcessEditingObs { get { return _TextStorageDidProcessEditing; } }
        public override void TextStorageDidProcessEditing(Foundation.NSNotification notification)
        {
            _TextStorageDidProcessEditing.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _TextStorageWillProcessEditing = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> TextStorageWillProcessEditingObs { get { return _TextStorageWillProcessEditing; } }
        public override void TextStorageWillProcessEditing(Foundation.NSNotification notification)
        {
            _TextStorageWillProcessEditing.OnNext(notification);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTextStorage, AppKit.NSTextStorageEditActions, Foundation.NSRange, System.nint>> _DidProcessEditing = new SingleAwaitSubject<Tuple<AppKit.NSTextStorage, AppKit.NSTextStorageEditActions, Foundation.NSRange, System.nint>>();
        public IObservable<Tuple<AppKit.NSTextStorage, AppKit.NSTextStorageEditActions, Foundation.NSRange, System.nint>> DidProcessEditingObs { get { return _DidProcessEditing; } }
        public override void DidProcessEditing(AppKit.NSTextStorage textStorage, AppKit.NSTextStorageEditActions editedMask, Foundation.NSRange editedRange, System.nint delta)
        {
            _DidProcessEditing.OnNext(Tuple.Create(textStorage, editedMask, editedRange, delta));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSTextStorage, AppKit.NSTextStorageEditActions, Foundation.NSRange, System.nint>> _WillProcessEditing = new SingleAwaitSubject<Tuple<AppKit.NSTextStorage, AppKit.NSTextStorageEditActions, Foundation.NSRange, System.nint>>();
        public IObservable<Tuple<AppKit.NSTextStorage, AppKit.NSTextStorageEditActions, Foundation.NSRange, System.nint>> WillProcessEditingObs { get { return _WillProcessEditing; } }
        public override void WillProcessEditing(AppKit.NSTextStorage textStorage, AppKit.NSTextStorageEditActions editedMask, Foundation.NSRange editedRange, System.nint delta)
        {
            _WillProcessEditing.OnNext(Tuple.Create(textStorage, editedMask, editedRange, delta));
        }

    }
    public  partial class NSWindowDelegateRx : NSWindowDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _DidBecomeKey = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidBecomeKeyObs { get { return _DidBecomeKey; } }
        public override void DidBecomeKey(Foundation.NSNotification notification)
        {
            _DidBecomeKey.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidBecomeMain = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidBecomeMainObs { get { return _DidBecomeMain; } }
        public override void DidBecomeMain(Foundation.NSNotification notification)
        {
            _DidBecomeMain.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidChangeBackingProperties = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidChangeBackingPropertiesObs { get { return _DidChangeBackingProperties; } }
        public override void DidChangeBackingProperties(Foundation.NSNotification notification)
        {
            _DidChangeBackingProperties.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidChangeScreen = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidChangeScreenObs { get { return _DidChangeScreen; } }
        public override void DidChangeScreen(Foundation.NSNotification notification)
        {
            _DidChangeScreen.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidChangeScreenProfile = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidChangeScreenProfileObs { get { return _DidChangeScreenProfile; } }
        public override void DidChangeScreenProfile(Foundation.NSNotification notification)
        {
            _DidChangeScreenProfile.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidDeminiaturize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidDeminiaturizeObs { get { return _DidDeminiaturize; } }
        public override void DidDeminiaturize(Foundation.NSNotification notification)
        {
            _DidDeminiaturize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidEndLiveResize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidEndLiveResizeObs { get { return _DidEndLiveResize; } }
        public override void DidEndLiveResize(Foundation.NSNotification notification)
        {
            _DidEndLiveResize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidEndSheet = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidEndSheetObs { get { return _DidEndSheet; } }
        public override void DidEndSheet(Foundation.NSNotification notification)
        {
            _DidEndSheet.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidEnterFullScreen = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidEnterFullScreenObs { get { return _DidEnterFullScreen; } }
        public override void DidEnterFullScreen(Foundation.NSNotification notification)
        {
            _DidEnterFullScreen.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidEnterVersionBrowser = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidEnterVersionBrowserObs { get { return _DidEnterVersionBrowser; } }
        public override void DidEnterVersionBrowser(Foundation.NSNotification notification)
        {
            _DidEnterVersionBrowser.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidExitFullScreen = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidExitFullScreenObs { get { return _DidExitFullScreen; } }
        public override void DidExitFullScreen(Foundation.NSNotification notification)
        {
            _DidExitFullScreen.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidExitVersionBrowser = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidExitVersionBrowserObs { get { return _DidExitVersionBrowser; } }
        public override void DidExitVersionBrowser(Foundation.NSNotification notification)
        {
            _DidExitVersionBrowser.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidExpose = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidExposeObs { get { return _DidExpose; } }
        public override void DidExpose(Foundation.NSNotification notification)
        {
            _DidExpose.OnNext(notification);
        }

        readonly SingleAwaitSubject<AppKit.NSWindow> _DidFailToEnterFullScreen = new SingleAwaitSubject<AppKit.NSWindow>();
        public IObservable<AppKit.NSWindow> DidFailToEnterFullScreenObs { get { return _DidFailToEnterFullScreen; } }
        public override void DidFailToEnterFullScreen(AppKit.NSWindow window)
        {
            _DidFailToEnterFullScreen.OnNext(window);
        }

        readonly SingleAwaitSubject<AppKit.NSWindow> _DidFailToExitFullScreen = new SingleAwaitSubject<AppKit.NSWindow>();
        public IObservable<AppKit.NSWindow> DidFailToExitFullScreenObs { get { return _DidFailToExitFullScreen; } }
        public override void DidFailToExitFullScreen(AppKit.NSWindow window)
        {
            _DidFailToExitFullScreen.OnNext(window);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidMiniaturize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidMiniaturizeObs { get { return _DidMiniaturize; } }
        public override void DidMiniaturize(Foundation.NSNotification notification)
        {
            _DidMiniaturize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidMove = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidMoveObs { get { return _DidMove; } }
        public override void DidMove(Foundation.NSNotification notification)
        {
            _DidMove.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidResignKey = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidResignKeyObs { get { return _DidResignKey; } }
        public override void DidResignKey(Foundation.NSNotification notification)
        {
            _DidResignKey.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidResignMain = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidResignMainObs { get { return _DidResignMain; } }
        public override void DidResignMain(Foundation.NSNotification notification)
        {
            _DidResignMain.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidResize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidResizeObs { get { return _DidResize; } }
        public override void DidResize(Foundation.NSNotification notification)
        {
            _DidResize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidUpdate = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidUpdateObs { get { return _DidUpdate; } }
        public override void DidUpdate(Foundation.NSNotification notification)
        {
            _DidUpdate.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillBeginSheet = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillBeginSheetObs { get { return _WillBeginSheet; } }
        public override void WillBeginSheet(Foundation.NSNotification notification)
        {
            _WillBeginSheet.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillClose = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillCloseObs { get { return _WillClose; } }
        public override void WillClose(Foundation.NSNotification notification)
        {
            _WillClose.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillEnterFullScreen = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillEnterFullScreenObs { get { return _WillEnterFullScreen; } }
        public override void WillEnterFullScreen(Foundation.NSNotification notification)
        {
            _WillEnterFullScreen.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillEnterVersionBrowser = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillEnterVersionBrowserObs { get { return _WillEnterVersionBrowser; } }
        public override void WillEnterVersionBrowser(Foundation.NSNotification notification)
        {
            _WillEnterVersionBrowser.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillExitFullScreen = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillExitFullScreenObs { get { return _WillExitFullScreen; } }
        public override void WillExitFullScreen(Foundation.NSNotification notification)
        {
            _WillExitFullScreen.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillExitVersionBrowser = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillExitVersionBrowserObs { get { return _WillExitVersionBrowser; } }
        public override void WillExitVersionBrowser(Foundation.NSNotification notification)
        {
            _WillExitVersionBrowser.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillMiniaturize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillMiniaturizeObs { get { return _WillMiniaturize; } }
        public override void WillMiniaturize(Foundation.NSNotification notification)
        {
            _WillMiniaturize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillMove = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillMoveObs { get { return _WillMove; } }
        public override void WillMove(Foundation.NSNotification notification)
        {
            _WillMove.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillStartLiveResize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillStartLiveResizeObs { get { return _WillStartLiveResize; } }
        public override void WillStartLiveResize(Foundation.NSNotification notification)
        {
            _WillStartLiveResize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSWindow, Foundation.NSCoder>> _DidDecodeRestorableState = new SingleAwaitSubject<Tuple<AppKit.NSWindow, Foundation.NSCoder>>();
        public IObservable<Tuple<AppKit.NSWindow, Foundation.NSCoder>> DidDecodeRestorableStateObs { get { return _DidDecodeRestorableState; } }
        public override void DidDecodeRestorableState(AppKit.NSWindow window, Foundation.NSCoder coder)
        {
            _DidDecodeRestorableState.OnNext(Tuple.Create(window, coder));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSWindow, System.Double>> _StartCustomAnimationToEnterFullScreen = new SingleAwaitSubject<Tuple<AppKit.NSWindow, System.Double>>();
        public IObservable<Tuple<AppKit.NSWindow, System.Double>> StartCustomAnimationToEnterFullScreenObs { get { return _StartCustomAnimationToEnterFullScreen; } }
        public override void StartCustomAnimationToEnterFullScreen(AppKit.NSWindow window, System.Double duration)
        {
            _StartCustomAnimationToEnterFullScreen.OnNext(Tuple.Create(window, duration));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSWindow, System.Double>> _StartCustomAnimationToExitFullScreen = new SingleAwaitSubject<Tuple<AppKit.NSWindow, System.Double>>();
        public IObservable<Tuple<AppKit.NSWindow, System.Double>> StartCustomAnimationToExitFullScreenObs { get { return _StartCustomAnimationToExitFullScreen; } }
        public override void StartCustomAnimationToExitFullScreen(AppKit.NSWindow window, System.Double duration)
        {
            _StartCustomAnimationToExitFullScreen.OnNext(Tuple.Create(window, duration));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSWindow, Foundation.NSCoder>> _WillEncodeRestorableState = new SingleAwaitSubject<Tuple<AppKit.NSWindow, Foundation.NSCoder>>();
        public IObservable<Tuple<AppKit.NSWindow, Foundation.NSCoder>> WillEncodeRestorableStateObs { get { return _WillEncodeRestorableState; } }
        public override void WillEncodeRestorableState(AppKit.NSWindow window, Foundation.NSCoder coder)
        {
            _WillEncodeRestorableState.OnNext(Tuple.Create(window, coder));
        }

    }
}
namespace CoreLocation.Rx
{
    public  partial class CLLocationManagerDelegateRx : CLLocationManagerDelegate
    {
        readonly SingleAwaitSubject<CoreLocation.CLLocationManager> _LocationUpdatesPaused = new SingleAwaitSubject<CoreLocation.CLLocationManager>();
        public IObservable<CoreLocation.CLLocationManager> LocationUpdatesPausedObs { get { return _LocationUpdatesPaused; } }
        public override void LocationUpdatesPaused(CoreLocation.CLLocationManager manager)
        {
            _LocationUpdatesPaused.OnNext(manager);
        }

        readonly SingleAwaitSubject<CoreLocation.CLLocationManager> _LocationUpdatesResumed = new SingleAwaitSubject<CoreLocation.CLLocationManager>();
        public IObservable<CoreLocation.CLLocationManager> LocationUpdatesResumedObs { get { return _LocationUpdatesResumed; } }
        public override void LocationUpdatesResumed(CoreLocation.CLLocationManager manager)
        {
            _LocationUpdatesResumed.OnNext(manager);
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLAuthorizationStatus>> _AuthorizationChanged = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLAuthorizationStatus>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLAuthorizationStatus>> AuthorizationChangedObs { get { return _AuthorizationChanged; } }
        public override void AuthorizationChanged(CoreLocation.CLLocationManager manager, CoreLocation.CLAuthorizationStatus status)
        {
            _AuthorizationChanged.OnNext(Tuple.Create(manager, status));
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, Foundation.NSError>> _DeferredUpdatesFinished = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, Foundation.NSError>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, Foundation.NSError>> DeferredUpdatesFinishedObs { get { return _DeferredUpdatesFinished; } }
        public override void DeferredUpdatesFinished(CoreLocation.CLLocationManager manager, Foundation.NSError error)
        {
            _DeferredUpdatesFinished.OnNext(Tuple.Create(manager, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegionState, CoreLocation.CLRegion>> _DidDetermineState = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegionState, CoreLocation.CLRegion>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegionState, CoreLocation.CLRegion>> DidDetermineStateObs { get { return _DidDetermineState; } }
        public override void DidDetermineState(CoreLocation.CLLocationManager manager, CoreLocation.CLRegionState state, CoreLocation.CLRegion region)
        {
            _DidDetermineState.OnNext(Tuple.Create(manager, state, region));
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion>> _DidStartMonitoringForRegion = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion>> DidStartMonitoringForRegionObs { get { return _DidStartMonitoringForRegion; } }
        public override void DidStartMonitoringForRegion(CoreLocation.CLLocationManager manager, CoreLocation.CLRegion region)
        {
            _DidStartMonitoringForRegion.OnNext(Tuple.Create(manager, region));
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, Foundation.NSError>> _Failed = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, Foundation.NSError>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, Foundation.NSError>> FailedObs { get { return _Failed; } }
        public override void Failed(CoreLocation.CLLocationManager manager, Foundation.NSError error)
        {
            _Failed.OnNext(Tuple.Create(manager, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLLocation[]>> _LocationsUpdated = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLLocation[]>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLLocation[]>> LocationsUpdatedObs { get { return _LocationsUpdated; } }
        public override void LocationsUpdated(CoreLocation.CLLocationManager manager, CoreLocation.CLLocation[] locations)
        {
            _LocationsUpdated.OnNext(Tuple.Create(manager, locations));
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion, Foundation.NSError>> _MonitoringFailed = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion, Foundation.NSError>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion, Foundation.NSError>> MonitoringFailedObs { get { return _MonitoringFailed; } }
        public override void MonitoringFailed(CoreLocation.CLLocationManager manager, CoreLocation.CLRegion region, Foundation.NSError error)
        {
            _MonitoringFailed.OnNext(Tuple.Create(manager, region, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion>> _RegionEntered = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion>> RegionEnteredObs { get { return _RegionEntered; } }
        public override void RegionEntered(CoreLocation.CLLocationManager manager, CoreLocation.CLRegion region)
        {
            _RegionEntered.OnNext(Tuple.Create(manager, region));
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion>> _RegionLeft = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion>> RegionLeftObs { get { return _RegionLeft; } }
        public override void RegionLeft(CoreLocation.CLLocationManager manager, CoreLocation.CLRegion region)
        {
            _RegionLeft.OnNext(Tuple.Create(manager, region));
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLLocation, CoreLocation.CLLocation>> _UpdatedLocation = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLLocation, CoreLocation.CLLocation>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLLocation, CoreLocation.CLLocation>> UpdatedLocationObs { get { return _UpdatedLocation; } }
        public override void UpdatedLocation(CoreLocation.CLLocationManager manager, CoreLocation.CLLocation newLocation, CoreLocation.CLLocation oldLocation)
        {
            _UpdatedLocation.OnNext(Tuple.Create(manager, newLocation, oldLocation));
        }

    }
}
namespace MultipeerConnectivity.Rx
{
    public  partial class MCAdvertiserAssistantDelegateRx : MCAdvertiserAssistantDelegate
    {
        readonly SingleAwaitSubject<MultipeerConnectivity.MCAdvertiserAssistant> _DidDismissInvitation = new SingleAwaitSubject<MultipeerConnectivity.MCAdvertiserAssistant>();
        public IObservable<MultipeerConnectivity.MCAdvertiserAssistant> DidDismissInvitationObs { get { return _DidDismissInvitation; } }
        public override void DidDismissInvitation(MultipeerConnectivity.MCAdvertiserAssistant advertiserAssistant)
        {
            _DidDismissInvitation.OnNext(advertiserAssistant);
        }

        readonly SingleAwaitSubject<MultipeerConnectivity.MCAdvertiserAssistant> _WillPresentInvitation = new SingleAwaitSubject<MultipeerConnectivity.MCAdvertiserAssistant>();
        public IObservable<MultipeerConnectivity.MCAdvertiserAssistant> WillPresentInvitationObs { get { return _WillPresentInvitation; } }
        public override void WillPresentInvitation(MultipeerConnectivity.MCAdvertiserAssistant advertiserAssistant)
        {
            _WillPresentInvitation.OnNext(advertiserAssistant);
        }

    }
    public abstract partial class MCBrowserViewControllerDelegateRx : MCBrowserViewControllerDelegate
    {
        readonly SingleAwaitSubject<MultipeerConnectivity.MCBrowserViewController> _DidFinish = new SingleAwaitSubject<MultipeerConnectivity.MCBrowserViewController>();
        public IObservable<MultipeerConnectivity.MCBrowserViewController> DidFinishObs { get { return _DidFinish; } }
        public override void DidFinish(MultipeerConnectivity.MCBrowserViewController browserViewController)
        {
            _DidFinish.OnNext(browserViewController);
        }

        readonly SingleAwaitSubject<MultipeerConnectivity.MCBrowserViewController> _WasCancelled = new SingleAwaitSubject<MultipeerConnectivity.MCBrowserViewController>();
        public IObservable<MultipeerConnectivity.MCBrowserViewController> WasCancelledObs { get { return _WasCancelled; } }
        public override void WasCancelled(MultipeerConnectivity.MCBrowserViewController browserViewController)
        {
            _WasCancelled.OnNext(browserViewController);
        }

    }
    public abstract partial class MCNearbyServiceAdvertiserDelegateRx : MCNearbyServiceAdvertiserDelegate
    {
        readonly SingleAwaitSubject<Tuple<MultipeerConnectivity.MCNearbyServiceAdvertiser, Foundation.NSError>> _DidNotStartAdvertisingPeer = new SingleAwaitSubject<Tuple<MultipeerConnectivity.MCNearbyServiceAdvertiser, Foundation.NSError>>();
        public IObservable<Tuple<MultipeerConnectivity.MCNearbyServiceAdvertiser, Foundation.NSError>> DidNotStartAdvertisingPeerObs { get { return _DidNotStartAdvertisingPeer; } }
        public override void DidNotStartAdvertisingPeer(MultipeerConnectivity.MCNearbyServiceAdvertiser advertiser, Foundation.NSError error)
        {
            _DidNotStartAdvertisingPeer.OnNext(Tuple.Create(advertiser, error));
        }

        readonly SingleAwaitSubject<Tuple<MultipeerConnectivity.MCNearbyServiceAdvertiser, MultipeerConnectivity.MCPeerID, Foundation.NSData, MultipeerConnectivity.MCNearbyServiceAdvertiserInvitationHandler>> _DidReceiveInvitationFromPeer = new SingleAwaitSubject<Tuple<MultipeerConnectivity.MCNearbyServiceAdvertiser, MultipeerConnectivity.MCPeerID, Foundation.NSData, MultipeerConnectivity.MCNearbyServiceAdvertiserInvitationHandler>>();
        public IObservable<Tuple<MultipeerConnectivity.MCNearbyServiceAdvertiser, MultipeerConnectivity.MCPeerID, Foundation.NSData, MultipeerConnectivity.MCNearbyServiceAdvertiserInvitationHandler>> DidReceiveInvitationFromPeerObs { get { return _DidReceiveInvitationFromPeer; } }
        public override void DidReceiveInvitationFromPeer(MultipeerConnectivity.MCNearbyServiceAdvertiser advertiser, MultipeerConnectivity.MCPeerID peerID, Foundation.NSData context, MultipeerConnectivity.MCNearbyServiceAdvertiserInvitationHandler invitationHandler)
        {
            _DidReceiveInvitationFromPeer.OnNext(Tuple.Create(advertiser, peerID, context, invitationHandler));
        }

    }
    public abstract partial class MCNearbyServiceBrowserDelegateRx : MCNearbyServiceBrowserDelegate
    {
        readonly SingleAwaitSubject<Tuple<MultipeerConnectivity.MCNearbyServiceBrowser, Foundation.NSError>> _DidNotStartBrowsingForPeers = new SingleAwaitSubject<Tuple<MultipeerConnectivity.MCNearbyServiceBrowser, Foundation.NSError>>();
        public IObservable<Tuple<MultipeerConnectivity.MCNearbyServiceBrowser, Foundation.NSError>> DidNotStartBrowsingForPeersObs { get { return _DidNotStartBrowsingForPeers; } }
        public override void DidNotStartBrowsingForPeers(MultipeerConnectivity.MCNearbyServiceBrowser browser, Foundation.NSError error)
        {
            _DidNotStartBrowsingForPeers.OnNext(Tuple.Create(browser, error));
        }

        readonly SingleAwaitSubject<Tuple<MultipeerConnectivity.MCNearbyServiceBrowser, MultipeerConnectivity.MCPeerID, Foundation.NSDictionary>> _FoundPeer = new SingleAwaitSubject<Tuple<MultipeerConnectivity.MCNearbyServiceBrowser, MultipeerConnectivity.MCPeerID, Foundation.NSDictionary>>();
        public IObservable<Tuple<MultipeerConnectivity.MCNearbyServiceBrowser, MultipeerConnectivity.MCPeerID, Foundation.NSDictionary>> FoundPeerObs { get { return _FoundPeer; } }
        public override void FoundPeer(MultipeerConnectivity.MCNearbyServiceBrowser browser, MultipeerConnectivity.MCPeerID peerID, Foundation.NSDictionary info)
        {
            _FoundPeer.OnNext(Tuple.Create(browser, peerID, info));
        }

        readonly SingleAwaitSubject<Tuple<MultipeerConnectivity.MCNearbyServiceBrowser, MultipeerConnectivity.MCPeerID>> _LostPeer = new SingleAwaitSubject<Tuple<MultipeerConnectivity.MCNearbyServiceBrowser, MultipeerConnectivity.MCPeerID>>();
        public IObservable<Tuple<MultipeerConnectivity.MCNearbyServiceBrowser, MultipeerConnectivity.MCPeerID>> LostPeerObs { get { return _LostPeer; } }
        public override void LostPeer(MultipeerConnectivity.MCNearbyServiceBrowser browser, MultipeerConnectivity.MCPeerID peerID)
        {
            _LostPeer.OnNext(Tuple.Create(browser, peerID));
        }

    }
    public abstract partial class MCSessionDelegateRx : MCSessionDelegate
    {
        readonly SingleAwaitSubject<Tuple<MultipeerConnectivity.MCSession, MultipeerConnectivity.MCPeerID, MultipeerConnectivity.MCSessionState>> _DidChangeState = new SingleAwaitSubject<Tuple<MultipeerConnectivity.MCSession, MultipeerConnectivity.MCPeerID, MultipeerConnectivity.MCSessionState>>();
        public IObservable<Tuple<MultipeerConnectivity.MCSession, MultipeerConnectivity.MCPeerID, MultipeerConnectivity.MCSessionState>> DidChangeStateObs { get { return _DidChangeState; } }
        public override void DidChangeState(MultipeerConnectivity.MCSession session, MultipeerConnectivity.MCPeerID peerID, MultipeerConnectivity.MCSessionState state)
        {
            _DidChangeState.OnNext(Tuple.Create(session, peerID, state));
        }

        readonly SingleAwaitSubject<Tuple<MultipeerConnectivity.MCSession, string, MultipeerConnectivity.MCPeerID, Foundation.NSUrl, Foundation.NSError>> _DidFinishReceivingResource = new SingleAwaitSubject<Tuple<MultipeerConnectivity.MCSession, string, MultipeerConnectivity.MCPeerID, Foundation.NSUrl, Foundation.NSError>>();
        public IObservable<Tuple<MultipeerConnectivity.MCSession, string, MultipeerConnectivity.MCPeerID, Foundation.NSUrl, Foundation.NSError>> DidFinishReceivingResourceObs { get { return _DidFinishReceivingResource; } }
        public override void DidFinishReceivingResource(MultipeerConnectivity.MCSession session, string resourceName, MultipeerConnectivity.MCPeerID fromPeer, Foundation.NSUrl localUrl, Foundation.NSError error)
        {
            _DidFinishReceivingResource.OnNext(Tuple.Create(session, resourceName, fromPeer, localUrl, error));
        }

        readonly SingleAwaitSubject<Tuple<MultipeerConnectivity.MCSession, Foundation.NSData, MultipeerConnectivity.MCPeerID>> _DidReceiveData = new SingleAwaitSubject<Tuple<MultipeerConnectivity.MCSession, Foundation.NSData, MultipeerConnectivity.MCPeerID>>();
        public IObservable<Tuple<MultipeerConnectivity.MCSession, Foundation.NSData, MultipeerConnectivity.MCPeerID>> DidReceiveDataObs { get { return _DidReceiveData; } }
        public override void DidReceiveData(MultipeerConnectivity.MCSession session, Foundation.NSData data, MultipeerConnectivity.MCPeerID peerID)
        {
            _DidReceiveData.OnNext(Tuple.Create(session, data, peerID));
        }

        readonly SingleAwaitSubject<Tuple<MultipeerConnectivity.MCSession, Foundation.NSInputStream, string, MultipeerConnectivity.MCPeerID>> _DidReceiveStream = new SingleAwaitSubject<Tuple<MultipeerConnectivity.MCSession, Foundation.NSInputStream, string, MultipeerConnectivity.MCPeerID>>();
        public IObservable<Tuple<MultipeerConnectivity.MCSession, Foundation.NSInputStream, string, MultipeerConnectivity.MCPeerID>> DidReceiveStreamObs { get { return _DidReceiveStream; } }
        public override void DidReceiveStream(MultipeerConnectivity.MCSession session, Foundation.NSInputStream stream, string streamName, MultipeerConnectivity.MCPeerID peerID)
        {
            _DidReceiveStream.OnNext(Tuple.Create(session, stream, streamName, peerID));
        }

        readonly SingleAwaitSubject<Tuple<MultipeerConnectivity.MCSession, string, MultipeerConnectivity.MCPeerID, Foundation.NSProgress>> _DidStartReceivingResource = new SingleAwaitSubject<Tuple<MultipeerConnectivity.MCSession, string, MultipeerConnectivity.MCPeerID, Foundation.NSProgress>>();
        public IObservable<Tuple<MultipeerConnectivity.MCSession, string, MultipeerConnectivity.MCPeerID, Foundation.NSProgress>> DidStartReceivingResourceObs { get { return _DidStartReceivingResource; } }
        public override void DidStartReceivingResource(MultipeerConnectivity.MCSession session, string resourceName, MultipeerConnectivity.MCPeerID fromPeer, Foundation.NSProgress progress)
        {
            _DidStartReceivingResource.OnNext(Tuple.Create(session, resourceName, fromPeer, progress));
        }

    }
}
namespace Foundation.Rx
{
    public  partial class NSCacheDelegateRx : NSCacheDelegate
    {
        readonly SingleAwaitSubject<Tuple<Foundation.NSCache, Foundation.NSObject>> _WillEvictObject = new SingleAwaitSubject<Tuple<Foundation.NSCache, Foundation.NSObject>>();
        public IObservable<Tuple<Foundation.NSCache, Foundation.NSObject>> WillEvictObjectObs { get { return _WillEvictObject; } }
        public override void WillEvictObject(Foundation.NSCache cache, Foundation.NSObject obj)
        {
            _WillEvictObject.OnNext(Tuple.Create(cache, obj));
        }

    }
    public  partial class NSKeyedArchiverDelegateRx : NSKeyedArchiverDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSKeyedArchiver> _Finished = new SingleAwaitSubject<Foundation.NSKeyedArchiver>();
        public IObservable<Foundation.NSKeyedArchiver> FinishedObs { get { return _Finished; } }
        public override void Finished(Foundation.NSKeyedArchiver archiver)
        {
            _Finished.OnNext(archiver);
        }

        readonly SingleAwaitSubject<Foundation.NSKeyedArchiver> _Finishing = new SingleAwaitSubject<Foundation.NSKeyedArchiver>();
        public IObservable<Foundation.NSKeyedArchiver> FinishingObs { get { return _Finishing; } }
        public override void Finishing(Foundation.NSKeyedArchiver archiver)
        {
            _Finishing.OnNext(archiver);
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSKeyedArchiver, Foundation.NSObject>> _EncodedObject = new SingleAwaitSubject<Tuple<Foundation.NSKeyedArchiver, Foundation.NSObject>>();
        public IObservable<Tuple<Foundation.NSKeyedArchiver, Foundation.NSObject>> EncodedObjectObs { get { return _EncodedObject; } }
        public override void EncodedObject(Foundation.NSKeyedArchiver archiver, Foundation.NSObject obj)
        {
            _EncodedObject.OnNext(Tuple.Create(archiver, obj));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSKeyedArchiver, Foundation.NSObject, Foundation.NSObject>> _ReplacingObject = new SingleAwaitSubject<Tuple<Foundation.NSKeyedArchiver, Foundation.NSObject, Foundation.NSObject>>();
        public IObservable<Tuple<Foundation.NSKeyedArchiver, Foundation.NSObject, Foundation.NSObject>> ReplacingObjectObs { get { return _ReplacingObject; } }
        public override void ReplacingObject(Foundation.NSKeyedArchiver archiver, Foundation.NSObject oldObject, Foundation.NSObject newObject)
        {
            _ReplacingObject.OnNext(Tuple.Create(archiver, oldObject, newObject));
        }

    }
    public  partial class NSKeyedUnarchiverDelegateRx : NSKeyedUnarchiverDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSKeyedUnarchiver> _Finished = new SingleAwaitSubject<Foundation.NSKeyedUnarchiver>();
        public IObservable<Foundation.NSKeyedUnarchiver> FinishedObs { get { return _Finished; } }
        public override void Finished(Foundation.NSKeyedUnarchiver unarchiver)
        {
            _Finished.OnNext(unarchiver);
        }

        readonly SingleAwaitSubject<Foundation.NSKeyedUnarchiver> _Finishing = new SingleAwaitSubject<Foundation.NSKeyedUnarchiver>();
        public IObservable<Foundation.NSKeyedUnarchiver> FinishingObs { get { return _Finishing; } }
        public override void Finishing(Foundation.NSKeyedUnarchiver unarchiver)
        {
            _Finishing.OnNext(unarchiver);
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSKeyedUnarchiver, Foundation.NSObject, Foundation.NSObject>> _ReplacingObject = new SingleAwaitSubject<Tuple<Foundation.NSKeyedUnarchiver, Foundation.NSObject, Foundation.NSObject>>();
        public IObservable<Tuple<Foundation.NSKeyedUnarchiver, Foundation.NSObject, Foundation.NSObject>> ReplacingObjectObs { get { return _ReplacingObject; } }
        public override void ReplacingObject(Foundation.NSKeyedUnarchiver unarchiver, Foundation.NSObject oldObject, Foundation.NSObject newObject)
        {
            _ReplacingObject.OnNext(Tuple.Create(unarchiver, oldObject, newObject));
        }

    }
    public  partial class NSMachPortDelegateRx : NSMachPortDelegate
    {
        readonly SingleAwaitSubject<System.IntPtr> _MachMessageReceived = new SingleAwaitSubject<System.IntPtr>();
        public IObservable<System.IntPtr> MachMessageReceivedObs { get { return _MachMessageReceived; } }
        public override void MachMessageReceived(System.IntPtr msgHeader)
        {
            _MachMessageReceived.OnNext(msgHeader);
        }

    }
    public  partial class NSNetServiceBrowserDelegateRx : NSNetServiceBrowserDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNetServiceBrowser> _SearchStarted = new SingleAwaitSubject<Foundation.NSNetServiceBrowser>();
        public IObservable<Foundation.NSNetServiceBrowser> SearchStartedObs { get { return _SearchStarted; } }
        public override void SearchStarted(Foundation.NSNetServiceBrowser sender)
        {
            _SearchStarted.OnNext(sender);
        }

        readonly SingleAwaitSubject<Foundation.NSNetServiceBrowser> _SearchStopped = new SingleAwaitSubject<Foundation.NSNetServiceBrowser>();
        public IObservable<Foundation.NSNetServiceBrowser> SearchStoppedObs { get { return _SearchStopped; } }
        public override void SearchStopped(Foundation.NSNetServiceBrowser sender)
        {
            _SearchStopped.OnNext(sender);
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSNetServiceBrowser, string, System.Boolean>> _DomainRemoved = new SingleAwaitSubject<Tuple<Foundation.NSNetServiceBrowser, string, System.Boolean>>();
        public IObservable<Tuple<Foundation.NSNetServiceBrowser, string, System.Boolean>> DomainRemovedObs { get { return _DomainRemoved; } }
        public override void DomainRemoved(Foundation.NSNetServiceBrowser sender, string domain, System.Boolean moreComing)
        {
            _DomainRemoved.OnNext(Tuple.Create(sender, domain, moreComing));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSNetServiceBrowser, string, System.Boolean>> _FoundDomain = new SingleAwaitSubject<Tuple<Foundation.NSNetServiceBrowser, string, System.Boolean>>();
        public IObservable<Tuple<Foundation.NSNetServiceBrowser, string, System.Boolean>> FoundDomainObs { get { return _FoundDomain; } }
        public override void FoundDomain(Foundation.NSNetServiceBrowser sender, string domain, System.Boolean moreComing)
        {
            _FoundDomain.OnNext(Tuple.Create(sender, domain, moreComing));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSNetServiceBrowser, Foundation.NSNetService, System.Boolean>> _FoundService = new SingleAwaitSubject<Tuple<Foundation.NSNetServiceBrowser, Foundation.NSNetService, System.Boolean>>();
        public IObservable<Tuple<Foundation.NSNetServiceBrowser, Foundation.NSNetService, System.Boolean>> FoundServiceObs { get { return _FoundService; } }
        public override void FoundService(Foundation.NSNetServiceBrowser sender, Foundation.NSNetService service, System.Boolean moreComing)
        {
            _FoundService.OnNext(Tuple.Create(sender, service, moreComing));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSNetServiceBrowser, Foundation.NSDictionary>> _NotSearched = new SingleAwaitSubject<Tuple<Foundation.NSNetServiceBrowser, Foundation.NSDictionary>>();
        public IObservable<Tuple<Foundation.NSNetServiceBrowser, Foundation.NSDictionary>> NotSearchedObs { get { return _NotSearched; } }
        public override void NotSearched(Foundation.NSNetServiceBrowser sender, Foundation.NSDictionary errors)
        {
            _NotSearched.OnNext(Tuple.Create(sender, errors));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSNetServiceBrowser, Foundation.NSNetService, System.Boolean>> _ServiceRemoved = new SingleAwaitSubject<Tuple<Foundation.NSNetServiceBrowser, Foundation.NSNetService, System.Boolean>>();
        public IObservable<Tuple<Foundation.NSNetServiceBrowser, Foundation.NSNetService, System.Boolean>> ServiceRemovedObs { get { return _ServiceRemoved; } }
        public override void ServiceRemoved(Foundation.NSNetServiceBrowser sender, Foundation.NSNetService service, System.Boolean moreComing)
        {
            _ServiceRemoved.OnNext(Tuple.Create(sender, service, moreComing));
        }

    }
    public  partial class NSNetServiceDelegateRx : NSNetServiceDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNetService> _AddressResolved = new SingleAwaitSubject<Foundation.NSNetService>();
        public IObservable<Foundation.NSNetService> AddressResolvedObs { get { return _AddressResolved; } }
        public override void AddressResolved(Foundation.NSNetService sender)
        {
            _AddressResolved.OnNext(sender);
        }

        readonly SingleAwaitSubject<Foundation.NSNetService> _Published = new SingleAwaitSubject<Foundation.NSNetService>();
        public IObservable<Foundation.NSNetService> PublishedObs { get { return _Published; } }
        public override void Published(Foundation.NSNetService sender)
        {
            _Published.OnNext(sender);
        }

        readonly SingleAwaitSubject<Foundation.NSNetService> _Stopped = new SingleAwaitSubject<Foundation.NSNetService>();
        public IObservable<Foundation.NSNetService> StoppedObs { get { return _Stopped; } }
        public override void Stopped(Foundation.NSNetService sender)
        {
            _Stopped.OnNext(sender);
        }

        readonly SingleAwaitSubject<Foundation.NSNetService> _WillPublish = new SingleAwaitSubject<Foundation.NSNetService>();
        public IObservable<Foundation.NSNetService> WillPublishObs { get { return _WillPublish; } }
        public override void WillPublish(Foundation.NSNetService sender)
        {
            _WillPublish.OnNext(sender);
        }

        readonly SingleAwaitSubject<Foundation.NSNetService> _WillResolve = new SingleAwaitSubject<Foundation.NSNetService>();
        public IObservable<Foundation.NSNetService> WillResolveObs { get { return _WillResolve; } }
        public override void WillResolve(Foundation.NSNetService sender)
        {
            _WillResolve.OnNext(sender);
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSNetService, Foundation.NSInputStream, Foundation.NSOutputStream>> _DidAcceptConnection = new SingleAwaitSubject<Tuple<Foundation.NSNetService, Foundation.NSInputStream, Foundation.NSOutputStream>>();
        public IObservable<Tuple<Foundation.NSNetService, Foundation.NSInputStream, Foundation.NSOutputStream>> DidAcceptConnectionObs { get { return _DidAcceptConnection; } }
        public override void DidAcceptConnection(Foundation.NSNetService sender, Foundation.NSInputStream inputStream, Foundation.NSOutputStream outputStream)
        {
            _DidAcceptConnection.OnNext(Tuple.Create(sender, inputStream, outputStream));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSNetService, Foundation.NSDictionary>> _PublishFailure = new SingleAwaitSubject<Tuple<Foundation.NSNetService, Foundation.NSDictionary>>();
        public IObservable<Tuple<Foundation.NSNetService, Foundation.NSDictionary>> PublishFailureObs { get { return _PublishFailure; } }
        public override void PublishFailure(Foundation.NSNetService sender, Foundation.NSDictionary errors)
        {
            _PublishFailure.OnNext(Tuple.Create(sender, errors));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSNetService, Foundation.NSDictionary>> _ResolveFailure = new SingleAwaitSubject<Tuple<Foundation.NSNetService, Foundation.NSDictionary>>();
        public IObservable<Tuple<Foundation.NSNetService, Foundation.NSDictionary>> ResolveFailureObs { get { return _ResolveFailure; } }
        public override void ResolveFailure(Foundation.NSNetService sender, Foundation.NSDictionary errors)
        {
            _ResolveFailure.OnNext(Tuple.Create(sender, errors));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSNetService, Foundation.NSData>> _UpdatedTxtRecordData = new SingleAwaitSubject<Tuple<Foundation.NSNetService, Foundation.NSData>>();
        public IObservable<Tuple<Foundation.NSNetService, Foundation.NSData>> UpdatedTxtRecordDataObs { get { return _UpdatedTxtRecordData; } }
        public override void UpdatedTxtRecordData(Foundation.NSNetService sender, Foundation.NSData data)
        {
            _UpdatedTxtRecordData.OnNext(Tuple.Create(sender, data));
        }

    }
    public  partial class NSPortDelegateRx : NSPortDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSPortMessage> _MessageReceived = new SingleAwaitSubject<Foundation.NSPortMessage>();
        public IObservable<Foundation.NSPortMessage> MessageReceivedObs { get { return _MessageReceived; } }
        public override void MessageReceived(Foundation.NSPortMessage message)
        {
            _MessageReceived.OnNext(message);
        }

    }
    public  partial class NSStreamDelegateRx : NSStreamDelegate
    {
        readonly SingleAwaitSubject<Tuple<Foundation.NSStream, Foundation.NSStreamEvent>> _HandleEvent = new SingleAwaitSubject<Tuple<Foundation.NSStream, Foundation.NSStreamEvent>>();
        public IObservable<Tuple<Foundation.NSStream, Foundation.NSStreamEvent>> HandleEventObs { get { return _HandleEvent; } }
        public override void HandleEvent(Foundation.NSStream theStream, Foundation.NSStreamEvent streamEvent)
        {
            _HandleEvent.OnNext(Tuple.Create(theStream, streamEvent));
        }

    }
    public  partial class NSUrlConnectionDataDelegateRx : NSUrlConnectionDataDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSUrlConnection> _FinishedLoading = new SingleAwaitSubject<Foundation.NSUrlConnection>();
        public IObservable<Foundation.NSUrlConnection> FinishedLoadingObs { get { return _FinishedLoading; } }
        public override void FinishedLoading(Foundation.NSUrlConnection connection)
        {
            _FinishedLoading.OnNext(connection);
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSData>> _ReceivedData = new SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSData>>();
        public IObservable<Tuple<Foundation.NSUrlConnection, Foundation.NSData>> ReceivedDataObs { get { return _ReceivedData; } }
        public override void ReceivedData(Foundation.NSUrlConnection connection, Foundation.NSData data)
        {
            _ReceivedData.OnNext(Tuple.Create(connection, data));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSUrlResponse>> _ReceivedResponse = new SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSUrlResponse>>();
        public IObservable<Tuple<Foundation.NSUrlConnection, Foundation.NSUrlResponse>> ReceivedResponseObs { get { return _ReceivedResponse; } }
        public override void ReceivedResponse(Foundation.NSUrlConnection connection, Foundation.NSUrlResponse response)
        {
            _ReceivedResponse.OnNext(Tuple.Create(connection, response));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, System.nint, System.nint, System.nint>> _SentBodyData = new SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, System.nint, System.nint, System.nint>>();
        public IObservable<Tuple<Foundation.NSUrlConnection, System.nint, System.nint, System.nint>> SentBodyDataObs { get { return _SentBodyData; } }
        public override void SentBodyData(Foundation.NSUrlConnection connection, System.nint bytesWritten, System.nint totalBytesWritten, System.nint totalBytesExpectedToWrite)
        {
            _SentBodyData.OnNext(Tuple.Create(connection, bytesWritten, totalBytesWritten, totalBytesExpectedToWrite));
        }

    }
    public  partial class NSUrlConnectionDelegateRx : NSUrlConnectionDelegate
    {
        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSUrlAuthenticationChallenge>> _CanceledAuthenticationChallenge = new SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSUrlAuthenticationChallenge>>();
        public IObservable<Tuple<Foundation.NSUrlConnection, Foundation.NSUrlAuthenticationChallenge>> CanceledAuthenticationChallengeObs { get { return _CanceledAuthenticationChallenge; } }
        public override void CanceledAuthenticationChallenge(Foundation.NSUrlConnection connection, Foundation.NSUrlAuthenticationChallenge challenge)
        {
            _CanceledAuthenticationChallenge.OnNext(Tuple.Create(connection, challenge));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSError>> _FailedWithError = new SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSError>>();
        public IObservable<Tuple<Foundation.NSUrlConnection, Foundation.NSError>> FailedWithErrorObs { get { return _FailedWithError; } }
        public override void FailedWithError(Foundation.NSUrlConnection connection, Foundation.NSError error)
        {
            _FailedWithError.OnNext(Tuple.Create(connection, error));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSUrlAuthenticationChallenge>> _ReceivedAuthenticationChallenge = new SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSUrlAuthenticationChallenge>>();
        public IObservable<Tuple<Foundation.NSUrlConnection, Foundation.NSUrlAuthenticationChallenge>> ReceivedAuthenticationChallengeObs { get { return _ReceivedAuthenticationChallenge; } }
        public override void ReceivedAuthenticationChallenge(Foundation.NSUrlConnection connection, Foundation.NSUrlAuthenticationChallenge challenge)
        {
            _ReceivedAuthenticationChallenge.OnNext(Tuple.Create(connection, challenge));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSUrlAuthenticationChallenge>> _WillSendRequestForAuthenticationChallenge = new SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSUrlAuthenticationChallenge>>();
        public IObservable<Tuple<Foundation.NSUrlConnection, Foundation.NSUrlAuthenticationChallenge>> WillSendRequestForAuthenticationChallengeObs { get { return _WillSendRequestForAuthenticationChallenge; } }
        public override void WillSendRequestForAuthenticationChallenge(Foundation.NSUrlConnection connection, Foundation.NSUrlAuthenticationChallenge challenge)
        {
            _WillSendRequestForAuthenticationChallenge.OnNext(Tuple.Create(connection, challenge));
        }

    }
    public abstract partial class NSUrlConnectionDownloadDelegateRx : NSUrlConnectionDownloadDelegate
    {
        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSUrl>> _FinishedDownloading = new SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, Foundation.NSUrl>>();
        public IObservable<Tuple<Foundation.NSUrlConnection, Foundation.NSUrl>> FinishedDownloadingObs { get { return _FinishedDownloading; } }
        public override void FinishedDownloading(Foundation.NSUrlConnection connection, Foundation.NSUrl destinationUrl)
        {
            _FinishedDownloading.OnNext(Tuple.Create(connection, destinationUrl));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, System.Int64, System.Int64>> _ResumedDownloading = new SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, System.Int64, System.Int64>>();
        public IObservable<Tuple<Foundation.NSUrlConnection, System.Int64, System.Int64>> ResumedDownloadingObs { get { return _ResumedDownloading; } }
        public override void ResumedDownloading(Foundation.NSUrlConnection connection, System.Int64 totalBytesWritten, System.Int64 expectedTotalBytes)
        {
            _ResumedDownloading.OnNext(Tuple.Create(connection, totalBytesWritten, expectedTotalBytes));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, System.Int64, System.Int64, System.Int64>> _WroteData = new SingleAwaitSubject<Tuple<Foundation.NSUrlConnection, System.Int64, System.Int64, System.Int64>>();
        public IObservable<Tuple<Foundation.NSUrlConnection, System.Int64, System.Int64, System.Int64>> WroteDataObs { get { return _WroteData; } }
        public override void WroteData(Foundation.NSUrlConnection connection, System.Int64 bytesWritten, System.Int64 totalBytesWritten, System.Int64 expectedTotalBytes)
        {
            _WroteData.OnNext(Tuple.Create(connection, bytesWritten, totalBytesWritten, expectedTotalBytes));
        }

    }
    public  partial class NSUrlSessionDataDelegateRx : NSUrlSessionDataDelegate
    {
        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSUrlSessionDownloadTask>> _DidBecomeDownloadTask = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSUrlSessionDownloadTask>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSUrlSessionDownloadTask>> DidBecomeDownloadTaskObs { get { return _DidBecomeDownloadTask; } }
        public override void DidBecomeDownloadTask(Foundation.NSUrlSession session, Foundation.NSUrlSessionDataTask dataTask, Foundation.NSUrlSessionDownloadTask downloadTask)
        {
            _DidBecomeDownloadTask.OnNext(Tuple.Create(session, dataTask, downloadTask));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSUrlSessionStreamTask>> _DidBecomeStreamTask = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSUrlSessionStreamTask>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSUrlSessionStreamTask>> DidBecomeStreamTaskObs { get { return _DidBecomeStreamTask; } }
        public override void DidBecomeStreamTask(Foundation.NSUrlSession session, Foundation.NSUrlSessionDataTask dataTask, Foundation.NSUrlSessionStreamTask streamTask)
        {
            _DidBecomeStreamTask.OnNext(Tuple.Create(session, dataTask, streamTask));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSData>> _DidReceiveData = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSData>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSData>> DidReceiveDataObs { get { return _DidReceiveData; } }
        public override void DidReceiveData(Foundation.NSUrlSession session, Foundation.NSUrlSessionDataTask dataTask, Foundation.NSData data)
        {
            _DidReceiveData.OnNext(Tuple.Create(session, dataTask, data));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSUrlResponse, System.Action<Foundation.NSUrlSessionResponseDisposition>>> _DidReceiveResponse = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSUrlResponse, System.Action<Foundation.NSUrlSessionResponseDisposition>>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSUrlResponse, System.Action<Foundation.NSUrlSessionResponseDisposition>>> DidReceiveResponseObs { get { return _DidReceiveResponse; } }
        public override void DidReceiveResponse(Foundation.NSUrlSession session, Foundation.NSUrlSessionDataTask dataTask, Foundation.NSUrlResponse response, System.Action<Foundation.NSUrlSessionResponseDisposition> completionHandler)
        {
            _DidReceiveResponse.OnNext(Tuple.Create(session, dataTask, response, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSCachedUrlResponse, System.Action<Foundation.NSCachedUrlResponse>>> _WillCacheResponse = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSCachedUrlResponse, System.Action<Foundation.NSCachedUrlResponse>>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDataTask, Foundation.NSCachedUrlResponse, System.Action<Foundation.NSCachedUrlResponse>>> WillCacheResponseObs { get { return _WillCacheResponse; } }
        public override void WillCacheResponse(Foundation.NSUrlSession session, Foundation.NSUrlSessionDataTask dataTask, Foundation.NSCachedUrlResponse proposedResponse, System.Action<Foundation.NSCachedUrlResponse> completionHandler)
        {
            _WillCacheResponse.OnNext(Tuple.Create(session, dataTask, proposedResponse, completionHandler));
        }

    }
    public  partial class NSUrlSessionDelegateRx : NSUrlSessionDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSUrlSession> _DidFinishEventsForBackgroundSession = new SingleAwaitSubject<Foundation.NSUrlSession>();
        public IObservable<Foundation.NSUrlSession> DidFinishEventsForBackgroundSessionObs { get { return _DidFinishEventsForBackgroundSession; } }
        public override void DidFinishEventsForBackgroundSession(Foundation.NSUrlSession session)
        {
            _DidFinishEventsForBackgroundSession.OnNext(session);
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSError>> _DidBecomeInvalid = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSError>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSError>> DidBecomeInvalidObs { get { return _DidBecomeInvalid; } }
        public override void DidBecomeInvalid(Foundation.NSUrlSession session, Foundation.NSError error)
        {
            _DidBecomeInvalid.OnNext(Tuple.Create(session, error));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlAuthenticationChallenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential>>> _DidReceiveChallenge = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlAuthenticationChallenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential>>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlAuthenticationChallenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential>>> DidReceiveChallengeObs { get { return _DidReceiveChallenge; } }
        public override void DidReceiveChallenge(Foundation.NSUrlSession session, Foundation.NSUrlAuthenticationChallenge challenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential> completionHandler)
        {
            _DidReceiveChallenge.OnNext(Tuple.Create(session, challenge, completionHandler));
        }

    }
    public abstract partial class NSUrlSessionDownloadDelegateRx : NSUrlSessionDownloadDelegate
    {
        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDownloadTask, Foundation.NSUrl>> _DidFinishDownloading = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDownloadTask, Foundation.NSUrl>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDownloadTask, Foundation.NSUrl>> DidFinishDownloadingObs { get { return _DidFinishDownloading; } }
        public override void DidFinishDownloading(Foundation.NSUrlSession session, Foundation.NSUrlSessionDownloadTask downloadTask, Foundation.NSUrl location)
        {
            _DidFinishDownloading.OnNext(Tuple.Create(session, downloadTask, location));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDownloadTask, System.Int64, System.Int64>> _DidResume = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDownloadTask, System.Int64, System.Int64>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDownloadTask, System.Int64, System.Int64>> DidResumeObs { get { return _DidResume; } }
        public override void DidResume(Foundation.NSUrlSession session, Foundation.NSUrlSessionDownloadTask downloadTask, System.Int64 resumeFileOffset, System.Int64 expectedTotalBytes)
        {
            _DidResume.OnNext(Tuple.Create(session, downloadTask, resumeFileOffset, expectedTotalBytes));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDownloadTask, System.Int64, System.Int64, System.Int64>> _DidWriteData = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDownloadTask, System.Int64, System.Int64, System.Int64>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionDownloadTask, System.Int64, System.Int64, System.Int64>> DidWriteDataObs { get { return _DidWriteData; } }
        public override void DidWriteData(Foundation.NSUrlSession session, Foundation.NSUrlSessionDownloadTask downloadTask, System.Int64 bytesWritten, System.Int64 totalBytesWritten, System.Int64 totalBytesExpectedToWrite)
        {
            _DidWriteData.OnNext(Tuple.Create(session, downloadTask, bytesWritten, totalBytesWritten, totalBytesExpectedToWrite));
        }

    }
    public  partial class NSUrlSessionStreamDelegateRx : NSUrlSessionStreamDelegate
    {
        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionStreamTask>> _BetterRouteDiscovered = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionStreamTask>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionStreamTask>> BetterRouteDiscoveredObs { get { return _BetterRouteDiscovered; } }
        public override void BetterRouteDiscovered(Foundation.NSUrlSession session, Foundation.NSUrlSessionStreamTask streamTask)
        {
            _BetterRouteDiscovered.OnNext(Tuple.Create(session, streamTask));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionStreamTask, Foundation.NSInputStream, Foundation.NSOutputStream>> _CompletedTaskCaptureStreams = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionStreamTask, Foundation.NSInputStream, Foundation.NSOutputStream>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionStreamTask, Foundation.NSInputStream, Foundation.NSOutputStream>> CompletedTaskCaptureStreamsObs { get { return _CompletedTaskCaptureStreams; } }
        public override void CompletedTaskCaptureStreams(Foundation.NSUrlSession session, Foundation.NSUrlSessionStreamTask streamTask, Foundation.NSInputStream inputStream, Foundation.NSOutputStream outputStream)
        {
            _CompletedTaskCaptureStreams.OnNext(Tuple.Create(session, streamTask, inputStream, outputStream));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionStreamTask>> _ReadClosed = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionStreamTask>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionStreamTask>> ReadClosedObs { get { return _ReadClosed; } }
        public override void ReadClosed(Foundation.NSUrlSession session, Foundation.NSUrlSessionStreamTask streamTask)
        {
            _ReadClosed.OnNext(Tuple.Create(session, streamTask));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionStreamTask>> _WriteClosed = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionStreamTask>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionStreamTask>> WriteClosedObs { get { return _WriteClosed; } }
        public override void WriteClosed(Foundation.NSUrlSession session, Foundation.NSUrlSessionStreamTask streamTask)
        {
            _WriteClosed.OnNext(Tuple.Create(session, streamTask));
        }

    }
    public  partial class NSUrlDownloadDelegateRx : NSUrlDownloadDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSUrlDownload> _DownloadBegan = new SingleAwaitSubject<Foundation.NSUrlDownload>();
        public IObservable<Foundation.NSUrlDownload> DownloadBeganObs { get { return _DownloadBegan; } }
        public override void DownloadBegan(Foundation.NSUrlDownload download)
        {
            _DownloadBegan.OnNext(download);
        }

        readonly SingleAwaitSubject<Foundation.NSUrlDownload> _Finished = new SingleAwaitSubject<Foundation.NSUrlDownload>();
        public IObservable<Foundation.NSUrlDownload> FinishedObs { get { return _Finished; } }
        public override void Finished(Foundation.NSUrlDownload download)
        {
            _Finished.OnNext(download);
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, Foundation.NSUrlAuthenticationChallenge>> _CanceledAuthenticationChallenge = new SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, Foundation.NSUrlAuthenticationChallenge>>();
        public IObservable<Tuple<Foundation.NSUrlDownload, Foundation.NSUrlAuthenticationChallenge>> CanceledAuthenticationChallengeObs { get { return _CanceledAuthenticationChallenge; } }
        public override void CanceledAuthenticationChallenge(Foundation.NSUrlDownload download, Foundation.NSUrlAuthenticationChallenge challenge)
        {
            _CanceledAuthenticationChallenge.OnNext(Tuple.Create(download, challenge));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, string>> _CreatedDestination = new SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, string>>();
        public IObservable<Tuple<Foundation.NSUrlDownload, string>> CreatedDestinationObs { get { return _CreatedDestination; } }
        public override void CreatedDestination(Foundation.NSUrlDownload download, string path)
        {
            _CreatedDestination.OnNext(Tuple.Create(download, path));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, string>> _DecideDestination = new SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, string>>();
        public IObservable<Tuple<Foundation.NSUrlDownload, string>> DecideDestinationObs { get { return _DecideDestination; } }
        public override void DecideDestination(Foundation.NSUrlDownload download, string suggestedFilename)
        {
            _DecideDestination.OnNext(Tuple.Create(download, suggestedFilename));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, Foundation.NSError>> _FailedWithError = new SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, Foundation.NSError>>();
        public IObservable<Tuple<Foundation.NSUrlDownload, Foundation.NSError>> FailedWithErrorObs { get { return _FailedWithError; } }
        public override void FailedWithError(Foundation.NSUrlDownload download, Foundation.NSError error)
        {
            _FailedWithError.OnNext(Tuple.Create(download, error));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, Foundation.NSUrlAuthenticationChallenge>> _ReceivedAuthenticationChallenge = new SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, Foundation.NSUrlAuthenticationChallenge>>();
        public IObservable<Tuple<Foundation.NSUrlDownload, Foundation.NSUrlAuthenticationChallenge>> ReceivedAuthenticationChallengeObs { get { return _ReceivedAuthenticationChallenge; } }
        public override void ReceivedAuthenticationChallenge(Foundation.NSUrlDownload download, Foundation.NSUrlAuthenticationChallenge challenge)
        {
            _ReceivedAuthenticationChallenge.OnNext(Tuple.Create(download, challenge));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, System.nuint>> _ReceivedData = new SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, System.nuint>>();
        public IObservable<Tuple<Foundation.NSUrlDownload, System.nuint>> ReceivedDataObs { get { return _ReceivedData; } }
        public override void ReceivedData(Foundation.NSUrlDownload download, System.nuint length)
        {
            _ReceivedData.OnNext(Tuple.Create(download, length));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, Foundation.NSUrlResponse>> _ReceivedResponse = new SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, Foundation.NSUrlResponse>>();
        public IObservable<Tuple<Foundation.NSUrlDownload, Foundation.NSUrlResponse>> ReceivedResponseObs { get { return _ReceivedResponse; } }
        public override void ReceivedResponse(Foundation.NSUrlDownload download, Foundation.NSUrlResponse response)
        {
            _ReceivedResponse.OnNext(Tuple.Create(download, response));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, Foundation.NSUrlResponse, System.Int64>> _Resume = new SingleAwaitSubject<Tuple<Foundation.NSUrlDownload, Foundation.NSUrlResponse, System.Int64>>();
        public IObservable<Tuple<Foundation.NSUrlDownload, Foundation.NSUrlResponse, System.Int64>> ResumeObs { get { return _Resume; } }
        public override void Resume(Foundation.NSUrlDownload download, Foundation.NSUrlResponse response, System.Int64 startingByte)
        {
            _Resume.OnNext(Tuple.Create(download, response, startingByte));
        }

    }
    public  partial class NSUserActivityDelegateRx : NSUserActivityDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSUserActivity> _UserActivityWasContinued = new SingleAwaitSubject<Foundation.NSUserActivity>();
        public IObservable<Foundation.NSUserActivity> UserActivityWasContinuedObs { get { return _UserActivityWasContinued; } }
        public override void UserActivityWasContinued(Foundation.NSUserActivity userActivity)
        {
            _UserActivityWasContinued.OnNext(userActivity);
        }

        readonly SingleAwaitSubject<Foundation.NSUserActivity> _UserActivityWillSave = new SingleAwaitSubject<Foundation.NSUserActivity>();
        public IObservable<Foundation.NSUserActivity> UserActivityWillSaveObs { get { return _UserActivityWillSave; } }
        public override void UserActivityWillSave(Foundation.NSUserActivity userActivity)
        {
            _UserActivityWillSave.OnNext(userActivity);
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUserActivity, Foundation.NSInputStream, Foundation.NSOutputStream>> _UserActivityReceivedData = new SingleAwaitSubject<Tuple<Foundation.NSUserActivity, Foundation.NSInputStream, Foundation.NSOutputStream>>();
        public IObservable<Tuple<Foundation.NSUserActivity, Foundation.NSInputStream, Foundation.NSOutputStream>> UserActivityReceivedDataObs { get { return _UserActivityReceivedData; } }
        public override void UserActivityReceivedData(Foundation.NSUserActivity userActivity, Foundation.NSInputStream inputStream, Foundation.NSOutputStream outputStream)
        {
            _UserActivityReceivedData.OnNext(Tuple.Create(userActivity, inputStream, outputStream));
        }

    }
    public  partial class NSUrlSessionTaskDelegateRx : NSUrlSessionTaskDelegate
    {
        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSError>> _DidCompleteWithError = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSError>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSError>> DidCompleteWithErrorObs { get { return _DidCompleteWithError; } }
        public override void DidCompleteWithError(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task, Foundation.NSError error)
        {
            _DidCompleteWithError.OnNext(Tuple.Create(session, task, error));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSUrlSessionTaskMetrics>> _DidFinishCollectingMetrics = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSUrlSessionTaskMetrics>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSUrlSessionTaskMetrics>> DidFinishCollectingMetricsObs { get { return _DidFinishCollectingMetrics; } }
        public override void DidFinishCollectingMetrics(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task, Foundation.NSUrlSessionTaskMetrics metrics)
        {
            _DidFinishCollectingMetrics.OnNext(Tuple.Create(session, task, metrics));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSUrlAuthenticationChallenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential>>> _DidReceiveChallenge = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSUrlAuthenticationChallenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential>>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSUrlAuthenticationChallenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential>>> DidReceiveChallengeObs { get { return _DidReceiveChallenge; } }
        public override void DidReceiveChallenge(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task, Foundation.NSUrlAuthenticationChallenge challenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential> completionHandler)
        {
            _DidReceiveChallenge.OnNext(Tuple.Create(session, task, challenge, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, System.Int64, System.Int64, System.Int64>> _DidSendBodyData = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, System.Int64, System.Int64, System.Int64>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, System.Int64, System.Int64, System.Int64>> DidSendBodyDataObs { get { return _DidSendBodyData; } }
        public override void DidSendBodyData(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task, System.Int64 bytesSent, System.Int64 totalBytesSent, System.Int64 totalBytesExpectedToSend)
        {
            _DidSendBodyData.OnNext(Tuple.Create(session, task, bytesSent, totalBytesSent, totalBytesExpectedToSend));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, System.Action<Foundation.NSInputStream>>> _NeedNewBodyStream = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, System.Action<Foundation.NSInputStream>>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, System.Action<Foundation.NSInputStream>>> NeedNewBodyStreamObs { get { return _NeedNewBodyStream; } }
        public override void NeedNewBodyStream(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task, System.Action<Foundation.NSInputStream> completionHandler)
        {
            _NeedNewBodyStream.OnNext(Tuple.Create(session, task, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSHttpUrlResponse, Foundation.NSUrlRequest, System.Action<Foundation.NSUrlRequest>>> _WillPerformHttpRedirection = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSHttpUrlResponse, Foundation.NSUrlRequest, System.Action<Foundation.NSUrlRequest>>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSHttpUrlResponse, Foundation.NSUrlRequest, System.Action<Foundation.NSUrlRequest>>> WillPerformHttpRedirectionObs { get { return _WillPerformHttpRedirection; } }
        public override void WillPerformHttpRedirection(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task, Foundation.NSHttpUrlResponse response, Foundation.NSUrlRequest newRequest, System.Action<Foundation.NSUrlRequest> completionHandler)
        {
            _WillPerformHttpRedirection.OnNext(Tuple.Create(session, task, response, newRequest, completionHandler));
        }

    }
    public  partial class NSUserNotificationCenterDelegateRx : NSUserNotificationCenterDelegate
    {
        readonly SingleAwaitSubject<Tuple<Foundation.NSUserNotificationCenter, Foundation.NSUserNotification>> _DidActivateNotification = new SingleAwaitSubject<Tuple<Foundation.NSUserNotificationCenter, Foundation.NSUserNotification>>();
        public IObservable<Tuple<Foundation.NSUserNotificationCenter, Foundation.NSUserNotification>> DidActivateNotificationObs { get { return _DidActivateNotification; } }
        public override void DidActivateNotification(Foundation.NSUserNotificationCenter center, Foundation.NSUserNotification notification)
        {
            _DidActivateNotification.OnNext(Tuple.Create(center, notification));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUserNotificationCenter, Foundation.NSUserNotification>> _DidDeliverNotification = new SingleAwaitSubject<Tuple<Foundation.NSUserNotificationCenter, Foundation.NSUserNotification>>();
        public IObservable<Tuple<Foundation.NSUserNotificationCenter, Foundation.NSUserNotification>> DidDeliverNotificationObs { get { return _DidDeliverNotification; } }
        public override void DidDeliverNotification(Foundation.NSUserNotificationCenter center, Foundation.NSUserNotification notification)
        {
            _DidDeliverNotification.OnNext(Tuple.Create(center, notification));
        }

    }
}
namespace CoreAnimation.Rx
{
    public  partial class CALayerDelegateRx : CALayerDelegate
    {
        readonly SingleAwaitSubject<CoreAnimation.CALayer> _DisplayLayer = new SingleAwaitSubject<CoreAnimation.CALayer>();
        public IObservable<CoreAnimation.CALayer> DisplayLayerObs { get { return _DisplayLayer; } }
        public override void DisplayLayer(CoreAnimation.CALayer layer)
        {
            _DisplayLayer.OnNext(layer);
        }

        readonly SingleAwaitSubject<CoreAnimation.CALayer> _LayoutSublayersOfLayer = new SingleAwaitSubject<CoreAnimation.CALayer>();
        public IObservable<CoreAnimation.CALayer> LayoutSublayersOfLayerObs { get { return _LayoutSublayersOfLayer; } }
        public override void LayoutSublayersOfLayer(CoreAnimation.CALayer layer)
        {
            _LayoutSublayersOfLayer.OnNext(layer);
        }

        readonly SingleAwaitSubject<CoreAnimation.CALayer> _WillDrawLayer = new SingleAwaitSubject<CoreAnimation.CALayer>();
        public IObservable<CoreAnimation.CALayer> WillDrawLayerObs { get { return _WillDrawLayer; } }
        public override void WillDrawLayer(CoreAnimation.CALayer layer)
        {
            _WillDrawLayer.OnNext(layer);
        }

        readonly SingleAwaitSubject<Tuple<CoreAnimation.CALayer, CoreGraphics.CGContext>> _DrawLayer = new SingleAwaitSubject<Tuple<CoreAnimation.CALayer, CoreGraphics.CGContext>>();
        public IObservable<Tuple<CoreAnimation.CALayer, CoreGraphics.CGContext>> DrawLayerObs { get { return _DrawLayer; } }
        public override void DrawLayer(CoreAnimation.CALayer layer, CoreGraphics.CGContext context)
        {
            _DrawLayer.OnNext(Tuple.Create(layer, context));
        }

    }
    public  partial class CAAnimationDelegateRx : CAAnimationDelegate
    {
        readonly SingleAwaitSubject<CoreAnimation.CAAnimation> _AnimationStarted = new SingleAwaitSubject<CoreAnimation.CAAnimation>();
        public IObservable<CoreAnimation.CAAnimation> AnimationStartedObs { get { return _AnimationStarted; } }
        public override void AnimationStarted(CoreAnimation.CAAnimation anim)
        {
            _AnimationStarted.OnNext(anim);
        }

        readonly SingleAwaitSubject<Tuple<CoreAnimation.CAAnimation, System.Boolean>> _AnimationStopped = new SingleAwaitSubject<Tuple<CoreAnimation.CAAnimation, System.Boolean>>();
        public IObservable<Tuple<CoreAnimation.CAAnimation, System.Boolean>> AnimationStoppedObs { get { return _AnimationStopped; } }
        public override void AnimationStopped(CoreAnimation.CAAnimation anim, System.Boolean finished)
        {
            _AnimationStopped.OnNext(Tuple.Create(anim, finished));
        }

    }
}
namespace NetworkExtension.Rx
{
    public  partial class NWTcpConnectionAuthenticationDelegateRx : NWTcpConnectionAuthenticationDelegate
    {
        readonly SingleAwaitSubject<Tuple<NetworkExtension.NWTcpConnection, Foundation.NSArray, System.Action<Security.SecTrust>>> _EvaluateTrust = new SingleAwaitSubject<Tuple<NetworkExtension.NWTcpConnection, Foundation.NSArray, System.Action<Security.SecTrust>>>();
        public IObservable<Tuple<NetworkExtension.NWTcpConnection, Foundation.NSArray, System.Action<Security.SecTrust>>> EvaluateTrustObs { get { return _EvaluateTrust; } }
        public override void EvaluateTrust(NetworkExtension.NWTcpConnection connection, Foundation.NSArray peerCertificateChain, System.Action<Security.SecTrust> completion)
        {
            _EvaluateTrust.OnNext(Tuple.Create(connection, peerCertificateChain, completion));
        }

        readonly SingleAwaitSubject<Tuple<NetworkExtension.NWTcpConnection, System.Action<Security.SecIdentity,Foundation.NSArray>>> _ProvideIdentity = new SingleAwaitSubject<Tuple<NetworkExtension.NWTcpConnection, System.Action<Security.SecIdentity,Foundation.NSArray>>>();
        public IObservable<Tuple<NetworkExtension.NWTcpConnection, System.Action<Security.SecIdentity,Foundation.NSArray>>> ProvideIdentityObs { get { return _ProvideIdentity; } }
        public override void ProvideIdentity(NetworkExtension.NWTcpConnection connection, System.Action<Security.SecIdentity,Foundation.NSArray> completion)
        {
            _ProvideIdentity.OnNext(Tuple.Create(connection, completion));
        }

    }
}
namespace NotificationCenter.Rx
{
    public abstract partial class NCWidgetListViewDelegateRx : NCWidgetListViewDelegate
    {
        readonly SingleAwaitSubject<NotificationCenter.NCWidgetListViewController> _PerformAddAction = new SingleAwaitSubject<NotificationCenter.NCWidgetListViewController>();
        public IObservable<NotificationCenter.NCWidgetListViewController> PerformAddActionObs { get { return _PerformAddAction; } }
        public override void PerformAddAction(NotificationCenter.NCWidgetListViewController list)
        {
            _PerformAddAction.OnNext(list);
        }

        readonly SingleAwaitSubject<Tuple<NotificationCenter.NCWidgetListViewController, System.nuint>> _DidRemoveRow = new SingleAwaitSubject<Tuple<NotificationCenter.NCWidgetListViewController, System.nuint>>();
        public IObservable<Tuple<NotificationCenter.NCWidgetListViewController, System.nuint>> DidRemoveRowObs { get { return _DidRemoveRow; } }
        public override void DidRemoveRow(NotificationCenter.NCWidgetListViewController list, System.nuint row)
        {
            _DidRemoveRow.OnNext(Tuple.Create(list, row));
        }

        readonly SingleAwaitSubject<Tuple<NotificationCenter.NCWidgetListViewController, System.nuint, System.nuint>> _DidReorderRow = new SingleAwaitSubject<Tuple<NotificationCenter.NCWidgetListViewController, System.nuint, System.nuint>>();
        public IObservable<Tuple<NotificationCenter.NCWidgetListViewController, System.nuint, System.nuint>> DidReorderRowObs { get { return _DidReorderRow; } }
        public override void DidReorderRow(NotificationCenter.NCWidgetListViewController list, System.nuint row, System.nuint newIndex)
        {
            _DidReorderRow.OnNext(Tuple.Create(list, row, newIndex));
        }

    }
    public abstract partial class NCWidgetSearchViewDelegateRx : NCWidgetSearchViewDelegate
    {
        readonly SingleAwaitSubject<NotificationCenter.NCWidgetSearchViewController> _TermCleared = new SingleAwaitSubject<NotificationCenter.NCWidgetSearchViewController>();
        public IObservable<NotificationCenter.NCWidgetSearchViewController> TermClearedObs { get { return _TermCleared; } }
        public override void TermCleared(NotificationCenter.NCWidgetSearchViewController controller)
        {
            _TermCleared.OnNext(controller);
        }

        readonly SingleAwaitSubject<Tuple<NotificationCenter.NCWidgetSearchViewController, Foundation.NSObject>> _ResultSelected = new SingleAwaitSubject<Tuple<NotificationCenter.NCWidgetSearchViewController, Foundation.NSObject>>();
        public IObservable<Tuple<NotificationCenter.NCWidgetSearchViewController, Foundation.NSObject>> ResultSelectedObs { get { return _ResultSelected; } }
        public override void ResultSelected(NotificationCenter.NCWidgetSearchViewController controller, Foundation.NSObject obj)
        {
            _ResultSelected.OnNext(Tuple.Create(controller, obj));
        }

        readonly SingleAwaitSubject<Tuple<NotificationCenter.NCWidgetSearchViewController, string, System.nuint>> _SearchForTearm = new SingleAwaitSubject<Tuple<NotificationCenter.NCWidgetSearchViewController, string, System.nuint>>();
        public IObservable<Tuple<NotificationCenter.NCWidgetSearchViewController, string, System.nuint>> SearchForTearmObs { get { return _SearchForTearm; } }
        public override void SearchForTearm(NotificationCenter.NCWidgetSearchViewController controller, string searchTerm, System.nuint max)
        {
            _SearchForTearm.OnNext(Tuple.Create(controller, searchTerm, max));
        }

    }
}
namespace PdfKit.Rx
{
    public  partial class PdfDocumentDelegateRx : PdfDocumentDelegate
    {
        readonly SingleAwaitSubject<PdfKit.PdfSelection> _DidMatchString = new SingleAwaitSubject<PdfKit.PdfSelection>();
        public IObservable<PdfKit.PdfSelection> DidMatchStringObs { get { return _DidMatchString; } }
        public override void DidMatchString(PdfKit.PdfSelection sender)
        {
            _DidMatchString.OnNext(sender);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _FindFinished = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> FindFinishedObs { get { return _FindFinished; } }
        public override void FindFinished(Foundation.NSNotification notification)
        {
            _FindFinished.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _MatchFound = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> MatchFoundObs { get { return _MatchFound; } }
        public override void MatchFound(Foundation.NSNotification notification)
        {
            _MatchFound.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _PageFindFinished = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> PageFindFinishedObs { get { return _PageFindFinished; } }
        public override void PageFindFinished(Foundation.NSNotification notification)
        {
            _PageFindFinished.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _PageFindStarted = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> PageFindStartedObs { get { return _PageFindStarted; } }
        public override void PageFindStarted(Foundation.NSNotification notification)
        {
            _PageFindStarted.OnNext(notification);
        }

    }
    public  partial class PdfViewDelegateRx : PdfViewDelegate
    {
        readonly SingleAwaitSubject<PdfKit.PdfView> _PerformFind = new SingleAwaitSubject<PdfKit.PdfView>();
        public IObservable<PdfKit.PdfView> PerformFindObs { get { return _PerformFind; } }
        public override void PerformFind(PdfKit.PdfView sender)
        {
            _PerformFind.OnNext(sender);
        }

        readonly SingleAwaitSubject<PdfKit.PdfView> _PerformGoToPage = new SingleAwaitSubject<PdfKit.PdfView>();
        public IObservable<PdfKit.PdfView> PerformGoToPageObs { get { return _PerformGoToPage; } }
        public override void PerformGoToPage(PdfKit.PdfView sender)
        {
            _PerformGoToPage.OnNext(sender);
        }

        readonly SingleAwaitSubject<PdfKit.PdfView> _PerformPrint = new SingleAwaitSubject<PdfKit.PdfView>();
        public IObservable<PdfKit.PdfView> PerformPrintObs { get { return _PerformPrint; } }
        public override void PerformPrint(PdfKit.PdfView sender)
        {
            _PerformPrint.OnNext(sender);
        }

        readonly SingleAwaitSubject<Tuple<PdfKit.PdfView, PdfKit.PdfActionRemoteGoTo>> _OpenPdf = new SingleAwaitSubject<Tuple<PdfKit.PdfView, PdfKit.PdfActionRemoteGoTo>>();
        public IObservable<Tuple<PdfKit.PdfView, PdfKit.PdfActionRemoteGoTo>> OpenPdfObs { get { return _OpenPdf; } }
        public override void OpenPdf(PdfKit.PdfView sender, PdfKit.PdfActionRemoteGoTo action)
        {
            _OpenPdf.OnNext(Tuple.Create(sender, action));
        }

        readonly SingleAwaitSubject<Tuple<PdfKit.PdfView, Foundation.NSUrl>> _WillClickOnLink = new SingleAwaitSubject<Tuple<PdfKit.PdfView, Foundation.NSUrl>>();
        public IObservable<Tuple<PdfKit.PdfView, Foundation.NSUrl>> WillClickOnLinkObs { get { return _WillClickOnLink; } }
        public override void WillClickOnLink(PdfKit.PdfView sender, Foundation.NSUrl url)
        {
            _WillClickOnLink.OnNext(Tuple.Create(sender, url));
        }

    }
}
namespace QTKit.Rx
{
    public  partial class QTCaptureDecompressedVideoOutputDelegateRx : QTCaptureDecompressedVideoOutputDelegate
    {
        readonly SingleAwaitSubject<Tuple<QTKit.QTCaptureOutput, QTKit.QTSampleBuffer, QTKit.QTCaptureConnection>> _DidDropVideoFrame = new SingleAwaitSubject<Tuple<QTKit.QTCaptureOutput, QTKit.QTSampleBuffer, QTKit.QTCaptureConnection>>();
        public IObservable<Tuple<QTKit.QTCaptureOutput, QTKit.QTSampleBuffer, QTKit.QTCaptureConnection>> DidDropVideoFrameObs { get { return _DidDropVideoFrame; } }
        public override void DidDropVideoFrame(QTKit.QTCaptureOutput captureOutput, QTKit.QTSampleBuffer sampleBuffer, QTKit.QTCaptureConnection connection)
        {
            _DidDropVideoFrame.OnNext(Tuple.Create(captureOutput, sampleBuffer, connection));
        }

        readonly SingleAwaitSubject<Tuple<QTKit.QTCaptureOutput, CoreVideo.CVImageBuffer, QTKit.QTSampleBuffer, QTKit.QTCaptureConnection>> _DidOutputVideoFrame = new SingleAwaitSubject<Tuple<QTKit.QTCaptureOutput, CoreVideo.CVImageBuffer, QTKit.QTSampleBuffer, QTKit.QTCaptureConnection>>();
        public IObservable<Tuple<QTKit.QTCaptureOutput, CoreVideo.CVImageBuffer, QTKit.QTSampleBuffer, QTKit.QTCaptureConnection>> DidOutputVideoFrameObs { get { return _DidOutputVideoFrame; } }
        public override void DidOutputVideoFrame(QTKit.QTCaptureOutput captureOutput, CoreVideo.CVImageBuffer videoFrame, QTKit.QTSampleBuffer sampleBuffer, QTKit.QTCaptureConnection connection)
        {
            _DidOutputVideoFrame.OnNext(Tuple.Create(captureOutput, videoFrame, sampleBuffer, connection));
        }

    }
    public  partial class QTCaptureFileOutputDelegateRx : QTCaptureFileOutputDelegate
    {
        readonly SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[], Foundation.NSError>> _DidFinishRecording = new SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[], Foundation.NSError>>();
        public IObservable<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[], Foundation.NSError>> DidFinishRecordingObs { get { return _DidFinishRecording; } }
        public override void DidFinishRecording(QTKit.QTCaptureFileOutput captureOutput, Foundation.NSUrl outputFileURL, QTKit.QTCaptureConnection[] connections, Foundation.NSError reason)
        {
            _DidFinishRecording.OnNext(Tuple.Create(captureOutput, outputFileURL, connections, reason));
        }

        readonly SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, QTKit.QTSampleBuffer, QTKit.QTCaptureConnection>> _DidOutputSampleBuffer = new SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, QTKit.QTSampleBuffer, QTKit.QTCaptureConnection>>();
        public IObservable<Tuple<QTKit.QTCaptureFileOutput, QTKit.QTSampleBuffer, QTKit.QTCaptureConnection>> DidOutputSampleBufferObs { get { return _DidOutputSampleBuffer; } }
        public override void DidOutputSampleBuffer(QTKit.QTCaptureFileOutput captureOutput, QTKit.QTSampleBuffer sampleBuffer, QTKit.QTCaptureConnection connection)
        {
            _DidOutputSampleBuffer.OnNext(Tuple.Create(captureOutput, sampleBuffer, connection));
        }

        readonly SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[]>> _DidPauseRecording = new SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[]>>();
        public IObservable<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[]>> DidPauseRecordingObs { get { return _DidPauseRecording; } }
        public override void DidPauseRecording(QTKit.QTCaptureFileOutput captureOutput, Foundation.NSUrl fileUrl, QTKit.QTCaptureConnection[] connections)
        {
            _DidPauseRecording.OnNext(Tuple.Create(captureOutput, fileUrl, connections));
        }

        readonly SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[]>> _DidResumeRecording = new SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[]>>();
        public IObservable<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[]>> DidResumeRecordingObs { get { return _DidResumeRecording; } }
        public override void DidResumeRecording(QTKit.QTCaptureFileOutput captureOutput, Foundation.NSUrl fileUrl, QTKit.QTCaptureConnection[] connections)
        {
            _DidResumeRecording.OnNext(Tuple.Create(captureOutput, fileUrl, connections));
        }

        readonly SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[]>> _DidStartRecording = new SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[]>>();
        public IObservable<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[]>> DidStartRecordingObs { get { return _DidStartRecording; } }
        public override void DidStartRecording(QTKit.QTCaptureFileOutput captureOutput, Foundation.NSUrl fileUrl, QTKit.QTCaptureConnection[] connections)
        {
            _DidStartRecording.OnNext(Tuple.Create(captureOutput, fileUrl, connections));
        }

        readonly SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[], Foundation.NSError>> _MustChangeOutputFile = new SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[], Foundation.NSError>>();
        public IObservable<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[], Foundation.NSError>> MustChangeOutputFileObs { get { return _MustChangeOutputFile; } }
        public override void MustChangeOutputFile(QTKit.QTCaptureFileOutput captureOutput, Foundation.NSUrl outputFileURL, QTKit.QTCaptureConnection[] connections, Foundation.NSError reason)
        {
            _MustChangeOutputFile.OnNext(Tuple.Create(captureOutput, outputFileURL, connections, reason));
        }

        readonly SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[], Foundation.NSError>> _WillFinishRecording = new SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[], Foundation.NSError>>();
        public IObservable<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[], Foundation.NSError>> WillFinishRecordingObs { get { return _WillFinishRecording; } }
        public override void WillFinishRecording(QTKit.QTCaptureFileOutput captureOutput, Foundation.NSUrl outputFileURL, QTKit.QTCaptureConnection[] connections, Foundation.NSError reason)
        {
            _WillFinishRecording.OnNext(Tuple.Create(captureOutput, outputFileURL, connections, reason));
        }

        readonly SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[]>> _WillStartRecording = new SingleAwaitSubject<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[]>>();
        public IObservable<Tuple<QTKit.QTCaptureFileOutput, Foundation.NSUrl, QTKit.QTCaptureConnection[]>> WillStartRecordingObs { get { return _WillStartRecording; } }
        public override void WillStartRecording(QTKit.QTCaptureFileOutput captureOutput, Foundation.NSUrl fileUrl, QTKit.QTCaptureConnection[] connections)
        {
            _WillStartRecording.OnNext(Tuple.Create(captureOutput, fileUrl, connections));
        }

    }
}
namespace QuickLookUI.Rx
{
    public  partial class QLPreviewPanelDelegateRx : QLPreviewPanelDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSNotification> _DidBecomeKey = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidBecomeKeyObs { get { return _DidBecomeKey; } }
        public override void DidBecomeKey(Foundation.NSNotification notification)
        {
            _DidBecomeKey.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidBecomeMain = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidBecomeMainObs { get { return _DidBecomeMain; } }
        public override void DidBecomeMain(Foundation.NSNotification notification)
        {
            _DidBecomeMain.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidChangeBackingProperties = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidChangeBackingPropertiesObs { get { return _DidChangeBackingProperties; } }
        public override void DidChangeBackingProperties(Foundation.NSNotification notification)
        {
            _DidChangeBackingProperties.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidChangeScreen = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidChangeScreenObs { get { return _DidChangeScreen; } }
        public override void DidChangeScreen(Foundation.NSNotification notification)
        {
            _DidChangeScreen.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidChangeScreenProfile = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidChangeScreenProfileObs { get { return _DidChangeScreenProfile; } }
        public override void DidChangeScreenProfile(Foundation.NSNotification notification)
        {
            _DidChangeScreenProfile.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidDeminiaturize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidDeminiaturizeObs { get { return _DidDeminiaturize; } }
        public override void DidDeminiaturize(Foundation.NSNotification notification)
        {
            _DidDeminiaturize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidEndLiveResize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidEndLiveResizeObs { get { return _DidEndLiveResize; } }
        public override void DidEndLiveResize(Foundation.NSNotification notification)
        {
            _DidEndLiveResize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidEndSheet = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidEndSheetObs { get { return _DidEndSheet; } }
        public override void DidEndSheet(Foundation.NSNotification notification)
        {
            _DidEndSheet.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidEnterFullScreen = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidEnterFullScreenObs { get { return _DidEnterFullScreen; } }
        public override void DidEnterFullScreen(Foundation.NSNotification notification)
        {
            _DidEnterFullScreen.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidEnterVersionBrowser = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidEnterVersionBrowserObs { get { return _DidEnterVersionBrowser; } }
        public override void DidEnterVersionBrowser(Foundation.NSNotification notification)
        {
            _DidEnterVersionBrowser.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidExitFullScreen = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidExitFullScreenObs { get { return _DidExitFullScreen; } }
        public override void DidExitFullScreen(Foundation.NSNotification notification)
        {
            _DidExitFullScreen.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidExitVersionBrowser = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidExitVersionBrowserObs { get { return _DidExitVersionBrowser; } }
        public override void DidExitVersionBrowser(Foundation.NSNotification notification)
        {
            _DidExitVersionBrowser.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidExpose = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidExposeObs { get { return _DidExpose; } }
        public override void DidExpose(Foundation.NSNotification notification)
        {
            _DidExpose.OnNext(notification);
        }

        readonly SingleAwaitSubject<AppKit.NSWindow> _DidFailToEnterFullScreen = new SingleAwaitSubject<AppKit.NSWindow>();
        public IObservable<AppKit.NSWindow> DidFailToEnterFullScreenObs { get { return _DidFailToEnterFullScreen; } }
        public override void DidFailToEnterFullScreen(AppKit.NSWindow window)
        {
            _DidFailToEnterFullScreen.OnNext(window);
        }

        readonly SingleAwaitSubject<AppKit.NSWindow> _DidFailToExitFullScreen = new SingleAwaitSubject<AppKit.NSWindow>();
        public IObservable<AppKit.NSWindow> DidFailToExitFullScreenObs { get { return _DidFailToExitFullScreen; } }
        public override void DidFailToExitFullScreen(AppKit.NSWindow window)
        {
            _DidFailToExitFullScreen.OnNext(window);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidMiniaturize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidMiniaturizeObs { get { return _DidMiniaturize; } }
        public override void DidMiniaturize(Foundation.NSNotification notification)
        {
            _DidMiniaturize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidMove = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidMoveObs { get { return _DidMove; } }
        public override void DidMove(Foundation.NSNotification notification)
        {
            _DidMove.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidResignKey = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidResignKeyObs { get { return _DidResignKey; } }
        public override void DidResignKey(Foundation.NSNotification notification)
        {
            _DidResignKey.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidResignMain = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidResignMainObs { get { return _DidResignMain; } }
        public override void DidResignMain(Foundation.NSNotification notification)
        {
            _DidResignMain.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidResize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidResizeObs { get { return _DidResize; } }
        public override void DidResize(Foundation.NSNotification notification)
        {
            _DidResize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _DidUpdate = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> DidUpdateObs { get { return _DidUpdate; } }
        public override void DidUpdate(Foundation.NSNotification notification)
        {
            _DidUpdate.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillBeginSheet = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillBeginSheetObs { get { return _WillBeginSheet; } }
        public override void WillBeginSheet(Foundation.NSNotification notification)
        {
            _WillBeginSheet.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillClose = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillCloseObs { get { return _WillClose; } }
        public override void WillClose(Foundation.NSNotification notification)
        {
            _WillClose.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillEnterFullScreen = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillEnterFullScreenObs { get { return _WillEnterFullScreen; } }
        public override void WillEnterFullScreen(Foundation.NSNotification notification)
        {
            _WillEnterFullScreen.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillEnterVersionBrowser = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillEnterVersionBrowserObs { get { return _WillEnterVersionBrowser; } }
        public override void WillEnterVersionBrowser(Foundation.NSNotification notification)
        {
            _WillEnterVersionBrowser.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillExitFullScreen = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillExitFullScreenObs { get { return _WillExitFullScreen; } }
        public override void WillExitFullScreen(Foundation.NSNotification notification)
        {
            _WillExitFullScreen.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillExitVersionBrowser = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillExitVersionBrowserObs { get { return _WillExitVersionBrowser; } }
        public override void WillExitVersionBrowser(Foundation.NSNotification notification)
        {
            _WillExitVersionBrowser.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillMiniaturize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillMiniaturizeObs { get { return _WillMiniaturize; } }
        public override void WillMiniaturize(Foundation.NSNotification notification)
        {
            _WillMiniaturize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillMove = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillMoveObs { get { return _WillMove; } }
        public override void WillMove(Foundation.NSNotification notification)
        {
            _WillMove.OnNext(notification);
        }

        readonly SingleAwaitSubject<Foundation.NSNotification> _WillStartLiveResize = new SingleAwaitSubject<Foundation.NSNotification>();
        public IObservable<Foundation.NSNotification> WillStartLiveResizeObs { get { return _WillStartLiveResize; } }
        public override void WillStartLiveResize(Foundation.NSNotification notification)
        {
            _WillStartLiveResize.OnNext(notification);
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSWindow, Foundation.NSCoder>> _DidDecodeRestorableState = new SingleAwaitSubject<Tuple<AppKit.NSWindow, Foundation.NSCoder>>();
        public IObservable<Tuple<AppKit.NSWindow, Foundation.NSCoder>> DidDecodeRestorableStateObs { get { return _DidDecodeRestorableState; } }
        public override void DidDecodeRestorableState(AppKit.NSWindow window, Foundation.NSCoder coder)
        {
            _DidDecodeRestorableState.OnNext(Tuple.Create(window, coder));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSWindow, System.Double>> _StartCustomAnimationToEnterFullScreen = new SingleAwaitSubject<Tuple<AppKit.NSWindow, System.Double>>();
        public IObservable<Tuple<AppKit.NSWindow, System.Double>> StartCustomAnimationToEnterFullScreenObs { get { return _StartCustomAnimationToEnterFullScreen; } }
        public override void StartCustomAnimationToEnterFullScreen(AppKit.NSWindow window, System.Double duration)
        {
            _StartCustomAnimationToEnterFullScreen.OnNext(Tuple.Create(window, duration));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSWindow, System.Double>> _StartCustomAnimationToExitFullScreen = new SingleAwaitSubject<Tuple<AppKit.NSWindow, System.Double>>();
        public IObservable<Tuple<AppKit.NSWindow, System.Double>> StartCustomAnimationToExitFullScreenObs { get { return _StartCustomAnimationToExitFullScreen; } }
        public override void StartCustomAnimationToExitFullScreen(AppKit.NSWindow window, System.Double duration)
        {
            _StartCustomAnimationToExitFullScreen.OnNext(Tuple.Create(window, duration));
        }

        readonly SingleAwaitSubject<Tuple<AppKit.NSWindow, Foundation.NSCoder>> _WillEncodeRestorableState = new SingleAwaitSubject<Tuple<AppKit.NSWindow, Foundation.NSCoder>>();
        public IObservable<Tuple<AppKit.NSWindow, Foundation.NSCoder>> WillEncodeRestorableStateObs { get { return _WillEncodeRestorableState; } }
        public override void WillEncodeRestorableState(AppKit.NSWindow window, Foundation.NSCoder coder)
        {
            _WillEncodeRestorableState.OnNext(Tuple.Create(window, coder));
        }

    }
}
namespace SceneKit.Rx
{
    public  partial class SCNNodeRendererDelegateRx : SCNNodeRendererDelegate
    {
        readonly SingleAwaitSubject<Tuple<SceneKit.SCNNode, SceneKit.SCNRenderer, Foundation.NSDictionary>> _Render = new SingleAwaitSubject<Tuple<SceneKit.SCNNode, SceneKit.SCNRenderer, Foundation.NSDictionary>>();
        public IObservable<Tuple<SceneKit.SCNNode, SceneKit.SCNRenderer, Foundation.NSDictionary>> RenderObs { get { return _Render; } }
        public override void Render(SceneKit.SCNNode node, SceneKit.SCNRenderer renderer, Foundation.NSDictionary arguments)
        {
            _Render.OnNext(Tuple.Create(node, renderer, arguments));
        }

    }
    public  partial class SCNPhysicsContactDelegateRx : SCNPhysicsContactDelegate
    {
        readonly SingleAwaitSubject<Tuple<SceneKit.SCNPhysicsWorld, SceneKit.SCNPhysicsContact>> _DidBeginContact = new SingleAwaitSubject<Tuple<SceneKit.SCNPhysicsWorld, SceneKit.SCNPhysicsContact>>();
        public IObservable<Tuple<SceneKit.SCNPhysicsWorld, SceneKit.SCNPhysicsContact>> DidBeginContactObs { get { return _DidBeginContact; } }
        public override void DidBeginContact(SceneKit.SCNPhysicsWorld world, SceneKit.SCNPhysicsContact contact)
        {
            _DidBeginContact.OnNext(Tuple.Create(world, contact));
        }

        readonly SingleAwaitSubject<Tuple<SceneKit.SCNPhysicsWorld, SceneKit.SCNPhysicsContact>> _DidEndContact = new SingleAwaitSubject<Tuple<SceneKit.SCNPhysicsWorld, SceneKit.SCNPhysicsContact>>();
        public IObservable<Tuple<SceneKit.SCNPhysicsWorld, SceneKit.SCNPhysicsContact>> DidEndContactObs { get { return _DidEndContact; } }
        public override void DidEndContact(SceneKit.SCNPhysicsWorld world, SceneKit.SCNPhysicsContact contact)
        {
            _DidEndContact.OnNext(Tuple.Create(world, contact));
        }

        readonly SingleAwaitSubject<Tuple<SceneKit.SCNPhysicsWorld, SceneKit.SCNPhysicsContact>> _DidUpdateContact = new SingleAwaitSubject<Tuple<SceneKit.SCNPhysicsWorld, SceneKit.SCNPhysicsContact>>();
        public IObservable<Tuple<SceneKit.SCNPhysicsWorld, SceneKit.SCNPhysicsContact>> DidUpdateContactObs { get { return _DidUpdateContact; } }
        public override void DidUpdateContact(SceneKit.SCNPhysicsWorld world, SceneKit.SCNPhysicsContact contact)
        {
            _DidUpdateContact.OnNext(Tuple.Create(world, contact));
        }

    }
    public  partial class SCNProgramDelegateRx : SCNProgramDelegate
    {
        readonly SingleAwaitSubject<Tuple<SceneKit.SCNProgram, Foundation.NSError>> _HandleError = new SingleAwaitSubject<Tuple<SceneKit.SCNProgram, Foundation.NSError>>();
        public IObservable<Tuple<SceneKit.SCNProgram, Foundation.NSError>> HandleErrorObs { get { return _HandleError; } }
        public override void HandleError(SceneKit.SCNProgram program, Foundation.NSError error)
        {
            _HandleError.OnNext(Tuple.Create(program, error));
        }

    }
    public  partial class SCNSceneRendererDelegateRx : SCNSceneRendererDelegate
    {
        readonly SingleAwaitSubject<Tuple<SceneKit.ISCNSceneRenderer, System.Double>> _DidApplyAnimations = new SingleAwaitSubject<Tuple<SceneKit.ISCNSceneRenderer, System.Double>>();
        public IObservable<Tuple<SceneKit.ISCNSceneRenderer, System.Double>> DidApplyAnimationsObs { get { return _DidApplyAnimations; } }
        public override void DidApplyAnimations(SceneKit.ISCNSceneRenderer renderer, System.Double timeInSeconds)
        {
            _DidApplyAnimations.OnNext(Tuple.Create(renderer, timeInSeconds));
        }

        readonly SingleAwaitSubject<Tuple<SceneKit.ISCNSceneRenderer, SceneKit.SCNScene, System.Double>> _DidRenderScene = new SingleAwaitSubject<Tuple<SceneKit.ISCNSceneRenderer, SceneKit.SCNScene, System.Double>>();
        public IObservable<Tuple<SceneKit.ISCNSceneRenderer, SceneKit.SCNScene, System.Double>> DidRenderSceneObs { get { return _DidRenderScene; } }
        public override void DidRenderScene(SceneKit.ISCNSceneRenderer renderer, SceneKit.SCNScene scene, System.Double timeInSeconds)
        {
            _DidRenderScene.OnNext(Tuple.Create(renderer, scene, timeInSeconds));
        }

        readonly SingleAwaitSubject<Tuple<SceneKit.ISCNSceneRenderer, System.Double>> _DidSimulatePhysics = new SingleAwaitSubject<Tuple<SceneKit.ISCNSceneRenderer, System.Double>>();
        public IObservable<Tuple<SceneKit.ISCNSceneRenderer, System.Double>> DidSimulatePhysicsObs { get { return _DidSimulatePhysics; } }
        public override void DidSimulatePhysics(SceneKit.ISCNSceneRenderer renderer, System.Double timeInSeconds)
        {
            _DidSimulatePhysics.OnNext(Tuple.Create(renderer, timeInSeconds));
        }

        readonly SingleAwaitSubject<Tuple<SceneKit.ISCNSceneRenderer, System.Double>> _Update = new SingleAwaitSubject<Tuple<SceneKit.ISCNSceneRenderer, System.Double>>();
        public IObservable<Tuple<SceneKit.ISCNSceneRenderer, System.Double>> UpdateObs { get { return _Update; } }
        public override void Update(SceneKit.ISCNSceneRenderer renderer, System.Double timeInSeconds)
        {
            _Update.OnNext(Tuple.Create(renderer, timeInSeconds));
        }

        readonly SingleAwaitSubject<Tuple<SceneKit.ISCNSceneRenderer, SceneKit.SCNScene, System.Double>> _WillRenderScene = new SingleAwaitSubject<Tuple<SceneKit.ISCNSceneRenderer, SceneKit.SCNScene, System.Double>>();
        public IObservable<Tuple<SceneKit.ISCNSceneRenderer, SceneKit.SCNScene, System.Double>> WillRenderSceneObs { get { return _WillRenderScene; } }
        public override void WillRenderScene(SceneKit.ISCNSceneRenderer renderer, SceneKit.SCNScene scene, System.Double timeInSeconds)
        {
            _WillRenderScene.OnNext(Tuple.Create(renderer, scene, timeInSeconds));
        }

    }
}
namespace ContactsUI.Rx
{
    public  partial class CNContactPickerDelegateRx : CNContactPickerDelegate
    {
        readonly SingleAwaitSubject<ContactsUI.CNContactPicker> _DidClose = new SingleAwaitSubject<ContactsUI.CNContactPicker>();
        public IObservable<ContactsUI.CNContactPicker> DidCloseObs { get { return _DidClose; } }
        public override void DidClose(ContactsUI.CNContactPicker picker)
        {
            _DidClose.OnNext(picker);
        }

        readonly SingleAwaitSubject<ContactsUI.CNContactPicker> _WillClose = new SingleAwaitSubject<ContactsUI.CNContactPicker>();
        public IObservable<ContactsUI.CNContactPicker> WillCloseObs { get { return _WillClose; } }
        public override void WillClose(ContactsUI.CNContactPicker picker)
        {
            _WillClose.OnNext(picker);
        }

        readonly SingleAwaitSubject<Tuple<ContactsUI.CNContactPicker, Contacts.CNContactProperty>> _ContactPropertySelected = new SingleAwaitSubject<Tuple<ContactsUI.CNContactPicker, Contacts.CNContactProperty>>();
        public IObservable<Tuple<ContactsUI.CNContactPicker, Contacts.CNContactProperty>> ContactPropertySelectedObs { get { return _ContactPropertySelected; } }
        public override void ContactPropertySelected(ContactsUI.CNContactPicker picker, Contacts.CNContactProperty contactProperty)
        {
            _ContactPropertySelected.OnNext(Tuple.Create(picker, contactProperty));
        }

        readonly SingleAwaitSubject<Tuple<ContactsUI.CNContactPicker, Contacts.CNContact>> _ContactSelected = new SingleAwaitSubject<Tuple<ContactsUI.CNContactPicker, Contacts.CNContact>>();
        public IObservable<Tuple<ContactsUI.CNContactPicker, Contacts.CNContact>> ContactSelectedObs { get { return _ContactSelected; } }
        public override void ContactSelected(ContactsUI.CNContactPicker picker, Contacts.CNContact contact)
        {
            _ContactSelected.OnNext(Tuple.Create(picker, contact));
        }

    }
}
namespace CoreBluetooth.Rx
{
    public abstract partial class CBCentralManagerDelegateRx : CBCentralManagerDelegate
    {
        readonly SingleAwaitSubject<CoreBluetooth.CBCentralManager> _UpdatedState = new SingleAwaitSubject<CoreBluetooth.CBCentralManager>();
        public IObservable<CoreBluetooth.CBCentralManager> UpdatedStateObs { get { return _UpdatedState; } }
        public override void UpdatedState(CoreBluetooth.CBCentralManager central)
        {
            _UpdatedState.OnNext(central);
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral>> _ConnectedPeripheral = new SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral>>();
        public IObservable<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral>> ConnectedPeripheralObs { get { return _ConnectedPeripheral; } }
        public override void ConnectedPeripheral(CoreBluetooth.CBCentralManager central, CoreBluetooth.CBPeripheral peripheral)
        {
            _ConnectedPeripheral.OnNext(Tuple.Create(central, peripheral));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral, Foundation.NSError>> _DisconnectedPeripheral = new SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral, Foundation.NSError>> DisconnectedPeripheralObs { get { return _DisconnectedPeripheral; } }
        public override void DisconnectedPeripheral(CoreBluetooth.CBCentralManager central, CoreBluetooth.CBPeripheral peripheral, Foundation.NSError error)
        {
            _DisconnectedPeripheral.OnNext(Tuple.Create(central, peripheral, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral, Foundation.NSDictionary, Foundation.NSNumber>> _DiscoveredPeripheral = new SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral, Foundation.NSDictionary, Foundation.NSNumber>>();
        public IObservable<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral, Foundation.NSDictionary, Foundation.NSNumber>> DiscoveredPeripheralObs { get { return _DiscoveredPeripheral; } }
        public override void DiscoveredPeripheral(CoreBluetooth.CBCentralManager central, CoreBluetooth.CBPeripheral peripheral, Foundation.NSDictionary advertisementData, Foundation.NSNumber RSSI)
        {
            _DiscoveredPeripheral.OnNext(Tuple.Create(central, peripheral, advertisementData, RSSI));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral, Foundation.NSError>> _FailedToConnectPeripheral = new SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral, Foundation.NSError>> FailedToConnectPeripheralObs { get { return _FailedToConnectPeripheral; } }
        public override void FailedToConnectPeripheral(CoreBluetooth.CBCentralManager central, CoreBluetooth.CBPeripheral peripheral, Foundation.NSError error)
        {
            _FailedToConnectPeripheral.OnNext(Tuple.Create(central, peripheral, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral[]>> _RetrievedConnectedPeripherals = new SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral[]>>();
        public IObservable<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral[]>> RetrievedConnectedPeripheralsObs { get { return _RetrievedConnectedPeripherals; } }
        public override void RetrievedConnectedPeripherals(CoreBluetooth.CBCentralManager central, CoreBluetooth.CBPeripheral[] peripherals)
        {
            _RetrievedConnectedPeripherals.OnNext(Tuple.Create(central, peripherals));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral[]>> _RetrievedPeripherals = new SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral[]>>();
        public IObservable<Tuple<CoreBluetooth.CBCentralManager, CoreBluetooth.CBPeripheral[]>> RetrievedPeripheralsObs { get { return _RetrievedPeripherals; } }
        public override void RetrievedPeripherals(CoreBluetooth.CBCentralManager central, CoreBluetooth.CBPeripheral[] peripherals)
        {
            _RetrievedPeripherals.OnNext(Tuple.Create(central, peripherals));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, Foundation.NSDictionary>> _WillRestoreState = new SingleAwaitSubject<Tuple<CoreBluetooth.CBCentralManager, Foundation.NSDictionary>>();
        public IObservable<Tuple<CoreBluetooth.CBCentralManager, Foundation.NSDictionary>> WillRestoreStateObs { get { return _WillRestoreState; } }
        public override void WillRestoreState(CoreBluetooth.CBCentralManager central, Foundation.NSDictionary dict)
        {
            _WillRestoreState.OnNext(Tuple.Create(central, dict));
        }

    }
    public  partial class CBPeripheralDelegateRx : CBPeripheralDelegate
    {
        readonly SingleAwaitSubject<CoreBluetooth.CBPeripheral> _InvalidatedService = new SingleAwaitSubject<CoreBluetooth.CBPeripheral>();
        public IObservable<CoreBluetooth.CBPeripheral> InvalidatedServiceObs { get { return _InvalidatedService; } }
        public override void InvalidatedService(CoreBluetooth.CBPeripheral peripheral)
        {
            _InvalidatedService.OnNext(peripheral);
        }

        readonly SingleAwaitSubject<CoreBluetooth.CBPeripheral> _UpdatedName = new SingleAwaitSubject<CoreBluetooth.CBPeripheral>();
        public IObservable<CoreBluetooth.CBPeripheral> UpdatedNameObs { get { return _UpdatedName; } }
        public override void UpdatedName(CoreBluetooth.CBPeripheral peripheral)
        {
            _UpdatedName.OnNext(peripheral);
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBService, Foundation.NSError>> _DiscoveredCharacteristic = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBService, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBService, Foundation.NSError>> DiscoveredCharacteristicObs { get { return _DiscoveredCharacteristic; } }
        public override void DiscoveredCharacteristic(CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBService service, Foundation.NSError error)
        {
            _DiscoveredCharacteristic.OnNext(Tuple.Create(peripheral, service, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBCharacteristic, Foundation.NSError>> _DiscoveredDescriptor = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBCharacteristic, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBCharacteristic, Foundation.NSError>> DiscoveredDescriptorObs { get { return _DiscoveredDescriptor; } }
        public override void DiscoveredDescriptor(CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBCharacteristic characteristic, Foundation.NSError error)
        {
            _DiscoveredDescriptor.OnNext(Tuple.Create(peripheral, characteristic, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBService, Foundation.NSError>> _DiscoveredIncludedService = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBService, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBService, Foundation.NSError>> DiscoveredIncludedServiceObs { get { return _DiscoveredIncludedService; } }
        public override void DiscoveredIncludedService(CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBService service, Foundation.NSError error)
        {
            _DiscoveredIncludedService.OnNext(Tuple.Create(peripheral, service, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, Foundation.NSError>> _DiscoveredService = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheral, Foundation.NSError>> DiscoveredServiceObs { get { return _DiscoveredService; } }
        public override void DiscoveredService(CoreBluetooth.CBPeripheral peripheral, Foundation.NSError error)
        {
            _DiscoveredService.OnNext(Tuple.Create(peripheral, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBService[]>> _ModifiedServices = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBService[]>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBService[]>> ModifiedServicesObs { get { return _ModifiedServices; } }
        public override void ModifiedServices(CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBService[] services)
        {
            _ModifiedServices.OnNext(Tuple.Create(peripheral, services));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, Foundation.NSNumber, Foundation.NSError>> _RssiRead = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, Foundation.NSNumber, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheral, Foundation.NSNumber, Foundation.NSError>> RssiReadObs { get { return _RssiRead; } }
        public override void RssiRead(CoreBluetooth.CBPeripheral peripheral, Foundation.NSNumber rssi, Foundation.NSError error)
        {
            _RssiRead.OnNext(Tuple.Create(peripheral, rssi, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, Foundation.NSError>> _RssiUpdated = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheral, Foundation.NSError>> RssiUpdatedObs { get { return _RssiUpdated; } }
        public override void RssiUpdated(CoreBluetooth.CBPeripheral peripheral, Foundation.NSError error)
        {
            _RssiUpdated.OnNext(Tuple.Create(peripheral, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBCharacteristic, Foundation.NSError>> _UpdatedCharacterteristicValue = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBCharacteristic, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBCharacteristic, Foundation.NSError>> UpdatedCharacterteristicValueObs { get { return _UpdatedCharacterteristicValue; } }
        public override void UpdatedCharacterteristicValue(CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBCharacteristic characteristic, Foundation.NSError error)
        {
            _UpdatedCharacterteristicValue.OnNext(Tuple.Create(peripheral, characteristic, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBCharacteristic, Foundation.NSError>> _UpdatedNotificationState = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBCharacteristic, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBCharacteristic, Foundation.NSError>> UpdatedNotificationStateObs { get { return _UpdatedNotificationState; } }
        public override void UpdatedNotificationState(CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBCharacteristic characteristic, Foundation.NSError error)
        {
            _UpdatedNotificationState.OnNext(Tuple.Create(peripheral, characteristic, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBDescriptor, Foundation.NSError>> _UpdatedValue = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBDescriptor, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBDescriptor, Foundation.NSError>> UpdatedValueObs { get { return _UpdatedValue; } }
        public override void UpdatedValue(CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBDescriptor descriptor, Foundation.NSError error)
        {
            _UpdatedValue.OnNext(Tuple.Create(peripheral, descriptor, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBCharacteristic, Foundation.NSError>> _WroteCharacteristicValue = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBCharacteristic, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBCharacteristic, Foundation.NSError>> WroteCharacteristicValueObs { get { return _WroteCharacteristicValue; } }
        public override void WroteCharacteristicValue(CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBCharacteristic characteristic, Foundation.NSError error)
        {
            _WroteCharacteristicValue.OnNext(Tuple.Create(peripheral, characteristic, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBDescriptor, Foundation.NSError>> _WroteDescriptorValue = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBDescriptor, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheral, CoreBluetooth.CBDescriptor, Foundation.NSError>> WroteDescriptorValueObs { get { return _WroteDescriptorValue; } }
        public override void WroteDescriptorValue(CoreBluetooth.CBPeripheral peripheral, CoreBluetooth.CBDescriptor descriptor, Foundation.NSError error)
        {
            _WroteDescriptorValue.OnNext(Tuple.Create(peripheral, descriptor, error));
        }

    }
    public abstract partial class CBPeripheralManagerDelegateRx : CBPeripheralManagerDelegate
    {
        readonly SingleAwaitSubject<CoreBluetooth.CBPeripheralManager> _ReadyToUpdateSubscribers = new SingleAwaitSubject<CoreBluetooth.CBPeripheralManager>();
        public IObservable<CoreBluetooth.CBPeripheralManager> ReadyToUpdateSubscribersObs { get { return _ReadyToUpdateSubscribers; } }
        public override void ReadyToUpdateSubscribers(CoreBluetooth.CBPeripheralManager peripheral)
        {
            _ReadyToUpdateSubscribers.OnNext(peripheral);
        }

        readonly SingleAwaitSubject<CoreBluetooth.CBPeripheralManager> _StateUpdated = new SingleAwaitSubject<CoreBluetooth.CBPeripheralManager>();
        public IObservable<CoreBluetooth.CBPeripheralManager> StateUpdatedObs { get { return _StateUpdated; } }
        public override void StateUpdated(CoreBluetooth.CBPeripheralManager peripheral)
        {
            _StateUpdated.OnNext(peripheral);
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, Foundation.NSError>> _AdvertisingStarted = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheralManager, Foundation.NSError>> AdvertisingStartedObs { get { return _AdvertisingStarted; } }
        public override void AdvertisingStarted(CoreBluetooth.CBPeripheralManager peripheral, Foundation.NSError error)
        {
            _AdvertisingStarted.OnNext(Tuple.Create(peripheral, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBCentral, CoreBluetooth.CBCharacteristic>> _CharacteristicSubscribed = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBCentral, CoreBluetooth.CBCharacteristic>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBCentral, CoreBluetooth.CBCharacteristic>> CharacteristicSubscribedObs { get { return _CharacteristicSubscribed; } }
        public override void CharacteristicSubscribed(CoreBluetooth.CBPeripheralManager peripheral, CoreBluetooth.CBCentral central, CoreBluetooth.CBCharacteristic characteristic)
        {
            _CharacteristicSubscribed.OnNext(Tuple.Create(peripheral, central, characteristic));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBCentral, CoreBluetooth.CBCharacteristic>> _CharacteristicUnsubscribed = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBCentral, CoreBluetooth.CBCharacteristic>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBCentral, CoreBluetooth.CBCharacteristic>> CharacteristicUnsubscribedObs { get { return _CharacteristicUnsubscribed; } }
        public override void CharacteristicUnsubscribed(CoreBluetooth.CBPeripheralManager peripheral, CoreBluetooth.CBCentral central, CoreBluetooth.CBCharacteristic characteristic)
        {
            _CharacteristicUnsubscribed.OnNext(Tuple.Create(peripheral, central, characteristic));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBATTRequest>> _ReadRequestReceived = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBATTRequest>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBATTRequest>> ReadRequestReceivedObs { get { return _ReadRequestReceived; } }
        public override void ReadRequestReceived(CoreBluetooth.CBPeripheralManager peripheral, CoreBluetooth.CBATTRequest request)
        {
            _ReadRequestReceived.OnNext(Tuple.Create(peripheral, request));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBService, Foundation.NSError>> _ServiceAdded = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBService, Foundation.NSError>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBService, Foundation.NSError>> ServiceAddedObs { get { return _ServiceAdded; } }
        public override void ServiceAdded(CoreBluetooth.CBPeripheralManager peripheral, CoreBluetooth.CBService service, Foundation.NSError error)
        {
            _ServiceAdded.OnNext(Tuple.Create(peripheral, service, error));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, Foundation.NSDictionary>> _WillRestoreState = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, Foundation.NSDictionary>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheralManager, Foundation.NSDictionary>> WillRestoreStateObs { get { return _WillRestoreState; } }
        public override void WillRestoreState(CoreBluetooth.CBPeripheralManager peripheral, Foundation.NSDictionary dict)
        {
            _WillRestoreState.OnNext(Tuple.Create(peripheral, dict));
        }

        readonly SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBATTRequest[]>> _WriteRequestsReceived = new SingleAwaitSubject<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBATTRequest[]>>();
        public IObservable<Tuple<CoreBluetooth.CBPeripheralManager, CoreBluetooth.CBATTRequest[]>> WriteRequestsReceivedObs { get { return _WriteRequestsReceived; } }
        public override void WriteRequestsReceived(CoreBluetooth.CBPeripheralManager peripheral, CoreBluetooth.CBATTRequest[] requests)
        {
            _WriteRequestsReceived.OnNext(Tuple.Create(peripheral, requests));
        }

    }
}
namespace GameKit.Rx
{
    public abstract partial class GKFriendRequestComposeViewControllerDelegateRx : GKFriendRequestComposeViewControllerDelegate
    {
        readonly SingleAwaitSubject<GameKit.GKFriendRequestComposeViewController> _DidFinish = new SingleAwaitSubject<GameKit.GKFriendRequestComposeViewController>();
        public IObservable<GameKit.GKFriendRequestComposeViewController> DidFinishObs { get { return _DidFinish; } }
        public override void DidFinish(GameKit.GKFriendRequestComposeViewController viewController)
        {
            _DidFinish.OnNext(viewController);
        }

    }
    public abstract partial class GKGameCenterControllerDelegateRx : GKGameCenterControllerDelegate
    {
        readonly SingleAwaitSubject<GameKit.GKGameCenterViewController> _Finished = new SingleAwaitSubject<GameKit.GKGameCenterViewController>();
        public IObservable<GameKit.GKGameCenterViewController> FinishedObs { get { return _Finished; } }
        public override void Finished(GameKit.GKGameCenterViewController controller)
        {
            _Finished.OnNext(controller);
        }

    }
    public abstract partial class GKAchievementViewControllerDelegateRx : GKAchievementViewControllerDelegate
    {
        readonly SingleAwaitSubject<GameKit.GKAchievementViewController> _DidFinish = new SingleAwaitSubject<GameKit.GKAchievementViewController>();
        public IObservable<GameKit.GKAchievementViewController> DidFinishObs { get { return _DidFinish; } }
        public override void DidFinish(GameKit.GKAchievementViewController viewController)
        {
            _DidFinish.OnNext(viewController);
        }

    }
    public abstract partial class GKTurnBasedMatchmakerViewControllerDelegateRx : GKTurnBasedMatchmakerViewControllerDelegate
    {
        readonly SingleAwaitSubject<GameKit.GKTurnBasedMatchmakerViewController> _WasCancelled = new SingleAwaitSubject<GameKit.GKTurnBasedMatchmakerViewController>();
        public IObservable<GameKit.GKTurnBasedMatchmakerViewController> WasCancelledObs { get { return _WasCancelled; } }
        public override void WasCancelled(GameKit.GKTurnBasedMatchmakerViewController viewController)
        {
            _WasCancelled.OnNext(viewController);
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKTurnBasedMatchmakerViewController, Foundation.NSError>> _FailedWithError = new SingleAwaitSubject<Tuple<GameKit.GKTurnBasedMatchmakerViewController, Foundation.NSError>>();
        public IObservable<Tuple<GameKit.GKTurnBasedMatchmakerViewController, Foundation.NSError>> FailedWithErrorObs { get { return _FailedWithError; } }
        public override void FailedWithError(GameKit.GKTurnBasedMatchmakerViewController viewController, Foundation.NSError error)
        {
            _FailedWithError.OnNext(Tuple.Create(viewController, error));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKTurnBasedMatchmakerViewController, GameKit.GKTurnBasedMatch>> _FoundMatch = new SingleAwaitSubject<Tuple<GameKit.GKTurnBasedMatchmakerViewController, GameKit.GKTurnBasedMatch>>();
        public IObservable<Tuple<GameKit.GKTurnBasedMatchmakerViewController, GameKit.GKTurnBasedMatch>> FoundMatchObs { get { return _FoundMatch; } }
        public override void FoundMatch(GameKit.GKTurnBasedMatchmakerViewController viewController, GameKit.GKTurnBasedMatch match)
        {
            _FoundMatch.OnNext(Tuple.Create(viewController, match));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKTurnBasedMatchmakerViewController, GameKit.GKTurnBasedMatch>> _PlayerQuitForMatch = new SingleAwaitSubject<Tuple<GameKit.GKTurnBasedMatchmakerViewController, GameKit.GKTurnBasedMatch>>();
        public IObservable<Tuple<GameKit.GKTurnBasedMatchmakerViewController, GameKit.GKTurnBasedMatch>> PlayerQuitForMatchObs { get { return _PlayerQuitForMatch; } }
        public override void PlayerQuitForMatch(GameKit.GKTurnBasedMatchmakerViewController viewController, GameKit.GKTurnBasedMatch match)
        {
            _PlayerQuitForMatch.OnNext(Tuple.Create(viewController, match));
        }

    }
    public abstract partial class GKLeaderboardViewControllerDelegateRx : GKLeaderboardViewControllerDelegate
    {
        readonly SingleAwaitSubject<GameKit.GKLeaderboardViewController> _DidFinish = new SingleAwaitSubject<GameKit.GKLeaderboardViewController>();
        public IObservable<GameKit.GKLeaderboardViewController> DidFinishObs { get { return _DidFinish; } }
        public override void DidFinish(GameKit.GKLeaderboardViewController viewController)
        {
            _DidFinish.OnNext(viewController);
        }

    }
    public abstract partial class GKTurnBasedEventHandlerDelegateRx : GKTurnBasedEventHandlerDelegate
    {
        readonly SingleAwaitSubject<Foundation.NSString[]> _HandleInviteFromGameCenter = new SingleAwaitSubject<Foundation.NSString[]>();
        public IObservable<Foundation.NSString[]> HandleInviteFromGameCenterObs { get { return _HandleInviteFromGameCenter; } }
        public override void HandleInviteFromGameCenter(Foundation.NSString[] playersToInvite)
        {
            _HandleInviteFromGameCenter.OnNext(playersToInvite);
        }

        readonly SingleAwaitSubject<GameKit.GKTurnBasedMatch> _HandleMatchEnded = new SingleAwaitSubject<GameKit.GKTurnBasedMatch>();
        public IObservable<GameKit.GKTurnBasedMatch> HandleMatchEndedObs { get { return _HandleMatchEnded; } }
        public override void HandleMatchEnded(GameKit.GKTurnBasedMatch match)
        {
            _HandleMatchEnded.OnNext(match);
        }

        readonly SingleAwaitSubject<GameKit.GKTurnBasedMatch> _HandleTurnEventForMatch = new SingleAwaitSubject<GameKit.GKTurnBasedMatch>();
        public IObservable<GameKit.GKTurnBasedMatch> HandleTurnEventForMatchObs { get { return _HandleTurnEventForMatch; } }
        public override void HandleTurnEventForMatch(GameKit.GKTurnBasedMatch match)
        {
            _HandleTurnEventForMatch.OnNext(match);
        }

    }
    public  partial class GKMatchDelegateRx : GKMatchDelegate
    {
        readonly SingleAwaitSubject<Tuple<GameKit.GKMatch, string, Foundation.NSError>> _ConnectionFailed = new SingleAwaitSubject<Tuple<GameKit.GKMatch, string, Foundation.NSError>>();
        public IObservable<Tuple<GameKit.GKMatch, string, Foundation.NSError>> ConnectionFailedObs { get { return _ConnectionFailed; } }
        public override void ConnectionFailed(GameKit.GKMatch match, string playerId, Foundation.NSError error)
        {
            _ConnectionFailed.OnNext(Tuple.Create(match, playerId, error));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKMatch, Foundation.NSData, string>> _DataReceived = new SingleAwaitSubject<Tuple<GameKit.GKMatch, Foundation.NSData, string>>();
        public IObservable<Tuple<GameKit.GKMatch, Foundation.NSData, string>> DataReceivedObs { get { return _DataReceived; } }
        public override void DataReceived(GameKit.GKMatch match, Foundation.NSData data, string playerId)
        {
            _DataReceived.OnNext(Tuple.Create(match, data, playerId));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKMatch, Foundation.NSData, GameKit.GKPlayer, GameKit.GKPlayer>> _DataReceivedForRecipient = new SingleAwaitSubject<Tuple<GameKit.GKMatch, Foundation.NSData, GameKit.GKPlayer, GameKit.GKPlayer>>();
        public IObservable<Tuple<GameKit.GKMatch, Foundation.NSData, GameKit.GKPlayer, GameKit.GKPlayer>> DataReceivedForRecipientObs { get { return _DataReceivedForRecipient; } }
        public override void DataReceivedForRecipient(GameKit.GKMatch match, Foundation.NSData data, GameKit.GKPlayer recipient, GameKit.GKPlayer player)
        {
            _DataReceivedForRecipient.OnNext(Tuple.Create(match, data, recipient, player));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKMatch, Foundation.NSData, GameKit.GKPlayer>> _DataReceivedFromPlayer = new SingleAwaitSubject<Tuple<GameKit.GKMatch, Foundation.NSData, GameKit.GKPlayer>>();
        public IObservable<Tuple<GameKit.GKMatch, Foundation.NSData, GameKit.GKPlayer>> DataReceivedFromPlayerObs { get { return _DataReceivedFromPlayer; } }
        public override void DataReceivedFromPlayer(GameKit.GKMatch match, Foundation.NSData data, GameKit.GKPlayer player)
        {
            _DataReceivedFromPlayer.OnNext(Tuple.Create(match, data, player));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKMatch, Foundation.NSError>> _Failed = new SingleAwaitSubject<Tuple<GameKit.GKMatch, Foundation.NSError>>();
        public IObservable<Tuple<GameKit.GKMatch, Foundation.NSError>> FailedObs { get { return _Failed; } }
        public override void Failed(GameKit.GKMatch match, Foundation.NSError error)
        {
            _Failed.OnNext(Tuple.Create(match, error));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKMatch, string, GameKit.GKPlayerConnectionState>> _StateChanged = new SingleAwaitSubject<Tuple<GameKit.GKMatch, string, GameKit.GKPlayerConnectionState>>();
        public IObservable<Tuple<GameKit.GKMatch, string, GameKit.GKPlayerConnectionState>> StateChangedObs { get { return _StateChanged; } }
        public override void StateChanged(GameKit.GKMatch match, string playerId, GameKit.GKPlayerConnectionState state)
        {
            _StateChanged.OnNext(Tuple.Create(match, playerId, state));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKMatch, GameKit.GKPlayer, GameKit.GKPlayerConnectionState>> _StateChangedForPlayer = new SingleAwaitSubject<Tuple<GameKit.GKMatch, GameKit.GKPlayer, GameKit.GKPlayerConnectionState>>();
        public IObservable<Tuple<GameKit.GKMatch, GameKit.GKPlayer, GameKit.GKPlayerConnectionState>> StateChangedForPlayerObs { get { return _StateChangedForPlayer; } }
        public override void StateChangedForPlayer(GameKit.GKMatch match, GameKit.GKPlayer player, GameKit.GKPlayerConnectionState state)
        {
            _StateChangedForPlayer.OnNext(Tuple.Create(match, player, state));
        }

    }
    public abstract partial class GKMatchmakerViewControllerDelegateRx : GKMatchmakerViewControllerDelegate
    {
        readonly SingleAwaitSubject<GameKit.GKMatchmakerViewController> _WasCancelled = new SingleAwaitSubject<GameKit.GKMatchmakerViewController>();
        public IObservable<GameKit.GKMatchmakerViewController> WasCancelledObs { get { return _WasCancelled; } }
        public override void WasCancelled(GameKit.GKMatchmakerViewController viewController)
        {
            _WasCancelled.OnNext(viewController);
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKMatchmakerViewController, Foundation.NSError>> _DidFailWithError = new SingleAwaitSubject<Tuple<GameKit.GKMatchmakerViewController, Foundation.NSError>>();
        public IObservable<Tuple<GameKit.GKMatchmakerViewController, Foundation.NSError>> DidFailWithErrorObs { get { return _DidFailWithError; } }
        public override void DidFailWithError(GameKit.GKMatchmakerViewController viewController, Foundation.NSError error)
        {
            _DidFailWithError.OnNext(Tuple.Create(viewController, error));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKMatchmakerViewController, GameKit.GKPlayer[]>> _DidFindHostedPlayers = new SingleAwaitSubject<Tuple<GameKit.GKMatchmakerViewController, GameKit.GKPlayer[]>>();
        public IObservable<Tuple<GameKit.GKMatchmakerViewController, GameKit.GKPlayer[]>> DidFindHostedPlayersObs { get { return _DidFindHostedPlayers; } }
        public override void DidFindHostedPlayers(GameKit.GKMatchmakerViewController viewController, GameKit.GKPlayer[] playerIDs)
        {
            _DidFindHostedPlayers.OnNext(Tuple.Create(viewController, playerIDs));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKMatchmakerViewController, GameKit.GKMatch>> _DidFindMatch = new SingleAwaitSubject<Tuple<GameKit.GKMatchmakerViewController, GameKit.GKMatch>>();
        public IObservable<Tuple<GameKit.GKMatchmakerViewController, GameKit.GKMatch>> DidFindMatchObs { get { return _DidFindMatch; } }
        public override void DidFindMatch(GameKit.GKMatchmakerViewController viewController, GameKit.GKMatch match)
        {
            _DidFindMatch.OnNext(Tuple.Create(viewController, match));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKMatchmakerViewController, string[]>> _DidFindPlayers = new SingleAwaitSubject<Tuple<GameKit.GKMatchmakerViewController, string[]>>();
        public IObservable<Tuple<GameKit.GKMatchmakerViewController, string[]>> DidFindPlayersObs { get { return _DidFindPlayers; } }
        public override void DidFindPlayers(GameKit.GKMatchmakerViewController viewController, string[] playerIDs)
        {
            _DidFindPlayers.OnNext(Tuple.Create(viewController, playerIDs));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKMatchmakerViewController, GameKit.GKPlayer>> _HostedPlayerDidAccept = new SingleAwaitSubject<Tuple<GameKit.GKMatchmakerViewController, GameKit.GKPlayer>>();
        public IObservable<Tuple<GameKit.GKMatchmakerViewController, GameKit.GKPlayer>> HostedPlayerDidAcceptObs { get { return _HostedPlayerDidAccept; } }
        public override void HostedPlayerDidAccept(GameKit.GKMatchmakerViewController viewController, GameKit.GKPlayer playerID)
        {
            _HostedPlayerDidAccept.OnNext(Tuple.Create(viewController, playerID));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKMatchmakerViewController, string>> _ReceivedAcceptFromHostedPlayer = new SingleAwaitSubject<Tuple<GameKit.GKMatchmakerViewController, string>>();
        public IObservable<Tuple<GameKit.GKMatchmakerViewController, string>> ReceivedAcceptFromHostedPlayerObs { get { return _ReceivedAcceptFromHostedPlayer; } }
        public override void ReceivedAcceptFromHostedPlayer(GameKit.GKMatchmakerViewController viewController, string playerID)
        {
            _ReceivedAcceptFromHostedPlayer.OnNext(Tuple.Create(viewController, playerID));
        }

    }
}
namespace GameplayKit.Rx
{
    public  partial class GKAgentDelegateRx : GKAgentDelegate
    {
        readonly SingleAwaitSubject<GameplayKit.GKAgent> _AgentDidUpdate = new SingleAwaitSubject<GameplayKit.GKAgent>();
        public IObservable<GameplayKit.GKAgent> AgentDidUpdateObs { get { return _AgentDidUpdate; } }
        public override void AgentDidUpdate(GameplayKit.GKAgent agent)
        {
            _AgentDidUpdate.OnNext(agent);
        }

        readonly SingleAwaitSubject<GameplayKit.GKAgent> _AgentWillUpdate = new SingleAwaitSubject<GameplayKit.GKAgent>();
        public IObservable<GameplayKit.GKAgent> AgentWillUpdateObs { get { return _AgentWillUpdate; } }
        public override void AgentWillUpdate(GameplayKit.GKAgent agent)
        {
            _AgentWillUpdate.OnNext(agent);
        }

    }
}
namespace ImageKit.Rx
{
    public  partial class IKImageBrowserDelegateRx : IKImageBrowserDelegate
    {
        readonly SingleAwaitSubject<ImageKit.IKImageBrowserView> _SelectionDidChange = new SingleAwaitSubject<ImageKit.IKImageBrowserView>();
        public IObservable<ImageKit.IKImageBrowserView> SelectionDidChangeObs { get { return _SelectionDidChange; } }
        public override void SelectionDidChange(ImageKit.IKImageBrowserView browser)
        {
            _SelectionDidChange.OnNext(browser);
        }

        readonly SingleAwaitSubject<Tuple<ImageKit.IKImageBrowserView, AppKit.NSEvent>> _BackgroundWasRightClicked = new SingleAwaitSubject<Tuple<ImageKit.IKImageBrowserView, AppKit.NSEvent>>();
        public IObservable<Tuple<ImageKit.IKImageBrowserView, AppKit.NSEvent>> BackgroundWasRightClickedObs { get { return _BackgroundWasRightClicked; } }
        public override void BackgroundWasRightClicked(ImageKit.IKImageBrowserView browser, AppKit.NSEvent nsevent)
        {
            _BackgroundWasRightClicked.OnNext(Tuple.Create(browser, nsevent));
        }

        readonly SingleAwaitSubject<Tuple<ImageKit.IKImageBrowserView, System.nint>> _CellWasDoubleClicked = new SingleAwaitSubject<Tuple<ImageKit.IKImageBrowserView, System.nint>>();
        public IObservable<Tuple<ImageKit.IKImageBrowserView, System.nint>> CellWasDoubleClickedObs { get { return _CellWasDoubleClicked; } }
        public override void CellWasDoubleClicked(ImageKit.IKImageBrowserView browser, System.nint index)
        {
            _CellWasDoubleClicked.OnNext(Tuple.Create(browser, index));
        }

        readonly SingleAwaitSubject<Tuple<ImageKit.IKImageBrowserView, System.nint, AppKit.NSEvent>> _CellWasRightClicked = new SingleAwaitSubject<Tuple<ImageKit.IKImageBrowserView, System.nint, AppKit.NSEvent>>();
        public IObservable<Tuple<ImageKit.IKImageBrowserView, System.nint, AppKit.NSEvent>> CellWasRightClickedObs { get { return _CellWasRightClicked; } }
        public override void CellWasRightClicked(ImageKit.IKImageBrowserView browser, System.nint index, AppKit.NSEvent nsevent)
        {
            _CellWasRightClicked.OnNext(Tuple.Create(browser, index, nsevent));
        }

    }
    public  partial class IKCameraDeviceViewDelegateRx : IKCameraDeviceViewDelegate
    {
        readonly SingleAwaitSubject<ImageKit.IKCameraDeviceView> _SelectionDidChange = new SingleAwaitSubject<ImageKit.IKCameraDeviceView>();
        public IObservable<ImageKit.IKCameraDeviceView> SelectionDidChangeObs { get { return _SelectionDidChange; } }
        public override void SelectionDidChange(ImageKit.IKCameraDeviceView cameraDeviceView)
        {
            _SelectionDidChange.OnNext(cameraDeviceView);
        }

        readonly SingleAwaitSubject<Tuple<ImageKit.IKCameraDeviceView, Foundation.NSError>> _DidEncounterError = new SingleAwaitSubject<Tuple<ImageKit.IKCameraDeviceView, Foundation.NSError>>();
        public IObservable<Tuple<ImageKit.IKCameraDeviceView, Foundation.NSError>> DidEncounterErrorObs { get { return _DidEncounterError; } }
        public override void DidEncounterError(ImageKit.IKCameraDeviceView cameraDeviceView, Foundation.NSError error)
        {
            _DidEncounterError.OnNext(Tuple.Create(cameraDeviceView, error));
        }

    }
    public  partial class IKDeviceBrowserViewDelegateRx : IKDeviceBrowserViewDelegate
    {
        readonly SingleAwaitSubject<Tuple<ImageKit.IKDeviceBrowserView, Foundation.NSError>> _DidEncounterError = new SingleAwaitSubject<Tuple<ImageKit.IKDeviceBrowserView, Foundation.NSError>>();
        public IObservable<Tuple<ImageKit.IKDeviceBrowserView, Foundation.NSError>> DidEncounterErrorObs { get { return _DidEncounterError; } }
        public override void DidEncounterError(ImageKit.IKDeviceBrowserView deviceBrowserView, Foundation.NSError error)
        {
            _DidEncounterError.OnNext(Tuple.Create(deviceBrowserView, error));
        }

    }
    public  partial class IKScannerDeviceViewDelegateRx : IKScannerDeviceViewDelegate
    {
        readonly SingleAwaitSubject<Tuple<ImageKit.IKScannerDeviceView, Foundation.NSError>> _DidEncounterError = new SingleAwaitSubject<Tuple<ImageKit.IKScannerDeviceView, Foundation.NSError>>();
        public IObservable<Tuple<ImageKit.IKScannerDeviceView, Foundation.NSError>> DidEncounterErrorObs { get { return _DidEncounterError; } }
        public override void DidEncounterError(ImageKit.IKScannerDeviceView scannerDeviceView, Foundation.NSError error)
        {
            _DidEncounterError.OnNext(Tuple.Create(scannerDeviceView, error));
        }

        readonly SingleAwaitSubject<Tuple<ImageKit.IKScannerDeviceView, Foundation.NSUrl, Foundation.NSData, Foundation.NSError>> _DidScan = new SingleAwaitSubject<Tuple<ImageKit.IKScannerDeviceView, Foundation.NSUrl, Foundation.NSData, Foundation.NSError>>();
        public IObservable<Tuple<ImageKit.IKScannerDeviceView, Foundation.NSUrl, Foundation.NSData, Foundation.NSError>> DidScanObs { get { return _DidScan; } }
        public override void DidScan(ImageKit.IKScannerDeviceView scannerDeviceView, Foundation.NSUrl url, Foundation.NSData data, Foundation.NSError error)
        {
            _DidScan.OnNext(Tuple.Create(scannerDeviceView, url, data, error));
        }

    }
}
namespace SpriteKit.Rx
{
    public  partial class SKSceneDelegateRx : SKSceneDelegate
    {
        readonly SingleAwaitSubject<SpriteKit.SKScene> _DidApplyConstraints = new SingleAwaitSubject<SpriteKit.SKScene>();
        public IObservable<SpriteKit.SKScene> DidApplyConstraintsObs { get { return _DidApplyConstraints; } }
        public override void DidApplyConstraints(SpriteKit.SKScene scene)
        {
            _DidApplyConstraints.OnNext(scene);
        }

        readonly SingleAwaitSubject<SpriteKit.SKScene> _DidEvaluateActions = new SingleAwaitSubject<SpriteKit.SKScene>();
        public IObservable<SpriteKit.SKScene> DidEvaluateActionsObs { get { return _DidEvaluateActions; } }
        public override void DidEvaluateActions(SpriteKit.SKScene scene)
        {
            _DidEvaluateActions.OnNext(scene);
        }

        readonly SingleAwaitSubject<SpriteKit.SKScene> _DidFinishUpdate = new SingleAwaitSubject<SpriteKit.SKScene>();
        public IObservable<SpriteKit.SKScene> DidFinishUpdateObs { get { return _DidFinishUpdate; } }
        public override void DidFinishUpdate(SpriteKit.SKScene scene)
        {
            _DidFinishUpdate.OnNext(scene);
        }

        readonly SingleAwaitSubject<SpriteKit.SKScene> _DidSimulatePhysics = new SingleAwaitSubject<SpriteKit.SKScene>();
        public IObservable<SpriteKit.SKScene> DidSimulatePhysicsObs { get { return _DidSimulatePhysics; } }
        public override void DidSimulatePhysics(SpriteKit.SKScene scene)
        {
            _DidSimulatePhysics.OnNext(scene);
        }

        readonly SingleAwaitSubject<Tuple<System.Double, SpriteKit.SKScene>> _Update = new SingleAwaitSubject<Tuple<System.Double, SpriteKit.SKScene>>();
        public IObservable<Tuple<System.Double, SpriteKit.SKScene>> UpdateObs { get { return _Update; } }
        public override void Update(System.Double currentTime, SpriteKit.SKScene scene)
        {
            _Update.OnNext(Tuple.Create(currentTime, scene));
        }

    }
    public  partial class SKPhysicsContactDelegateRx : SKPhysicsContactDelegate
    {
        readonly SingleAwaitSubject<SpriteKit.SKPhysicsContact> _DidBeginContact = new SingleAwaitSubject<SpriteKit.SKPhysicsContact>();
        public IObservable<SpriteKit.SKPhysicsContact> DidBeginContactObs { get { return _DidBeginContact; } }
        public override void DidBeginContact(SpriteKit.SKPhysicsContact contact)
        {
            _DidBeginContact.OnNext(contact);
        }

        readonly SingleAwaitSubject<SpriteKit.SKPhysicsContact> _DidEndContact = new SingleAwaitSubject<SpriteKit.SKPhysicsContact>();
        public IObservable<SpriteKit.SKPhysicsContact> DidEndContactObs { get { return _DidEndContact; } }
        public override void DidEndContact(SpriteKit.SKPhysicsContact contact)
        {
            _DidEndContact.OnNext(contact);
        }

    }
}
namespace StoreKit.Rx
{
    public abstract partial class SKProductsRequestDelegateRx : SKProductsRequestDelegate
    {
        readonly SingleAwaitSubject<Tuple<StoreKit.SKProductsRequest, StoreKit.SKProductsResponse>> _ReceivedResponse = new SingleAwaitSubject<Tuple<StoreKit.SKProductsRequest, StoreKit.SKProductsResponse>>();
        public IObservable<Tuple<StoreKit.SKProductsRequest, StoreKit.SKProductsResponse>> ReceivedResponseObs { get { return _ReceivedResponse; } }
        public override void ReceivedResponse(StoreKit.SKProductsRequest request, StoreKit.SKProductsResponse response)
        {
            _ReceivedResponse.OnNext(Tuple.Create(request, response));
        }

    }
    public  partial class SKRequestDelegateRx : SKRequestDelegate
    {
        readonly SingleAwaitSubject<StoreKit.SKRequest> _RequestFinished = new SingleAwaitSubject<StoreKit.SKRequest>();
        public IObservable<StoreKit.SKRequest> RequestFinishedObs { get { return _RequestFinished; } }
        public override void RequestFinished(StoreKit.SKRequest request)
        {
            _RequestFinished.OnNext(request);
        }

        readonly SingleAwaitSubject<Tuple<StoreKit.SKRequest, Foundation.NSError>> _RequestFailed = new SingleAwaitSubject<Tuple<StoreKit.SKRequest, Foundation.NSError>>();
        public IObservable<Tuple<StoreKit.SKRequest, Foundation.NSError>> RequestFailedObs { get { return _RequestFailed; } }
        public override void RequestFailed(StoreKit.SKRequest request, Foundation.NSError error)
        {
            _RequestFailed.OnNext(Tuple.Create(request, error));
        }

    }
}

#pragma warning restore 1591,0618,0105,0672

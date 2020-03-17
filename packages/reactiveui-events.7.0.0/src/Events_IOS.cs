#pragma warning disable 1591,0618,0105,0672

using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using ReactiveUI.Events;

using AVFoundation;
using GameKit;
using QuickLook;
using CoreFoundation;
using Foundation;
using AddressBookUI;
using AddressBook;
using AudioToolbox;
using CoreAnimation;
using CoreBluetooth;
using SceneKit;
using HomeKit;
using CoreLocation;
using MessageUI;
using UIKit;
using SpriteKit;
using CoreMidi;
using StoreKit;
using MapKit;
using ExternalAccessory;
using EventKitUI;
using MediaPlayer;
using GLKit;
using PassKit;
using iAd;
using AVFoundation;
using GameKit;
using PhotosUI;
using PushKit;
using QuickLook;
using ReplayKit;
using GameplayKit;
using SafariServices;
using AVKit;
using AddressBookUI;
using SceneKit;
using CallKit;
using CoreAnimation;
using HomeKit;
using MediaPlayer;
using UIKit;
using Speech;
using ContactsUI;
using SpriteKit;
using CoreBluetooth;
using StoreKit;
using CoreData;
using MapKit;
using CoreSpotlight;
using CoreLocation;
using Foundation;
using EventKitUI;
using ExternalAccessory;
using MessageUI;
using GLKit;
using MetalKit;
using MultipeerConnectivity;
using PassKit;
using NetworkExtension;
using UserNotifications;
using WatchConnectivity;
using VideoSubscriberAccount;
using WebKit;
using iAd;

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
        public static AVAudioSessionEvents Events(this AVAudioSession This)
        {
            return new AVAudioSessionEvents(This);
        }
        public static AVSpeechSynthesizerEvents Events(this AVSpeechSynthesizer This)
        {
            return new AVSpeechSynthesizerEvents(This);
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
    public class AVAudioSessionEvents
    {
        AVAudioSession This;

        public AVAudioSessionEvents(AVAudioSession This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> BeginInterruption {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.BeginInterruption += x, x => This.BeginInterruption -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EndInterruption {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EndInterruption += x, x => This.EndInterruption -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AVFoundation.AVCategoryEventArgs> CategoryChanged {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVCategoryEventArgs>, AVFoundation.AVCategoryEventArgs>(x => This.CategoryChanged += x, x => This.CategoryChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AVFoundation.AVStatusEventArgs> InputAvailabilityChanged {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVStatusEventArgs>, AVFoundation.AVStatusEventArgs>(x => This.InputAvailabilityChanged += x, x => This.InputAvailabilityChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AVFoundation.AVSampleRateEventArgs> SampleRateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVSampleRateEventArgs>, AVFoundation.AVSampleRateEventArgs>(x => This.SampleRateChanged += x, x => This.SampleRateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AVFoundation.AVChannelsEventArgs> InputChannelsChanged {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVChannelsEventArgs>, AVFoundation.AVChannelsEventArgs>(x => This.InputChannelsChanged += x, x => This.InputChannelsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AVFoundation.AVChannelsEventArgs> OutputChannelsChanged {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVChannelsEventArgs>, AVFoundation.AVChannelsEventArgs>(x => This.OutputChannelsChanged += x, x => This.OutputChannelsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class AVSpeechSynthesizerEvents
    {
        AVSpeechSynthesizer This;

        public AVSpeechSynthesizerEvents(AVSpeechSynthesizer This)
        {
            this.This = This;
        }

        public IObservable<AVFoundation.AVSpeechSynthesizerUteranceEventArgs> DidCancelSpeechUtterance {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVSpeechSynthesizerUteranceEventArgs>, AVFoundation.AVSpeechSynthesizerUteranceEventArgs>(x => This.DidCancelSpeechUtterance += x, x => This.DidCancelSpeechUtterance -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AVFoundation.AVSpeechSynthesizerUteranceEventArgs> DidContinueSpeechUtterance {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVSpeechSynthesizerUteranceEventArgs>, AVFoundation.AVSpeechSynthesizerUteranceEventArgs>(x => This.DidContinueSpeechUtterance += x, x => This.DidContinueSpeechUtterance -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AVFoundation.AVSpeechSynthesizerUteranceEventArgs> DidFinishSpeechUtterance {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVSpeechSynthesizerUteranceEventArgs>, AVFoundation.AVSpeechSynthesizerUteranceEventArgs>(x => This.DidFinishSpeechUtterance += x, x => This.DidFinishSpeechUtterance -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AVFoundation.AVSpeechSynthesizerUteranceEventArgs> DidPauseSpeechUtterance {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVSpeechSynthesizerUteranceEventArgs>, AVFoundation.AVSpeechSynthesizerUteranceEventArgs>(x => This.DidPauseSpeechUtterance += x, x => This.DidPauseSpeechUtterance -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AVFoundation.AVSpeechSynthesizerUteranceEventArgs> DidStartSpeechUtterance {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVSpeechSynthesizerUteranceEventArgs>, AVFoundation.AVSpeechSynthesizerUteranceEventArgs>(x => This.DidStartSpeechUtterance += x, x => This.DidStartSpeechUtterance -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AVFoundation.AVSpeechSynthesizerWillSpeakEventArgs> WillSpeakRangeOfSpeechString {
            get { return Observable.FromEventPattern<System.EventHandler<AVFoundation.AVSpeechSynthesizerWillSpeakEventArgs>, AVFoundation.AVSpeechSynthesizerWillSpeakEventArgs>(x => This.WillSpeakRangeOfSpeechString += x, x => This.WillSpeakRangeOfSpeechString -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace GameKit
{
    public static class EventsMixin
    {
        public static GKMatchmakerViewControllerEvents Events(this GKMatchmakerViewController This)
        {
            return new GKMatchmakerViewControllerEvents(This);
        }
        public static GKSessionEvents Events(this GKSession This)
        {
            return new GKSessionEvents(This);
        }
        public static GKMatchEvents Events(this GKMatch This)
        {
            return new GKMatchEvents(This);
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
        public static GKAchievementViewControllerEvents Events(this GKAchievementViewController This)
        {
            return new GKAchievementViewControllerEvents(This);
        }
        public static GKChallengeEventHandlerEvents Events(this GKChallengeEventHandler This)
        {
            return new GKChallengeEventHandlerEvents(This);
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
    public class GKSessionEvents
    {
        GKSession This;

        public GKSessionEvents(GKSession This)
        {
            this.This = This;
        }

        public IObservable<GameKit.GKDataReceivedEventArgs> ReceiveData {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKDataReceivedEventArgs>, GameKit.GKDataReceivedEventArgs>(x => This.ReceiveData += x, x => This.ReceiveData -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKPeerChangedStateEventArgs> PeerChanged {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKPeerChangedStateEventArgs>, GameKit.GKPeerChangedStateEventArgs>(x => This.PeerChanged += x, x => This.PeerChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKPeerConnectionEventArgs> ConnectionRequest {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKPeerConnectionEventArgs>, GameKit.GKPeerConnectionEventArgs>(x => This.ConnectionRequest += x, x => This.ConnectionRequest -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKPeerConnectionEventArgs> ConnectionFailed {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKPeerConnectionEventArgs>, GameKit.GKPeerConnectionEventArgs>(x => This.ConnectionFailed += x, x => This.ConnectionFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<GameKit.GKPeerConnectionEventArgs> Failed {
            get { return Observable.FromEventPattern<System.EventHandler<GameKit.GKPeerConnectionEventArgs>, GameKit.GKPeerConnectionEventArgs>(x => This.Failed += x, x => This.Failed -= x).Select(x => x.EventArgs); }
        }

    }
    public class GKMatchEvents
    {
        GKMatch This;

        public GKMatchEvents(GKMatch This)
        {
            this.This = This;
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
    public class GKChallengeEventHandlerEvents
    {
        GKChallengeEventHandler This;

        public GKChallengeEventHandlerEvents(GKChallengeEventHandler This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> LocalPlayerCompletedChallenge {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LocalPlayerCompletedChallenge += x, x => This.LocalPlayerCompletedChallenge -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> LocalPlayerReceivedChallenge {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LocalPlayerReceivedChallenge += x, x => This.LocalPlayerReceivedChallenge -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> LocalPlayerSelectedChallenge {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LocalPlayerSelectedChallenge += x, x => This.LocalPlayerSelectedChallenge -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> RemotePlayerCompletedChallenge {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.RemotePlayerCompletedChallenge += x, x => This.RemotePlayerCompletedChallenge -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace QuickLook
{
    public static class EventsMixin
    {
        public static QLPreviewControllerEvents Events(this QLPreviewController This)
        {
            return new QLPreviewControllerEvents(This);
        }
    }

    public class QLPreviewControllerEvents
    {
        QLPreviewController This;

        public QLPreviewControllerEvents(QLPreviewController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidDismiss {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidDismiss += x, x => This.DidDismiss -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillDismiss {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillDismiss += x, x => This.WillDismiss -= x).Select(x => x.EventArgs); }
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
}
namespace AddressBookUI
{
    public static class EventsMixin
    {
        public static ABNewPersonViewControllerEvents Events(this ABNewPersonViewController This)
        {
            return new ABNewPersonViewControllerEvents(This);
        }
        public static ABPeoplePickerNavigationControllerEvents Events(this ABPeoplePickerNavigationController This)
        {
            return new ABPeoplePickerNavigationControllerEvents(This);
        }
        public static ABPersonViewControllerEvents Events(this ABPersonViewController This)
        {
            return new ABPersonViewControllerEvents(This);
        }
        public static ABUnknownPersonViewControllerEvents Events(this ABUnknownPersonViewController This)
        {
            return new ABUnknownPersonViewControllerEvents(This);
        }
    }

    public class ABNewPersonViewControllerEvents
    {
        ABNewPersonViewController This;

        public ABNewPersonViewControllerEvents(ABNewPersonViewController This)
        {
            this.This = This;
        }

        public IObservable<AddressBookUI.ABNewPersonCompleteEventArgs> NewPersonComplete {
            get { return Observable.FromEventPattern<System.EventHandler<AddressBookUI.ABNewPersonCompleteEventArgs>, AddressBookUI.ABNewPersonCompleteEventArgs>(x => This.NewPersonComplete += x, x => This.NewPersonComplete -= x).Select(x => x.EventArgs); }
        }

    }
    public class ABPeoplePickerNavigationControllerEvents
    {
        ABPeoplePickerNavigationController This;

        public ABPeoplePickerNavigationControllerEvents(ABPeoplePickerNavigationController This)
        {
            this.This = This;
        }

        public IObservable<AddressBookUI.ABPeoplePickerSelectPersonEventArgs> SelectPerson {
            get { return Observable.FromEventPattern<System.EventHandler<AddressBookUI.ABPeoplePickerSelectPersonEventArgs>, AddressBookUI.ABPeoplePickerSelectPersonEventArgs>(x => This.SelectPerson += x, x => This.SelectPerson -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AddressBookUI.ABPeoplePickerSelectPerson2EventArgs> SelectPerson2 {
            get { return Observable.FromEventPattern<System.EventHandler<AddressBookUI.ABPeoplePickerSelectPerson2EventArgs>, AddressBookUI.ABPeoplePickerSelectPerson2EventArgs>(x => This.SelectPerson2 += x, x => This.SelectPerson2 -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AddressBookUI.ABPeoplePickerPerformActionEventArgs> PerformAction {
            get { return Observable.FromEventPattern<System.EventHandler<AddressBookUI.ABPeoplePickerPerformActionEventArgs>, AddressBookUI.ABPeoplePickerPerformActionEventArgs>(x => This.PerformAction += x, x => This.PerformAction -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AddressBookUI.ABPeoplePickerPerformAction2EventArgs> PerformAction2 {
            get { return Observable.FromEventPattern<System.EventHandler<AddressBookUI.ABPeoplePickerPerformAction2EventArgs>, AddressBookUI.ABPeoplePickerPerformAction2EventArgs>(x => This.PerformAction2 += x, x => This.PerformAction2 -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Cancelled {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Cancelled += x, x => This.Cancelled -= x).Select(x => x.EventArgs); }
        }

    }
    public class ABPersonViewControllerEvents
    {
        ABPersonViewController This;

        public ABPersonViewControllerEvents(ABPersonViewController This)
        {
            this.This = This;
        }

        public IObservable<AddressBookUI.ABPersonViewPerformDefaultActionEventArgs> PerformDefaultAction {
            get { return Observable.FromEventPattern<System.EventHandler<AddressBookUI.ABPersonViewPerformDefaultActionEventArgs>, AddressBookUI.ABPersonViewPerformDefaultActionEventArgs>(x => This.PerformDefaultAction += x, x => This.PerformDefaultAction -= x).Select(x => x.EventArgs); }
        }

    }
    public class ABUnknownPersonViewControllerEvents
    {
        ABUnknownPersonViewController This;

        public ABUnknownPersonViewControllerEvents(ABUnknownPersonViewController This)
        {
            this.This = This;
        }

        public IObservable<AddressBookUI.ABPersonViewPerformDefaultActionEventArgs> PerformDefaultAction {
            get { return Observable.FromEventPattern<System.EventHandler<AddressBookUI.ABPersonViewPerformDefaultActionEventArgs>, AddressBookUI.ABPersonViewPerformDefaultActionEventArgs>(x => This.PerformDefaultAction += x, x => This.PerformDefaultAction -= x).Select(x => x.EventArgs); }
        }

        public IObservable<AddressBookUI.ABUnknownPersonCreatedEventArgs> PersonCreated {
            get { return Observable.FromEventPattern<System.EventHandler<AddressBookUI.ABUnknownPersonCreatedEventArgs>, AddressBookUI.ABUnknownPersonCreatedEventArgs>(x => This.PersonCreated += x, x => This.PersonCreated -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace AddressBook
{
    public static class EventsMixin
    {
        public static ABAddressBookEvents Events(this ABAddressBook This)
        {
            return new ABAddressBookEvents(This);
        }
    }

    public class ABAddressBookEvents
    {
        ABAddressBook This;

        public ABAddressBookEvents(ABAddressBook This)
        {
            this.This = This;
        }

        public IObservable<AddressBook.ExternalChangeEventArgs> ExternalChange {
            get { return Observable.FromEventPattern<System.EventHandler<AddressBook.ExternalChangeEventArgs>, AddressBook.ExternalChangeEventArgs>(x => This.ExternalChange += x, x => This.ExternalChange -= x).Select(x => x.EventArgs); }
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
        public static CBPeripheralManagerEvents Events(this CBPeripheralManager This)
        {
            return new CBPeripheralManagerEvents(This);
        }
        public static CBPeripheralEvents Events(this CBPeripheral This)
        {
            return new CBPeripheralEvents(This);
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
namespace HomeKit
{
    public static class EventsMixin
    {
        public static HMAccessoryEvents Events(this HMAccessory This)
        {
            return new HMAccessoryEvents(This);
        }
        public static HMAccessoryBrowserEvents Events(this HMAccessoryBrowser This)
        {
            return new HMAccessoryBrowserEvents(This);
        }
        public static HMHomeEvents Events(this HMHome This)
        {
            return new HMHomeEvents(This);
        }
        public static HMHomeManagerEvents Events(this HMHomeManager This)
        {
            return new HMHomeManagerEvents(This);
        }
    }

    public class HMAccessoryEvents
    {
        HMAccessory This;

        public HMAccessoryEvents(HMAccessory This)
        {
            this.This = This;
        }

        public IObservable<HomeKit.HMAccessoryUpdateEventArgs> DidUpdateAssociatedServiceType {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMAccessoryUpdateEventArgs>, HomeKit.HMAccessoryUpdateEventArgs>(x => This.DidUpdateAssociatedServiceType += x, x => This.DidUpdateAssociatedServiceType -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidUpdateName {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidUpdateName += x, x => This.DidUpdateName -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMAccessoryUpdateEventArgs> DidUpdateNameForService {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMAccessoryUpdateEventArgs>, HomeKit.HMAccessoryUpdateEventArgs>(x => This.DidUpdateNameForService += x, x => This.DidUpdateNameForService -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidUpdateReachability {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidUpdateReachability += x, x => This.DidUpdateReachability -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidUpdateServices {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidUpdateServices += x, x => This.DidUpdateServices -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMAccessoryServiceUpdateCharacteristicEventArgs> DidUpdateValueForCharacteristic {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMAccessoryServiceUpdateCharacteristicEventArgs>, HomeKit.HMAccessoryServiceUpdateCharacteristicEventArgs>(x => This.DidUpdateValueForCharacteristic += x, x => This.DidUpdateValueForCharacteristic -= x).Select(x => x.EventArgs); }
        }

    }
    public class HMAccessoryBrowserEvents
    {
        HMAccessoryBrowser This;

        public HMAccessoryBrowserEvents(HMAccessoryBrowser This)
        {
            this.This = This;
        }

        public IObservable<HomeKit.HMAccessoryBrowserEventArgs> DidFindNewAccessory {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMAccessoryBrowserEventArgs>, HomeKit.HMAccessoryBrowserEventArgs>(x => This.DidFindNewAccessory += x, x => This.DidFindNewAccessory -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMAccessoryBrowserEventArgs> DidRemoveNewAccessory {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMAccessoryBrowserEventArgs>, HomeKit.HMAccessoryBrowserEventArgs>(x => This.DidRemoveNewAccessory += x, x => This.DidRemoveNewAccessory -= x).Select(x => x.EventArgs); }
        }

    }
    public class HMHomeEvents
    {
        HMHome This;

        public HMHomeEvents(HMHome This)
        {
            this.This = This;
        }

        public IObservable<HomeKit.HMHomeAccessoryEventArgs> DidAddAccessory {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeAccessoryEventArgs>, HomeKit.HMHomeAccessoryEventArgs>(x => This.DidAddAccessory += x, x => This.DidAddAccessory -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeActionSetEventArgs> DidAddActionSet {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeActionSetEventArgs>, HomeKit.HMHomeActionSetEventArgs>(x => This.DidAddActionSet += x, x => This.DidAddActionSet -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeRoomEventArgs> DidAddRoom {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeRoomEventArgs>, HomeKit.HMHomeRoomEventArgs>(x => This.DidAddRoom += x, x => This.DidAddRoom -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeRoomZoneEventArgs> DidAddRoomToZone {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeRoomZoneEventArgs>, HomeKit.HMHomeRoomZoneEventArgs>(x => This.DidAddRoomToZone += x, x => This.DidAddRoomToZone -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeServiceServiceGroupEventArgs> DidAddService {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeServiceServiceGroupEventArgs>, HomeKit.HMHomeServiceServiceGroupEventArgs>(x => This.DidAddService += x, x => This.DidAddService -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeServiceGroupEventArgs> DidAddServiceGroup {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeServiceGroupEventArgs>, HomeKit.HMHomeServiceGroupEventArgs>(x => This.DidAddServiceGroup += x, x => This.DidAddServiceGroup -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeTriggerEventArgs> DidAddTrigger {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeTriggerEventArgs>, HomeKit.HMHomeTriggerEventArgs>(x => This.DidAddTrigger += x, x => This.DidAddTrigger -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeUserEventArgs> DidAddUser {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeUserEventArgs>, HomeKit.HMHomeUserEventArgs>(x => This.DidAddUser += x, x => This.DidAddUser -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeZoneEventArgs> DidAddZone {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeZoneEventArgs>, HomeKit.HMHomeZoneEventArgs>(x => This.DidAddZone += x, x => This.DidAddZone -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeErrorAccessoryEventArgs> DidEncounterError {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeErrorAccessoryEventArgs>, HomeKit.HMHomeErrorAccessoryEventArgs>(x => This.DidEncounterError += x, x => This.DidEncounterError -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeAccessoryEventArgs> DidRemoveAccessory {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeAccessoryEventArgs>, HomeKit.HMHomeAccessoryEventArgs>(x => This.DidRemoveAccessory += x, x => This.DidRemoveAccessory -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeActionSetEventArgs> DidRemoveActionSet {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeActionSetEventArgs>, HomeKit.HMHomeActionSetEventArgs>(x => This.DidRemoveActionSet += x, x => This.DidRemoveActionSet -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeRoomEventArgs> DidRemoveRoom {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeRoomEventArgs>, HomeKit.HMHomeRoomEventArgs>(x => This.DidRemoveRoom += x, x => This.DidRemoveRoom -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeRoomZoneEventArgs> DidRemoveRoomFromZone {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeRoomZoneEventArgs>, HomeKit.HMHomeRoomZoneEventArgs>(x => This.DidRemoveRoomFromZone += x, x => This.DidRemoveRoomFromZone -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeServiceServiceGroupEventArgs> DidRemoveService {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeServiceServiceGroupEventArgs>, HomeKit.HMHomeServiceServiceGroupEventArgs>(x => This.DidRemoveService += x, x => This.DidRemoveService -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeServiceGroupEventArgs> DidRemoveServiceGroup {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeServiceGroupEventArgs>, HomeKit.HMHomeServiceGroupEventArgs>(x => This.DidRemoveServiceGroup += x, x => This.DidRemoveServiceGroup -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeTriggerEventArgs> DidRemoveTrigger {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeTriggerEventArgs>, HomeKit.HMHomeTriggerEventArgs>(x => This.DidRemoveTrigger += x, x => This.DidRemoveTrigger -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeUserEventArgs> DidRemoveUser {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeUserEventArgs>, HomeKit.HMHomeUserEventArgs>(x => This.DidRemoveUser += x, x => This.DidRemoveUser -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeZoneEventArgs> DidRemoveZone {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeZoneEventArgs>, HomeKit.HMHomeZoneEventArgs>(x => This.DidRemoveZone += x, x => This.DidRemoveZone -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeAccessoryEventArgs> DidUnblockAccessory {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeAccessoryEventArgs>, HomeKit.HMHomeAccessoryEventArgs>(x => This.DidUnblockAccessory += x, x => This.DidUnblockAccessory -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeActionSetEventArgs> DidUpdateActionsForActionSet {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeActionSetEventArgs>, HomeKit.HMHomeActionSetEventArgs>(x => This.DidUpdateActionsForActionSet += x, x => This.DidUpdateActionsForActionSet -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeActionSetEventArgs> DidUpdateNameForActionSet {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeActionSetEventArgs>, HomeKit.HMHomeActionSetEventArgs>(x => This.DidUpdateNameForActionSet += x, x => This.DidUpdateNameForActionSet -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidUpdateNameForHome {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidUpdateNameForHome += x, x => This.DidUpdateNameForHome -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeRoomEventArgs> DidUpdateNameForRoom {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeRoomEventArgs>, HomeKit.HMHomeRoomEventArgs>(x => This.DidUpdateNameForRoom += x, x => This.DidUpdateNameForRoom -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeServiceGroupEventArgs> DidUpdateNameForServiceGroup {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeServiceGroupEventArgs>, HomeKit.HMHomeServiceGroupEventArgs>(x => This.DidUpdateNameForServiceGroup += x, x => This.DidUpdateNameForServiceGroup -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeTriggerEventArgs> DidUpdateNameForTrigger {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeTriggerEventArgs>, HomeKit.HMHomeTriggerEventArgs>(x => This.DidUpdateNameForTrigger += x, x => This.DidUpdateNameForTrigger -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeZoneEventArgs> DidUpdateNameForZone {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeZoneEventArgs>, HomeKit.HMHomeZoneEventArgs>(x => This.DidUpdateNameForZone += x, x => This.DidUpdateNameForZone -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeRoomAccessoryEventArgs> DidUpdateRoom {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeRoomAccessoryEventArgs>, HomeKit.HMHomeRoomAccessoryEventArgs>(x => This.DidUpdateRoom += x, x => This.DidUpdateRoom -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeTriggerEventArgs> DidUpdateTrigger {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeTriggerEventArgs>, HomeKit.HMHomeTriggerEventArgs>(x => This.DidUpdateTrigger += x, x => This.DidUpdateTrigger -= x).Select(x => x.EventArgs); }
        }

    }
    public class HMHomeManagerEvents
    {
        HMHomeManager This;

        public HMHomeManagerEvents(HMHomeManager This)
        {
            this.This = This;
        }

        public IObservable<HomeKit.HMHomeManagerEventArgs> DidAddHome {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeManagerEventArgs>, HomeKit.HMHomeManagerEventArgs>(x => This.DidAddHome += x, x => This.DidAddHome -= x).Select(x => x.EventArgs); }
        }

        public IObservable<HomeKit.HMHomeManagerEventArgs> DidRemoveHome {
            get { return Observable.FromEventPattern<System.EventHandler<HomeKit.HMHomeManagerEventArgs>, HomeKit.HMHomeManagerEventArgs>(x => This.DidRemoveHome += x, x => This.DidRemoveHome -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidUpdateHomes {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidUpdateHomes += x, x => This.DidUpdateHomes -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidUpdatePrimaryHome {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidUpdatePrimaryHome += x, x => This.DidUpdatePrimaryHome -= x).Select(x => x.EventArgs); }
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

        public IObservable<CoreLocation.CLRegionBeaconsRangedEventArgs> DidRangeBeacons {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLRegionBeaconsRangedEventArgs>, CoreLocation.CLRegionBeaconsRangedEventArgs>(x => This.DidRangeBeacons += x, x => This.DidRangeBeacons -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLRegionEventArgs> DidStartMonitoringForRegion {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLRegionEventArgs>, CoreLocation.CLRegionEventArgs>(x => This.DidStartMonitoringForRegion += x, x => This.DidStartMonitoringForRegion -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLVisitedEventArgs> DidVisit {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLVisitedEventArgs>, CoreLocation.CLVisitedEventArgs>(x => This.DidVisit += x, x => This.DidVisit -= x).Select(x => x.EventArgs); }
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

        public IObservable<CoreLocation.CLRegionBeaconsFailedEventArgs> RangingBeaconsDidFailForRegion {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLRegionBeaconsFailedEventArgs>, CoreLocation.CLRegionBeaconsFailedEventArgs>(x => This.RangingBeaconsDidFailForRegion += x, x => This.RangingBeaconsDidFailForRegion -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLRegionEventArgs> RegionEntered {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLRegionEventArgs>, CoreLocation.CLRegionEventArgs>(x => This.RegionEntered += x, x => This.RegionEntered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLRegionEventArgs> RegionLeft {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLRegionEventArgs>, CoreLocation.CLRegionEventArgs>(x => This.RegionLeft += x, x => This.RegionLeft -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLHeadingUpdatedEventArgs> UpdatedHeading {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLHeadingUpdatedEventArgs>, CoreLocation.CLHeadingUpdatedEventArgs>(x => This.UpdatedHeading += x, x => This.UpdatedHeading -= x).Select(x => x.EventArgs); }
        }

        public IObservable<CoreLocation.CLLocationUpdatedEventArgs> UpdatedLocation {
            get { return Observable.FromEventPattern<System.EventHandler<CoreLocation.CLLocationUpdatedEventArgs>, CoreLocation.CLLocationUpdatedEventArgs>(x => This.UpdatedLocation += x, x => This.UpdatedLocation -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace MessageUI
{
    public static class EventsMixin
    {
        public static MFMailComposeViewControllerEvents Events(this MFMailComposeViewController This)
        {
            return new MFMailComposeViewControllerEvents(This);
        }
        public static MFMessageComposeViewControllerEvents Events(this MFMessageComposeViewController This)
        {
            return new MFMessageComposeViewControllerEvents(This);
        }
    }

    public class MFMailComposeViewControllerEvents
    {
        MFMailComposeViewController This;

        public MFMailComposeViewControllerEvents(MFMailComposeViewController This)
        {
            this.This = This;
        }

        public IObservable<MessageUI.MFComposeResultEventArgs> Finished {
            get { return Observable.FromEventPattern<System.EventHandler<MessageUI.MFComposeResultEventArgs>, MessageUI.MFComposeResultEventArgs>(x => This.Finished += x, x => This.Finished -= x).Select(x => x.EventArgs); }
        }

    }
    public class MFMessageComposeViewControllerEvents
    {
        MFMessageComposeViewController This;

        public MFMessageComposeViewControllerEvents(MFMessageComposeViewController This)
        {
            this.This = This;
        }

        public IObservable<MessageUI.MFMessageComposeResultEventArgs> Finished {
            get { return Observable.FromEventPattern<System.EventHandler<MessageUI.MFMessageComposeResultEventArgs>, MessageUI.MFMessageComposeResultEventArgs>(x => This.Finished += x, x => This.Finished -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace UIKit
{
    public static class EventsMixin
    {
        public static UIActionSheetEvents Events(this UIActionSheet This)
        {
            return new UIActionSheetEvents(This);
        }
        public static UIAlertViewEvents Events(this UIAlertView This)
        {
            return new UIAlertViewEvents(This);
        }
        public static UIBarButtonItemEvents Events(this UIBarButtonItem This)
        {
            return new UIBarButtonItemEvents(This);
        }
        public static UIControlEvents Events(this UIControl This)
        {
            return new UIControlEvents(This);
        }
        public static UIDocumentMenuViewControllerEvents Events(this UIDocumentMenuViewController This)
        {
            return new UIDocumentMenuViewControllerEvents(This);
        }
        public static UIDocumentPickerViewControllerEvents Events(this UIDocumentPickerViewController This)
        {
            return new UIDocumentPickerViewControllerEvents(This);
        }
        public static UIPopoverControllerEvents Events(this UIPopoverController This)
        {
            return new UIPopoverControllerEvents(This);
        }
        public static UIPopoverPresentationControllerEvents Events(this UIPopoverPresentationController This)
        {
            return new UIPopoverPresentationControllerEvents(This);
        }
        public static UISearchBarEvents Events(this UISearchBar This)
        {
            return new UISearchBarEvents(This);
        }
        public static UITextFieldEvents Events(this UITextField This)
        {
            return new UITextFieldEvents(This);
        }
        public static UITextViewEvents Events(this UITextView This)
        {
            return new UITextViewEvents(This);
        }
        public static UIImagePickerControllerEvents Events(this UIImagePickerController This)
        {
            return new UIImagePickerControllerEvents(This);
        }
        public static UIPageViewControllerEvents Events(this UIPageViewController This)
        {
            return new UIPageViewControllerEvents(This);
        }
        public static UIPrintInteractionControllerEvents Events(this UIPrintInteractionController This)
        {
            return new UIPrintInteractionControllerEvents(This);
        }
        public static NSTextStorageEvents Events(this NSTextStorage This)
        {
            return new NSTextStorageEvents(This);
        }
        public static UIAccelerometerEvents Events(this UIAccelerometer This)
        {
            return new UIAccelerometerEvents(This);
        }
        public static UICollisionBehaviorEvents Events(this UICollisionBehavior This)
        {
            return new UICollisionBehaviorEvents(This);
        }
        public static UIDocumentInteractionControllerEvents Events(this UIDocumentInteractionController This)
        {
            return new UIDocumentInteractionControllerEvents(This);
        }
        public static UIScrollViewEvents Events(this UIScrollView This)
        {
            return new UIScrollViewEvents(This);
        }
        public static UIPreviewInteractionEvents Events(this UIPreviewInteraction This)
        {
            return new UIPreviewInteractionEvents(This);
        }
        public static UITabBarEvents Events(this UITabBar This)
        {
            return new UITabBarEvents(This);
        }
        public static UITabBarControllerEvents Events(this UITabBarController This)
        {
            return new UITabBarControllerEvents(This);
        }
        public static UISplitViewControllerEvents Events(this UISplitViewController This)
        {
            return new UISplitViewControllerEvents(This);
        }
        public static UIVideoEditorControllerEvents Events(this UIVideoEditorController This)
        {
            return new UIVideoEditorControllerEvents(This);
        }
        public static UIWebViewEvents Events(this UIWebView This)
        {
            return new UIWebViewEvents(This);
        }
    }

    public class UIActionSheetEvents
    {
        UIActionSheet This;

        public UIActionSheetEvents(UIActionSheet This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Canceled {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Canceled += x, x => This.Canceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIButtonEventArgs> Clicked {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIButtonEventArgs>, UIKit.UIButtonEventArgs>(x => This.Clicked += x, x => This.Clicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIButtonEventArgs> Dismissed {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIButtonEventArgs>, UIKit.UIButtonEventArgs>(x => This.Dismissed += x, x => This.Dismissed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Presented {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Presented += x, x => This.Presented -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIButtonEventArgs> WillDismiss {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIButtonEventArgs>, UIKit.UIButtonEventArgs>(x => This.WillDismiss += x, x => This.WillDismiss -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillPresent {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillPresent += x, x => This.WillPresent -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIAlertViewEvents
    {
        UIAlertView This;

        public UIAlertViewEvents(UIAlertView This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Canceled {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Canceled += x, x => This.Canceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIButtonEventArgs> Clicked {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIButtonEventArgs>, UIKit.UIButtonEventArgs>(x => This.Clicked += x, x => This.Clicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIButtonEventArgs> Dismissed {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIButtonEventArgs>, UIKit.UIButtonEventArgs>(x => This.Dismissed += x, x => This.Dismissed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Presented {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Presented += x, x => This.Presented -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIButtonEventArgs> WillDismiss {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIButtonEventArgs>, UIKit.UIButtonEventArgs>(x => This.WillDismiss += x, x => This.WillDismiss -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillPresent {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillPresent += x, x => This.WillPresent -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIBarButtonItemEvents
    {
        UIBarButtonItem This;

        public UIBarButtonItemEvents(UIBarButtonItem This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Clicked {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Clicked += x, x => This.Clicked -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIControlEvents
    {
        UIControl This;

        public UIControlEvents(UIControl This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> TouchDown {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TouchDown += x, x => This.TouchDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TouchDownRepeat {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TouchDownRepeat += x, x => This.TouchDownRepeat -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TouchDragInside {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TouchDragInside += x, x => This.TouchDragInside -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TouchDragOutside {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TouchDragOutside += x, x => This.TouchDragOutside -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TouchDragEnter {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TouchDragEnter += x, x => This.TouchDragEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TouchDragExit {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TouchDragExit += x, x => This.TouchDragExit -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TouchUpInside {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TouchUpInside += x, x => This.TouchUpInside -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TouchUpOutside {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TouchUpOutside += x, x => This.TouchUpOutside -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> TouchCancel {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.TouchCancel += x, x => This.TouchCancel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ValueChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PrimaryActionTriggered {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PrimaryActionTriggered += x, x => This.PrimaryActionTriggered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EditingDidBegin {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EditingDidBegin += x, x => This.EditingDidBegin -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EditingChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EditingChanged += x, x => This.EditingChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EditingDidEnd {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EditingDidEnd += x, x => This.EditingDidEnd -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EditingDidEndOnExit {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EditingDidEndOnExit += x, x => This.EditingDidEndOnExit -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> AllTouchEvents {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AllTouchEvents += x, x => This.AllTouchEvents -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> AllEditingEvents {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AllEditingEvents += x, x => This.AllEditingEvents -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> AllEvents {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AllEvents += x, x => This.AllEvents -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIDocumentMenuViewControllerEvents
    {
        UIDocumentMenuViewController This;

        public UIDocumentMenuViewControllerEvents(UIDocumentMenuViewController This)
        {
            this.This = This;
        }

        public IObservable<UIKit.UIDocumentMenuDocumentPickedEventArgs> DidPickDocumentPicker {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIDocumentMenuDocumentPickedEventArgs>, UIKit.UIDocumentMenuDocumentPickedEventArgs>(x => This.DidPickDocumentPicker += x, x => This.DidPickDocumentPicker -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WasCancelled {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WasCancelled += x, x => This.WasCancelled -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIDocumentPickerViewControllerEvents
    {
        UIDocumentPickerViewController This;

        public UIDocumentPickerViewControllerEvents(UIDocumentPickerViewController This)
        {
            this.This = This;
        }

        public IObservable<UIKit.UIDocumentPickedEventArgs> DidPickDocument {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIDocumentPickedEventArgs>, UIKit.UIDocumentPickedEventArgs>(x => This.DidPickDocument += x, x => This.DidPickDocument -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WasCancelled {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WasCancelled += x, x => This.WasCancelled -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIPopoverControllerEvents
    {
        UIPopoverController This;

        public UIPopoverControllerEvents(UIPopoverController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidDismiss {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidDismiss += x, x => This.DidDismiss -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIPopoverControllerRepositionEventArgs> WillReposition {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIPopoverControllerRepositionEventArgs>, UIKit.UIPopoverControllerRepositionEventArgs>(x => This.WillReposition += x, x => This.WillReposition -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIPopoverPresentationControllerEvents
    {
        UIPopoverPresentationController This;

        public UIPopoverPresentationControllerEvents(UIPopoverPresentationController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidDismiss {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidDismiss += x, x => This.DidDismiss -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PrepareForPresentation {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PrepareForPresentation += x, x => This.PrepareForPresentation -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIPopoverPresentationControllerRepositionEventArgs> WillReposition {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIPopoverPresentationControllerRepositionEventArgs>, UIKit.UIPopoverPresentationControllerRepositionEventArgs>(x => This.WillReposition += x, x => This.WillReposition -= x).Select(x => x.EventArgs); }
        }

    }
    public class UISearchBarEvents
    {
        UISearchBar This;

        public UISearchBarEvents(UISearchBar This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> BookmarkButtonClicked {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.BookmarkButtonClicked += x, x => This.BookmarkButtonClicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> CancelButtonClicked {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CancelButtonClicked += x, x => This.CancelButtonClicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ListButtonClicked {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ListButtonClicked += x, x => This.ListButtonClicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> OnEditingStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.OnEditingStarted += x, x => This.OnEditingStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> OnEditingStopped {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.OnEditingStopped += x, x => This.OnEditingStopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SearchButtonClicked {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SearchButtonClicked += x, x => This.SearchButtonClicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UISearchBarButtonIndexEventArgs> SelectedScopeButtonIndexChanged {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UISearchBarButtonIndexEventArgs>, UIKit.UISearchBarButtonIndexEventArgs>(x => This.SelectedScopeButtonIndexChanged += x, x => This.SelectedScopeButtonIndexChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UISearchBarTextChangedEventArgs> TextChanged {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UISearchBarTextChangedEventArgs>, UIKit.UISearchBarTextChangedEventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class UITextFieldEvents
        : UIKit.UIControlEvents
    {
        UITextField This;

        public UITextFieldEvents(UITextField This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Ended {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Ended += x, x => This.Ended -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Started {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Started += x, x => This.Started -= x).Select(x => x.EventArgs); }
        }

    }
    public class UITextViewEvents
        : UIKit.UIScrollViewEvents
    {
        UITextView This;

        public UITextViewEvents(UITextView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Changed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Changed += x, x => This.Changed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Ended {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Ended += x, x => This.Ended -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Started {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Started += x, x => This.Started -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIImagePickerControllerEvents
    {
        UIImagePickerController This;

        public UIImagePickerControllerEvents(UIImagePickerController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Canceled {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Canceled += x, x => This.Canceled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIImagePickerImagePickedEventArgs> FinishedPickingImage {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIImagePickerImagePickedEventArgs>, UIKit.UIImagePickerImagePickedEventArgs>(x => This.FinishedPickingImage += x, x => This.FinishedPickingImage -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIImagePickerMediaPickedEventArgs> FinishedPickingMedia {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIImagePickerMediaPickedEventArgs>, UIKit.UIImagePickerMediaPickedEventArgs>(x => This.FinishedPickingMedia += x, x => This.FinishedPickingMedia -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIPageViewControllerEvents
    {
        UIPageViewController This;

        public UIPageViewControllerEvents(UIPageViewController This)
        {
            this.This = This;
        }

        public IObservable<UIKit.UIPageViewFinishedAnimationEventArgs> DidFinishAnimating {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIPageViewFinishedAnimationEventArgs>, UIKit.UIPageViewFinishedAnimationEventArgs>(x => This.DidFinishAnimating += x, x => This.DidFinishAnimating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIPageViewControllerTransitionEventArgs> WillTransition {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIPageViewControllerTransitionEventArgs>, UIKit.UIPageViewControllerTransitionEventArgs>(x => This.WillTransition += x, x => This.WillTransition -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIPrintInteractionControllerEvents
    {
        UIPrintInteractionController This;

        public UIPrintInteractionControllerEvents(UIPrintInteractionController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidDismissPrinterOptions {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidDismissPrinterOptions += x, x => This.DidDismissPrinterOptions -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidFinishJob {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidFinishJob += x, x => This.DidFinishJob -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidPresentPrinterOptions {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidPresentPrinterOptions += x, x => This.DidPresentPrinterOptions -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillDismissPrinterOptions {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillDismissPrinterOptions += x, x => This.WillDismissPrinterOptions -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillPresentPrinterOptions {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillPresentPrinterOptions += x, x => This.WillPresentPrinterOptions -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillStartJob {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillStartJob += x, x => This.WillStartJob -= x).Select(x => x.EventArgs); }
        }

    }
    public class NSTextStorageEvents
    {
        NSTextStorage This;

        public NSTextStorageEvents(NSTextStorage This)
        {
            this.This = This;
        }

        public IObservable<UIKit.NSTextStorageEventArgs> DidProcessEditing {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.NSTextStorageEventArgs>, UIKit.NSTextStorageEventArgs>(x => This.DidProcessEditing += x, x => This.DidProcessEditing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.NSTextStorageEventArgs> WillProcessEditing {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.NSTextStorageEventArgs>, UIKit.NSTextStorageEventArgs>(x => This.WillProcessEditing += x, x => This.WillProcessEditing -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIAccelerometerEvents
    {
        UIAccelerometer This;

        public UIAccelerometerEvents(UIAccelerometer This)
        {
            this.This = This;
        }

        public IObservable<UIKit.UIAccelerometerEventArgs> Acceleration {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIAccelerometerEventArgs>, UIKit.UIAccelerometerEventArgs>(x => This.Acceleration += x, x => This.Acceleration -= x).Select(x => x.EventArgs); }
        }

    }
    public class UICollisionBehaviorEvents
    {
        UICollisionBehavior This;

        public UICollisionBehaviorEvents(UICollisionBehavior This)
        {
            this.This = This;
        }

        public IObservable<UIKit.UICollisionBeganBoundaryContactEventArgs> BeganBoundaryContact {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UICollisionBeganBoundaryContactEventArgs>, UIKit.UICollisionBeganBoundaryContactEventArgs>(x => This.BeganBoundaryContact += x, x => This.BeganBoundaryContact -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UICollisionBeganContactEventArgs> BeganContact {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UICollisionBeganContactEventArgs>, UIKit.UICollisionBeganContactEventArgs>(x => This.BeganContact += x, x => This.BeganContact -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UICollisionEndedBoundaryContactEventArgs> EndedBoundaryContact {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UICollisionEndedBoundaryContactEventArgs>, UIKit.UICollisionEndedBoundaryContactEventArgs>(x => This.EndedBoundaryContact += x, x => This.EndedBoundaryContact -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UICollisionEndedContactEventArgs> EndedContact {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UICollisionEndedContactEventArgs>, UIKit.UICollisionEndedContactEventArgs>(x => This.EndedContact += x, x => This.EndedContact -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIDocumentInteractionControllerEvents
    {
        UIDocumentInteractionController This;

        public UIDocumentInteractionControllerEvents(UIDocumentInteractionController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidDismissOpenInMenu {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidDismissOpenInMenu += x, x => This.DidDismissOpenInMenu -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidDismissOptionsMenu {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidDismissOptionsMenu += x, x => This.DidDismissOptionsMenu -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidEndPreview {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidEndPreview += x, x => This.DidEndPreview -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIDocumentSendingToApplicationEventArgs> DidEndSendingToApplication {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIDocumentSendingToApplicationEventArgs>, UIKit.UIDocumentSendingToApplicationEventArgs>(x => This.DidEndSendingToApplication += x, x => This.DidEndSendingToApplication -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillBeginPreview {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillBeginPreview += x, x => This.WillBeginPreview -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIDocumentSendingToApplicationEventArgs> WillBeginSendingToApplication {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIDocumentSendingToApplicationEventArgs>, UIKit.UIDocumentSendingToApplicationEventArgs>(x => This.WillBeginSendingToApplication += x, x => This.WillBeginSendingToApplication -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillPresentOpenInMenu {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillPresentOpenInMenu += x, x => This.WillPresentOpenInMenu -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillPresentOptionsMenu {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillPresentOptionsMenu += x, x => This.WillPresentOptionsMenu -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIScrollViewEvents
    {
        UIScrollView This;

        public UIScrollViewEvents(UIScrollView This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DecelerationEnded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DecelerationEnded += x, x => This.DecelerationEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DecelerationStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DecelerationStarted += x, x => This.DecelerationStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidZoom {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidZoom += x, x => This.DidZoom -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.DraggingEventArgs> DraggingEnded {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.DraggingEventArgs>, UIKit.DraggingEventArgs>(x => This.DraggingEnded += x, x => This.DraggingEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DraggingStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DraggingStarted += x, x => This.DraggingStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ScrollAnimationEnded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ScrollAnimationEnded += x, x => This.ScrollAnimationEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Scrolled {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Scrolled += x, x => This.Scrolled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ScrolledToTop {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ScrolledToTop += x, x => This.ScrolledToTop -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.WillEndDraggingEventArgs> WillEndDragging {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.WillEndDraggingEventArgs>, UIKit.WillEndDraggingEventArgs>(x => This.WillEndDragging += x, x => This.WillEndDragging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.ZoomingEndedEventArgs> ZoomingEnded {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.ZoomingEndedEventArgs>, UIKit.ZoomingEndedEventArgs>(x => This.ZoomingEnded += x, x => This.ZoomingEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIScrollViewZoomingEventArgs> ZoomingStarted {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIScrollViewZoomingEventArgs>, UIKit.UIScrollViewZoomingEventArgs>(x => This.ZoomingStarted += x, x => This.ZoomingStarted -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIPreviewInteractionEvents
    {
        UIPreviewInteraction This;

        public UIPreviewInteractionEvents(UIPreviewInteraction This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DidCancel {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidCancel += x, x => This.DidCancel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.NSPreviewInteractionPreviewUpdateEventArgs> DidUpdateCommit {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.NSPreviewInteractionPreviewUpdateEventArgs>, UIKit.NSPreviewInteractionPreviewUpdateEventArgs>(x => This.DidUpdateCommit += x, x => This.DidUpdateCommit -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.NSPreviewInteractionPreviewUpdateEventArgs> DidUpdatePreviewTransition {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.NSPreviewInteractionPreviewUpdateEventArgs>, UIKit.NSPreviewInteractionPreviewUpdateEventArgs>(x => This.DidUpdatePreviewTransition += x, x => This.DidUpdatePreviewTransition -= x).Select(x => x.EventArgs); }
        }

    }
    public class UITabBarEvents
    {
        UITabBar This;

        public UITabBarEvents(UITabBar This)
        {
            this.This = This;
        }

        public IObservable<UIKit.UITabBarItemsEventArgs> DidBeginCustomizingItems {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UITabBarItemsEventArgs>, UIKit.UITabBarItemsEventArgs>(x => This.DidBeginCustomizingItems += x, x => This.DidBeginCustomizingItems -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UITabBarFinalItemsEventArgs> DidEndCustomizingItems {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UITabBarFinalItemsEventArgs>, UIKit.UITabBarFinalItemsEventArgs>(x => This.DidEndCustomizingItems += x, x => This.DidEndCustomizingItems -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UITabBarItemEventArgs> ItemSelected {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UITabBarItemEventArgs>, UIKit.UITabBarItemEventArgs>(x => This.ItemSelected += x, x => This.ItemSelected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UITabBarItemsEventArgs> WillBeginCustomizingItems {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UITabBarItemsEventArgs>, UIKit.UITabBarItemsEventArgs>(x => This.WillBeginCustomizingItems += x, x => This.WillBeginCustomizingItems -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UITabBarFinalItemsEventArgs> WillEndCustomizingItems {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UITabBarFinalItemsEventArgs>, UIKit.UITabBarFinalItemsEventArgs>(x => This.WillEndCustomizingItems += x, x => This.WillEndCustomizingItems -= x).Select(x => x.EventArgs); }
        }

    }
    public class UITabBarControllerEvents
    {
        UITabBarController This;

        public UITabBarControllerEvents(UITabBarController This)
        {
            this.This = This;
        }

        public IObservable<UIKit.UITabBarCustomizeChangeEventArgs> FinishedCustomizingViewControllers {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UITabBarCustomizeChangeEventArgs>, UIKit.UITabBarCustomizeChangeEventArgs>(x => This.FinishedCustomizingViewControllers += x, x => This.FinishedCustomizingViewControllers -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UITabBarCustomizeEventArgs> OnCustomizingViewControllers {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UITabBarCustomizeEventArgs>, UIKit.UITabBarCustomizeEventArgs>(x => This.OnCustomizingViewControllers += x, x => This.OnCustomizingViewControllers -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UITabBarCustomizeChangeEventArgs> OnEndCustomizingViewControllers {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UITabBarCustomizeChangeEventArgs>, UIKit.UITabBarCustomizeChangeEventArgs>(x => This.OnEndCustomizingViewControllers += x, x => This.OnEndCustomizingViewControllers -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UITabBarSelectionEventArgs> ViewControllerSelected {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UITabBarSelectionEventArgs>, UIKit.UITabBarSelectionEventArgs>(x => This.ViewControllerSelected += x, x => This.ViewControllerSelected -= x).Select(x => x.EventArgs); }
        }

    }
    public class UISplitViewControllerEvents
    {
        UISplitViewController This;

        public UISplitViewControllerEvents(UISplitViewController This)
        {
            this.This = This;
        }

        public IObservable<UIKit.UISplitViewControllerDisplayModeEventArgs> WillChangeDisplayMode {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UISplitViewControllerDisplayModeEventArgs>, UIKit.UISplitViewControllerDisplayModeEventArgs>(x => This.WillChangeDisplayMode += x, x => This.WillChangeDisplayMode -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UISplitViewHideEventArgs> WillHideViewController {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UISplitViewHideEventArgs>, UIKit.UISplitViewHideEventArgs>(x => This.WillHideViewController += x, x => This.WillHideViewController -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UISplitViewPresentEventArgs> WillPresentViewController {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UISplitViewPresentEventArgs>, UIKit.UISplitViewPresentEventArgs>(x => This.WillPresentViewController += x, x => This.WillPresentViewController -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UISplitViewShowEventArgs> WillShowViewController {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UISplitViewShowEventArgs>, UIKit.UISplitViewShowEventArgs>(x => This.WillShowViewController += x, x => This.WillShowViewController -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIVideoEditorControllerEvents
    {
        UIVideoEditorController This;

        public UIVideoEditorControllerEvents(UIVideoEditorController This)
        {
            this.This = This;
        }

        public IObservable<Foundation.NSErrorEventArgs> Failed {
            get { return Observable.FromEventPattern<System.EventHandler<Foundation.NSErrorEventArgs>, Foundation.NSErrorEventArgs>(x => This.Failed += x, x => This.Failed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> UserCancelled {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.UserCancelled += x, x => This.UserCancelled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<UIKit.UIPathEventArgs> Saved {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIPathEventArgs>, UIKit.UIPathEventArgs>(x => This.Saved += x, x => This.Saved -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIWebViewEvents
    {
        UIWebView This;

        public UIWebViewEvents(UIWebView This)
        {
            this.This = This;
        }

        public IObservable<UIKit.UIWebErrorArgs> LoadError {
            get { return Observable.FromEventPattern<System.EventHandler<UIKit.UIWebErrorArgs>, UIKit.UIWebErrorArgs>(x => This.LoadError += x, x => This.LoadError -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> LoadFinished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LoadFinished += x, x => This.LoadFinished -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> LoadStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LoadStarted += x, x => This.LoadStarted -= x).Select(x => x.EventArgs); }
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
        public static SKStoreProductViewControllerEvents Events(this SKStoreProductViewController This)
        {
            return new SKStoreProductViewControllerEvents(This);
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
    public class SKStoreProductViewControllerEvents
    {
        SKStoreProductViewController This;

        public SKStoreProductViewControllerEvents(SKStoreProductViewController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Finished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Finished += x, x => This.Finished -= x).Select(x => x.EventArgs); }
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

        public IObservable<MapKit.MKMapViewAccessoryTappedEventArgs> CalloutAccessoryControlTapped {
            get { return Observable.FromEventPattern<System.EventHandler<MapKit.MKMapViewAccessoryTappedEventArgs>, MapKit.MKMapViewAccessoryTappedEventArgs>(x => This.CalloutAccessoryControlTapped += x, x => This.CalloutAccessoryControlTapped -= x).Select(x => x.EventArgs); }
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

        public IObservable<MapKit.MKOverlayViewsEventArgs> DidAddOverlayViews {
            get { return Observable.FromEventPattern<System.EventHandler<MapKit.MKOverlayViewsEventArgs>, MapKit.MKOverlayViewsEventArgs>(x => This.DidAddOverlayViews += x, x => This.DidAddOverlayViews -= x).Select(x => x.EventArgs); }
        }

        public IObservable<MapKit.MMapViewUserTrackingEventArgs> DidChangeUserTrackingMode {
            get { return Observable.FromEventPattern<System.EventHandler<MapKit.MMapViewUserTrackingEventArgs>, MapKit.MMapViewUserTrackingEventArgs>(x => This.DidChangeUserTrackingMode += x, x => This.DidChangeUserTrackingMode -= x).Select(x => x.EventArgs); }
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
namespace ExternalAccessory
{
    public static class EventsMixin
    {
        public static EAAccessoryEvents Events(this EAAccessory This)
        {
            return new EAAccessoryEvents(This);
        }
        public static EAWiFiUnconfiguredAccessoryBrowserEvents Events(this EAWiFiUnconfiguredAccessoryBrowser This)
        {
            return new EAWiFiUnconfiguredAccessoryBrowserEvents(This);
        }
    }

    public class EAAccessoryEvents
    {
        EAAccessory This;

        public EAAccessoryEvents(EAAccessory This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Disconnected {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Disconnected += x, x => This.Disconnected -= x).Select(x => x.EventArgs); }
        }

    }
    public class EAWiFiUnconfiguredAccessoryBrowserEvents
    {
        EAWiFiUnconfiguredAccessoryBrowser This;

        public EAWiFiUnconfiguredAccessoryBrowserEvents(EAWiFiUnconfiguredAccessoryBrowser This)
        {
            this.This = This;
        }

        public IObservable<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowserEventArgs> DidFindUnconfiguredAccessories {
            get { return Observable.FromEventPattern<System.EventHandler<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowserEventArgs>, ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowserEventArgs>(x => This.DidFindUnconfiguredAccessories += x, x => This.DidFindUnconfiguredAccessories -= x).Select(x => x.EventArgs); }
        }

        public IObservable<ExternalAccessory.EAWiFiUnconfiguredAccessoryDidFinishEventArgs> DidFinishConfiguringAccessory {
            get { return Observable.FromEventPattern<System.EventHandler<ExternalAccessory.EAWiFiUnconfiguredAccessoryDidFinishEventArgs>, ExternalAccessory.EAWiFiUnconfiguredAccessoryDidFinishEventArgs>(x => This.DidFinishConfiguringAccessory += x, x => This.DidFinishConfiguringAccessory -= x).Select(x => x.EventArgs); }
        }

        public IObservable<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowserEventArgs> DidRemoveUnconfiguredAccessories {
            get { return Observable.FromEventPattern<System.EventHandler<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowserEventArgs>, ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowserEventArgs>(x => This.DidRemoveUnconfiguredAccessories += x, x => This.DidRemoveUnconfiguredAccessories -= x).Select(x => x.EventArgs); }
        }

        public IObservable<ExternalAccessory.EAWiFiUnconfiguredAccessoryEventArgs> DidUpdateState {
            get { return Observable.FromEventPattern<System.EventHandler<ExternalAccessory.EAWiFiUnconfiguredAccessoryEventArgs>, ExternalAccessory.EAWiFiUnconfiguredAccessoryEventArgs>(x => This.DidUpdateState += x, x => This.DidUpdateState -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace EventKitUI
{
    public static class EventsMixin
    {
        public static EKCalendarChooserEvents Events(this EKCalendarChooser This)
        {
            return new EKCalendarChooserEvents(This);
        }
        public static EKEventEditViewControllerEvents Events(this EKEventEditViewController This)
        {
            return new EKEventEditViewControllerEvents(This);
        }
        public static EKEventViewControllerEvents Events(this EKEventViewController This)
        {
            return new EKEventViewControllerEvents(This);
        }
    }

    public class EKCalendarChooserEvents
    {
        EKCalendarChooser This;

        public EKCalendarChooserEvents(EKCalendarChooser This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Cancelled {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Cancelled += x, x => This.Cancelled -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Finished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Finished += x, x => This.Finished -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class EKEventEditViewControllerEvents
    {
        EKEventEditViewController This;

        public EKEventEditViewControllerEvents(EKEventEditViewController This)
        {
            this.This = This;
        }

        public IObservable<EventKitUI.EKEventEditEventArgs> Completed {
            get { return Observable.FromEventPattern<System.EventHandler<EventKitUI.EKEventEditEventArgs>, EventKitUI.EKEventEditEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

    }
    public class EKEventViewControllerEvents
    {
        EKEventViewController This;

        public EKEventViewControllerEvents(EKEventViewController This)
        {
            this.This = This;
        }

        public IObservable<EventKitUI.EKEventViewEventArgs> Completed {
            get { return Observable.FromEventPattern<System.EventHandler<EventKitUI.EKEventViewEventArgs>, EventKitUI.EKEventViewEventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace MediaPlayer
{
    public static class EventsMixin
    {
        public static MPMediaPickerControllerEvents Events(this MPMediaPickerController This)
        {
            return new MPMediaPickerControllerEvents(This);
        }
    }

    public class MPMediaPickerControllerEvents
    {
        MPMediaPickerController This;

        public MPMediaPickerControllerEvents(MPMediaPickerController This)
        {
            this.This = This;
        }

        public IObservable<MediaPlayer.ItemsPickedEventArgs> ItemsPicked {
            get { return Observable.FromEventPattern<System.EventHandler<MediaPlayer.ItemsPickedEventArgs>, MediaPlayer.ItemsPickedEventArgs>(x => This.ItemsPicked += x, x => This.ItemsPicked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DidCancel {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DidCancel += x, x => This.DidCancel -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace GLKit
{
    public static class EventsMixin
    {
        public static GLKViewEvents Events(this GLKView This)
        {
            return new GLKViewEvents(This);
        }
    }

    public class GLKViewEvents
    {
        GLKView This;

        public GLKViewEvents(GLKView This)
        {
            this.This = This;
        }

        public IObservable<GLKit.GLKViewDrawEventArgs> DrawInRect {
            get { return Observable.FromEventPattern<System.EventHandler<GLKit.GLKViewDrawEventArgs>, GLKit.GLKViewDrawEventArgs>(x => This.DrawInRect += x, x => This.DrawInRect -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace PassKit
{
    public static class EventsMixin
    {
        public static PKAddPassesViewControllerEvents Events(this PKAddPassesViewController This)
        {
            return new PKAddPassesViewControllerEvents(This);
        }
        public static PKPaymentAuthorizationViewControllerEvents Events(this PKPaymentAuthorizationViewController This)
        {
            return new PKPaymentAuthorizationViewControllerEvents(This);
        }
    }

    public class PKAddPassesViewControllerEvents
    {
        PKAddPassesViewController This;

        public PKAddPassesViewControllerEvents(PKAddPassesViewController This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Finished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Finished += x, x => This.Finished -= x).Select(x => x.EventArgs); }
        }

    }
    public class PKPaymentAuthorizationViewControllerEvents
    {
        PKPaymentAuthorizationViewController This;

        public PKPaymentAuthorizationViewControllerEvents(PKPaymentAuthorizationViewController This)
        {
            this.This = This;
        }

        public IObservable<PassKit.PKPaymentAuthorizationEventArgs> DidAuthorizePayment {
            get { return Observable.FromEventPattern<System.EventHandler<PassKit.PKPaymentAuthorizationEventArgs>, PassKit.PKPaymentAuthorizationEventArgs>(x => This.DidAuthorizePayment += x, x => This.DidAuthorizePayment -= x).Select(x => x.EventArgs); }
        }

        public IObservable<PassKit.PKPaymentMethodSelectedEventArgs> DidSelectPaymentMethod {
            get { return Observable.FromEventPattern<System.EventHandler<PassKit.PKPaymentMethodSelectedEventArgs>, PassKit.PKPaymentMethodSelectedEventArgs>(x => This.DidSelectPaymentMethod += x, x => This.DidSelectPaymentMethod -= x).Select(x => x.EventArgs); }
        }

        public IObservable<PassKit.PKPaymentShippingAddressSelectedEventArgs> DidSelectShippingAddress {
            get { return Observable.FromEventPattern<System.EventHandler<PassKit.PKPaymentShippingAddressSelectedEventArgs>, PassKit.PKPaymentShippingAddressSelectedEventArgs>(x => This.DidSelectShippingAddress += x, x => This.DidSelectShippingAddress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<PassKit.PKPaymentSelectedContactEventArgs> DidSelectShippingContact {
            get { return Observable.FromEventPattern<System.EventHandler<PassKit.PKPaymentSelectedContactEventArgs>, PassKit.PKPaymentSelectedContactEventArgs>(x => This.DidSelectShippingContact += x, x => This.DidSelectShippingContact -= x).Select(x => x.EventArgs); }
        }

        public IObservable<PassKit.PKPaymentShippingMethodSelectedEventArgs> DidSelectShippingMethod {
            get { return Observable.FromEventPattern<System.EventHandler<PassKit.PKPaymentShippingMethodSelectedEventArgs>, PassKit.PKPaymentShippingMethodSelectedEventArgs>(x => This.DidSelectShippingMethod += x, x => This.DidSelectShippingMethod -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PaymentAuthorizationViewControllerDidFinish {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PaymentAuthorizationViewControllerDidFinish += x, x => This.PaymentAuthorizationViewControllerDidFinish -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillAuthorizePayment {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillAuthorizePayment += x, x => This.WillAuthorizePayment -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace iAd
{
    public static class EventsMixin
    {
        public static ADInterstitialAdEvents Events(this ADInterstitialAd This)
        {
            return new ADInterstitialAdEvents(This);
        }
        public static ADBannerViewEvents Events(this ADBannerView This)
        {
            return new ADBannerViewEvents(This);
        }
    }

    public class ADInterstitialAdEvents
    {
        ADInterstitialAd This;

        public ADInterstitialAdEvents(ADInterstitialAd This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ActionFinished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ActionFinished += x, x => This.ActionFinished -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> AdLoaded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AdLoaded += x, x => This.AdLoaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> AdUnloaded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AdUnloaded += x, x => This.AdUnloaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<iAd.ADErrorEventArgs> FailedToReceiveAd {
            get { return Observable.FromEventPattern<System.EventHandler<iAd.ADErrorEventArgs>, iAd.ADErrorEventArgs>(x => This.FailedToReceiveAd += x, x => This.FailedToReceiveAd -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillLoad {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillLoad += x, x => This.WillLoad -= x).Select(x => x.EventArgs); }
        }

    }
    public class ADBannerViewEvents
    {
        ADBannerView This;

        public ADBannerViewEvents(ADBannerView This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ActionFinished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ActionFinished += x, x => This.ActionFinished -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> AdLoaded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AdLoaded += x, x => This.AdLoaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<iAd.AdErrorEventArgs> FailedToReceiveAd {
            get { return Observable.FromEventPattern<System.EventHandler<iAd.AdErrorEventArgs>, iAd.AdErrorEventArgs>(x => This.FailedToReceiveAd += x, x => This.FailedToReceiveAd -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> WillLoad {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.WillLoad += x, x => This.WillLoad -= x).Select(x => x.EventArgs); }
        }

    }
}

namespace AVFoundation.Rx
{
    public  partial class AVPlayerItemOutputPushDelegateRx : AVPlayerItemOutputPushDelegate
    {
        readonly SingleAwaitSubject<AVFoundation.AVPlayerItemOutput> _OutputSequenceWasFlushed = new SingleAwaitSubject<AVFoundation.AVPlayerItemOutput>();
        public IObservable<AVFoundation.AVPlayerItemOutput> OutputSequenceWasFlushedObs { get { return _OutputSequenceWasFlushed; } }
        public override void OutputSequenceWasFlushed(AVFoundation.AVPlayerItemOutput output)
        {
            _OutputSequenceWasFlushed.OnNext(output);
        }

    }
    public  partial class AVCaptureAudioDataOutputSampleBufferDelegateRx : AVCaptureAudioDataOutputSampleBufferDelegate
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
    public  partial class AVSpeechSynthesizerDelegateRx : AVSpeechSynthesizerDelegate
    {
        readonly SingleAwaitSubject<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>> _DidCancelSpeechUtterance = new SingleAwaitSubject<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>>();
        public IObservable<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>> DidCancelSpeechUtteranceObs { get { return _DidCancelSpeechUtterance; } }
        public override void DidCancelSpeechUtterance(AVFoundation.AVSpeechSynthesizer synthesizer, AVFoundation.AVSpeechUtterance utterance)
        {
            _DidCancelSpeechUtterance.OnNext(Tuple.Create(synthesizer, utterance));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>> _DidContinueSpeechUtterance = new SingleAwaitSubject<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>>();
        public IObservable<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>> DidContinueSpeechUtteranceObs { get { return _DidContinueSpeechUtterance; } }
        public override void DidContinueSpeechUtterance(AVFoundation.AVSpeechSynthesizer synthesizer, AVFoundation.AVSpeechUtterance utterance)
        {
            _DidContinueSpeechUtterance.OnNext(Tuple.Create(synthesizer, utterance));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>> _DidFinishSpeechUtterance = new SingleAwaitSubject<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>>();
        public IObservable<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>> DidFinishSpeechUtteranceObs { get { return _DidFinishSpeechUtterance; } }
        public override void DidFinishSpeechUtterance(AVFoundation.AVSpeechSynthesizer synthesizer, AVFoundation.AVSpeechUtterance utterance)
        {
            _DidFinishSpeechUtterance.OnNext(Tuple.Create(synthesizer, utterance));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>> _DidPauseSpeechUtterance = new SingleAwaitSubject<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>>();
        public IObservable<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>> DidPauseSpeechUtteranceObs { get { return _DidPauseSpeechUtterance; } }
        public override void DidPauseSpeechUtterance(AVFoundation.AVSpeechSynthesizer synthesizer, AVFoundation.AVSpeechUtterance utterance)
        {
            _DidPauseSpeechUtterance.OnNext(Tuple.Create(synthesizer, utterance));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>> _DidStartSpeechUtterance = new SingleAwaitSubject<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>>();
        public IObservable<Tuple<AVFoundation.AVSpeechSynthesizer, AVFoundation.AVSpeechUtterance>> DidStartSpeechUtteranceObs { get { return _DidStartSpeechUtterance; } }
        public override void DidStartSpeechUtterance(AVFoundation.AVSpeechSynthesizer synthesizer, AVFoundation.AVSpeechUtterance utterance)
        {
            _DidStartSpeechUtterance.OnNext(Tuple.Create(synthesizer, utterance));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVSpeechSynthesizer, Foundation.NSRange, AVFoundation.AVSpeechUtterance>> _WillSpeakRangeOfSpeechString = new SingleAwaitSubject<Tuple<AVFoundation.AVSpeechSynthesizer, Foundation.NSRange, AVFoundation.AVSpeechUtterance>>();
        public IObservable<Tuple<AVFoundation.AVSpeechSynthesizer, Foundation.NSRange, AVFoundation.AVSpeechUtterance>> WillSpeakRangeOfSpeechStringObs { get { return _WillSpeakRangeOfSpeechString; } }
        public override void WillSpeakRangeOfSpeechString(AVFoundation.AVSpeechSynthesizer synthesizer, Foundation.NSRange characterRange, AVFoundation.AVSpeechUtterance utterance)
        {
            _WillSpeakRangeOfSpeechString.OnNext(Tuple.Create(synthesizer, characterRange, utterance));
        }

    }
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
    public  partial class AVAudioSessionDelegateRx : AVAudioSessionDelegate
    {
        readonly SingleAwaitSubject<Unit> _BeginInterruption = new SingleAwaitSubject<Unit>();
        public IObservable<Unit> BeginInterruptionObs { get { return _BeginInterruption; } }
        public override void BeginInterruption()
        {
            _BeginInterruption.OnNext(Unit.Default);
        }

        readonly SingleAwaitSubject<AVFoundation.AVAudioSessionInterruptionFlags> _EndInterruption = new SingleAwaitSubject<AVFoundation.AVAudioSessionInterruptionFlags>();
        public IObservable<AVFoundation.AVAudioSessionInterruptionFlags> EndInterruptionObs { get { return _EndInterruption; } }
        public override void EndInterruption(AVFoundation.AVAudioSessionInterruptionFlags flags)
        {
            _EndInterruption.OnNext(flags);
        }

        readonly SingleAwaitSubject<System.Boolean> _InputIsAvailableChanged = new SingleAwaitSubject<System.Boolean>();
        public IObservable<System.Boolean> InputIsAvailableChangedObs { get { return _InputIsAvailableChanged; } }
        public override void InputIsAvailableChanged(System.Boolean isInputAvailable)
        {
            _InputIsAvailableChanged.OnNext(isInputAvailable);
        }

    }
    public  partial class AVAudioPlayerDelegateRx : AVAudioPlayerDelegate
    {
        readonly SingleAwaitSubject<AVFoundation.AVAudioPlayer> _BeginInterruption = new SingleAwaitSubject<AVFoundation.AVAudioPlayer>();
        public IObservable<AVFoundation.AVAudioPlayer> BeginInterruptionObs { get { return _BeginInterruption; } }
        public override void BeginInterruption(AVFoundation.AVAudioPlayer player)
        {
            _BeginInterruption.OnNext(player);
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVAudioPlayer, Foundation.NSError>> _DecoderError = new SingleAwaitSubject<Tuple<AVFoundation.AVAudioPlayer, Foundation.NSError>>();
        public IObservable<Tuple<AVFoundation.AVAudioPlayer, Foundation.NSError>> DecoderErrorObs { get { return _DecoderError; } }
        public override void DecoderError(AVFoundation.AVAudioPlayer player, Foundation.NSError error)
        {
            _DecoderError.OnNext(Tuple.Create(player, error));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVAudioPlayer, AVFoundation.AVAudioSessionInterruptionFlags>> _EndInterruption = new SingleAwaitSubject<Tuple<AVFoundation.AVAudioPlayer, AVFoundation.AVAudioSessionInterruptionFlags>>();
        public IObservable<Tuple<AVFoundation.AVAudioPlayer, AVFoundation.AVAudioSessionInterruptionFlags>> EndInterruptionObs { get { return _EndInterruption; } }
        public override void EndInterruption(AVFoundation.AVAudioPlayer player, AVFoundation.AVAudioSessionInterruptionFlags flags)
        {
            _EndInterruption.OnNext(Tuple.Create(player, flags));
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
        readonly SingleAwaitSubject<AVFoundation.AVAudioRecorder> _BeginInterruption = new SingleAwaitSubject<AVFoundation.AVAudioRecorder>();
        public IObservable<AVFoundation.AVAudioRecorder> BeginInterruptionObs { get { return _BeginInterruption; } }
        public override void BeginInterruption(AVFoundation.AVAudioRecorder recorder)
        {
            _BeginInterruption.OnNext(recorder);
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVAudioRecorder, Foundation.NSError>> _EncoderError = new SingleAwaitSubject<Tuple<AVFoundation.AVAudioRecorder, Foundation.NSError>>();
        public IObservable<Tuple<AVFoundation.AVAudioRecorder, Foundation.NSError>> EncoderErrorObs { get { return _EncoderError; } }
        public override void EncoderError(AVFoundation.AVAudioRecorder recorder, Foundation.NSError error)
        {
            _EncoderError.OnNext(Tuple.Create(recorder, error));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVAudioRecorder, AVFoundation.AVAudioSessionInterruptionFlags>> _EndInterruption = new SingleAwaitSubject<Tuple<AVFoundation.AVAudioRecorder, AVFoundation.AVAudioSessionInterruptionFlags>>();
        public IObservable<Tuple<AVFoundation.AVAudioRecorder, AVFoundation.AVAudioSessionInterruptionFlags>> EndInterruptionObs { get { return _EndInterruption; } }
        public override void EndInterruption(AVFoundation.AVAudioRecorder recorder, AVFoundation.AVAudioSessionInterruptionFlags flags)
        {
            _EndInterruption.OnNext(Tuple.Create(recorder, flags));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVAudioRecorder, System.Boolean>> _FinishedRecording = new SingleAwaitSubject<Tuple<AVFoundation.AVAudioRecorder, System.Boolean>>();
        public IObservable<Tuple<AVFoundation.AVAudioRecorder, System.Boolean>> FinishedRecordingObs { get { return _FinishedRecording; } }
        public override void FinishedRecording(AVFoundation.AVAudioRecorder recorder, System.Boolean flag)
        {
            _FinishedRecording.OnNext(Tuple.Create(recorder, flag));
        }

    }
    public  partial class AVCaptureMetadataOutputObjectsDelegateRx : AVCaptureMetadataOutputObjectsDelegate
    {
        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCaptureMetadataOutput, AVFoundation.AVMetadataObject[], AVFoundation.AVCaptureConnection>> _DidOutputMetadataObjects = new SingleAwaitSubject<Tuple<AVFoundation.AVCaptureMetadataOutput, AVFoundation.AVMetadataObject[], AVFoundation.AVCaptureConnection>>();
        public IObservable<Tuple<AVFoundation.AVCaptureMetadataOutput, AVFoundation.AVMetadataObject[], AVFoundation.AVCaptureConnection>> DidOutputMetadataObjectsObs { get { return _DidOutputMetadataObjects; } }
        public override void DidOutputMetadataObjects(AVFoundation.AVCaptureMetadataOutput captureOutput, AVFoundation.AVMetadataObject[] metadataObjects, AVFoundation.AVCaptureConnection connection)
        {
            _DidOutputMetadataObjects.OnNext(Tuple.Create(captureOutput, metadataObjects, connection));
        }

    }
    public  partial class AVCapturePhotoCaptureDelegateRx : AVCapturePhotoCaptureDelegate
    {
        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, AVFoundation.AVCaptureResolvedPhotoSettings>> _DidCapturePhoto = new SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, AVFoundation.AVCaptureResolvedPhotoSettings>>();
        public IObservable<Tuple<AVFoundation.AVCapturePhotoOutput, AVFoundation.AVCaptureResolvedPhotoSettings>> DidCapturePhotoObs { get { return _DidCapturePhoto; } }
        public override void DidCapturePhoto(AVFoundation.AVCapturePhotoOutput captureOutput, AVFoundation.AVCaptureResolvedPhotoSettings resolvedSettings)
        {
            _DidCapturePhoto.OnNext(Tuple.Create(captureOutput, resolvedSettings));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, AVFoundation.AVCaptureResolvedPhotoSettings, Foundation.NSError>> _DidFinishCapture = new SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, AVFoundation.AVCaptureResolvedPhotoSettings, Foundation.NSError>>();
        public IObservable<Tuple<AVFoundation.AVCapturePhotoOutput, AVFoundation.AVCaptureResolvedPhotoSettings, Foundation.NSError>> DidFinishCaptureObs { get { return _DidFinishCapture; } }
        public override void DidFinishCapture(AVFoundation.AVCapturePhotoOutput captureOutput, AVFoundation.AVCaptureResolvedPhotoSettings resolvedSettings, Foundation.NSError error)
        {
            _DidFinishCapture.OnNext(Tuple.Create(captureOutput, resolvedSettings, error));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, Foundation.NSUrl, CoreMedia.CMTime, CoreMedia.CMTime, AVFoundation.AVCaptureResolvedPhotoSettings, Foundation.NSError>> _DidFinishProcessingLivePhotoMovie = new SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, Foundation.NSUrl, CoreMedia.CMTime, CoreMedia.CMTime, AVFoundation.AVCaptureResolvedPhotoSettings, Foundation.NSError>>();
        public IObservable<Tuple<AVFoundation.AVCapturePhotoOutput, Foundation.NSUrl, CoreMedia.CMTime, CoreMedia.CMTime, AVFoundation.AVCaptureResolvedPhotoSettings, Foundation.NSError>> DidFinishProcessingLivePhotoMovieObs { get { return _DidFinishProcessingLivePhotoMovie; } }
        public override void DidFinishProcessingLivePhotoMovie(AVFoundation.AVCapturePhotoOutput captureOutput, Foundation.NSUrl outputFileUrl, CoreMedia.CMTime duration, CoreMedia.CMTime photoDisplayTime, AVFoundation.AVCaptureResolvedPhotoSettings resolvedSettings, Foundation.NSError error)
        {
            _DidFinishProcessingLivePhotoMovie.OnNext(Tuple.Create(captureOutput, outputFileUrl, duration, photoDisplayTime, resolvedSettings, error));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, CoreMedia.CMSampleBuffer, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureResolvedPhotoSettings, AVFoundation.AVCaptureBracketedStillImageSettings, Foundation.NSError>> _DidFinishProcessingPhoto = new SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, CoreMedia.CMSampleBuffer, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureResolvedPhotoSettings, AVFoundation.AVCaptureBracketedStillImageSettings, Foundation.NSError>>();
        public IObservable<Tuple<AVFoundation.AVCapturePhotoOutput, CoreMedia.CMSampleBuffer, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureResolvedPhotoSettings, AVFoundation.AVCaptureBracketedStillImageSettings, Foundation.NSError>> DidFinishProcessingPhotoObs { get { return _DidFinishProcessingPhoto; } }
        public override void DidFinishProcessingPhoto(AVFoundation.AVCapturePhotoOutput captureOutput, CoreMedia.CMSampleBuffer photoSampleBuffer, CoreMedia.CMSampleBuffer previewPhotoSampleBuffer, AVFoundation.AVCaptureResolvedPhotoSettings resolvedSettings, AVFoundation.AVCaptureBracketedStillImageSettings bracketSettings, Foundation.NSError error)
        {
            _DidFinishProcessingPhoto.OnNext(Tuple.Create(captureOutput, photoSampleBuffer, previewPhotoSampleBuffer, resolvedSettings, bracketSettings, error));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, CoreMedia.CMSampleBuffer, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureResolvedPhotoSettings, AVFoundation.AVCaptureBracketedStillImageSettings, Foundation.NSError>> _DidFinishProcessingRawPhoto = new SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, CoreMedia.CMSampleBuffer, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureResolvedPhotoSettings, AVFoundation.AVCaptureBracketedStillImageSettings, Foundation.NSError>>();
        public IObservable<Tuple<AVFoundation.AVCapturePhotoOutput, CoreMedia.CMSampleBuffer, CoreMedia.CMSampleBuffer, AVFoundation.AVCaptureResolvedPhotoSettings, AVFoundation.AVCaptureBracketedStillImageSettings, Foundation.NSError>> DidFinishProcessingRawPhotoObs { get { return _DidFinishProcessingRawPhoto; } }
        public override void DidFinishProcessingRawPhoto(AVFoundation.AVCapturePhotoOutput captureOutput, CoreMedia.CMSampleBuffer rawSampleBuffer, CoreMedia.CMSampleBuffer previewPhotoSampleBuffer, AVFoundation.AVCaptureResolvedPhotoSettings resolvedSettings, AVFoundation.AVCaptureBracketedStillImageSettings bracketSettings, Foundation.NSError error)
        {
            _DidFinishProcessingRawPhoto.OnNext(Tuple.Create(captureOutput, rawSampleBuffer, previewPhotoSampleBuffer, resolvedSettings, bracketSettings, error));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, Foundation.NSUrl, AVFoundation.AVCaptureResolvedPhotoSettings>> _DidFinishRecordingLivePhotoMovie = new SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, Foundation.NSUrl, AVFoundation.AVCaptureResolvedPhotoSettings>>();
        public IObservable<Tuple<AVFoundation.AVCapturePhotoOutput, Foundation.NSUrl, AVFoundation.AVCaptureResolvedPhotoSettings>> DidFinishRecordingLivePhotoMovieObs { get { return _DidFinishRecordingLivePhotoMovie; } }
        public override void DidFinishRecordingLivePhotoMovie(AVFoundation.AVCapturePhotoOutput captureOutput, Foundation.NSUrl outputFileUrl, AVFoundation.AVCaptureResolvedPhotoSettings resolvedSettings)
        {
            _DidFinishRecordingLivePhotoMovie.OnNext(Tuple.Create(captureOutput, outputFileUrl, resolvedSettings));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, AVFoundation.AVCaptureResolvedPhotoSettings>> _WillBeginCapture = new SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, AVFoundation.AVCaptureResolvedPhotoSettings>>();
        public IObservable<Tuple<AVFoundation.AVCapturePhotoOutput, AVFoundation.AVCaptureResolvedPhotoSettings>> WillBeginCaptureObs { get { return _WillBeginCapture; } }
        public override void WillBeginCapture(AVFoundation.AVCapturePhotoOutput captureOutput, AVFoundation.AVCaptureResolvedPhotoSettings resolvedSettings)
        {
            _WillBeginCapture.OnNext(Tuple.Create(captureOutput, resolvedSettings));
        }

        readonly SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, AVFoundation.AVCaptureResolvedPhotoSettings>> _WillCapturePhoto = new SingleAwaitSubject<Tuple<AVFoundation.AVCapturePhotoOutput, AVFoundation.AVCaptureResolvedPhotoSettings>>();
        public IObservable<Tuple<AVFoundation.AVCapturePhotoOutput, AVFoundation.AVCaptureResolvedPhotoSettings>> WillCapturePhotoObs { get { return _WillCapturePhoto; } }
        public override void WillCapturePhoto(AVFoundation.AVCapturePhotoOutput captureOutput, AVFoundation.AVCaptureResolvedPhotoSettings resolvedSettings)
        {
            _WillCapturePhoto.OnNext(Tuple.Create(captureOutput, resolvedSettings));
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
    public  partial class AVAssetDownloadDelegateRx : AVAssetDownloadDelegate
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

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, AVFoundation.AVAssetDownloadTask, Foundation.NSUrl>> _DidFinishDownloadingToUrl = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, AVFoundation.AVAssetDownloadTask, Foundation.NSUrl>>();
        public IObservable<Tuple<Foundation.NSUrlSession, AVFoundation.AVAssetDownloadTask, Foundation.NSUrl>> DidFinishDownloadingToUrlObs { get { return _DidFinishDownloadingToUrl; } }
        public override void DidFinishDownloadingToUrl(Foundation.NSUrlSession session, AVFoundation.AVAssetDownloadTask assetDownloadTask, Foundation.NSUrl location)
        {
            _DidFinishDownloadingToUrl.OnNext(Tuple.Create(session, assetDownloadTask, location));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, AVFoundation.AVAssetDownloadTask, CoreMedia.CMTimeRange, Foundation.NSValue[], CoreMedia.CMTimeRange>> _DidLoadTimeRange = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, AVFoundation.AVAssetDownloadTask, CoreMedia.CMTimeRange, Foundation.NSValue[], CoreMedia.CMTimeRange>>();
        public IObservable<Tuple<Foundation.NSUrlSession, AVFoundation.AVAssetDownloadTask, CoreMedia.CMTimeRange, Foundation.NSValue[], CoreMedia.CMTimeRange>> DidLoadTimeRangeObs { get { return _DidLoadTimeRange; } }
        public override void DidLoadTimeRange(Foundation.NSUrlSession session, AVFoundation.AVAssetDownloadTask assetDownloadTask, CoreMedia.CMTimeRange timeRange, Foundation.NSValue[] loadedTimeRanges, CoreMedia.CMTimeRange timeRangeExpectedToLoad)
        {
            _DidLoadTimeRange.OnNext(Tuple.Create(session, assetDownloadTask, timeRange, loadedTimeRanges, timeRangeExpectedToLoad));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSUrlAuthenticationChallenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential>>> _DidReceiveChallenge = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSUrlAuthenticationChallenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential>>>();
        public IObservable<Tuple<Foundation.NSUrlSession, Foundation.NSUrlSessionTask, Foundation.NSUrlAuthenticationChallenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential>>> DidReceiveChallengeObs { get { return _DidReceiveChallenge; } }
        public override void DidReceiveChallenge(Foundation.NSUrlSession session, Foundation.NSUrlSessionTask task, Foundation.NSUrlAuthenticationChallenge challenge, System.Action<Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential> completionHandler)
        {
            _DidReceiveChallenge.OnNext(Tuple.Create(session, task, challenge, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<Foundation.NSUrlSession, AVFoundation.AVAssetDownloadTask, AVFoundation.AVMediaSelection>> _DidResolveMediaSelection = new SingleAwaitSubject<Tuple<Foundation.NSUrlSession, AVFoundation.AVAssetDownloadTask, AVFoundation.AVMediaSelection>>();
        public IObservable<Tuple<Foundation.NSUrlSession, AVFoundation.AVAssetDownloadTask, AVFoundation.AVMediaSelection>> DidResolveMediaSelectionObs { get { return _DidResolveMediaSelection; } }
        public override void DidResolveMediaSelection(Foundation.NSUrlSession session, AVFoundation.AVAssetDownloadTask assetDownloadTask, AVFoundation.AVMediaSelection resolvedMediaSelection)
        {
            _DidResolveMediaSelection.OnNext(Tuple.Create(session, assetDownloadTask, resolvedMediaSelection));
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
}
namespace GameKit.Rx
{
    public  partial class GKMatchDelegateRx : GKMatchDelegate
    {
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
    public  partial class GKPeerPickerControllerDelegateRx : GKPeerPickerControllerDelegate
    {
        readonly SingleAwaitSubject<GameKit.GKPeerPickerController> _ControllerCancelled = new SingleAwaitSubject<GameKit.GKPeerPickerController>();
        public IObservable<GameKit.GKPeerPickerController> ControllerCancelledObs { get { return _ControllerCancelled; } }
        public override void ControllerCancelled(GameKit.GKPeerPickerController picker)
        {
            _ControllerCancelled.OnNext(picker);
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKPeerPickerController, GameKit.GKPeerPickerConnectionType>> _ConnectionTypeSelected = new SingleAwaitSubject<Tuple<GameKit.GKPeerPickerController, GameKit.GKPeerPickerConnectionType>>();
        public IObservable<Tuple<GameKit.GKPeerPickerController, GameKit.GKPeerPickerConnectionType>> ConnectionTypeSelectedObs { get { return _ConnectionTypeSelected; } }
        public override void ConnectionTypeSelected(GameKit.GKPeerPickerController picker, GameKit.GKPeerPickerConnectionType type)
        {
            _ConnectionTypeSelected.OnNext(Tuple.Create(picker, type));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKPeerPickerController, string, GameKit.GKSession>> _PeerConnected = new SingleAwaitSubject<Tuple<GameKit.GKPeerPickerController, string, GameKit.GKSession>>();
        public IObservable<Tuple<GameKit.GKPeerPickerController, string, GameKit.GKSession>> PeerConnectedObs { get { return _PeerConnected; } }
        public override void PeerConnected(GameKit.GKPeerPickerController picker, string peerId, GameKit.GKSession toSession)
        {
            _PeerConnected.OnNext(Tuple.Create(picker, peerId, toSession));
        }

    }
    public  partial class GKSessionDelegateRx : GKSessionDelegate
    {
        readonly SingleAwaitSubject<Tuple<GameKit.GKSession, Foundation.NSError>> _FailedWithError = new SingleAwaitSubject<Tuple<GameKit.GKSession, Foundation.NSError>>();
        public IObservable<Tuple<GameKit.GKSession, Foundation.NSError>> FailedWithErrorObs { get { return _FailedWithError; } }
        public override void FailedWithError(GameKit.GKSession session, Foundation.NSError error)
        {
            _FailedWithError.OnNext(Tuple.Create(session, error));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKSession, string, GameKit.GKPeerConnectionState>> _PeerChangedState = new SingleAwaitSubject<Tuple<GameKit.GKSession, string, GameKit.GKPeerConnectionState>>();
        public IObservable<Tuple<GameKit.GKSession, string, GameKit.GKPeerConnectionState>> PeerChangedStateObs { get { return _PeerChangedState; } }
        public override void PeerChangedState(GameKit.GKSession session, string peerID, GameKit.GKPeerConnectionState state)
        {
            _PeerChangedState.OnNext(Tuple.Create(session, peerID, state));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKSession, string, Foundation.NSError>> _PeerConnectionFailed = new SingleAwaitSubject<Tuple<GameKit.GKSession, string, Foundation.NSError>>();
        public IObservable<Tuple<GameKit.GKSession, string, Foundation.NSError>> PeerConnectionFailedObs { get { return _PeerConnectionFailed; } }
        public override void PeerConnectionFailed(GameKit.GKSession session, string peerID, Foundation.NSError error)
        {
            _PeerConnectionFailed.OnNext(Tuple.Create(session, peerID, error));
        }

        readonly SingleAwaitSubject<Tuple<GameKit.GKSession, string>> _PeerConnectionRequest = new SingleAwaitSubject<Tuple<GameKit.GKSession, string>>();
        public IObservable<Tuple<GameKit.GKSession, string>> PeerConnectionRequestObs { get { return _PeerConnectionRequest; } }
        public override void PeerConnectionRequest(GameKit.GKSession session, string peerID)
        {
            _PeerConnectionRequest.OnNext(Tuple.Create(session, peerID));
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

        readonly SingleAwaitSubject<Tuple<GameKit.GKTurnBasedMatch, System.Boolean>> _HandleTurnEvent = new SingleAwaitSubject<Tuple<GameKit.GKTurnBasedMatch, System.Boolean>>();
        public IObservable<Tuple<GameKit.GKTurnBasedMatch, System.Boolean>> HandleTurnEventObs { get { return _HandleTurnEvent; } }
        public override void HandleTurnEvent(GameKit.GKTurnBasedMatch match, System.Boolean activated)
        {
            _HandleTurnEvent.OnNext(Tuple.Create(match, activated));
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
    public abstract partial class GKLeaderboardViewControllerDelegateRx : GKLeaderboardViewControllerDelegate
    {
        readonly SingleAwaitSubject<GameKit.GKLeaderboardViewController> _DidFinish = new SingleAwaitSubject<GameKit.GKLeaderboardViewController>();
        public IObservable<GameKit.GKLeaderboardViewController> DidFinishObs { get { return _DidFinish; } }
        public override void DidFinish(GameKit.GKLeaderboardViewController viewController)
        {
            _DidFinish.OnNext(viewController);
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
    public  partial class GKChallengeEventHandlerDelegateRx : GKChallengeEventHandlerDelegate
    {
        readonly SingleAwaitSubject<GameKit.GKChallenge> _LocalPlayerCompletedChallenge = new SingleAwaitSubject<GameKit.GKChallenge>();
        public IObservable<GameKit.GKChallenge> LocalPlayerCompletedChallengeObs { get { return _LocalPlayerCompletedChallenge; } }
        public override void LocalPlayerCompletedChallenge(GameKit.GKChallenge challenge)
        {
            _LocalPlayerCompletedChallenge.OnNext(challenge);
        }

        readonly SingleAwaitSubject<GameKit.GKChallenge> _LocalPlayerReceivedChallenge = new SingleAwaitSubject<GameKit.GKChallenge>();
        public IObservable<GameKit.GKChallenge> LocalPlayerReceivedChallengeObs { get { return _LocalPlayerReceivedChallenge; } }
        public override void LocalPlayerReceivedChallenge(GameKit.GKChallenge challenge)
        {
            _LocalPlayerReceivedChallenge.OnNext(challenge);
        }

        readonly SingleAwaitSubject<GameKit.GKChallenge> _LocalPlayerSelectedChallenge = new SingleAwaitSubject<GameKit.GKChallenge>();
        public IObservable<GameKit.GKChallenge> LocalPlayerSelectedChallengeObs { get { return _LocalPlayerSelectedChallenge; } }
        public override void LocalPlayerSelectedChallenge(GameKit.GKChallenge challenge)
        {
            _LocalPlayerSelectedChallenge.OnNext(challenge);
        }

        readonly SingleAwaitSubject<GameKit.GKChallenge> _RemotePlayerCompletedChallenge = new SingleAwaitSubject<GameKit.GKChallenge>();
        public IObservable<GameKit.GKChallenge> RemotePlayerCompletedChallengeObs { get { return _RemotePlayerCompletedChallenge; } }
        public override void RemotePlayerCompletedChallenge(GameKit.GKChallenge challenge)
        {
            _RemotePlayerCompletedChallenge.OnNext(challenge);
        }

    }
}
namespace PhotosUI.Rx
{
    public  partial class PHLivePhotoViewDelegateRx : PHLivePhotoViewDelegate
    {
        readonly SingleAwaitSubject<Tuple<PhotosUI.PHLivePhotoView, PhotosUI.PHLivePhotoViewPlaybackStyle>> _DidEndPlayback = new SingleAwaitSubject<Tuple<PhotosUI.PHLivePhotoView, PhotosUI.PHLivePhotoViewPlaybackStyle>>();
        public IObservable<Tuple<PhotosUI.PHLivePhotoView, PhotosUI.PHLivePhotoViewPlaybackStyle>> DidEndPlaybackObs { get { return _DidEndPlayback; } }
        public override void DidEndPlayback(PhotosUI.PHLivePhotoView livePhotoView, PhotosUI.PHLivePhotoViewPlaybackStyle playbackStyle)
        {
            _DidEndPlayback.OnNext(Tuple.Create(livePhotoView, playbackStyle));
        }

        readonly SingleAwaitSubject<Tuple<PhotosUI.PHLivePhotoView, PhotosUI.PHLivePhotoViewPlaybackStyle>> _WillBeginPlayback = new SingleAwaitSubject<Tuple<PhotosUI.PHLivePhotoView, PhotosUI.PHLivePhotoViewPlaybackStyle>>();
        public IObservable<Tuple<PhotosUI.PHLivePhotoView, PhotosUI.PHLivePhotoViewPlaybackStyle>> WillBeginPlaybackObs { get { return _WillBeginPlayback; } }
        public override void WillBeginPlayback(PhotosUI.PHLivePhotoView livePhotoView, PhotosUI.PHLivePhotoViewPlaybackStyle playbackStyle)
        {
            _WillBeginPlayback.OnNext(Tuple.Create(livePhotoView, playbackStyle));
        }

    }
}
namespace PushKit.Rx
{
    public abstract partial class PKPushRegistryDelegateRx : PKPushRegistryDelegate
    {
        readonly SingleAwaitSubject<Tuple<PushKit.PKPushRegistry, string>> _DidInvalidatePushToken = new SingleAwaitSubject<Tuple<PushKit.PKPushRegistry, string>>();
        public IObservable<Tuple<PushKit.PKPushRegistry, string>> DidInvalidatePushTokenObs { get { return _DidInvalidatePushToken; } }
        public override void DidInvalidatePushToken(PushKit.PKPushRegistry registry, string type)
        {
            _DidInvalidatePushToken.OnNext(Tuple.Create(registry, type));
        }

        readonly SingleAwaitSubject<Tuple<PushKit.PKPushRegistry, PushKit.PKPushPayload, string>> _DidReceiveIncomingPush = new SingleAwaitSubject<Tuple<PushKit.PKPushRegistry, PushKit.PKPushPayload, string>>();
        public IObservable<Tuple<PushKit.PKPushRegistry, PushKit.PKPushPayload, string>> DidReceiveIncomingPushObs { get { return _DidReceiveIncomingPush; } }
        public override void DidReceiveIncomingPush(PushKit.PKPushRegistry registry, PushKit.PKPushPayload payload, string type)
        {
            _DidReceiveIncomingPush.OnNext(Tuple.Create(registry, payload, type));
        }

        readonly SingleAwaitSubject<Tuple<PushKit.PKPushRegistry, PushKit.PKPushCredentials, string>> _DidUpdatePushCredentials = new SingleAwaitSubject<Tuple<PushKit.PKPushRegistry, PushKit.PKPushCredentials, string>>();
        public IObservable<Tuple<PushKit.PKPushRegistry, PushKit.PKPushCredentials, string>> DidUpdatePushCredentialsObs { get { return _DidUpdatePushCredentials; } }
        public override void DidUpdatePushCredentials(PushKit.PKPushRegistry registry, PushKit.PKPushCredentials credentials, string type)
        {
            _DidUpdatePushCredentials.OnNext(Tuple.Create(registry, credentials, type));
        }

    }
}
namespace QuickLook.Rx
{
    public  partial class QLPreviewControllerDelegateRx : QLPreviewControllerDelegate
    {
        readonly SingleAwaitSubject<QuickLook.QLPreviewController> _DidDismiss = new SingleAwaitSubject<QuickLook.QLPreviewController>();
        public IObservable<QuickLook.QLPreviewController> DidDismissObs { get { return _DidDismiss; } }
        public override void DidDismiss(QuickLook.QLPreviewController controller)
        {
            _DidDismiss.OnNext(controller);
        }

        readonly SingleAwaitSubject<QuickLook.QLPreviewController> _WillDismiss = new SingleAwaitSubject<QuickLook.QLPreviewController>();
        public IObservable<QuickLook.QLPreviewController> WillDismissObs { get { return _WillDismiss; } }
        public override void WillDismiss(QuickLook.QLPreviewController controller)
        {
            _WillDismiss.OnNext(controller);
        }

    }
}
namespace ReplayKit.Rx
{
    public abstract partial class RPBroadcastActivityViewControllerDelegateRx : RPBroadcastActivityViewControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<ReplayKit.RPBroadcastActivityViewController, ReplayKit.RPBroadcastController, Foundation.NSError>> _DidFinish = new SingleAwaitSubject<Tuple<ReplayKit.RPBroadcastActivityViewController, ReplayKit.RPBroadcastController, Foundation.NSError>>();
        public IObservable<Tuple<ReplayKit.RPBroadcastActivityViewController, ReplayKit.RPBroadcastController, Foundation.NSError>> DidFinishObs { get { return _DidFinish; } }
        public override void DidFinish(ReplayKit.RPBroadcastActivityViewController broadcastActivityViewController, ReplayKit.RPBroadcastController broadcastController, Foundation.NSError error)
        {
            _DidFinish.OnNext(Tuple.Create(broadcastActivityViewController, broadcastController, error));
        }

    }
    public  partial class RPBroadcastControllerDelegateRx : RPBroadcastControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<ReplayKit.RPBroadcastController, Foundation.NSError>> _DidFinish = new SingleAwaitSubject<Tuple<ReplayKit.RPBroadcastController, Foundation.NSError>>();
        public IObservable<Tuple<ReplayKit.RPBroadcastController, Foundation.NSError>> DidFinishObs { get { return _DidFinish; } }
        public override void DidFinish(ReplayKit.RPBroadcastController broadcastController, Foundation.NSError error)
        {
            _DidFinish.OnNext(Tuple.Create(broadcastController, error));
        }

        readonly SingleAwaitSubject<Tuple<ReplayKit.RPBroadcastController, Foundation.NSDictionary<Foundation.NSString,Foundation.INSCoding>>> _DidUpdateServiceInfo = new SingleAwaitSubject<Tuple<ReplayKit.RPBroadcastController, Foundation.NSDictionary<Foundation.NSString,Foundation.INSCoding>>>();
        public IObservable<Tuple<ReplayKit.RPBroadcastController, Foundation.NSDictionary<Foundation.NSString,Foundation.INSCoding>>> DidUpdateServiceInfoObs { get { return _DidUpdateServiceInfo; } }
        public override void DidUpdateServiceInfo(ReplayKit.RPBroadcastController broadcastController, Foundation.NSDictionary<Foundation.NSString,Foundation.INSCoding> serviceInfo)
        {
            _DidUpdateServiceInfo.OnNext(Tuple.Create(broadcastController, serviceInfo));
        }

    }
    public  partial class RPPreviewViewControllerDelegateRx : RPPreviewViewControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<ReplayKit.RPPreviewViewController, Foundation.NSSet<Foundation.NSString>>> _DidFinish = new SingleAwaitSubject<Tuple<ReplayKit.RPPreviewViewController, Foundation.NSSet<Foundation.NSString>>>();
        public IObservable<Tuple<ReplayKit.RPPreviewViewController, Foundation.NSSet<Foundation.NSString>>> DidFinishObs { get { return _DidFinish; } }
        public override void DidFinish(ReplayKit.RPPreviewViewController previewController, Foundation.NSSet<Foundation.NSString> activityTypes)
        {
            _DidFinish.OnNext(Tuple.Create(previewController, activityTypes));
        }

    }
    public  partial class RPScreenRecorderDelegateRx : RPScreenRecorderDelegate
    {
        readonly SingleAwaitSubject<ReplayKit.RPScreenRecorder> _DidChangeAvailability = new SingleAwaitSubject<ReplayKit.RPScreenRecorder>();
        public IObservable<ReplayKit.RPScreenRecorder> DidChangeAvailabilityObs { get { return _DidChangeAvailability; } }
        public override void DidChangeAvailability(ReplayKit.RPScreenRecorder screenRecorder)
        {
            _DidChangeAvailability.OnNext(screenRecorder);
        }

        readonly SingleAwaitSubject<Tuple<ReplayKit.RPScreenRecorder, Foundation.NSError, ReplayKit.RPPreviewViewController>> _DidStopRecording = new SingleAwaitSubject<Tuple<ReplayKit.RPScreenRecorder, Foundation.NSError, ReplayKit.RPPreviewViewController>>();
        public IObservable<Tuple<ReplayKit.RPScreenRecorder, Foundation.NSError, ReplayKit.RPPreviewViewController>> DidStopRecordingObs { get { return _DidStopRecording; } }
        public override void DidStopRecording(ReplayKit.RPScreenRecorder screenRecorder, Foundation.NSError error, ReplayKit.RPPreviewViewController previewViewController)
        {
            _DidStopRecording.OnNext(Tuple.Create(screenRecorder, error, previewViewController));
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
namespace SafariServices.Rx
{
    public  partial class SFSafariViewControllerDelegateRx : SFSafariViewControllerDelegate
    {
        readonly SingleAwaitSubject<SafariServices.SFSafariViewController> _DidFinish = new SingleAwaitSubject<SafariServices.SFSafariViewController>();
        public IObservable<SafariServices.SFSafariViewController> DidFinishObs { get { return _DidFinish; } }
        public override void DidFinish(SafariServices.SFSafariViewController controller)
        {
            _DidFinish.OnNext(controller);
        }

        readonly SingleAwaitSubject<Tuple<SafariServices.SFSafariViewController, System.Boolean>> _DidCompleteInitialLoad = new SingleAwaitSubject<Tuple<SafariServices.SFSafariViewController, System.Boolean>>();
        public IObservable<Tuple<SafariServices.SFSafariViewController, System.Boolean>> DidCompleteInitialLoadObs { get { return _DidCompleteInitialLoad; } }
        public override void DidCompleteInitialLoad(SafariServices.SFSafariViewController controller, System.Boolean didLoadSuccessfully)
        {
            _DidCompleteInitialLoad.OnNext(Tuple.Create(controller, didLoadSuccessfully));
        }

    }
}
namespace AVKit.Rx
{
    public  partial class AVPictureInPictureControllerDelegateRx : AVPictureInPictureControllerDelegate
    {
        readonly SingleAwaitSubject<AVKit.AVPictureInPictureController> _DidStartPictureInPicture = new SingleAwaitSubject<AVKit.AVPictureInPictureController>();
        public IObservable<AVKit.AVPictureInPictureController> DidStartPictureInPictureObs { get { return _DidStartPictureInPicture; } }
        public override void DidStartPictureInPicture(AVKit.AVPictureInPictureController pictureInPictureController)
        {
            _DidStartPictureInPicture.OnNext(pictureInPictureController);
        }

        readonly SingleAwaitSubject<AVKit.AVPictureInPictureController> _DidStopPictureInPicture = new SingleAwaitSubject<AVKit.AVPictureInPictureController>();
        public IObservable<AVKit.AVPictureInPictureController> DidStopPictureInPictureObs { get { return _DidStopPictureInPicture; } }
        public override void DidStopPictureInPicture(AVKit.AVPictureInPictureController pictureInPictureController)
        {
            _DidStopPictureInPicture.OnNext(pictureInPictureController);
        }

        readonly SingleAwaitSubject<AVKit.AVPictureInPictureController> _WillStartPictureInPicture = new SingleAwaitSubject<AVKit.AVPictureInPictureController>();
        public IObservable<AVKit.AVPictureInPictureController> WillStartPictureInPictureObs { get { return _WillStartPictureInPicture; } }
        public override void WillStartPictureInPicture(AVKit.AVPictureInPictureController pictureInPictureController)
        {
            _WillStartPictureInPicture.OnNext(pictureInPictureController);
        }

        readonly SingleAwaitSubject<AVKit.AVPictureInPictureController> _WillStopPictureInPicture = new SingleAwaitSubject<AVKit.AVPictureInPictureController>();
        public IObservable<AVKit.AVPictureInPictureController> WillStopPictureInPictureObs { get { return _WillStopPictureInPicture; } }
        public override void WillStopPictureInPicture(AVKit.AVPictureInPictureController pictureInPictureController)
        {
            _WillStopPictureInPicture.OnNext(pictureInPictureController);
        }

        readonly SingleAwaitSubject<Tuple<AVKit.AVPictureInPictureController, Foundation.NSError>> _FailedToStartPictureInPicture = new SingleAwaitSubject<Tuple<AVKit.AVPictureInPictureController, Foundation.NSError>>();
        public IObservable<Tuple<AVKit.AVPictureInPictureController, Foundation.NSError>> FailedToStartPictureInPictureObs { get { return _FailedToStartPictureInPicture; } }
        public override void FailedToStartPictureInPicture(AVKit.AVPictureInPictureController pictureInPictureController, Foundation.NSError error)
        {
            _FailedToStartPictureInPicture.OnNext(Tuple.Create(pictureInPictureController, error));
        }

        readonly SingleAwaitSubject<Tuple<AVKit.AVPictureInPictureController, System.Action<System.Boolean>>> _RestoreUserInterfaceForPictureInPicture = new SingleAwaitSubject<Tuple<AVKit.AVPictureInPictureController, System.Action<System.Boolean>>>();
        public IObservable<Tuple<AVKit.AVPictureInPictureController, System.Action<System.Boolean>>> RestoreUserInterfaceForPictureInPictureObs { get { return _RestoreUserInterfaceForPictureInPicture; } }
        public override void RestoreUserInterfaceForPictureInPicture(AVKit.AVPictureInPictureController pictureInPictureController, System.Action<System.Boolean> completionHandler)
        {
            _RestoreUserInterfaceForPictureInPicture.OnNext(Tuple.Create(pictureInPictureController, completionHandler));
        }

    }
    public  partial class AVPlayerViewControllerDelegateRx : AVPlayerViewControllerDelegate
    {
        readonly SingleAwaitSubject<AVKit.AVPlayerViewController> _DidStartPictureInPicture = new SingleAwaitSubject<AVKit.AVPlayerViewController>();
        public IObservable<AVKit.AVPlayerViewController> DidStartPictureInPictureObs { get { return _DidStartPictureInPicture; } }
        public override void DidStartPictureInPicture(AVKit.AVPlayerViewController playerViewController)
        {
            _DidStartPictureInPicture.OnNext(playerViewController);
        }

        readonly SingleAwaitSubject<AVKit.AVPlayerViewController> _DidStopPictureInPicture = new SingleAwaitSubject<AVKit.AVPlayerViewController>();
        public IObservable<AVKit.AVPlayerViewController> DidStopPictureInPictureObs { get { return _DidStopPictureInPicture; } }
        public override void DidStopPictureInPicture(AVKit.AVPlayerViewController playerViewController)
        {
            _DidStopPictureInPicture.OnNext(playerViewController);
        }

        readonly SingleAwaitSubject<AVKit.AVPlayerViewController> _WillStartPictureInPicture = new SingleAwaitSubject<AVKit.AVPlayerViewController>();
        public IObservable<AVKit.AVPlayerViewController> WillStartPictureInPictureObs { get { return _WillStartPictureInPicture; } }
        public override void WillStartPictureInPicture(AVKit.AVPlayerViewController playerViewController)
        {
            _WillStartPictureInPicture.OnNext(playerViewController);
        }

        readonly SingleAwaitSubject<AVKit.AVPlayerViewController> _WillStopPictureInPicture = new SingleAwaitSubject<AVKit.AVPlayerViewController>();
        public IObservable<AVKit.AVPlayerViewController> WillStopPictureInPictureObs { get { return _WillStopPictureInPicture; } }
        public override void WillStopPictureInPicture(AVKit.AVPlayerViewController playerViewController)
        {
            _WillStopPictureInPicture.OnNext(playerViewController);
        }

        readonly SingleAwaitSubject<Tuple<AVKit.AVPlayerViewController, Foundation.NSError>> _FailedToStartPictureInPicture = new SingleAwaitSubject<Tuple<AVKit.AVPlayerViewController, Foundation.NSError>>();
        public IObservable<Tuple<AVKit.AVPlayerViewController, Foundation.NSError>> FailedToStartPictureInPictureObs { get { return _FailedToStartPictureInPicture; } }
        public override void FailedToStartPictureInPicture(AVKit.AVPlayerViewController playerViewController, Foundation.NSError error)
        {
            _FailedToStartPictureInPicture.OnNext(Tuple.Create(playerViewController, error));
        }

        readonly SingleAwaitSubject<Tuple<AVKit.AVPlayerViewController, System.Action<System.Boolean>>> _RestoreUserInterfaceForPictureInPicture = new SingleAwaitSubject<Tuple<AVKit.AVPlayerViewController, System.Action<System.Boolean>>>();
        public IObservable<Tuple<AVKit.AVPlayerViewController, System.Action<System.Boolean>>> RestoreUserInterfaceForPictureInPictureObs { get { return _RestoreUserInterfaceForPictureInPicture; } }
        public override void RestoreUserInterfaceForPictureInPicture(AVKit.AVPlayerViewController playerViewController, System.Action<System.Boolean> completionHandler)
        {
            _RestoreUserInterfaceForPictureInPicture.OnNext(Tuple.Create(playerViewController, completionHandler));
        }

    }
}
namespace AddressBookUI.Rx
{
    public abstract partial class ABNewPersonViewControllerDelegateRx : ABNewPersonViewControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<AddressBookUI.ABNewPersonViewController, AddressBook.ABPerson>> _DidCompleteWithNewPerson = new SingleAwaitSubject<Tuple<AddressBookUI.ABNewPersonViewController, AddressBook.ABPerson>>();
        public IObservable<Tuple<AddressBookUI.ABNewPersonViewController, AddressBook.ABPerson>> DidCompleteWithNewPersonObs { get { return _DidCompleteWithNewPerson; } }
        public override void DidCompleteWithNewPerson(AddressBookUI.ABNewPersonViewController controller, AddressBook.ABPerson person)
        {
            _DidCompleteWithNewPerson.OnNext(Tuple.Create(controller, person));
        }

    }
    public  partial class ABPeoplePickerNavigationControllerDelegateRx : ABPeoplePickerNavigationControllerDelegate
    {
        readonly SingleAwaitSubject<AddressBookUI.ABPeoplePickerNavigationController> _Cancelled = new SingleAwaitSubject<AddressBookUI.ABPeoplePickerNavigationController>();
        public IObservable<AddressBookUI.ABPeoplePickerNavigationController> CancelledObs { get { return _Cancelled; } }
        public override void Cancelled(AddressBookUI.ABPeoplePickerNavigationController peoplePicker)
        {
            _Cancelled.OnNext(peoplePicker);
        }

        readonly SingleAwaitSubject<Tuple<AddressBookUI.ABPeoplePickerNavigationController, AddressBook.ABPerson, System.Int32, System.Int32>> _DidSelectPerson = new SingleAwaitSubject<Tuple<AddressBookUI.ABPeoplePickerNavigationController, AddressBook.ABPerson, System.Int32, System.Int32>>();
        public IObservable<Tuple<AddressBookUI.ABPeoplePickerNavigationController, AddressBook.ABPerson, System.Int32, System.Int32>> DidSelectPersonObs { get { return _DidSelectPerson; } }
        public override void DidSelectPerson(AddressBookUI.ABPeoplePickerNavigationController peoplePicker, AddressBook.ABPerson selectedPerson, System.Int32 propertyId, System.Int32 identifier)
        {
            _DidSelectPerson.OnNext(Tuple.Create(peoplePicker, selectedPerson, propertyId, identifier));
        }

    }
    public abstract partial class ABUnknownPersonViewControllerDelegateRx : ABUnknownPersonViewControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<AddressBookUI.ABUnknownPersonViewController, AddressBook.ABPerson>> _DidResolveToPerson = new SingleAwaitSubject<Tuple<AddressBookUI.ABUnknownPersonViewController, AddressBook.ABPerson>>();
        public IObservable<Tuple<AddressBookUI.ABUnknownPersonViewController, AddressBook.ABPerson>> DidResolveToPersonObs { get { return _DidResolveToPerson; } }
        public override void DidResolveToPerson(AddressBookUI.ABUnknownPersonViewController unknownPersonView, AddressBook.ABPerson person)
        {
            _DidResolveToPerson.OnNext(Tuple.Create(unknownPersonView, person));
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
namespace CallKit.Rx
{
    public abstract partial class CXCallDirectoryExtensionContextDelegateRx : CXCallDirectoryExtensionContextDelegate
    {
        readonly SingleAwaitSubject<Tuple<CallKit.CXCallDirectoryExtensionContext, Foundation.NSError>> _RequestFailed = new SingleAwaitSubject<Tuple<CallKit.CXCallDirectoryExtensionContext, Foundation.NSError>>();
        public IObservable<Tuple<CallKit.CXCallDirectoryExtensionContext, Foundation.NSError>> RequestFailedObs { get { return _RequestFailed; } }
        public override void RequestFailed(CallKit.CXCallDirectoryExtensionContext extensionContext, Foundation.NSError error)
        {
            _RequestFailed.OnNext(Tuple.Create(extensionContext, error));
        }

    }
    public abstract partial class CXCallObserverDelegateRx : CXCallObserverDelegate
    {
        readonly SingleAwaitSubject<Tuple<CallKit.CXCallObserver, CallKit.CXCall>> _CallChanged = new SingleAwaitSubject<Tuple<CallKit.CXCallObserver, CallKit.CXCall>>();
        public IObservable<Tuple<CallKit.CXCallObserver, CallKit.CXCall>> CallChangedObs { get { return _CallChanged; } }
        public override void CallChanged(CallKit.CXCallObserver callObserver, CallKit.CXCall call)
        {
            _CallChanged.OnNext(Tuple.Create(callObserver, call));
        }

    }
    public abstract partial class CXProviderDelegateRx : CXProviderDelegate
    {
        readonly SingleAwaitSubject<CallKit.CXProvider> _DidBegin = new SingleAwaitSubject<CallKit.CXProvider>();
        public IObservable<CallKit.CXProvider> DidBeginObs { get { return _DidBegin; } }
        public override void DidBegin(CallKit.CXProvider provider)
        {
            _DidBegin.OnNext(provider);
        }

        readonly SingleAwaitSubject<CallKit.CXProvider> _DidReset = new SingleAwaitSubject<CallKit.CXProvider>();
        public IObservable<CallKit.CXProvider> DidResetObs { get { return _DidReset; } }
        public override void DidReset(CallKit.CXProvider provider)
        {
            _DidReset.OnNext(provider);
        }

        readonly SingleAwaitSubject<Tuple<CallKit.CXProvider, AVFoundation.AVAudioSession>> _DidActivateAudioSession = new SingleAwaitSubject<Tuple<CallKit.CXProvider, AVFoundation.AVAudioSession>>();
        public IObservable<Tuple<CallKit.CXProvider, AVFoundation.AVAudioSession>> DidActivateAudioSessionObs { get { return _DidActivateAudioSession; } }
        public override void DidActivateAudioSession(CallKit.CXProvider provider, AVFoundation.AVAudioSession audioSession)
        {
            _DidActivateAudioSession.OnNext(Tuple.Create(provider, audioSession));
        }

        readonly SingleAwaitSubject<Tuple<CallKit.CXProvider, AVFoundation.AVAudioSession>> _DidDeactivateAudioSession = new SingleAwaitSubject<Tuple<CallKit.CXProvider, AVFoundation.AVAudioSession>>();
        public IObservable<Tuple<CallKit.CXProvider, AVFoundation.AVAudioSession>> DidDeactivateAudioSessionObs { get { return _DidDeactivateAudioSession; } }
        public override void DidDeactivateAudioSession(CallKit.CXProvider provider, AVFoundation.AVAudioSession audioSession)
        {
            _DidDeactivateAudioSession.OnNext(Tuple.Create(provider, audioSession));
        }

        readonly SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXAnswerCallAction>> _PerformAnswerCallAction = new SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXAnswerCallAction>>();
        public IObservable<Tuple<CallKit.CXProvider, CallKit.CXAnswerCallAction>> PerformAnswerCallActionObs { get { return _PerformAnswerCallAction; } }
        public override void PerformAnswerCallAction(CallKit.CXProvider provider, CallKit.CXAnswerCallAction action)
        {
            _PerformAnswerCallAction.OnNext(Tuple.Create(provider, action));
        }

        readonly SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXEndCallAction>> _PerformEndCallAction = new SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXEndCallAction>>();
        public IObservable<Tuple<CallKit.CXProvider, CallKit.CXEndCallAction>> PerformEndCallActionObs { get { return _PerformEndCallAction; } }
        public override void PerformEndCallAction(CallKit.CXProvider provider, CallKit.CXEndCallAction action)
        {
            _PerformEndCallAction.OnNext(Tuple.Create(provider, action));
        }

        readonly SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXPlayDtmfCallAction>> _PerformPlayDtmfCallAction = new SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXPlayDtmfCallAction>>();
        public IObservable<Tuple<CallKit.CXProvider, CallKit.CXPlayDtmfCallAction>> PerformPlayDtmfCallActionObs { get { return _PerformPlayDtmfCallAction; } }
        public override void PerformPlayDtmfCallAction(CallKit.CXProvider provider, CallKit.CXPlayDtmfCallAction action)
        {
            _PerformPlayDtmfCallAction.OnNext(Tuple.Create(provider, action));
        }

        readonly SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXSetGroupCallAction>> _PerformSetGroupCallAction = new SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXSetGroupCallAction>>();
        public IObservable<Tuple<CallKit.CXProvider, CallKit.CXSetGroupCallAction>> PerformSetGroupCallActionObs { get { return _PerformSetGroupCallAction; } }
        public override void PerformSetGroupCallAction(CallKit.CXProvider provider, CallKit.CXSetGroupCallAction action)
        {
            _PerformSetGroupCallAction.OnNext(Tuple.Create(provider, action));
        }

        readonly SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXSetHeldCallAction>> _PerformSetHeldCallAction = new SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXSetHeldCallAction>>();
        public IObservable<Tuple<CallKit.CXProvider, CallKit.CXSetHeldCallAction>> PerformSetHeldCallActionObs { get { return _PerformSetHeldCallAction; } }
        public override void PerformSetHeldCallAction(CallKit.CXProvider provider, CallKit.CXSetHeldCallAction action)
        {
            _PerformSetHeldCallAction.OnNext(Tuple.Create(provider, action));
        }

        readonly SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXSetMutedCallAction>> _PerformSetMutedCallAction = new SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXSetMutedCallAction>>();
        public IObservable<Tuple<CallKit.CXProvider, CallKit.CXSetMutedCallAction>> PerformSetMutedCallActionObs { get { return _PerformSetMutedCallAction; } }
        public override void PerformSetMutedCallAction(CallKit.CXProvider provider, CallKit.CXSetMutedCallAction action)
        {
            _PerformSetMutedCallAction.OnNext(Tuple.Create(provider, action));
        }

        readonly SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXStartCallAction>> _PerformStartCallAction = new SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXStartCallAction>>();
        public IObservable<Tuple<CallKit.CXProvider, CallKit.CXStartCallAction>> PerformStartCallActionObs { get { return _PerformStartCallAction; } }
        public override void PerformStartCallAction(CallKit.CXProvider provider, CallKit.CXStartCallAction action)
        {
            _PerformStartCallAction.OnNext(Tuple.Create(provider, action));
        }

        readonly SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXAction>> _TimedOutPerformingAction = new SingleAwaitSubject<Tuple<CallKit.CXProvider, CallKit.CXAction>>();
        public IObservable<Tuple<CallKit.CXProvider, CallKit.CXAction>> TimedOutPerformingActionObs { get { return _TimedOutPerformingAction; } }
        public override void TimedOutPerformingAction(CallKit.CXProvider provider, CallKit.CXAction action)
        {
            _TimedOutPerformingAction.OnNext(Tuple.Create(provider, action));
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
namespace HomeKit.Rx
{
    public  partial class HMAccessoryBrowserDelegateRx : HMAccessoryBrowserDelegate
    {
        readonly SingleAwaitSubject<Tuple<HomeKit.HMAccessoryBrowser, HomeKit.HMAccessory>> _DidFindNewAccessory = new SingleAwaitSubject<Tuple<HomeKit.HMAccessoryBrowser, HomeKit.HMAccessory>>();
        public IObservable<Tuple<HomeKit.HMAccessoryBrowser, HomeKit.HMAccessory>> DidFindNewAccessoryObs { get { return _DidFindNewAccessory; } }
        public override void DidFindNewAccessory(HomeKit.HMAccessoryBrowser browser, HomeKit.HMAccessory accessory)
        {
            _DidFindNewAccessory.OnNext(Tuple.Create(browser, accessory));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMAccessoryBrowser, HomeKit.HMAccessory>> _DidRemoveNewAccessory = new SingleAwaitSubject<Tuple<HomeKit.HMAccessoryBrowser, HomeKit.HMAccessory>>();
        public IObservable<Tuple<HomeKit.HMAccessoryBrowser, HomeKit.HMAccessory>> DidRemoveNewAccessoryObs { get { return _DidRemoveNewAccessory; } }
        public override void DidRemoveNewAccessory(HomeKit.HMAccessoryBrowser browser, HomeKit.HMAccessory accessory)
        {
            _DidRemoveNewAccessory.OnNext(Tuple.Create(browser, accessory));
        }

    }
    public  partial class HMAccessoryDelegateRx : HMAccessoryDelegate
    {
        readonly SingleAwaitSubject<HomeKit.HMAccessory> _DidUpdateName = new SingleAwaitSubject<HomeKit.HMAccessory>();
        public IObservable<HomeKit.HMAccessory> DidUpdateNameObs { get { return _DidUpdateName; } }
        public override void DidUpdateName(HomeKit.HMAccessory accessory)
        {
            _DidUpdateName.OnNext(accessory);
        }

        readonly SingleAwaitSubject<HomeKit.HMAccessory> _DidUpdateReachability = new SingleAwaitSubject<HomeKit.HMAccessory>();
        public IObservable<HomeKit.HMAccessory> DidUpdateReachabilityObs { get { return _DidUpdateReachability; } }
        public override void DidUpdateReachability(HomeKit.HMAccessory accessory)
        {
            _DidUpdateReachability.OnNext(accessory);
        }

        readonly SingleAwaitSubject<HomeKit.HMAccessory> _DidUpdateServices = new SingleAwaitSubject<HomeKit.HMAccessory>();
        public IObservable<HomeKit.HMAccessory> DidUpdateServicesObs { get { return _DidUpdateServices; } }
        public override void DidUpdateServices(HomeKit.HMAccessory accessory)
        {
            _DidUpdateServices.OnNext(accessory);
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMAccessory, HomeKit.HMService>> _DidUpdateAssociatedServiceType = new SingleAwaitSubject<Tuple<HomeKit.HMAccessory, HomeKit.HMService>>();
        public IObservable<Tuple<HomeKit.HMAccessory, HomeKit.HMService>> DidUpdateAssociatedServiceTypeObs { get { return _DidUpdateAssociatedServiceType; } }
        public override void DidUpdateAssociatedServiceType(HomeKit.HMAccessory accessory, HomeKit.HMService service)
        {
            _DidUpdateAssociatedServiceType.OnNext(Tuple.Create(accessory, service));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMAccessory, HomeKit.HMService>> _DidUpdateNameForService = new SingleAwaitSubject<Tuple<HomeKit.HMAccessory, HomeKit.HMService>>();
        public IObservable<Tuple<HomeKit.HMAccessory, HomeKit.HMService>> DidUpdateNameForServiceObs { get { return _DidUpdateNameForService; } }
        public override void DidUpdateNameForService(HomeKit.HMAccessory accessory, HomeKit.HMService service)
        {
            _DidUpdateNameForService.OnNext(Tuple.Create(accessory, service));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMAccessory, HomeKit.HMService, HomeKit.HMCharacteristic>> _DidUpdateValueForCharacteristic = new SingleAwaitSubject<Tuple<HomeKit.HMAccessory, HomeKit.HMService, HomeKit.HMCharacteristic>>();
        public IObservable<Tuple<HomeKit.HMAccessory, HomeKit.HMService, HomeKit.HMCharacteristic>> DidUpdateValueForCharacteristicObs { get { return _DidUpdateValueForCharacteristic; } }
        public override void DidUpdateValueForCharacteristic(HomeKit.HMAccessory accessory, HomeKit.HMService service, HomeKit.HMCharacteristic characteristic)
        {
            _DidUpdateValueForCharacteristic.OnNext(Tuple.Create(accessory, service, characteristic));
        }

    }
    public  partial class HMCameraSnapshotControlDelegateRx : HMCameraSnapshotControlDelegate
    {
        readonly SingleAwaitSubject<Tuple<HomeKit.HMCameraSnapshotControl, HomeKit.HMCameraSnapshot, Foundation.NSError>> _DidTakeSnapshot = new SingleAwaitSubject<Tuple<HomeKit.HMCameraSnapshotControl, HomeKit.HMCameraSnapshot, Foundation.NSError>>();
        public IObservable<Tuple<HomeKit.HMCameraSnapshotControl, HomeKit.HMCameraSnapshot, Foundation.NSError>> DidTakeSnapshotObs { get { return _DidTakeSnapshot; } }
        public override void DidTakeSnapshot(HomeKit.HMCameraSnapshotControl cameraSnapshotControl, HomeKit.HMCameraSnapshot snapshot, Foundation.NSError error)
        {
            _DidTakeSnapshot.OnNext(Tuple.Create(cameraSnapshotControl, snapshot, error));
        }

    }
    public  partial class HMCameraStreamControlDelegateRx : HMCameraStreamControlDelegate
    {
        readonly SingleAwaitSubject<HomeKit.HMCameraStreamControl> _DidStartStream = new SingleAwaitSubject<HomeKit.HMCameraStreamControl>();
        public IObservable<HomeKit.HMCameraStreamControl> DidStartStreamObs { get { return _DidStartStream; } }
        public override void DidStartStream(HomeKit.HMCameraStreamControl cameraStreamControl)
        {
            _DidStartStream.OnNext(cameraStreamControl);
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMCameraStreamControl, Foundation.NSError>> _DidStopStream = new SingleAwaitSubject<Tuple<HomeKit.HMCameraStreamControl, Foundation.NSError>>();
        public IObservable<Tuple<HomeKit.HMCameraStreamControl, Foundation.NSError>> DidStopStreamObs { get { return _DidStopStream; } }
        public override void DidStopStream(HomeKit.HMCameraStreamControl cameraStreamControl, Foundation.NSError error)
        {
            _DidStopStream.OnNext(Tuple.Create(cameraStreamControl, error));
        }

    }
    public  partial class HMHomeDelegateRx : HMHomeDelegate
    {
        readonly SingleAwaitSubject<HomeKit.HMHome> _DidUpdateNameForHome = new SingleAwaitSubject<HomeKit.HMHome>();
        public IObservable<HomeKit.HMHome> DidUpdateNameForHomeObs { get { return _DidUpdateNameForHome; } }
        public override void DidUpdateNameForHome(HomeKit.HMHome home)
        {
            _DidUpdateNameForHome.OnNext(home);
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMAccessory>> _DidAddAccessory = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMAccessory>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMAccessory>> DidAddAccessoryObs { get { return _DidAddAccessory; } }
        public override void DidAddAccessory(HomeKit.HMHome home, HomeKit.HMAccessory accessory)
        {
            _DidAddAccessory.OnNext(Tuple.Create(home, accessory));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMActionSet>> _DidAddActionSet = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMActionSet>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMActionSet>> DidAddActionSetObs { get { return _DidAddActionSet; } }
        public override void DidAddActionSet(HomeKit.HMHome home, HomeKit.HMActionSet actionSet)
        {
            _DidAddActionSet.OnNext(Tuple.Create(home, actionSet));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMRoom>> _DidAddRoom = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMRoom>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMRoom>> DidAddRoomObs { get { return _DidAddRoom; } }
        public override void DidAddRoom(HomeKit.HMHome home, HomeKit.HMRoom room)
        {
            _DidAddRoom.OnNext(Tuple.Create(home, room));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMRoom, HomeKit.HMZone>> _DidAddRoomToZone = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMRoom, HomeKit.HMZone>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMRoom, HomeKit.HMZone>> DidAddRoomToZoneObs { get { return _DidAddRoomToZone; } }
        public override void DidAddRoomToZone(HomeKit.HMHome home, HomeKit.HMRoom room, HomeKit.HMZone zone)
        {
            _DidAddRoomToZone.OnNext(Tuple.Create(home, room, zone));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMService, HomeKit.HMServiceGroup>> _DidAddService = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMService, HomeKit.HMServiceGroup>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMService, HomeKit.HMServiceGroup>> DidAddServiceObs { get { return _DidAddService; } }
        public override void DidAddService(HomeKit.HMHome home, HomeKit.HMService service, HomeKit.HMServiceGroup group)
        {
            _DidAddService.OnNext(Tuple.Create(home, service, group));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMServiceGroup>> _DidAddServiceGroup = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMServiceGroup>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMServiceGroup>> DidAddServiceGroupObs { get { return _DidAddServiceGroup; } }
        public override void DidAddServiceGroup(HomeKit.HMHome home, HomeKit.HMServiceGroup group)
        {
            _DidAddServiceGroup.OnNext(Tuple.Create(home, group));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMTrigger>> _DidAddTrigger = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMTrigger>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMTrigger>> DidAddTriggerObs { get { return _DidAddTrigger; } }
        public override void DidAddTrigger(HomeKit.HMHome home, HomeKit.HMTrigger trigger)
        {
            _DidAddTrigger.OnNext(Tuple.Create(home, trigger));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMUser>> _DidAddUser = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMUser>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMUser>> DidAddUserObs { get { return _DidAddUser; } }
        public override void DidAddUser(HomeKit.HMHome home, HomeKit.HMUser user)
        {
            _DidAddUser.OnNext(Tuple.Create(home, user));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMZone>> _DidAddZone = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMZone>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMZone>> DidAddZoneObs { get { return _DidAddZone; } }
        public override void DidAddZone(HomeKit.HMHome home, HomeKit.HMZone zone)
        {
            _DidAddZone.OnNext(Tuple.Create(home, zone));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, Foundation.NSError, HomeKit.HMAccessory>> _DidEncounterError = new SingleAwaitSubject<Tuple<HomeKit.HMHome, Foundation.NSError, HomeKit.HMAccessory>>();
        public IObservable<Tuple<HomeKit.HMHome, Foundation.NSError, HomeKit.HMAccessory>> DidEncounterErrorObs { get { return _DidEncounterError; } }
        public override void DidEncounterError(HomeKit.HMHome home, Foundation.NSError error, HomeKit.HMAccessory accessory)
        {
            _DidEncounterError.OnNext(Tuple.Create(home, error, accessory));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMAccessory>> _DidRemoveAccessory = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMAccessory>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMAccessory>> DidRemoveAccessoryObs { get { return _DidRemoveAccessory; } }
        public override void DidRemoveAccessory(HomeKit.HMHome home, HomeKit.HMAccessory accessory)
        {
            _DidRemoveAccessory.OnNext(Tuple.Create(home, accessory));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMActionSet>> _DidRemoveActionSet = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMActionSet>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMActionSet>> DidRemoveActionSetObs { get { return _DidRemoveActionSet; } }
        public override void DidRemoveActionSet(HomeKit.HMHome home, HomeKit.HMActionSet actionSet)
        {
            _DidRemoveActionSet.OnNext(Tuple.Create(home, actionSet));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMRoom>> _DidRemoveRoom = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMRoom>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMRoom>> DidRemoveRoomObs { get { return _DidRemoveRoom; } }
        public override void DidRemoveRoom(HomeKit.HMHome home, HomeKit.HMRoom room)
        {
            _DidRemoveRoom.OnNext(Tuple.Create(home, room));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMRoom, HomeKit.HMZone>> _DidRemoveRoomFromZone = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMRoom, HomeKit.HMZone>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMRoom, HomeKit.HMZone>> DidRemoveRoomFromZoneObs { get { return _DidRemoveRoomFromZone; } }
        public override void DidRemoveRoomFromZone(HomeKit.HMHome home, HomeKit.HMRoom room, HomeKit.HMZone zone)
        {
            _DidRemoveRoomFromZone.OnNext(Tuple.Create(home, room, zone));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMService, HomeKit.HMServiceGroup>> _DidRemoveService = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMService, HomeKit.HMServiceGroup>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMService, HomeKit.HMServiceGroup>> DidRemoveServiceObs { get { return _DidRemoveService; } }
        public override void DidRemoveService(HomeKit.HMHome home, HomeKit.HMService service, HomeKit.HMServiceGroup group)
        {
            _DidRemoveService.OnNext(Tuple.Create(home, service, group));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMServiceGroup>> _DidRemoveServiceGroup = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMServiceGroup>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMServiceGroup>> DidRemoveServiceGroupObs { get { return _DidRemoveServiceGroup; } }
        public override void DidRemoveServiceGroup(HomeKit.HMHome home, HomeKit.HMServiceGroup group)
        {
            _DidRemoveServiceGroup.OnNext(Tuple.Create(home, group));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMTrigger>> _DidRemoveTrigger = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMTrigger>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMTrigger>> DidRemoveTriggerObs { get { return _DidRemoveTrigger; } }
        public override void DidRemoveTrigger(HomeKit.HMHome home, HomeKit.HMTrigger trigger)
        {
            _DidRemoveTrigger.OnNext(Tuple.Create(home, trigger));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMUser>> _DidRemoveUser = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMUser>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMUser>> DidRemoveUserObs { get { return _DidRemoveUser; } }
        public override void DidRemoveUser(HomeKit.HMHome home, HomeKit.HMUser user)
        {
            _DidRemoveUser.OnNext(Tuple.Create(home, user));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMZone>> _DidRemoveZone = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMZone>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMZone>> DidRemoveZoneObs { get { return _DidRemoveZone; } }
        public override void DidRemoveZone(HomeKit.HMHome home, HomeKit.HMZone zone)
        {
            _DidRemoveZone.OnNext(Tuple.Create(home, zone));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMAccessory>> _DidUnblockAccessory = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMAccessory>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMAccessory>> DidUnblockAccessoryObs { get { return _DidUnblockAccessory; } }
        public override void DidUnblockAccessory(HomeKit.HMHome home, HomeKit.HMAccessory accessory)
        {
            _DidUnblockAccessory.OnNext(Tuple.Create(home, accessory));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMActionSet>> _DidUpdateActionsForActionSet = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMActionSet>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMActionSet>> DidUpdateActionsForActionSetObs { get { return _DidUpdateActionsForActionSet; } }
        public override void DidUpdateActionsForActionSet(HomeKit.HMHome home, HomeKit.HMActionSet actionSet)
        {
            _DidUpdateActionsForActionSet.OnNext(Tuple.Create(home, actionSet));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMActionSet>> _DidUpdateNameForActionSet = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMActionSet>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMActionSet>> DidUpdateNameForActionSetObs { get { return _DidUpdateNameForActionSet; } }
        public override void DidUpdateNameForActionSet(HomeKit.HMHome home, HomeKit.HMActionSet actionSet)
        {
            _DidUpdateNameForActionSet.OnNext(Tuple.Create(home, actionSet));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMRoom>> _DidUpdateNameForRoom = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMRoom>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMRoom>> DidUpdateNameForRoomObs { get { return _DidUpdateNameForRoom; } }
        public override void DidUpdateNameForRoom(HomeKit.HMHome home, HomeKit.HMRoom room)
        {
            _DidUpdateNameForRoom.OnNext(Tuple.Create(home, room));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMServiceGroup>> _DidUpdateNameForServiceGroup = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMServiceGroup>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMServiceGroup>> DidUpdateNameForServiceGroupObs { get { return _DidUpdateNameForServiceGroup; } }
        public override void DidUpdateNameForServiceGroup(HomeKit.HMHome home, HomeKit.HMServiceGroup group)
        {
            _DidUpdateNameForServiceGroup.OnNext(Tuple.Create(home, group));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMTrigger>> _DidUpdateNameForTrigger = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMTrigger>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMTrigger>> DidUpdateNameForTriggerObs { get { return _DidUpdateNameForTrigger; } }
        public override void DidUpdateNameForTrigger(HomeKit.HMHome home, HomeKit.HMTrigger trigger)
        {
            _DidUpdateNameForTrigger.OnNext(Tuple.Create(home, trigger));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMZone>> _DidUpdateNameForZone = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMZone>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMZone>> DidUpdateNameForZoneObs { get { return _DidUpdateNameForZone; } }
        public override void DidUpdateNameForZone(HomeKit.HMHome home, HomeKit.HMZone zone)
        {
            _DidUpdateNameForZone.OnNext(Tuple.Create(home, zone));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMRoom, HomeKit.HMAccessory>> _DidUpdateRoom = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMRoom, HomeKit.HMAccessory>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMRoom, HomeKit.HMAccessory>> DidUpdateRoomObs { get { return _DidUpdateRoom; } }
        public override void DidUpdateRoom(HomeKit.HMHome home, HomeKit.HMRoom room, HomeKit.HMAccessory accessory)
        {
            _DidUpdateRoom.OnNext(Tuple.Create(home, room, accessory));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMTrigger>> _DidUpdateTrigger = new SingleAwaitSubject<Tuple<HomeKit.HMHome, HomeKit.HMTrigger>>();
        public IObservable<Tuple<HomeKit.HMHome, HomeKit.HMTrigger>> DidUpdateTriggerObs { get { return _DidUpdateTrigger; } }
        public override void DidUpdateTrigger(HomeKit.HMHome home, HomeKit.HMTrigger trigger)
        {
            _DidUpdateTrigger.OnNext(Tuple.Create(home, trigger));
        }

    }
    public  partial class HMHomeManagerDelegateRx : HMHomeManagerDelegate
    {
        readonly SingleAwaitSubject<HomeKit.HMHomeManager> _DidUpdateHomes = new SingleAwaitSubject<HomeKit.HMHomeManager>();
        public IObservable<HomeKit.HMHomeManager> DidUpdateHomesObs { get { return _DidUpdateHomes; } }
        public override void DidUpdateHomes(HomeKit.HMHomeManager manager)
        {
            _DidUpdateHomes.OnNext(manager);
        }

        readonly SingleAwaitSubject<HomeKit.HMHomeManager> _DidUpdatePrimaryHome = new SingleAwaitSubject<HomeKit.HMHomeManager>();
        public IObservable<HomeKit.HMHomeManager> DidUpdatePrimaryHomeObs { get { return _DidUpdatePrimaryHome; } }
        public override void DidUpdatePrimaryHome(HomeKit.HMHomeManager manager)
        {
            _DidUpdatePrimaryHome.OnNext(manager);
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHomeManager, HomeKit.HMHome>> _DidAddHome = new SingleAwaitSubject<Tuple<HomeKit.HMHomeManager, HomeKit.HMHome>>();
        public IObservable<Tuple<HomeKit.HMHomeManager, HomeKit.HMHome>> DidAddHomeObs { get { return _DidAddHome; } }
        public override void DidAddHome(HomeKit.HMHomeManager manager, HomeKit.HMHome home)
        {
            _DidAddHome.OnNext(Tuple.Create(manager, home));
        }

        readonly SingleAwaitSubject<Tuple<HomeKit.HMHomeManager, HomeKit.HMHome>> _DidRemoveHome = new SingleAwaitSubject<Tuple<HomeKit.HMHomeManager, HomeKit.HMHome>>();
        public IObservable<Tuple<HomeKit.HMHomeManager, HomeKit.HMHome>> DidRemoveHomeObs { get { return _DidRemoveHome; } }
        public override void DidRemoveHome(HomeKit.HMHomeManager manager, HomeKit.HMHome home)
        {
            _DidRemoveHome.OnNext(Tuple.Create(manager, home));
        }

    }
}
namespace MediaPlayer.Rx
{
    public  partial class MPPlayableContentDelegateRx : MPPlayableContentDelegate
    {
        readonly SingleAwaitSubject<Tuple<MediaPlayer.MPPlayableContentManager, Foundation.NSIndexPath, System.Action<Foundation.NSError>>> _PlayableContentManager = new SingleAwaitSubject<Tuple<MediaPlayer.MPPlayableContentManager, Foundation.NSIndexPath, System.Action<Foundation.NSError>>>();
        public IObservable<Tuple<MediaPlayer.MPPlayableContentManager, Foundation.NSIndexPath, System.Action<Foundation.NSError>>> PlayableContentManagerObs { get { return _PlayableContentManager; } }
        public override void PlayableContentManager(MediaPlayer.MPPlayableContentManager contentManager, Foundation.NSIndexPath indexPath, System.Action<Foundation.NSError> completionHandler)
        {
            _PlayableContentManager.OnNext(Tuple.Create(contentManager, indexPath, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<MediaPlayer.MPPlayableContentManager, MediaPlayer.MPPlayableContentManagerContext>> _ContextUpdated = new SingleAwaitSubject<Tuple<MediaPlayer.MPPlayableContentManager, MediaPlayer.MPPlayableContentManagerContext>>();
        public IObservable<Tuple<MediaPlayer.MPPlayableContentManager, MediaPlayer.MPPlayableContentManagerContext>> ContextUpdatedObs { get { return _ContextUpdated; } }
        public override void ContextUpdated(MediaPlayer.MPPlayableContentManager contentManager, MediaPlayer.MPPlayableContentManagerContext context)
        {
            _ContextUpdated.OnNext(Tuple.Create(contentManager, context));
        }

        readonly SingleAwaitSubject<Tuple<MediaPlayer.MPPlayableContentManager, MediaPlayer.MPContentItem[], System.Action<Foundation.NSError>>> _InitializePlaybackQueue = new SingleAwaitSubject<Tuple<MediaPlayer.MPPlayableContentManager, MediaPlayer.MPContentItem[], System.Action<Foundation.NSError>>>();
        public IObservable<Tuple<MediaPlayer.MPPlayableContentManager, MediaPlayer.MPContentItem[], System.Action<Foundation.NSError>>> InitializePlaybackQueueObs { get { return _InitializePlaybackQueue; } }
        public override void InitializePlaybackQueue(MediaPlayer.MPPlayableContentManager contentManager, MediaPlayer.MPContentItem[] contentItems, System.Action<Foundation.NSError> completionHandler)
        {
            _InitializePlaybackQueue.OnNext(Tuple.Create(contentManager, contentItems, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<MediaPlayer.MPPlayableContentManager, Foundation.NSIndexPath, System.Action<Foundation.NSError>>> _InitiatePlaybackOfContentItem = new SingleAwaitSubject<Tuple<MediaPlayer.MPPlayableContentManager, Foundation.NSIndexPath, System.Action<Foundation.NSError>>>();
        public IObservable<Tuple<MediaPlayer.MPPlayableContentManager, Foundation.NSIndexPath, System.Action<Foundation.NSError>>> InitiatePlaybackOfContentItemObs { get { return _InitiatePlaybackOfContentItem; } }
        public override void InitiatePlaybackOfContentItem(MediaPlayer.MPPlayableContentManager contentManager, Foundation.NSIndexPath indexPath, System.Action<Foundation.NSError> completionHandler)
        {
            _InitiatePlaybackOfContentItem.OnNext(Tuple.Create(contentManager, indexPath, completionHandler));
        }

    }
    public  partial class MPMediaPickerControllerDelegateRx : MPMediaPickerControllerDelegate
    {
        readonly SingleAwaitSubject<MediaPlayer.MPMediaPickerController> _MediaPickerDidCancel = new SingleAwaitSubject<MediaPlayer.MPMediaPickerController>();
        public IObservable<MediaPlayer.MPMediaPickerController> MediaPickerDidCancelObs { get { return _MediaPickerDidCancel; } }
        public override void MediaPickerDidCancel(MediaPlayer.MPMediaPickerController sender)
        {
            _MediaPickerDidCancel.OnNext(sender);
        }

        readonly SingleAwaitSubject<Tuple<MediaPlayer.MPMediaPickerController, MediaPlayer.MPMediaItemCollection>> _MediaItemsPicked = new SingleAwaitSubject<Tuple<MediaPlayer.MPMediaPickerController, MediaPlayer.MPMediaItemCollection>>();
        public IObservable<Tuple<MediaPlayer.MPMediaPickerController, MediaPlayer.MPMediaItemCollection>> MediaItemsPickedObs { get { return _MediaItemsPicked; } }
        public override void MediaItemsPicked(MediaPlayer.MPMediaPickerController sender, MediaPlayer.MPMediaItemCollection mediaItemCollection)
        {
            _MediaItemsPicked.OnNext(Tuple.Create(sender, mediaItemCollection));
        }

    }
}
namespace UIKit.Rx
{
    public  partial class UIAdaptivePresentationControllerDelegateRx : UIAdaptivePresentationControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.UIPresentationController, UIKit.UIModalPresentationStyle, UIKit.IUIViewControllerTransitionCoordinator>> _WillPresent = new SingleAwaitSubject<Tuple<UIKit.UIPresentationController, UIKit.UIModalPresentationStyle, UIKit.IUIViewControllerTransitionCoordinator>>();
        public IObservable<Tuple<UIKit.UIPresentationController, UIKit.UIModalPresentationStyle, UIKit.IUIViewControllerTransitionCoordinator>> WillPresentObs { get { return _WillPresent; } }
        public override void WillPresent(UIKit.UIPresentationController presentationController, UIKit.UIModalPresentationStyle style, UIKit.IUIViewControllerTransitionCoordinator transitionCoordinator)
        {
            _WillPresent.OnNext(Tuple.Create(presentationController, style, transitionCoordinator));
        }

    }
    public  partial class UIPopoverPresentationControllerDelegateRx : UIPopoverPresentationControllerDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIPopoverPresentationController> _DidDismissPopover = new SingleAwaitSubject<UIKit.UIPopoverPresentationController>();
        public IObservable<UIKit.UIPopoverPresentationController> DidDismissPopoverObs { get { return _DidDismissPopover; } }
        public override void DidDismissPopover(UIKit.UIPopoverPresentationController popoverPresentationController)
        {
            _DidDismissPopover.OnNext(popoverPresentationController);
        }

        readonly SingleAwaitSubject<UIKit.UIPopoverPresentationController> _PrepareForPopoverPresentation = new SingleAwaitSubject<UIKit.UIPopoverPresentationController>();
        public IObservable<UIKit.UIPopoverPresentationController> PrepareForPopoverPresentationObs { get { return _PrepareForPopoverPresentation; } }
        public override void PrepareForPopoverPresentation(UIKit.UIPopoverPresentationController popoverPresentationController)
        {
            _PrepareForPopoverPresentation.OnNext(popoverPresentationController);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIPopoverPresentationController, CoreGraphics.CGRect, UIKit.UIView>> _WillRepositionPopover = new SingleAwaitSubject<Tuple<UIKit.UIPopoverPresentationController, CoreGraphics.CGRect, UIKit.UIView>>();
        public IObservable<Tuple<UIKit.UIPopoverPresentationController, CoreGraphics.CGRect, UIKit.UIView>> WillRepositionPopoverObs { get { return _WillRepositionPopover; } }
        public override void WillRepositionPopover(UIKit.UIPopoverPresentationController popoverPresentationController, CoreGraphics.CGRect targetRect, UIKit.UIView inView)
        {
            _WillRepositionPopover.OnNext(Tuple.Create(popoverPresentationController, targetRect, inView));
        }

    }
    public  partial class NSLayoutManagerDelegateRx : NSLayoutManagerDelegate
    {
        readonly SingleAwaitSubject<UIKit.NSLayoutManager> _DidInvalidatedLayout = new SingleAwaitSubject<UIKit.NSLayoutManager>();
        public IObservable<UIKit.NSLayoutManager> DidInvalidatedLayoutObs { get { return _DidInvalidatedLayout; } }
        public override void DidInvalidatedLayout(UIKit.NSLayoutManager sender)
        {
            _DidInvalidatedLayout.OnNext(sender);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.NSLayoutManager, UIKit.NSTextContainer, CoreGraphics.CGSize>> _DidChangeGeometry = new SingleAwaitSubject<Tuple<UIKit.NSLayoutManager, UIKit.NSTextContainer, CoreGraphics.CGSize>>();
        public IObservable<Tuple<UIKit.NSLayoutManager, UIKit.NSTextContainer, CoreGraphics.CGSize>> DidChangeGeometryObs { get { return _DidChangeGeometry; } }
        public override void DidChangeGeometry(UIKit.NSLayoutManager layoutManager, UIKit.NSTextContainer textContainer, CoreGraphics.CGSize oldSize)
        {
            _DidChangeGeometry.OnNext(Tuple.Create(layoutManager, textContainer, oldSize));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.NSLayoutManager, UIKit.NSTextContainer, System.Boolean>> _DidCompleteLayout = new SingleAwaitSubject<Tuple<UIKit.NSLayoutManager, UIKit.NSTextContainer, System.Boolean>>();
        public IObservable<Tuple<UIKit.NSLayoutManager, UIKit.NSTextContainer, System.Boolean>> DidCompleteLayoutObs { get { return _DidCompleteLayout; } }
        public override void DidCompleteLayout(UIKit.NSLayoutManager layoutManager, UIKit.NSTextContainer textContainer, System.Boolean layoutFinishedFlag)
        {
            _DidCompleteLayout.OnNext(Tuple.Create(layoutManager, textContainer, layoutFinishedFlag));
        }

    }
    public  partial class NSTextStorageDelegateRx : NSTextStorageDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.NSTextStorage, UIKit.NSTextStorageEditActions, Foundation.NSRange, System.nint>> _DidProcessEditing = new SingleAwaitSubject<Tuple<UIKit.NSTextStorage, UIKit.NSTextStorageEditActions, Foundation.NSRange, System.nint>>();
        public IObservable<Tuple<UIKit.NSTextStorage, UIKit.NSTextStorageEditActions, Foundation.NSRange, System.nint>> DidProcessEditingObs { get { return _DidProcessEditing; } }
        public override void DidProcessEditing(UIKit.NSTextStorage textStorage, UIKit.NSTextStorageEditActions editedMask, Foundation.NSRange editedRange, System.nint delta)
        {
            _DidProcessEditing.OnNext(Tuple.Create(textStorage, editedMask, editedRange, delta));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.NSTextStorage, UIKit.NSTextStorageEditActions, Foundation.NSRange, System.nint>> _WillProcessEditing = new SingleAwaitSubject<Tuple<UIKit.NSTextStorage, UIKit.NSTextStorageEditActions, Foundation.NSRange, System.nint>>();
        public IObservable<Tuple<UIKit.NSTextStorage, UIKit.NSTextStorageEditActions, Foundation.NSRange, System.nint>> WillProcessEditingObs { get { return _WillProcessEditing; } }
        public override void WillProcessEditing(UIKit.NSTextStorage textStorage, UIKit.NSTextStorageEditActions editedMask, Foundation.NSRange editedRange, System.nint delta)
        {
            _WillProcessEditing.OnNext(Tuple.Create(textStorage, editedMask, editedRange, delta));
        }

    }
    public  partial class UIAccelerometerDelegateRx : UIAccelerometerDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.UIAccelerometer, UIKit.UIAcceleration>> _DidAccelerate = new SingleAwaitSubject<Tuple<UIKit.UIAccelerometer, UIKit.UIAcceleration>>();
        public IObservable<Tuple<UIKit.UIAccelerometer, UIKit.UIAcceleration>> DidAccelerateObs { get { return _DidAccelerate; } }
        public override void DidAccelerate(UIKit.UIAccelerometer accelerometer, UIKit.UIAcceleration acceleration)
        {
            _DidAccelerate.OnNext(Tuple.Create(accelerometer, acceleration));
        }

    }
    public  partial class UIActionSheetDelegateRx : UIActionSheetDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIActionSheet> _Canceled = new SingleAwaitSubject<UIKit.UIActionSheet>();
        public IObservable<UIKit.UIActionSheet> CanceledObs { get { return _Canceled; } }
        public override void Canceled(UIKit.UIActionSheet actionSheet)
        {
            _Canceled.OnNext(actionSheet);
        }

        readonly SingleAwaitSubject<UIKit.UIActionSheet> _Presented = new SingleAwaitSubject<UIKit.UIActionSheet>();
        public IObservable<UIKit.UIActionSheet> PresentedObs { get { return _Presented; } }
        public override void Presented(UIKit.UIActionSheet actionSheet)
        {
            _Presented.OnNext(actionSheet);
        }

        readonly SingleAwaitSubject<UIKit.UIActionSheet> _WillPresent = new SingleAwaitSubject<UIKit.UIActionSheet>();
        public IObservable<UIKit.UIActionSheet> WillPresentObs { get { return _WillPresent; } }
        public override void WillPresent(UIKit.UIActionSheet actionSheet)
        {
            _WillPresent.OnNext(actionSheet);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIActionSheet, System.nint>> _Clicked = new SingleAwaitSubject<Tuple<UIKit.UIActionSheet, System.nint>>();
        public IObservable<Tuple<UIKit.UIActionSheet, System.nint>> ClickedObs { get { return _Clicked; } }
        public override void Clicked(UIKit.UIActionSheet actionSheet, System.nint buttonIndex)
        {
            _Clicked.OnNext(Tuple.Create(actionSheet, buttonIndex));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIActionSheet, System.nint>> _Dismissed = new SingleAwaitSubject<Tuple<UIKit.UIActionSheet, System.nint>>();
        public IObservable<Tuple<UIKit.UIActionSheet, System.nint>> DismissedObs { get { return _Dismissed; } }
        public override void Dismissed(UIKit.UIActionSheet actionSheet, System.nint buttonIndex)
        {
            _Dismissed.OnNext(Tuple.Create(actionSheet, buttonIndex));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIActionSheet, System.nint>> _WillDismiss = new SingleAwaitSubject<Tuple<UIKit.UIActionSheet, System.nint>>();
        public IObservable<Tuple<UIKit.UIActionSheet, System.nint>> WillDismissObs { get { return _WillDismiss; } }
        public override void WillDismiss(UIKit.UIActionSheet actionSheet, System.nint buttonIndex)
        {
            _WillDismiss.OnNext(Tuple.Create(actionSheet, buttonIndex));
        }

    }
    public  partial class UIAlertViewDelegateRx : UIAlertViewDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIAlertView> _Canceled = new SingleAwaitSubject<UIKit.UIAlertView>();
        public IObservable<UIKit.UIAlertView> CanceledObs { get { return _Canceled; } }
        public override void Canceled(UIKit.UIAlertView alertView)
        {
            _Canceled.OnNext(alertView);
        }

        readonly SingleAwaitSubject<UIKit.UIAlertView> _Presented = new SingleAwaitSubject<UIKit.UIAlertView>();
        public IObservable<UIKit.UIAlertView> PresentedObs { get { return _Presented; } }
        public override void Presented(UIKit.UIAlertView alertView)
        {
            _Presented.OnNext(alertView);
        }

        readonly SingleAwaitSubject<UIKit.UIAlertView> _WillPresent = new SingleAwaitSubject<UIKit.UIAlertView>();
        public IObservable<UIKit.UIAlertView> WillPresentObs { get { return _WillPresent; } }
        public override void WillPresent(UIKit.UIAlertView alertView)
        {
            _WillPresent.OnNext(alertView);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIAlertView, System.nint>> _Clicked = new SingleAwaitSubject<Tuple<UIKit.UIAlertView, System.nint>>();
        public IObservable<Tuple<UIKit.UIAlertView, System.nint>> ClickedObs { get { return _Clicked; } }
        public override void Clicked(UIKit.UIAlertView alertview, System.nint buttonIndex)
        {
            _Clicked.OnNext(Tuple.Create(alertview, buttonIndex));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIAlertView, System.nint>> _Dismissed = new SingleAwaitSubject<Tuple<UIKit.UIAlertView, System.nint>>();
        public IObservable<Tuple<UIKit.UIAlertView, System.nint>> DismissedObs { get { return _Dismissed; } }
        public override void Dismissed(UIKit.UIAlertView alertView, System.nint buttonIndex)
        {
            _Dismissed.OnNext(Tuple.Create(alertView, buttonIndex));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIAlertView, System.nint>> _WillDismiss = new SingleAwaitSubject<Tuple<UIKit.UIAlertView, System.nint>>();
        public IObservable<Tuple<UIKit.UIAlertView, System.nint>> WillDismissObs { get { return _WillDismiss; } }
        public override void WillDismiss(UIKit.UIAlertView alertView, System.nint buttonIndex)
        {
            _WillDismiss.OnNext(Tuple.Create(alertView, buttonIndex));
        }

    }
    public  partial class UIApplicationDelegateRx : UIApplicationDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIApplication> _ApplicationSignificantTimeChange = new SingleAwaitSubject<UIKit.UIApplication>();
        public IObservable<UIKit.UIApplication> ApplicationSignificantTimeChangeObs { get { return _ApplicationSignificantTimeChange; } }
        public override void ApplicationSignificantTimeChange(UIKit.UIApplication application)
        {
            _ApplicationSignificantTimeChange.OnNext(application);
        }

        readonly SingleAwaitSubject<UIKit.UIApplication> _DidEnterBackground = new SingleAwaitSubject<UIKit.UIApplication>();
        public IObservable<UIKit.UIApplication> DidEnterBackgroundObs { get { return _DidEnterBackground; } }
        public override void DidEnterBackground(UIKit.UIApplication application)
        {
            _DidEnterBackground.OnNext(application);
        }

        readonly SingleAwaitSubject<UIKit.UIApplication> _FinishedLaunching = new SingleAwaitSubject<UIKit.UIApplication>();
        public IObservable<UIKit.UIApplication> FinishedLaunchingObs { get { return _FinishedLaunching; } }
        public override void FinishedLaunching(UIKit.UIApplication application)
        {
            _FinishedLaunching.OnNext(application);
        }

        readonly SingleAwaitSubject<UIKit.UIApplication> _OnActivated = new SingleAwaitSubject<UIKit.UIApplication>();
        public IObservable<UIKit.UIApplication> OnActivatedObs { get { return _OnActivated; } }
        public override void OnActivated(UIKit.UIApplication application)
        {
            _OnActivated.OnNext(application);
        }

        readonly SingleAwaitSubject<UIKit.UIApplication> _OnResignActivation = new SingleAwaitSubject<UIKit.UIApplication>();
        public IObservable<UIKit.UIApplication> OnResignActivationObs { get { return _OnResignActivation; } }
        public override void OnResignActivation(UIKit.UIApplication application)
        {
            _OnResignActivation.OnNext(application);
        }

        readonly SingleAwaitSubject<UIKit.UIApplication> _ProtectedDataDidBecomeAvailable = new SingleAwaitSubject<UIKit.UIApplication>();
        public IObservable<UIKit.UIApplication> ProtectedDataDidBecomeAvailableObs { get { return _ProtectedDataDidBecomeAvailable; } }
        public override void ProtectedDataDidBecomeAvailable(UIKit.UIApplication application)
        {
            _ProtectedDataDidBecomeAvailable.OnNext(application);
        }

        readonly SingleAwaitSubject<UIKit.UIApplication> _ProtectedDataWillBecomeUnavailable = new SingleAwaitSubject<UIKit.UIApplication>();
        public IObservable<UIKit.UIApplication> ProtectedDataWillBecomeUnavailableObs { get { return _ProtectedDataWillBecomeUnavailable; } }
        public override void ProtectedDataWillBecomeUnavailable(UIKit.UIApplication application)
        {
            _ProtectedDataWillBecomeUnavailable.OnNext(application);
        }

        readonly SingleAwaitSubject<UIKit.UIApplication> _ReceiveMemoryWarning = new SingleAwaitSubject<UIKit.UIApplication>();
        public IObservable<UIKit.UIApplication> ReceiveMemoryWarningObs { get { return _ReceiveMemoryWarning; } }
        public override void ReceiveMemoryWarning(UIKit.UIApplication application)
        {
            _ReceiveMemoryWarning.OnNext(application);
        }

        readonly SingleAwaitSubject<UIKit.UIApplication> _ShouldRequestHealthAuthorization = new SingleAwaitSubject<UIKit.UIApplication>();
        public IObservable<UIKit.UIApplication> ShouldRequestHealthAuthorizationObs { get { return _ShouldRequestHealthAuthorization; } }
        public override void ShouldRequestHealthAuthorization(UIKit.UIApplication application)
        {
            _ShouldRequestHealthAuthorization.OnNext(application);
        }

        readonly SingleAwaitSubject<UIKit.UIApplication> _WillEnterForeground = new SingleAwaitSubject<UIKit.UIApplication>();
        public IObservable<UIKit.UIApplication> WillEnterForegroundObs { get { return _WillEnterForeground; } }
        public override void WillEnterForeground(UIKit.UIApplication application)
        {
            _WillEnterForeground.OnNext(application);
        }

        readonly SingleAwaitSubject<UIKit.UIApplication> _WillTerminate = new SingleAwaitSubject<UIKit.UIApplication>();
        public IObservable<UIKit.UIApplication> WillTerminateObs { get { return _WillTerminate; } }
        public override void WillTerminate(UIKit.UIApplication application)
        {
            _WillTerminate.OnNext(application);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, CoreGraphics.CGRect>> _ChangedStatusBarFrame = new SingleAwaitSubject<Tuple<UIKit.UIApplication, CoreGraphics.CGRect>>();
        public IObservable<Tuple<UIKit.UIApplication, CoreGraphics.CGRect>> ChangedStatusBarFrameObs { get { return _ChangedStatusBarFrame; } }
        public override void ChangedStatusBarFrame(UIKit.UIApplication application, CoreGraphics.CGRect oldStatusBarFrame)
        {
            _ChangedStatusBarFrame.OnNext(Tuple.Create(application, oldStatusBarFrame));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, UIKit.UIInterfaceOrientation>> _DidChangeStatusBarOrientation = new SingleAwaitSubject<Tuple<UIKit.UIApplication, UIKit.UIInterfaceOrientation>>();
        public IObservable<Tuple<UIKit.UIApplication, UIKit.UIInterfaceOrientation>> DidChangeStatusBarOrientationObs { get { return _DidChangeStatusBarOrientation; } }
        public override void DidChangeStatusBarOrientation(UIKit.UIApplication application, UIKit.UIInterfaceOrientation oldStatusBarOrientation)
        {
            _DidChangeStatusBarOrientation.OnNext(Tuple.Create(application, oldStatusBarOrientation));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSCoder>> _DidDecodeRestorableState = new SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSCoder>>();
        public IObservable<Tuple<UIKit.UIApplication, Foundation.NSCoder>> DidDecodeRestorableStateObs { get { return _DidDecodeRestorableState; } }
        public override void DidDecodeRestorableState(UIKit.UIApplication application, Foundation.NSCoder coder)
        {
            _DidDecodeRestorableState.OnNext(Tuple.Create(application, coder));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, string, Foundation.NSError>> _DidFailToContinueUserActivitiy = new SingleAwaitSubject<Tuple<UIKit.UIApplication, string, Foundation.NSError>>();
        public IObservable<Tuple<UIKit.UIApplication, string, Foundation.NSError>> DidFailToContinueUserActivitiyObs { get { return _DidFailToContinueUserActivitiy; } }
        public override void DidFailToContinueUserActivitiy(UIKit.UIApplication application, string userActivityType, Foundation.NSError error)
        {
            _DidFailToContinueUserActivitiy.OnNext(Tuple.Create(application, userActivityType, error));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSDictionary, System.Action<UIKit.UIBackgroundFetchResult>>> _DidReceiveRemoteNotification = new SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSDictionary, System.Action<UIKit.UIBackgroundFetchResult>>>();
        public IObservable<Tuple<UIKit.UIApplication, Foundation.NSDictionary, System.Action<UIKit.UIBackgroundFetchResult>>> DidReceiveRemoteNotificationObs { get { return _DidReceiveRemoteNotification; } }
        public override void DidReceiveRemoteNotification(UIKit.UIApplication application, Foundation.NSDictionary userInfo, System.Action<UIKit.UIBackgroundFetchResult> completionHandler)
        {
            _DidReceiveRemoteNotification.OnNext(Tuple.Create(application, userInfo, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, UIKit.UIUserNotificationSettings>> _DidRegisterUserNotificationSettings = new SingleAwaitSubject<Tuple<UIKit.UIApplication, UIKit.UIUserNotificationSettings>>();
        public IObservable<Tuple<UIKit.UIApplication, UIKit.UIUserNotificationSettings>> DidRegisterUserNotificationSettingsObs { get { return _DidRegisterUserNotificationSettings; } }
        public override void DidRegisterUserNotificationSettings(UIKit.UIApplication application, UIKit.UIUserNotificationSettings notificationSettings)
        {
            _DidRegisterUserNotificationSettings.OnNext(Tuple.Create(application, notificationSettings));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSError>> _FailedToRegisterForRemoteNotifications = new SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSError>>();
        public IObservable<Tuple<UIKit.UIApplication, Foundation.NSError>> FailedToRegisterForRemoteNotificationsObs { get { return _FailedToRegisterForRemoteNotifications; } }
        public override void FailedToRegisterForRemoteNotifications(UIKit.UIApplication application, Foundation.NSError error)
        {
            _FailedToRegisterForRemoteNotifications.OnNext(Tuple.Create(application, error));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, string, UIKit.UILocalNotification, Foundation.NSDictionary, System.Action>> _HandleAction = new SingleAwaitSubject<Tuple<UIKit.UIApplication, string, UIKit.UILocalNotification, Foundation.NSDictionary, System.Action>>();
        public IObservable<Tuple<UIKit.UIApplication, string, UIKit.UILocalNotification, Foundation.NSDictionary, System.Action>> HandleActionObs { get { return _HandleAction; } }
        public override void HandleAction(UIKit.UIApplication application, string actionIdentifier, UIKit.UILocalNotification localNotification, Foundation.NSDictionary responseInfo, System.Action completionHandler)
        {
            _HandleAction.OnNext(Tuple.Create(application, actionIdentifier, localNotification, responseInfo, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, string, System.Action>> _HandleEventsForBackgroundUrl = new SingleAwaitSubject<Tuple<UIKit.UIApplication, string, System.Action>>();
        public IObservable<Tuple<UIKit.UIApplication, string, System.Action>> HandleEventsForBackgroundUrlObs { get { return _HandleEventsForBackgroundUrl; } }
        public override void HandleEventsForBackgroundUrl(UIKit.UIApplication application, string sessionIdentifier, System.Action completionHandler)
        {
            _HandleEventsForBackgroundUrl.OnNext(Tuple.Create(application, sessionIdentifier, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSDictionary, System.Action<Foundation.NSDictionary>>> _HandleWatchKitExtensionRequest = new SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSDictionary, System.Action<Foundation.NSDictionary>>>();
        public IObservable<Tuple<UIKit.UIApplication, Foundation.NSDictionary, System.Action<Foundation.NSDictionary>>> HandleWatchKitExtensionRequestObs { get { return _HandleWatchKitExtensionRequest; } }
        public override void HandleWatchKitExtensionRequest(UIKit.UIApplication application, Foundation.NSDictionary userInfo, System.Action<Foundation.NSDictionary> reply)
        {
            _HandleWatchKitExtensionRequest.OnNext(Tuple.Create(application, userInfo, reply));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, UIKit.UIApplicationShortcutItem, UIKit.UIOperationHandler>> _PerformActionForShortcutItem = new SingleAwaitSubject<Tuple<UIKit.UIApplication, UIKit.UIApplicationShortcutItem, UIKit.UIOperationHandler>>();
        public IObservable<Tuple<UIKit.UIApplication, UIKit.UIApplicationShortcutItem, UIKit.UIOperationHandler>> PerformActionForShortcutItemObs { get { return _PerformActionForShortcutItem; } }
        public override void PerformActionForShortcutItem(UIKit.UIApplication application, UIKit.UIApplicationShortcutItem shortcutItem, UIKit.UIOperationHandler completionHandler)
        {
            _PerformActionForShortcutItem.OnNext(Tuple.Create(application, shortcutItem, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, System.Action<UIKit.UIBackgroundFetchResult>>> _PerformFetch = new SingleAwaitSubject<Tuple<UIKit.UIApplication, System.Action<UIKit.UIBackgroundFetchResult>>>();
        public IObservable<Tuple<UIKit.UIApplication, System.Action<UIKit.UIBackgroundFetchResult>>> PerformFetchObs { get { return _PerformFetch; } }
        public override void PerformFetch(UIKit.UIApplication application, System.Action<UIKit.UIBackgroundFetchResult> completionHandler)
        {
            _PerformFetch.OnNext(Tuple.Create(application, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, UIKit.UILocalNotification>> _ReceivedLocalNotification = new SingleAwaitSubject<Tuple<UIKit.UIApplication, UIKit.UILocalNotification>>();
        public IObservable<Tuple<UIKit.UIApplication, UIKit.UILocalNotification>> ReceivedLocalNotificationObs { get { return _ReceivedLocalNotification; } }
        public override void ReceivedLocalNotification(UIKit.UIApplication application, UIKit.UILocalNotification notification)
        {
            _ReceivedLocalNotification.OnNext(Tuple.Create(application, notification));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSDictionary>> _ReceivedRemoteNotification = new SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSDictionary>>();
        public IObservable<Tuple<UIKit.UIApplication, Foundation.NSDictionary>> ReceivedRemoteNotificationObs { get { return _ReceivedRemoteNotification; } }
        public override void ReceivedRemoteNotification(UIKit.UIApplication application, Foundation.NSDictionary userInfo)
        {
            _ReceivedRemoteNotification.OnNext(Tuple.Create(application, userInfo));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSData>> _RegisteredForRemoteNotifications = new SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSData>>();
        public IObservable<Tuple<UIKit.UIApplication, Foundation.NSData>> RegisteredForRemoteNotificationsObs { get { return _RegisteredForRemoteNotifications; } }
        public override void RegisteredForRemoteNotifications(UIKit.UIApplication application, Foundation.NSData deviceToken)
        {
            _RegisteredForRemoteNotifications.OnNext(Tuple.Create(application, deviceToken));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSUserActivity>> _UserActivityUpdated = new SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSUserActivity>>();
        public IObservable<Tuple<UIKit.UIApplication, Foundation.NSUserActivity>> UserActivityUpdatedObs { get { return _UserActivityUpdated; } }
        public override void UserActivityUpdated(UIKit.UIApplication application, Foundation.NSUserActivity userActivity)
        {
            _UserActivityUpdated.OnNext(Tuple.Create(application, userActivity));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, CloudKit.CKShareMetadata>> _UserDidAcceptCloudKitShare = new SingleAwaitSubject<Tuple<UIKit.UIApplication, CloudKit.CKShareMetadata>>();
        public IObservable<Tuple<UIKit.UIApplication, CloudKit.CKShareMetadata>> UserDidAcceptCloudKitShareObs { get { return _UserDidAcceptCloudKitShare; } }
        public override void UserDidAcceptCloudKitShare(UIKit.UIApplication application, CloudKit.CKShareMetadata cloudKitShareMetadata)
        {
            _UserDidAcceptCloudKitShare.OnNext(Tuple.Create(application, cloudKitShareMetadata));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, CoreGraphics.CGRect>> _WillChangeStatusBarFrame = new SingleAwaitSubject<Tuple<UIKit.UIApplication, CoreGraphics.CGRect>>();
        public IObservable<Tuple<UIKit.UIApplication, CoreGraphics.CGRect>> WillChangeStatusBarFrameObs { get { return _WillChangeStatusBarFrame; } }
        public override void WillChangeStatusBarFrame(UIKit.UIApplication application, CoreGraphics.CGRect newStatusBarFrame)
        {
            _WillChangeStatusBarFrame.OnNext(Tuple.Create(application, newStatusBarFrame));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, UIKit.UIInterfaceOrientation, System.Double>> _WillChangeStatusBarOrientation = new SingleAwaitSubject<Tuple<UIKit.UIApplication, UIKit.UIInterfaceOrientation, System.Double>>();
        public IObservable<Tuple<UIKit.UIApplication, UIKit.UIInterfaceOrientation, System.Double>> WillChangeStatusBarOrientationObs { get { return _WillChangeStatusBarOrientation; } }
        public override void WillChangeStatusBarOrientation(UIKit.UIApplication application, UIKit.UIInterfaceOrientation newStatusBarOrientation, System.Double duration)
        {
            _WillChangeStatusBarOrientation.OnNext(Tuple.Create(application, newStatusBarOrientation, duration));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSCoder>> _WillEncodeRestorableState = new SingleAwaitSubject<Tuple<UIKit.UIApplication, Foundation.NSCoder>>();
        public IObservable<Tuple<UIKit.UIApplication, Foundation.NSCoder>> WillEncodeRestorableStateObs { get { return _WillEncodeRestorableState; } }
        public override void WillEncodeRestorableState(UIKit.UIApplication application, Foundation.NSCoder coder)
        {
            _WillEncodeRestorableState.OnNext(Tuple.Create(application, coder));
        }

    }
    public abstract partial class UICloudSharingControllerDelegateRx : UICloudSharingControllerDelegate
    {
        readonly SingleAwaitSubject<UIKit.UICloudSharingController> _DidSaveShare = new SingleAwaitSubject<UIKit.UICloudSharingController>();
        public IObservable<UIKit.UICloudSharingController> DidSaveShareObs { get { return _DidSaveShare; } }
        public override void DidSaveShare(UIKit.UICloudSharingController csc)
        {
            _DidSaveShare.OnNext(csc);
        }

        readonly SingleAwaitSubject<UIKit.UICloudSharingController> _DidStopSharing = new SingleAwaitSubject<UIKit.UICloudSharingController>();
        public IObservable<UIKit.UICloudSharingController> DidStopSharingObs { get { return _DidStopSharing; } }
        public override void DidStopSharing(UIKit.UICloudSharingController csc)
        {
            _DidStopSharing.OnNext(csc);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICloudSharingController, Foundation.NSError>> _FailedToSaveShare = new SingleAwaitSubject<Tuple<UIKit.UICloudSharingController, Foundation.NSError>>();
        public IObservable<Tuple<UIKit.UICloudSharingController, Foundation.NSError>> FailedToSaveShareObs { get { return _FailedToSaveShare; } }
        public override void FailedToSaveShare(UIKit.UICloudSharingController csc, Foundation.NSError error)
        {
            _FailedToSaveShare.OnNext(Tuple.Create(csc, error));
        }

    }
    public  partial class UICollectionViewDelegateRx : UICollectionViewDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIScrollView> _DecelerationEnded = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> DecelerationEndedObs { get { return _DecelerationEnded; } }
        public override void DecelerationEnded(UIKit.UIScrollView scrollView)
        {
            _DecelerationEnded.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<UIKit.UIScrollView> _DecelerationStarted = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> DecelerationStartedObs { get { return _DecelerationStarted; } }
        public override void DecelerationStarted(UIKit.UIScrollView scrollView)
        {
            _DecelerationStarted.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<UIKit.UIScrollView> _DidZoom = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> DidZoomObs { get { return _DidZoom; } }
        public override void DidZoom(UIKit.UIScrollView scrollView)
        {
            _DidZoom.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<UIKit.UIScrollView> _DraggingStarted = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> DraggingStartedObs { get { return _DraggingStarted; } }
        public override void DraggingStarted(UIKit.UIScrollView scrollView)
        {
            _DraggingStarted.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<UIKit.UIScrollView> _ScrollAnimationEnded = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> ScrollAnimationEndedObs { get { return _ScrollAnimationEnded; } }
        public override void ScrollAnimationEnded(UIKit.UIScrollView scrollView)
        {
            _ScrollAnimationEnded.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<UIKit.UIScrollView> _Scrolled = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> ScrolledObs { get { return _Scrolled; } }
        public override void Scrolled(UIKit.UIScrollView scrollView)
        {
            _Scrolled.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<UIKit.UIScrollView> _ScrolledToTop = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> ScrolledToTopObs { get { return _ScrolledToTop; } }
        public override void ScrolledToTop(UIKit.UIScrollView scrollView)
        {
            _ScrolledToTop.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollectionView, UIKit.UICollectionViewCell, Foundation.NSIndexPath>> _CellDisplayingEnded = new SingleAwaitSubject<Tuple<UIKit.UICollectionView, UIKit.UICollectionViewCell, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UICollectionView, UIKit.UICollectionViewCell, Foundation.NSIndexPath>> CellDisplayingEndedObs { get { return _CellDisplayingEnded; } }
        public override void CellDisplayingEnded(UIKit.UICollectionView collectionView, UIKit.UICollectionViewCell cell, Foundation.NSIndexPath indexPath)
        {
            _CellDisplayingEnded.OnNext(Tuple.Create(collectionView, cell, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollectionView, UIKit.UICollectionViewFocusUpdateContext, UIKit.UIFocusAnimationCoordinator>> _DidUpdateFocus = new SingleAwaitSubject<Tuple<UIKit.UICollectionView, UIKit.UICollectionViewFocusUpdateContext, UIKit.UIFocusAnimationCoordinator>>();
        public IObservable<Tuple<UIKit.UICollectionView, UIKit.UICollectionViewFocusUpdateContext, UIKit.UIFocusAnimationCoordinator>> DidUpdateFocusObs { get { return _DidUpdateFocus; } }
        public override void DidUpdateFocus(UIKit.UICollectionView collectionView, UIKit.UICollectionViewFocusUpdateContext context, UIKit.UIFocusAnimationCoordinator coordinator)
        {
            _DidUpdateFocus.OnNext(Tuple.Create(collectionView, context, coordinator));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIScrollView, System.Boolean>> _DraggingEnded = new SingleAwaitSubject<Tuple<UIKit.UIScrollView, System.Boolean>>();
        public IObservable<Tuple<UIKit.UIScrollView, System.Boolean>> DraggingEndedObs { get { return _DraggingEnded; } }
        public override void DraggingEnded(UIKit.UIScrollView scrollView, System.Boolean willDecelerate)
        {
            _DraggingEnded.OnNext(Tuple.Create(scrollView, willDecelerate));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollectionView, Foundation.NSIndexPath>> _ItemDeselected = new SingleAwaitSubject<Tuple<UIKit.UICollectionView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UICollectionView, Foundation.NSIndexPath>> ItemDeselectedObs { get { return _ItemDeselected; } }
        public override void ItemDeselected(UIKit.UICollectionView collectionView, Foundation.NSIndexPath indexPath)
        {
            _ItemDeselected.OnNext(Tuple.Create(collectionView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollectionView, Foundation.NSIndexPath>> _ItemHighlighted = new SingleAwaitSubject<Tuple<UIKit.UICollectionView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UICollectionView, Foundation.NSIndexPath>> ItemHighlightedObs { get { return _ItemHighlighted; } }
        public override void ItemHighlighted(UIKit.UICollectionView collectionView, Foundation.NSIndexPath indexPath)
        {
            _ItemHighlighted.OnNext(Tuple.Create(collectionView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollectionView, Foundation.NSIndexPath>> _ItemSelected = new SingleAwaitSubject<Tuple<UIKit.UICollectionView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UICollectionView, Foundation.NSIndexPath>> ItemSelectedObs { get { return _ItemSelected; } }
        public override void ItemSelected(UIKit.UICollectionView collectionView, Foundation.NSIndexPath indexPath)
        {
            _ItemSelected.OnNext(Tuple.Create(collectionView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollectionView, Foundation.NSIndexPath>> _ItemUnhighlighted = new SingleAwaitSubject<Tuple<UIKit.UICollectionView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UICollectionView, Foundation.NSIndexPath>> ItemUnhighlightedObs { get { return _ItemUnhighlighted; } }
        public override void ItemUnhighlighted(UIKit.UICollectionView collectionView, Foundation.NSIndexPath indexPath)
        {
            _ItemUnhighlighted.OnNext(Tuple.Create(collectionView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollectionView, ObjCRuntime.Selector, Foundation.NSIndexPath, Foundation.NSObject>> _PerformAction = new SingleAwaitSubject<Tuple<UIKit.UICollectionView, ObjCRuntime.Selector, Foundation.NSIndexPath, Foundation.NSObject>>();
        public IObservable<Tuple<UIKit.UICollectionView, ObjCRuntime.Selector, Foundation.NSIndexPath, Foundation.NSObject>> PerformActionObs { get { return _PerformAction; } }
        public override void PerformAction(UIKit.UICollectionView collectionView, ObjCRuntime.Selector action, Foundation.NSIndexPath indexPath, Foundation.NSObject sender)
        {
            _PerformAction.OnNext(Tuple.Create(collectionView, action, indexPath, sender));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollectionView, UIKit.UICollectionReusableView, Foundation.NSString, Foundation.NSIndexPath>> _SupplementaryViewDisplayingEnded = new SingleAwaitSubject<Tuple<UIKit.UICollectionView, UIKit.UICollectionReusableView, Foundation.NSString, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UICollectionView, UIKit.UICollectionReusableView, Foundation.NSString, Foundation.NSIndexPath>> SupplementaryViewDisplayingEndedObs { get { return _SupplementaryViewDisplayingEnded; } }
        public override void SupplementaryViewDisplayingEnded(UIKit.UICollectionView collectionView, UIKit.UICollectionReusableView view, Foundation.NSString elementKind, Foundation.NSIndexPath indexPath)
        {
            _SupplementaryViewDisplayingEnded.OnNext(Tuple.Create(collectionView, view, elementKind, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollectionView, UIKit.UICollectionViewCell, Foundation.NSIndexPath>> _WillDisplayCell = new SingleAwaitSubject<Tuple<UIKit.UICollectionView, UIKit.UICollectionViewCell, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UICollectionView, UIKit.UICollectionViewCell, Foundation.NSIndexPath>> WillDisplayCellObs { get { return _WillDisplayCell; } }
        public override void WillDisplayCell(UIKit.UICollectionView collectionView, UIKit.UICollectionViewCell cell, Foundation.NSIndexPath indexPath)
        {
            _WillDisplayCell.OnNext(Tuple.Create(collectionView, cell, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollectionView, UIKit.UICollectionReusableView, string, Foundation.NSIndexPath>> _WillDisplaySupplementaryView = new SingleAwaitSubject<Tuple<UIKit.UICollectionView, UIKit.UICollectionReusableView, string, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UICollectionView, UIKit.UICollectionReusableView, string, Foundation.NSIndexPath>> WillDisplaySupplementaryViewObs { get { return _WillDisplaySupplementaryView; } }
        public override void WillDisplaySupplementaryView(UIKit.UICollectionView collectionView, UIKit.UICollectionReusableView view, string elementKind, Foundation.NSIndexPath indexPath)
        {
            _WillDisplaySupplementaryView.OnNext(Tuple.Create(collectionView, view, elementKind, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIScrollView, UIKit.UIView, System.nfloat>> _ZoomingEnded = new SingleAwaitSubject<Tuple<UIKit.UIScrollView, UIKit.UIView, System.nfloat>>();
        public IObservable<Tuple<UIKit.UIScrollView, UIKit.UIView, System.nfloat>> ZoomingEndedObs { get { return _ZoomingEnded; } }
        public override void ZoomingEnded(UIKit.UIScrollView scrollView, UIKit.UIView withView, System.nfloat atScale)
        {
            _ZoomingEnded.OnNext(Tuple.Create(scrollView, withView, atScale));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIScrollView, UIKit.UIView>> _ZoomingStarted = new SingleAwaitSubject<Tuple<UIKit.UIScrollView, UIKit.UIView>>();
        public IObservable<Tuple<UIKit.UIScrollView, UIKit.UIView>> ZoomingStartedObs { get { return _ZoomingStarted; } }
        public override void ZoomingStarted(UIKit.UIScrollView scrollView, UIKit.UIView view)
        {
            _ZoomingStarted.OnNext(Tuple.Create(scrollView, view));
        }

    }
    public  partial class UICollisionBehaviorDelegateRx : UICollisionBehaviorDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.UICollisionBehavior, UIKit.IUIDynamicItem, Foundation.NSObject, CoreGraphics.CGPoint>> _BeganBoundaryContact = new SingleAwaitSubject<Tuple<UIKit.UICollisionBehavior, UIKit.IUIDynamicItem, Foundation.NSObject, CoreGraphics.CGPoint>>();
        public IObservable<Tuple<UIKit.UICollisionBehavior, UIKit.IUIDynamicItem, Foundation.NSObject, CoreGraphics.CGPoint>> BeganBoundaryContactObs { get { return _BeganBoundaryContact; } }
        public override void BeganBoundaryContact(UIKit.UICollisionBehavior behavior, UIKit.IUIDynamicItem dynamicItem, Foundation.NSObject boundaryIdentifier, CoreGraphics.CGPoint atPoint)
        {
            _BeganBoundaryContact.OnNext(Tuple.Create(behavior, dynamicItem, boundaryIdentifier, atPoint));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollisionBehavior, UIKit.IUIDynamicItem, UIKit.IUIDynamicItem, CoreGraphics.CGPoint>> _BeganContact = new SingleAwaitSubject<Tuple<UIKit.UICollisionBehavior, UIKit.IUIDynamicItem, UIKit.IUIDynamicItem, CoreGraphics.CGPoint>>();
        public IObservable<Tuple<UIKit.UICollisionBehavior, UIKit.IUIDynamicItem, UIKit.IUIDynamicItem, CoreGraphics.CGPoint>> BeganContactObs { get { return _BeganContact; } }
        public override void BeganContact(UIKit.UICollisionBehavior behavior, UIKit.IUIDynamicItem firstItem, UIKit.IUIDynamicItem secondItem, CoreGraphics.CGPoint atPoint)
        {
            _BeganContact.OnNext(Tuple.Create(behavior, firstItem, secondItem, atPoint));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollisionBehavior, UIKit.IUIDynamicItem, Foundation.NSObject>> _EndedBoundaryContact = new SingleAwaitSubject<Tuple<UIKit.UICollisionBehavior, UIKit.IUIDynamicItem, Foundation.NSObject>>();
        public IObservable<Tuple<UIKit.UICollisionBehavior, UIKit.IUIDynamicItem, Foundation.NSObject>> EndedBoundaryContactObs { get { return _EndedBoundaryContact; } }
        public override void EndedBoundaryContact(UIKit.UICollisionBehavior behavior, UIKit.IUIDynamicItem dynamicItem, Foundation.NSObject boundaryIdentifier)
        {
            _EndedBoundaryContact.OnNext(Tuple.Create(behavior, dynamicItem, boundaryIdentifier));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UICollisionBehavior, UIKit.IUIDynamicItem, UIKit.IUIDynamicItem>> _EndedContact = new SingleAwaitSubject<Tuple<UIKit.UICollisionBehavior, UIKit.IUIDynamicItem, UIKit.IUIDynamicItem>>();
        public IObservable<Tuple<UIKit.UICollisionBehavior, UIKit.IUIDynamicItem, UIKit.IUIDynamicItem>> EndedContactObs { get { return _EndedContact; } }
        public override void EndedContact(UIKit.UICollisionBehavior behavior, UIKit.IUIDynamicItem firstItem, UIKit.IUIDynamicItem secondItem)
        {
            _EndedContact.OnNext(Tuple.Create(behavior, firstItem, secondItem));
        }

    }
    public  partial class UIDocumentInteractionControllerDelegateRx : UIDocumentInteractionControllerDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIDocumentInteractionController> _DidDismissOpenInMenu = new SingleAwaitSubject<UIKit.UIDocumentInteractionController>();
        public IObservable<UIKit.UIDocumentInteractionController> DidDismissOpenInMenuObs { get { return _DidDismissOpenInMenu; } }
        public override void DidDismissOpenInMenu(UIKit.UIDocumentInteractionController controller)
        {
            _DidDismissOpenInMenu.OnNext(controller);
        }

        readonly SingleAwaitSubject<UIKit.UIDocumentInteractionController> _DidDismissOptionsMenu = new SingleAwaitSubject<UIKit.UIDocumentInteractionController>();
        public IObservable<UIKit.UIDocumentInteractionController> DidDismissOptionsMenuObs { get { return _DidDismissOptionsMenu; } }
        public override void DidDismissOptionsMenu(UIKit.UIDocumentInteractionController controller)
        {
            _DidDismissOptionsMenu.OnNext(controller);
        }

        readonly SingleAwaitSubject<UIKit.UIDocumentInteractionController> _DidEndPreview = new SingleAwaitSubject<UIKit.UIDocumentInteractionController>();
        public IObservable<UIKit.UIDocumentInteractionController> DidEndPreviewObs { get { return _DidEndPreview; } }
        public override void DidEndPreview(UIKit.UIDocumentInteractionController controller)
        {
            _DidEndPreview.OnNext(controller);
        }

        readonly SingleAwaitSubject<UIKit.UIDocumentInteractionController> _WillBeginPreview = new SingleAwaitSubject<UIKit.UIDocumentInteractionController>();
        public IObservable<UIKit.UIDocumentInteractionController> WillBeginPreviewObs { get { return _WillBeginPreview; } }
        public override void WillBeginPreview(UIKit.UIDocumentInteractionController controller)
        {
            _WillBeginPreview.OnNext(controller);
        }

        readonly SingleAwaitSubject<UIKit.UIDocumentInteractionController> _WillPresentOpenInMenu = new SingleAwaitSubject<UIKit.UIDocumentInteractionController>();
        public IObservable<UIKit.UIDocumentInteractionController> WillPresentOpenInMenuObs { get { return _WillPresentOpenInMenu; } }
        public override void WillPresentOpenInMenu(UIKit.UIDocumentInteractionController controller)
        {
            _WillPresentOpenInMenu.OnNext(controller);
        }

        readonly SingleAwaitSubject<UIKit.UIDocumentInteractionController> _WillPresentOptionsMenu = new SingleAwaitSubject<UIKit.UIDocumentInteractionController>();
        public IObservable<UIKit.UIDocumentInteractionController> WillPresentOptionsMenuObs { get { return _WillPresentOptionsMenu; } }
        public override void WillPresentOptionsMenu(UIKit.UIDocumentInteractionController controller)
        {
            _WillPresentOptionsMenu.OnNext(controller);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIDocumentInteractionController, string>> _DidEndSendingToApplication = new SingleAwaitSubject<Tuple<UIKit.UIDocumentInteractionController, string>>();
        public IObservable<Tuple<UIKit.UIDocumentInteractionController, string>> DidEndSendingToApplicationObs { get { return _DidEndSendingToApplication; } }
        public override void DidEndSendingToApplication(UIKit.UIDocumentInteractionController controller, string application)
        {
            _DidEndSendingToApplication.OnNext(Tuple.Create(controller, application));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIDocumentInteractionController, string>> _WillBeginSendingToApplication = new SingleAwaitSubject<Tuple<UIKit.UIDocumentInteractionController, string>>();
        public IObservable<Tuple<UIKit.UIDocumentInteractionController, string>> WillBeginSendingToApplicationObs { get { return _WillBeginSendingToApplication; } }
        public override void WillBeginSendingToApplication(UIKit.UIDocumentInteractionController controller, string application)
        {
            _WillBeginSendingToApplication.OnNext(Tuple.Create(controller, application));
        }

    }
    public abstract partial class UIDocumentMenuDelegateRx : UIDocumentMenuDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIDocumentMenuViewController> _WasCancelled = new SingleAwaitSubject<UIKit.UIDocumentMenuViewController>();
        public IObservable<UIKit.UIDocumentMenuViewController> WasCancelledObs { get { return _WasCancelled; } }
        public override void WasCancelled(UIKit.UIDocumentMenuViewController documentMenu)
        {
            _WasCancelled.OnNext(documentMenu);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIDocumentMenuViewController, UIKit.UIDocumentPickerViewController>> _DidPickDocumentPicker = new SingleAwaitSubject<Tuple<UIKit.UIDocumentMenuViewController, UIKit.UIDocumentPickerViewController>>();
        public IObservable<Tuple<UIKit.UIDocumentMenuViewController, UIKit.UIDocumentPickerViewController>> DidPickDocumentPickerObs { get { return _DidPickDocumentPicker; } }
        public override void DidPickDocumentPicker(UIKit.UIDocumentMenuViewController documentMenu, UIKit.UIDocumentPickerViewController documentPicker)
        {
            _DidPickDocumentPicker.OnNext(Tuple.Create(documentMenu, documentPicker));
        }

    }
    public abstract partial class UIDocumentPickerDelegateRx : UIDocumentPickerDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIDocumentPickerViewController> _WasCancelled = new SingleAwaitSubject<UIKit.UIDocumentPickerViewController>();
        public IObservable<UIKit.UIDocumentPickerViewController> WasCancelledObs { get { return _WasCancelled; } }
        public override void WasCancelled(UIKit.UIDocumentPickerViewController controller)
        {
            _WasCancelled.OnNext(controller);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIDocumentPickerViewController, Foundation.NSUrl>> _DidPickDocument = new SingleAwaitSubject<Tuple<UIKit.UIDocumentPickerViewController, Foundation.NSUrl>>();
        public IObservable<Tuple<UIKit.UIDocumentPickerViewController, Foundation.NSUrl>> DidPickDocumentObs { get { return _DidPickDocument; } }
        public override void DidPickDocument(UIKit.UIDocumentPickerViewController controller, Foundation.NSUrl url)
        {
            _DidPickDocument.OnNext(Tuple.Create(controller, url));
        }

    }
    public abstract partial class UIDynamicAnimatorDelegateRx : UIDynamicAnimatorDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIDynamicAnimator> _DidPause = new SingleAwaitSubject<UIKit.UIDynamicAnimator>();
        public IObservable<UIKit.UIDynamicAnimator> DidPauseObs { get { return _DidPause; } }
        public override void DidPause(UIKit.UIDynamicAnimator animator)
        {
            _DidPause.OnNext(animator);
        }

        readonly SingleAwaitSubject<UIKit.UIDynamicAnimator> _WillResume = new SingleAwaitSubject<UIKit.UIDynamicAnimator>();
        public IObservable<UIKit.UIDynamicAnimator> WillResumeObs { get { return _WillResume; } }
        public override void WillResume(UIKit.UIDynamicAnimator animator)
        {
            _WillResume.OnNext(animator);
        }

    }
    public  partial class UIImagePickerControllerDelegateRx : UIImagePickerControllerDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIImagePickerController> _Canceled = new SingleAwaitSubject<UIKit.UIImagePickerController>();
        public IObservable<UIKit.UIImagePickerController> CanceledObs { get { return _Canceled; } }
        public override void Canceled(UIKit.UIImagePickerController picker)
        {
            _Canceled.OnNext(picker);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIImagePickerController, UIKit.UIImage, Foundation.NSDictionary>> _FinishedPickingImage = new SingleAwaitSubject<Tuple<UIKit.UIImagePickerController, UIKit.UIImage, Foundation.NSDictionary>>();
        public IObservable<Tuple<UIKit.UIImagePickerController, UIKit.UIImage, Foundation.NSDictionary>> FinishedPickingImageObs { get { return _FinishedPickingImage; } }
        public override void FinishedPickingImage(UIKit.UIImagePickerController picker, UIKit.UIImage image, Foundation.NSDictionary editingInfo)
        {
            _FinishedPickingImage.OnNext(Tuple.Create(picker, image, editingInfo));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIImagePickerController, Foundation.NSDictionary>> _FinishedPickingMedia = new SingleAwaitSubject<Tuple<UIKit.UIImagePickerController, Foundation.NSDictionary>>();
        public IObservable<Tuple<UIKit.UIImagePickerController, Foundation.NSDictionary>> FinishedPickingMediaObs { get { return _FinishedPickingMedia; } }
        public override void FinishedPickingMedia(UIKit.UIImagePickerController picker, Foundation.NSDictionary info)
        {
            _FinishedPickingMedia.OnNext(Tuple.Create(picker, info));
        }

    }
    public abstract partial class UIPreviewInteractionDelegateRx : UIPreviewInteractionDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIPreviewInteraction> _DidCancel = new SingleAwaitSubject<UIKit.UIPreviewInteraction>();
        public IObservable<UIKit.UIPreviewInteraction> DidCancelObs { get { return _DidCancel; } }
        public override void DidCancel(UIKit.UIPreviewInteraction previewInteraction)
        {
            _DidCancel.OnNext(previewInteraction);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIPreviewInteraction, System.nfloat, System.Boolean>> _DidUpdateCommit = new SingleAwaitSubject<Tuple<UIKit.UIPreviewInteraction, System.nfloat, System.Boolean>>();
        public IObservable<Tuple<UIKit.UIPreviewInteraction, System.nfloat, System.Boolean>> DidUpdateCommitObs { get { return _DidUpdateCommit; } }
        public override void DidUpdateCommit(UIKit.UIPreviewInteraction previewInteraction, System.nfloat transitionProgress, System.Boolean ended)
        {
            _DidUpdateCommit.OnNext(Tuple.Create(previewInteraction, transitionProgress, ended));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIPreviewInteraction, System.nfloat, System.Boolean>> _DidUpdatePreviewTransition = new SingleAwaitSubject<Tuple<UIKit.UIPreviewInteraction, System.nfloat, System.Boolean>>();
        public IObservable<Tuple<UIKit.UIPreviewInteraction, System.nfloat, System.Boolean>> DidUpdatePreviewTransitionObs { get { return _DidUpdatePreviewTransition; } }
        public override void DidUpdatePreviewTransition(UIKit.UIPreviewInteraction previewInteraction, System.nfloat transitionProgress, System.Boolean ended)
        {
            _DidUpdatePreviewTransition.OnNext(Tuple.Create(previewInteraction, transitionProgress, ended));
        }

    }
    public  partial class UIPopoverControllerDelegateRx : UIPopoverControllerDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIPopoverController> _DidDismiss = new SingleAwaitSubject<UIKit.UIPopoverController>();
        public IObservable<UIKit.UIPopoverController> DidDismissObs { get { return _DidDismiss; } }
        public override void DidDismiss(UIKit.UIPopoverController popoverController)
        {
            _DidDismiss.OnNext(popoverController);
        }

    }
    public  partial class UINavigationBarDelegateRx : UINavigationBarDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.UINavigationBar, UIKit.UINavigationItem>> _DidPopItem = new SingleAwaitSubject<Tuple<UIKit.UINavigationBar, UIKit.UINavigationItem>>();
        public IObservable<Tuple<UIKit.UINavigationBar, UIKit.UINavigationItem>> DidPopItemObs { get { return _DidPopItem; } }
        public override void DidPopItem(UIKit.UINavigationBar navigationBar, UIKit.UINavigationItem item)
        {
            _DidPopItem.OnNext(Tuple.Create(navigationBar, item));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UINavigationBar, UIKit.UINavigationItem>> _DidPushItem = new SingleAwaitSubject<Tuple<UIKit.UINavigationBar, UIKit.UINavigationItem>>();
        public IObservable<Tuple<UIKit.UINavigationBar, UIKit.UINavigationItem>> DidPushItemObs { get { return _DidPushItem; } }
        public override void DidPushItem(UIKit.UINavigationBar navigationBar, UIKit.UINavigationItem item)
        {
            _DidPushItem.OnNext(Tuple.Create(navigationBar, item));
        }

    }
    public  partial class UIPrintInteractionControllerDelegateRx : UIPrintInteractionControllerDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIPrintInteractionController> _DidDismissPrinterOptions = new SingleAwaitSubject<UIKit.UIPrintInteractionController>();
        public IObservable<UIKit.UIPrintInteractionController> DidDismissPrinterOptionsObs { get { return _DidDismissPrinterOptions; } }
        public override void DidDismissPrinterOptions(UIKit.UIPrintInteractionController printInteractionController)
        {
            _DidDismissPrinterOptions.OnNext(printInteractionController);
        }

        readonly SingleAwaitSubject<UIKit.UIPrintInteractionController> _DidFinishJob = new SingleAwaitSubject<UIKit.UIPrintInteractionController>();
        public IObservable<UIKit.UIPrintInteractionController> DidFinishJobObs { get { return _DidFinishJob; } }
        public override void DidFinishJob(UIKit.UIPrintInteractionController printInteractionController)
        {
            _DidFinishJob.OnNext(printInteractionController);
        }

        readonly SingleAwaitSubject<UIKit.UIPrintInteractionController> _DidPresentPrinterOptions = new SingleAwaitSubject<UIKit.UIPrintInteractionController>();
        public IObservable<UIKit.UIPrintInteractionController> DidPresentPrinterOptionsObs { get { return _DidPresentPrinterOptions; } }
        public override void DidPresentPrinterOptions(UIKit.UIPrintInteractionController printInteractionController)
        {
            _DidPresentPrinterOptions.OnNext(printInteractionController);
        }

        readonly SingleAwaitSubject<UIKit.UIPrintInteractionController> _WillDismissPrinterOptions = new SingleAwaitSubject<UIKit.UIPrintInteractionController>();
        public IObservable<UIKit.UIPrintInteractionController> WillDismissPrinterOptionsObs { get { return _WillDismissPrinterOptions; } }
        public override void WillDismissPrinterOptions(UIKit.UIPrintInteractionController printInteractionController)
        {
            _WillDismissPrinterOptions.OnNext(printInteractionController);
        }

        readonly SingleAwaitSubject<UIKit.UIPrintInteractionController> _WillPresentPrinterOptions = new SingleAwaitSubject<UIKit.UIPrintInteractionController>();
        public IObservable<UIKit.UIPrintInteractionController> WillPresentPrinterOptionsObs { get { return _WillPresentPrinterOptions; } }
        public override void WillPresentPrinterOptions(UIKit.UIPrintInteractionController printInteractionController)
        {
            _WillPresentPrinterOptions.OnNext(printInteractionController);
        }

        readonly SingleAwaitSubject<UIKit.UIPrintInteractionController> _WillStartJob = new SingleAwaitSubject<UIKit.UIPrintInteractionController>();
        public IObservable<UIKit.UIPrintInteractionController> WillStartJobObs { get { return _WillStartJob; } }
        public override void WillStartJob(UIKit.UIPrintInteractionController printInteractionController)
        {
            _WillStartJob.OnNext(printInteractionController);
        }

    }
    public  partial class UINavigationControllerDelegateRx : UINavigationControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.UINavigationController, UIKit.UIViewController, System.Boolean>> _DidShowViewController = new SingleAwaitSubject<Tuple<UIKit.UINavigationController, UIKit.UIViewController, System.Boolean>>();
        public IObservable<Tuple<UIKit.UINavigationController, UIKit.UIViewController, System.Boolean>> DidShowViewControllerObs { get { return _DidShowViewController; } }
        public override void DidShowViewController(UIKit.UINavigationController navigationController, UIKit.UIViewController viewController, System.Boolean animated)
        {
            _DidShowViewController.OnNext(Tuple.Create(navigationController, viewController, animated));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UINavigationController, UIKit.UIViewController, System.Boolean>> _WillShowViewController = new SingleAwaitSubject<Tuple<UIKit.UINavigationController, UIKit.UIViewController, System.Boolean>>();
        public IObservable<Tuple<UIKit.UINavigationController, UIKit.UIViewController, System.Boolean>> WillShowViewControllerObs { get { return _WillShowViewController; } }
        public override void WillShowViewController(UIKit.UINavigationController navigationController, UIKit.UIViewController viewController, System.Boolean animated)
        {
            _WillShowViewController.OnNext(Tuple.Create(navigationController, viewController, animated));
        }

    }
    public  partial class UIPickerViewDelegateRx : UIPickerViewDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.UIPickerView, System.nint, System.nint>> _Selected = new SingleAwaitSubject<Tuple<UIKit.UIPickerView, System.nint, System.nint>>();
        public IObservable<Tuple<UIKit.UIPickerView, System.nint, System.nint>> SelectedObs { get { return _Selected; } }
        public override void Selected(UIKit.UIPickerView pickerView, System.nint row, System.nint component)
        {
            _Selected.OnNext(Tuple.Create(pickerView, row, component));
        }

    }
    public  partial class UIScrollViewDelegateRx : UIScrollViewDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIScrollView> _DecelerationEnded = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> DecelerationEndedObs { get { return _DecelerationEnded; } }
        public override void DecelerationEnded(UIKit.UIScrollView scrollView)
        {
            _DecelerationEnded.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<UIKit.UIScrollView> _DecelerationStarted = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> DecelerationStartedObs { get { return _DecelerationStarted; } }
        public override void DecelerationStarted(UIKit.UIScrollView scrollView)
        {
            _DecelerationStarted.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<UIKit.UIScrollView> _DidZoom = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> DidZoomObs { get { return _DidZoom; } }
        public override void DidZoom(UIKit.UIScrollView scrollView)
        {
            _DidZoom.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<UIKit.UIScrollView> _DraggingStarted = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> DraggingStartedObs { get { return _DraggingStarted; } }
        public override void DraggingStarted(UIKit.UIScrollView scrollView)
        {
            _DraggingStarted.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<UIKit.UIScrollView> _ScrollAnimationEnded = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> ScrollAnimationEndedObs { get { return _ScrollAnimationEnded; } }
        public override void ScrollAnimationEnded(UIKit.UIScrollView scrollView)
        {
            _ScrollAnimationEnded.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<UIKit.UIScrollView> _Scrolled = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> ScrolledObs { get { return _Scrolled; } }
        public override void Scrolled(UIKit.UIScrollView scrollView)
        {
            _Scrolled.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<UIKit.UIScrollView> _ScrolledToTop = new SingleAwaitSubject<UIKit.UIScrollView>();
        public IObservable<UIKit.UIScrollView> ScrolledToTopObs { get { return _ScrolledToTop; } }
        public override void ScrolledToTop(UIKit.UIScrollView scrollView)
        {
            _ScrolledToTop.OnNext(scrollView);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIScrollView, System.Boolean>> _DraggingEnded = new SingleAwaitSubject<Tuple<UIKit.UIScrollView, System.Boolean>>();
        public IObservable<Tuple<UIKit.UIScrollView, System.Boolean>> DraggingEndedObs { get { return _DraggingEnded; } }
        public override void DraggingEnded(UIKit.UIScrollView scrollView, System.Boolean willDecelerate)
        {
            _DraggingEnded.OnNext(Tuple.Create(scrollView, willDecelerate));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIScrollView, UIKit.UIView, System.nfloat>> _ZoomingEnded = new SingleAwaitSubject<Tuple<UIKit.UIScrollView, UIKit.UIView, System.nfloat>>();
        public IObservable<Tuple<UIKit.UIScrollView, UIKit.UIView, System.nfloat>> ZoomingEndedObs { get { return _ZoomingEnded; } }
        public override void ZoomingEnded(UIKit.UIScrollView scrollView, UIKit.UIView withView, System.nfloat atScale)
        {
            _ZoomingEnded.OnNext(Tuple.Create(scrollView, withView, atScale));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIScrollView, UIKit.UIView>> _ZoomingStarted = new SingleAwaitSubject<Tuple<UIKit.UIScrollView, UIKit.UIView>>();
        public IObservable<Tuple<UIKit.UIScrollView, UIKit.UIView>> ZoomingStartedObs { get { return _ZoomingStarted; } }
        public override void ZoomingStarted(UIKit.UIScrollView scrollView, UIKit.UIView view)
        {
            _ZoomingStarted.OnNext(Tuple.Create(scrollView, view));
        }

    }
    public  partial class UIPageViewControllerDelegateRx : UIPageViewControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.UIPageViewController, System.Boolean, UIKit.UIViewController[], System.Boolean>> _DidFinishAnimating = new SingleAwaitSubject<Tuple<UIKit.UIPageViewController, System.Boolean, UIKit.UIViewController[], System.Boolean>>();
        public IObservable<Tuple<UIKit.UIPageViewController, System.Boolean, UIKit.UIViewController[], System.Boolean>> DidFinishAnimatingObs { get { return _DidFinishAnimating; } }
        public override void DidFinishAnimating(UIKit.UIPageViewController pageViewController, System.Boolean finished, UIKit.UIViewController[] previousViewControllers, System.Boolean completed)
        {
            _DidFinishAnimating.OnNext(Tuple.Create(pageViewController, finished, previousViewControllers, completed));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIPageViewController, UIKit.UIViewController[]>> _WillTransition = new SingleAwaitSubject<Tuple<UIKit.UIPageViewController, UIKit.UIViewController[]>>();
        public IObservable<Tuple<UIKit.UIPageViewController, UIKit.UIViewController[]>> WillTransitionObs { get { return _WillTransition; } }
        public override void WillTransition(UIKit.UIPageViewController pageViewController, UIKit.UIViewController[] pendingViewControllers)
        {
            _WillTransition.OnNext(Tuple.Create(pageViewController, pendingViewControllers));
        }

    }
    public  partial class UISearchBarDelegateRx : UISearchBarDelegate
    {
        readonly SingleAwaitSubject<UIKit.UISearchBar> _BookmarkButtonClicked = new SingleAwaitSubject<UIKit.UISearchBar>();
        public IObservable<UIKit.UISearchBar> BookmarkButtonClickedObs { get { return _BookmarkButtonClicked; } }
        public override void BookmarkButtonClicked(UIKit.UISearchBar searchBar)
        {
            _BookmarkButtonClicked.OnNext(searchBar);
        }

        readonly SingleAwaitSubject<UIKit.UISearchBar> _CancelButtonClicked = new SingleAwaitSubject<UIKit.UISearchBar>();
        public IObservable<UIKit.UISearchBar> CancelButtonClickedObs { get { return _CancelButtonClicked; } }
        public override void CancelButtonClicked(UIKit.UISearchBar searchBar)
        {
            _CancelButtonClicked.OnNext(searchBar);
        }

        readonly SingleAwaitSubject<UIKit.UISearchBar> _ListButtonClicked = new SingleAwaitSubject<UIKit.UISearchBar>();
        public IObservable<UIKit.UISearchBar> ListButtonClickedObs { get { return _ListButtonClicked; } }
        public override void ListButtonClicked(UIKit.UISearchBar searchBar)
        {
            _ListButtonClicked.OnNext(searchBar);
        }

        readonly SingleAwaitSubject<UIKit.UISearchBar> _OnEditingStarted = new SingleAwaitSubject<UIKit.UISearchBar>();
        public IObservable<UIKit.UISearchBar> OnEditingStartedObs { get { return _OnEditingStarted; } }
        public override void OnEditingStarted(UIKit.UISearchBar searchBar)
        {
            _OnEditingStarted.OnNext(searchBar);
        }

        readonly SingleAwaitSubject<UIKit.UISearchBar> _OnEditingStopped = new SingleAwaitSubject<UIKit.UISearchBar>();
        public IObservable<UIKit.UISearchBar> OnEditingStoppedObs { get { return _OnEditingStopped; } }
        public override void OnEditingStopped(UIKit.UISearchBar searchBar)
        {
            _OnEditingStopped.OnNext(searchBar);
        }

        readonly SingleAwaitSubject<UIKit.UISearchBar> _SearchButtonClicked = new SingleAwaitSubject<UIKit.UISearchBar>();
        public IObservable<UIKit.UISearchBar> SearchButtonClickedObs { get { return _SearchButtonClicked; } }
        public override void SearchButtonClicked(UIKit.UISearchBar searchBar)
        {
            _SearchButtonClicked.OnNext(searchBar);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UISearchBar, System.nint>> _SelectedScopeButtonIndexChanged = new SingleAwaitSubject<Tuple<UIKit.UISearchBar, System.nint>>();
        public IObservable<Tuple<UIKit.UISearchBar, System.nint>> SelectedScopeButtonIndexChangedObs { get { return _SelectedScopeButtonIndexChanged; } }
        public override void SelectedScopeButtonIndexChanged(UIKit.UISearchBar searchBar, System.nint selectedScope)
        {
            _SelectedScopeButtonIndexChanged.OnNext(Tuple.Create(searchBar, selectedScope));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UISearchBar, string>> _TextChanged = new SingleAwaitSubject<Tuple<UIKit.UISearchBar, string>>();
        public IObservable<Tuple<UIKit.UISearchBar, string>> TextChangedObs { get { return _TextChanged; } }
        public override void TextChanged(UIKit.UISearchBar searchBar, string searchText)
        {
            _TextChanged.OnNext(Tuple.Create(searchBar, searchText));
        }

    }
    public  partial class UITabBarControllerDelegateRx : UITabBarControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.UITabBarController, UIKit.UIViewController[], System.Boolean>> _FinishedCustomizingViewControllers = new SingleAwaitSubject<Tuple<UIKit.UITabBarController, UIKit.UIViewController[], System.Boolean>>();
        public IObservable<Tuple<UIKit.UITabBarController, UIKit.UIViewController[], System.Boolean>> FinishedCustomizingViewControllersObs { get { return _FinishedCustomizingViewControllers; } }
        public override void FinishedCustomizingViewControllers(UIKit.UITabBarController tabBarController, UIKit.UIViewController[] viewControllers, System.Boolean changed)
        {
            _FinishedCustomizingViewControllers.OnNext(Tuple.Create(tabBarController, viewControllers, changed));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITabBarController, UIKit.UIViewController[]>> _OnCustomizingViewControllers = new SingleAwaitSubject<Tuple<UIKit.UITabBarController, UIKit.UIViewController[]>>();
        public IObservable<Tuple<UIKit.UITabBarController, UIKit.UIViewController[]>> OnCustomizingViewControllersObs { get { return _OnCustomizingViewControllers; } }
        public override void OnCustomizingViewControllers(UIKit.UITabBarController tabBarController, UIKit.UIViewController[] viewControllers)
        {
            _OnCustomizingViewControllers.OnNext(Tuple.Create(tabBarController, viewControllers));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITabBarController, UIKit.UIViewController[], System.Boolean>> _OnEndCustomizingViewControllers = new SingleAwaitSubject<Tuple<UIKit.UITabBarController, UIKit.UIViewController[], System.Boolean>>();
        public IObservable<Tuple<UIKit.UITabBarController, UIKit.UIViewController[], System.Boolean>> OnEndCustomizingViewControllersObs { get { return _OnEndCustomizingViewControllers; } }
        public override void OnEndCustomizingViewControllers(UIKit.UITabBarController tabBarController, UIKit.UIViewController[] viewControllers, System.Boolean changed)
        {
            _OnEndCustomizingViewControllers.OnNext(Tuple.Create(tabBarController, viewControllers, changed));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITabBarController, UIKit.UIViewController>> _ViewControllerSelected = new SingleAwaitSubject<Tuple<UIKit.UITabBarController, UIKit.UIViewController>>();
        public IObservable<Tuple<UIKit.UITabBarController, UIKit.UIViewController>> ViewControllerSelectedObs { get { return _ViewControllerSelected; } }
        public override void ViewControllerSelected(UIKit.UITabBarController tabBarController, UIKit.UIViewController viewController)
        {
            _ViewControllerSelected.OnNext(Tuple.Create(tabBarController, viewController));
        }

    }
    public  partial class UISearchControllerDelegateRx : UISearchControllerDelegate
    {
        readonly SingleAwaitSubject<UIKit.UISearchController> _DidDismissSearchController = new SingleAwaitSubject<UIKit.UISearchController>();
        public IObservable<UIKit.UISearchController> DidDismissSearchControllerObs { get { return _DidDismissSearchController; } }
        public override void DidDismissSearchController(UIKit.UISearchController searchController)
        {
            _DidDismissSearchController.OnNext(searchController);
        }

        readonly SingleAwaitSubject<UIKit.UISearchController> _DidPresentSearchController = new SingleAwaitSubject<UIKit.UISearchController>();
        public IObservable<UIKit.UISearchController> DidPresentSearchControllerObs { get { return _DidPresentSearchController; } }
        public override void DidPresentSearchController(UIKit.UISearchController searchController)
        {
            _DidPresentSearchController.OnNext(searchController);
        }

        readonly SingleAwaitSubject<UIKit.UISearchController> _PresentSearchController = new SingleAwaitSubject<UIKit.UISearchController>();
        public IObservable<UIKit.UISearchController> PresentSearchControllerObs { get { return _PresentSearchController; } }
        public override void PresentSearchController(UIKit.UISearchController searchController)
        {
            _PresentSearchController.OnNext(searchController);
        }

        readonly SingleAwaitSubject<UIKit.UISearchController> _WillDismissSearchController = new SingleAwaitSubject<UIKit.UISearchController>();
        public IObservable<UIKit.UISearchController> WillDismissSearchControllerObs { get { return _WillDismissSearchController; } }
        public override void WillDismissSearchController(UIKit.UISearchController searchController)
        {
            _WillDismissSearchController.OnNext(searchController);
        }

        readonly SingleAwaitSubject<UIKit.UISearchController> _WillPresentSearchController = new SingleAwaitSubject<UIKit.UISearchController>();
        public IObservable<UIKit.UISearchController> WillPresentSearchControllerObs { get { return _WillPresentSearchController; } }
        public override void WillPresentSearchController(UIKit.UISearchController searchController)
        {
            _WillPresentSearchController.OnNext(searchController);
        }

    }
    public  partial class UITabBarDelegateRx : UITabBarDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.UITabBar, UIKit.UITabBarItem[]>> _DidBeginCustomizingItems = new SingleAwaitSubject<Tuple<UIKit.UITabBar, UIKit.UITabBarItem[]>>();
        public IObservable<Tuple<UIKit.UITabBar, UIKit.UITabBarItem[]>> DidBeginCustomizingItemsObs { get { return _DidBeginCustomizingItems; } }
        public override void DidBeginCustomizingItems(UIKit.UITabBar tabbar, UIKit.UITabBarItem[] items)
        {
            _DidBeginCustomizingItems.OnNext(Tuple.Create(tabbar, items));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITabBar, UIKit.UITabBarItem[], System.Boolean>> _DidEndCustomizingItems = new SingleAwaitSubject<Tuple<UIKit.UITabBar, UIKit.UITabBarItem[], System.Boolean>>();
        public IObservable<Tuple<UIKit.UITabBar, UIKit.UITabBarItem[], System.Boolean>> DidEndCustomizingItemsObs { get { return _DidEndCustomizingItems; } }
        public override void DidEndCustomizingItems(UIKit.UITabBar tabbar, UIKit.UITabBarItem[] items, System.Boolean changed)
        {
            _DidEndCustomizingItems.OnNext(Tuple.Create(tabbar, items, changed));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITabBar, UIKit.UITabBarItem>> _ItemSelected = new SingleAwaitSubject<Tuple<UIKit.UITabBar, UIKit.UITabBarItem>>();
        public IObservable<Tuple<UIKit.UITabBar, UIKit.UITabBarItem>> ItemSelectedObs { get { return _ItemSelected; } }
        public override void ItemSelected(UIKit.UITabBar tabbar, UIKit.UITabBarItem item)
        {
            _ItemSelected.OnNext(Tuple.Create(tabbar, item));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITabBar, UIKit.UITabBarItem[]>> _WillBeginCustomizingItems = new SingleAwaitSubject<Tuple<UIKit.UITabBar, UIKit.UITabBarItem[]>>();
        public IObservable<Tuple<UIKit.UITabBar, UIKit.UITabBarItem[]>> WillBeginCustomizingItemsObs { get { return _WillBeginCustomizingItems; } }
        public override void WillBeginCustomizingItems(UIKit.UITabBar tabbar, UIKit.UITabBarItem[] items)
        {
            _WillBeginCustomizingItems.OnNext(Tuple.Create(tabbar, items));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITabBar, UIKit.UITabBarItem[], System.Boolean>> _WillEndCustomizingItems = new SingleAwaitSubject<Tuple<UIKit.UITabBar, UIKit.UITabBarItem[], System.Boolean>>();
        public IObservable<Tuple<UIKit.UITabBar, UIKit.UITabBarItem[], System.Boolean>> WillEndCustomizingItemsObs { get { return _WillEndCustomizingItems; } }
        public override void WillEndCustomizingItems(UIKit.UITabBar tabbar, UIKit.UITabBarItem[] items, System.Boolean changed)
        {
            _WillEndCustomizingItems.OnNext(Tuple.Create(tabbar, items, changed));
        }

    }
    public  partial class UIPrinterPickerControllerDelegateRx : UIPrinterPickerControllerDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIPrinterPickerController> _DidDismiss = new SingleAwaitSubject<UIKit.UIPrinterPickerController>();
        public IObservable<UIKit.UIPrinterPickerController> DidDismissObs { get { return _DidDismiss; } }
        public override void DidDismiss(UIKit.UIPrinterPickerController printerPickerController)
        {
            _DidDismiss.OnNext(printerPickerController);
        }

        readonly SingleAwaitSubject<UIKit.UIPrinterPickerController> _DidPresent = new SingleAwaitSubject<UIKit.UIPrinterPickerController>();
        public IObservable<UIKit.UIPrinterPickerController> DidPresentObs { get { return _DidPresent; } }
        public override void DidPresent(UIKit.UIPrinterPickerController printerPickerController)
        {
            _DidPresent.OnNext(printerPickerController);
        }

        readonly SingleAwaitSubject<UIKit.UIPrinterPickerController> _DidSelectPrinter = new SingleAwaitSubject<UIKit.UIPrinterPickerController>();
        public IObservable<UIKit.UIPrinterPickerController> DidSelectPrinterObs { get { return _DidSelectPrinter; } }
        public override void DidSelectPrinter(UIKit.UIPrinterPickerController printerPickerController)
        {
            _DidSelectPrinter.OnNext(printerPickerController);
        }

        readonly SingleAwaitSubject<UIKit.UIPrinterPickerController> _WillDismiss = new SingleAwaitSubject<UIKit.UIPrinterPickerController>();
        public IObservable<UIKit.UIPrinterPickerController> WillDismissObs { get { return _WillDismiss; } }
        public override void WillDismiss(UIKit.UIPrinterPickerController printerPickerController)
        {
            _WillDismiss.OnNext(printerPickerController);
        }

        readonly SingleAwaitSubject<UIKit.UIPrinterPickerController> _WillPresent = new SingleAwaitSubject<UIKit.UIPrinterPickerController>();
        public IObservable<UIKit.UIPrinterPickerController> WillPresentObs { get { return _WillPresent; } }
        public override void WillPresent(UIKit.UIPrinterPickerController printerPickerController)
        {
            _WillPresent.OnNext(printerPickerController);
        }

    }
    public  partial class UISplitViewControllerDelegateRx : UISplitViewControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.UISplitViewController, UIKit.UISplitViewControllerDisplayMode>> _WillChangeDisplayMode = new SingleAwaitSubject<Tuple<UIKit.UISplitViewController, UIKit.UISplitViewControllerDisplayMode>>();
        public IObservable<Tuple<UIKit.UISplitViewController, UIKit.UISplitViewControllerDisplayMode>> WillChangeDisplayModeObs { get { return _WillChangeDisplayMode; } }
        public override void WillChangeDisplayMode(UIKit.UISplitViewController svc, UIKit.UISplitViewControllerDisplayMode displayMode)
        {
            _WillChangeDisplayMode.OnNext(Tuple.Create(svc, displayMode));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UISplitViewController, UIKit.UIViewController, UIKit.UIBarButtonItem, UIKit.UIPopoverController>> _WillHideViewController = new SingleAwaitSubject<Tuple<UIKit.UISplitViewController, UIKit.UIViewController, UIKit.UIBarButtonItem, UIKit.UIPopoverController>>();
        public IObservable<Tuple<UIKit.UISplitViewController, UIKit.UIViewController, UIKit.UIBarButtonItem, UIKit.UIPopoverController>> WillHideViewControllerObs { get { return _WillHideViewController; } }
        public override void WillHideViewController(UIKit.UISplitViewController svc, UIKit.UIViewController aViewController, UIKit.UIBarButtonItem barButtonItem, UIKit.UIPopoverController pc)
        {
            _WillHideViewController.OnNext(Tuple.Create(svc, aViewController, barButtonItem, pc));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UISplitViewController, UIKit.UIPopoverController, UIKit.UIViewController>> _WillPresentViewController = new SingleAwaitSubject<Tuple<UIKit.UISplitViewController, UIKit.UIPopoverController, UIKit.UIViewController>>();
        public IObservable<Tuple<UIKit.UISplitViewController, UIKit.UIPopoverController, UIKit.UIViewController>> WillPresentViewControllerObs { get { return _WillPresentViewController; } }
        public override void WillPresentViewController(UIKit.UISplitViewController svc, UIKit.UIPopoverController pc, UIKit.UIViewController aViewController)
        {
            _WillPresentViewController.OnNext(Tuple.Create(svc, pc, aViewController));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UISplitViewController, UIKit.UIViewController, UIKit.UIBarButtonItem>> _WillShowViewController = new SingleAwaitSubject<Tuple<UIKit.UISplitViewController, UIKit.UIViewController, UIKit.UIBarButtonItem>>();
        public IObservable<Tuple<UIKit.UISplitViewController, UIKit.UIViewController, UIKit.UIBarButtonItem>> WillShowViewControllerObs { get { return _WillShowViewController; } }
        public override void WillShowViewController(UIKit.UISplitViewController svc, UIKit.UIViewController aViewController, UIKit.UIBarButtonItem button)
        {
            _WillShowViewController.OnNext(Tuple.Create(svc, aViewController, button));
        }

    }
    public  partial class UITextFieldDelegateRx : UITextFieldDelegate
    {
        readonly SingleAwaitSubject<UIKit.UITextField> _EditingEnded = new SingleAwaitSubject<UIKit.UITextField>();
        public IObservable<UIKit.UITextField> EditingEndedObs { get { return _EditingEnded; } }
        public override void EditingEnded(UIKit.UITextField textField)
        {
            _EditingEnded.OnNext(textField);
        }

        readonly SingleAwaitSubject<UIKit.UITextField> _EditingStarted = new SingleAwaitSubject<UIKit.UITextField>();
        public IObservable<UIKit.UITextField> EditingStartedObs { get { return _EditingStarted; } }
        public override void EditingStarted(UIKit.UITextField textField)
        {
            _EditingStarted.OnNext(textField);
        }

    }
    public  partial class UISearchDisplayDelegateRx : UISearchDisplayDelegate
    {
        readonly SingleAwaitSubject<UIKit.UISearchDisplayController> _DidBeginSearch = new SingleAwaitSubject<UIKit.UISearchDisplayController>();
        public IObservable<UIKit.UISearchDisplayController> DidBeginSearchObs { get { return _DidBeginSearch; } }
        public override void DidBeginSearch(UIKit.UISearchDisplayController controller)
        {
            _DidBeginSearch.OnNext(controller);
        }

        readonly SingleAwaitSubject<UIKit.UISearchDisplayController> _DidEndSearch = new SingleAwaitSubject<UIKit.UISearchDisplayController>();
        public IObservable<UIKit.UISearchDisplayController> DidEndSearchObs { get { return _DidEndSearch; } }
        public override void DidEndSearch(UIKit.UISearchDisplayController controller)
        {
            _DidEndSearch.OnNext(controller);
        }

        readonly SingleAwaitSubject<UIKit.UISearchDisplayController> _WillBeginSearch = new SingleAwaitSubject<UIKit.UISearchDisplayController>();
        public IObservable<UIKit.UISearchDisplayController> WillBeginSearchObs { get { return _WillBeginSearch; } }
        public override void WillBeginSearch(UIKit.UISearchDisplayController controller)
        {
            _WillBeginSearch.OnNext(controller);
        }

        readonly SingleAwaitSubject<UIKit.UISearchDisplayController> _WillEndSearch = new SingleAwaitSubject<UIKit.UISearchDisplayController>();
        public IObservable<UIKit.UISearchDisplayController> WillEndSearchObs { get { return _WillEndSearch; } }
        public override void WillEndSearch(UIKit.UISearchDisplayController controller)
        {
            _WillEndSearch.OnNext(controller);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>> _DidHideSearchResults = new SingleAwaitSubject<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>>();
        public IObservable<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>> DidHideSearchResultsObs { get { return _DidHideSearchResults; } }
        public override void DidHideSearchResults(UIKit.UISearchDisplayController controller, UIKit.UITableView tableView)
        {
            _DidHideSearchResults.OnNext(Tuple.Create(controller, tableView));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>> _DidLoadSearchResults = new SingleAwaitSubject<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>>();
        public IObservable<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>> DidLoadSearchResultsObs { get { return _DidLoadSearchResults; } }
        public override void DidLoadSearchResults(UIKit.UISearchDisplayController controller, UIKit.UITableView tableView)
        {
            _DidLoadSearchResults.OnNext(Tuple.Create(controller, tableView));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>> _DidShowSearchResults = new SingleAwaitSubject<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>>();
        public IObservable<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>> DidShowSearchResultsObs { get { return _DidShowSearchResults; } }
        public override void DidShowSearchResults(UIKit.UISearchDisplayController controller, UIKit.UITableView tableView)
        {
            _DidShowSearchResults.OnNext(Tuple.Create(controller, tableView));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>> _WillHideSearchResults = new SingleAwaitSubject<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>>();
        public IObservable<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>> WillHideSearchResultsObs { get { return _WillHideSearchResults; } }
        public override void WillHideSearchResults(UIKit.UISearchDisplayController controller, UIKit.UITableView tableView)
        {
            _WillHideSearchResults.OnNext(Tuple.Create(controller, tableView));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>> _WillShowSearchResults = new SingleAwaitSubject<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>>();
        public IObservable<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>> WillShowSearchResultsObs { get { return _WillShowSearchResults; } }
        public override void WillShowSearchResults(UIKit.UISearchDisplayController controller, UIKit.UITableView tableView)
        {
            _WillShowSearchResults.OnNext(Tuple.Create(controller, tableView));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>> _WillUnloadSearchResults = new SingleAwaitSubject<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>>();
        public IObservable<Tuple<UIKit.UISearchDisplayController, UIKit.UITableView>> WillUnloadSearchResultsObs { get { return _WillUnloadSearchResults; } }
        public override void WillUnloadSearchResults(UIKit.UISearchDisplayController controller, UIKit.UITableView tableView)
        {
            _WillUnloadSearchResults.OnNext(Tuple.Create(controller, tableView));
        }

    }
    public  partial class UITextViewDelegateRx : UITextViewDelegate
    {
        readonly SingleAwaitSubject<UIKit.UITextView> _Changed = new SingleAwaitSubject<UIKit.UITextView>();
        public IObservable<UIKit.UITextView> ChangedObs { get { return _Changed; } }
        public override void Changed(UIKit.UITextView textView)
        {
            _Changed.OnNext(textView);
        }

        readonly SingleAwaitSubject<UIKit.UITextView> _EditingEnded = new SingleAwaitSubject<UIKit.UITextView>();
        public IObservable<UIKit.UITextView> EditingEndedObs { get { return _EditingEnded; } }
        public override void EditingEnded(UIKit.UITextView textView)
        {
            _EditingEnded.OnNext(textView);
        }

        readonly SingleAwaitSubject<UIKit.UITextView> _EditingStarted = new SingleAwaitSubject<UIKit.UITextView>();
        public IObservable<UIKit.UITextView> EditingStartedObs { get { return _EditingStarted; } }
        public override void EditingStarted(UIKit.UITextView textView)
        {
            _EditingStarted.OnNext(textView);
        }

        readonly SingleAwaitSubject<UIKit.UITextView> _SelectionChanged = new SingleAwaitSubject<UIKit.UITextView>();
        public IObservable<UIKit.UITextView> SelectionChangedObs { get { return _SelectionChanged; } }
        public override void SelectionChanged(UIKit.UITextView textView)
        {
            _SelectionChanged.OnNext(textView);
        }

    }
    public  partial class UIVideoEditorControllerDelegateRx : UIVideoEditorControllerDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIVideoEditorController> _UserCancelled = new SingleAwaitSubject<UIKit.UIVideoEditorController>();
        public IObservable<UIKit.UIVideoEditorController> UserCancelledObs { get { return _UserCancelled; } }
        public override void UserCancelled(UIKit.UIVideoEditorController editor)
        {
            _UserCancelled.OnNext(editor);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIVideoEditorController, Foundation.NSError>> _Failed = new SingleAwaitSubject<Tuple<UIKit.UIVideoEditorController, Foundation.NSError>>();
        public IObservable<Tuple<UIKit.UIVideoEditorController, Foundation.NSError>> FailedObs { get { return _Failed; } }
        public override void Failed(UIKit.UIVideoEditorController editor, Foundation.NSError error)
        {
            _Failed.OnNext(Tuple.Create(editor, error));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIVideoEditorController, string>> _VideoSaved = new SingleAwaitSubject<Tuple<UIKit.UIVideoEditorController, string>>();
        public IObservable<Tuple<UIKit.UIVideoEditorController, string>> VideoSavedObs { get { return _VideoSaved; } }
        public override void VideoSaved(UIKit.UIVideoEditorController editor, string editedVideoPath)
        {
            _VideoSaved.OnNext(Tuple.Create(editor, editedVideoPath));
        }

    }
    public  partial class UITableViewDelegateRx : UITableViewDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _AccessoryButtonTapped = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> AccessoryButtonTappedObs { get { return _AccessoryButtonTapped; } }
        public override void AccessoryButtonTapped(UIKit.UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            _AccessoryButtonTapped.OnNext(Tuple.Create(tableView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewCell, Foundation.NSIndexPath>> _CellDisplayingEnded = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewCell, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UITableViewCell, Foundation.NSIndexPath>> CellDisplayingEndedObs { get { return _CellDisplayingEnded; } }
        public override void CellDisplayingEnded(UIKit.UITableView tableView, UIKit.UITableViewCell cell, Foundation.NSIndexPath indexPath)
        {
            _CellDisplayingEnded.OnNext(Tuple.Create(tableView, cell, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _DidEndEditing = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> DidEndEditingObs { get { return _DidEndEditing; } }
        public override void DidEndEditing(UIKit.UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            _DidEndEditing.OnNext(Tuple.Create(tableView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewFocusUpdateContext, UIKit.UIFocusAnimationCoordinator>> _DidUpdateFocus = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewFocusUpdateContext, UIKit.UIFocusAnimationCoordinator>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UITableViewFocusUpdateContext, UIKit.UIFocusAnimationCoordinator>> DidUpdateFocusObs { get { return _DidUpdateFocus; } }
        public override void DidUpdateFocus(UIKit.UITableView tableView, UIKit.UITableViewFocusUpdateContext context, UIKit.UIFocusAnimationCoordinator coordinator)
        {
            _DidUpdateFocus.OnNext(Tuple.Create(tableView, context, coordinator));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> _FooterViewDisplayingEnded = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> FooterViewDisplayingEndedObs { get { return _FooterViewDisplayingEnded; } }
        public override void FooterViewDisplayingEnded(UIKit.UITableView tableView, UIKit.UIView footerView, System.nint section)
        {
            _FooterViewDisplayingEnded.OnNext(Tuple.Create(tableView, footerView, section));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> _HeaderViewDisplayingEnded = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> HeaderViewDisplayingEndedObs { get { return _HeaderViewDisplayingEnded; } }
        public override void HeaderViewDisplayingEnded(UIKit.UITableView tableView, UIKit.UIView headerView, System.nint section)
        {
            _HeaderViewDisplayingEnded.OnNext(Tuple.Create(tableView, headerView, section));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, ObjCRuntime.Selector, Foundation.NSIndexPath, Foundation.NSObject>> _PerformAction = new SingleAwaitSubject<Tuple<UIKit.UITableView, ObjCRuntime.Selector, Foundation.NSIndexPath, Foundation.NSObject>>();
        public IObservable<Tuple<UIKit.UITableView, ObjCRuntime.Selector, Foundation.NSIndexPath, Foundation.NSObject>> PerformActionObs { get { return _PerformAction; } }
        public override void PerformAction(UIKit.UITableView tableView, ObjCRuntime.Selector action, Foundation.NSIndexPath indexPath, Foundation.NSObject sender)
        {
            _PerformAction.OnNext(Tuple.Create(tableView, action, indexPath, sender));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _RowDeselected = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> RowDeselectedObs { get { return _RowDeselected; } }
        public override void RowDeselected(UIKit.UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            _RowDeselected.OnNext(Tuple.Create(tableView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _RowHighlighted = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> RowHighlightedObs { get { return _RowHighlighted; } }
        public override void RowHighlighted(UIKit.UITableView tableView, Foundation.NSIndexPath rowIndexPath)
        {
            _RowHighlighted.OnNext(Tuple.Create(tableView, rowIndexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _RowSelected = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> RowSelectedObs { get { return _RowSelected; } }
        public override void RowSelected(UIKit.UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            _RowSelected.OnNext(Tuple.Create(tableView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _RowUnhighlighted = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> RowUnhighlightedObs { get { return _RowUnhighlighted; } }
        public override void RowUnhighlighted(UIKit.UITableView tableView, Foundation.NSIndexPath rowIndexPath)
        {
            _RowUnhighlighted.OnNext(Tuple.Create(tableView, rowIndexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _WillBeginEditing = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> WillBeginEditingObs { get { return _WillBeginEditing; } }
        public override void WillBeginEditing(UIKit.UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            _WillBeginEditing.OnNext(Tuple.Create(tableView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewCell, Foundation.NSIndexPath>> _WillDisplay = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewCell, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UITableViewCell, Foundation.NSIndexPath>> WillDisplayObs { get { return _WillDisplay; } }
        public override void WillDisplay(UIKit.UITableView tableView, UIKit.UITableViewCell cell, Foundation.NSIndexPath indexPath)
        {
            _WillDisplay.OnNext(Tuple.Create(tableView, cell, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> _WillDisplayFooterView = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> WillDisplayFooterViewObs { get { return _WillDisplayFooterView; } }
        public override void WillDisplayFooterView(UIKit.UITableView tableView, UIKit.UIView footerView, System.nint section)
        {
            _WillDisplayFooterView.OnNext(Tuple.Create(tableView, footerView, section));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> _WillDisplayHeaderView = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> WillDisplayHeaderViewObs { get { return _WillDisplayHeaderView; } }
        public override void WillDisplayHeaderView(UIKit.UITableView tableView, UIKit.UIView headerView, System.nint section)
        {
            _WillDisplayHeaderView.OnNext(Tuple.Create(tableView, headerView, section));
        }

    }
    public abstract partial class UITextInputDelegateRx : UITextInputDelegate
    {
        readonly SingleAwaitSubject<UIKit.IUITextInput> _SelectionDidChange = new SingleAwaitSubject<UIKit.IUITextInput>();
        public IObservable<UIKit.IUITextInput> SelectionDidChangeObs { get { return _SelectionDidChange; } }
        public override void SelectionDidChange(UIKit.IUITextInput uiTextInput)
        {
            _SelectionDidChange.OnNext(uiTextInput);
        }

        readonly SingleAwaitSubject<UIKit.IUITextInput> _SelectionWillChange = new SingleAwaitSubject<UIKit.IUITextInput>();
        public IObservable<UIKit.IUITextInput> SelectionWillChangeObs { get { return _SelectionWillChange; } }
        public override void SelectionWillChange(UIKit.IUITextInput uiTextInput)
        {
            _SelectionWillChange.OnNext(uiTextInput);
        }

        readonly SingleAwaitSubject<UIKit.IUITextInput> _TextDidChange = new SingleAwaitSubject<UIKit.IUITextInput>();
        public IObservable<UIKit.IUITextInput> TextDidChangeObs { get { return _TextDidChange; } }
        public override void TextDidChange(UIKit.IUITextInput textInput)
        {
            _TextDidChange.OnNext(textInput);
        }

        readonly SingleAwaitSubject<UIKit.IUITextInput> _TextWillChange = new SingleAwaitSubject<UIKit.IUITextInput>();
        public IObservable<UIKit.IUITextInput> TextWillChangeObs { get { return _TextWillChange; } }
        public override void TextWillChange(UIKit.IUITextInput textInput)
        {
            _TextWillChange.OnNext(textInput);
        }

    }
    public abstract partial class UITableViewSourceRx : UITableViewSource
    {
        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _AccessoryButtonTapped = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> AccessoryButtonTappedObs { get { return _AccessoryButtonTapped; } }
        public override void AccessoryButtonTapped(UIKit.UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            _AccessoryButtonTapped.OnNext(Tuple.Create(tableView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewCell, Foundation.NSIndexPath>> _CellDisplayingEnded = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewCell, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UITableViewCell, Foundation.NSIndexPath>> CellDisplayingEndedObs { get { return _CellDisplayingEnded; } }
        public override void CellDisplayingEnded(UIKit.UITableView tableView, UIKit.UITableViewCell cell, Foundation.NSIndexPath indexPath)
        {
            _CellDisplayingEnded.OnNext(Tuple.Create(tableView, cell, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewCellEditingStyle, Foundation.NSIndexPath>> _CommitEditingStyle = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewCellEditingStyle, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UITableViewCellEditingStyle, Foundation.NSIndexPath>> CommitEditingStyleObs { get { return _CommitEditingStyle; } }
        public override void CommitEditingStyle(UIKit.UITableView tableView, UIKit.UITableViewCellEditingStyle editingStyle, Foundation.NSIndexPath indexPath)
        {
            _CommitEditingStyle.OnNext(Tuple.Create(tableView, editingStyle, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _DidEndEditing = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> DidEndEditingObs { get { return _DidEndEditing; } }
        public override void DidEndEditing(UIKit.UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            _DidEndEditing.OnNext(Tuple.Create(tableView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewFocusUpdateContext, UIKit.UIFocusAnimationCoordinator>> _DidUpdateFocus = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewFocusUpdateContext, UIKit.UIFocusAnimationCoordinator>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UITableViewFocusUpdateContext, UIKit.UIFocusAnimationCoordinator>> DidUpdateFocusObs { get { return _DidUpdateFocus; } }
        public override void DidUpdateFocus(UIKit.UITableView tableView, UIKit.UITableViewFocusUpdateContext context, UIKit.UIFocusAnimationCoordinator coordinator)
        {
            _DidUpdateFocus.OnNext(Tuple.Create(tableView, context, coordinator));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> _FooterViewDisplayingEnded = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> FooterViewDisplayingEndedObs { get { return _FooterViewDisplayingEnded; } }
        public override void FooterViewDisplayingEnded(UIKit.UITableView tableView, UIKit.UIView footerView, System.nint section)
        {
            _FooterViewDisplayingEnded.OnNext(Tuple.Create(tableView, footerView, section));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> _HeaderViewDisplayingEnded = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> HeaderViewDisplayingEndedObs { get { return _HeaderViewDisplayingEnded; } }
        public override void HeaderViewDisplayingEnded(UIKit.UITableView tableView, UIKit.UIView headerView, System.nint section)
        {
            _HeaderViewDisplayingEnded.OnNext(Tuple.Create(tableView, headerView, section));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath, Foundation.NSIndexPath>> _MoveRow = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath, Foundation.NSIndexPath>> MoveRowObs { get { return _MoveRow; } }
        public override void MoveRow(UIKit.UITableView tableView, Foundation.NSIndexPath sourceIndexPath, Foundation.NSIndexPath destinationIndexPath)
        {
            _MoveRow.OnNext(Tuple.Create(tableView, sourceIndexPath, destinationIndexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, ObjCRuntime.Selector, Foundation.NSIndexPath, Foundation.NSObject>> _PerformAction = new SingleAwaitSubject<Tuple<UIKit.UITableView, ObjCRuntime.Selector, Foundation.NSIndexPath, Foundation.NSObject>>();
        public IObservable<Tuple<UIKit.UITableView, ObjCRuntime.Selector, Foundation.NSIndexPath, Foundation.NSObject>> PerformActionObs { get { return _PerformAction; } }
        public override void PerformAction(UIKit.UITableView tableView, ObjCRuntime.Selector action, Foundation.NSIndexPath indexPath, Foundation.NSObject sender)
        {
            _PerformAction.OnNext(Tuple.Create(tableView, action, indexPath, sender));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _RowDeselected = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> RowDeselectedObs { get { return _RowDeselected; } }
        public override void RowDeselected(UIKit.UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            _RowDeselected.OnNext(Tuple.Create(tableView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _RowHighlighted = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> RowHighlightedObs { get { return _RowHighlighted; } }
        public override void RowHighlighted(UIKit.UITableView tableView, Foundation.NSIndexPath rowIndexPath)
        {
            _RowHighlighted.OnNext(Tuple.Create(tableView, rowIndexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _RowSelected = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> RowSelectedObs { get { return _RowSelected; } }
        public override void RowSelected(UIKit.UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            _RowSelected.OnNext(Tuple.Create(tableView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _RowUnhighlighted = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> RowUnhighlightedObs { get { return _RowUnhighlighted; } }
        public override void RowUnhighlighted(UIKit.UITableView tableView, Foundation.NSIndexPath rowIndexPath)
        {
            _RowUnhighlighted.OnNext(Tuple.Create(tableView, rowIndexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> _WillBeginEditing = new SingleAwaitSubject<Tuple<UIKit.UITableView, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, Foundation.NSIndexPath>> WillBeginEditingObs { get { return _WillBeginEditing; } }
        public override void WillBeginEditing(UIKit.UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            _WillBeginEditing.OnNext(Tuple.Create(tableView, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewCell, Foundation.NSIndexPath>> _WillDisplay = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UITableViewCell, Foundation.NSIndexPath>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UITableViewCell, Foundation.NSIndexPath>> WillDisplayObs { get { return _WillDisplay; } }
        public override void WillDisplay(UIKit.UITableView tableView, UIKit.UITableViewCell cell, Foundation.NSIndexPath indexPath)
        {
            _WillDisplay.OnNext(Tuple.Create(tableView, cell, indexPath));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> _WillDisplayFooterView = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> WillDisplayFooterViewObs { get { return _WillDisplayFooterView; } }
        public override void WillDisplayFooterView(UIKit.UITableView tableView, UIKit.UIView footerView, System.nint section)
        {
            _WillDisplayFooterView.OnNext(Tuple.Create(tableView, footerView, section));
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> _WillDisplayHeaderView = new SingleAwaitSubject<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>>();
        public IObservable<Tuple<UIKit.UITableView, UIKit.UIView, System.nint>> WillDisplayHeaderViewObs { get { return _WillDisplayHeaderView; } }
        public override void WillDisplayHeaderView(UIKit.UITableView tableView, UIKit.UIView headerView, System.nint section)
        {
            _WillDisplayHeaderView.OnNext(Tuple.Create(tableView, headerView, section));
        }

    }
    public  partial class UIWebViewDelegateRx : UIWebViewDelegate
    {
        readonly SingleAwaitSubject<UIKit.UIWebView> _LoadingFinished = new SingleAwaitSubject<UIKit.UIWebView>();
        public IObservable<UIKit.UIWebView> LoadingFinishedObs { get { return _LoadingFinished; } }
        public override void LoadingFinished(UIKit.UIWebView webView)
        {
            _LoadingFinished.OnNext(webView);
        }

        readonly SingleAwaitSubject<UIKit.UIWebView> _LoadStarted = new SingleAwaitSubject<UIKit.UIWebView>();
        public IObservable<UIKit.UIWebView> LoadStartedObs { get { return _LoadStarted; } }
        public override void LoadStarted(UIKit.UIWebView webView)
        {
            _LoadStarted.OnNext(webView);
        }

        readonly SingleAwaitSubject<Tuple<UIKit.UIWebView, Foundation.NSError>> _LoadFailed = new SingleAwaitSubject<Tuple<UIKit.UIWebView, Foundation.NSError>>();
        public IObservable<Tuple<UIKit.UIWebView, Foundation.NSError>> LoadFailedObs { get { return _LoadFailed; } }
        public override void LoadFailed(UIKit.UIWebView webView, Foundation.NSError error)
        {
            _LoadFailed.OnNext(Tuple.Create(webView, error));
        }

    }
    public abstract partial class UIViewControllerPreviewingDelegateRx : UIViewControllerPreviewingDelegate
    {
        readonly SingleAwaitSubject<Tuple<UIKit.IUIViewControllerPreviewing, UIKit.UIViewController>> _CommitViewController = new SingleAwaitSubject<Tuple<UIKit.IUIViewControllerPreviewing, UIKit.UIViewController>>();
        public IObservable<Tuple<UIKit.IUIViewControllerPreviewing, UIKit.UIViewController>> CommitViewControllerObs { get { return _CommitViewController; } }
        public override void CommitViewController(UIKit.IUIViewControllerPreviewing previewingContext, UIKit.UIViewController viewControllerToCommit)
        {
            _CommitViewController.OnNext(Tuple.Create(previewingContext, viewControllerToCommit));
        }

    }
}
namespace Speech.Rx
{
    public  partial class SFSpeechRecognitionTaskDelegateRx : SFSpeechRecognitionTaskDelegate
    {
        readonly SingleAwaitSubject<Speech.SFSpeechRecognitionTask> _DidDetectSpeech = new SingleAwaitSubject<Speech.SFSpeechRecognitionTask>();
        public IObservable<Speech.SFSpeechRecognitionTask> DidDetectSpeechObs { get { return _DidDetectSpeech; } }
        public override void DidDetectSpeech(Speech.SFSpeechRecognitionTask task)
        {
            _DidDetectSpeech.OnNext(task);
        }

        readonly SingleAwaitSubject<Speech.SFSpeechRecognitionTask> _FinishedReadingAudio = new SingleAwaitSubject<Speech.SFSpeechRecognitionTask>();
        public IObservable<Speech.SFSpeechRecognitionTask> FinishedReadingAudioObs { get { return _FinishedReadingAudio; } }
        public override void FinishedReadingAudio(Speech.SFSpeechRecognitionTask task)
        {
            _FinishedReadingAudio.OnNext(task);
        }

        readonly SingleAwaitSubject<Speech.SFSpeechRecognitionTask> _WasCancelled = new SingleAwaitSubject<Speech.SFSpeechRecognitionTask>();
        public IObservable<Speech.SFSpeechRecognitionTask> WasCancelledObs { get { return _WasCancelled; } }
        public override void WasCancelled(Speech.SFSpeechRecognitionTask task)
        {
            _WasCancelled.OnNext(task);
        }

        readonly SingleAwaitSubject<Tuple<Speech.SFSpeechRecognitionTask, Speech.SFSpeechRecognitionResult>> _DidFinishRecognition = new SingleAwaitSubject<Tuple<Speech.SFSpeechRecognitionTask, Speech.SFSpeechRecognitionResult>>();
        public IObservable<Tuple<Speech.SFSpeechRecognitionTask, Speech.SFSpeechRecognitionResult>> DidFinishRecognitionObs { get { return _DidFinishRecognition; } }
        public override void DidFinishRecognition(Speech.SFSpeechRecognitionTask task, Speech.SFSpeechRecognitionResult recognitionResult)
        {
            _DidFinishRecognition.OnNext(Tuple.Create(task, recognitionResult));
        }

        readonly SingleAwaitSubject<Tuple<Speech.SFSpeechRecognitionTask, System.Boolean>> _DidFinishSuccessfully = new SingleAwaitSubject<Tuple<Speech.SFSpeechRecognitionTask, System.Boolean>>();
        public IObservable<Tuple<Speech.SFSpeechRecognitionTask, System.Boolean>> DidFinishSuccessfullyObs { get { return _DidFinishSuccessfully; } }
        public override void DidFinishSuccessfully(Speech.SFSpeechRecognitionTask task, System.Boolean successfully)
        {
            _DidFinishSuccessfully.OnNext(Tuple.Create(task, successfully));
        }

        readonly SingleAwaitSubject<Tuple<Speech.SFSpeechRecognitionTask, Speech.SFTranscription>> _DidHypothesizeTranscription = new SingleAwaitSubject<Tuple<Speech.SFSpeechRecognitionTask, Speech.SFTranscription>>();
        public IObservable<Tuple<Speech.SFSpeechRecognitionTask, Speech.SFTranscription>> DidHypothesizeTranscriptionObs { get { return _DidHypothesizeTranscription; } }
        public override void DidHypothesizeTranscription(Speech.SFSpeechRecognitionTask task, Speech.SFTranscription transcription)
        {
            _DidHypothesizeTranscription.OnNext(Tuple.Create(task, transcription));
        }

    }
    public  partial class SFSpeechRecognizerDelegateRx : SFSpeechRecognizerDelegate
    {
        readonly SingleAwaitSubject<Tuple<Speech.SFSpeechRecognizer, System.Boolean>> _AvailabilityDidChange = new SingleAwaitSubject<Tuple<Speech.SFSpeechRecognizer, System.Boolean>>();
        public IObservable<Tuple<Speech.SFSpeechRecognizer, System.Boolean>> AvailabilityDidChangeObs { get { return _AvailabilityDidChange; } }
        public override void AvailabilityDidChange(Speech.SFSpeechRecognizer speechRecognizer, System.Boolean available)
        {
            _AvailabilityDidChange.OnNext(Tuple.Create(speechRecognizer, available));
        }

    }
}
namespace ContactsUI.Rx
{
    public  partial class CNContactPickerDelegateRx : CNContactPickerDelegate
    {
        readonly SingleAwaitSubject<ContactsUI.CNContactPickerViewController> _ContactPickerDidCancel = new SingleAwaitSubject<ContactsUI.CNContactPickerViewController>();
        public IObservable<ContactsUI.CNContactPickerViewController> ContactPickerDidCancelObs { get { return _ContactPickerDidCancel; } }
        public override void ContactPickerDidCancel(ContactsUI.CNContactPickerViewController picker)
        {
            _ContactPickerDidCancel.OnNext(picker);
        }

        readonly SingleAwaitSubject<Tuple<ContactsUI.CNContactPickerViewController, Contacts.CNContact>> _DidSelectContact = new SingleAwaitSubject<Tuple<ContactsUI.CNContactPickerViewController, Contacts.CNContact>>();
        public IObservable<Tuple<ContactsUI.CNContactPickerViewController, Contacts.CNContact>> DidSelectContactObs { get { return _DidSelectContact; } }
        public override void DidSelectContact(ContactsUI.CNContactPickerViewController picker, Contacts.CNContact contact)
        {
            _DidSelectContact.OnNext(Tuple.Create(picker, contact));
        }

        readonly SingleAwaitSubject<Tuple<ContactsUI.CNContactPickerViewController, Contacts.CNContactProperty[]>> _DidSelectContactProperties = new SingleAwaitSubject<Tuple<ContactsUI.CNContactPickerViewController, Contacts.CNContactProperty[]>>();
        public IObservable<Tuple<ContactsUI.CNContactPickerViewController, Contacts.CNContactProperty[]>> DidSelectContactPropertiesObs { get { return _DidSelectContactProperties; } }
        public override void DidSelectContactProperties(ContactsUI.CNContactPickerViewController picker, Contacts.CNContactProperty[] contactProperties)
        {
            _DidSelectContactProperties.OnNext(Tuple.Create(picker, contactProperties));
        }

        readonly SingleAwaitSubject<Tuple<ContactsUI.CNContactPickerViewController, Contacts.CNContactProperty>> _DidSelectContactProperty = new SingleAwaitSubject<Tuple<ContactsUI.CNContactPickerViewController, Contacts.CNContactProperty>>();
        public IObservable<Tuple<ContactsUI.CNContactPickerViewController, Contacts.CNContactProperty>> DidSelectContactPropertyObs { get { return _DidSelectContactProperty; } }
        public override void DidSelectContactProperty(ContactsUI.CNContactPickerViewController picker, Contacts.CNContactProperty contactProperty)
        {
            _DidSelectContactProperty.OnNext(Tuple.Create(picker, contactProperty));
        }

        readonly SingleAwaitSubject<Tuple<ContactsUI.CNContactPickerViewController, Contacts.CNContact[]>> _DidSelectContacts = new SingleAwaitSubject<Tuple<ContactsUI.CNContactPickerViewController, Contacts.CNContact[]>>();
        public IObservable<Tuple<ContactsUI.CNContactPickerViewController, Contacts.CNContact[]>> DidSelectContactsObs { get { return _DidSelectContacts; } }
        public override void DidSelectContacts(ContactsUI.CNContactPickerViewController picker, Contacts.CNContact[] contacts)
        {
            _DidSelectContacts.OnNext(Tuple.Create(picker, contacts));
        }

    }
    public  partial class CNContactViewControllerDelegateRx : CNContactViewControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<ContactsUI.CNContactViewController, Contacts.CNContact>> _DidComplete = new SingleAwaitSubject<Tuple<ContactsUI.CNContactViewController, Contacts.CNContact>>();
        public IObservable<Tuple<ContactsUI.CNContactViewController, Contacts.CNContact>> DidCompleteObs { get { return _DidComplete; } }
        public override void DidComplete(ContactsUI.CNContactViewController viewController, Contacts.CNContact contact)
        {
            _DidComplete.OnNext(Tuple.Create(viewController, contact));
        }

    }
}
namespace SpriteKit.Rx
{
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
    public  partial class SKStoreProductViewControllerDelegateRx : SKStoreProductViewControllerDelegate
    {
        readonly SingleAwaitSubject<StoreKit.SKStoreProductViewController> _Finished = new SingleAwaitSubject<StoreKit.SKStoreProductViewController>();
        public IObservable<StoreKit.SKStoreProductViewController> FinishedObs { get { return _Finished; } }
        public override void Finished(StoreKit.SKStoreProductViewController controller)
        {
            _Finished.OnNext(controller);
        }

    }
}
namespace CoreData.Rx
{
    public  partial class NSFetchedResultsControllerDelegateRx : NSFetchedResultsControllerDelegate
    {
        readonly SingleAwaitSubject<CoreData.NSFetchedResultsController> _DidChangeContent = new SingleAwaitSubject<CoreData.NSFetchedResultsController>();
        public IObservable<CoreData.NSFetchedResultsController> DidChangeContentObs { get { return _DidChangeContent; } }
        public override void DidChangeContent(CoreData.NSFetchedResultsController controller)
        {
            _DidChangeContent.OnNext(controller);
        }

        readonly SingleAwaitSubject<CoreData.NSFetchedResultsController> _WillChangeContent = new SingleAwaitSubject<CoreData.NSFetchedResultsController>();
        public IObservable<CoreData.NSFetchedResultsController> WillChangeContentObs { get { return _WillChangeContent; } }
        public override void WillChangeContent(CoreData.NSFetchedResultsController controller)
        {
            _WillChangeContent.OnNext(controller);
        }

        readonly SingleAwaitSubject<Tuple<CoreData.NSFetchedResultsController, Foundation.NSObject, Foundation.NSIndexPath, CoreData.NSFetchedResultsChangeType, Foundation.NSIndexPath>> _DidChangeObject = new SingleAwaitSubject<Tuple<CoreData.NSFetchedResultsController, Foundation.NSObject, Foundation.NSIndexPath, CoreData.NSFetchedResultsChangeType, Foundation.NSIndexPath>>();
        public IObservable<Tuple<CoreData.NSFetchedResultsController, Foundation.NSObject, Foundation.NSIndexPath, CoreData.NSFetchedResultsChangeType, Foundation.NSIndexPath>> DidChangeObjectObs { get { return _DidChangeObject; } }
        public override void DidChangeObject(CoreData.NSFetchedResultsController controller, Foundation.NSObject anObject, Foundation.NSIndexPath indexPath, CoreData.NSFetchedResultsChangeType type, Foundation.NSIndexPath newIndexPath)
        {
            _DidChangeObject.OnNext(Tuple.Create(controller, anObject, indexPath, type, newIndexPath));
        }

        readonly SingleAwaitSubject<Tuple<CoreData.NSFetchedResultsController, CoreData.INSFetchedResultsSectionInfo, System.nuint, CoreData.NSFetchedResultsChangeType>> _DidChangeSection = new SingleAwaitSubject<Tuple<CoreData.NSFetchedResultsController, CoreData.INSFetchedResultsSectionInfo, System.nuint, CoreData.NSFetchedResultsChangeType>>();
        public IObservable<Tuple<CoreData.NSFetchedResultsController, CoreData.INSFetchedResultsSectionInfo, System.nuint, CoreData.NSFetchedResultsChangeType>> DidChangeSectionObs { get { return _DidChangeSection; } }
        public override void DidChangeSection(CoreData.NSFetchedResultsController controller, CoreData.INSFetchedResultsSectionInfo sectionInfo, System.nuint sectionIndex, CoreData.NSFetchedResultsChangeType type)
        {
            _DidChangeSection.OnNext(Tuple.Create(controller, sectionInfo, sectionIndex, type));
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

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView, UIKit.UIControl>> _CalloutAccessoryControlTapped = new SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView, UIKit.UIControl>>();
        public IObservable<Tuple<MapKit.MKMapView, MapKit.MKAnnotationView, UIKit.UIControl>> CalloutAccessoryControlTappedObs { get { return _CalloutAccessoryControlTapped; } }
        public override void CalloutAccessoryControlTapped(MapKit.MKMapView mapView, MapKit.MKAnnotationView view, UIKit.UIControl control)
        {
            _CalloutAccessoryControlTapped.OnNext(Tuple.Create(mapView, view, control));
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

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKOverlayView>> _DidAddOverlayViews = new SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKOverlayView>>();
        public IObservable<Tuple<MapKit.MKMapView, MapKit.MKOverlayView>> DidAddOverlayViewsObs { get { return _DidAddOverlayViews; } }
        public override void DidAddOverlayViews(MapKit.MKMapView mapView, MapKit.MKOverlayView overlayViews)
        {
            _DidAddOverlayViews.OnNext(Tuple.Create(mapView, overlayViews));
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKUserTrackingMode, System.Boolean>> _DidChangeUserTrackingMode = new SingleAwaitSubject<Tuple<MapKit.MKMapView, MapKit.MKUserTrackingMode, System.Boolean>>();
        public IObservable<Tuple<MapKit.MKMapView, MapKit.MKUserTrackingMode, System.Boolean>> DidChangeUserTrackingModeObs { get { return _DidChangeUserTrackingMode; } }
        public override void DidChangeUserTrackingMode(MapKit.MKMapView mapView, MapKit.MKUserTrackingMode mode, System.Boolean animated)
        {
            _DidChangeUserTrackingMode.OnNext(Tuple.Create(mapView, mode, animated));
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
    public abstract partial class MKReverseGeocoderDelegateRx : MKReverseGeocoderDelegate
    {
        readonly SingleAwaitSubject<Tuple<MapKit.MKReverseGeocoder, Foundation.NSError>> _FailedWithError = new SingleAwaitSubject<Tuple<MapKit.MKReverseGeocoder, Foundation.NSError>>();
        public IObservable<Tuple<MapKit.MKReverseGeocoder, Foundation.NSError>> FailedWithErrorObs { get { return _FailedWithError; } }
        public override void FailedWithError(MapKit.MKReverseGeocoder geocoder, Foundation.NSError error)
        {
            _FailedWithError.OnNext(Tuple.Create(geocoder, error));
        }

        readonly SingleAwaitSubject<Tuple<MapKit.MKReverseGeocoder, MapKit.MKPlacemark>> _FoundWithPlacemark = new SingleAwaitSubject<Tuple<MapKit.MKReverseGeocoder, MapKit.MKPlacemark>>();
        public IObservable<Tuple<MapKit.MKReverseGeocoder, MapKit.MKPlacemark>> FoundWithPlacemarkObs { get { return _FoundWithPlacemark; } }
        public override void FoundWithPlacemark(MapKit.MKReverseGeocoder geocoder, MapKit.MKPlacemark placemark)
        {
            _FoundWithPlacemark.OnNext(Tuple.Create(geocoder, placemark));
        }

    }
}
namespace CoreSpotlight.Rx
{
    public abstract partial class CSSearchableIndexDelegateRx : CSSearchableIndexDelegate
    {
        readonly SingleAwaitSubject<CoreSpotlight.CSSearchableIndex> _DidFinishThrottle = new SingleAwaitSubject<CoreSpotlight.CSSearchableIndex>();
        public IObservable<CoreSpotlight.CSSearchableIndex> DidFinishThrottleObs { get { return _DidFinishThrottle; } }
        public override void DidFinishThrottle(CoreSpotlight.CSSearchableIndex searchableIndex)
        {
            _DidFinishThrottle.OnNext(searchableIndex);
        }

        readonly SingleAwaitSubject<CoreSpotlight.CSSearchableIndex> _DidThrottle = new SingleAwaitSubject<CoreSpotlight.CSSearchableIndex>();
        public IObservable<CoreSpotlight.CSSearchableIndex> DidThrottleObs { get { return _DidThrottle; } }
        public override void DidThrottle(CoreSpotlight.CSSearchableIndex searchableIndex)
        {
            _DidThrottle.OnNext(searchableIndex);
        }

        readonly SingleAwaitSubject<Tuple<CoreSpotlight.CSSearchableIndex, System.Action>> _ReindexAllSearchableItems = new SingleAwaitSubject<Tuple<CoreSpotlight.CSSearchableIndex, System.Action>>();
        public IObservable<Tuple<CoreSpotlight.CSSearchableIndex, System.Action>> ReindexAllSearchableItemsObs { get { return _ReindexAllSearchableItems; } }
        public override void ReindexAllSearchableItems(CoreSpotlight.CSSearchableIndex searchableIndex, System.Action acknowledgementHandler)
        {
            _ReindexAllSearchableItems.OnNext(Tuple.Create(searchableIndex, acknowledgementHandler));
        }

        readonly SingleAwaitSubject<Tuple<CoreSpotlight.CSSearchableIndex, string[], System.Action>> _ReindexSearchableItems = new SingleAwaitSubject<Tuple<CoreSpotlight.CSSearchableIndex, string[], System.Action>>();
        public IObservable<Tuple<CoreSpotlight.CSSearchableIndex, string[], System.Action>> ReindexSearchableItemsObs { get { return _ReindexSearchableItems; } }
        public override void ReindexSearchableItems(CoreSpotlight.CSSearchableIndex searchableIndex, string[] identifiers, System.Action acknowledgementHandler)
        {
            _ReindexSearchableItems.OnNext(Tuple.Create(searchableIndex, identifiers, acknowledgementHandler));
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

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLBeacon[], CoreLocation.CLBeaconRegion>> _DidRangeBeacons = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLBeacon[], CoreLocation.CLBeaconRegion>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLBeacon[], CoreLocation.CLBeaconRegion>> DidRangeBeaconsObs { get { return _DidRangeBeacons; } }
        public override void DidRangeBeacons(CoreLocation.CLLocationManager manager, CoreLocation.CLBeacon[] beacons, CoreLocation.CLBeaconRegion region)
        {
            _DidRangeBeacons.OnNext(Tuple.Create(manager, beacons, region));
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion>> _DidStartMonitoringForRegion = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLRegion>> DidStartMonitoringForRegionObs { get { return _DidStartMonitoringForRegion; } }
        public override void DidStartMonitoringForRegion(CoreLocation.CLLocationManager manager, CoreLocation.CLRegion region)
        {
            _DidStartMonitoringForRegion.OnNext(Tuple.Create(manager, region));
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLVisit>> _DidVisit = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLVisit>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLVisit>> DidVisitObs { get { return _DidVisit; } }
        public override void DidVisit(CoreLocation.CLLocationManager manager, CoreLocation.CLVisit visit)
        {
            _DidVisit.OnNext(Tuple.Create(manager, visit));
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

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLBeaconRegion, Foundation.NSError>> _RangingBeaconsDidFailForRegion = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLBeaconRegion, Foundation.NSError>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLBeaconRegion, Foundation.NSError>> RangingBeaconsDidFailForRegionObs { get { return _RangingBeaconsDidFailForRegion; } }
        public override void RangingBeaconsDidFailForRegion(CoreLocation.CLLocationManager manager, CoreLocation.CLBeaconRegion region, Foundation.NSError error)
        {
            _RangingBeaconsDidFailForRegion.OnNext(Tuple.Create(manager, region, error));
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

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLHeading>> _UpdatedHeading = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLHeading>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLHeading>> UpdatedHeadingObs { get { return _UpdatedHeading; } }
        public override void UpdatedHeading(CoreLocation.CLLocationManager manager, CoreLocation.CLHeading newHeading)
        {
            _UpdatedHeading.OnNext(Tuple.Create(manager, newHeading));
        }

        readonly SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLLocation, CoreLocation.CLLocation>> _UpdatedLocation = new SingleAwaitSubject<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLLocation, CoreLocation.CLLocation>>();
        public IObservable<Tuple<CoreLocation.CLLocationManager, CoreLocation.CLLocation, CoreLocation.CLLocation>> UpdatedLocationObs { get { return _UpdatedLocation; } }
        public override void UpdatedLocation(CoreLocation.CLLocationManager manager, CoreLocation.CLLocation newLocation, CoreLocation.CLLocation oldLocation)
        {
            _UpdatedLocation.OnNext(Tuple.Create(manager, newLocation, oldLocation));
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
    public  partial class NSStreamDelegateRx : NSStreamDelegate
    {
        readonly SingleAwaitSubject<Tuple<Foundation.NSStream, Foundation.NSStreamEvent>> _HandleEvent = new SingleAwaitSubject<Tuple<Foundation.NSStream, Foundation.NSStreamEvent>>();
        public IObservable<Tuple<Foundation.NSStream, Foundation.NSStreamEvent>> HandleEventObs { get { return _HandleEvent; } }
        public override void HandleEvent(Foundation.NSStream theStream, Foundation.NSStreamEvent streamEvent)
        {
            _HandleEvent.OnNext(Tuple.Create(theStream, streamEvent));
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
}
namespace EventKitUI.Rx
{
    public  partial class EKCalendarChooserDelegateRx : EKCalendarChooserDelegate
    {
        readonly SingleAwaitSubject<EventKitUI.EKCalendarChooser> _Cancelled = new SingleAwaitSubject<EventKitUI.EKCalendarChooser>();
        public IObservable<EventKitUI.EKCalendarChooser> CancelledObs { get { return _Cancelled; } }
        public override void Cancelled(EventKitUI.EKCalendarChooser calendarChooser)
        {
            _Cancelled.OnNext(calendarChooser);
        }

        readonly SingleAwaitSubject<EventKitUI.EKCalendarChooser> _Finished = new SingleAwaitSubject<EventKitUI.EKCalendarChooser>();
        public IObservable<EventKitUI.EKCalendarChooser> FinishedObs { get { return _Finished; } }
        public override void Finished(EventKitUI.EKCalendarChooser calendarChooser)
        {
            _Finished.OnNext(calendarChooser);
        }

        readonly SingleAwaitSubject<EventKitUI.EKCalendarChooser> _SelectionChanged = new SingleAwaitSubject<EventKitUI.EKCalendarChooser>();
        public IObservable<EventKitUI.EKCalendarChooser> SelectionChangedObs { get { return _SelectionChanged; } }
        public override void SelectionChanged(EventKitUI.EKCalendarChooser calendarChooser)
        {
            _SelectionChanged.OnNext(calendarChooser);
        }

    }
    public abstract partial class EKEventEditViewDelegateRx : EKEventEditViewDelegate
    {
        readonly SingleAwaitSubject<Tuple<EventKitUI.EKEventEditViewController, EventKitUI.EKEventEditViewAction>> _Completed = new SingleAwaitSubject<Tuple<EventKitUI.EKEventEditViewController, EventKitUI.EKEventEditViewAction>>();
        public IObservable<Tuple<EventKitUI.EKEventEditViewController, EventKitUI.EKEventEditViewAction>> CompletedObs { get { return _Completed; } }
        public override void Completed(EventKitUI.EKEventEditViewController controller, EventKitUI.EKEventEditViewAction action)
        {
            _Completed.OnNext(Tuple.Create(controller, action));
        }

    }
    public abstract partial class EKEventViewDelegateRx : EKEventViewDelegate
    {
        readonly SingleAwaitSubject<Tuple<EventKitUI.EKEventViewController, EventKitUI.EKEventViewAction>> _Completed = new SingleAwaitSubject<Tuple<EventKitUI.EKEventViewController, EventKitUI.EKEventViewAction>>();
        public IObservable<Tuple<EventKitUI.EKEventViewController, EventKitUI.EKEventViewAction>> CompletedObs { get { return _Completed; } }
        public override void Completed(EventKitUI.EKEventViewController controller, EventKitUI.EKEventViewAction action)
        {
            _Completed.OnNext(Tuple.Create(controller, action));
        }

    }
}
namespace ExternalAccessory.Rx
{
    public  partial class EAAccessoryDelegateRx : EAAccessoryDelegate
    {
        readonly SingleAwaitSubject<ExternalAccessory.EAAccessory> _Disconnected = new SingleAwaitSubject<ExternalAccessory.EAAccessory>();
        public IObservable<ExternalAccessory.EAAccessory> DisconnectedObs { get { return _Disconnected; } }
        public override void Disconnected(ExternalAccessory.EAAccessory accessory)
        {
            _Disconnected.OnNext(accessory);
        }

    }
    public abstract partial class EAWiFiUnconfiguredAccessoryBrowserDelegateRx : EAWiFiUnconfiguredAccessoryBrowserDelegate
    {
        readonly SingleAwaitSubject<Tuple<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser, Foundation.NSSet>> _DidFindUnconfiguredAccessories = new SingleAwaitSubject<Tuple<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser, Foundation.NSSet>>();
        public IObservable<Tuple<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser, Foundation.NSSet>> DidFindUnconfiguredAccessoriesObs { get { return _DidFindUnconfiguredAccessories; } }
        public override void DidFindUnconfiguredAccessories(ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser browser, Foundation.NSSet accessories)
        {
            _DidFindUnconfiguredAccessories.OnNext(Tuple.Create(browser, accessories));
        }

        readonly SingleAwaitSubject<Tuple<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser, ExternalAccessory.EAWiFiUnconfiguredAccessory, ExternalAccessory.EAWiFiUnconfiguredAccessoryConfigurationStatus>> _DidFinishConfiguringAccessory = new SingleAwaitSubject<Tuple<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser, ExternalAccessory.EAWiFiUnconfiguredAccessory, ExternalAccessory.EAWiFiUnconfiguredAccessoryConfigurationStatus>>();
        public IObservable<Tuple<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser, ExternalAccessory.EAWiFiUnconfiguredAccessory, ExternalAccessory.EAWiFiUnconfiguredAccessoryConfigurationStatus>> DidFinishConfiguringAccessoryObs { get { return _DidFinishConfiguringAccessory; } }
        public override void DidFinishConfiguringAccessory(ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser browser, ExternalAccessory.EAWiFiUnconfiguredAccessory accessory, ExternalAccessory.EAWiFiUnconfiguredAccessoryConfigurationStatus status)
        {
            _DidFinishConfiguringAccessory.OnNext(Tuple.Create(browser, accessory, status));
        }

        readonly SingleAwaitSubject<Tuple<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser, Foundation.NSSet>> _DidRemoveUnconfiguredAccessories = new SingleAwaitSubject<Tuple<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser, Foundation.NSSet>>();
        public IObservable<Tuple<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser, Foundation.NSSet>> DidRemoveUnconfiguredAccessoriesObs { get { return _DidRemoveUnconfiguredAccessories; } }
        public override void DidRemoveUnconfiguredAccessories(ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser browser, Foundation.NSSet accessories)
        {
            _DidRemoveUnconfiguredAccessories.OnNext(Tuple.Create(browser, accessories));
        }

        readonly SingleAwaitSubject<Tuple<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser, ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowserState>> _DidUpdateState = new SingleAwaitSubject<Tuple<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser, ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowserState>>();
        public IObservable<Tuple<ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser, ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowserState>> DidUpdateStateObs { get { return _DidUpdateState; } }
        public override void DidUpdateState(ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser browser, ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowserState state)
        {
            _DidUpdateState.OnNext(Tuple.Create(browser, state));
        }

    }
}
namespace MessageUI.Rx
{
    public  partial class MFMailComposeViewControllerDelegateRx : MFMailComposeViewControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<MessageUI.MFMailComposeViewController, MessageUI.MFMailComposeResult, Foundation.NSError>> _Finished = new SingleAwaitSubject<Tuple<MessageUI.MFMailComposeViewController, MessageUI.MFMailComposeResult, Foundation.NSError>>();
        public IObservable<Tuple<MessageUI.MFMailComposeViewController, MessageUI.MFMailComposeResult, Foundation.NSError>> FinishedObs { get { return _Finished; } }
        public override void Finished(MessageUI.MFMailComposeViewController controller, MessageUI.MFMailComposeResult result, Foundation.NSError error)
        {
            _Finished.OnNext(Tuple.Create(controller, result, error));
        }

    }
    public abstract partial class MFMessageComposeViewControllerDelegateRx : MFMessageComposeViewControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<MessageUI.MFMessageComposeViewController, MessageUI.MessageComposeResult>> _Finished = new SingleAwaitSubject<Tuple<MessageUI.MFMessageComposeViewController, MessageUI.MessageComposeResult>>();
        public IObservable<Tuple<MessageUI.MFMessageComposeViewController, MessageUI.MessageComposeResult>> FinishedObs { get { return _Finished; } }
        public override void Finished(MessageUI.MFMessageComposeViewController controller, MessageUI.MessageComposeResult result)
        {
            _Finished.OnNext(Tuple.Create(controller, result));
        }

    }
}
namespace GLKit.Rx
{
    public abstract partial class GLKViewControllerDelegateRx : GLKViewControllerDelegate
    {
        readonly SingleAwaitSubject<GLKit.GLKViewController> _Update = new SingleAwaitSubject<GLKit.GLKViewController>();
        public IObservable<GLKit.GLKViewController> UpdateObs { get { return _Update; } }
        public override void Update(GLKit.GLKViewController controller)
        {
            _Update.OnNext(controller);
        }

        readonly SingleAwaitSubject<Tuple<GLKit.GLKViewController, System.Boolean>> _WillPause = new SingleAwaitSubject<Tuple<GLKit.GLKViewController, System.Boolean>>();
        public IObservable<Tuple<GLKit.GLKViewController, System.Boolean>> WillPauseObs { get { return _WillPause; } }
        public override void WillPause(GLKit.GLKViewController controller, System.Boolean pause)
        {
            _WillPause.OnNext(Tuple.Create(controller, pause));
        }

    }
    public abstract partial class GLKViewDelegateRx : GLKViewDelegate
    {
        readonly SingleAwaitSubject<Tuple<GLKit.GLKView, CoreGraphics.CGRect>> _DrawInRect = new SingleAwaitSubject<Tuple<GLKit.GLKView, CoreGraphics.CGRect>>();
        public IObservable<Tuple<GLKit.GLKView, CoreGraphics.CGRect>> DrawInRectObs { get { return _DrawInRect; } }
        public override void DrawInRect(GLKit.GLKView view, CoreGraphics.CGRect rect)
        {
            _DrawInRect.OnNext(Tuple.Create(view, rect));
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
namespace MultipeerConnectivity.Rx
{
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
}
namespace PassKit.Rx
{
    public abstract partial class PKAddPaymentPassViewControllerDelegateRx : PKAddPaymentPassViewControllerDelegate
    {
        readonly SingleAwaitSubject<Tuple<PassKit.PKAddPaymentPassViewController, PassKit.PKPaymentPass, Foundation.NSError>> _DidFinishAddingPaymentPass = new SingleAwaitSubject<Tuple<PassKit.PKAddPaymentPassViewController, PassKit.PKPaymentPass, Foundation.NSError>>();
        public IObservable<Tuple<PassKit.PKAddPaymentPassViewController, PassKit.PKPaymentPass, Foundation.NSError>> DidFinishAddingPaymentPassObs { get { return _DidFinishAddingPaymentPass; } }
        public override void DidFinishAddingPaymentPass(PassKit.PKAddPaymentPassViewController controller, PassKit.PKPaymentPass pass, Foundation.NSError error)
        {
            _DidFinishAddingPaymentPass.OnNext(Tuple.Create(controller, pass, error));
        }

        readonly SingleAwaitSubject<Tuple<PassKit.PKAddPaymentPassViewController, Foundation.NSData[], Foundation.NSData, Foundation.NSData, System.Action<PassKit.PKAddPaymentPassRequest>>> _GenerateRequestWithCertificateChain = new SingleAwaitSubject<Tuple<PassKit.PKAddPaymentPassViewController, Foundation.NSData[], Foundation.NSData, Foundation.NSData, System.Action<PassKit.PKAddPaymentPassRequest>>>();
        public IObservable<Tuple<PassKit.PKAddPaymentPassViewController, Foundation.NSData[], Foundation.NSData, Foundation.NSData, System.Action<PassKit.PKAddPaymentPassRequest>>> GenerateRequestWithCertificateChainObs { get { return _GenerateRequestWithCertificateChain; } }
        public override void GenerateRequestWithCertificateChain(PassKit.PKAddPaymentPassViewController controller, Foundation.NSData[] certificates, Foundation.NSData nonce, Foundation.NSData nonceSignature, System.Action<PassKit.PKAddPaymentPassRequest> handler)
        {
            _GenerateRequestWithCertificateChain.OnNext(Tuple.Create(controller, certificates, nonce, nonceSignature, handler));
        }

    }
    public abstract partial class PKPaymentAuthorizationControllerDelegateRx : PKPaymentAuthorizationControllerDelegate
    {
        readonly SingleAwaitSubject<PassKit.PKPaymentAuthorizationController> _DidFinish = new SingleAwaitSubject<PassKit.PKPaymentAuthorizationController>();
        public IObservable<PassKit.PKPaymentAuthorizationController> DidFinishObs { get { return _DidFinish; } }
        public override void DidFinish(PassKit.PKPaymentAuthorizationController controller)
        {
            _DidFinish.OnNext(controller);
        }

        readonly SingleAwaitSubject<PassKit.PKPaymentAuthorizationController> _WillAuthorizePayment = new SingleAwaitSubject<PassKit.PKPaymentAuthorizationController>();
        public IObservable<PassKit.PKPaymentAuthorizationController> WillAuthorizePaymentObs { get { return _WillAuthorizePayment; } }
        public override void WillAuthorizePayment(PassKit.PKPaymentAuthorizationController controller)
        {
            _WillAuthorizePayment.OnNext(controller);
        }

        readonly SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationController, PassKit.PKPayment, System.Action<PassKit.PKPaymentAuthorizationStatus>>> _DidAuthorizePayment = new SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationController, PassKit.PKPayment, System.Action<PassKit.PKPaymentAuthorizationStatus>>>();
        public IObservable<Tuple<PassKit.PKPaymentAuthorizationController, PassKit.PKPayment, System.Action<PassKit.PKPaymentAuthorizationStatus>>> DidAuthorizePaymentObs { get { return _DidAuthorizePayment; } }
        public override void DidAuthorizePayment(PassKit.PKPaymentAuthorizationController controller, PassKit.PKPayment payment, System.Action<PassKit.PKPaymentAuthorizationStatus> completion)
        {
            _DidAuthorizePayment.OnNext(Tuple.Create(controller, payment, completion));
        }

        readonly SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationController, PassKit.PKPaymentMethod, System.Action<PassKit.PKPaymentSummaryItem[]>>> _DidSelectPaymentMethod = new SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationController, PassKit.PKPaymentMethod, System.Action<PassKit.PKPaymentSummaryItem[]>>>();
        public IObservable<Tuple<PassKit.PKPaymentAuthorizationController, PassKit.PKPaymentMethod, System.Action<PassKit.PKPaymentSummaryItem[]>>> DidSelectPaymentMethodObs { get { return _DidSelectPaymentMethod; } }
        public override void DidSelectPaymentMethod(PassKit.PKPaymentAuthorizationController controller, PassKit.PKPaymentMethod paymentMethod, System.Action<PassKit.PKPaymentSummaryItem[]> completion)
        {
            _DidSelectPaymentMethod.OnNext(Tuple.Create(controller, paymentMethod, completion));
        }

        readonly SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationController, PassKit.PKContact, System.Action<PassKit.PKPaymentAuthorizationStatus,PassKit.PKShippingMethod[],PassKit.PKPaymentSummaryItem[]>>> _DidSelectShippingContact = new SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationController, PassKit.PKContact, System.Action<PassKit.PKPaymentAuthorizationStatus,PassKit.PKShippingMethod[],PassKit.PKPaymentSummaryItem[]>>>();
        public IObservable<Tuple<PassKit.PKPaymentAuthorizationController, PassKit.PKContact, System.Action<PassKit.PKPaymentAuthorizationStatus,PassKit.PKShippingMethod[],PassKit.PKPaymentSummaryItem[]>>> DidSelectShippingContactObs { get { return _DidSelectShippingContact; } }
        public override void DidSelectShippingContact(PassKit.PKPaymentAuthorizationController controller, PassKit.PKContact contact, System.Action<PassKit.PKPaymentAuthorizationStatus,PassKit.PKShippingMethod[],PassKit.PKPaymentSummaryItem[]> completion)
        {
            _DidSelectShippingContact.OnNext(Tuple.Create(controller, contact, completion));
        }

        readonly SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationController, PassKit.PKShippingMethod, System.Action<PassKit.PKPaymentAuthorizationStatus,PassKit.PKPaymentSummaryItem[]>>> _DidSelectShippingMethod = new SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationController, PassKit.PKShippingMethod, System.Action<PassKit.PKPaymentAuthorizationStatus,PassKit.PKPaymentSummaryItem[]>>>();
        public IObservable<Tuple<PassKit.PKPaymentAuthorizationController, PassKit.PKShippingMethod, System.Action<PassKit.PKPaymentAuthorizationStatus,PassKit.PKPaymentSummaryItem[]>>> DidSelectShippingMethodObs { get { return _DidSelectShippingMethod; } }
        public override void DidSelectShippingMethod(PassKit.PKPaymentAuthorizationController controller, PassKit.PKShippingMethod shippingMethod, System.Action<PassKit.PKPaymentAuthorizationStatus,PassKit.PKPaymentSummaryItem[]> completion)
        {
            _DidSelectShippingMethod.OnNext(Tuple.Create(controller, shippingMethod, completion));
        }

    }
    public  partial class PKAddPassesViewControllerDelegateRx : PKAddPassesViewControllerDelegate
    {
        readonly SingleAwaitSubject<PassKit.PKAddPassesViewController> _Finished = new SingleAwaitSubject<PassKit.PKAddPassesViewController>();
        public IObservable<PassKit.PKAddPassesViewController> FinishedObs { get { return _Finished; } }
        public override void Finished(PassKit.PKAddPassesViewController controller)
        {
            _Finished.OnNext(controller);
        }

    }
    public abstract partial class PKPaymentAuthorizationViewControllerDelegateRx : PKPaymentAuthorizationViewControllerDelegate
    {
        readonly SingleAwaitSubject<PassKit.PKPaymentAuthorizationViewController> _PaymentAuthorizationViewControllerDidFinish = new SingleAwaitSubject<PassKit.PKPaymentAuthorizationViewController>();
        public IObservable<PassKit.PKPaymentAuthorizationViewController> PaymentAuthorizationViewControllerDidFinishObs { get { return _PaymentAuthorizationViewControllerDidFinish; } }
        public override void PaymentAuthorizationViewControllerDidFinish(PassKit.PKPaymentAuthorizationViewController controller)
        {
            _PaymentAuthorizationViewControllerDidFinish.OnNext(controller);
        }

        readonly SingleAwaitSubject<PassKit.PKPaymentAuthorizationViewController> _WillAuthorizePayment = new SingleAwaitSubject<PassKit.PKPaymentAuthorizationViewController>();
        public IObservable<PassKit.PKPaymentAuthorizationViewController> WillAuthorizePaymentObs { get { return _WillAuthorizePayment; } }
        public override void WillAuthorizePayment(PassKit.PKPaymentAuthorizationViewController controller)
        {
            _WillAuthorizePayment.OnNext(controller);
        }

        readonly SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationViewController, PassKit.PKPayment, System.Action<PassKit.PKPaymentAuthorizationStatus>>> _DidAuthorizePayment = new SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationViewController, PassKit.PKPayment, System.Action<PassKit.PKPaymentAuthorizationStatus>>>();
        public IObservable<Tuple<PassKit.PKPaymentAuthorizationViewController, PassKit.PKPayment, System.Action<PassKit.PKPaymentAuthorizationStatus>>> DidAuthorizePaymentObs { get { return _DidAuthorizePayment; } }
        public override void DidAuthorizePayment(PassKit.PKPaymentAuthorizationViewController controller, PassKit.PKPayment payment, System.Action<PassKit.PKPaymentAuthorizationStatus> completion)
        {
            _DidAuthorizePayment.OnNext(Tuple.Create(controller, payment, completion));
        }

        readonly SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationViewController, PassKit.PKPaymentMethod, System.Action<PassKit.PKPaymentSummaryItem[]>>> _DidSelectPaymentMethod = new SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationViewController, PassKit.PKPaymentMethod, System.Action<PassKit.PKPaymentSummaryItem[]>>>();
        public IObservable<Tuple<PassKit.PKPaymentAuthorizationViewController, PassKit.PKPaymentMethod, System.Action<PassKit.PKPaymentSummaryItem[]>>> DidSelectPaymentMethodObs { get { return _DidSelectPaymentMethod; } }
        public override void DidSelectPaymentMethod(PassKit.PKPaymentAuthorizationViewController controller, PassKit.PKPaymentMethod paymentMethod, System.Action<PassKit.PKPaymentSummaryItem[]> completion)
        {
            _DidSelectPaymentMethod.OnNext(Tuple.Create(controller, paymentMethod, completion));
        }

        readonly SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationViewController, AddressBook.ABRecord, PassKit.PKPaymentShippingAddressSelected>> _DidSelectShippingAddress = new SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationViewController, AddressBook.ABRecord, PassKit.PKPaymentShippingAddressSelected>>();
        public IObservable<Tuple<PassKit.PKPaymentAuthorizationViewController, AddressBook.ABRecord, PassKit.PKPaymentShippingAddressSelected>> DidSelectShippingAddressObs { get { return _DidSelectShippingAddress; } }
        public override void DidSelectShippingAddress(PassKit.PKPaymentAuthorizationViewController controller, AddressBook.ABRecord address, PassKit.PKPaymentShippingAddressSelected completion)
        {
            _DidSelectShippingAddress.OnNext(Tuple.Create(controller, address, completion));
        }

        readonly SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationViewController, PassKit.PKContact, PassKit.PKPaymentShippingAddressSelected>> _DidSelectShippingContact = new SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationViewController, PassKit.PKContact, PassKit.PKPaymentShippingAddressSelected>>();
        public IObservable<Tuple<PassKit.PKPaymentAuthorizationViewController, PassKit.PKContact, PassKit.PKPaymentShippingAddressSelected>> DidSelectShippingContactObs { get { return _DidSelectShippingContact; } }
        public override void DidSelectShippingContact(PassKit.PKPaymentAuthorizationViewController controller, PassKit.PKContact contact, PassKit.PKPaymentShippingAddressSelected completion)
        {
            _DidSelectShippingContact.OnNext(Tuple.Create(controller, contact, completion));
        }

        readonly SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationViewController, PassKit.PKShippingMethod, PassKit.PKPaymentShippingMethodSelected>> _DidSelectShippingMethod = new SingleAwaitSubject<Tuple<PassKit.PKPaymentAuthorizationViewController, PassKit.PKShippingMethod, PassKit.PKPaymentShippingMethodSelected>>();
        public IObservable<Tuple<PassKit.PKPaymentAuthorizationViewController, PassKit.PKShippingMethod, PassKit.PKPaymentShippingMethodSelected>> DidSelectShippingMethodObs { get { return _DidSelectShippingMethod; } }
        public override void DidSelectShippingMethod(PassKit.PKPaymentAuthorizationViewController controller, PassKit.PKShippingMethod shippingMethod, PassKit.PKPaymentShippingMethodSelected completion)
        {
            _DidSelectShippingMethod.OnNext(Tuple.Create(controller, shippingMethod, completion));
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
namespace UserNotifications.Rx
{
    public  partial class UNUserNotificationCenterDelegateRx : UNUserNotificationCenterDelegate
    {
        readonly SingleAwaitSubject<Tuple<UserNotifications.UNUserNotificationCenter, UserNotifications.UNNotificationResponse, System.Action>> _DidReceiveNotificationResponse = new SingleAwaitSubject<Tuple<UserNotifications.UNUserNotificationCenter, UserNotifications.UNNotificationResponse, System.Action>>();
        public IObservable<Tuple<UserNotifications.UNUserNotificationCenter, UserNotifications.UNNotificationResponse, System.Action>> DidReceiveNotificationResponseObs { get { return _DidReceiveNotificationResponse; } }
        public override void DidReceiveNotificationResponse(UserNotifications.UNUserNotificationCenter center, UserNotifications.UNNotificationResponse response, System.Action completionHandler)
        {
            _DidReceiveNotificationResponse.OnNext(Tuple.Create(center, response, completionHandler));
        }

        readonly SingleAwaitSubject<Tuple<UserNotifications.UNUserNotificationCenter, UserNotifications.UNNotification, System.Action<UserNotifications.UNNotificationPresentationOptions>>> _WillPresentNotification = new SingleAwaitSubject<Tuple<UserNotifications.UNUserNotificationCenter, UserNotifications.UNNotification, System.Action<UserNotifications.UNNotificationPresentationOptions>>>();
        public IObservable<Tuple<UserNotifications.UNUserNotificationCenter, UserNotifications.UNNotification, System.Action<UserNotifications.UNNotificationPresentationOptions>>> WillPresentNotificationObs { get { return _WillPresentNotification; } }
        public override void WillPresentNotification(UserNotifications.UNUserNotificationCenter center, UserNotifications.UNNotification notification, System.Action<UserNotifications.UNNotificationPresentationOptions> completionHandler)
        {
            _WillPresentNotification.OnNext(Tuple.Create(center, notification, completionHandler));
        }

    }
}
namespace WatchConnectivity.Rx
{
    public  partial class WCSessionDelegateRx : WCSessionDelegate
    {
        readonly SingleAwaitSubject<WatchConnectivity.WCSession> _DidBecomeInactive = new SingleAwaitSubject<WatchConnectivity.WCSession>();
        public IObservable<WatchConnectivity.WCSession> DidBecomeInactiveObs { get { return _DidBecomeInactive; } }
        public override void DidBecomeInactive(WatchConnectivity.WCSession session)
        {
            _DidBecomeInactive.OnNext(session);
        }

        readonly SingleAwaitSubject<WatchConnectivity.WCSession> _DidDeactivate = new SingleAwaitSubject<WatchConnectivity.WCSession>();
        public IObservable<WatchConnectivity.WCSession> DidDeactivateObs { get { return _DidDeactivate; } }
        public override void DidDeactivate(WatchConnectivity.WCSession session)
        {
            _DidDeactivate.OnNext(session);
        }

        readonly SingleAwaitSubject<WatchConnectivity.WCSession> _SessionReachabilityDidChange = new SingleAwaitSubject<WatchConnectivity.WCSession>();
        public IObservable<WatchConnectivity.WCSession> SessionReachabilityDidChangeObs { get { return _SessionReachabilityDidChange; } }
        public override void SessionReachabilityDidChange(WatchConnectivity.WCSession session)
        {
            _SessionReachabilityDidChange.OnNext(session);
        }

        readonly SingleAwaitSubject<WatchConnectivity.WCSession> _SessionWatchStateDidChange = new SingleAwaitSubject<WatchConnectivity.WCSession>();
        public IObservable<WatchConnectivity.WCSession> SessionWatchStateDidChangeObs { get { return _SessionWatchStateDidChange; } }
        public override void SessionWatchStateDidChange(WatchConnectivity.WCSession session)
        {
            _SessionWatchStateDidChange.OnNext(session);
        }

        readonly SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, WatchConnectivity.WCSessionActivationState, Foundation.NSError>> _ActivationDidComplete = new SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, WatchConnectivity.WCSessionActivationState, Foundation.NSError>>();
        public IObservable<Tuple<WatchConnectivity.WCSession, WatchConnectivity.WCSessionActivationState, Foundation.NSError>> ActivationDidCompleteObs { get { return _ActivationDidComplete; } }
        public override void ActivationDidComplete(WatchConnectivity.WCSession session, WatchConnectivity.WCSessionActivationState activationState, Foundation.NSError error)
        {
            _ActivationDidComplete.OnNext(Tuple.Create(session, activationState, error));
        }

        readonly SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, WatchConnectivity.WCSessionFileTransfer, Foundation.NSError>> _DidFinishFileTransfer = new SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, WatchConnectivity.WCSessionFileTransfer, Foundation.NSError>>();
        public IObservable<Tuple<WatchConnectivity.WCSession, WatchConnectivity.WCSessionFileTransfer, Foundation.NSError>> DidFinishFileTransferObs { get { return _DidFinishFileTransfer; } }
        public override void DidFinishFileTransfer(WatchConnectivity.WCSession session, WatchConnectivity.WCSessionFileTransfer fileTransfer, Foundation.NSError error)
        {
            _DidFinishFileTransfer.OnNext(Tuple.Create(session, fileTransfer, error));
        }

        readonly SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, WatchConnectivity.WCSessionUserInfoTransfer, Foundation.NSError>> _DidFinishUserInfoTransfer = new SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, WatchConnectivity.WCSessionUserInfoTransfer, Foundation.NSError>>();
        public IObservable<Tuple<WatchConnectivity.WCSession, WatchConnectivity.WCSessionUserInfoTransfer, Foundation.NSError>> DidFinishUserInfoTransferObs { get { return _DidFinishUserInfoTransfer; } }
        public override void DidFinishUserInfoTransfer(WatchConnectivity.WCSession session, WatchConnectivity.WCSessionUserInfoTransfer userInfoTransfer, Foundation.NSError error)
        {
            _DidFinishUserInfoTransfer.OnNext(Tuple.Create(session, userInfoTransfer, error));
        }

        readonly SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, Foundation.NSDictionary<Foundation.NSString,Foundation.NSObject>>> _DidReceiveApplicationContext = new SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, Foundation.NSDictionary<Foundation.NSString,Foundation.NSObject>>>();
        public IObservable<Tuple<WatchConnectivity.WCSession, Foundation.NSDictionary<Foundation.NSString,Foundation.NSObject>>> DidReceiveApplicationContextObs { get { return _DidReceiveApplicationContext; } }
        public override void DidReceiveApplicationContext(WatchConnectivity.WCSession session, Foundation.NSDictionary<Foundation.NSString,Foundation.NSObject> applicationContext)
        {
            _DidReceiveApplicationContext.OnNext(Tuple.Create(session, applicationContext));
        }

        readonly SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, WatchConnectivity.WCSessionFile>> _DidReceiveFile = new SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, WatchConnectivity.WCSessionFile>>();
        public IObservable<Tuple<WatchConnectivity.WCSession, WatchConnectivity.WCSessionFile>> DidReceiveFileObs { get { return _DidReceiveFile; } }
        public override void DidReceiveFile(WatchConnectivity.WCSession session, WatchConnectivity.WCSessionFile file)
        {
            _DidReceiveFile.OnNext(Tuple.Create(session, file));
        }

        readonly SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, Foundation.NSDictionary<Foundation.NSString,Foundation.NSObject>, WatchConnectivity.WCSessionReplyHandler>> _DidReceiveMessage = new SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, Foundation.NSDictionary<Foundation.NSString,Foundation.NSObject>, WatchConnectivity.WCSessionReplyHandler>>();
        public IObservable<Tuple<WatchConnectivity.WCSession, Foundation.NSDictionary<Foundation.NSString,Foundation.NSObject>, WatchConnectivity.WCSessionReplyHandler>> DidReceiveMessageObs { get { return _DidReceiveMessage; } }
        public override void DidReceiveMessage(WatchConnectivity.WCSession session, Foundation.NSDictionary<Foundation.NSString,Foundation.NSObject> message, WatchConnectivity.WCSessionReplyHandler replyHandler)
        {
            _DidReceiveMessage.OnNext(Tuple.Create(session, message, replyHandler));
        }

        readonly SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, Foundation.NSData, WatchConnectivity.WCSessionReplyDataHandler>> _DidReceiveMessageData = new SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, Foundation.NSData, WatchConnectivity.WCSessionReplyDataHandler>>();
        public IObservable<Tuple<WatchConnectivity.WCSession, Foundation.NSData, WatchConnectivity.WCSessionReplyDataHandler>> DidReceiveMessageDataObs { get { return _DidReceiveMessageData; } }
        public override void DidReceiveMessageData(WatchConnectivity.WCSession session, Foundation.NSData messageData, WatchConnectivity.WCSessionReplyDataHandler replyHandler)
        {
            _DidReceiveMessageData.OnNext(Tuple.Create(session, messageData, replyHandler));
        }

        readonly SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, Foundation.NSDictionary<Foundation.NSString,Foundation.NSObject>>> _DidReceiveUserInfo = new SingleAwaitSubject<Tuple<WatchConnectivity.WCSession, Foundation.NSDictionary<Foundation.NSString,Foundation.NSObject>>>();
        public IObservable<Tuple<WatchConnectivity.WCSession, Foundation.NSDictionary<Foundation.NSString,Foundation.NSObject>>> DidReceiveUserInfoObs { get { return _DidReceiveUserInfo; } }
        public override void DidReceiveUserInfo(WatchConnectivity.WCSession session, Foundation.NSDictionary<Foundation.NSString,Foundation.NSObject> userInfo)
        {
            _DidReceiveUserInfo.OnNext(Tuple.Create(session, userInfo));
        }

    }
}
namespace VideoSubscriberAccount.Rx
{
    public abstract partial class VSAccountManagerDelegateRx : VSAccountManagerDelegate
    {
        readonly SingleAwaitSubject<Tuple<VideoSubscriberAccount.VSAccountManager, UIKit.UIViewController>> _DismissViewController = new SingleAwaitSubject<Tuple<VideoSubscriberAccount.VSAccountManager, UIKit.UIViewController>>();
        public IObservable<Tuple<VideoSubscriberAccount.VSAccountManager, UIKit.UIViewController>> DismissViewControllerObs { get { return _DismissViewController; } }
        public override void DismissViewController(VideoSubscriberAccount.VSAccountManager accountManager, UIKit.UIViewController viewController)
        {
            _DismissViewController.OnNext(Tuple.Create(accountManager, viewController));
        }

        readonly SingleAwaitSubject<Tuple<VideoSubscriberAccount.VSAccountManager, UIKit.UIViewController>> _PresentViewController = new SingleAwaitSubject<Tuple<VideoSubscriberAccount.VSAccountManager, UIKit.UIViewController>>();
        public IObservable<Tuple<VideoSubscriberAccount.VSAccountManager, UIKit.UIViewController>> PresentViewControllerObs { get { return _PresentViewController; } }
        public override void PresentViewController(VideoSubscriberAccount.VSAccountManager accountManager, UIKit.UIViewController viewController)
        {
            _PresentViewController.OnNext(Tuple.Create(accountManager, viewController));
        }

    }
}
namespace WebKit.Rx
{
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

        readonly SingleAwaitSubject<Tuple<WebKit.WKWebView, UIKit.UIViewController>> _CommitPreviewingViewController = new SingleAwaitSubject<Tuple<WebKit.WKWebView, UIKit.UIViewController>>();
        public IObservable<Tuple<WebKit.WKWebView, UIKit.UIViewController>> CommitPreviewingViewControllerObs { get { return _CommitPreviewingViewController; } }
        public override void CommitPreviewingViewController(WebKit.WKWebView webView, UIKit.UIViewController previewingViewController)
        {
            _CommitPreviewingViewController.OnNext(Tuple.Create(webView, previewingViewController));
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
namespace iAd.Rx
{
    public  partial class ADBannerViewDelegateRx : ADBannerViewDelegate
    {
        readonly SingleAwaitSubject<iAd.ADBannerView> _ActionFinished = new SingleAwaitSubject<iAd.ADBannerView>();
        public IObservable<iAd.ADBannerView> ActionFinishedObs { get { return _ActionFinished; } }
        public override void ActionFinished(iAd.ADBannerView banner)
        {
            _ActionFinished.OnNext(banner);
        }

        readonly SingleAwaitSubject<iAd.ADBannerView> _AdLoaded = new SingleAwaitSubject<iAd.ADBannerView>();
        public IObservable<iAd.ADBannerView> AdLoadedObs { get { return _AdLoaded; } }
        public override void AdLoaded(iAd.ADBannerView banner)
        {
            _AdLoaded.OnNext(banner);
        }

        readonly SingleAwaitSubject<iAd.ADBannerView> _WillLoad = new SingleAwaitSubject<iAd.ADBannerView>();
        public IObservable<iAd.ADBannerView> WillLoadObs { get { return _WillLoad; } }
        public override void WillLoad(iAd.ADBannerView bannerView)
        {
            _WillLoad.OnNext(bannerView);
        }

        readonly SingleAwaitSubject<Tuple<iAd.ADBannerView, Foundation.NSError>> _FailedToReceiveAd = new SingleAwaitSubject<Tuple<iAd.ADBannerView, Foundation.NSError>>();
        public IObservable<Tuple<iAd.ADBannerView, Foundation.NSError>> FailedToReceiveAdObs { get { return _FailedToReceiveAd; } }
        public override void FailedToReceiveAd(iAd.ADBannerView banner, Foundation.NSError error)
        {
            _FailedToReceiveAd.OnNext(Tuple.Create(banner, error));
        }

    }
    public abstract partial class ADInterstitialAdDelegateRx : ADInterstitialAdDelegate
    {
        readonly SingleAwaitSubject<iAd.ADInterstitialAd> _ActionFinished = new SingleAwaitSubject<iAd.ADInterstitialAd>();
        public IObservable<iAd.ADInterstitialAd> ActionFinishedObs { get { return _ActionFinished; } }
        public override void ActionFinished(iAd.ADInterstitialAd interstitialAd)
        {
            _ActionFinished.OnNext(interstitialAd);
        }

        readonly SingleAwaitSubject<iAd.ADInterstitialAd> _AdLoaded = new SingleAwaitSubject<iAd.ADInterstitialAd>();
        public IObservable<iAd.ADInterstitialAd> AdLoadedObs { get { return _AdLoaded; } }
        public override void AdLoaded(iAd.ADInterstitialAd interstitialAd)
        {
            _AdLoaded.OnNext(interstitialAd);
        }

        readonly SingleAwaitSubject<iAd.ADInterstitialAd> _AdUnloaded = new SingleAwaitSubject<iAd.ADInterstitialAd>();
        public IObservable<iAd.ADInterstitialAd> AdUnloadedObs { get { return _AdUnloaded; } }
        public override void AdUnloaded(iAd.ADInterstitialAd interstitialAd)
        {
            _AdUnloaded.OnNext(interstitialAd);
        }

        readonly SingleAwaitSubject<iAd.ADInterstitialAd> _WillLoad = new SingleAwaitSubject<iAd.ADInterstitialAd>();
        public IObservable<iAd.ADInterstitialAd> WillLoadObs { get { return _WillLoad; } }
        public override void WillLoad(iAd.ADInterstitialAd interstitialAd)
        {
            _WillLoad.OnNext(interstitialAd);
        }

        readonly SingleAwaitSubject<Tuple<iAd.ADInterstitialAd, Foundation.NSError>> _FailedToReceiveAd = new SingleAwaitSubject<Tuple<iAd.ADInterstitialAd, Foundation.NSError>>();
        public IObservable<Tuple<iAd.ADInterstitialAd, Foundation.NSError>> FailedToReceiveAdObs { get { return _FailedToReceiveAd; } }
        public override void FailedToReceiveAd(iAd.ADInterstitialAd interstitialAd, Foundation.NSError error)
        {
            _FailedToReceiveAd.OnNext(Tuple.Create(interstitialAd, error));
        }

    }
}

#pragma warning restore 1591,0618,0105,0672

#pragma warning disable 1591,0618,0105,0672

using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using ReactiveUI.Events;

using System.ComponentModel;
using System.IO.Packaging;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Microsoft.Win32;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Controls.Primitives;
using System.Windows.Annotations;
using System.Windows.Annotations.Storage;
using System.Windows.Documents.Serialization;
using System.Windows.Markup;
using System.Windows.Markup.Localizer;
using System.Windows.Shell;

namespace System.ComponentModel
{
    public static class EventsMixin
    {
        public static ICollectionViewEvents Events(this ICollectionView This)
        {
            return new ICollectionViewEvents(This);
        }
    }

    public class ICollectionViewEvents
    {
        ICollectionView This;

        public ICollectionViewEvents(ICollectionView This)
        {
            this.This = This;
        }

        public IObservable<System.ComponentModel.CurrentChangingEventArgs> CurrentChanging {
            get { return Observable.FromEventPattern<System.ComponentModel.CurrentChangingEventHandler, System.ComponentModel.CurrentChangingEventArgs>(x => This.CurrentChanging += x, x => This.CurrentChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> CurrentChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CurrentChanged += x, x => This.CurrentChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.IO.Packaging
{
    public static class EventsMixin
    {
        public static PackageDigitalSignatureManagerEvents Events(this PackageDigitalSignatureManager This)
        {
            return new PackageDigitalSignatureManagerEvents(This);
        }
    }

    public class PackageDigitalSignatureManagerEvents
    {
        PackageDigitalSignatureManager This;

        public PackageDigitalSignatureManagerEvents(PackageDigitalSignatureManager This)
        {
            this.This = This;
        }

        public IObservable<System.IO.Packaging.SignatureVerificationEventArgs> InvalidSignatureEvent {
            get { return Observable.FromEventPattern<System.IO.Packaging.InvalidSignatureEventHandler, System.IO.Packaging.SignatureVerificationEventArgs>(x => This.InvalidSignatureEvent += x, x => This.InvalidSignatureEvent -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows
{
    public static class EventsMixin
    {
        public static FreezableEvents Events(this Freezable This)
        {
            return new FreezableEvents(This);
        }
        public static IInputElementEvents Events(this IInputElement This)
        {
            return new IInputElementEvents(This);
        }
        public static ContentElementEvents Events(this ContentElement This)
        {
            return new ContentElementEvents(This);
        }
        public static UIElementEvents Events(this UIElement This)
        {
            return new UIElementEvents(This);
        }
        public static UIElement3DEvents Events(this UIElement3D This)
        {
            return new UIElement3DEvents(This);
        }
        public static PresentationSourceEvents Events(this PresentationSource This)
        {
            return new PresentationSourceEvents(This);
        }
        public static FrameworkElementEvents Events(this FrameworkElement This)
        {
            return new FrameworkElementEvents(This);
        }
        public static WindowEvents Events(this Window This)
        {
            return new WindowEvents(This);
        }
        public static ApplicationEvents Events(this Application This)
        {
            return new ApplicationEvents(This);
        }
        public static FrameworkContentElementEvents Events(this FrameworkContentElement This)
        {
            return new FrameworkContentElementEvents(This);
        }
        public static VisualStateGroupEvents Events(this VisualStateGroup This)
        {
            return new VisualStateGroupEvents(This);
        }
    }

    public class FreezableEvents
    {
        Freezable This;

        public FreezableEvents(Freezable This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Changed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Changed += x, x => This.Changed -= x).Select(x => x.EventArgs); }
        }

    }
    public class IInputElementEvents
    {
        IInputElement This;

        public IInputElementEvents(IInputElement This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseLeftButtonDown += x, x => This.PreviewMouseLeftButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseLeftButtonDown += x, x => This.MouseLeftButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseLeftButtonUp += x, x => This.PreviewMouseLeftButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseLeftButtonUp += x, x => This.MouseLeftButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseRightButtonDown += x, x => This.PreviewMouseRightButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseRightButtonDown += x, x => This.MouseRightButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseRightButtonUp += x, x => This.PreviewMouseRightButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseRightButtonUp += x, x => This.MouseRightButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> PreviewMouseMove {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.PreviewMouseMove += x, x => This.PreviewMouseMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseMove {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseMove += x, x => This.MouseMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseWheelEventArgs> PreviewMouseWheel {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(x => This.PreviewMouseWheel += x, x => This.PreviewMouseWheel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseWheelEventArgs> MouseWheel {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(x => This.MouseWheel += x, x => This.MouseWheel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseEnter {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseEnter += x, x => This.MouseEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseLeave {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseLeave += x, x => This.MouseLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> GotMouseCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.GotMouseCapture += x, x => This.GotMouseCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> LostMouseCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.LostMouseCapture += x, x => This.LostMouseCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusDownEventArgs> PreviewStylusDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(x => This.PreviewStylusDown += x, x => This.PreviewStylusDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusDownEventArgs> StylusDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(x => This.StylusDown += x, x => This.StylusDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusUp += x, x => This.PreviewStylusUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusUp += x, x => This.StylusUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusMove += x, x => This.PreviewStylusMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusMove += x, x => This.StylusMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInAirMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusInAirMove += x, x => This.PreviewStylusInAirMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusInAirMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusInAirMove += x, x => This.StylusInAirMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusEnter {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusEnter += x, x => This.StylusEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusLeave {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusLeave += x, x => This.StylusLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusInRange += x, x => This.PreviewStylusInRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusInRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusInRange += x, x => This.StylusInRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusOutOfRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusOutOfRange += x, x => This.PreviewStylusOutOfRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusOutOfRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusOutOfRange += x, x => This.StylusOutOfRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusSystemGestureEventArgs> PreviewStylusSystemGesture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(x => This.PreviewStylusSystemGesture += x, x => This.PreviewStylusSystemGesture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusSystemGestureEventArgs> StylusSystemGesture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(x => This.StylusSystemGesture += x, x => This.StylusSystemGesture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.StylusButtonDown += x, x => This.StylusButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.PreviewStylusButtonDown += x, x => This.PreviewStylusButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.PreviewStylusButtonUp += x, x => This.PreviewStylusButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.StylusButtonUp += x, x => This.StylusButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> GotStylusCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.GotStylusCapture += x, x => This.GotStylusCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> LostStylusCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.LostStylusCapture += x, x => This.LostStylusCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyDown {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.PreviewKeyDown += x, x => This.PreviewKeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyUp {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.PreviewKeyUp += x, x => This.PreviewKeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewGotKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.PreviewGotKeyboardFocus += x, x => This.PreviewGotKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> GotKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.GotKeyboardFocus += x, x => This.GotKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewLostKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.PreviewLostKeyboardFocus += x, x => This.PreviewLostKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> LostKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.LostKeyboardFocus += x, x => This.LostKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TextCompositionEventArgs> PreviewTextInput {
            get { return Observable.FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(x => This.PreviewTextInput += x, x => This.PreviewTextInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TextCompositionEventArgs> TextInput {
            get { return Observable.FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(x => This.TextInput += x, x => This.TextInput -= x).Select(x => x.EventArgs); }
        }

    }
    public class ContentElementEvents
    {
        ContentElement This;

        public ContentElementEvents(ContentElement This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> GotFocus {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.GotFocus += x, x => This.GotFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> LostFocus {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.LostFocus += x, x => This.LostFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsEnabledChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsEnabledChanged += x, x => This.IsEnabledChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> FocusableChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.FocusableChanged += x, x => This.FocusableChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseDown += x, x => This.PreviewMouseDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseDown += x, x => This.MouseDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseUp += x, x => This.PreviewMouseUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseUp += x, x => This.MouseUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseLeftButtonDown += x, x => This.PreviewMouseLeftButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseLeftButtonDown += x, x => This.MouseLeftButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseLeftButtonUp += x, x => This.PreviewMouseLeftButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseLeftButtonUp += x, x => This.MouseLeftButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseRightButtonDown += x, x => This.PreviewMouseRightButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseRightButtonDown += x, x => This.MouseRightButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseRightButtonUp += x, x => This.PreviewMouseRightButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseRightButtonUp += x, x => This.MouseRightButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> PreviewMouseMove {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.PreviewMouseMove += x, x => This.PreviewMouseMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseMove {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseMove += x, x => This.MouseMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseWheelEventArgs> PreviewMouseWheel {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(x => This.PreviewMouseWheel += x, x => This.PreviewMouseWheel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseWheelEventArgs> MouseWheel {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(x => This.MouseWheel += x, x => This.MouseWheel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseEnter {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseEnter += x, x => This.MouseEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseLeave {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseLeave += x, x => This.MouseLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> GotMouseCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.GotMouseCapture += x, x => This.GotMouseCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> LostMouseCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.LostMouseCapture += x, x => This.LostMouseCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.QueryCursorEventArgs> QueryCursor {
            get { return Observable.FromEventPattern<System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs>(x => This.QueryCursor += x, x => This.QueryCursor -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusDownEventArgs> PreviewStylusDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(x => This.PreviewStylusDown += x, x => This.PreviewStylusDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusDownEventArgs> StylusDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(x => This.StylusDown += x, x => This.StylusDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusUp += x, x => This.PreviewStylusUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusUp += x, x => This.StylusUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusMove += x, x => This.PreviewStylusMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusMove += x, x => This.StylusMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInAirMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusInAirMove += x, x => This.PreviewStylusInAirMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusInAirMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusInAirMove += x, x => This.StylusInAirMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusEnter {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusEnter += x, x => This.StylusEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusLeave {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusLeave += x, x => This.StylusLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusInRange += x, x => This.PreviewStylusInRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusInRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusInRange += x, x => This.StylusInRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusOutOfRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusOutOfRange += x, x => This.PreviewStylusOutOfRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusOutOfRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusOutOfRange += x, x => This.StylusOutOfRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusSystemGestureEventArgs> PreviewStylusSystemGesture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(x => This.PreviewStylusSystemGesture += x, x => This.PreviewStylusSystemGesture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusSystemGestureEventArgs> StylusSystemGesture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(x => This.StylusSystemGesture += x, x => This.StylusSystemGesture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> GotStylusCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.GotStylusCapture += x, x => This.GotStylusCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> LostStylusCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.LostStylusCapture += x, x => This.LostStylusCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.StylusButtonDown += x, x => This.StylusButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.StylusButtonUp += x, x => This.StylusButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.PreviewStylusButtonDown += x, x => This.PreviewStylusButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.PreviewStylusButtonUp += x, x => This.PreviewStylusButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyDown {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.PreviewKeyDown += x, x => This.PreviewKeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyUp {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.PreviewKeyUp += x, x => This.PreviewKeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewGotKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.PreviewGotKeyboardFocus += x, x => This.PreviewGotKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> GotKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.GotKeyboardFocus += x, x => This.GotKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewLostKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.PreviewLostKeyboardFocus += x, x => This.PreviewLostKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> LostKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.LostKeyboardFocus += x, x => This.LostKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TextCompositionEventArgs> PreviewTextInput {
            get { return Observable.FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(x => This.PreviewTextInput += x, x => This.PreviewTextInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TextCompositionEventArgs> TextInput {
            get { return Observable.FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(x => This.TextInput += x, x => This.TextInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.QueryContinueDragEventArgs> PreviewQueryContinueDrag {
            get { return Observable.FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(x => This.PreviewQueryContinueDrag += x, x => This.PreviewQueryContinueDrag -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.QueryContinueDragEventArgs> QueryContinueDrag {
            get { return Observable.FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(x => This.QueryContinueDrag += x, x => This.QueryContinueDrag -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.GiveFeedbackEventArgs> PreviewGiveFeedback {
            get { return Observable.FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(x => This.PreviewGiveFeedback += x, x => This.PreviewGiveFeedback -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.GiveFeedbackEventArgs> GiveFeedback {
            get { return Observable.FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(x => This.GiveFeedback += x, x => This.GiveFeedback -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> PreviewDragEnter {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.PreviewDragEnter += x, x => This.PreviewDragEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> DragEnter {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.DragEnter += x, x => This.DragEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> PreviewDragOver {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.PreviewDragOver += x, x => This.PreviewDragOver -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> DragOver {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.DragOver += x, x => This.DragOver -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> PreviewDragLeave {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.PreviewDragLeave += x, x => This.PreviewDragLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> DragLeave {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.DragLeave += x, x => This.DragLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> PreviewDrop {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.PreviewDrop += x, x => This.PreviewDrop -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> Drop {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.Drop += x, x => This.Drop -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchDown {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.PreviewTouchDown += x, x => This.PreviewTouchDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchDown {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchDown += x, x => This.TouchDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchMove {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.PreviewTouchMove += x, x => This.PreviewTouchMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchMove {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchMove += x, x => This.TouchMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchUp {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.PreviewTouchUp += x, x => This.PreviewTouchUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchUp {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchUp += x, x => This.TouchUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> GotTouchCapture {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.GotTouchCapture += x, x => This.GotTouchCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> LostTouchCapture {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.LostTouchCapture += x, x => This.LostTouchCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchEnter {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchEnter += x, x => This.TouchEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchLeave {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchLeave += x, x => This.TouchLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseDirectlyOverChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsMouseDirectlyOverChanged += x, x => This.IsMouseDirectlyOverChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsKeyboardFocusWithinChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsKeyboardFocusWithinChanged += x, x => This.IsKeyboardFocusWithinChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseCapturedChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsMouseCapturedChanged += x, x => This.IsMouseCapturedChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseCaptureWithinChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsMouseCaptureWithinChanged += x, x => This.IsMouseCaptureWithinChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusDirectlyOverChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsStylusDirectlyOverChanged += x, x => This.IsStylusDirectlyOverChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusCapturedChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsStylusCapturedChanged += x, x => This.IsStylusCapturedChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusCaptureWithinChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsStylusCaptureWithinChanged += x, x => This.IsStylusCaptureWithinChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsKeyboardFocusedChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsKeyboardFocusedChanged += x, x => This.IsKeyboardFocusedChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIElementEvents
    {
        UIElement This;

        public UIElementEvents(UIElement This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseDown += x, x => This.PreviewMouseDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseDown += x, x => This.MouseDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseUp += x, x => This.PreviewMouseUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseUp += x, x => This.MouseUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseLeftButtonDown += x, x => This.PreviewMouseLeftButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseLeftButtonDown += x, x => This.MouseLeftButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseLeftButtonUp += x, x => This.PreviewMouseLeftButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseLeftButtonUp += x, x => This.MouseLeftButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseRightButtonDown += x, x => This.PreviewMouseRightButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseRightButtonDown += x, x => This.MouseRightButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseRightButtonUp += x, x => This.PreviewMouseRightButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseRightButtonUp += x, x => This.MouseRightButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> PreviewMouseMove {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.PreviewMouseMove += x, x => This.PreviewMouseMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseMove {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseMove += x, x => This.MouseMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseWheelEventArgs> PreviewMouseWheel {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(x => This.PreviewMouseWheel += x, x => This.PreviewMouseWheel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseWheelEventArgs> MouseWheel {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(x => This.MouseWheel += x, x => This.MouseWheel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseEnter {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseEnter += x, x => This.MouseEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseLeave {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseLeave += x, x => This.MouseLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> GotMouseCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.GotMouseCapture += x, x => This.GotMouseCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> LostMouseCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.LostMouseCapture += x, x => This.LostMouseCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.QueryCursorEventArgs> QueryCursor {
            get { return Observable.FromEventPattern<System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs>(x => This.QueryCursor += x, x => This.QueryCursor -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusDownEventArgs> PreviewStylusDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(x => This.PreviewStylusDown += x, x => This.PreviewStylusDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusDownEventArgs> StylusDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(x => This.StylusDown += x, x => This.StylusDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusUp += x, x => This.PreviewStylusUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusUp += x, x => This.StylusUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusMove += x, x => This.PreviewStylusMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusMove += x, x => This.StylusMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInAirMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusInAirMove += x, x => This.PreviewStylusInAirMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusInAirMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusInAirMove += x, x => This.StylusInAirMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusEnter {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusEnter += x, x => This.StylusEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusLeave {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusLeave += x, x => This.StylusLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusInRange += x, x => This.PreviewStylusInRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusInRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusInRange += x, x => This.StylusInRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusOutOfRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusOutOfRange += x, x => This.PreviewStylusOutOfRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusOutOfRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusOutOfRange += x, x => This.StylusOutOfRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusSystemGestureEventArgs> PreviewStylusSystemGesture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(x => This.PreviewStylusSystemGesture += x, x => This.PreviewStylusSystemGesture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusSystemGestureEventArgs> StylusSystemGesture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(x => This.StylusSystemGesture += x, x => This.StylusSystemGesture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> GotStylusCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.GotStylusCapture += x, x => This.GotStylusCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> LostStylusCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.LostStylusCapture += x, x => This.LostStylusCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.StylusButtonDown += x, x => This.StylusButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.StylusButtonUp += x, x => This.StylusButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.PreviewStylusButtonDown += x, x => This.PreviewStylusButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.PreviewStylusButtonUp += x, x => This.PreviewStylusButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyDown {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.PreviewKeyDown += x, x => This.PreviewKeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyUp {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.PreviewKeyUp += x, x => This.PreviewKeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewGotKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.PreviewGotKeyboardFocus += x, x => This.PreviewGotKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> GotKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.GotKeyboardFocus += x, x => This.GotKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewLostKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.PreviewLostKeyboardFocus += x, x => This.PreviewLostKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> LostKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.LostKeyboardFocus += x, x => This.LostKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TextCompositionEventArgs> PreviewTextInput {
            get { return Observable.FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(x => This.PreviewTextInput += x, x => This.PreviewTextInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TextCompositionEventArgs> TextInput {
            get { return Observable.FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(x => This.TextInput += x, x => This.TextInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.QueryContinueDragEventArgs> PreviewQueryContinueDrag {
            get { return Observable.FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(x => This.PreviewQueryContinueDrag += x, x => This.PreviewQueryContinueDrag -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.QueryContinueDragEventArgs> QueryContinueDrag {
            get { return Observable.FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(x => This.QueryContinueDrag += x, x => This.QueryContinueDrag -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.GiveFeedbackEventArgs> PreviewGiveFeedback {
            get { return Observable.FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(x => This.PreviewGiveFeedback += x, x => This.PreviewGiveFeedback -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.GiveFeedbackEventArgs> GiveFeedback {
            get { return Observable.FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(x => This.GiveFeedback += x, x => This.GiveFeedback -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> PreviewDragEnter {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.PreviewDragEnter += x, x => This.PreviewDragEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> DragEnter {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.DragEnter += x, x => This.DragEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> PreviewDragOver {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.PreviewDragOver += x, x => This.PreviewDragOver -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> DragOver {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.DragOver += x, x => This.DragOver -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> PreviewDragLeave {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.PreviewDragLeave += x, x => This.PreviewDragLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> DragLeave {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.DragLeave += x, x => This.DragLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> PreviewDrop {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.PreviewDrop += x, x => This.PreviewDrop -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> Drop {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.Drop += x, x => This.Drop -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchDown {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.PreviewTouchDown += x, x => This.PreviewTouchDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchDown {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchDown += x, x => This.TouchDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchMove {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.PreviewTouchMove += x, x => This.PreviewTouchMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchMove {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchMove += x, x => This.TouchMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchUp {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.PreviewTouchUp += x, x => This.PreviewTouchUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchUp {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchUp += x, x => This.TouchUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> GotTouchCapture {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.GotTouchCapture += x, x => This.GotTouchCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> LostTouchCapture {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.LostTouchCapture += x, x => This.LostTouchCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchEnter {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchEnter += x, x => This.TouchEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchLeave {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchLeave += x, x => This.TouchLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseDirectlyOverChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsMouseDirectlyOverChanged += x, x => This.IsMouseDirectlyOverChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsKeyboardFocusWithinChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsKeyboardFocusWithinChanged += x, x => This.IsKeyboardFocusWithinChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseCapturedChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsMouseCapturedChanged += x, x => This.IsMouseCapturedChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseCaptureWithinChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsMouseCaptureWithinChanged += x, x => This.IsMouseCaptureWithinChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusDirectlyOverChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsStylusDirectlyOverChanged += x, x => This.IsStylusDirectlyOverChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusCapturedChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsStylusCapturedChanged += x, x => This.IsStylusCapturedChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusCaptureWithinChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsStylusCaptureWithinChanged += x, x => This.IsStylusCaptureWithinChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsKeyboardFocusedChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsKeyboardFocusedChanged += x, x => This.IsKeyboardFocusedChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> LayoutUpdated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LayoutUpdated += x, x => This.LayoutUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> GotFocus {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.GotFocus += x, x => This.GotFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> LostFocus {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.LostFocus += x, x => This.LostFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsEnabledChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsEnabledChanged += x, x => This.IsEnabledChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsHitTestVisibleChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsHitTestVisibleChanged += x, x => This.IsHitTestVisibleChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsVisibleChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsVisibleChanged += x, x => This.IsVisibleChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> FocusableChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.FocusableChanged += x, x => This.FocusableChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.ManipulationStartingEventArgs> ManipulationStarting {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.ManipulationStartingEventArgs>, System.Windows.Input.ManipulationStartingEventArgs>(x => This.ManipulationStarting += x, x => This.ManipulationStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.ManipulationStartedEventArgs> ManipulationStarted {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.ManipulationStartedEventArgs>, System.Windows.Input.ManipulationStartedEventArgs>(x => This.ManipulationStarted += x, x => This.ManipulationStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.ManipulationDeltaEventArgs> ManipulationDelta {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.ManipulationDeltaEventArgs>, System.Windows.Input.ManipulationDeltaEventArgs>(x => This.ManipulationDelta += x, x => This.ManipulationDelta -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.ManipulationInertiaStartingEventArgs>, System.Windows.Input.ManipulationInertiaStartingEventArgs>(x => This.ManipulationInertiaStarting += x, x => This.ManipulationInertiaStarting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs> ManipulationBoundaryFeedback {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>, System.Windows.Input.ManipulationBoundaryFeedbackEventArgs>(x => This.ManipulationBoundaryFeedback += x, x => This.ManipulationBoundaryFeedback -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.ManipulationCompletedEventArgs> ManipulationCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.ManipulationCompletedEventArgs>, System.Windows.Input.ManipulationCompletedEventArgs>(x => This.ManipulationCompleted += x, x => This.ManipulationCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class UIElement3DEvents
    {
        UIElement3D This;

        public UIElement3DEvents(UIElement3D This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseDown += x, x => This.PreviewMouseDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseDown += x, x => This.MouseDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseUp += x, x => This.PreviewMouseUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseUp += x, x => This.MouseUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseLeftButtonDown += x, x => This.PreviewMouseLeftButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseLeftButtonDown += x, x => This.MouseLeftButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseLeftButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseLeftButtonUp += x, x => This.PreviewMouseLeftButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseLeftButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseLeftButtonUp += x, x => This.MouseLeftButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseRightButtonDown += x, x => This.PreviewMouseRightButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseRightButtonDown += x, x => This.MouseRightButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseRightButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseRightButtonUp += x, x => This.PreviewMouseRightButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseRightButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseRightButtonUp += x, x => This.MouseRightButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> PreviewMouseMove {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.PreviewMouseMove += x, x => This.PreviewMouseMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseMove {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseMove += x, x => This.MouseMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseWheelEventArgs> PreviewMouseWheel {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(x => This.PreviewMouseWheel += x, x => This.PreviewMouseWheel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseWheelEventArgs> MouseWheel {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseWheelEventHandler, System.Windows.Input.MouseWheelEventArgs>(x => This.MouseWheel += x, x => This.MouseWheel -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseEnter {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseEnter += x, x => This.MouseEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> MouseLeave {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.MouseLeave += x, x => This.MouseLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> GotMouseCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.GotMouseCapture += x, x => This.GotMouseCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseEventArgs> LostMouseCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseEventHandler, System.Windows.Input.MouseEventArgs>(x => This.LostMouseCapture += x, x => This.LostMouseCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.QueryCursorEventArgs> QueryCursor {
            get { return Observable.FromEventPattern<System.Windows.Input.QueryCursorEventHandler, System.Windows.Input.QueryCursorEventArgs>(x => This.QueryCursor += x, x => This.QueryCursor -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusDownEventArgs> PreviewStylusDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(x => This.PreviewStylusDown += x, x => This.PreviewStylusDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusDownEventArgs> StylusDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusDownEventHandler, System.Windows.Input.StylusDownEventArgs>(x => This.StylusDown += x, x => This.StylusDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusUp += x, x => This.PreviewStylusUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusUp += x, x => This.StylusUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusMove += x, x => This.PreviewStylusMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusMove += x, x => This.StylusMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInAirMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusInAirMove += x, x => This.PreviewStylusInAirMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusInAirMove {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusInAirMove += x, x => This.StylusInAirMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusEnter {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusEnter += x, x => This.StylusEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusLeave {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusLeave += x, x => This.StylusLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusInRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusInRange += x, x => This.PreviewStylusInRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusInRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusInRange += x, x => This.StylusInRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> PreviewStylusOutOfRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.PreviewStylusOutOfRange += x, x => This.PreviewStylusOutOfRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> StylusOutOfRange {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.StylusOutOfRange += x, x => This.StylusOutOfRange -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusSystemGestureEventArgs> PreviewStylusSystemGesture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(x => This.PreviewStylusSystemGesture += x, x => This.PreviewStylusSystemGesture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusSystemGestureEventArgs> StylusSystemGesture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusSystemGestureEventHandler, System.Windows.Input.StylusSystemGestureEventArgs>(x => This.StylusSystemGesture += x, x => This.StylusSystemGesture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> GotStylusCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.GotStylusCapture += x, x => This.GotStylusCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusEventArgs> LostStylusCapture {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusEventHandler, System.Windows.Input.StylusEventArgs>(x => This.LostStylusCapture += x, x => This.LostStylusCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.StylusButtonDown += x, x => This.StylusButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> StylusButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.StylusButtonUp += x, x => This.StylusButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonDown {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.PreviewStylusButtonDown += x, x => This.PreviewStylusButtonDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.StylusButtonEventArgs> PreviewStylusButtonUp {
            get { return Observable.FromEventPattern<System.Windows.Input.StylusButtonEventHandler, System.Windows.Input.StylusButtonEventArgs>(x => This.PreviewStylusButtonUp += x, x => This.PreviewStylusButtonUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyDown {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.PreviewKeyDown += x, x => This.PreviewKeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> KeyDown {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.KeyDown += x, x => This.KeyDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> PreviewKeyUp {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.PreviewKeyUp += x, x => This.PreviewKeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyEventArgs> KeyUp {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyEventHandler, System.Windows.Input.KeyEventArgs>(x => This.KeyUp += x, x => This.KeyUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewGotKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.PreviewGotKeyboardFocus += x, x => This.PreviewGotKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> GotKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.GotKeyboardFocus += x, x => This.GotKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> PreviewLostKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.PreviewLostKeyboardFocus += x, x => This.PreviewLostKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.KeyboardFocusChangedEventArgs> LostKeyboardFocus {
            get { return Observable.FromEventPattern<System.Windows.Input.KeyboardFocusChangedEventHandler, System.Windows.Input.KeyboardFocusChangedEventArgs>(x => This.LostKeyboardFocus += x, x => This.LostKeyboardFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TextCompositionEventArgs> PreviewTextInput {
            get { return Observable.FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(x => This.PreviewTextInput += x, x => This.PreviewTextInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TextCompositionEventArgs> TextInput {
            get { return Observable.FromEventPattern<System.Windows.Input.TextCompositionEventHandler, System.Windows.Input.TextCompositionEventArgs>(x => This.TextInput += x, x => This.TextInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.QueryContinueDragEventArgs> PreviewQueryContinueDrag {
            get { return Observable.FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(x => This.PreviewQueryContinueDrag += x, x => This.PreviewQueryContinueDrag -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.QueryContinueDragEventArgs> QueryContinueDrag {
            get { return Observable.FromEventPattern<System.Windows.QueryContinueDragEventHandler, System.Windows.QueryContinueDragEventArgs>(x => This.QueryContinueDrag += x, x => This.QueryContinueDrag -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.GiveFeedbackEventArgs> PreviewGiveFeedback {
            get { return Observable.FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(x => This.PreviewGiveFeedback += x, x => This.PreviewGiveFeedback -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.GiveFeedbackEventArgs> GiveFeedback {
            get { return Observable.FromEventPattern<System.Windows.GiveFeedbackEventHandler, System.Windows.GiveFeedbackEventArgs>(x => This.GiveFeedback += x, x => This.GiveFeedback -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> PreviewDragEnter {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.PreviewDragEnter += x, x => This.PreviewDragEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> DragEnter {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.DragEnter += x, x => This.DragEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> PreviewDragOver {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.PreviewDragOver += x, x => This.PreviewDragOver -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> DragOver {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.DragOver += x, x => This.DragOver -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> PreviewDragLeave {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.PreviewDragLeave += x, x => This.PreviewDragLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> DragLeave {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.DragLeave += x, x => This.DragLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> PreviewDrop {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.PreviewDrop += x, x => This.PreviewDrop -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DragEventArgs> Drop {
            get { return Observable.FromEventPattern<System.Windows.DragEventHandler, System.Windows.DragEventArgs>(x => This.Drop += x, x => This.Drop -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchDown {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.PreviewTouchDown += x, x => This.PreviewTouchDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchDown {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchDown += x, x => This.TouchDown -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchMove {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.PreviewTouchMove += x, x => This.PreviewTouchMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchMove {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchMove += x, x => This.TouchMove -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> PreviewTouchUp {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.PreviewTouchUp += x, x => This.PreviewTouchUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchUp {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchUp += x, x => This.TouchUp -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> GotTouchCapture {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.GotTouchCapture += x, x => This.GotTouchCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> LostTouchCapture {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.LostTouchCapture += x, x => This.LostTouchCapture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchEnter {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchEnter += x, x => This.TouchEnter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.TouchEventArgs> TouchLeave {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Input.TouchEventArgs>, System.Windows.Input.TouchEventArgs>(x => This.TouchLeave += x, x => This.TouchLeave -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseDirectlyOverChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsMouseDirectlyOverChanged += x, x => This.IsMouseDirectlyOverChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsKeyboardFocusWithinChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsKeyboardFocusWithinChanged += x, x => This.IsKeyboardFocusWithinChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseCapturedChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsMouseCapturedChanged += x, x => This.IsMouseCapturedChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsMouseCaptureWithinChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsMouseCaptureWithinChanged += x, x => This.IsMouseCaptureWithinChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusDirectlyOverChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsStylusDirectlyOverChanged += x, x => This.IsStylusDirectlyOverChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusCapturedChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsStylusCapturedChanged += x, x => This.IsStylusCapturedChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsStylusCaptureWithinChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsStylusCaptureWithinChanged += x, x => This.IsStylusCaptureWithinChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsKeyboardFocusedChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsKeyboardFocusedChanged += x, x => This.IsKeyboardFocusedChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> GotFocus {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.GotFocus += x, x => This.GotFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> LostFocus {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.LostFocus += x, x => This.LostFocus -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsEnabledChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsEnabledChanged += x, x => This.IsEnabledChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsHitTestVisibleChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsHitTestVisibleChanged += x, x => This.IsHitTestVisibleChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsVisibleChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsVisibleChanged += x, x => This.IsVisibleChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> FocusableChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.FocusableChanged += x, x => This.FocusableChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class PresentationSourceEvents
    {
        PresentationSource This;

        public PresentationSourceEvents(PresentationSource This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ContentRendered {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ContentRendered += x, x => This.ContentRendered -= x).Select(x => x.EventArgs); }
        }

    }
    public class FrameworkElementEvents
        : System.Windows.UIElementEvents
    {
        FrameworkElement This;

        public FrameworkElementEvents(FrameworkElement This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Data.DataTransferEventArgs> TargetUpdated {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Data.DataTransferEventArgs>, System.Windows.Data.DataTransferEventArgs>(x => This.TargetUpdated += x, x => This.TargetUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Data.DataTransferEventArgs> SourceUpdated {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Data.DataTransferEventArgs>, System.Windows.Data.DataTransferEventArgs>(x => This.SourceUpdated += x, x => This.SourceUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> DataContextChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.DataContextChanged += x, x => This.DataContextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RequestBringIntoViewEventArgs> RequestBringIntoView {
            get { return Observable.FromEventPattern<System.Windows.RequestBringIntoViewEventHandler, System.Windows.RequestBringIntoViewEventArgs>(x => This.RequestBringIntoView += x, x => This.RequestBringIntoView -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.SizeChangedEventArgs> SizeChanged {
            get { return Observable.FromEventPattern<System.Windows.SizeChangedEventHandler, System.Windows.SizeChangedEventArgs>(x => This.SizeChanged += x, x => This.SizeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Initialized {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Initialized += x, x => This.Initialized -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Loaded {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Loaded += x, x => This.Loaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unloaded {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Unloaded += x, x => This.Unloaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.ToolTipEventArgs> ToolTipOpening {
            get { return Observable.FromEventPattern<System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(x => This.ToolTipOpening += x, x => This.ToolTipOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.ToolTipEventArgs> ToolTipClosing {
            get { return Observable.FromEventPattern<System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(x => This.ToolTipClosing += x, x => This.ToolTipClosing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.ContextMenuEventArgs> ContextMenuOpening {
            get { return Observable.FromEventPattern<System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(x => This.ContextMenuOpening += x, x => This.ContextMenuOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.ContextMenuEventArgs> ContextMenuClosing {
            get { return Observable.FromEventPattern<System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(x => This.ContextMenuClosing += x, x => This.ContextMenuClosing -= x).Select(x => x.EventArgs); }
        }

    }
    public class WindowEvents
        : System.Windows.Controls.ControlEvents
    {
        Window This;

        public WindowEvents(Window This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> SourceInitialized {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SourceInitialized += x, x => This.SourceInitialized -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Deactivated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Deactivated += x, x => This.Deactivated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> StateChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> LocationChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LocationChanged += x, x => This.LocationChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ComponentModel.CancelEventArgs> Closing {
            get { return Observable.FromEventPattern<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(x => This.Closing += x, x => This.Closing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Closed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ContentRendered {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ContentRendered += x, x => This.ContentRendered -= x).Select(x => x.EventArgs); }
        }

    }
    public class ApplicationEvents
    {
        Application This;

        public ApplicationEvents(Application This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.StartupEventArgs> Startup {
            get { return Observable.FromEventPattern<System.Windows.StartupEventHandler, System.Windows.StartupEventArgs>(x => This.Startup += x, x => This.Startup -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.ExitEventArgs> Exit {
            get { return Observable.FromEventPattern<System.Windows.ExitEventHandler, System.Windows.ExitEventArgs>(x => This.Exit += x, x => This.Exit -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Deactivated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Deactivated += x, x => This.Deactivated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.SessionEndingCancelEventArgs> SessionEnding {
            get { return Observable.FromEventPattern<System.Windows.SessionEndingCancelEventHandler, System.Windows.SessionEndingCancelEventArgs>(x => This.SessionEnding += x, x => This.SessionEnding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Threading.DispatcherUnhandledExceptionEventArgs> DispatcherUnhandledException {
            get { return Observable.FromEventPattern<System.Windows.Threading.DispatcherUnhandledExceptionEventHandler, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs>(x => This.DispatcherUnhandledException += x, x => This.DispatcherUnhandledException -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigatingCancelEventArgs> Navigating {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(x => This.Navigating += x, x => This.Navigating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> Navigated {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.Navigated += x, x => This.Navigated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationProgressEventArgs> NavigationProgress {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationProgressEventHandler, System.Windows.Navigation.NavigationProgressEventArgs>(x => This.NavigationProgress += x, x => This.NavigationProgress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationFailedEventArgs> NavigationFailed {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs>(x => This.NavigationFailed += x, x => This.NavigationFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> LoadCompleted {
            get { return Observable.FromEventPattern<System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.LoadCompleted += x, x => This.LoadCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> NavigationStopped {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.NavigationStopped += x, x => This.NavigationStopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.FragmentNavigationEventArgs> FragmentNavigation {
            get { return Observable.FromEventPattern<System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs>(x => This.FragmentNavigation += x, x => This.FragmentNavigation -= x).Select(x => x.EventArgs); }
        }

    }
    public class FrameworkContentElementEvents
        : System.Windows.ContentElementEvents
    {
        FrameworkContentElement This;

        public FrameworkContentElementEvents(FrameworkContentElement This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Data.DataTransferEventArgs> TargetUpdated {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Data.DataTransferEventArgs>, System.Windows.Data.DataTransferEventArgs>(x => This.TargetUpdated += x, x => This.TargetUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Data.DataTransferEventArgs> SourceUpdated {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Data.DataTransferEventArgs>, System.Windows.Data.DataTransferEventArgs>(x => This.SourceUpdated += x, x => This.SourceUpdated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> DataContextChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.DataContextChanged += x, x => This.DataContextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Initialized {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Initialized += x, x => This.Initialized -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Loaded {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Loaded += x, x => This.Loaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unloaded {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Unloaded += x, x => This.Unloaded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.ToolTipEventArgs> ToolTipOpening {
            get { return Observable.FromEventPattern<System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(x => This.ToolTipOpening += x, x => This.ToolTipOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.ToolTipEventArgs> ToolTipClosing {
            get { return Observable.FromEventPattern<System.Windows.Controls.ToolTipEventHandler, System.Windows.Controls.ToolTipEventArgs>(x => This.ToolTipClosing += x, x => This.ToolTipClosing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.ContextMenuEventArgs> ContextMenuOpening {
            get { return Observable.FromEventPattern<System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(x => This.ContextMenuOpening += x, x => This.ContextMenuOpening -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.ContextMenuEventArgs> ContextMenuClosing {
            get { return Observable.FromEventPattern<System.Windows.Controls.ContextMenuEventHandler, System.Windows.Controls.ContextMenuEventArgs>(x => This.ContextMenuClosing += x, x => This.ContextMenuClosing -= x).Select(x => x.EventArgs); }
        }

    }
    public class VisualStateGroupEvents
    {
        VisualStateGroup This;

        public VisualStateGroupEvents(VisualStateGroup This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.VisualStateChangedEventArgs> CurrentStateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.VisualStateChangedEventArgs>, System.Windows.VisualStateChangedEventArgs>(x => This.CurrentStateChanged += x, x => This.CurrentStateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.VisualStateChangedEventArgs> CurrentStateChanging {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.VisualStateChangedEventArgs>, System.Windows.VisualStateChangedEventArgs>(x => This.CurrentStateChanging += x, x => This.CurrentStateChanging -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Data
{
    public static class EventsMixin
    {
        public static DataSourceProviderEvents Events(this DataSourceProvider This)
        {
            return new DataSourceProviderEvents(This);
        }
        public static CollectionViewEvents Events(this CollectionView This)
        {
            return new CollectionViewEvents(This);
        }
        public static CollectionViewSourceEvents Events(this CollectionViewSource This)
        {
            return new CollectionViewSourceEvents(This);
        }
    }

    public class DataSourceProviderEvents
    {
        DataSourceProvider This;

        public DataSourceProviderEvents(DataSourceProvider This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DataChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DataChanged += x, x => This.DataChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CollectionViewEvents
    {
        CollectionView This;

        public CollectionViewEvents(CollectionView This)
        {
            this.This = This;
        }

        public IObservable<System.ComponentModel.CurrentChangingEventArgs> CurrentChanging {
            get { return Observable.FromEventPattern<System.ComponentModel.CurrentChangingEventHandler, System.ComponentModel.CurrentChangingEventArgs>(x => This.CurrentChanging += x, x => This.CurrentChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> CurrentChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CurrentChanged += x, x => This.CurrentChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CollectionViewSourceEvents
    {
        CollectionViewSource This;

        public CollectionViewSourceEvents(CollectionViewSource This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Data.FilterEventArgs> Filter {
            get { return Observable.FromEventPattern<System.Windows.Data.FilterEventHandler, System.Windows.Data.FilterEventArgs>(x => This.Filter += x, x => This.Filter -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Threading
{
    public static class EventsMixin
    {
        public static DispatcherEvents Events(this Dispatcher This)
        {
            return new DispatcherEvents(This);
        }
        public static DispatcherHooksEvents Events(this DispatcherHooks This)
        {
            return new DispatcherHooksEvents(This);
        }
        public static DispatcherOperationEvents Events(this DispatcherOperation This)
        {
            return new DispatcherOperationEvents(This);
        }
        public static DispatcherTimerEvents Events(this DispatcherTimer This)
        {
            return new DispatcherTimerEvents(This);
        }
    }

    public class DispatcherEvents
    {
        Dispatcher This;

        public DispatcherEvents(Dispatcher This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ShutdownStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ShutdownStarted += x, x => This.ShutdownStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> ShutdownFinished {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ShutdownFinished += x, x => This.ShutdownFinished -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Threading.DispatcherUnhandledExceptionFilterEventArgs> UnhandledExceptionFilter {
            get { return Observable.FromEventPattern<System.Windows.Threading.DispatcherUnhandledExceptionFilterEventHandler, System.Windows.Threading.DispatcherUnhandledExceptionFilterEventArgs>(x => This.UnhandledExceptionFilter += x, x => This.UnhandledExceptionFilter -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Threading.DispatcherUnhandledExceptionEventArgs> UnhandledException {
            get { return Observable.FromEventPattern<System.Windows.Threading.DispatcherUnhandledExceptionEventHandler, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs>(x => This.UnhandledException += x, x => This.UnhandledException -= x).Select(x => x.EventArgs); }
        }

    }
    public class DispatcherHooksEvents
    {
        DispatcherHooks This;

        public DispatcherHooksEvents(DispatcherHooks This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DispatcherInactive {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DispatcherInactive += x, x => This.DispatcherInactive -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Threading.DispatcherHookEventArgs> OperationPosted {
            get { return Observable.FromEventPattern<System.Windows.Threading.DispatcherHookEventHandler, System.Windows.Threading.DispatcherHookEventArgs>(x => This.OperationPosted += x, x => This.OperationPosted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Threading.DispatcherHookEventArgs> OperationStarted {
            get { return Observable.FromEventPattern<System.Windows.Threading.DispatcherHookEventHandler, System.Windows.Threading.DispatcherHookEventArgs>(x => This.OperationStarted += x, x => This.OperationStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Threading.DispatcherHookEventArgs> OperationCompleted {
            get { return Observable.FromEventPattern<System.Windows.Threading.DispatcherHookEventHandler, System.Windows.Threading.DispatcherHookEventArgs>(x => This.OperationCompleted += x, x => This.OperationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Threading.DispatcherHookEventArgs> OperationPriorityChanged {
            get { return Observable.FromEventPattern<System.Windows.Threading.DispatcherHookEventHandler, System.Windows.Threading.DispatcherHookEventArgs>(x => This.OperationPriorityChanged += x, x => This.OperationPriorityChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Threading.DispatcherHookEventArgs> OperationAborted {
            get { return Observable.FromEventPattern<System.Windows.Threading.DispatcherHookEventHandler, System.Windows.Threading.DispatcherHookEventArgs>(x => This.OperationAborted += x, x => This.OperationAborted -= x).Select(x => x.EventArgs); }
        }

    }
    public class DispatcherOperationEvents
    {
        DispatcherOperation This;

        public DispatcherOperationEvents(DispatcherOperation This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Aborted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Aborted += x, x => This.Aborted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Completed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

    }
    public class DispatcherTimerEvents
    {
        DispatcherTimer This;

        public DispatcherTimerEvents(DispatcherTimer This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Tick {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Tick += x, x => This.Tick -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Documents
{
    public static class EventsMixin
    {
        public static DocumentPageEvents Events(this DocumentPage This)
        {
            return new DocumentPageEvents(This);
        }
        public static DocumentPaginatorEvents Events(this DocumentPaginator This)
        {
            return new DocumentPaginatorEvents(This);
        }
        public static DynamicDocumentPaginatorEvents Events(this DynamicDocumentPaginator This)
        {
            return new DynamicDocumentPaginatorEvents(This);
        }
        public static DocumentReferenceCollectionEvents Events(this DocumentReferenceCollection This)
        {
            return new DocumentReferenceCollectionEvents(This);
        }
        public static HyperlinkEvents Events(this Hyperlink This)
        {
            return new HyperlinkEvents(This);
        }
        public static PageContentEvents Events(this PageContent This)
        {
            return new PageContentEvents(This);
        }
        public static TextRangeEvents Events(this TextRange This)
        {
            return new TextRangeEvents(This);
        }
    }

    public class DocumentPageEvents
    {
        DocumentPage This;

        public DocumentPageEvents(DocumentPage This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> PageDestroyed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PageDestroyed += x, x => This.PageDestroyed -= x).Select(x => x.EventArgs); }
        }

    }
    public class DocumentPaginatorEvents
    {
        DocumentPaginator This;

        public DocumentPaginatorEvents(DocumentPaginator This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Documents.GetPageCompletedEventArgs> GetPageCompleted {
            get { return Observable.FromEventPattern<System.Windows.Documents.GetPageCompletedEventHandler, System.Windows.Documents.GetPageCompletedEventArgs>(x => This.GetPageCompleted += x, x => This.GetPageCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.ComponentModel.AsyncCompletedEventArgs> ComputePageCountCompleted {
            get { return Observable.FromEventPattern<System.ComponentModel.AsyncCompletedEventHandler, System.ComponentModel.AsyncCompletedEventArgs>(x => This.ComputePageCountCompleted += x, x => This.ComputePageCountCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Documents.PagesChangedEventArgs> PagesChanged {
            get { return Observable.FromEventPattern<System.Windows.Documents.PagesChangedEventHandler, System.Windows.Documents.PagesChangedEventArgs>(x => This.PagesChanged += x, x => This.PagesChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class DynamicDocumentPaginatorEvents
        : System.Windows.Documents.DocumentPaginatorEvents
    {
        DynamicDocumentPaginator This;

        public DynamicDocumentPaginatorEvents(DynamicDocumentPaginator This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Documents.GetPageNumberCompletedEventArgs> GetPageNumberCompleted {
            get { return Observable.FromEventPattern<System.Windows.Documents.GetPageNumberCompletedEventHandler, System.Windows.Documents.GetPageNumberCompletedEventArgs>(x => This.GetPageNumberCompleted += x, x => This.GetPageNumberCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PaginationCompleted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PaginationCompleted += x, x => This.PaginationCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Documents.PaginationProgressEventArgs> PaginationProgress {
            get { return Observable.FromEventPattern<System.Windows.Documents.PaginationProgressEventHandler, System.Windows.Documents.PaginationProgressEventArgs>(x => This.PaginationProgress += x, x => This.PaginationProgress -= x).Select(x => x.EventArgs); }
        }

    }
    public class DocumentReferenceCollectionEvents
    {
        DocumentReferenceCollection This;

        public DocumentReferenceCollectionEvents(DocumentReferenceCollection This)
        {
            this.This = This;
        }

        public IObservable<System.Collections.Specialized.NotifyCollectionChangedEventArgs> CollectionChanged {
            get { return Observable.FromEventPattern<System.Collections.Specialized.NotifyCollectionChangedEventHandler, System.Collections.Specialized.NotifyCollectionChangedEventArgs>(x => This.CollectionChanged += x, x => This.CollectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class HyperlinkEvents
        : System.Windows.FrameworkContentElementEvents
    {
        Hyperlink This;

        public HyperlinkEvents(Hyperlink This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Navigation.RequestNavigateEventArgs> RequestNavigate {
            get { return Observable.FromEventPattern<System.Windows.Navigation.RequestNavigateEventHandler, System.Windows.Navigation.RequestNavigateEventArgs>(x => This.RequestNavigate += x, x => This.RequestNavigate -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Click {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class PageContentEvents
        : System.Windows.FrameworkElementEvents
    {
        PageContent This;

        public PageContentEvents(PageContent This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Documents.GetPageRootCompletedEventArgs> GetPageRootCompleted {
            get { return Observable.FromEventPattern<System.Windows.Documents.GetPageRootCompletedEventHandler, System.Windows.Documents.GetPageRootCompletedEventArgs>(x => This.GetPageRootCompleted += x, x => This.GetPageRootCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextRangeEvents
    {
        TextRange This;

        public TextRangeEvents(TextRange This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Changed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Changed += x, x => This.Changed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Ink
{
    public static class EventsMixin
    {
        public static DrawingAttributesEvents Events(this DrawingAttributes This)
        {
            return new DrawingAttributesEvents(This);
        }
        public static IncrementalLassoHitTesterEvents Events(this IncrementalLassoHitTester This)
        {
            return new IncrementalLassoHitTesterEvents(This);
        }
        public static IncrementalStrokeHitTesterEvents Events(this IncrementalStrokeHitTester This)
        {
            return new IncrementalStrokeHitTesterEvents(This);
        }
        public static StrokeEvents Events(this Stroke This)
        {
            return new StrokeEvents(This);
        }
        public static StrokeCollectionEvents Events(this StrokeCollection This)
        {
            return new StrokeCollectionEvents(This);
        }
    }

    public class DrawingAttributesEvents
    {
        DrawingAttributes This;

        public DrawingAttributesEvents(DrawingAttributes This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Ink.PropertyDataChangedEventArgs> AttributeChanged {
            get { return Observable.FromEventPattern<System.Windows.Ink.PropertyDataChangedEventHandler, System.Windows.Ink.PropertyDataChangedEventArgs>(x => This.AttributeChanged += x, x => This.AttributeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Ink.PropertyDataChangedEventArgs> PropertyDataChanged {
            get { return Observable.FromEventPattern<System.Windows.Ink.PropertyDataChangedEventHandler, System.Windows.Ink.PropertyDataChangedEventArgs>(x => This.PropertyDataChanged += x, x => This.PropertyDataChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class IncrementalLassoHitTesterEvents
    {
        IncrementalLassoHitTester This;

        public IncrementalLassoHitTesterEvents(IncrementalLassoHitTester This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Ink.LassoSelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.Ink.LassoSelectionChangedEventHandler, System.Windows.Ink.LassoSelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class IncrementalStrokeHitTesterEvents
    {
        IncrementalStrokeHitTester This;

        public IncrementalStrokeHitTesterEvents(IncrementalStrokeHitTester This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Ink.StrokeHitEventArgs> StrokeHit {
            get { return Observable.FromEventPattern<System.Windows.Ink.StrokeHitEventHandler, System.Windows.Ink.StrokeHitEventArgs>(x => This.StrokeHit += x, x => This.StrokeHit -= x).Select(x => x.EventArgs); }
        }

    }
    public class StrokeEvents
    {
        Stroke This;

        public StrokeEvents(Stroke This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Ink.PropertyDataChangedEventArgs> DrawingAttributesChanged {
            get { return Observable.FromEventPattern<System.Windows.Ink.PropertyDataChangedEventHandler, System.Windows.Ink.PropertyDataChangedEventArgs>(x => This.DrawingAttributesChanged += x, x => This.DrawingAttributesChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Ink.DrawingAttributesReplacedEventArgs> DrawingAttributesReplaced {
            get { return Observable.FromEventPattern<System.Windows.Ink.DrawingAttributesReplacedEventHandler, System.Windows.Ink.DrawingAttributesReplacedEventArgs>(x => This.DrawingAttributesReplaced += x, x => This.DrawingAttributesReplaced -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Ink.StylusPointsReplacedEventArgs> StylusPointsReplaced {
            get { return Observable.FromEventPattern<System.Windows.Ink.StylusPointsReplacedEventHandler, System.Windows.Ink.StylusPointsReplacedEventArgs>(x => This.StylusPointsReplaced += x, x => This.StylusPointsReplaced -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> StylusPointsChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.StylusPointsChanged += x, x => This.StylusPointsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Ink.PropertyDataChangedEventArgs> PropertyDataChanged {
            get { return Observable.FromEventPattern<System.Windows.Ink.PropertyDataChangedEventHandler, System.Windows.Ink.PropertyDataChangedEventArgs>(x => This.PropertyDataChanged += x, x => This.PropertyDataChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Invalidated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Invalidated += x, x => This.Invalidated -= x).Select(x => x.EventArgs); }
        }

    }
    public class StrokeCollectionEvents
    {
        StrokeCollection This;

        public StrokeCollectionEvents(StrokeCollection This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Ink.StrokeCollectionChangedEventArgs> StrokesChanged {
            get { return Observable.FromEventPattern<System.Windows.Ink.StrokeCollectionChangedEventHandler, System.Windows.Ink.StrokeCollectionChangedEventArgs>(x => This.StrokesChanged += x, x => This.StrokesChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Ink.PropertyDataChangedEventArgs> PropertyDataChanged {
            get { return Observable.FromEventPattern<System.Windows.Ink.PropertyDataChangedEventHandler, System.Windows.Ink.PropertyDataChangedEventArgs>(x => This.PropertyDataChanged += x, x => This.PropertyDataChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Input
{
    public static class EventsMixin
    {
        public static CommandBindingEvents Events(this CommandBinding This)
        {
            return new CommandBindingEvents(This);
        }
        public static RoutedCommandEvents Events(this RoutedCommand This)
        {
            return new RoutedCommandEvents(This);
        }
        public static IManipulatorEvents Events(this IManipulator This)
        {
            return new IManipulatorEvents(This);
        }
        public static InputLanguageManagerEvents Events(this InputLanguageManager This)
        {
            return new InputLanguageManagerEvents(This);
        }
        public static InputManagerEvents Events(this InputManager This)
        {
            return new InputManagerEvents(This);
        }
        public static InputMethodEvents Events(this InputMethod This)
        {
            return new InputMethodEvents(This);
        }
        public static TouchDeviceEvents Events(this TouchDevice This)
        {
            return new TouchDeviceEvents(This);
        }
        public static StylusPointCollectionEvents Events(this StylusPointCollection This)
        {
            return new StylusPointCollectionEvents(This);
        }
    }

    public class CommandBindingEvents
    {
        CommandBinding This;

        public CommandBindingEvents(CommandBinding This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Input.ExecutedRoutedEventArgs> PreviewExecuted {
            get { return Observable.FromEventPattern<System.Windows.Input.ExecutedRoutedEventHandler, System.Windows.Input.ExecutedRoutedEventArgs>(x => This.PreviewExecuted += x, x => This.PreviewExecuted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.ExecutedRoutedEventArgs> Executed {
            get { return Observable.FromEventPattern<System.Windows.Input.ExecutedRoutedEventHandler, System.Windows.Input.ExecutedRoutedEventArgs>(x => This.Executed += x, x => This.Executed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.CanExecuteRoutedEventArgs> PreviewCanExecute {
            get { return Observable.FromEventPattern<System.Windows.Input.CanExecuteRoutedEventHandler, System.Windows.Input.CanExecuteRoutedEventArgs>(x => This.PreviewCanExecute += x, x => This.PreviewCanExecute -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.CanExecuteRoutedEventArgs> CanExecute {
            get { return Observable.FromEventPattern<System.Windows.Input.CanExecuteRoutedEventHandler, System.Windows.Input.CanExecuteRoutedEventArgs>(x => This.CanExecute += x, x => This.CanExecute -= x).Select(x => x.EventArgs); }
        }

    }
    public class RoutedCommandEvents
    {
        RoutedCommand This;

        public RoutedCommandEvents(RoutedCommand This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> CanExecuteChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CanExecuteChanged += x, x => This.CanExecuteChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class IManipulatorEvents
    {
        IManipulator This;

        public IManipulatorEvents(IManipulator This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Updated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Updated += x, x => This.Updated -= x).Select(x => x.EventArgs); }
        }

    }
    public class InputLanguageManagerEvents
    {
        InputLanguageManager This;

        public InputLanguageManagerEvents(InputLanguageManager This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Input.InputLanguageEventArgs> InputLanguageChanged {
            get { return Observable.FromEventPattern<System.Windows.Input.InputLanguageEventHandler, System.Windows.Input.InputLanguageEventArgs>(x => This.InputLanguageChanged += x, x => This.InputLanguageChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.InputLanguageEventArgs> InputLanguageChanging {
            get { return Observable.FromEventPattern<System.Windows.Input.InputLanguageEventHandler, System.Windows.Input.InputLanguageEventArgs>(x => This.InputLanguageChanging += x, x => This.InputLanguageChanging -= x).Select(x => x.EventArgs); }
        }

    }
    public class InputManagerEvents
    {
        InputManager This;

        public InputManagerEvents(InputManager This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Input.PreProcessInputEventArgs> PreProcessInput {
            get { return Observable.FromEventPattern<System.Windows.Input.PreProcessInputEventHandler, System.Windows.Input.PreProcessInputEventArgs>(x => This.PreProcessInput += x, x => This.PreProcessInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.NotifyInputEventArgs> PreNotifyInput {
            get { return Observable.FromEventPattern<System.Windows.Input.NotifyInputEventHandler, System.Windows.Input.NotifyInputEventArgs>(x => This.PreNotifyInput += x, x => This.PreNotifyInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.NotifyInputEventArgs> PostNotifyInput {
            get { return Observable.FromEventPattern<System.Windows.Input.NotifyInputEventHandler, System.Windows.Input.NotifyInputEventArgs>(x => This.PostNotifyInput += x, x => This.PostNotifyInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.ProcessInputEventArgs> PostProcessInput {
            get { return Observable.FromEventPattern<System.Windows.Input.ProcessInputEventHandler, System.Windows.Input.ProcessInputEventArgs>(x => This.PostProcessInput += x, x => This.PostProcessInput -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> EnterMenuMode {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.EnterMenuMode += x, x => This.EnterMenuMode -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> LeaveMenuMode {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.LeaveMenuMode += x, x => This.LeaveMenuMode -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> HitTestInvalidatedAsync {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.HitTestInvalidatedAsync += x, x => This.HitTestInvalidatedAsync -= x).Select(x => x.EventArgs); }
        }

    }
    public class InputMethodEvents
    {
        InputMethod This;

        public InputMethodEvents(InputMethod This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Input.InputMethodStateChangedEventArgs> StateChanged {
            get { return Observable.FromEventPattern<System.Windows.Input.InputMethodStateChangedEventHandler, System.Windows.Input.InputMethodStateChangedEventArgs>(x => This.StateChanged += x, x => This.StateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class TouchDeviceEvents
    {
        TouchDevice This;

        public TouchDeviceEvents(TouchDevice This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Activated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Activated += x, x => This.Activated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Deactivated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Deactivated += x, x => This.Deactivated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Updated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Updated += x, x => This.Updated -= x).Select(x => x.EventArgs); }
        }

    }
    public class StylusPointCollectionEvents
    {
        StylusPointCollection This;

        public StylusPointCollectionEvents(StylusPointCollection This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Changed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Changed += x, x => This.Changed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Interop
{
    public static class EventsMixin
    {
        public static D3DImageEvents Events(this D3DImage This)
        {
            return new D3DImageEvents(This);
        }
        public static HwndSourceEvents Events(this HwndSource This)
        {
            return new HwndSourceEvents(This);
        }
        public static HwndHostEvents Events(this HwndHost This)
        {
            return new HwndHostEvents(This);
        }
    }

    public class D3DImageEvents
        : System.Windows.FreezableEvents
    {
        D3DImage This;

        public D3DImageEvents(D3DImage This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.DependencyPropertyChangedEventArgs> IsFrontBufferAvailableChanged {
            get { return Observable.FromEventPattern<System.Windows.DependencyPropertyChangedEventHandler, System.Windows.DependencyPropertyChangedEventArgs>(x => This.IsFrontBufferAvailableChanged += x, x => This.IsFrontBufferAvailableChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class HwndSourceEvents
        : System.Windows.PresentationSourceEvents
    {
        HwndSource This;

        public HwndSourceEvents(HwndSource This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Disposed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Disposed += x, x => This.Disposed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SizeToContentChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SizeToContentChanged += x, x => This.SizeToContentChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.AutoResizedEventArgs> AutoResized {
            get { return Observable.FromEventPattern<System.Windows.AutoResizedEventHandler, System.Windows.AutoResizedEventArgs>(x => This.AutoResized += x, x => This.AutoResized -= x).Select(x => x.EventArgs); }
        }

    }
    public class HwndHostEvents
        : System.Windows.FrameworkElementEvents
    {
        HwndHost This;

        public HwndHostEvents(HwndHost This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Int32> MessageHook {
            get { return Observable.FromEventPattern<System.Windows.Interop.HwndSourceHook, System.Int32>(x => This.MessageHook += x, x => This.MessageHook -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Media.Animation
{
    public static class EventsMixin
    {
        public static ClockEvents Events(this Clock This)
        {
            return new ClockEvents(This);
        }
        public static TimelineEvents Events(this Timeline This)
        {
            return new TimelineEvents(This);
        }
    }

    public class ClockEvents
    {
        Clock This;

        public ClockEvents(Clock This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Completed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> CurrentGlobalSpeedInvalidated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CurrentGlobalSpeedInvalidated += x, x => This.CurrentGlobalSpeedInvalidated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> CurrentStateInvalidated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CurrentStateInvalidated += x, x => This.CurrentStateInvalidated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> CurrentTimeInvalidated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CurrentTimeInvalidated += x, x => This.CurrentTimeInvalidated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> RemoveRequested {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.RemoveRequested += x, x => This.RemoveRequested -= x).Select(x => x.EventArgs); }
        }

    }
    public class TimelineEvents
        : System.Windows.FreezableEvents
    {
        Timeline This;

        public TimelineEvents(Timeline This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> CurrentStateInvalidated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CurrentStateInvalidated += x, x => This.CurrentStateInvalidated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> CurrentTimeInvalidated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CurrentTimeInvalidated += x, x => This.CurrentTimeInvalidated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> CurrentGlobalSpeedInvalidated {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.CurrentGlobalSpeedInvalidated += x, x => This.CurrentGlobalSpeedInvalidated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Completed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Completed += x, x => This.Completed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> RemoveRequested {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.RemoveRequested += x, x => This.RemoveRequested -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Media.Imaging
{
    public static class EventsMixin
    {
        public static BitmapDecoderEvents Events(this BitmapDecoder This)
        {
            return new BitmapDecoderEvents(This);
        }
        public static BitmapSourceEvents Events(this BitmapSource This)
        {
            return new BitmapSourceEvents(This);
        }
    }

    public class BitmapDecoderEvents
    {
        BitmapDecoder This;

        public BitmapDecoderEvents(BitmapDecoder This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DownloadCompleted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DownloadCompleted += x, x => This.DownloadCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Media.Imaging.DownloadProgressEventArgs> DownloadProgress {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Media.Imaging.DownloadProgressEventArgs>, System.Windows.Media.Imaging.DownloadProgressEventArgs>(x => This.DownloadProgress += x, x => This.DownloadProgress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Media.ExceptionEventArgs> DownloadFailed {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Media.ExceptionEventArgs>, System.Windows.Media.ExceptionEventArgs>(x => This.DownloadFailed += x, x => This.DownloadFailed -= x).Select(x => x.EventArgs); }
        }

    }
    public class BitmapSourceEvents
        : System.Windows.FreezableEvents
    {
        BitmapSource This;

        public BitmapSourceEvents(BitmapSource This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DownloadCompleted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DownloadCompleted += x, x => This.DownloadCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Media.Imaging.DownloadProgressEventArgs> DownloadProgress {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Media.Imaging.DownloadProgressEventArgs>, System.Windows.Media.Imaging.DownloadProgressEventArgs>(x => This.DownloadProgress += x, x => This.DownloadProgress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Media.ExceptionEventArgs> DownloadFailed {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Media.ExceptionEventArgs>, System.Windows.Media.ExceptionEventArgs>(x => This.DownloadFailed += x, x => This.DownloadFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Media.ExceptionEventArgs> DecodeFailed {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Media.ExceptionEventArgs>, System.Windows.Media.ExceptionEventArgs>(x => This.DecodeFailed += x, x => This.DecodeFailed -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Media
{
    public static class EventsMixin
    {
        public static MediaPlayerEvents Events(this MediaPlayer This)
        {
            return new MediaPlayerEvents(This);
        }
    }

    public class MediaPlayerEvents
        : System.Windows.FreezableEvents
    {
        MediaPlayer This;

        public MediaPlayerEvents(MediaPlayer This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Media.ExceptionEventArgs> MediaFailed {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Media.ExceptionEventArgs>, System.Windows.Media.ExceptionEventArgs>(x => This.MediaFailed += x, x => This.MediaFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> MediaOpened {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.MediaOpened += x, x => This.MediaOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> MediaEnded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.MediaEnded += x, x => This.MediaEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> BufferingStarted {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.BufferingStarted += x, x => This.BufferingStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> BufferingEnded {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.BufferingEnded += x, x => This.BufferingEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Media.MediaScriptCommandEventArgs> ScriptCommand {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Media.MediaScriptCommandEventArgs>, System.Windows.Media.MediaScriptCommandEventArgs>(x => This.ScriptCommand += x, x => This.ScriptCommand -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace Microsoft.Win32
{
    public static class EventsMixin
    {
        public static FileDialogEvents Events(this FileDialog This)
        {
            return new FileDialogEvents(This);
        }
    }

    public class FileDialogEvents
    {
        FileDialog This;

        public FileDialogEvents(FileDialog This)
        {
            this.This = This;
        }

        public IObservable<System.ComponentModel.CancelEventArgs> FileOk {
            get { return Observable.FromEventPattern<System.ComponentModel.CancelEventHandler, System.ComponentModel.CancelEventArgs>(x => This.FileOk += x, x => This.FileOk -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Controls
{
    public static class EventsMixin
    {
        public static ControlEvents Events(this Control This)
        {
            return new ControlEvents(This);
        }
        public static ContextMenuEvents Events(this ContextMenu This)
        {
            return new ContextMenuEvents(This);
        }
        public static MenuItemEvents Events(this MenuItem This)
        {
            return new MenuItemEvents(This);
        }
        public static CalendarEvents Events(this Calendar This)
        {
            return new CalendarEvents(This);
        }
        public static CalendarDateRangeEvents Events(this CalendarDateRange This)
        {
            return new CalendarDateRangeEvents(This);
        }
        public static ComboBoxEvents Events(this ComboBox This)
        {
            return new ComboBoxEvents(This);
        }
        public static ListBoxItemEvents Events(this ListBoxItem This)
        {
            return new ListBoxItemEvents(This);
        }
        public static DataGridEvents Events(this DataGrid This)
        {
            return new DataGridEvents(This);
        }
        public static DataGridColumnEvents Events(this DataGridColumn This)
        {
            return new DataGridColumnEvents(This);
        }
        public static DataGridCellEvents Events(this DataGridCell This)
        {
            return new DataGridCellEvents(This);
        }
        public static DataGridRowEvents Events(this DataGridRow This)
        {
            return new DataGridRowEvents(This);
        }
        public static DatePickerEvents Events(this DatePicker This)
        {
            return new DatePickerEvents(This);
        }
        public static ExpanderEvents Events(this Expander This)
        {
            return new ExpanderEvents(This);
        }
        public static FrameEvents Events(this Frame This)
        {
            return new FrameEvents(This);
        }
        public static ImageEvents Events(this Image This)
        {
            return new ImageEvents(This);
        }
        public static InkCanvasEvents Events(this InkCanvas This)
        {
            return new InkCanvasEvents(This);
        }
        public static ItemContainerGeneratorEvents Events(this ItemContainerGenerator This)
        {
            return new ItemContainerGeneratorEvents(This);
        }
        public static MediaElementEvents Events(this MediaElement This)
        {
            return new MediaElementEvents(This);
        }
        public static PasswordBoxEvents Events(this PasswordBox This)
        {
            return new PasswordBoxEvents(This);
        }
        public static ScrollViewerEvents Events(this ScrollViewer This)
        {
            return new ScrollViewerEvents(This);
        }
        public static ToolTipEvents Events(this ToolTip This)
        {
            return new ToolTipEvents(This);
        }
        public static TreeViewEvents Events(this TreeView This)
        {
            return new TreeViewEvents(This);
        }
        public static TreeViewItemEvents Events(this TreeViewItem This)
        {
            return new TreeViewItemEvents(This);
        }
        public static WebBrowserEvents Events(this WebBrowser This)
        {
            return new WebBrowserEvents(This);
        }
    }

    public class ControlEvents
        : System.Windows.FrameworkElementEvents
    {
        Control This;

        public ControlEvents(Control This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> PreviewMouseDoubleClick {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.PreviewMouseDoubleClick += x, x => This.PreviewMouseDoubleClick -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Input.MouseButtonEventArgs> MouseDoubleClick {
            get { return Observable.FromEventPattern<System.Windows.Input.MouseButtonEventHandler, System.Windows.Input.MouseButtonEventArgs>(x => This.MouseDoubleClick += x, x => This.MouseDoubleClick -= x).Select(x => x.EventArgs); }
        }

    }
    public class ContextMenuEvents
        : System.Windows.Controls.ControlEvents
    {
        ContextMenu This;

        public ContextMenuEvents(ContextMenu This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Opened {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Closed {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

    }
    public class MenuItemEvents
        : System.Windows.Controls.ControlEvents
    {
        MenuItem This;

        public MenuItemEvents(MenuItem This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Click {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Checked {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Checked += x, x => This.Checked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unchecked {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Unchecked += x, x => This.Unchecked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> SubmenuOpened {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.SubmenuOpened += x, x => This.SubmenuOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> SubmenuClosed {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.SubmenuClosed += x, x => This.SubmenuClosed -= x).Select(x => x.EventArgs); }
        }

    }
    public class CalendarEvents
        : System.Windows.Controls.ControlEvents
    {
        Calendar This;

        public CalendarEvents(Calendar This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectedDatesChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs>(x => This.SelectedDatesChanged += x, x => This.SelectedDatesChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.CalendarDateChangedEventArgs> DisplayDateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.CalendarDateChangedEventArgs>, System.Windows.Controls.CalendarDateChangedEventArgs>(x => This.DisplayDateChanged += x, x => This.DisplayDateChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.CalendarModeChangedEventArgs> DisplayModeChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.CalendarModeChangedEventArgs>, System.Windows.Controls.CalendarModeChangedEventArgs>(x => This.DisplayModeChanged += x, x => This.DisplayModeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionModeChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.SelectionModeChanged += x, x => This.SelectionModeChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class CalendarDateRangeEvents
    {
        CalendarDateRange This;

        public CalendarDateRangeEvents(CalendarDateRange This)
        {
            this.This = This;
        }

        public IObservable<System.ComponentModel.PropertyChangedEventArgs> PropertyChanged {
            get { return Observable.FromEventPattern<System.ComponentModel.PropertyChangedEventHandler, System.ComponentModel.PropertyChangedEventArgs>(x => This.PropertyChanged += x, x => This.PropertyChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ComboBoxEvents
        : System.Windows.Controls.Primitives.SelectorEvents
    {
        ComboBox This;

        public ComboBoxEvents(ComboBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> DropDownOpened {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DropDownOpened += x, x => This.DropDownOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> DropDownClosed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.DropDownClosed += x, x => This.DropDownClosed -= x).Select(x => x.EventArgs); }
        }

    }
    public class ListBoxItemEvents
        : System.Windows.Controls.ControlEvents
    {
        ListBoxItem This;

        public ListBoxItemEvents(ListBoxItem This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Selected {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Selected += x, x => This.Selected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unselected {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Unselected += x, x => This.Unselected -= x).Select(x => x.EventArgs); }
        }

    }
    public class DataGridEvents
        : System.Windows.Controls.Primitives.SelectorEvents
    {
        DataGrid This;

        public DataGridEvents(DataGrid This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.DataGridColumnEventArgs> ColumnDisplayIndexChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs>, System.Windows.Controls.DataGridColumnEventArgs>(x => This.ColumnDisplayIndexChanged += x, x => This.ColumnDisplayIndexChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridRowEventArgs> LoadingRow {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>, System.Windows.Controls.DataGridRowEventArgs>(x => This.LoadingRow += x, x => This.LoadingRow -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridRowEventArgs> UnloadingRow {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>, System.Windows.Controls.DataGridRowEventArgs>(x => This.UnloadingRow += x, x => This.UnloadingRow -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridRowEditEndingEventArgs> RowEditEnding {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridRowEditEndingEventArgs>, System.Windows.Controls.DataGridRowEditEndingEventArgs>(x => This.RowEditEnding += x, x => This.RowEditEnding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridCellEditEndingEventArgs> CellEditEnding {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>, System.Windows.Controls.DataGridCellEditEndingEventArgs>(x => This.CellEditEnding += x, x => This.CellEditEnding -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> CurrentCellChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.EventArgs>, System.EventArgs>(x => This.CurrentCellChanged += x, x => This.CurrentCellChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridBeginningEditEventArgs> BeginningEdit {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>, System.Windows.Controls.DataGridBeginningEditEventArgs>(x => This.BeginningEdit += x, x => This.BeginningEdit -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridPreparingCellForEditEventArgs> PreparingCellForEdit {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridPreparingCellForEditEventArgs>, System.Windows.Controls.DataGridPreparingCellForEditEventArgs>(x => This.PreparingCellForEdit += x, x => This.PreparingCellForEdit -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.AddingNewItemEventArgs> AddingNewItem {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.AddingNewItemEventArgs>, System.Windows.Controls.AddingNewItemEventArgs>(x => This.AddingNewItem += x, x => This.AddingNewItem -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.InitializingNewItemEventArgs> InitializingNewItem {
            get { return Observable.FromEventPattern<System.Windows.Controls.InitializingNewItemEventHandler, System.Windows.Controls.InitializingNewItemEventArgs>(x => This.InitializingNewItem += x, x => This.InitializingNewItem -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridRowDetailsEventArgs> LoadingRowDetails {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs>, System.Windows.Controls.DataGridRowDetailsEventArgs>(x => This.LoadingRowDetails += x, x => This.LoadingRowDetails -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridRowDetailsEventArgs> UnloadingRowDetails {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs>, System.Windows.Controls.DataGridRowDetailsEventArgs>(x => This.UnloadingRowDetails += x, x => This.UnloadingRowDetails -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridRowDetailsEventArgs> RowDetailsVisibilityChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridRowDetailsEventArgs>, System.Windows.Controls.DataGridRowDetailsEventArgs>(x => This.RowDetailsVisibilityChanged += x, x => This.RowDetailsVisibilityChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.SelectedCellsChangedEventArgs> SelectedCellsChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.SelectedCellsChangedEventHandler, System.Windows.Controls.SelectedCellsChangedEventArgs>(x => This.SelectedCellsChanged += x, x => This.SelectedCellsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridSortingEventArgs> Sorting {
            get { return Observable.FromEventPattern<System.Windows.Controls.DataGridSortingEventHandler, System.Windows.Controls.DataGridSortingEventArgs>(x => This.Sorting += x, x => This.Sorting -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> AutoGeneratedColumns {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.AutoGeneratedColumns += x, x => This.AutoGeneratedColumns -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs> AutoGeneratingColumn {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>, System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(x => This.AutoGeneratingColumn += x, x => This.AutoGeneratingColumn -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridColumnReorderingEventArgs> ColumnReordering {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridColumnReorderingEventArgs>, System.Windows.Controls.DataGridColumnReorderingEventArgs>(x => This.ColumnReordering += x, x => This.ColumnReordering -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.Primitives.DragStartedEventArgs> ColumnHeaderDragStarted {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.Primitives.DragStartedEventArgs>, System.Windows.Controls.Primitives.DragStartedEventArgs>(x => This.ColumnHeaderDragStarted += x, x => This.ColumnHeaderDragStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.Primitives.DragDeltaEventArgs> ColumnHeaderDragDelta {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.Primitives.DragDeltaEventArgs>, System.Windows.Controls.Primitives.DragDeltaEventArgs>(x => This.ColumnHeaderDragDelta += x, x => This.ColumnHeaderDragDelta -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.Primitives.DragCompletedEventArgs> ColumnHeaderDragCompleted {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.Primitives.DragCompletedEventArgs>, System.Windows.Controls.Primitives.DragCompletedEventArgs>(x => This.ColumnHeaderDragCompleted += x, x => This.ColumnHeaderDragCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridColumnEventArgs> ColumnReordered {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridColumnEventArgs>, System.Windows.Controls.DataGridColumnEventArgs>(x => This.ColumnReordered += x, x => This.ColumnReordered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridRowClipboardEventArgs> CopyingRowClipboardContent {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridRowClipboardEventArgs>, System.Windows.Controls.DataGridRowClipboardEventArgs>(x => This.CopyingRowClipboardContent += x, x => This.CopyingRowClipboardContent -= x).Select(x => x.EventArgs); }
        }

    }
    public class DataGridColumnEvents
    {
        DataGridColumn This;

        public DataGridColumnEvents(DataGridColumn This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.DataGridCellClipboardEventArgs> CopyingCellClipboardContent {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridCellClipboardEventArgs>, System.Windows.Controls.DataGridCellClipboardEventArgs>(x => This.CopyingCellClipboardContent += x, x => This.CopyingCellClipboardContent -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DataGridCellClipboardEventArgs> PastingCellClipboardContent {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DataGridCellClipboardEventArgs>, System.Windows.Controls.DataGridCellClipboardEventArgs>(x => This.PastingCellClipboardContent += x, x => This.PastingCellClipboardContent -= x).Select(x => x.EventArgs); }
        }

    }
    public class DataGridCellEvents
        : System.Windows.Controls.ControlEvents
    {
        DataGridCell This;

        public DataGridCellEvents(DataGridCell This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Selected {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Selected += x, x => This.Selected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unselected {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Unselected += x, x => This.Unselected -= x).Select(x => x.EventArgs); }
        }

    }
    public class DataGridRowEvents
        : System.Windows.Controls.ControlEvents
    {
        DataGridRow This;

        public DataGridRowEvents(DataGridRow This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Selected {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Selected += x, x => This.Selected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unselected {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Unselected += x, x => This.Unselected -= x).Select(x => x.EventArgs); }
        }

    }
    public class DatePickerEvents
        : System.Windows.Controls.ControlEvents
    {
        DatePicker This;

        public DatePickerEvents(DatePicker This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> CalendarClosed {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.CalendarClosed += x, x => This.CalendarClosed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> CalendarOpened {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.CalendarOpened += x, x => This.CalendarOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.DatePickerDateValidationErrorEventArgs> DateValidationError {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.DatePickerDateValidationErrorEventArgs>, System.Windows.Controls.DatePickerDateValidationErrorEventArgs>(x => This.DateValidationError += x, x => This.DateValidationError -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectedDateChanged {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>, System.Windows.Controls.SelectionChangedEventArgs>(x => This.SelectedDateChanged += x, x => This.SelectedDateChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ExpanderEvents
        : System.Windows.Controls.ControlEvents
    {
        Expander This;

        public ExpanderEvents(Expander This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Expanded {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Expanded += x, x => This.Expanded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Collapsed {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Collapsed += x, x => This.Collapsed -= x).Select(x => x.EventArgs); }
        }

    }
    public class FrameEvents
        : System.Windows.Controls.ControlEvents
    {
        Frame This;

        public FrameEvents(Frame This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> ContentRendered {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.ContentRendered += x, x => This.ContentRendered -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigatingCancelEventArgs> Navigating {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(x => This.Navigating += x, x => This.Navigating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationProgressEventArgs> NavigationProgress {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationProgressEventHandler, System.Windows.Navigation.NavigationProgressEventArgs>(x => This.NavigationProgress += x, x => This.NavigationProgress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationFailedEventArgs> NavigationFailed {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs>(x => This.NavigationFailed += x, x => This.NavigationFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> Navigated {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.Navigated += x, x => This.Navigated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> LoadCompleted {
            get { return Observable.FromEventPattern<System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.LoadCompleted += x, x => This.LoadCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> NavigationStopped {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.NavigationStopped += x, x => This.NavigationStopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.FragmentNavigationEventArgs> FragmentNavigation {
            get { return Observable.FromEventPattern<System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs>(x => This.FragmentNavigation += x, x => This.FragmentNavigation -= x).Select(x => x.EventArgs); }
        }

    }
    public class ImageEvents
        : System.Windows.FrameworkElementEvents
    {
        Image This;

        public ImageEvents(Image This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.ExceptionRoutedEventArgs> ImageFailed {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs>(x => This.ImageFailed += x, x => This.ImageFailed -= x).Select(x => x.EventArgs); }
        }

    }
    public class InkCanvasEvents
        : System.Windows.FrameworkElementEvents
    {
        InkCanvas This;

        public InkCanvasEvents(InkCanvas This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.InkCanvasStrokeCollectedEventArgs> StrokeCollected {
            get { return Observable.FromEventPattern<System.Windows.Controls.InkCanvasStrokeCollectedEventHandler, System.Windows.Controls.InkCanvasStrokeCollectedEventArgs>(x => This.StrokeCollected += x, x => This.StrokeCollected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.InkCanvasGestureEventArgs> Gesture {
            get { return Observable.FromEventPattern<System.Windows.Controls.InkCanvasGestureEventHandler, System.Windows.Controls.InkCanvasGestureEventArgs>(x => This.Gesture += x, x => This.Gesture -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.InkCanvasStrokesReplacedEventArgs> StrokesReplaced {
            get { return Observable.FromEventPattern<System.Windows.Controls.InkCanvasStrokesReplacedEventHandler, System.Windows.Controls.InkCanvasStrokesReplacedEventArgs>(x => This.StrokesReplaced += x, x => This.StrokesReplaced -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Ink.DrawingAttributesReplacedEventArgs> DefaultDrawingAttributesReplaced {
            get { return Observable.FromEventPattern<System.Windows.Ink.DrawingAttributesReplacedEventHandler, System.Windows.Ink.DrawingAttributesReplacedEventArgs>(x => This.DefaultDrawingAttributesReplaced += x, x => This.DefaultDrawingAttributesReplaced -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> ActiveEditingModeChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.ActiveEditingModeChanged += x, x => This.ActiveEditingModeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> EditingModeChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.EditingModeChanged += x, x => This.EditingModeChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> EditingModeInvertedChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.EditingModeInvertedChanged += x, x => This.EditingModeInvertedChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.InkCanvasSelectionEditingEventArgs> SelectionMoving {
            get { return Observable.FromEventPattern<System.Windows.Controls.InkCanvasSelectionEditingEventHandler, System.Windows.Controls.InkCanvasSelectionEditingEventArgs>(x => This.SelectionMoving += x, x => This.SelectionMoving -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionMoved {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionMoved += x, x => This.SelectionMoved -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.InkCanvasStrokeErasingEventArgs> StrokeErasing {
            get { return Observable.FromEventPattern<System.Windows.Controls.InkCanvasStrokeErasingEventHandler, System.Windows.Controls.InkCanvasStrokeErasingEventArgs>(x => This.StrokeErasing += x, x => This.StrokeErasing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> StrokeErased {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.StrokeErased += x, x => This.StrokeErased -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.InkCanvasSelectionEditingEventArgs> SelectionResizing {
            get { return Observable.FromEventPattern<System.Windows.Controls.InkCanvasSelectionEditingEventHandler, System.Windows.Controls.InkCanvasSelectionEditingEventArgs>(x => This.SelectionResizing += x, x => This.SelectionResizing -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionResized {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionResized += x, x => This.SelectionResized -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.InkCanvasSelectionChangingEventArgs> SelectionChanging {
            get { return Observable.FromEventPattern<System.Windows.Controls.InkCanvasSelectionChangingEventHandler, System.Windows.Controls.InkCanvasSelectionChangingEventArgs>(x => This.SelectionChanging += x, x => This.SelectionChanging -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ItemContainerGeneratorEvents
    {
        ItemContainerGenerator This;

        public ItemContainerGeneratorEvents(ItemContainerGenerator This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.Primitives.ItemsChangedEventArgs> ItemsChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.Primitives.ItemsChangedEventHandler, System.Windows.Controls.Primitives.ItemsChangedEventArgs>(x => This.ItemsChanged += x, x => This.ItemsChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> StatusChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.StatusChanged += x, x => This.StatusChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class MediaElementEvents
        : System.Windows.FrameworkElementEvents
    {
        MediaElement This;

        public MediaElementEvents(MediaElement This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.ExceptionRoutedEventArgs> MediaFailed {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.ExceptionRoutedEventArgs>, System.Windows.ExceptionRoutedEventArgs>(x => This.MediaFailed += x, x => This.MediaFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> MediaOpened {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.MediaOpened += x, x => This.MediaOpened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> BufferingStarted {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.BufferingStarted += x, x => This.BufferingStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> BufferingEnded {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.BufferingEnded += x, x => This.BufferingEnded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.MediaScriptCommandRoutedEventArgs> ScriptCommand {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.MediaScriptCommandRoutedEventArgs>, System.Windows.MediaScriptCommandRoutedEventArgs>(x => This.ScriptCommand += x, x => This.ScriptCommand -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> MediaEnded {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.MediaEnded += x, x => This.MediaEnded -= x).Select(x => x.EventArgs); }
        }

    }
    public class PasswordBoxEvents
        : System.Windows.Controls.ControlEvents
    {
        PasswordBox This;

        public PasswordBoxEvents(PasswordBox This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> PasswordChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.PasswordChanged += x, x => This.PasswordChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ScrollViewerEvents
        : System.Windows.Controls.ControlEvents
    {
        ScrollViewer This;

        public ScrollViewerEvents(ScrollViewer This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.ScrollChangedEventArgs> ScrollChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.ScrollChangedEventHandler, System.Windows.Controls.ScrollChangedEventArgs>(x => This.ScrollChanged += x, x => This.ScrollChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToolTipEvents
        : System.Windows.Controls.ControlEvents
    {
        ToolTip This;

        public ToolTipEvents(ToolTip This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Opened {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Closed {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

    }
    public class TreeViewEvents
        : System.Windows.Controls.ControlEvents
    {
        TreeView This;

        public TreeViewEvents(TreeView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedPropertyChangedEventArgs<object>> SelectedItemChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedPropertyChangedEventHandler<object>, System.Windows.RoutedPropertyChangedEventArgs<object>>(x => This.SelectedItemChanged += x, x => This.SelectedItemChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class TreeViewItemEvents
        : System.Windows.Controls.ControlEvents
    {
        TreeViewItem This;

        public TreeViewItemEvents(TreeViewItem This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Expanded {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Expanded += x, x => This.Expanded -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Collapsed {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Collapsed += x, x => This.Collapsed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Selected {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Selected += x, x => This.Selected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unselected {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Unselected += x, x => This.Unselected -= x).Select(x => x.EventArgs); }
        }

    }
    public class WebBrowserEvents
        : System.Windows.Interop.HwndHostEvents
    {
        WebBrowser This;

        public WebBrowserEvents(WebBrowser This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Navigation.NavigatingCancelEventArgs> Navigating {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(x => This.Navigating += x, x => This.Navigating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> Navigated {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.Navigated += x, x => This.Navigated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> LoadCompleted {
            get { return Observable.FromEventPattern<System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.LoadCompleted += x, x => This.LoadCompleted -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Navigation
{
    public static class EventsMixin
    {
        public static NavigationWindowEvents Events(this NavigationWindow This)
        {
            return new NavigationWindowEvents(This);
        }
        public static NavigationServiceEvents Events(this NavigationService This)
        {
            return new NavigationServiceEvents(This);
        }
    }

    public class NavigationWindowEvents
        : System.Windows.WindowEvents
    {
        NavigationWindow This;

        public NavigationWindowEvents(NavigationWindow This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Navigation.NavigatingCancelEventArgs> Navigating {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(x => This.Navigating += x, x => This.Navigating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationProgressEventArgs> NavigationProgress {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationProgressEventHandler, System.Windows.Navigation.NavigationProgressEventArgs>(x => This.NavigationProgress += x, x => This.NavigationProgress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationFailedEventArgs> NavigationFailed {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs>(x => This.NavigationFailed += x, x => This.NavigationFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> Navigated {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.Navigated += x, x => This.Navigated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> LoadCompleted {
            get { return Observable.FromEventPattern<System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.LoadCompleted += x, x => This.LoadCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> NavigationStopped {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.NavigationStopped += x, x => This.NavigationStopped -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.FragmentNavigationEventArgs> FragmentNavigation {
            get { return Observable.FromEventPattern<System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs>(x => This.FragmentNavigation += x, x => This.FragmentNavigation -= x).Select(x => x.EventArgs); }
        }

    }
    public class NavigationServiceEvents
    {
        NavigationService This;

        public NavigationServiceEvents(NavigationService This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Navigation.NavigationFailedEventArgs> NavigationFailed {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationFailedEventHandler, System.Windows.Navigation.NavigationFailedEventArgs>(x => This.NavigationFailed += x, x => This.NavigationFailed -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigatingCancelEventArgs> Navigating {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatingCancelEventHandler, System.Windows.Navigation.NavigatingCancelEventArgs>(x => This.Navigating += x, x => This.Navigating -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> Navigated {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigatedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.Navigated += x, x => This.Navigated -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationProgressEventArgs> NavigationProgress {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationProgressEventHandler, System.Windows.Navigation.NavigationProgressEventArgs>(x => This.NavigationProgress += x, x => This.NavigationProgress -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> LoadCompleted {
            get { return Observable.FromEventPattern<System.Windows.Navigation.LoadCompletedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.LoadCompleted += x, x => This.LoadCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.FragmentNavigationEventArgs> FragmentNavigation {
            get { return Observable.FromEventPattern<System.Windows.Navigation.FragmentNavigationEventHandler, System.Windows.Navigation.FragmentNavigationEventArgs>(x => This.FragmentNavigation += x, x => This.FragmentNavigation -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Navigation.NavigationEventArgs> NavigationStopped {
            get { return Observable.FromEventPattern<System.Windows.Navigation.NavigationStoppedEventHandler, System.Windows.Navigation.NavigationEventArgs>(x => This.NavigationStopped += x, x => This.NavigationStopped -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Controls.Primitives
{
    public static class EventsMixin
    {
        public static DocumentViewerBaseEvents Events(this DocumentViewerBase This)
        {
            return new DocumentViewerBaseEvents(This);
        }
        public static ButtonBaseEvents Events(this ButtonBase This)
        {
            return new ButtonBaseEvents(This);
        }
        public static ToggleButtonEvents Events(this ToggleButton This)
        {
            return new ToggleButtonEvents(This);
        }
        public static SelectorEvents Events(this Selector This)
        {
            return new SelectorEvents(This);
        }
        public static ThumbEvents Events(this Thumb This)
        {
            return new ThumbEvents(This);
        }
        public static TextBoxBaseEvents Events(this TextBoxBase This)
        {
            return new TextBoxBaseEvents(This);
        }
        public static DocumentPageViewEvents Events(this DocumentPageView This)
        {
            return new DocumentPageViewEvents(This);
        }
        public static PopupEvents Events(this Popup This)
        {
            return new PopupEvents(This);
        }
        public static RangeBaseEvents Events(this RangeBase This)
        {
            return new RangeBaseEvents(This);
        }
        public static ScrollBarEvents Events(this ScrollBar This)
        {
            return new ScrollBarEvents(This);
        }
    }

    public class DocumentViewerBaseEvents
        : System.Windows.Controls.ControlEvents
    {
        DocumentViewerBase This;

        public DocumentViewerBaseEvents(DocumentViewerBase This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> PageViewsChanged {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PageViewsChanged += x, x => This.PageViewsChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ButtonBaseEvents
        : System.Windows.Controls.ControlEvents
    {
        ButtonBase This;

        public ButtonBaseEvents(ButtonBase This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Click {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
    public class ToggleButtonEvents
        : System.Windows.Controls.Primitives.ButtonBaseEvents
    {
        ToggleButton This;

        public ToggleButtonEvents(ToggleButton This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedEventArgs> Checked {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Checked += x, x => This.Checked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Unchecked {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Unchecked += x, x => This.Unchecked -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> Indeterminate {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.Indeterminate += x, x => This.Indeterminate -= x).Select(x => x.EventArgs); }
        }

    }
    public class SelectorEvents
        : System.Windows.Controls.ControlEvents
    {
        Selector This;

        public SelectorEvents(Selector This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.SelectionChangedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.SelectionChangedEventHandler, System.Windows.Controls.SelectionChangedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ThumbEvents
        : System.Windows.Controls.ControlEvents
    {
        Thumb This;

        public ThumbEvents(Thumb This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.Primitives.DragStartedEventArgs> DragStarted {
            get { return Observable.FromEventPattern<System.Windows.Controls.Primitives.DragStartedEventHandler, System.Windows.Controls.Primitives.DragStartedEventArgs>(x => This.DragStarted += x, x => This.DragStarted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.Primitives.DragDeltaEventArgs> DragDelta {
            get { return Observable.FromEventPattern<System.Windows.Controls.Primitives.DragDeltaEventHandler, System.Windows.Controls.Primitives.DragDeltaEventArgs>(x => This.DragDelta += x, x => This.DragDelta -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Controls.Primitives.DragCompletedEventArgs> DragCompleted {
            get { return Observable.FromEventPattern<System.Windows.Controls.Primitives.DragCompletedEventHandler, System.Windows.Controls.Primitives.DragCompletedEventArgs>(x => This.DragCompleted += x, x => This.DragCompleted -= x).Select(x => x.EventArgs); }
        }

    }
    public class TextBoxBaseEvents
        : System.Windows.Controls.ControlEvents
    {
        TextBoxBase This;

        public TextBoxBaseEvents(TextBoxBase This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.TextChangedEventArgs> TextChanged {
            get { return Observable.FromEventPattern<System.Windows.Controls.TextChangedEventHandler, System.Windows.Controls.TextChangedEventArgs>(x => This.TextChanged += x, x => This.TextChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.RoutedEventArgs> SelectionChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedEventHandler, System.Windows.RoutedEventArgs>(x => This.SelectionChanged += x, x => This.SelectionChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class DocumentPageViewEvents
        : System.Windows.FrameworkElementEvents
    {
        DocumentPageView This;

        public DocumentPageViewEvents(DocumentPageView This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> PageConnected {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PageConnected += x, x => This.PageConnected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> PageDisconnected {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.PageDisconnected += x, x => This.PageDisconnected -= x).Select(x => x.EventArgs); }
        }

    }
    public class PopupEvents
        : System.Windows.FrameworkElementEvents
    {
        Popup This;

        public PopupEvents(Popup This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Opened {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Opened += x, x => This.Opened -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.EventArgs> Closed {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Closed += x, x => This.Closed -= x).Select(x => x.EventArgs); }
        }

    }
    public class RangeBaseEvents
        : System.Windows.Controls.ControlEvents
    {
        RangeBase This;

        public RangeBaseEvents(RangeBase This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.RoutedPropertyChangedEventArgs<System.Double>> ValueChanged {
            get { return Observable.FromEventPattern<System.Windows.RoutedPropertyChangedEventHandler<System.Double>, System.Windows.RoutedPropertyChangedEventArgs<System.Double>>(x => This.ValueChanged += x, x => This.ValueChanged -= x).Select(x => x.EventArgs); }
        }

    }
    public class ScrollBarEvents
        : System.Windows.Controls.Primitives.RangeBaseEvents
    {
        ScrollBar This;

        public ScrollBarEvents(ScrollBar This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Controls.Primitives.ScrollEventArgs> Scroll {
            get { return Observable.FromEventPattern<System.Windows.Controls.Primitives.ScrollEventHandler, System.Windows.Controls.Primitives.ScrollEventArgs>(x => This.Scroll += x, x => This.Scroll -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Annotations
{
    public static class EventsMixin
    {
        public static AnnotationEvents Events(this Annotation This)
        {
            return new AnnotationEvents(This);
        }
    }

    public class AnnotationEvents
    {
        Annotation This;

        public AnnotationEvents(Annotation This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Annotations.AnnotationAuthorChangedEventArgs> AuthorChanged {
            get { return Observable.FromEventPattern<System.Windows.Annotations.AnnotationAuthorChangedEventHandler, System.Windows.Annotations.AnnotationAuthorChangedEventArgs>(x => This.AuthorChanged += x, x => This.AuthorChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Annotations.AnnotationResourceChangedEventArgs> AnchorChanged {
            get { return Observable.FromEventPattern<System.Windows.Annotations.AnnotationResourceChangedEventHandler, System.Windows.Annotations.AnnotationResourceChangedEventArgs>(x => This.AnchorChanged += x, x => This.AnchorChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Annotations.AnnotationResourceChangedEventArgs> CargoChanged {
            get { return Observable.FromEventPattern<System.Windows.Annotations.AnnotationResourceChangedEventHandler, System.Windows.Annotations.AnnotationResourceChangedEventArgs>(x => This.CargoChanged += x, x => This.CargoChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Annotations.Storage
{
    public static class EventsMixin
    {
        public static AnnotationStoreEvents Events(this AnnotationStore This)
        {
            return new AnnotationStoreEvents(This);
        }
    }

    public class AnnotationStoreEvents
    {
        AnnotationStore This;

        public AnnotationStoreEvents(AnnotationStore This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Annotations.Storage.StoreContentChangedEventArgs> StoreContentChanged {
            get { return Observable.FromEventPattern<System.Windows.Annotations.Storage.StoreContentChangedEventHandler, System.Windows.Annotations.Storage.StoreContentChangedEventArgs>(x => This.StoreContentChanged += x, x => This.StoreContentChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Annotations.AnnotationAuthorChangedEventArgs> AuthorChanged {
            get { return Observable.FromEventPattern<System.Windows.Annotations.AnnotationAuthorChangedEventHandler, System.Windows.Annotations.AnnotationAuthorChangedEventArgs>(x => This.AuthorChanged += x, x => This.AuthorChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Annotations.AnnotationResourceChangedEventArgs> AnchorChanged {
            get { return Observable.FromEventPattern<System.Windows.Annotations.AnnotationResourceChangedEventHandler, System.Windows.Annotations.AnnotationResourceChangedEventArgs>(x => This.AnchorChanged += x, x => This.AnchorChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Annotations.AnnotationResourceChangedEventArgs> CargoChanged {
            get { return Observable.FromEventPattern<System.Windows.Annotations.AnnotationResourceChangedEventHandler, System.Windows.Annotations.AnnotationResourceChangedEventArgs>(x => This.CargoChanged += x, x => This.CargoChanged -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Documents.Serialization
{
    public static class EventsMixin
    {
        public static SerializerWriterEvents Events(this SerializerWriter This)
        {
            return new SerializerWriterEvents(This);
        }
    }

    public class SerializerWriterEvents
    {
        SerializerWriter This;

        public SerializerWriterEvents(SerializerWriter This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Documents.Serialization.WritingPrintTicketRequiredEventArgs> WritingPrintTicketRequired {
            get { return Observable.FromEventPattern<System.Windows.Documents.Serialization.WritingPrintTicketRequiredEventHandler, System.Windows.Documents.Serialization.WritingPrintTicketRequiredEventArgs>(x => This.WritingPrintTicketRequired += x, x => This.WritingPrintTicketRequired -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Documents.Serialization.WritingProgressChangedEventArgs> WritingProgressChanged {
            get { return Observable.FromEventPattern<System.Windows.Documents.Serialization.WritingProgressChangedEventHandler, System.Windows.Documents.Serialization.WritingProgressChangedEventArgs>(x => This.WritingProgressChanged += x, x => This.WritingProgressChanged -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Documents.Serialization.WritingCompletedEventArgs> WritingCompleted {
            get { return Observable.FromEventPattern<System.Windows.Documents.Serialization.WritingCompletedEventHandler, System.Windows.Documents.Serialization.WritingCompletedEventArgs>(x => This.WritingCompleted += x, x => This.WritingCompleted -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Documents.Serialization.WritingCancelledEventArgs> WritingCancelled {
            get { return Observable.FromEventPattern<System.Windows.Documents.Serialization.WritingCancelledEventHandler, System.Windows.Documents.Serialization.WritingCancelledEventArgs>(x => This.WritingCancelled += x, x => This.WritingCancelled -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Markup
{
    public static class EventsMixin
    {
        public static XamlReaderEvents Events(this XamlReader This)
        {
            return new XamlReaderEvents(This);
        }
    }

    public class XamlReaderEvents
    {
        XamlReader This;

        public XamlReaderEvents(XamlReader This)
        {
            this.This = This;
        }

        public IObservable<System.ComponentModel.AsyncCompletedEventArgs> LoadCompleted {
            get { return Observable.FromEventPattern<System.ComponentModel.AsyncCompletedEventHandler, System.ComponentModel.AsyncCompletedEventArgs>(x => This.LoadCompleted += x, x => This.LoadCompleted -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Markup.Localizer
{
    public static class EventsMixin
    {
        public static BamlLocalizerEvents Events(this BamlLocalizer This)
        {
            return new BamlLocalizerEvents(This);
        }
    }

    public class BamlLocalizerEvents
    {
        BamlLocalizer This;

        public BamlLocalizerEvents(BamlLocalizer This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Markup.Localizer.BamlLocalizerErrorNotifyEventArgs> ErrorNotify {
            get { return Observable.FromEventPattern<System.Windows.Markup.Localizer.BamlLocalizerErrorNotifyEventHandler, System.Windows.Markup.Localizer.BamlLocalizerErrorNotifyEventArgs>(x => This.ErrorNotify += x, x => This.ErrorNotify -= x).Select(x => x.EventArgs); }
        }

    }
}
namespace System.Windows.Shell
{
    public static class EventsMixin
    {
        public static JumpListEvents Events(this JumpList This)
        {
            return new JumpListEvents(This);
        }
        public static ThumbButtonInfoEvents Events(this ThumbButtonInfo This)
        {
            return new ThumbButtonInfoEvents(This);
        }
    }

    public class JumpListEvents
    {
        JumpList This;

        public JumpListEvents(JumpList This)
        {
            this.This = This;
        }

        public IObservable<System.Windows.Shell.JumpItemsRejectedEventArgs> JumpItemsRejected {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Shell.JumpItemsRejectedEventArgs>, System.Windows.Shell.JumpItemsRejectedEventArgs>(x => This.JumpItemsRejected += x, x => This.JumpItemsRejected -= x).Select(x => x.EventArgs); }
        }

        public IObservable<System.Windows.Shell.JumpItemsRemovedEventArgs> JumpItemsRemovedByUser {
            get { return Observable.FromEventPattern<System.EventHandler<System.Windows.Shell.JumpItemsRemovedEventArgs>, System.Windows.Shell.JumpItemsRemovedEventArgs>(x => This.JumpItemsRemovedByUser += x, x => This.JumpItemsRemovedByUser -= x).Select(x => x.EventArgs); }
        }

    }
    public class ThumbButtonInfoEvents
        : System.Windows.FreezableEvents
    {
        ThumbButtonInfo This;

        public ThumbButtonInfoEvents(ThumbButtonInfo This)
            : base(This)
        {
            this.This = This;
        }

        public IObservable<System.EventArgs> Click {
            get { return Observable.FromEventPattern<System.EventHandler, System.EventArgs>(x => This.Click += x, x => This.Click -= x).Select(x => x.EventArgs); }
        }

    }
}


#pragma warning restore 1591,0618,0105,0672

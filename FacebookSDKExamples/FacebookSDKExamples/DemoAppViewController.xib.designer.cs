// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace FacebookSDKExamples {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("DemoAppViewController")]
	public partial class DemoAppViewController {
		
		private FBButton __mt_button;
		
		private MonoTouch.UIKit.UILabel __mt_label;
		
		private MonoTouch.UIKit.UIButton __mt_publicInfoButton;
		
		private MonoTouch.UIKit.UIButton __mt_publishButton;
		
		private MonoTouch.UIKit.UIButton __mt_uploadPhotoButton;
		
		private MonoTouch.UIKit.UIButton __mt_userInfoButton;
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("button")]
		private FBButton button {
			get {
				this.__mt_button = ((FBButton)(this.GetNativeField("button")));
				return this.__mt_button;
			}
			set {
				this.__mt_button = value;
				this.SetNativeField("button", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("label")]
		private MonoTouch.UIKit.UILabel label {
			get {
				this.__mt_label = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("label")));
				return this.__mt_label;
			}
			set {
				this.__mt_label = value;
				this.SetNativeField("label", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("publicInfoButton")]
		private MonoTouch.UIKit.UIButton publicInfoButton {
			get {
				this.__mt_publicInfoButton = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("publicInfoButton")));
				return this.__mt_publicInfoButton;
			}
			set {
				this.__mt_publicInfoButton = value;
				this.SetNativeField("publicInfoButton", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("publishButton")]
		private MonoTouch.UIKit.UIButton publishButton {
			get {
				this.__mt_publishButton = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("publishButton")));
				return this.__mt_publishButton;
			}
			set {
				this.__mt_publishButton = value;
				this.SetNativeField("publishButton", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("uploadPhotoButton")]
		private MonoTouch.UIKit.UIButton uploadPhotoButton {
			get {
				this.__mt_uploadPhotoButton = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("uploadPhotoButton")));
				return this.__mt_uploadPhotoButton;
			}
			set {
				this.__mt_uploadPhotoButton = value;
				this.SetNativeField("uploadPhotoButton", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("userInfoButton")]
		private MonoTouch.UIKit.UIButton userInfoButton {
			get {
				this.__mt_userInfoButton = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("userInfoButton")));
				return this.__mt_userInfoButton;
			}
			set {
				this.__mt_userInfoButton = value;
				this.SetNativeField("userInfoButton", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UIButton or subclass
	[MonoTouch.Foundation.Register("FBButton")]
	public partial class FBButton {
	}
}
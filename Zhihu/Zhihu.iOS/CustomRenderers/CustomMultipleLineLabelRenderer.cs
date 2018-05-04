using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Zhihu.Core.Controls;
using Zhihu.iOS.CustomRenderers;

[assembly: ExportRenderer(typeof(MultipleLineLabel), typeof(CustomMultiLineLabelRenderer))]
namespace Zhihu.iOS.CustomRenderers {
    public class CustomMultiLineLabelRenderer : LabelRenderer {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e) {
            base.OnElementChanged(e);

            MultipleLineLabel multiLineLabel = (MultipleLineLabel)Element;

            if (multiLineLabel != null && multiLineLabel.Lines != -1)
                Control.Lines = multiLineLabel.Lines;
        }
    }
}
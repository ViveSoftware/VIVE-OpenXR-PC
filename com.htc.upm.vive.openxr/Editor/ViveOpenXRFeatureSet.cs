// Copyright HTC Corporation All Rights Reserved.
#if UNITY_EDITOR

using UnityEditor;
using UnityEditor.XR.OpenXR.Features;

namespace VIVE.OpenXR
{
	[OpenXRFeatureSet(
		FeatureIds = new string[] {
			VIVEFocus3Feature.featureId,
			VIVEFocus3Profile.featureId,
			Hand.ViveHandTracking.featureId,
			"vive.openxr.feature.compositionlayer",
			"vive.openxr.feature.compositionlayer.cylinder",
			"vive.openxr.feature.compositionlayer.colorscalebias",
			Tracker.ViveWristTracker.featureId,
			Hand.ViveHandInteraction.featureId,
			"vive.openxr.feature.foveation",
			FacialTracking.ViveFacialTracking.featureId,
			PlaneDetection.VivePlaneDetection.featureId,
			VivePathEnumeration.featureId,
			Feature.ViveAnchor.featureId,
			DisplayRefreshRate.ViveDisplayRefreshRate.featureId,
			Passthrough.VivePassthrough.featureId,
			FirstPersonObserver.ViveFirstPersonObserver.FeatureId,
			SecondaryViewConfiguration.ViveSecondaryViewConfiguration.FeatureId,
			UserPresence.ViveUserPresence.featureId,
			CompositionLayer.ViveCompositionLayerExtraSettings.featureId,
			FrameSynchronization.ViveFrameSynchronization.featureId,
			EyeTracker.ViveEyeTracker.featureId,
			Feature.ViveMockRuntime.featureId,
			Interaction.ViveInteractions.featureId,
		},
		UiName = "VIVE XR Support",
		Description = "Necessary to deploy a VIVE XR compatible app.",
		FeatureSetId = "com.htc.vive.openxr.featureset.vivexr",
#if UNITY_ANDROID
		DefaultFeatureIds = new string[] { VIVEFocus3Feature.featureId, VIVEFocus3Profile.featureId, },
#endif
		SupportedBuildTargets = new BuildTargetGroup[] { BuildTargetGroup.Android, BuildTargetGroup.Standalone }
	)]
	sealed class ViveOpenXRFeatureSet { }
}
#endif

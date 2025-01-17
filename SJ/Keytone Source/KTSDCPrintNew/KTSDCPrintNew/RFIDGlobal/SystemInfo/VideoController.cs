﻿namespace ROOT.CIMV2.Win32 {
    using System;
    using System.ComponentModel;
    using System.Management;
    using System.Collections;
    using System.Globalization;
    
    
    // Functions ShouldSerialize<PropertyName> are functions used by VS property browser to check if a particular property has to be serialized. These functions are added for all ValueType properties ( properties of type Int32, BOOL etc.. which cannot be set to null). These functions use Is<PropertyName>Null function. These functions are also used in the TypeConverter implementation for the properties to check for NULL value of property so that an empty value can be shown in Property browser in case of Drag and Drop in Visual studio.
    // Functions Is<PropertyName>Null() are used to check if a property is NULL.
    // Functions Reset<PropertyName> are added for Nullable Read/Write properties. These functions are used by VS designer in property browser to set a property to NULL.
    // Every property added to the class for WMI property has attributes set to define its behavior in Visual Studio designer and also to define a TypeConverter to be used.
    // Datetime conversion functions ToDateTime and ToDmtfDateTime are added to the class to convert DMTF datetime to System.DateTime and vice-versa.
    // An Early Bound class generated for the WMI class.Win32_VideoController
    public class VideoController : System.ComponentModel.Component {
        
        // Private property to hold the WMI namespace in which the class resides.
        private static string CreatedWmiNamespace = "root\\cimv2";
        
        // Private property to hold the name of WMI class which created this class.
        private static string CreatedClassName = "Win32_VideoController";
        
        // Private member variable to hold the ManagementScope which is used by the various methods.
        private static System.Management.ManagementScope statMgmtScope = null;
        
        private ManagementSystemProperties PrivateSystemProperties;
        
        // Underlying lateBound WMI object.
        private System.Management.ManagementObject PrivateLateBoundObject;
        
        // Member variable to store the 'automatic commit' behavior for the class.
        private bool AutoCommitProp;
        
        // Private variable to hold the embedded property representing the instance.
        private System.Management.ManagementBaseObject embeddedObj;
        
        // The current WMI object used
        private System.Management.ManagementBaseObject curObj;
        
        // Flag to indicate if the instance is an embedded object.
        private bool isEmbedded;
        
        // Below are different overloads of constructors to initialize an instance of the class with a WMI object.
        public VideoController() {
            this.InitializeObject(null, null, null);
        }
        
        public VideoController(string keyDeviceID) {
            this.InitializeObject(null, new System.Management.ManagementPath(VideoController.ConstructPath(keyDeviceID)), null);
        }
        
        public VideoController(System.Management.ManagementScope mgmtScope, string keyDeviceID) {
            this.InitializeObject(((System.Management.ManagementScope)(mgmtScope)), new System.Management.ManagementPath(VideoController.ConstructPath(keyDeviceID)), null);
        }
        
        public VideoController(System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            this.InitializeObject(null, path, getOptions);
        }
        
        public VideoController(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path) {
            this.InitializeObject(mgmtScope, path, null);
        }
        
        public VideoController(System.Management.ManagementPath path) {
            this.InitializeObject(null, path, null);
        }
        
        public VideoController(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            this.InitializeObject(mgmtScope, path, getOptions);
        }
        
        public VideoController(System.Management.ManagementObject theObject) {
            Initialize();
            if ((CheckIfProperClass(theObject) == true)) {
                PrivateLateBoundObject = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
                curObj = PrivateLateBoundObject;
            }
            else {
                throw new System.ArgumentException("Class name does not match.");
            }
        }
        
        public VideoController(System.Management.ManagementBaseObject theObject) {
            Initialize();
            if ((CheckIfProperClass(theObject) == true)) {
                embeddedObj = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(theObject);
                curObj = embeddedObj;
                isEmbedded = true;
            }
            else {
                throw new System.ArgumentException("Class name does not match.");
            }
        }
        
        // Property returns the namespace of the WMI class.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string OriginatingNamespace {
            get {
                return "root\\cimv2";
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ManagementClassName {
            get {
                string strRet = CreatedClassName;
                if ((curObj != null)) {
                    if ((curObj.ClassPath != null)) {
                        strRet = ((string)(curObj["__CLASS"]));
                        if (((strRet == null) 
                                    || (strRet == string.Empty))) {
                            strRet = CreatedClassName;
                        }
                    }
                }
                return strRet;
            }
        }
        
        // Property pointing to an embedded object to get System properties of the WMI object.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ManagementSystemProperties SystemProperties {
            get {
                return PrivateSystemProperties;
            }
        }
        
        // Property returning the underlying lateBound object.
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public System.Management.ManagementBaseObject LateBoundObject {
            get {
                return curObj;
            }
        }
        
        // ManagementScope of the object.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public System.Management.ManagementScope Scope {
            get {
                if ((isEmbedded == false)) {
                    return PrivateLateBoundObject.Scope;
                }
                else {
                    return null;
                }
            }
            set {
                if ((isEmbedded == false)) {
                    PrivateLateBoundObject.Scope = value;
                }
            }
        }
        
        // Property to show the commit behavior for the WMI object. If true, WMI object will be automatically saved after each property modification.(ie. Put() is called after modification of a property).
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AutoCommit {
            get {
                return AutoCommitProp;
            }
            set {
                AutoCommitProp = value;
            }
        }
        
        // The ManagementPath of the underlying WMI object.
        [Browsable(true)]
        public System.Management.ManagementPath Path {
            get {
                if ((isEmbedded == false)) {
                    return PrivateLateBoundObject.Path;
                }
                else {
                    return null;
                }
            }
            set {
                if ((isEmbedded == false)) {
                    if ((CheckIfProperClass(null, value, null) != true)) {
                        throw new System.ArgumentException("Class name does not match.");
                    }
                    PrivateLateBoundObject.Path = value;
                }
            }
        }
        
        // Public static scope property which is used by the various methods.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static System.Management.ManagementScope StaticScope {
            get {
                return statMgmtScope;
            }
            set {
                statMgmtScope = value;
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("An array of integers indicating the graphics and 3D capabilities of the video con" +
            "troller.")]
        public AcceleratorCapabilitiesValues[] AcceleratorCapabilities {
            get {
                System.Array arrEnumVals = ((System.Array)(curObj["AcceleratorCapabilities"]));
                AcceleratorCapabilitiesValues[] enumToRet = new AcceleratorCapabilitiesValues[arrEnumVals.Length];
                int counter = 0;
                for (counter = 0; (counter < arrEnumVals.Length); counter = (counter + 1)) {
                    enumToRet[counter] = ((AcceleratorCapabilitiesValues)(System.Convert.ToInt32(arrEnumVals.GetValue(counter))));
                }
                return enumToRet;
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The AdapterCompatibility properties contains the general chip set used for this c" +
            "ontroller in order to compare compatibilities with the system")]
        public string AdapterCompatibility {
            get {
                return ((string)(curObj["AdapterCompatibility"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The AdapterDACType property contains a string of the Digital-to-Analog converter " +
            "(DAC) chip name or ID.\nCharacter Set: Alphanumeric")]
        public string AdapterDACType {
            get {
                return ((string)(curObj["AdapterDACType"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAdapterRAMNull {
            get {
                if ((curObj["AdapterRAM"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The AdapterRAM property indicates the memory size of the video adapter. \nExample:" +
            " 64000")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint AdapterRAM {
            get {
                if ((curObj["AdapterRAM"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["AdapterRAM"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAvailabilityNull {
            get {
                if ((curObj["Availability"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The availability and status of the device.  For example, the Availability property indicates that the device is running and has full power (value=3), or is in a warning (4), test (5), degraded (10) or power save state (values 13-15 and 17). Regarding the power saving states, these are defined as follows: Value 13 (""Power Save - Unknown"") indicates that the device is known to be in a power save mode, but its exact status in this mode is unknown; 14 (""Power Save - Low Power Mode"") indicates that the device is in a power save state but still functioning, and may exhibit degraded performance; 15 (""Power Save - Standby"") describes that the device is not functioning but could be brought to full power 'quickly'; and value 17 (""Power Save - Warning"") indicates that the device is in a warning state, though also in a power save mode.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public AvailabilityValues Availability {
            get {
                if ((curObj["Availability"] == null)) {
                    return ((AvailabilityValues)(System.Convert.ToInt32(0)));
                }
                return ((AvailabilityValues)(System.Convert.ToInt32(curObj["Availability"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"An array of free-form strings providing more detailed explanations for any of the video accelerator features indicated in the Capabilities array. Note, each entry of this array is related to the entry in the Capabilities array that is located at the same index.")]
        public string[] CapabilityDescriptions {
            get {
                return ((string[])(curObj["CapabilityDescriptions"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Caption property is a short textual description (one-line string) of the obje" +
            "ct.")]
        public string Caption {
            get {
                return ((string)(curObj["Caption"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsColorTableEntriesNull {
            get {
                if ((curObj["ColorTableEntries"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The ColorTableEntries property indicates the size of the system\'s color table, if" +
            " the device has a color depth of no more than 8 bits per pixel, null otherwise. " +
            "<P>Example: 256")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint ColorTableEntries {
            get {
                if ((curObj["ColorTableEntries"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["ColorTableEntries"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsConfigManagerErrorCodeNull {
            get {
                if ((curObj["ConfigManagerErrorCode"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indicates the Win32 Configuration Manager error code.  The following values may b" +
            "e returned: \n0\tThis device is working properly. \n1\tThis device is not configured" +
            " correctly. \n2\tWindows cannot load the driver for this device. \n3\tThe driver for" +
            " this device might be corrupted, or your system may be running low on memory or " +
            "other resources. \n4\tThis device is not working properly. One of its drivers or y" +
            "our registry might be corrupted. \n5\tThe driver for this device needs a resource " +
            "that Windows cannot manage. \n6\tThe boot configuration for this device conflicts " +
            "with other devices. \n7\tCannot filter. \n8\tThe driver loader for the device is mis" +
            "sing. \n9\tThis device is not working properly because the controlling firmware is" +
            " reporting the resources for the device incorrectly. \n10\tThis device cannot star" +
            "t. \n11\tThis device failed. \n12\tThis device cannot find enough free resources tha" +
            "t it can use. \n13\tWindows cannot verify this device\'s resources. \n14\tThis device" +
            " cannot work properly until you restart your computer. \n15\tThis device is not wo" +
            "rking properly because there is probably a re-enumeration problem. \n16\tWindows c" +
            "annot identify all the resources this device uses. \n17\tThis device is asking for" +
            " an unknown resource type. \n18\tReinstall the drivers for this device. \n19\tYour r" +
            "egistry might be corrupted. \n20\tFailure using the VxD loader. \n21\tSystem failure" +
            ": Try changing the driver for this device. If that does not work, see your hardw" +
            "are documentation. Windows is removing this device. \n22\tThis device is disabled." +
            " \n23\tSystem failure: Try changing the driver for this device. If that doesn\'t wo" +
            "rk, see your hardware documentation. \n24\tThis device is not present, is not work" +
            "ing properly, or does not have all its drivers installed. \n25\tWindows is still s" +
            "etting up this device. \n26\tWindows is still setting up this device. \n27\tThis dev" +
            "ice does not have valid log configuration. \n28\tThe drivers for this device are n" +
            "ot installed. \n29\tThis device is disabled because the firmware of the device did" +
            " not give it the required resources. \n30\tThis device is using an Interrupt Reque" +
            "st (IRQ) resource that another device is using. \n31\tThis device is not working p" +
            "roperly because Windows cannot load the drivers required for this device.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ConfigManagerErrorCodeValues ConfigManagerErrorCode {
            get {
                if ((curObj["ConfigManagerErrorCode"] == null)) {
                    return ((ConfigManagerErrorCodeValues)(System.Convert.ToInt32(32)));
                }
                return ((ConfigManagerErrorCodeValues)(System.Convert.ToInt32(curObj["ConfigManagerErrorCode"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsConfigManagerUserConfigNull {
            get {
                if ((curObj["ConfigManagerUserConfig"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indicates whether the device is using a user-defined configuration.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool ConfigManagerUserConfig {
            get {
                if ((curObj["ConfigManagerUserConfig"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["ConfigManagerUserConfig"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("CreationClassName indicates the name of the class or the subclass used in the cre" +
            "ation of an instance. When used with the other key properties of this class, thi" +
            "s property allows all instances of this class and its subclasses to be uniquely " +
            "identified.")]
        public string CreationClassName {
            get {
                return ((string)(curObj["CreationClassName"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCurrentBitsPerPixelNull {
            get {
                if ((curObj["CurrentBitsPerPixel"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The number of bits used to display each pixel.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint CurrentBitsPerPixel {
            get {
                if ((curObj["CurrentBitsPerPixel"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["CurrentBitsPerPixel"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCurrentHorizontalResolutionNull {
            get {
                if ((curObj["CurrentHorizontalResolution"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Current number of horizontal pixels.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint CurrentHorizontalResolution {
            get {
                if ((curObj["CurrentHorizontalResolution"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["CurrentHorizontalResolution"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCurrentNumberOfColorsNull {
            get {
                if ((curObj["CurrentNumberOfColors"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Number of colors supported at the current resolutions.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ulong CurrentNumberOfColors {
            get {
                if ((curObj["CurrentNumberOfColors"] == null)) {
                    return System.Convert.ToUInt64(0);
                }
                return ((ulong)(curObj["CurrentNumberOfColors"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCurrentNumberOfColumnsNull {
            get {
                if ((curObj["CurrentNumberOfColumns"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("If in character mode, number of columns for this video controller. Otherwise, ent" +
            "er 0.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint CurrentNumberOfColumns {
            get {
                if ((curObj["CurrentNumberOfColumns"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["CurrentNumberOfColumns"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCurrentNumberOfRowsNull {
            get {
                if ((curObj["CurrentNumberOfRows"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("If in character mode, number of rows for this video controller. Otherwise, enter " +
            "0.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint CurrentNumberOfRows {
            get {
                if ((curObj["CurrentNumberOfRows"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["CurrentNumberOfRows"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCurrentRefreshRateNull {
            get {
                if ((curObj["CurrentRefreshRate"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The CurrentRefreshRate property specifies the frequency at which the video contro" +
            "ller refreshes the image for the monitor. A value of 0 indicates the default rat" +
            "e is being used, while 0xFFFFFFFF indicates the optimal rate is being used.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint CurrentRefreshRate {
            get {
                if ((curObj["CurrentRefreshRate"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["CurrentRefreshRate"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCurrentScanModeNull {
            get {
                if ((curObj["CurrentScanMode"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Current scan mode. \"Interlaced\" (value=3) or \"Non Interlaced\" (4) can be defined " +
            "using this property.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public CurrentScanModeValues CurrentScanMode {
            get {
                if ((curObj["CurrentScanMode"] == null)) {
                    return ((CurrentScanModeValues)(System.Convert.ToInt32(0)));
                }
                return ((CurrentScanModeValues)(System.Convert.ToInt32(curObj["CurrentScanMode"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCurrentVerticalResolutionNull {
            get {
                if ((curObj["CurrentVerticalResolution"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Current number of vertical pixels.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint CurrentVerticalResolution {
            get {
                if ((curObj["CurrentVerticalResolution"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["CurrentVerticalResolution"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Description property provides a textual description of the object. ")]
        public string Description {
            get {
                return ((string)(curObj["Description"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The DeviceID property contains a identifier (unique to the computer system) for t" +
            "his video controller.")]
        public string DeviceID {
            get {
                return ((string)(curObj["DeviceID"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDeviceSpecificPensNull {
            get {
                if ((curObj["DeviceSpecificPens"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The DeviceSpecificPens property indicates the current number of device-specific p" +
            "ens.  0xffff means the device does not support pens. \nExample: 3")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint DeviceSpecificPens {
            get {
                if ((curObj["DeviceSpecificPens"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["DeviceSpecificPens"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDitherTypeNull {
            get {
                if ((curObj["DitherType"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The DitherType property indicates the dither type of the video controller.  The property can be one of the following predefined values, or a driver-defined value greater than or equal to 256: Value Meaning :-1	-	No dithering. 2	-	Dithering with a coarse brush. 3	-	Dithering with a fine brush. 4	-	Line art dithering; a special dithering 		method that produces well defined borders 		between black, white, and gray scalings. 		It is not suitable for images that include 		continuous graduations in intensity and 		hue such as scanned photographs. 5	-	Device does grayscaling. ")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public DitherTypeValues DitherType {
            get {
                if ((curObj["DitherType"] == null)) {
                    return ((DitherTypeValues)(System.Convert.ToInt32(0)));
                }
                return ((DitherTypeValues)(System.Convert.ToInt32(curObj["DitherType"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDriverDateNull {
            get {
                if ((curObj["DriverDate"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The DriverDate property indicates the last modification date and time of the curr" +
            "ently-installed video driver.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime DriverDate {
            get {
                if ((curObj["DriverDate"] != null)) {
                    return ToDateTime(((string)(curObj["DriverDate"])));
                }
                else {
                    return System.DateTime.MinValue;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The DriverVersion property indicates the version number of the video driver.")]
        public string DriverVersion {
            get {
                return ((string)(curObj["DriverVersion"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsErrorClearedNull {
            get {
                if ((curObj["ErrorCleared"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("ErrorCleared is a boolean property indicating that the error reported in LastErro" +
            "rCode property is now cleared.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool ErrorCleared {
            get {
                if ((curObj["ErrorCleared"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["ErrorCleared"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("ErrorDescription is a free-form string supplying more information about the error" +
            " recorded in LastErrorCode property, and information on any corrective actions t" +
            "hat may be taken.")]
        public string ErrorDescription {
            get {
                return ((string)(curObj["ErrorDescription"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsICMIntentNull {
            get {
                if ((curObj["ICMIntent"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The ICMIntent ( Image Color Matching Intent ) property indicates the specific value of one of the three possible color matching methods, (or intents) that should be used by default. This property is primarily for non-ICM applications. ICM applications establish intents by using the ICM functions. This property can be one of the following predefined values, or a driver defined value greater than or equal to 256.Value Meaning :-1	-	Color matching should optimize for color saturation. This value 		is the most appropriate choice for business graphs when dithering 		is not desired. 2	-	Color matching should optimize for color contrast. This value 		is the most appropriate choice for scanned or photographic images 		when dithering is desired. 3	-	Color matching should optimize to match the exact color requested. 		This value is most appropriate for use with business logos or other 		images when an exact color match is required. ")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ICMIntentValues ICMIntent {
            get {
                if ((curObj["ICMIntent"] == null)) {
                    return ((ICMIntentValues)(System.Convert.ToInt32(0)));
                }
                return ((ICMIntentValues)(System.Convert.ToInt32(curObj["ICMIntent"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsICMMethodNull {
            get {
                if ((curObj["ICMMethod"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The ICMMethod ( Image Color Matching Method ) property specifies how ICM is handled. For a non-ICM application, this property shows howICM is enabled. For ICM applications, the system examines this member to determine how to handle ICM support. This property can be one of the following predefined values, or a driver-defined value greater than or equal to 256.Value Meaning :-1	-	Specifies that ICM is disabled. 2	-	Specifies that ICM is handled by Windows. 3	-	Specifies that ICM is handled by the device driver. 4	-	Specifies that ICM is handled by the destination device. ")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ICMMethodValues ICMMethod {
            get {
                if ((curObj["ICMMethod"] == null)) {
                    return ((ICMMethodValues)(System.Convert.ToInt32(0)));
                }
                return ((ICMMethodValues)(System.Convert.ToInt32(curObj["ICMMethod"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The InfFilename property indicates the path to the video adapter\'s .INF file. \nEx" +
            "ample: C:\\WINNT\\SYSTEM32\\DRIVERS")]
        public string InfFilename {
            get {
                return ((string)(curObj["InfFilename"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The InfSection property indicates the section of the .INF file where the Win32 vi" +
            "deo information resides.")]
        public string InfSection {
            get {
                return ((string)(curObj["InfSection"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsInstallDateNull {
            get {
                if ((curObj["InstallDate"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The InstallDate property is datetime value indicating when the object was install" +
            "ed. A lack of a value does not indicate that the object is not installed.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime InstallDate {
            get {
                if ((curObj["InstallDate"] != null)) {
                    return ToDateTime(((string)(curObj["InstallDate"])));
                }
                else {
                    return System.DateTime.MinValue;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The InstalledDisplayDrivers property indicates the name of the installed display " +
            "device driver.")]
        public string InstalledDisplayDrivers {
            get {
                return ((string)(curObj["InstalledDisplayDrivers"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLastErrorCodeNull {
            get {
                if ((curObj["LastErrorCode"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("LastErrorCode captures the last error code reported by the logical device.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint LastErrorCode {
            get {
                if ((curObj["LastErrorCode"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["LastErrorCode"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMaxMemorySupportedNull {
            get {
                if ((curObj["MaxMemorySupported"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Maximum amount of memory supported in bytes.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MaxMemorySupported {
            get {
                if ((curObj["MaxMemorySupported"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["MaxMemorySupported"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMaxNumberControlledNull {
            get {
                if ((curObj["MaxNumberControlled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Maximum number of directly addressable entities supported by this Controller.  A " +
            "value of 0 should be used if the number is unknown or unlimited.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MaxNumberControlled {
            get {
                if ((curObj["MaxNumberControlled"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["MaxNumberControlled"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMaxRefreshRateNull {
            get {
                if ((curObj["MaxRefreshRate"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Maximum refresh rate of the video controller in Hertz.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MaxRefreshRate {
            get {
                if ((curObj["MaxRefreshRate"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["MaxRefreshRate"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMinRefreshRateNull {
            get {
                if ((curObj["MinRefreshRate"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Minimum refresh rate of the video controller in Hertz.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MinRefreshRate {
            get {
                if ((curObj["MinRefreshRate"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["MinRefreshRate"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMonochromeNull {
            get {
                if ((curObj["Monochrome"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Monochrome property indicates whether gray scale or color is used to display " +
            "images.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Monochrome {
            get {
                if ((curObj["Monochrome"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Monochrome"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Name property defines the label by which the object is known. When subclassed" +
            ", the Name property can be overridden to be a Key property.")]
        public string Name {
            get {
                return ((string)(curObj["Name"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsNumberOfColorPlanesNull {
            get {
                if ((curObj["NumberOfColorPlanes"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Current number of color planes.  If this value is not applicable for the current " +
            "video configuration, enter 0.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ushort NumberOfColorPlanes {
            get {
                if ((curObj["NumberOfColorPlanes"] == null)) {
                    return System.Convert.ToUInt16(0);
                }
                return ((ushort)(curObj["NumberOfColorPlanes"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsNumberOfVideoPagesNull {
            get {
                if ((curObj["NumberOfVideoPages"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Number of video pages supported given the current resolutions and available memor" +
            "y.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint NumberOfVideoPages {
            get {
                if ((curObj["NumberOfVideoPages"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["NumberOfVideoPages"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indicates the Win32 Plug and Play device ID of the logical device.  Example: *PNP" +
            "030b")]
        public string PNPDeviceID {
            get {
                return ((string)(curObj["PNPDeviceID"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Indicates the specific power-related capabilities of the logical device. The array values, 0=""Unknown"", 1=""Not Supported"" and 2=""Disabled"" are self-explanatory. The value, 3=""Enabled"" indicates that the power management features are currently enabled but the exact feature set is unknown or the information is unavailable. ""Power Saving Modes Entered Automatically"" (4) describes that a device can change its power state based on usage or other criteria. ""Power State Settable"" (5) indicates that the SetPowerState method is supported. ""Power Cycling Supported"" (6) indicates that the SetPowerState method can be invoked with the PowerState input variable set to 5 (""Power Cycle""). ""Timed Power On Supported"" (7) indicates that the SetPowerState method can be invoked with the PowerState input variable set to 5 (""Power Cycle"") and the Time parameter set to a specific date and time, or interval, for power-on.")]
        public PowerManagementCapabilitiesValues[] PowerManagementCapabilities {
            get {
                System.Array arrEnumVals = ((System.Array)(curObj["PowerManagementCapabilities"]));
                PowerManagementCapabilitiesValues[] enumToRet = new PowerManagementCapabilitiesValues[arrEnumVals.Length];
                int counter = 0;
                for (counter = 0; (counter < arrEnumVals.Length); counter = (counter + 1)) {
                    enumToRet[counter] = ((PowerManagementCapabilitiesValues)(System.Convert.ToInt32(arrEnumVals.GetValue(counter))));
                }
                return enumToRet;
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPowerManagementSupportedNull {
            get {
                if ((curObj["PowerManagementSupported"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Boolean indicating that the Device can be power managed - ie, put into a power save state. This boolean does not indicate that power management features are currently enabled, or if enabled, what features are supported. Refer to the PowerManagementCapabilities array for this information. If this boolean is false, the integer value 1, for the string, ""Not Supported"", should be the only entry in the PowerManagementCapabilities array.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool PowerManagementSupported {
            get {
                if ((curObj["PowerManagementSupported"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["PowerManagementSupported"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsProtocolSupportedNull {
            get {
                if ((curObj["ProtocolSupported"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The protocol used by the controller to access \'controlled\' devices.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ProtocolSupportedValues ProtocolSupported {
            get {
                if ((curObj["ProtocolSupported"] == null)) {
                    return ((ProtocolSupportedValues)(System.Convert.ToInt32(0)));
                }
                return ((ProtocolSupportedValues)(System.Convert.ToInt32(curObj["ProtocolSupported"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsReservedSystemPaletteEntriesNull {
            get {
                if ((curObj["ReservedSystemPaletteEntries"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The ReservedSystemPaletteEntries property indicates the current number of reserved entries in a system's color table. The operating system may reserve entries to support standard colors for task bars and other desktop display items. If the system is not using a palette, then ReservedSystemPaletteEntries is null.<P>Example: 24.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint ReservedSystemPaletteEntries {
            get {
                if ((curObj["ReservedSystemPaletteEntries"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["ReservedSystemPaletteEntries"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsSpecificationVersionNull {
            get {
                if ((curObj["SpecificationVersion"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The SpecificationVersion property indicates the version number of the initializat" +
            "ion data specification (upon which the structure is based).")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint SpecificationVersion {
            get {
                if ((curObj["SpecificationVersion"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["SpecificationVersion"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The Status property is a string indicating the current status of the object. Various operational and non-operational statuses can be defined. Operational statuses are ""OK"", ""Degraded"" and ""Pred Fail"". ""Pred Fail"" indicates that an element may be functioning properly but predicting a failure in the near future. An example is a SMART-enabled hard drive. Non-operational statuses can also be specified. These are ""Error"", ""Starting"", ""Stopping"" and ""Service"". The latter, ""Service"", could apply during mirror-resilvering of a disk, reload of a user permissions list, or other administrative work. Not all such work is on-line, yet the managed element is neither ""OK"" nor in one of the other states.")]
        public string Status {
            get {
                return ((string)(curObj["Status"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsStatusInfoNull {
            get {
                if ((curObj["StatusInfo"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("StatusInfo is a string indicating whether the logical device is in an enabled (va" +
            "lue = 3), disabled (value = 4) or some other (1) or unknown (2) state. If this p" +
            "roperty does not apply to the logical device, the value, 5 (\"Not Applicable\"), s" +
            "hould be used.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public StatusInfoValues StatusInfo {
            get {
                if ((curObj["StatusInfo"] == null)) {
                    return ((StatusInfoValues)(System.Convert.ToInt32(0)));
                }
                return ((StatusInfoValues)(System.Convert.ToInt32(curObj["StatusInfo"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The scoping System\'s CreationClassName.")]
        public string SystemCreationClassName {
            get {
                return ((string)(curObj["SystemCreationClassName"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The scoping System\'s Name.")]
        public string SystemName {
            get {
                return ((string)(curObj["SystemName"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsSystemPaletteEntriesNull {
            get {
                if ((curObj["SystemPaletteEntries"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The SystemPaletteEntries property indicates the current number of entries in a sy" +
            "stem\'s color table. If the system is not using a palette then SystemPaletteEntri" +
            "es is null.<P>Example: 256")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint SystemPaletteEntries {
            get {
                if ((curObj["SystemPaletteEntries"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["SystemPaletteEntries"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTimeOfLastResetNull {
            get {
                if ((curObj["TimeOfLastReset"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The TimeOfLastReset property indicates the date and time this controller was last" +
            " reset.  This could mean the controller was powered down, or reinitialized.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime TimeOfLastReset {
            get {
                if ((curObj["TimeOfLastReset"] != null)) {
                    return ToDateTime(((string)(curObj["TimeOfLastReset"])));
                }
                else {
                    return System.DateTime.MinValue;
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsVideoArchitectureNull {
            get {
                if ((curObj["VideoArchitecture"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The video architecture.  For example, VGA (value=5) or PC-98 (160) may be specifi" +
            "ed.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public VideoArchitectureValues VideoArchitecture {
            get {
                if ((curObj["VideoArchitecture"] == null)) {
                    return ((VideoArchitectureValues)(System.Convert.ToInt32(0)));
                }
                return ((VideoArchitectureValues)(System.Convert.ToInt32(curObj["VideoArchitecture"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsVideoMemoryTypeNull {
            get {
                if ((curObj["VideoMemoryType"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("An integer enumeration indicating the type of video memory.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public VideoMemoryTypeValues VideoMemoryType {
            get {
                if ((curObj["VideoMemoryType"] == null)) {
                    return ((VideoMemoryTypeValues)(System.Convert.ToInt32(0)));
                }
                return ((VideoMemoryTypeValues)(System.Convert.ToInt32(curObj["VideoMemoryType"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsVideoModeNull {
            get {
                if ((curObj["VideoMode"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Current video mode.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ushort VideoMode {
            get {
                if ((curObj["VideoMode"] == null)) {
                    return System.Convert.ToUInt16(0);
                }
                return ((ushort)(curObj["VideoMode"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The VideoModeDescription property indicates the current resolution, color, and sc" +
            "an mode settings of the video controller. \nExample: 1024 x 768 x 256 colors.")]
        public string VideoModeDescription {
            get {
                return ((string)(curObj["VideoModeDescription"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("A free-form string describing the video processor/Controller.")]
        public string VideoProcessor {
            get {
                return ((string)(curObj["VideoProcessor"]));
            }
        }
        
        private bool CheckIfProperClass(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions OptionsParam) {
            if (((path != null) 
                        && (string.Compare(path.ClassName, this.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) == 0))) {
                return true;
            }
            else {
                return CheckIfProperClass(new System.Management.ManagementObject(mgmtScope, path, OptionsParam));
            }
        }
        
        private bool CheckIfProperClass(System.Management.ManagementBaseObject theObj) {
            if (((theObj != null) 
                        && (string.Compare(((string)(theObj["__CLASS"])), this.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) == 0))) {
                return true;
            }
            else {
                System.Array parentClasses = ((System.Array)(theObj["__DERIVATION"]));
                if ((parentClasses != null)) {
                    int count = 0;
                    for (count = 0; (count < parentClasses.Length); count = (count + 1)) {
                        if ((string.Compare(((string)(parentClasses.GetValue(count))), this.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) == 0)) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        
        private bool ShouldSerializeAdapterRAM() {
            if ((this.IsAdapterRAMNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeAvailability() {
            if ((this.IsAvailabilityNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeColorTableEntries() {
            if ((this.IsColorTableEntriesNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeConfigManagerErrorCode() {
            if ((this.IsConfigManagerErrorCodeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeConfigManagerUserConfig() {
            if ((this.IsConfigManagerUserConfigNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCurrentBitsPerPixel() {
            if ((this.IsCurrentBitsPerPixelNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCurrentHorizontalResolution() {
            if ((this.IsCurrentHorizontalResolutionNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCurrentNumberOfColors() {
            if ((this.IsCurrentNumberOfColorsNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCurrentNumberOfColumns() {
            if ((this.IsCurrentNumberOfColumnsNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCurrentNumberOfRows() {
            if ((this.IsCurrentNumberOfRowsNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCurrentRefreshRate() {
            if ((this.IsCurrentRefreshRateNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCurrentScanMode() {
            if ((this.IsCurrentScanModeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCurrentVerticalResolution() {
            if ((this.IsCurrentVerticalResolutionNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDeviceSpecificPens() {
            if ((this.IsDeviceSpecificPensNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDitherType() {
            if ((this.IsDitherTypeNull == false)) {
                return true;
            }
            return false;
        }
        
        // Converts a given datetime in DMTF format to System.DateTime object.
        static System.DateTime ToDateTime(string dmtfDate) {
            System.DateTime initializer = System.DateTime.MinValue;
            int year = initializer.Year;
            int month = initializer.Month;
            int day = initializer.Day;
            int hour = initializer.Hour;
            int minute = initializer.Minute;
            int second = initializer.Second;
            long ticks = 0;
            string dmtf = dmtfDate;
            System.DateTime datetime = System.DateTime.MinValue;
            string tempString = string.Empty;
            if ((dmtf == null)) {
                throw new System.ArgumentOutOfRangeException();
            }
            if ((dmtf.Length == 0)) {
                throw new System.ArgumentOutOfRangeException();
            }
            if ((dmtf.Length != 25)) {
                throw new System.ArgumentOutOfRangeException();
            }
            try {
                tempString = dmtf.Substring(0, 4);
                if (("****" != tempString)) {
                    year = int.Parse(tempString);
                }
                tempString = dmtf.Substring(4, 2);
                if (("**" != tempString)) {
                    month = int.Parse(tempString);
                }
                tempString = dmtf.Substring(6, 2);
                if (("**" != tempString)) {
                    day = int.Parse(tempString);
                }
                tempString = dmtf.Substring(8, 2);
                if (("**" != tempString)) {
                    hour = int.Parse(tempString);
                }
                tempString = dmtf.Substring(10, 2);
                if (("**" != tempString)) {
                    minute = int.Parse(tempString);
                }
                tempString = dmtf.Substring(12, 2);
                if (("**" != tempString)) {
                    second = int.Parse(tempString);
                }
                tempString = dmtf.Substring(15, 6);
                if (("******" != tempString)) {
                    ticks = (long.Parse(tempString) * ((long)((System.TimeSpan.TicksPerMillisecond / 1000))));
                }
                if (((((((((year < 0) 
                            || (month < 0)) 
                            || (day < 0)) 
                            || (hour < 0)) 
                            || (minute < 0)) 
                            || (minute < 0)) 
                            || (second < 0)) 
                            || (ticks < 0))) {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
            catch (System.Exception e) {
                throw new System.ArgumentOutOfRangeException(null, e.Message);
            }
            datetime = new System.DateTime(year, month, day, hour, minute, second, 0);
            datetime = datetime.AddTicks(ticks);
            System.TimeSpan tickOffset = System.TimeZone.CurrentTimeZone.GetUtcOffset(datetime);
            int UTCOffset = 0;
            int OffsetToBeAdjusted = 0;
            long OffsetMins = ((long)((tickOffset.Ticks / System.TimeSpan.TicksPerMinute)));
            tempString = dmtf.Substring(22, 3);
            if ((tempString != "******")) {
                tempString = dmtf.Substring(21, 4);
                try {
                    UTCOffset = int.Parse(tempString);
                }
                catch (System.Exception e) {
                    throw new System.ArgumentOutOfRangeException(null, e.Message);
                }
                OffsetToBeAdjusted = ((int)((OffsetMins - UTCOffset)));
                datetime = datetime.AddMinutes(((double)(OffsetToBeAdjusted)));
            }
            return datetime;
        }
        
        // Converts a given System.DateTime object to DMTF datetime format.
        static string ToDmtfDateTime(System.DateTime date) {
            string utcString = string.Empty;
            System.TimeSpan tickOffset = System.TimeZone.CurrentTimeZone.GetUtcOffset(date);
            long OffsetMins = ((long)((tickOffset.Ticks / System.TimeSpan.TicksPerMinute)));
            if ((System.Math.Abs(OffsetMins) > 999)) {
                date = date.ToUniversalTime();
                utcString = "+000";
            }
            else {
                if ((tickOffset.Ticks >= 0)) {
                    utcString = string.Concat("+", ((System.Int64 )((tickOffset.Ticks / System.TimeSpan.TicksPerMinute))).ToString().PadLeft(3, '0'));
                }
                else {
                    string strTemp = ((System.Int64 )(OffsetMins)).ToString();
                    utcString = string.Concat("-", strTemp.Substring(1, (strTemp.Length - 1)).PadLeft(3, '0'));
                }
            }
            string dmtfDateTime = ((System.Int32 )(date.Year)).ToString().PadLeft(4, '0');
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Month)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Day)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Hour)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Minute)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Second)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ".");
            System.DateTime dtTemp = new System.DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, 0);
            long microsec = ((long)((((date.Ticks - dtTemp.Ticks) 
                        * 1000) 
                        / System.TimeSpan.TicksPerMillisecond)));
            string strMicrosec = ((System.Int64 )(microsec)).ToString();
            if ((strMicrosec.Length > 6)) {
                strMicrosec = strMicrosec.Substring(0, 6);
            }
            dmtfDateTime = string.Concat(dmtfDateTime, strMicrosec.PadLeft(6, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, utcString);
            return dmtfDateTime;
        }
        
        private bool ShouldSerializeDriverDate() {
            if ((this.IsDriverDateNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeErrorCleared() {
            if ((this.IsErrorClearedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeICMIntent() {
            if ((this.IsICMIntentNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeICMMethod() {
            if ((this.IsICMMethodNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeInstallDate() {
            if ((this.IsInstallDateNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeLastErrorCode() {
            if ((this.IsLastErrorCodeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMaxMemorySupported() {
            if ((this.IsMaxMemorySupportedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMaxNumberControlled() {
            if ((this.IsMaxNumberControlledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMaxRefreshRate() {
            if ((this.IsMaxRefreshRateNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMinRefreshRate() {
            if ((this.IsMinRefreshRateNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMonochrome() {
            if ((this.IsMonochromeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeNumberOfColorPlanes() {
            if ((this.IsNumberOfColorPlanesNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeNumberOfVideoPages() {
            if ((this.IsNumberOfVideoPagesNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializePowerManagementSupported() {
            if ((this.IsPowerManagementSupportedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeProtocolSupported() {
            if ((this.IsProtocolSupportedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeReservedSystemPaletteEntries() {
            if ((this.IsReservedSystemPaletteEntriesNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeSpecificationVersion() {
            if ((this.IsSpecificationVersionNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeStatusInfo() {
            if ((this.IsStatusInfoNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeSystemPaletteEntries() {
            if ((this.IsSystemPaletteEntriesNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeTimeOfLastReset() {
            if ((this.IsTimeOfLastResetNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeVideoArchitecture() {
            if ((this.IsVideoArchitectureNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeVideoMemoryType() {
            if ((this.IsVideoMemoryTypeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeVideoMode() {
            if ((this.IsVideoModeNull == false)) {
                return true;
            }
            return false;
        }
        
        [Browsable(true)]
        public void CommitObject() {
            if ((isEmbedded == false)) {
                PrivateLateBoundObject.Put();
            }
        }
        
        [Browsable(true)]
        public void CommitObject(System.Management.PutOptions putOptions) {
            if ((isEmbedded == false)) {
                PrivateLateBoundObject.Put(putOptions);
            }
        }
        
        private void Initialize() {
            AutoCommitProp = true;
            isEmbedded = false;
        }
        
        private static string ConstructPath(string keyDeviceID) {
            string strPath = "root\\cimv2:Win32_VideoController";
            strPath = string.Concat(strPath, string.Concat(".DeviceID=", string.Concat("\"", string.Concat(keyDeviceID, "\""))));
            return strPath;
        }
        
        private void InitializeObject(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            Initialize();
            if ((path != null)) {
                if ((CheckIfProperClass(mgmtScope, path, getOptions) != true)) {
                    throw new System.ArgumentException("Class name does not match.");
                }
            }
            PrivateLateBoundObject = new System.Management.ManagementObject(mgmtScope, path, getOptions);
            PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
            curObj = PrivateLateBoundObject;
        }
        
        // Different overloads of GetInstances() help in enumerating instances of the WMI class.
        public static VideoControllerCollection GetInstances() {
            return GetInstances(null, null, null);
        }
        
        public static VideoControllerCollection GetInstances(string condition) {
            return GetInstances(null, condition, null);
        }
        
        public static VideoControllerCollection GetInstances(System.String [] selectedProperties) {
            return GetInstances(null, null, selectedProperties);
        }
        
        public static VideoControllerCollection GetInstances(string condition, System.String [] selectedProperties) {
            return GetInstances(null, condition, selectedProperties);
        }
        
        public static VideoControllerCollection GetInstances(System.Management.ManagementScope mgmtScope, System.Management.EnumerationOptions enumOptions) {
            if ((mgmtScope == null)) {
                if ((statMgmtScope == null)) {
                    mgmtScope = new System.Management.ManagementScope();
                    mgmtScope.Path.NamespacePath = "root\\cimv2";
                }
                else {
                    mgmtScope = statMgmtScope;
                }
            }
            System.Management.ManagementPath pathObj = new System.Management.ManagementPath();
            pathObj.ClassName = "Win32_VideoController";
            pathObj.NamespacePath = "root\\cimv2";
            System.Management.ManagementClass clsObject = new System.Management.ManagementClass(mgmtScope, pathObj, null);
            if ((enumOptions == null)) {
                enumOptions = new System.Management.EnumerationOptions();
                enumOptions.EnsureLocatable = true;
            }
            return new VideoControllerCollection(clsObject.GetInstances(enumOptions));
        }
        
        public static VideoControllerCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition) {
            return GetInstances(mgmtScope, condition, null);
        }
        
        public static VideoControllerCollection GetInstances(System.Management.ManagementScope mgmtScope, System.String [] selectedProperties) {
            return GetInstances(mgmtScope, null, selectedProperties);
        }
        
        public static VideoControllerCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition, System.String [] selectedProperties) {
            if ((mgmtScope == null)) {
                if ((statMgmtScope == null)) {
                    mgmtScope = new System.Management.ManagementScope();
                    mgmtScope.Path.NamespacePath = "root\\cimv2";
                }
                else {
                    mgmtScope = statMgmtScope;
                }
            }
            System.Management.ManagementObjectSearcher ObjectSearcher = new System.Management.ManagementObjectSearcher(mgmtScope, new SelectQuery("Win32_VideoController", condition, selectedProperties));
            System.Management.EnumerationOptions enumOptions = new System.Management.EnumerationOptions();
            enumOptions.EnsureLocatable = true;
            ObjectSearcher.Options = enumOptions;
            return new VideoControllerCollection(ObjectSearcher.Get());
        }
        
        [Browsable(true)]
        public static VideoController CreateInstance() {
            System.Management.ManagementScope mgmtScope = null;
            if ((statMgmtScope == null)) {
                mgmtScope = new System.Management.ManagementScope();
                mgmtScope.Path.NamespacePath = CreatedWmiNamespace;
            }
            else {
                mgmtScope = statMgmtScope;
            }
            System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
            System.Management.ManagementClass tmpMgmtClass = new System.Management.ManagementClass(mgmtScope, mgmtPath, null);
            return new VideoController(tmpMgmtClass.CreateInstance());
        }
        
        [Browsable(true)]
        public void Delete() {
            PrivateLateBoundObject.Delete();
        }
        
        public uint Reset() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Reset", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint SetPowerState(ushort PowerState, System.DateTime Time) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetPowerState");
                inParams["PowerState"] = ((System.UInt16 )(PowerState));
                inParams["Time"] = ToDmtfDateTime(((System.DateTime)(Time)));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetPowerState", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public enum AcceleratorCapabilitiesValues {
            
            Unknown0 = 0,
            
            Other0 = 1,
            
            Graphics_Accelerator = 2,
            
            Val_3D_Accelerator = 3,
            
            NULL_ENUM_VALUE = 4,
        }
        
        public enum AvailabilityValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            Running_Full_Power = 3,
            
            Warning = 4,
            
            In_Test = 5,
            
            Not_Applicable = 6,
            
            Power_Off = 7,
            
            Off_Line = 8,
            
            Off_Duty = 9,
            
            Degraded = 10,
            
            Not_Installed = 11,
            
            Install_Error = 12,
            
            Power_Save_Unknown = 13,
            
            Power_Save_Low_Power_Mode = 14,
            
            Power_Save_Standby = 15,
            
            Power_Cycle = 16,
            
            Power_Save_Warning = 17,
            
            Paused = 18,
            
            Not_Ready = 19,
            
            Not_Configured = 20,
            
            Quiesced = 21,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum ConfigManagerErrorCodeValues {
            
            This_device_is_working_properly_ = 0,
            
            This_device_is_not_configured_correctly_ = 1,
            
            Windows_cannot_load_the_driver_for_this_device_ = 2,
            
            The_driver_for_this_device_might_be_corrupted_or_your_system_may_be_running_low_on_memory_or_other_resources_ = 3,
            
            This_device_is_not_working_properly_One_of_its_drivers_or_your_registry_might_be_corrupted_ = 4,
            
            The_driver_for_this_device_needs_a_resource_that_Windows_cannot_manage_ = 5,
            
            The_boot_configuration_for_this_device_conflicts_with_other_devices_ = 6,
            
            Cannot_filter_ = 7,
            
            The_driver_loader_for_the_device_is_missing_ = 8,
            
            This_device_is_not_working_properly_because_the_controlling_firmware_is_reporting_the_resources_for_the_device_incorrectly_ = 9,
            
            This_device_cannot_start_ = 10,
            
            This_device_failed_ = 11,
            
            This_device_cannot_find_enough_free_resources_that_it_can_use_ = 12,
            
            Windows_cannot_verify_this_device_s_resources_ = 13,
            
            This_device_cannot_work_properly_until_you_restart_your_computer_ = 14,
            
            This_device_is_not_working_properly_because_there_is_probably_a_re_enumeration_problem_ = 15,
            
            Windows_cannot_identify_all_the_resources_this_device_uses_ = 16,
            
            This_device_is_asking_for_an_unknown_resource_type_ = 17,
            
            Reinstall_the_drivers_for_this_device_ = 18,
            
            Failure_using_the_VxD_loader_ = 19,
            
            Your_registry_might_be_corrupted_ = 20,
            
            System_failure_Try_changing_the_driver_for_this_device_If_that_does_not_work_see_your_hardware_documentation_Windows_is_removing_this_device_ = 21,
            
            This_device_is_disabled_ = 22,
            
            System_failure_Try_changing_the_driver_for_this_device_If_that_doesn_t_work_see_your_hardware_documentation_ = 23,
            
            This_device_is_not_present_is_not_working_properly_or_does_not_have_all_its_drivers_installed_ = 24,
            
            Windows_is_still_setting_up_this_device_ = 25,
            
            Windows_is_still_setting_up_this_device_0 = 26,
            
            This_device_does_not_have_valid_log_configuration_ = 27,
            
            The_drivers_for_this_device_are_not_installed_ = 28,
            
            This_device_is_disabled_because_the_firmware_of_the_device_did_not_give_it_the_required_resources_ = 29,
            
            This_device_is_using_an_Interrupt_Request_IRQ_resource_that_another_device_is_using_ = 30,
            
            This_device_is_not_working_properly_because_Windows_cannot_load_the_drivers_required_for_this_device_ = 31,
            
            NULL_ENUM_VALUE = 32,
        }
        
        public enum CurrentScanModeValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            Interlaced = 3,
            
            Non_Interlaced = 4,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum DitherTypeValues {
            
            No_dithering = 1,
            
            Dithering_with_a_coarse_brush = 2,
            
            Dithering_with_a_fine_brush = 3,
            
            Line_art_dithering = 4,
            
            Device_does_gray_scaling = 5,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum ICMIntentValues {
            
            Saturation = 1,
            
            Contrast = 2,
            
            Exact_Color = 3,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum ICMMethodValues {
            
            Disabled = 1,
            
            Windows = 2,
            
            Device_Driver = 3,
            
            Destination_Device = 4,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum PowerManagementCapabilitiesValues {
            
            Unknown0 = 0,
            
            Not_Supported = 1,
            
            Disabled = 2,
            
            Enabled = 3,
            
            Power_Saving_Modes_Entered_Automatically = 4,
            
            Power_State_Settable = 5,
            
            Power_Cycling_Supported = 6,
            
            Timed_Power_On_Supported = 7,
            
            NULL_ENUM_VALUE = 8,
        }
        
        public enum ProtocolSupportedValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            EISA = 3,
            
            ISA = 4,
            
            PCI = 5,
            
            ATA_ATAPI = 6,
            
            Flexible_Diskette = 7,
            
            Val_1496 = 8,
            
            SCSI_Parallel_Interface = 9,
            
            SCSI_Fibre_Channel_Protocol = 10,
            
            SCSI_Serial_Bus_Protocol = 11,
            
            SCSI_Serial_Bus_Protocol_2_1394_ = 12,
            
            SCSI_Serial_Storage_Architecture = 13,
            
            VESA = 14,
            
            PCMCIA = 15,
            
            Universal_Serial_Bus = 16,
            
            Parallel_Protocol = 17,
            
            ESCON = 18,
            
            Diagnostic = 19,
            
            I2C = 20,
            
            Power = 21,
            
            HIPPI = 22,
            
            MultiBus = 23,
            
            VME = 24,
            
            IPI = 25,
            
            IEEE_488 = 26,
            
            RS232 = 27,
            
            IEEE_802_3_10BASE5 = 28,
            
            IEEE_802_3_10BASE2 = 29,
            
            IEEE_802_3_1BASE5 = 30,
            
            IEEE_802_3_10BROAD36 = 31,
            
            IEEE_802_3_100BASEVG = 32,
            
            IEEE_802_5_Token_Ring = 33,
            
            ANSI_X3T9_5_FDDI = 34,
            
            MCA = 35,
            
            ESDI = 36,
            
            IDE = 37,
            
            CMD = 38,
            
            ST506 = 39,
            
            DSSI = 40,
            
            QIC2 = 41,
            
            Enhanced_ATA_IDE = 42,
            
            AGP = 43,
            
            TWIRP_two_way_infrared_ = 44,
            
            FIR_fast_infrared_ = 45,
            
            SIR_serial_infrared_ = 46,
            
            IrBus = 47,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum StatusInfoValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            Enabled = 3,
            
            Disabled = 4,
            
            Not_Applicable = 5,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum VideoArchitectureValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            CGA = 3,
            
            EGA = 4,
            
            VGA = 5,
            
            SVGA = 6,
            
            MDA = 7,
            
            HGC = 8,
            
            MCGA = 9,
            
            Val_8514A = 10,
            
            XGA = 11,
            
            Linear_Frame_Buffer = 12,
            
            PC_98 = 160,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum VideoMemoryTypeValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            VRAM = 3,
            
            DRAM = 4,
            
            SRAM = 5,
            
            WRAM = 6,
            
            EDO_RAM = 7,
            
            Burst_Synchronous_DRAM = 8,
            
            Pipelined_Burst_SRAM = 9,
            
            CDRAM = 10,
            
            Val_3DRAM = 11,
            
            SDRAM = 12,
            
            SGRAM = 13,
            
            NULL_ENUM_VALUE = 0,
        }
        
        // Enumerator implementation for enumerating instances of the class.
        public class VideoControllerCollection : object, ICollection {
            
            private ManagementObjectCollection privColObj;
            
            public VideoControllerCollection(ManagementObjectCollection objCollection) {
                privColObj = objCollection;
            }
            
            public virtual int Count {
                get {
                    return privColObj.Count;
                }
            }
            
            public virtual bool IsSynchronized {
                get {
                    return privColObj.IsSynchronized;
                }
            }
            
            public virtual object SyncRoot {
                get {
                    return this;
                }
            }
            
            public virtual void CopyTo(System.Array array, int index) {
                privColObj.CopyTo(array, index);
                int nCtr;
                for (nCtr = 0; (nCtr < array.Length); nCtr = (nCtr + 1)) {
                    array.SetValue(new VideoController(((System.Management.ManagementObject)(array.GetValue(nCtr)))), nCtr);
                }
            }
            
            public virtual System.Collections.IEnumerator GetEnumerator() {
                return new VideoControllerEnumerator(privColObj.GetEnumerator());
            }
            
            public class VideoControllerEnumerator : object, System.Collections.IEnumerator {
                
                private ManagementObjectCollection.ManagementObjectEnumerator privObjEnum;
                
                public VideoControllerEnumerator(ManagementObjectCollection.ManagementObjectEnumerator objEnum) {
                    privObjEnum = objEnum;
                }
                
                public virtual object Current {
                    get {
                        return new VideoController(((System.Management.ManagementObject)(privObjEnum.Current)));
                    }
                }
                
                public virtual bool MoveNext() {
                    return privObjEnum.MoveNext();
                }
                
                public virtual void Reset() {
                    privObjEnum.Reset();
                }
            }
        }
        
        // TypeConverter to handle null values for ValueType properties
        public class WMIValueTypeConverter : TypeConverter {
            
            private TypeConverter baseConverter;
            
            private System.Type baseType;
            
            public WMIValueTypeConverter(System.Type inBaseType) {
                baseConverter = TypeDescriptor.GetConverter(inBaseType);
                baseType = inBaseType;
            }
            
            public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type srcType) {
                return baseConverter.CanConvertFrom(context, srcType);
            }
            
            public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) {
                return baseConverter.CanConvertTo(context, destinationType);
            }
            
            public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {
                return baseConverter.ConvertFrom(context, culture, value);
            }
            
            public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary dictionary) {
                return baseConverter.CreateInstance(context, dictionary);
            }
            
            public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetCreateInstanceSupported(context);
            }
            
            public override PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributeVar) {
                return baseConverter.GetProperties(context, value, attributeVar);
            }
            
            public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetPropertiesSupported(context);
            }
            
            public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValues(context);
            }
            
            public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValuesExclusive(context);
            }
            
            public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValuesSupported(context);
            }
            
            public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) {
                if ((baseType.BaseType == typeof(System.Enum))) {
                    if ((value.GetType() == destinationType)) {
                        return value;
                    }
                    if ((((value == null) 
                                && (context != null)) 
                                && (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false))) {
                        return  "NULL_ENUM_VALUE" ;
                    }
                    return baseConverter.ConvertTo(context, culture, value, destinationType);
                }
                if (((baseType == typeof(bool)) 
                            && (baseType.BaseType == typeof(System.ValueType)))) {
                    if ((((value == null) 
                                && (context != null)) 
                                && (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false))) {
                        return "";
                    }
                    return baseConverter.ConvertTo(context, culture, value, destinationType);
                }
                if (((context != null) 
                            && (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false))) {
                    return "";
                }
                return baseConverter.ConvertTo(context, culture, value, destinationType);
            }
        }
        
        // Embedded class to represent WMI system Properties.
        [TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public class ManagementSystemProperties {
            
            private System.Management.ManagementBaseObject PrivateLateBoundObject;
            
            public ManagementSystemProperties(System.Management.ManagementBaseObject ManagedObject) {
                PrivateLateBoundObject = ManagedObject;
            }
            
            [Browsable(true)]
            public int GENUS {
                get {
                    return ((int)(PrivateLateBoundObject["__GENUS"]));
                }
            }
            
            [Browsable(true)]
            public string CLASS {
                get {
                    return ((string)(PrivateLateBoundObject["__CLASS"]));
                }
            }
            
            [Browsable(true)]
            public string SUPERCLASS {
                get {
                    return ((string)(PrivateLateBoundObject["__SUPERCLASS"]));
                }
            }
            
            [Browsable(true)]
            public string DYNASTY {
                get {
                    return ((string)(PrivateLateBoundObject["__DYNASTY"]));
                }
            }
            
            [Browsable(true)]
            public string RELPATH {
                get {
                    return ((string)(PrivateLateBoundObject["__RELPATH"]));
                }
            }
            
            [Browsable(true)]
            public int PROPERTY_COUNT {
                get {
                    return ((int)(PrivateLateBoundObject["__PROPERTY_COUNT"]));
                }
            }
            
            [Browsable(true)]
            public string[] DERIVATION {
                get {
                    return ((string[])(PrivateLateBoundObject["__DERIVATION"]));
                }
            }
            
            [Browsable(true)]
            public string SERVER {
                get {
                    return ((string)(PrivateLateBoundObject["__SERVER"]));
                }
            }
            
            [Browsable(true)]
            public string NAMESPACE {
                get {
                    return ((string)(PrivateLateBoundObject["__NAMESPACE"]));
                }
            }
            
            [Browsable(true)]
            public string PATH {
                get {
                    return ((string)(PrivateLateBoundObject["__PATH"]));
                }
            }
        }
    }
}

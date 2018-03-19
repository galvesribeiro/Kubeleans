// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kubeleans.KubernetesApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Adapts a Secret into a volume.
    ///
    /// The contents of the target Secret's Data field will be presented in a
    /// volume as files using the keys in the Data field as the file names.
    /// Secret volumes support ownership management and SELinux relabeling.
    /// </summary>
    public partial class Iok8sapicorev1SecretVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1SecretVolumeSource
        /// class.
        /// </summary>
        public Iok8sapicorev1SecretVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1SecretVolumeSource
        /// class.
        /// </summary>
        /// <param name="defaultMode">Optional: mode bits to use on created
        /// files by default. Must be a value between 0 and 0777. Defaults to
        /// 0644. Directories within the path are not affected by this setting.
        /// This might be in conflict with other options that affect the file
        /// mode, like fsGroup, and the result can be other mode bits
        /// set.</param>
        /// <param name="items">If unspecified, each key-value pair in the Data
        /// field of the referenced Secret will be projected into the volume as
        /// a file whose name is the key and content is the value. If
        /// specified, the listed keys will be projected into the specified
        /// paths, and unlisted keys will not be present. If a key is specified
        /// which is not present in the Secret, the volume setup will error
        /// unless it is marked optional. Paths must be relative and may not
        /// contain the '..' path or start with '..'.</param>
        /// <param name="optional">Specify whether the Secret or it's keys must
        /// be defined</param>
        /// <param name="secretName">Name of the secret in the pod's namespace
        /// to use. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#secret</param>
        public Iok8sapicorev1SecretVolumeSource(int? defaultMode = default(int?), IList<Iok8sapicorev1KeyToPath> items = default(IList<Iok8sapicorev1KeyToPath>), bool? optional = default(bool?), string secretName = default(string))
        {
            DefaultMode = defaultMode;
            Items = items;
            Optional = optional;
            SecretName = secretName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional: mode bits to use on created files by
        /// default. Must be a value between 0 and 0777. Defaults to 0644.
        /// Directories within the path are not affected by this setting. This
        /// might be in conflict with other options that affect the file mode,
        /// like fsGroup, and the result can be other mode bits set.
        /// </summary>
        [JsonProperty(PropertyName = "defaultMode")]
        public int? DefaultMode { get; set; }

        /// <summary>
        /// Gets or sets if unspecified, each key-value pair in the Data field
        /// of the referenced Secret will be projected into the volume as a
        /// file whose name is the key and content is the value. If specified,
        /// the listed keys will be projected into the specified paths, and
        /// unlisted keys will not be present. If a key is specified which is
        /// not present in the Secret, the volume setup will error unless it is
        /// marked optional. Paths must be relative and may not contain the
        /// '..' path or start with '..'.
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<Iok8sapicorev1KeyToPath> Items { get; set; }

        /// <summary>
        /// Gets or sets specify whether the Secret or it's keys must be
        /// defined
        /// </summary>
        [JsonProperty(PropertyName = "optional")]
        public bool? Optional { get; set; }

        /// <summary>
        /// Gets or sets name of the secret in the pod's namespace to use. More
        /// info: https://kubernetes.io/docs/concepts/storage/volumes#secret
        /// </summary>
        [JsonProperty(PropertyName = "secretName")]
        public string SecretName { get; set; }

    }
}
// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kubeleans.KubernetesApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SelfSubjectAccessReviewSpec is a description of the access request.
    /// Exactly one of ResourceAuthorizationAttributes and
    /// NonResourceAuthorizationAttributes must be set
    /// </summary>
    public partial class Iok8sapiauthorizationv1SelfSubjectAccessReviewSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiauthorizationv1SelfSubjectAccessReviewSpec class.
        /// </summary>
        public Iok8sapiauthorizationv1SelfSubjectAccessReviewSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiauthorizationv1SelfSubjectAccessReviewSpec class.
        /// </summary>
        /// <param name="nonResourceAttributes">NonResourceAttributes describes
        /// information for a non-resource access request</param>
        /// <param name="resourceAttributes">ResourceAuthorizationAttributes
        /// describes information for a resource access request</param>
        public Iok8sapiauthorizationv1SelfSubjectAccessReviewSpec(Iok8sapiauthorizationv1NonResourceAttributes nonResourceAttributes = default(Iok8sapiauthorizationv1NonResourceAttributes), Iok8sapiauthorizationv1ResourceAttributes resourceAttributes = default(Iok8sapiauthorizationv1ResourceAttributes))
        {
            NonResourceAttributes = nonResourceAttributes;
            ResourceAttributes = resourceAttributes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets nonResourceAttributes describes information for a
        /// non-resource access request
        /// </summary>
        [JsonProperty(PropertyName = "nonResourceAttributes")]
        public Iok8sapiauthorizationv1NonResourceAttributes NonResourceAttributes { get; set; }

        /// <summary>
        /// Gets or sets resourceAuthorizationAttributes describes information
        /// for a resource access request
        /// </summary>
        [JsonProperty(PropertyName = "resourceAttributes")]
        public Iok8sapiauthorizationv1ResourceAttributes ResourceAttributes { get; set; }

    }
}

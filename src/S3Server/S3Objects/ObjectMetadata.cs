﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace S3ServerLibrary.S3Objects
{
    /// <summary>
    /// Object metadata.
    /// </summary>
    [XmlRoot(ElementName = "Contents", IsNullable = true)]
    public class ObjectMetadata
    {
        // Namespace = "http://s3.amazonaws.com/doc/2006-03-01/"

        #region Public-Members

        /// <summary>
        /// Object key.
        /// </summary>
        [XmlElement(ElementName = "Key", IsNullable = true)]
        public string Key { get; set; } = null;

        /// <summary>
        /// Timestamp from the last modification of the resource.
        /// </summary>
        [XmlElement(ElementName = "LastModified")]
        public DateTime LastModified { get; set; } = DateTime.Now.ToUniversalTime();

        /// <summary>
        /// ETag of the resource.
        /// </summary>
        [XmlElement(ElementName = "ETag", IsNullable = true)]
        public string ETag { get; set; } = null;

        /// <summary>
        /// Content type.
        /// </summary>
        public string ContentType { get; set; } = "application/octet-stream";

        /// <summary>
        /// The size in bytes of the resource.
        /// </summary>
        [XmlElement(ElementName = "Size")]
        public long Size
        {
            get
            {
                return _Size;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(Size));
                _Size = value;
            }
        }

        /// <summary>
        /// The class of storage where the resource resides.
        /// Valid values are STANDARD, REDUCED_REDUNDANCY, GLACIER, STANDARD_IA, ONEZONE_IA, INTELLIGENT_TIERING, DEEP_ARCHIVE, OUTPOSTS.
        /// </summary>
        [XmlElement(ElementName = "StorageClass", IsNullable = true)]
        public string StorageClass
        {
            get
            {
                return _StorageClass;
            }
            set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(StorageClass));
                if (!_StorageClassValidValues.Contains(value)) throw new ArgumentException("Unknown StorageClass '" + value + "'.");
                _StorageClass = value;
            }
        }

        /// <summary>
        /// Object owner.
        /// </summary>
        [XmlElement(ElementName = "Owner", IsNullable = true)]
        public Owner Owner { get; set; } = new Owner();

        #endregion

        #region Private-Members

        private string _StorageClass = "STANDARD";
        private List<string> _StorageClassValidValues = new List<string>
        {
            "STANDARD",
            "REDUCED_REDUNDANCY",
            "GLACIER",
            "STANDARD_IA",
            "ONEZONE_IA",
            "INTELLIGENT_TIERING",
            "DEEP_ARCHIVE",
            "OUTPOSTS"
        };
        private long _Size = 0;

        #endregion

        #region Constructors-and-Factories

        /// <summary>
        /// Instantiate.
        /// </summary>
        public ObjectMetadata()
        {

        }

        /// <summary>
        /// Instantiate.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <param name="lastModified">Last modified.</param>
        /// <param name="eTag">ETag.</param>
        /// <param name="size">Size.</param>
        /// <param name="owner">Owner.</param>
        /// <param name="storageClass">Storage class.  Valid values are STANDARD, REDUCED_REDUNDANCY, GLACIER, STANDARD_IA, ONEZONE_IA, INTELLIGENT_TIERING, DEEP_ARCHIVE, OUTPOSTS.</param>
        public ObjectMetadata(string key, DateTime lastModified, string eTag, long size, Owner owner, string storageClass = "STANDARD")
        {
            Key = key;
            LastModified = lastModified;
            ETag = eTag;
            Size = size;
            StorageClass = storageClass;
            Owner = owner;
        }

        #endregion

        #region Public-Methods

        #endregion

        #region Private-Methods

        #endregion
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace S3ServerInterface.Callbacks
{
    public class ObjectCallbacks
    {
        #region Public-Members

        /// <summary>
        /// Check for the existence of an object.  A successful S3Response should include no data and return an HTTP 200.
        /// </summary>
        public Func<S3Request, S3Response> Exists { get; set; }

        /// <summary>
        /// Write an object.  A successful S3Response should include no data and return an HTTP 200.
        /// </summary>
        public Func<S3Request, S3Response> Write { get; set; }

        /// <summary>
        /// Write an object's access control list.  A successful S3Response should include no data and return an HTTP 200.
        /// </summary>
        public Func<S3Request, S3Response> WriteAcl { get; set; }

        /// <summary>
        /// Write tags to an object.  A successful S3Response should include no data and return an HTTP 200.
        /// </summary>
        public Func<S3Request, S3Response> WriteTags { get; set; }

        /// <summary>
        /// Read an object.  A successful S3Response should include the data and return an HTTP 200.
        /// </summary>
        public Func<S3Request, S3Response> Read { get; set; }

        /// <summary>
        /// Read an object's access control list.  A successful S3Response should include an XML document containing the access control policy and return an HTTP 200.
        /// </summary>
        public Func<S3Request, S3Response> ReadAcl { get; set; }

        /// <summary>
        /// Read a range of bytes from an object.  A successful S3Response should include the data and return an HTTP 200.
        /// </summary>
        public Func<S3Request, S3Response> ReadRange { get; set; }

        /// <summary>
        /// Read an object's tags.  A successful S3Response should include the data and return an HTTP 200.
        /// </summary>
        public Func<S3Request, S3Response> ReadTags { get; set; }

        /// <summary>
        /// Delete an object.  A successful S3Response should include no data and return an HTTP 200.
        /// </summary>
        public Func<S3Request, S3Response> Delete { get; set; }

        /// <summary>
        /// Delete an object's tags.  A successful S3Response should include no data and return an HTTP 204.
        /// </summary>
        public Func<S3Request, S3Response> DeleteTags { get; set; }

        /// <summary>
        /// Delete multiple objects.  A successful S3Response should include an XML document containing the delete result and an HTTP 200.
        /// </summary>
        public Func<S3Request, S3Response> DeleteMultiple { get; set; }

        #endregion

        #region Private-Members

        #endregion

        #region Constructors-and-Factories

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        public ObjectCallbacks()
        {
            Write = null;
            Read = null;
            Delete = null;
        }

        #endregion

        #region Public-Methods

        #endregion

        #region Private-Methods

        #endregion
    }
}

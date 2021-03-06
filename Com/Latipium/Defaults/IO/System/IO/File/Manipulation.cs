﻿// Manipulation.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
        /// <summary>
        /// See File.Copy
        /// </summary>
        /// <param name="sourceFileName">Source file name.</param>
        /// <param name="destFileName">Destination file name.</param>
		[LatipiumMethod("Copy")]
		public void Copy(string sourceFileName, string destFileName) {
			if ( BeforeOperation(sourceFileName, destFileName) ) {
				try {
					File.Copy(sourceFileName, destFileName);
				} finally {
					AfterOperation();
				}
			}
		}

        /// <summary>
        /// See File.Copy
        /// </summary>
        /// <param name="sourceFileName">Source file name.</param>
        /// <param name="destFileName">Destination file name.</param>
        /// <param name="overwrite">If set to <c>true</c> overwrite.</param>
		[LatipiumMethod("Copy")]
		public void Copy(string sourceFileName, string destFileName, bool overwrite) {
			if ( BeforeOperation(sourceFileName, destFileName) ) {
				try {
					File.Copy(sourceFileName, destFileName, overwrite);
				} finally {
					AfterOperation();
				}
			}
		}

        /// <summary>
        /// See File.Delete
        /// </summary>
        /// <param name="path">Path.</param>
		[LatipiumMethod("Delete")]
		public void Delete(string path) {
			if ( BeforeOperation(path) ) {
				try {
					File.Delete(path);
				} finally {
					AfterOperation();
				}
			}
		}

        /// <summary>
        /// See File.Move
        /// </summary>
        /// <param name="sourceFileName">Source file name.</param>
        /// <param name="destFileName">Destination file name.</param>
		[LatipiumMethod("Move")]
		public void Move(string sourceFileName, string destFileName) {
			if ( BeforeOperation(sourceFileName, destFileName) ) {
				try {
					File.Move(sourceFileName, destFileName);
				} finally {
					AfterOperation();
				}
			}
		}

        /// <summary>
        /// See File.Replace
        /// </summary>
        /// <param name="sourceFileName">Source file name.</param>
        /// <param name="destinationFileName">Destination file name.</param>
        /// <param name="destinationBackupFileName">Destination backup file name.</param>
		[LatipiumMethod("Replace")]
		public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName) {
			if ( BeforeOperation(sourceFileName, destinationFileName, destinationBackupFileName) ) {
				try {
					File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
				} finally {
					AfterOperation();
				}
			}
		}

        /// <summary>
        /// See File.Replace
        /// </summary>
        /// <param name="sourceFileName">Source file name.</param>
        /// <param name="destinationFileName">Destination file name.</param>
        /// <param name="destinationBackupFileName">Destination backup file name.</param>
        /// <param name="ignoreMetadataErrors">If set to <c>true</c> ignore metadata errors.</param>
		[LatipiumMethod("Replace")]
		public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors) {
			if ( BeforeOperation(sourceFileName, destinationFileName, destinationBackupFileName) ) {
				try {
					File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
				} finally {
					AfterOperation();
				}
			}
		}
	}
}


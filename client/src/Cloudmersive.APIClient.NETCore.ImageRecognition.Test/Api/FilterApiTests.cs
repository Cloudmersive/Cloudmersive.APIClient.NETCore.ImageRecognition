/* 
 * imageapi
 *
 * Image Recognition and Processing APIs let you use Machine Learning to recognize and process images, and also perform useful image modification operations.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NETCore.ImageRecognition.Client;
using Cloudmersive.APIClient.NETCore.ImageRecognition.Api;

namespace Cloudmersive.APIClient.NETCore.ImageRecognition.Test
{
    /// <summary>
    ///  Class for testing FilterApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FilterApiTests
    {
        private FilterApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FilterApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FilterApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FilterApi
            //Assert.IsInstanceOfType(typeof(FilterApi), instance, "instance is a FilterApi");
        }

        
        /// <summary>
        /// Test FilterBlackAndWhite
        /// </summary>
        [Test]
        public void FilterBlackAndWhiteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.FilterBlackAndWhite(imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test FilterDespeckle
        /// </summary>
        [Test]
        public void FilterDespeckleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream imageFile = null;
            //var response = instance.FilterDespeckle(imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test FilterEdgeDetect
        /// </summary>
        [Test]
        public void FilterEdgeDetectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? radius = null;
            //System.IO.Stream imageFile = null;
            //var response = instance.FilterEdgeDetect(radius, imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test FilterEmboss
        /// </summary>
        [Test]
        public void FilterEmbossTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? radius = null;
            //int? sigma = null;
            //System.IO.Stream imageFile = null;
            //var response = instance.FilterEmboss(radius, sigma, imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test FilterGaussianBlur
        /// </summary>
        [Test]
        public void FilterGaussianBlurTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? radius = null;
            //int? sigma = null;
            //System.IO.Stream imageFile = null;
            //var response = instance.FilterGaussianBlur(radius, sigma, imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test FilterMotionBlur
        /// </summary>
        [Test]
        public void FilterMotionBlurTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? radius = null;
            //int? sigma = null;
            //int? angle = null;
            //System.IO.Stream imageFile = null;
            //var response = instance.FilterMotionBlur(radius, sigma, angle, imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test FilterPosterize
        /// </summary>
        [Test]
        public void FilterPosterizeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? levels = null;
            //var response = instance.FilterPosterize(levels);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test FilterSwirl
        /// </summary>
        [Test]
        public void FilterSwirlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? degrees = null;
            //System.IO.Stream imageFile = null;
            //var response = instance.FilterSwirl(degrees, imageFile);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
    }

}
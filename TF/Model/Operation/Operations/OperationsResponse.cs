﻿using System.Xml.Linq;
using System;

namespace TF.Model.Operation.Operations
{
    public class OperationsResponse
	{
        /// <summary>
        /// Массив операций.
        /// </summary>
        public List<Operation> Operations { get; set; }
	}
}

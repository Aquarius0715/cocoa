﻿
using System;
using System.Collections.Generic;
using System.Linq;

namespace Covid19Radar.Models
{
    public sealed class BeaconDataModel
    {
        /// <summary>
        /// for Cosmos DB 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Same beacon uuid's device can communication.
        /// </summary>
        /// <value>BeaconUuid</value>
        public string BeaconUuid { get; set; }
        /// <summary>
        /// Major - in this app case mapping user id
        /// </summary>
        /// <value>BLE major number</value>
        public string Major { get; set; }
        /// <summary>
        /// MInor - in this app case mapping user id
        /// </summary>
        /// <value>BLE minor number</value>
        public string Minor { get; set; }
        /// <summary>
        /// Bluetooth LE's calcated distance between beacons.
        /// </summary>
        /// <value>BLE minor number</value>
        public double Distance { get; set; }
        /// <summary>
        ///  Received Signal Strength Indicator, after use. Used for precise distance measurement
        /// </summary>
        /// <value>Received Signal Strength Indicator</value>
        public int Rssi { get; set; }
        /// <summary>
        /// Power of beacon transmitter, after use. Used for precise distance measurement
        /// </summary>
        public int TXPower { get; set; }
        /// <summary>
        /// Total contact time of the beacon, which makes a cumulative record.Consider the case where you go to the bathroom halfway and come back.
        /// </summary>
        public TimeSpan ElaspedTime { get; set; }
        /// <summary>
        /// The last time measured.
        /// </summary>
        public DateTime LastDetectTime { get; set; }
    }
}

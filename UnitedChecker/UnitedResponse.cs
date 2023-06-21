using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedChecker
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AircraftInfo
    {
        public object tailNumber { get; set; }
        public string icr { get; set; }
    }

    public class Cabin
    {
        public bool isUpperDeck { get; set; }
        public string cabinType { get; set; }
        public string cabinBrand { get; set; }
        public string cabinBranded { get; set; }
        public string layout { get; set; }
        public int rowCount { get; set; }
        public int columnCount { get; set; }
        public int availableSeats { get; set; }
        public int totalSeats { get; set; }
        public List<Row> rows { get; set; }
        public object adjacentSeats { get; set; }
        public List<MonumentRow> monumentRows { get; set; }
        public bool noComplementarySeatsAvailble { get; set; }
        public bool noSeatsAvailable { get; set; }
    }

    public class FlightInfo
    {
        public int marketingFlightNumber { get; set; }
        public int operatingFlightNumber { get; set; }
        public string marketingCarrierCode { get; set; }
        public string operatingCarrierCode { get; set; }
        public DateTime departureDate { get; set; }
        public string departureAirport { get; set; }
        public string arrivalAirport { get; set; }
        public bool noSeatSelectionWindow { get; set; }
    }

    public class Monument
    {
        public string location { get; set; }
        public string itemType { get; set; }
        public int verticalGridNumber { get; set; }
        public object seatLetter { get; set; }
        public int horizontalGridNumber { get; set; }
        public int horizontalSpan { get; set; }
        public int verticalSpan { get; set; }
        public bool isDoorExit { get; set; }
    }

    public class MonumentRow
    {
        public int verticalGridNumber { get; set; }
        public List<Monument> monuments { get; set; }
    }

    public class UnitedResponse
    {
        public TransactionIdentifiers transactionIdentifiers { get; set; }
        public List<object> softErrors { get; set; }
        public FlightInfo flightInfo { get; set; }
        public AircraftInfo aircraftInfo { get; set; }
        public List<Cabin> cabins { get; set; }
        public List<object> errors { get; set; }
        public List<object> tiers { get; set; }
        public List<object> travelers { get; set; }
        public double seatOfferTiles { get; set; }
    }

    public class Row
    {
        public int number { get; set; }
        public int verticalGridNumber { get; set; }
        public bool wing { get; set; }
        public List<Seat> seats { get; set; }
    }

    public class Seat
    {
        public int adjacentGroupId { get; set; }
        public string number { get; set; }
        public object tier { get; set; }
        public int rowNumber { get; set; }
        public string letter { get; set; }
        public string location { get; set; }
        public string seatSection { get; set; }
        public string itemType { get; set; }
        public string description { get; set; }
        public int pitchLength { get; set; }
        public double seatWidthInches { get; set; }
        public bool isBassinet { get; set; }
        public bool isExtraPitch { get; set; }
        public bool isExtraSeatWidth { get; set; }
        public bool hasInSeatPower { get; set; }
        public bool under15YrsOld { get; set; }
        public double recline { get; set; }
        public string reclineType { get; set; }
        public bool isLimitedSeatWidth { get; set; }
        public bool isSeatRearFacing { get; set; }
        public bool isWindowObstructedView { get; set; }
        public bool isReserveSeat { get; set; }
        public bool isUmnrSeat { get; set; }
        public bool hasNoUnderSeatStorage { get; set; }
        public int verticalGridNumber { get; set; }
        public string seatType { get; set; }
        public int horizontalGridNumber { get; set; }
        public bool isAvailable { get; set; }
        public bool isBlocked { get; set; }
        public bool isAdvanced { get; set; }
        public object servicesAndFees { get; set; }
        public bool isPermanentBlocked { get; set; }
        public bool isBulkhead { get; set; }
        public bool isBBlocked { get; set; }
        public bool isExit { get; set; }
        public bool isDoorExit { get; set; }
        public bool isInoperative { get; set; }
        public bool isOccupied { get; set; }
        public bool isHeld { get; set; }
        public bool isOnWing { get; set; }
        public string sellableSeatCategory { get; set; }
        public string programPricingCode { get; set; }
        public string eDoc { get; set; }
        public string displaySeatType { get; set; }
        public string displaySeatCategory { get; set; }
        public bool allowPet { get; set; }
        public bool allowPrisonerGuard { get; set; }
        public bool allowDisabledPassenger { get; set; }
        public bool allowLapInfant { get; set; }
        public bool allowUnAccompaniedMinor { get; set; }
        public bool isUmnrSeatShares { get; set; }
    }

    public class TransactionIdentifiers
    {
        public string transactionId { get; set; }
    }


}

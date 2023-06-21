using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Data;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using UnitedChecker;

namespace UnitedChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string reqBody { get; set; } = "";

        UnitedResponse unitedResponse = new();

        private async void button1_Click(object sender, EventArgs e)
        {

            UnitedToken unitedToken = JsonConvert.DeserializeObject<UnitedToken>(await GetRestToken());

            await SetBody();

            string download = await GetData(unitedToken.data.token.hash);

            richTextBox1.Text = download;

            unitedResponse = JsonConvert.DeserializeObject<UnitedResponse>(download);


            if (unitedResponse.aircraftInfo is null)
            {
                MessageBox.Show("Error");
                return;
            }


            var cabins = unitedResponse.cabins.FirstOrDefault();

            int totalbuisnessSeats = cabins.totalSeats;
            int availablebuisseats = cabins.availableSeats;

            totalseatslbl.Text = $"Total: {totalbuisnessSeats.ToString()}";
            availableseatslbl.Text = $"Avail: {availablebuisseats.ToString()}";

            await UpdateCabinSeats(cabins);


        }

        private async Task UpdateCabinSeats(Cabin cabins)
        {

            //1
            if (cabins.rows[0].seats[0].isOccupied) seat1A.ForeColor = Color.Red;   
            else seat1A.ForeColor = Color.Green;

            if (cabins.rows[0].seats[1].isOccupied) seat1B.ForeColor = Color.Red;
            else seat1B.ForeColor = Color.Green;

            if (cabins.rows[0].seats[2].isOccupied) seat1E.ForeColor = Color.Red;
            else seat1E.ForeColor = Color.Green;

            if (cabins.rows[0].seats[3].isOccupied)seat1F.ForeColor = Color.Red;
            else seat1F.ForeColor = Color.Green;
            //2
            if (cabins.rows[1].seats[0].isOccupied) seat2A.ForeColor = Color.Red;
            else seat2A.ForeColor = Color.Green;

            if (cabins.rows[1].seats[1].isOccupied)  seat2B.ForeColor = Color.Red;
            else  seat2B.ForeColor = Color.Green;

            if (cabins.rows[1].seats[2].isOccupied) seat2E.ForeColor = Color.Red;
            else seat2E.ForeColor = Color.Green;

            if (cabins.rows[1].seats[3].isOccupied) seat2F.ForeColor = Color.Red;
            else seat2F.ForeColor = Color.Green;
            //3
            if (cabins.rows[2].seats[0].isOccupied) seat3A.ForeColor = Color.Red;
            else seat3A.ForeColor = Color.Green;

            if (cabins.rows[2].seats[1].isOccupied) seat3B.ForeColor = Color.Red;
            else seat3B.ForeColor = Color.Green;

            if (cabins.rows[2].seats[2].isOccupied) seat3E.ForeColor = Color.Red;
            else seat3E.ForeColor = Color.Green;

            if (cabins.rows[2].seats[3].isOccupied) seat3F.ForeColor = Color.Red;
            else seat3F.ForeColor = Color.Green;
            //4


            if (cabins.rows[3].seats.Count > 2)
            {
                if (cabins.rows[3].seats[0].isOccupied) seat4A.ForeColor = Color.Red;
                else seat4A.ForeColor = Color.Green;

                if (cabins.rows[3].seats[1].isOccupied) seat4B.ForeColor = Color.Red;
                else seat4B.ForeColor = Color.Green;

                if (cabins.rows[3].seats[2].isOccupied) seat4E.ForeColor = Color.Red;
                else seat4E.ForeColor = Color.Green;

                if (cabins.rows[3].seats[3].isOccupied) seat4F.ForeColor = Color.Red;
                else seat4F.ForeColor = Color.Green;

            }
            else
            {
                if (cabins.rows[3].seats[0].isOccupied) seat4E.ForeColor = Color.Red;
                else seat4E.ForeColor = Color.Green;

                if (cabins.rows[3].seats[1].isOccupied) seat4F.ForeColor = Color.Red;
                else seat4F.ForeColor = Color.Green;

                seat4A.ForeColor = Color.Orange;
                seat4B.ForeColor = Color.Orange;
            }

        }

        private async Task SetBody()
        {
            reqBody = $$"""
                                {
                    "channelTransactionId": "4bb67043-2b3f-b2a0-55ec-3023a88b29b7",
                    "correlationId": "",
                    "sessionKey": "",
                    "dodCabins": null,
                    "seatMapRequest": {
                        "recordLocator": null,
                        "currencyCode": "USD",
                        "languageCode": "en-US",
                        "isLapChild": false,
                        "isAwardReservation": false,
                        "flightSegments": [
                            {
                                "arrivalAirport": {
                                    "iataCode": "ORD"
                                },
                                "checkInSegment": false,
                                "classOfService": null,
                                "coupons": [
                                    {}
                                ],
                                "departureAirport": {
                                    "iataCode": "KEF"
                                },
                                "departureDateTime": "{{dateTimePicker1.Value.Date.ToString("yyyy-MM-dd hh:mm")}}",
                                "farebasisCode": null,
                                "flightNumber": 913,
                                "isValidSegment": true,
                                "marketingAirlineCode": "UA",
                                "operatingAirlineCode": "UA",
                                "operatingFlightNumber": null,
                                "pricing": "false"
                            }
                        ],
                        "reservationReferences": null,
                        "travelers": null,
                        "bookingCode": null,
                        "dutyCode": null,
                        "bundleCode": null,
                        "channelId": "101",
                        "channelName": null,
                        "hasSSR": false
                    }
                }


                """;
        }

        public async Task<string> GetData(string token)
        {

            var options = new RestClientOptions("https://www.united.com/api/SeatMap/Retrieve")
            {

                MaxTimeout = -1  // 1 second. or whatever time you want.
            };
            var client = new RestClient(options);
            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept-Language", "en-US");
            request.AddHeader("User-Agent", "PostmanRuntime/7.28.4");
            request.AddHeader("X-Authorization-Api", token);
            request.AddHeader("Accept", "*/*");

            request.AddParameter("application/json", reqBody, ParameterType.RequestBody);
            var response = client.Execute(request);
            var content = response.Content;

            return content;



        }

        private async Task<string> GetRestToken()
        {
            var options = new RestClientOptions("https://www.united.com/api/token/refresh")
            {

                MaxTimeout = -1  // 1 second. or whatever time you want.
            };
            var client = new RestClient(options);
            var request = new RestRequest("", Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept-Language", "en-US");
            request.AddHeader("User-Agent", "PostmanRuntime/7.28.4");
            //request.AddHeader("X-Authorization-Api", token);
            request.AddHeader("Accept", "*/*");

           // request.AddParameter("application/json", reqBody, ParameterType.RequestBody);
            var response = client.Execute(request);
            var content = response.Content;

            return content;
        }

        private void getnextdaybtn_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
            dateTimePicker1.Refresh();
            button1.PerformClick();
        }

        private void getprevdaybtn_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
            dateTimePicker1.Refresh();
            button1.PerformClick();
        }
        
        private async Task viewSeatInfo(Seat seat)
        {
            string info =
                $"isAvailable: {seat.isAvailable}" + Environment.NewLine +
                $"isOccupied: {seat.isOccupied}" + Environment.NewLine +
                $"isBlocked: {seat.isBlocked}" + Environment.NewLine +
                $"isBBlocked: {seat.isBBlocked}" + Environment.NewLine +
                $"isHeld: {seat.isHeld}" + Environment.NewLine +
                $"isUmnrSeatShares: {seat.isUmnrSeatShares}" + Environment.NewLine +
                $"isReserveSeat: {seat.isReserveSeat}" + Environment.NewLine +
                $"isUmnrSeat: {seat.isUmnrSeat}" + Environment.NewLine +
                $"isInoperative: {seat.isInoperative}" + Environment.NewLine;


            MessageBox.Show(info, seat.number);
        }

        private async void seat1F_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[0].seats[3]);
        }

        private async void seat1E_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[0].seats[2]);
        }

        private async void seat1B_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[0].seats[1]);
        }

        private async void seat1A_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[0].seats[0]);
        }

        private async void seat2F_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[1].seats[3]);
        }

        private async void seat2E_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[1].seats[2]);
        }

        private async void seat2B_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[1].seats[1]);
        }

        private async void seat2A_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[1].seats[0]);
        }

        private async void seat3F_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[2].seats[3]);
        }

        private async void seat3E_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[2].seats[2]);
        }

        private async void seat3B_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[2].seats[1]);
        }

        private async void seat3A_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[2].seats[0]);
        }

        private async void seat4F_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[3].seats[0]);
        }

        private async void seat4E_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[3].seats[2]);
        }

        private async void seat4B_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[3].seats[1]);
        }

        private async void seat4A_Click(object sender, EventArgs e)
        {
            await viewSeatInfo(unitedResponse.cabins.FirstOrDefault().rows[3].seats[0]);
        }
    }
}
// <auto-generated/>
using Marqeta.Core.Sdk.Acceptedcountries;
using Marqeta.Core.Sdk.Accountholdergroups;
using Marqeta.Core.Sdk.Authcontrols;
using Marqeta.Core.Sdk.Autoreloads;
using Marqeta.Core.Sdk.Balances;
using Marqeta.Core.Sdk.Banktransfers;
using Marqeta.Core.Sdk.Bulkissuances;
using Marqeta.Core.Sdk.Businesses;
using Marqeta.Core.Sdk.Businesstransitions;
using Marqeta.Core.Sdk.Cardproducts;
using Marqeta.Core.Sdk.Cards;
using Marqeta.Core.Sdk.Cardtransitions;
using Marqeta.Core.Sdk.Commandomodes;
using Marqeta.Core.Sdk.Credit;
using Marqeta.Core.Sdk.Depositaccounts;
using Marqeta.Core.Sdk.Digitalwalletprovisionrequests;
using Marqeta.Core.Sdk.Digitalwallets;
using Marqeta.Core.Sdk.Digitalwallettokens;
using Marqeta.Core.Sdk.Digitalwallettokentransitions;
using Marqeta.Core.Sdk.Directdeposits;
using Marqeta.Core.Sdk.Feecharges;
using Marqeta.Core.Sdk.Feedback;
using Marqeta.Core.Sdk.Feerefunds;
using Marqeta.Core.Sdk.Fees;
using Marqeta.Core.Sdk.Fundingsources;
using Marqeta.Core.Sdk.Gpaorders;
using Marqeta.Core.Sdk.Kyc;
using Marqeta.Core.Sdk.Mccgroups;
using Marqeta.Core.Sdk.Merchantgroups;
using Marqeta.Core.Sdk.Peertransfers;
using Marqeta.Core.Sdk.Ping;
using Marqeta.Core.Sdk.Pins;
using Marqeta.Core.Sdk.Programreserve;
using Marqeta.Core.Sdk.Programtransfers;
using Marqeta.Core.Sdk.Pushtocards;
using Marqeta.Core.Sdk.Realtimefeegroups;
using Marqeta.Core.Sdk.Rewardprograms;
using Marqeta.Core.Sdk.Serialization.Json;
using Marqeta.Core.Sdk.Serialization.Text;
using Marqeta.Core.Sdk.Simulate;
using Marqeta.Core.Sdk.Transactions;
using Marqeta.Core.Sdk.Users;
using Marqeta.Core.Sdk.Usertransitions;
using Marqeta.Core.Sdk.Velocitycontrols;
using Marqeta.Core.Sdk.Webhooks;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Form;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Multipart;
using Microsoft.Kiota.Serialization.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Marqeta.Core.Sdk {
    /// <summary>
    /// The main entry point of the SDK, exposes the configuration and the fluent API.
    /// </summary>
    public class MarqetaClient : BaseRequestBuilder {
        /// <summary>The acceptedcountries property</summary>
        public AcceptedcountriesRequestBuilder Acceptedcountries { get =>
            new AcceptedcountriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The accountholdergroups property</summary>
        public AccountholdergroupsRequestBuilder Accountholdergroups { get =>
            new AccountholdergroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The authcontrols property</summary>
        public AuthcontrolsRequestBuilder Authcontrols { get =>
            new AuthcontrolsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The autoreloads property</summary>
        public AutoreloadsRequestBuilder Autoreloads { get =>
            new AutoreloadsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The balances property</summary>
        public BalancesRequestBuilder Balances { get =>
            new BalancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The banktransfers property</summary>
        public BanktransfersRequestBuilder Banktransfers { get =>
            new BanktransfersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The bulkissuances property</summary>
        public BulkissuancesRequestBuilder Bulkissuances { get =>
            new BulkissuancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The businesses property</summary>
        public BusinessesRequestBuilder Businesses { get =>
            new BusinessesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The businesstransitions property</summary>
        public BusinesstransitionsRequestBuilder Businesstransitions { get =>
            new BusinesstransitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cardproducts property</summary>
        public CardproductsRequestBuilder Cardproducts { get =>
            new CardproductsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cards property</summary>
        public CardsRequestBuilder Cards { get =>
            new CardsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cardtransitions property</summary>
        public CardtransitionsRequestBuilder Cardtransitions { get =>
            new CardtransitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The commandomodes property</summary>
        public CommandomodesRequestBuilder Commandomodes { get =>
            new CommandomodesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The credit property</summary>
        public CreditRequestBuilder Credit { get =>
            new CreditRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The depositaccounts property</summary>
        public DepositaccountsRequestBuilder Depositaccounts { get =>
            new DepositaccountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The digitalwalletprovisionrequests property</summary>
        public DigitalwalletprovisionrequestsRequestBuilder Digitalwalletprovisionrequests { get =>
            new DigitalwalletprovisionrequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The digitalwallets property</summary>
        public DigitalwalletsRequestBuilder Digitalwallets { get =>
            new DigitalwalletsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The digitalwallettokens property</summary>
        public DigitalwallettokensRequestBuilder Digitalwallettokens { get =>
            new DigitalwallettokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The digitalwallettokentransitions property</summary>
        public DigitalwallettokentransitionsRequestBuilder Digitalwallettokentransitions { get =>
            new DigitalwallettokentransitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The directdeposits property</summary>
        public DirectdepositsRequestBuilder Directdeposits { get =>
            new DirectdepositsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The feecharges property</summary>
        public FeechargesRequestBuilder Feecharges { get =>
            new FeechargesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The feedback property</summary>
        public FeedbackRequestBuilder Feedback { get =>
            new FeedbackRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The feerefunds property</summary>
        public FeerefundsRequestBuilder Feerefunds { get =>
            new FeerefundsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The fees property</summary>
        public FeesRequestBuilder Fees { get =>
            new FeesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The fundingsources property</summary>
        public FundingsourcesRequestBuilder Fundingsources { get =>
            new FundingsourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The gpaorders property</summary>
        public GpaordersRequestBuilder Gpaorders { get =>
            new GpaordersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The kyc property</summary>
        public KycRequestBuilder Kyc { get =>
            new KycRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mccgroups property</summary>
        public MccgroupsRequestBuilder Mccgroups { get =>
            new MccgroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The merchantgroups property</summary>
        public MerchantgroupsRequestBuilder Merchantgroups { get =>
            new MerchantgroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The peertransfers property</summary>
        public PeertransfersRequestBuilder Peertransfers { get =>
            new PeertransfersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ping property</summary>
        public PingRequestBuilder Ping { get =>
            new PingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pins property</summary>
        public PinsRequestBuilder Pins { get =>
            new PinsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The programreserve property</summary>
        public ProgramreserveRequestBuilder Programreserve { get =>
            new ProgramreserveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The programtransfers property</summary>
        public ProgramtransfersRequestBuilder Programtransfers { get =>
            new ProgramtransfersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pushtocards property</summary>
        public PushtocardsRequestBuilder Pushtocards { get =>
            new PushtocardsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The realtimefeegroups property</summary>
        public RealtimefeegroupsRequestBuilder Realtimefeegroups { get =>
            new RealtimefeegroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rewardprograms property</summary>
        public RewardprogramsRequestBuilder Rewardprograms { get =>
            new RewardprogramsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The simulate property</summary>
        public SimulateRequestBuilder Simulate { get =>
            new SimulateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The transactions property</summary>
        public TransactionsRequestBuilder Transactions { get =>
            new TransactionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The users property</summary>
        public UsersRequestBuilder Users { get =>
            new UsersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The usertransitions property</summary>
        public UsertransitionsRequestBuilder Usertransitions { get =>
            new UsertransitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The velocitycontrols property</summary>
        public VelocitycontrolsRequestBuilder Velocitycontrols { get =>
            new VelocitycontrolsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The webhooks property</summary>
        public WebhooksRequestBuilder Webhooks { get =>
            new WebhooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="MarqetaClient"/> and sets the default values.
        /// </summary>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MarqetaClient(IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}", new Dictionary<string, object>()) {
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<FormSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<MultipartSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextHtmlParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<CustomJsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<FormParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl)) {
                RequestAdapter.BaseUrl = "/v3";
            }
            PathParameters.TryAdd("baseurl", RequestAdapter.BaseUrl);
        }
    }
}

# VenueApplication

Application Motivation 

For our project, we chose to do a variation of a ticket management service. While ordinary ticket management services such as Ticketmaster or StubHub simply allow users to post tickets for various venues and events, our ticket management system will be specific to a single venue, such as Beaver Stadium. More stadiums have already stopped using paper tickets and only accept digital tickets, and an increasing number of venues are incorporating faster methods for purchasing merchandise and concessions. It is common now for users to select what they want and pay at a kiosk, without the help of a cashier. This helps crowds get through lines and back to their seats quicker. 

Our idea for our database application is to provide a centralized hub where all these resources can be utilized. Users can purchase tickets, access their digital tickets to get into the game, purchase concessions, and merchandise all from their phones. In addition to be convenient for the consumer, it is also of great benefit to the venue as well. The venue now has centralized data about ticket, concession, and merchandise sales that can be used to generate more accurate analytical reports. These reports allow the venue to make changes to their gameday experience to maximize profits and the experience of the fans. 

 

Requirement Analysis 

- Users administrators create/login to their respective accounts 

- Administrator can post tickets, merchandise, and concessions for sale for each event, updating items depending on price changes and stock available 

- User can browse tickets for an event, sorting by different metrics such as date and price 

- User can add/update payment methods 

- user can purchase a ticket with their account balance, where it will be added to their digital wallet 

- administrator “scans” tickets at event, where they are then removed from the user’s wallet 

- once in venue, user can search for various concessions and merchandise, and a report will be generated showing where the user can locate these items within the venue 

- user purchases concessions/merchandise through their account balance, if they have insufficient funds, the transaction will be cancelled 

- after the event, the administrator can generate a detailed report with various insights such as ticket, concessions, and merchandise sales volume for various event types, times, and dates. 

- User can list their purchased ticket up for sale, at which point other users will be able to see it and purchase it second hand 

 

Functionality Description 

The functionality of this application will be like that of popular ticket sale apps such as Ticketmaster. To start, the user must create an account. If they already have an account, then they can login using their username (or email) and password. There are two types of users; there’s the more traditional user who uses the application to purchase tickets, merchandise, and concessions at the event. There is also an administrative user, who can post tickets for events they are holding at the venue, as well as new merchandise and concessions options available for each event. Before an event, the user can browse tickets for various events, sorting by date or price. After adding a payment method to their account and loading a balance, the user can select tickets they would like to purchase. At this point, the tickets would be added to the user’s digital wallet, and their account balance would be subtracted. The user can access their digital wallet to view their tickets, where they will appear with their event name, seat number, section number.  

The day of the event, the administrator will scan the user’s ticket, after which the status will change to SCANNED and be removed from their wallet. Once in the event, the user can browse the application for various concessions and merchandise. The application will provide locations and store names for where that specific concession or merchandise item is located. Once at that store, the user can use the balance on their account to pay for those items. If the user does not have sufficient funds in their account, the transaction will be cancelled. 

On the administrative side, the venue can view and analyze the data from the event. This includes generating reports that indicate how many tickets were sold, how much concessions and merchandise were purchased, and which stores sold the most items. Using this data, the venue can analyze trends in item transactions and ticket sales over time for various events. Across events, the administrator can sort to see which event types generated the most sales. 

Another feature on the user side is the ability to resell tickets to other users. A user can list their ticket on the resale market for a new price, where other users can view them and purchase them. Once sold, the ticket will transfer from the seller’s wallet to the buyer’s wallet, and the seller’s account balance will get credited for the sale. 

 

Data Description 

For the users, we will need to collect some basic information such as their first and last name, birthday, email, and payment information. For administrators, we will also record similar information to allow administrators to log in and use the application. The database will record credit card numbers for each payment method for the user to load their account balance into the application. We will also record data for each user’s wallet, which shows their account balance and which tickets they have purchased. 

For each event, data such as the date, event type, start time, and description will be recorded in order to specify the event that the user is buying a ticket for. For each ticket, we will record information such as the which event it is for, the section, seat number, price, that status of the ticket (ex. expired, for sale by venue, for sale by second-hand user, sold, pending), and which user it belong to – if, or when, the ticket gets purchased by a user. 

On the day of the event, the most important data to store is which stores are available, and which products those stores have to sell to fans. We will collect data on each store in the venue, including which type of store it is (merchandise or concessions), and where it is located. For each item available for sale, we will record which store the item can be found, as well as the name of the item. Finally, we will also record data for each transaction that takes place the day of the event, which is crucial for the administration of the venue to view insights on sales. We will record information such as who(which user), what(which item) where(which store) when, and how(which payment method) a user bought each item. This will allow the administrators of the event to collect enough data in order to filter and sort by several different metrics. 

# AuctionApp

The Index page should list the current (future) and past catalogues in order of newest to oldest.  The catalogues should also include a filter for catalogue type (specialty, estate etc).  You will need to determine the best method to achieve this given the limited number of categories.
When no search parameters are provided, all catalogues should be displayed in order of date, then by catalogue name.  This will change to only show matching catalogues as when a specific category is selected.  As part of your design, you will need to determine what layout will look best to achieve this and use only bootstrap classes to construct your page and position the elements.  
Marks will be awarded based on the quality of the search implementation, the complexity of the user interface as well as demonstrating a good implementation of bootstrap by making good use of the documentation and the many class styles available.  You must avoid creating your own styles where possible. Where a colour/size is not desired, you must use the Site.css file to create a matching override for the bootstrap class you want to modify. However, you should first utilise the many bootstrap utilities such as sizing.

<img width="410" alt="Screenshot 2024-09-19 at 11 28 01 am" src="https://github.com/user-attachments/assets/2c8397fc-b1c0-4fc7-9d3a-d92417c9e03c">

Clicking on a catalogue from the index page should navigate the user to the list of Lots available from the auction catalogue.  This will include: Lot No, title, price range and a small image.   If the lot has already been sold then this should be clearly visible including the final sale price.   In addition, the list will need to be searchable via keyword that searches both the lot title and description for matching lots.  When no matches are found, then you should indicate this to the user (eg, show the words “No matching lots found”).  Always show the lots in ascending order of lot number, even during a keyword search. At the bottom of the page should be a button to return the user to the list of available catalogues in Task 1.

<img width="410" alt="Screenshot 2024-09-19 at 11 28 23 am" src="https://github.com/user-attachments/assets/f2d93eba-31da-496c-8c78-ec0e2db93d6e">

When the user clicks on a lot from the catalogue, the selected lot including ALL its details should appear on this page.  This includes the Lot number, title, range, description, image(s) and status.  To complete this task successfully, you will need to work out how to write the @razor code to display one or many images depending on the lot selected. 

The last 10% of your marks will be awarded based on the accuracy and validity of your html. Make sure that your dynamic pages generate HTML with all the required attributes and that your elements are nested correctly.

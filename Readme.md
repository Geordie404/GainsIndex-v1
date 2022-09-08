GainsIndex-v1 https://gainsindex-v1.azurewebsites.net/

# GAINS INDEX V1
This is a paired programming collaboration between two weight-lifting enthusiasts wanting to refine both their coding skills and productivity in the gym!

Ever tried keeping track of your lifting routine in a notebook or on an excel sheet on your phone? 
Tried pressing those little fields scrambling for the typing cursor? 
Or forbid... using a paid exercise app...

Gains Index provides a simple, user-friendly way to track your lifting routines.

Building GainsIndex has been a good step in our (@almondflour2 & @geordie404) experience as aspiring web developers and further motivation for us to be more knowledgeable both behind the keyboard and under the cold metal bar in the squat rack :)

## STACK
                              
ASP.NET Model View Controller | Web Development Framework
----------------------------- | ----------------------------
[Model] SQLite                | Database Model
[View] HTML & CSS + JQuery    | Frontend UI
[Controller] C#	              | Data Access and Application Flow
Microsoft Azure               |	Cloud Publishing
GitHub	                      | Version Control and Workflow

### PLANS FOR V2 
- Keep track of working weight progress in a visual expression of the data
- Calculated working weight suggestions
- Remove hardcoded Geo/Bella and create custom database per user

## HOME INDEX PAGE 
- Design plans: a home page that shows
                - Title of Gains Index V1
                - github repo link
                - Link to catalog (where create and advanced edit links are)
                - Reports todays day of week
                - Shows exercises for that day of the week 
                    - Toggle between Bella / Geo
                    - Each exercise can be clicked to grey out / signify it is complete w/javascript
                    - Each exercise has link to simple edit to update working weight / log notes

- CSS Conventions for specific pages
    - .woi -> workout index
    - .dtl -> workout details 
    - .clg -> catalog
    - .crt -> create
    - .edt -> exercise edit

### PROGRESS LOG 
- AUG 23 2022
    - Overhauled idea for recipe book into workout index
    - added custom css file for Exercise Home 
    - created css conventions for specific pages
    - created design plan
    - added exercise cards
    - formatted header
    - updated DB to have actual exercises
    - added gitignore for bin & obj

- Where to start:
    - add filter to Exercise Home for days 

- AUG 24 2022
    - added catalog page
    - started work on a days filter for the home page 
    - created two new branches 

- AUG 30 2022
    - added log and detals page
    - updated home and catalog pages

- Aug 31 2022
    - refined Jquery on home page for day filter and finished functionality
    - added large changed to CSS sitewide
    - cleaned up HTML on all views
    - added About page

- Sep 1 2022
    - clean up headers
    - added CSS to Home
    - cleaned up views for Edit, Log, Details
    - hide inputs in Log to add functionality

- Sep 2 2022
    - changed display of catalog to be more compact
    - changed cards on catalog
    - image for submit functionality on catalog
    - log return to home on save

- Sep 5 2022
    - updated workout cards on the home and catalog pages
    - cleaned up css universally
    - added more css files for compartmentalization
    - added button for log

- Sep 6 2022
    - reformatted:
        - delete view
        - catalog links & filter
        - index links 
        - about view css
        - disable auth
        - jump links on edit and delete

- Sep 7 2022
    - reformatted:
        - catalog view cards 
        - home view card size
        - aligned index links to the right
        - overhaul on create page
        - minor tweaks to css that fixed the rest of the css issues...





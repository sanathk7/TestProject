@Checkout
Feature:4Checkout

Scenario: User Address Details and Order
    Given User is on the Checkout page
    When User enters First Name "<firstname>", Last Name "<lastname>", and Zip Code "<zipcode>"
    Then Clicks on Continue

    Examples: 
    | firstname | lastname | zipcode |
    | sanath    | kumar    | 553909 |



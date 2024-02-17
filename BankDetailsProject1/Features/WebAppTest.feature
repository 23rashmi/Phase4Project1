Feature: WebAppTest

A short summary of the feature



@mytag
Scenario: Successful User Login
    Given a user with valid username "rashmi123" and valid password "rashmi@123"
    When the Login method is called
    Then the result should be Login Success

@mytag
Scenario: Unsuccessful User Login
    Given a user with valid username "invalid_user" and valid password "invalid"
    When the Login method is called
    Then the result should be Login Failed

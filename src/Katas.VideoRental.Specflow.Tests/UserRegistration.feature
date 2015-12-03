Feature: UserRegistration
	Features related with users and user management


Scenario: User registring to videoclub
Given user A enters name, age, email address
And user A is more than 18 years old
Then library registers an entry for user A
And sends user A a welcome email

Scenario: User donates a copy of a non-existing title to the library
Given user A is a member of the videoclub
And user A donates a new title
And enters title, director and year of release
And user B has a wishlist with title on it
Then the library creates a new entry for title
And user A receives 10 loyalty points
And user B receives a notification

Scenario: User donates another copy of an existing title to the library
Given user A is a member of the videoclub
And user A donates a new video
And enters title, director and year of release
And user B has a wishlist with title on it
Then the library increases the count for title by 1
And user A receives 10 loyalty points
And user B receives a notification

Scenario: user A performs a simple rental
Given user A is a member of the videoclub
And title is available for rental
Then user A can borrow the available copy
And user A gets charged £2.50
And library registers the copy as unavailable

Scenario: Returning a rental copy
Given user A performs a simple rental
And user A returns title
And user B is number 1 on the waiting list
Then library registers copy as available
And sends a thank you email to user A
And sends a title available email to user B

Scenario: Returning the wrong rental copy
Given user A performs a simple rental
And user A returns title
Then library sends an email to user with a warning

Scenario: Failed to return a rental copy
Given user A performs a simple rental
And 16 days later copy is still not returned
Then library sends an email to the user A
And prevents user from rental further copies
And user A looses 2 priority points

Scenario: Reserving a rental copy
Given user A is a video library member
And user A has more than 5 priority points
And user A adds title to user A wishlist
And user B is number 1 in the waiting list
And user A is number 2 in the waiting list
And user A requests to have priority access
And title becomes available for rental
Then user A gets a notification for availability
And user B does not get a notification for availability

Scenario: Sending newsletter to all members
Given user A is a administrator user
And user B is a member user
And user C is a member user
And user A sends a newsletter email
Then user B receives a newsletter email
And user C receives a newsletter email
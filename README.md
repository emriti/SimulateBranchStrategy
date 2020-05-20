# Simulate Branch Strategy

### Background

This is a sample mechanism for branching strategy, we will use sample use case to exhibit the strategy.

### Use case

##### With Branch

###### Branching in the beginning

In the beginning we initialize a project and saved it as a master branch, after that we enter sprint1 and we create new branch based on master branch and we called it sprint1

> master -> sprint1

After we finish our sprint, we then merge sprint1 branch into master branch.

> sprint1 -> master

###### Branching of new sprints

After we finish our sprint 1 and we want to begin with new sprint (sprint 2), thus we create a new branch based on master branch and we called it branch sprint 2. We worked on whatever is being done in this sprint into this branch.

> master -> sprint2

###### Bug-fixing of previous sprints

If we found bugs that related to previous sprints, then we need to create a new branch from that branch and for example we called new bugfix-pbi5-sprint1.

> sprint1 -> bugfix-pbi5-sprint1

After we finish with our bug-fixing, then we merge the bugfix-pbi5-sprint1 branch into sprint1 branch and sprint2 branch.

> bugfix-pbi5-sprint1 -> sprint2

> bugfix-pbi5-sprint1 -> sprint1

##### With Tags


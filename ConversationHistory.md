# Project Conversation History

## March 15, 2024
### Topic: Project Overview - Training Battles
#### Project Description
Training Battles is a competitive fitness tracking platform with the following components:
- Backend: .NET API (current workspace)
- Frontend: .NET MAUI
- Database: Azure SQL
- Integration with fitness devices (Fitbit, Garmin, Apple)

#### Core Features
1. User Management
   - Authentication/Authorization
   - Profile management
   - Device connection/sync

2. Battle System
   - 1v1 challenges
   - Group battles (up to 20 people - paid tier)
   - Community battles (unlimited members)
   - Custom timeframe settings
   - Statistic filtering

3. Leaderboard System
   - Real-time updates
   - Multiple sorting criteria
   - Automatic sync with device data
   - Geographic filtering/validation

4. Community Features
   - Group creation/management
   - Geographic-based communities
   - Business-based communities (gyms, clubs)
   - Custom profiles for users/groups/communities
   - Achievement badges system

5. Location Services
   - GPS data collection (opt-in)
   - Geofencing for community validation
   - Training location verification

#### Technical Requirements
- Azure SQL Database integration
- Fitness device API integrations
- Real-time leaderboard updates
- Location services
- Secure authentication
- Tiered access control

#### Next Steps
1. Design database schema
2. Set up initial API structure
3. Implement authentication
4. Create core entity models
5. Develop device integration services

### Initial Discussion
Human: [Previous conversation about maintaining context]
Assistant: [Previous response about maintaining context]

## March 15, 2024 (continued)
### Topic: Initial Backend Setup

#### Completed Steps:
1. Added necessary NuGet packages:
   - Entity Framework Core
   - SQL Server provider
   - JWT Bearer authentication
   - Swagger/OpenAPI

2. Created basic folder structure:
   - Models (Entities & DTOs)
   - Services
   - Controllers
   - Data
   - Configurations
   - Utilities

3. Updated Program.cs with:
   - CORS configuration
   - Basic middleware setup
   - Controller support

#### Next Steps:
1. Create database models based on requirements
2. Set up Entity Framework DbContext
3. Create initial migrations
4. Implement authentication system
5. Begin API endpoint development

Would you like to proceed with creating the database models next?

### Topic: Database Models Planning

Based on the requirements, we'll need the following core entities:

1. User
   - Basic profile info
   - Authentication details
   - Device connection settings
   - Subscription tier
   - Location settings

2. Battle
   - Type (1v1, Group, Community)
   - Start/End dates
   - Status
   - Target statistic
   - Location requirements

3. Group
   - Name/Description
   - Member list (max 20 for paid)
   - Admin users
   - Creation date
   - Status

4. Community
   - Name/Description 
   - Type (Geographic/Business)
   - Location data
   - Member list
   - Admins
   - Status

5. DeviceIntegration
   - User reference
   - Device type
   - Auth tokens
   - Last sync

6. WorkoutData
   - User reference
   - Timestamp
   - Activity type
   - Stats/metrics
   - Location data
   - Device source

7. Leaderboard
   - Battle reference
   - Rankings
   - Update timestamp
   - Visibility settings

8. Achievement
   - Name/Description
   - Criteria
   - Icon/Badge
   - Unlock conditions

Would you like me to start implementing these models as C# classes?
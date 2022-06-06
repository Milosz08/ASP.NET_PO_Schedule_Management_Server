﻿namespace asp_net_po_schedule_management_server.Utils
{
    /// <summary>
    /// Klasa przechowująca wszystkie endpointy (punkty końcowe z treścią) aplikacji do komunikacji z web klientem.
    /// </summary>
    public static class ApiEndpoints
    {
        // kontroler AuthController
        public const string LOGIN = "login";
        public const string REGISTER = "register";
        public const string CHANGE_PASSWORD = "change-password";
        public const string REFRESH_TOKEN = "refresh-token";
        public const string SEND_RESET_PASSWORD_TOKEN = "reset-password-email";
        public const string CONFIRM_RESET_TOKEN = "confirm-reset-password";
        public const string RESET_PASSWORD = "reset-password";
        public const string SEND_EMAIL_REGISTER = "send-emails-register";
     
        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler FileController
        public const string GET_AVATAR = "get-avatar";
        public const string ADD_OR_CHANGE_AVATAR = "add-or-change-avatar";
        public const string DELETE_AVATAR = "delete-avatar";
        public const string GET_ALL_AVATARS = "user-avatars";
        
        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler UsersController
        public const string UPDATE_USER = "update-user";
        public const string GET_ALL_USERS_PAGINATION = "all-users";
        public const string GET_ALL_EMPLOYEERS_SCHEDULE = "all-employeers-schedule";
        public const string GET_ALL_TEACHERS_BASE_DEPT_AND_SUBJ = "all-teachers-base-dept-and-subj";
        public const string GET_DASHBOARD_DETAILS = "dashboard-details";
        public const string GET_USER_BASE_ID = "user-base-id";

        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler HelperController
        public const string GET_AVAILABLE_PAGINATIONS = "available-paginations";
        public const string GET_AVAILABLE_STUDY_TYPES = "available-study-types";
        public const string GET_AVAILABLE_ROOM_TYPES = "available-room-types";
        public const string GET_AVAILABLE_STUDY_DEGREES = "available-study-degrees";
        public const string GET_AVAILABLE_ROLES = "available-roles";
        public const string GET_AVAILABLE_SEMESTERS = "available-semesters";
        public const string GET_AVAILABLE_SUBJECT_TYPES = "available-subject-types";
        public const string GET_AVAILABLE_SEM_BASE_STUDY_GROUP = "available-sem-base-study-group";
        public const string GET_AVAILABLE_DEGREES_BASE_STUDY_SPEC = "available-degrees-base-study-spec";
        public const string CONVERT_SCHEDULE_DATA_NAMES_TO_IDS = "convert-schedule-data-from-names-to-ids";
        public const string CONVERT_SCHEDULE_DATA_IDS_TO_NAMES = "convert-schedule-data-from-ids-to-names";
        
        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler DepartmentsController
        public const string ADD_DEPARTMENT = "add-department";
        public const string UPDATE_DEPARTMENT = "update-department";
        public const string GET_ALL_DEPARTMENTS_LIST = "all-departments-list";
        public const string GET_ALL_DEPARTMENTS_PAGINATION = "all-departments";
        public const string GET_ALL_DEPARTMENTS_SCHEDULE = "all-departments-schedule";
        public const string GET_DEPARTMENT_BASE_ID = "department-base-id";
        
        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler CathedralsController
        public const string ADD_CATHEDRAL = "add-cathedral";
        public const string UPDATE_CATHEDRAL = "update-cathedral";
        public const string GET_ALL_CATHEDRALS_BASE_DEPT = "all-cathedrals-dept";
        public const string GET_ALL_CATHEDRALS_PAGINATION = "all-cathedrals";
        public const string GET_ALL_CATHEDRALS_SCHEDULE = "all-cathedrals-schedule";
        public const string GET_CATHEDRAL_BASE_ID = "cathedral-base-id";
        
        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler StudySpecController
        public const string ADD_STUDY_SPECIALIZATION = "add-study-spec";
        public const string UPDATE_STUDY_SPECIALIZATION = "update-study-spec";
        public const string GET_All_STUDY_SPEC_BASE_DEPT = "all-study-specs-dept";
        public const string GET_ALL_STUDY_SPECS = "all-study-specs";
        public const string GET_ALL_STUDY_SPECS_SCHEDULE = "all-study-specs-schedule";
        public const string GET_AVAILABLE_STUDY_SPECS_BASE_DEPT = "available-study-specs-base-dept";
        public const string GET_STUDY_SPECIALIZATION_BASE_ID = "study-spec-base-id";
        
        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler StudyRoomsController
        public const string ADD_STUDY_ROOM = "add-study-room";
        public const string UPDATE_STUDY_ROOM = "update-study-room";
        public const string GET_ALL_STUDY_ROOMS = "all-study-rooms";
        public const string GET_ALL_STUDY_ROOMS_SCHEDULE = "all-study-rooms-schedule";
        public const string GET_ALL_STUDY_ROOMS_BASE_DEPT = "all-study-rooms-base-dept";
        public const string GET_STUDY_ROOM_BASE_ID = "study-room-base-id";
        
        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler StudySubjectController
        public const string ADD_STUDY_SUBJECT = "add-study-subject";
        public const string UPDATE_STUDY_SUBJECT = "update-study-subject";
        public const string GET_ALL_STUDY_SUBJECTS = "all-study-subjects";
        public const string GET_ALL_STUDY_SUBJECT_BASE_DEPT = "all-study-subjects-dept";
        public const string GET_AVAILABLE_SUBJECTS_BASE_DEPT = "available-subjects-base-dept";
        public const string GET_STUDY_SUBJECT_BASE_ID = "study-subject-base-id";
        
        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler StudyGroupController
        public const string ADD_STUDY_GROUP = "add-study-group";
        public const string GET_ALL_STUDY_GROUPS_PAGINATION = "all-study-groups";
        public const string GET_AVAILABLE_GROUPS_BASE_SPEC_AND_SEM_SCHEDULE = "available-groups-base-study-spec-and-sem";
        public const string GET_AVAILABLE_GROUPS_BASE_SPEC = "available-groups-base-study-spec";
        public const string GET_ALL_GROUPS_BASE_DEPT = "study-groups-base-dept";
        
        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler ScheduleSubjectsController
        public const string ADD_SCHEDULE_ACTIVITY = "add-new-schedule-activity";
        public const string GET_SCHEDULE_SUBJECTS_BASE_GROUP_ID = "all-schedule-subjects-base-group";
        public const string GET_SCHEDULE_SUBJECTS_BASE_TEACHER_ID = "all-schedule-subjects-base-teacher";
        public const string GET_SCHEDULE_SUBJECTS_BASE_ROOM_ID = "all-schedule-subjects-base-room";
        public const string GET_SCHEDULE_SUBJECT_DETAILS = "schedule-subject-details";
        
        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler TimeManagementController
        public const string GET_STUDY_YEARS = "all-study-years";
        public const string GET_WEEKSDATA_BASE_CURR_YEAR = "all-weeks-data-base-curr-year";

        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler SearchContentController
        public const string GET_MASSIVE_QUERY_RESULT = "massive-query-result";
        
        //--------------------------------------------------------------------------------------------------------------
        
        // kontroler ContactMessagesController
        public const string ADD_NEW_CONTACT_MESSAGE = "add-contact-message";
        public const string GET_ALL_CONTACT_MESSAGE_ISSUE_TYPES = "all-contact-message-issue-types";
        public const string GET_ALL_MESSAGES_BASE_CLAIMS = "all-messages-base-user-claim";
        public const string GET_MESSAGE_BASE_ID_AND_CLAIMS = "message-base-id-and-claim";
        
        //--------------------------------------------------------------------------------------------------------------
        
        // wspólne
        public const string DELETE_MASSIVE = "delete-massive";
        public const string DELETE_ALL = "delete";
    }
}
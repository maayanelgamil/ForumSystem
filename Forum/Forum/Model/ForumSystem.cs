
using System;
using System.Collections.Generic;

public class ForumSystem
{

    List<Forum> contained;
    List<GuestUser> contains;

    /**
	 * 
	 * @param ForumId
	 */
    public void findForum(int ForumId)
    {
        // TODO - implement ForumSystem.findForum
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param ForumId
	 * @param subForumId
	 * @param subject
	 * @param UserId
	 */
    public void newDisscussion(int ForumId, int subForumId, int subject, int UserId)
    {
        // TODO - implement ForumSystem.newDisscussion
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param Forumid
	 * @param SubForumId
	 * @param subject
	 * @param content
	 * @param UserName
	 */
    public void newOpeningMessage(int Forumid, int SubForumId, int subject, int content, int UserName)
    {
        // TODO - implement ForumSystem.newOpeningMessage
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param guestId
	 */
    public void findGuest(int guestId)
    {
        // TODO - implement ForumSystem.findGuest
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param ForumId
	 * @param ChoosenRole
	 */
    public void getManagerList(int ForumId, int ChoosenRole)
    {
        // TODO - implement ForumSystem.getManagerList
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param ForumId
	 * @param UserName
	 * @param Password
	 * @param GuestId
	 */
    public void newUserAccount(int ForumId, int UserName, int Password, int GuestId)
    {
        // TODO - implement ForumSystem.newUserAccount
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param ForumId
	 * @param UserName
	 * @param content
	 * @param choosenRole
	 * @param SubForumMngrId
	 */
    public void addComplaint(int ForumId, int UserName, int content, int choosenRole, int SubForumMngrId)
    {
        // TODO - implement ForumSystem.addComplaint
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param ForumId
	 * @param UserName
	 */
    public void checkManagerPolicy(int ForumId, int UserName)
    {
        // TODO - implement ForumSystem.checkManagerPolicy
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param ForumId
	 * @param oldManagerId
	 * @param newManagerName
	 */
    public void replaceManager(int ForumId, int oldManagerId, int newManagerName)
    {
        // TODO - implement ForumSystem.replaceManager
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param ForumId
	 */
    public void retriveUsersList(int ForumId)
    {
        // TODO - implement ForumSystem.retriveUsersList
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param ForumId
	 * @param UserNames
	 */
    public void newFriendsGroup(int ForumId, int UserNames)
    {
        // TODO - implement ForumSystem.newFriendsGroup
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param ForumId
	 * @param freindsGroupId
	 * @param UserName
	 * @param title
	 * @param data
	 */
    public void newGroupMessage(int ForumId, int freindsGroupId, int UserName, int title, int data)
    {
        // TODO - implement ForumSystem.newGroupMessage
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param ForumId
	 * @param UserName
	 */
    public void retriveFriendsGroupsList(int ForumId, int UserName)
    {
        // TODO - implement ForumSystem.retriveFriendsGroupsList
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param forumId
	 * @param content
	 */
    public void searchMessage(int forumId, int content)
    {
        // TODO - implement ForumSystem.searchMessage
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param ForumId
	 * @param subForumId
	 * @param discussionId
	 * @param content
	 */
    public void addResponseMessage(int ForumId, int subForumId, int discussionId, int content)
    {
        // TODO - implement ForumSystem.addResponseMessage
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param ForumIdm
	 * @param SubForumId
	 * @param subject
	 * @param messageId
	 */
    public void retriveMessage(int ForumIdm, int SubForumId, int subject, int messageId)
    {
        // TODO - implement ForumSystem.retriveMessage
        throw new NotImplementedException();
    }

}
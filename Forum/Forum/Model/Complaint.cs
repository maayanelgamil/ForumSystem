
using System;
using System.Collections.Generic;

public class Complaint
{

    List<Manager> recievedBy;
    SubForumManager refersTo;
    UserAccount complainedBy;
    private string Content;

    /**
	 * 
	 * @param content
	 */
    public void createComplaint(int content)
    {
        // TODO - implement Complaint.createComplaint
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param mngr
	 */
    public void associateWithManagerComplained(int mngr)
    {
        // TODO - implement Complaint.associateWithManagerComplained
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param U
	 */
    public void associateWithUser(int U)
    {
        // TODO - implement Complaint.associateWithUser
        throw new NotImplementedException();
    }

    /**
	 * 
	 * @param manager
	 */
    public void associateWithManager(int manager)
    {
        // TODO - implement Complaint.associateWithManager
        throw new NotImplementedException();
    }

}
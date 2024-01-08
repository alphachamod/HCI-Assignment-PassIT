Public Class Exams
    ' Public property to access lblAttempts


    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles applybtn.Click
        eligibilty_confirmation.Show()
        lblAttempts.Text = "Attempted"
    End Sub

    Private Sub btn_stnd_Click(sender As Object, e As EventArgs) Handles more_info_standard.Click
        MessageBox.Show("Standard Exam (Theory and Practical):
Theory Test: This test assesses the candidate's knowledge of the Highway Code, road signs, and general driving theory. It includes a multiple-choice section and a hazard perception test.
Practical Test: The practical driving test evaluates the candidate's ability to apply their knowledge and skills on the road. It includes various maneuvers, independent driving, and possibly an emergency stop.
Requirements: To take the practical test, individuals must have a valid provisional license, passed the theory test, and completed sufficient driving lessons.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_pass_Click(sender As Object, e As EventArgs) Handles more_info_passplus.Click
        MessageBox.Show("Pass Plus Exams:
Overview: Pass Plus is a voluntary training course designed for new drivers to further develop their driving skills and gain experience.
Content: The Pass Plus course covers topics such as driving in different weather conditions, on rural roads, at night, on dual carriageways, and on motorways.
Benefits: Completing the Pass Plus course may lead to insurance discounts and can help boost confidence and competence in various driving scenarios.
Eligibility: Any driver with a full UK driving license can take the Pass Plus course, but it's often recommended for newly qualified drivers. You must pass the Introductory Exam", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btn_drive_Click(sender As Object, e As EventArgs) Handles more_info_drivingtest.Click
        MessageBox.Show("If you've already completed the Pass Plus course and want to take a driving test, you would typically follow the standard process for booking a practical driving test. Here's a general overview:

Check Eligibility:

Ensure you meet the eligibility criteria, including having a valid full UK driving license.
Choose a Test Center:

Select a test center where you want to take your practical driving test.
Book Online:

Visit the official government website for driving tests and book your practical driving test online.
Provide Details:

Fill in the required details, including your driving license number and personal information.
Select a Time and Date:

Choose a suitable time and date for your practical driving test. Slots are usually available on weekdays and weekends.
Payment:

Pay the required fee for the practical driving test. Payment can usually be made online using a debit or credit card.
Confirmation:

After successfully booking your practical test, you'll receive a confirmation email with details about the date, time, and location of your test.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
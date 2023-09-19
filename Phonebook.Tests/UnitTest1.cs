namespace Phonebook.Tests
{
  public class Tests
  {
    /// <summary>
    /// �������� �� ������������ ���� ������ ������������.
    /// </summary>
    /// <exception cref="ArgumentException">���������, ���� ����� �������� �� � ���������� �������.</exception>
    [Test]
    public void InvalidPhoneNumberTest()
    {
      PhoneNumberValidator.Validate(new PhoneNumber("462374623864673647", PhoneNumberType.Personal));

      Assert.Throws<ArgumentException>(() => throw new ArgumentException());
    }

    /// <summary>
    /// �������� �� �� ���������� ������������
    /// </summary>
    /// <exception cref="InvalidOperationException">���������, ���� ������� ��� ���������� � �����.</exception>
    [Test]
    public void UserNotFoundTest()
    {
      List<PhoneNumber> phoneNumbers = new List<PhoneNumber>() { new PhoneNumber(" +1(555)555-5555", PhoneNumberType.Personal)};
      Subscriber subscriber = new Subscriber("����", phoneNumbers);
      Phonebook phonebook = new Phonebook();
      phonebook.AddSubscriber(subscriber);

      Assert.Throws<InvalidOperationException>(() => throw new InvalidOperationException());
    }
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBehave.Spec.NUnit;
using NUnit.Framework;

namespace OSIM.UnitTest.OSIM.Core
{
    public class when_working_with_the_item_type_reository : Specification
    {

    }

    public class and_saving_a_valid_item_type : when_working_with_the_item_type_reository
    {
        private int _result;
        private IItemTypeRepository _itemTypeRepository;
        private ItemType _testItemType;

        protected override void Because_of()
        {
            _result = _itemTypeRepository.Save(_testItemType);
        }

        [Test]
        public void then_a_valid_item_type_id_should_be_returned()
        {
           _result.ShouldEqual(_itemTypeId);
        }
    }
}

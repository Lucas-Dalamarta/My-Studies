import { ActiveMenuProvider } from './Components/ActiveMenuContext'

import Navbar from './Components/Navbar'
import NavItem from "./Components/NavItem";
import DropdownMenu from "./Components/DropdownMenu";

import { ReactComponent as BellIcon } from "./icons/bell.svg";
import { ReactComponent as MessengerIcon } from "./icons/messenger.svg";
import { ReactComponent as PlusIcon } from "./icons/plus.svg";
import { ReactComponent as CaretIcon } from "./icons/caret.svg";

function App() {
  return (
    <ActiveMenuProvider>
      <Navbar>
        <NavItem icon={<PlusIcon />} />
        <NavItem icon={<BellIcon />} />
        <NavItem icon={<MessengerIcon />} />

        <NavItem icon={<CaretIcon />}>
          <DropdownMenu />
        </NavItem>
      </Navbar>
    </ActiveMenuProvider>
  );
}

export default App;

const Navbar = ({children}) => {
  return (
    <nav className="navbar">
      <ul className="navbar-nav">{children}</ul>
    </nav>
  )
}

export default Navbar